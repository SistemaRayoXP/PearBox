Imports System.Windows.Forms
'I've used "Yes", "No" and cancel. Note that "No" means we're deleting anyway, 
'just NOT deleting the files. To cancel deletition just use Cancel
Public Class frmMainDelete
    Private Sub frmMainDelete_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Icon = SystemIcons.Exclamation
        Dim ExclamationImage As Image = SystemIcons.Exclamation.ToBitmap
        PictureBox1.Image = ExclamationImage
    End Sub

    Private Sub cmdIncludeFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncludeFiles.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub cmdExcludeFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcludeFiles.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
