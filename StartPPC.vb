Imports System.IO
Module StartPPC
    Public Sub Start(ConfigFile As String)
        'Try
        
        Dim ChispaCulpable As Process = New Process
        Dim catchvar As String = ""
        ChispaCulpable.StartInfo.FileName = My.Settings.PPCExecutable
        ChispaCulpable.StartInfo.WorkingDirectory = Path.GetDirectoryName(My.Settings.PPCExecutable)
        ChispaCulpable.StartInfo.Arguments = Chr(34) & ConfigFile & Chr(34)
        ChispaCulpable.StartInfo.CreateNoWindow = True
        ChispaCulpable.StartInfo.UseShellExecute = False
        ChispaCulpable.StartInfo.RedirectStandardError = True
        ChispaCulpable.StartInfo.RedirectStandardInput = True
        ChispaCulpable.StartInfo.RedirectStandardOutput = True
        ChispaCulpable.EnableRaisingEvents = True
        Application.DoEvents()
        AddHandler ChispaCulpable.Exited, AddressOf PPCSpark
        'AddHandler ChispaCulpable.OutputDataReceived, AddressOf PPCOutputReceived
        'AddHandler ChispaCulpable.ErrorDataReceived, AddressOf PPCErrorReceived
        ChispaCulpable.Start()
        ChispaCulpable.BeginOutputReadLine()
        ChispaCulpable.BeginErrorReadLine()

        'While ChispaCulpable.HasExited = False
        'End While
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Delegate Sub UpdateTextBoxDelg(text As String)
    Public myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateTextBox)

    Public Sub UpdateTextBox(text As String)
        frmStdOut.Txt.Text += text & Environment.NewLine
        frmStdOut.Txt.SelectionStart = frmStdOut.Txt.Text.Length
        frmStdOut.Txt.ScrollToCaret()
    End Sub

    Public Sub PPCOutputReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If frmStdOut.InvokeRequired = True Then
            frmStdOut.Invoke(myDelegate, e.Data)
        Else
            UpdateTextBox(e.Data)
        End If
    End Sub

    Public Sub PPCSpark(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub PPCErrorReceived(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
End Module
