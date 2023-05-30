Public Class ClassBuilderForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ClassBuilderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This routine runs when the form is loaded.  It will initialize certain fields
        Me.txtBaseFolder.Text = "C:\Projects\VBNet\EmpireVBNet\EmpireVBNet"
        Me.txtProject.Text = "EmpireVBNet"
        Me.cboLoad.Select() ' set's focus
    End Sub

    Private Sub cboLoad_Click(sender As Object, e As EventArgs) Handles cboLoad.Click
        ' This will execute the load project routine
        Call modClassBuilder.LoadProject(Me.txtBaseFolder.Text, Me.txtProject.Text)
    End Sub
End Class
