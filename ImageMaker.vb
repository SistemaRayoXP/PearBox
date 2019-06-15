Imports System.Windows.Forms

Public Class ImageMaker
    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer)
    Dim Arguments As String()
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        DiskMakerProcess.CancelAsync()
    End Sub

    Private Sub ImageMaker_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        DiskMakerProcess.RunWorkerAsync(Arguments)
    End Sub

    Public Sub CreateFixed(SizeMB As Integer, Path As String)
        Arguments = {SizeMB, Path}
    End Sub

    Public Sub CreateRemovable(Type As String, Path As String)
        Select Case Type
            Case "144BootPPC85"
                My.Computer.FileSystem.WriteAllBytes(Path, My.Resources._144BootPPC85, False)
            Case "144Boot68K70"
                My.Computer.FileSystem.WriteAllBytes(Path, My.Resources._144Boot68K70, False)
            Case "144Blank"
                My.Computer.FileSystem.WriteAllBytes(Path, My.Resources._144Blank, False)
        End Select
        MsgBox("The image """ & Path & """ was created successfully.", _
               MsgBoxStyle.Information, frmMain.Fortune)
    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer)
        Progress.Value = percent
        ProgressLabel.Text = percent & "%"
        Status.Text = position & " MB/" & length & " MB"
    End Sub

    Private Sub DiskMakerProcess_DoWork(sender As System.ComponentModel.BackgroundWorker, e As System.ComponentModel.DoWorkEventArgs) Handles DiskMakerProcess.DoWork
        Dim Arguments As String() = e.Argument
        Dim TotalMB As Integer = Arguments(0)
        Dim MBWritten As Integer
        Dim EmptyMB(((1024 * 1024) * 0.984375) - 1) As Byte

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Invoke(safedelegate, TotalMB, 0, 0)

        If My.Computer.FileSystem.FileExists(Arguments(1)) Then
            My.Computer.FileSystem.DeleteFile(Arguments(1), FileIO.UIOption.OnlyErrorDialogs, _
                                              FileIO.RecycleOption.DeletePermanently, _
                                              FileIO.UICancelOption.DoNothing)
        End If

        For x As Integer = 0 To EmptyMB.Length - 1
            EmptyMB(x) = 0
        Next

        Do Until MBWritten = TotalMB
            For x As Integer = 0 To TotalMB - 1
                If DiskMakerProcess.CancellationPending = True Then
                    IO.File.Delete(Arguments(1))
                    Exit Do
                Else
                    My.Computer.FileSystem.WriteAllBytes(Arguments(1), EmptyMB, True)
                    MBWritten += 1
                    Dim percent As Short = (MBWritten / TotalMB) * 100
                    Invoke(safedelegate, TotalMB, MBWritten, percent)
                End If
            Next
        Loop

        If DiskMakerProcess.CancellationPending = True Then
            MsgBox("The image creation has been cancelled.", MsgBoxStyle.Exclamation, "Image creation aborted")
        Else
            MsgBox("The image """ & Arguments(1) & """ was created successfully.", _
               MsgBoxStyle.Information, frmMain.Fortune)
        End If

    End Sub

    Private Sub DiskMakerProcess_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DiskMakerProcess.RunWorkerCompleted
        Me.Close()
    End Sub
End Class
