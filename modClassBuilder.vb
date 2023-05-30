Option Explicit On

Imports System.DirectoryServices
Imports System.IO

Module modClassBuilder
    ' This module contains routines and functions to support the ClassBuilder application
    Dim FSO As System.IO.FileSystemInfo


    Public Sub LoadProject(sFolder As String, sFileName As String)
        ' This routine will load Project information
        ' Find the sFolder based on the name in the form
        Dim BaseFolderName = "C:\Projects\VBNet\EmpireVBNet\EmpireVBNet"
        Dim MyFiles() As System.IO.FileInfo
        Dim FldInfop As New System.IO.DirectoryInfo(BaseFolderName)
        Dim FilePath As String
        FilePath = ""
        MyFiles = FldInfop.GetFiles("celltype*.vb", IO.SearchOption.AllDirectories)
        Debug.Print("LoadProject: VB File Ct:" & MyFiles.Count().ToString())
        For Each MySearchFile In MyFiles
            FilePath = ""
            FilePath = MySearchFile.DirectoryName + "\" + MySearchFile.Name
            Debug.Print("LoadProject:" + FilePath)
            Call ProcessFile(MySearchFile)
        Next

    End Sub

    Private Sub ProcessFile(MyFile As FileInfo)
        ' This routine will read a file and parse out module, class, or form.
        ' look for class
        Dim sMyClass As String = ""

        Call ProcessClassInFile(MyFile, sMyClass, 0)
    End Sub
    Private Sub ProcessClassInFile(MyFile As FileInfo, pClassName As String, pStartPosition As Long)
        ' this routine will process a file that starts with Class for the specified Class Name
        ' MyFile is the FileInfo object for the file to be searched.
        ' pStartPosition is the starting byte position to be searched.  The default should be zero.  
        '                This field will contain the end position of "End Class".  A -1 will be returned if no class is found.
        ' pClassName is the name of the class that was processed.

        ' open the FileStream
        Dim SR As StreamReader = MyFile.OpenText()

        ' search each line of FS to find the word Class that is Not part of a comment and Not "End Class"
        Dim sFileLine As String
        Dim bFoundStartOfClass As Boolean = False
        Dim iStartPosition As Long = 0

        ' position stream at the pStartPosition
        'SR.Seek(pStartPosition, 0)
        Try
            'Do While ((SR.Peek() <> -1) & (bFoundStartOfClass = False))
            Do While (bFoundStartOfClass = False)
                iStartPosition = SR.BaseStream.Position()
                sFileLine = Trim(SR.ReadLine.ToString())
                Debug.Print("Input Line: Pos=" & iStartPosition.ToString() & " S=" & sFileLine)
                Debug.Print("CLASS pos=" & InStr(1, UCase(sFileLine), "CLASS ").ToString())
                ' look for a remark symbol as the first character.  Skip line if present.
                If Left(sFileLine, 1) = "'" Then
                    ' we found remark as first part of line, so ignore
                    Debug.Print("Line starts with ' remark statement")
                ElseIf Left(UCase(sFileLine), 3) = "REM" Then
                    ' we found the REM statement, ignore.
                    Debug.Print("Line starts with REM remark statement")
                ElseIf InStr(1, UCase(sFileLine), "CLASS ") > 0 Then
                    ' found the CLASS keyword, record the start position.
                    bFoundStartOfClass = True
                    Debug.Print("Found CLASS statement")
                End If

            Loop
        Catch ex As Exception

        End Try
        ' See if we found a class
        If bFoundStartOfClass = True Then
            ' we found class now parse the class line
            Dim sClassName As String
            Dim iPos As Int16
            Dim iPos2 As Int16
            ' find start of CLASS statement
            iPos = InStr(UCase(sFileLine), "CLASS ")
            ' find end of Class name
            iPos2 = InStr(iPos + 6, sFileLine, " ")
            If iPos2 = 0 Then
                ' space not found, so it might be the end of the string
                iPos2 = Len(sFileLine)
            End If
            sClassName = Mid$(sFileLine, iPos + 6, iPos2 - iPos + 7 + 1)

        End If
    End Sub
End Module