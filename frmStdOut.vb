Public Class frmStdOut
    Private Sub frmStdOut_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Exit Sub
        For x As Integer = 512 To 550 Step 4
            Txt.AppendText("{" & vbNewLine)
            Txt.AppendText(4 * x & "x" & 3 * x & vbNewLine)
            Txt.AppendText(4 * (x + 2) & "x" & 3 * (x + 2) & vbNewLine)
            Txt.AppendText(4 * (x + 3) & "x" & 3 * (x + 3) & vbNewLine)
            Txt.AppendText(4 * (x + 4) & "x" & 3 * (x + 4) & vbNewLine)
            Txt.AppendText("}" & vbNewLine)
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dual() As String = Split(Txt.Text, "x")
        Dim Par As String = ""
        Dim Non As String = ""
        For x As Integer = 0 To dual.Length - 1
            If x Mod 2 = 0 Then
                Par = Par & dual(x) & vbNewLine
            Else
                Non = Non & dual(x) & vbNewLine
            End If
        Next
        Txt.Text = Par & vbNewLine & Non
    End Sub
End Class