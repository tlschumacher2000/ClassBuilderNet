Public Class xMyClass
    Dim mvarClassName As String
    Dim mvarIsPublic As Boolean
    Dim mvarProperties As Collection
    Dim mvarMethods As Collection
    Dim mvarClassFilename As String
    Dim mvarClassStartPos As Long

    Public Sub New()
    End Sub

    Public Function Create(pClassName As String, pIsPublic As Boolean, pProperties As Collection, pMethods As Collection, pClassFilename As String, pClassStartPos As Long) As xMyClass
        ' this function will create an instance of xClass and return it
        Dim tmpMyClass As New xMyClass
        With tmpMyClass
            .mvarClassName = pClassName
            .mvarIsPublic = pIsPublic
            .mvarProperties = pProperties
            .mvarMethods = pMethods
            .mvarClassFilename = pClassFilename
            .mvarClassStartPos = pClassStartPos
        End With
        Return (tmpMyClass)
    End Function
End Class
