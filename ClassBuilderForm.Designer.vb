<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClassBuilderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtBaseFolder = New TextBox()
        txtProject = New TextBox()
        tvClasses = New TreeView()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Label1 = New Label()
        cboLoad = New Button()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBaseFolder
        ' 
        txtBaseFolder.Location = New Point(108, 12)
        txtBaseFolder.Name = "txtBaseFolder"
        txtBaseFolder.Size = New Size(384, 27)
        txtBaseFolder.TabIndex = 0
        txtBaseFolder.Text = "BaseFolder"
        ' 
        ' txtProject
        ' 
        txtProject.Location = New Point(108, 45)
        txtProject.Name = "txtProject"
        txtProject.Size = New Size(384, 27)
        txtProject.TabIndex = 1
        txtProject.Text = "Project"
        ' 
        ' tvClasses
        ' 
        tvClasses.Location = New Point(17, 130)
        tvClasses.Name = "tvClasses"
        tvClasses.Size = New Size(236, 300)
        tvClasses.TabIndex = 2
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(281, 101)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(500, 329)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(492, 296)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(492, 296)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 4
        Label1.Text = "Classes:"
        ' 
        ' cboLoad
        ' 
        cboLoad.Location = New Point(689, 19)
        cboLoad.Name = "cboLoad"
        cboLoad.Size = New Size(91, 29)
        cboLoad.TabIndex = 5
        cboLoad.Text = "Load"
        cboLoad.UseVisualStyleBackColor = True
        ' 
        ' ClassBuilderForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cboLoad)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        Controls.Add(tvClasses)
        Controls.Add(txtProject)
        Controls.Add(txtBaseFolder)
        Name = "ClassBuilderForm"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBaseFolder As TextBox
    Friend WithEvents txtProject As TextBox
    Friend WithEvents tvClasses As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cboLoad As Button
End Class
