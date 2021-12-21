Imports System.IO
Public Class frmSettings
    Public FileName As String = ""
    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SettingsPicker.SelectedNode = SettingsPicker.TopNode
    End Sub

    Private Sub frmSettings_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        LoadConfig()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        On Error GoTo ErrorHandler
        Dim Options() As String = GetData()

        If VerifyData() = True Then
            MsgBox("Incomplete data, please fill all the required fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        MacMaker.EditMac(FileName, Options)
        Me.Close()

ErrorHandler:
        If Err.Number <> 0 Then
            MsgBox(Err.Description)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Protected Friend Sub LoadConfig()
        Dim Config() As String = Split(My.Computer.FileSystem.ReadAllText(FileName), vbNewLine)
        ProgressBar1.Maximum = Config.Length
        For x As Integer = 0 To Config.Length - 1
            Config(x) = Replace(Config(x), Chr(34), "")
            ProgressBar1.PerformStep()
            Dim SubConfig() As String = Split(Config(x), " = ")
            Select Case SubConfig(0)
                Case "ppc_start_resolution"
                    Dim res() As String = Split(SubConfig(1), "x")
                    If InStr(SubConfig(1), "@") <> 0 Then
                        Dim freq() As String = Split(res(2), "@")
                        res = {res(0), res(1), freq(0), freq(1)}
                        Frequency.Value = res(3)
                    End If

                    If isDivisible(res(0), 4) = True Then
                        For y As Integer = 0 To XCustomResolution.Items.Count - 1
                            If XCustomResolution.Items.Item(y).ToString = res(0) Then
                                XCustomResolution.SelectedIndex = y
                            End If
                        Next
                        If XCustomResolution.SelectedIndex = -1 Then
                            XCustomResolution.Items.Add(res(0))
                            XCustomResolution.SelectedIndex = XCustomResolution.Items.Count - 1
                        End If
                    End If
                    If isDivisible(res(1), 3) = True Then
                        For y As Integer = 0 To YCustomResolution.Items.Count - 1
                            If YCustomResolution.Items.Item(y).ToString = res(1) Then
                                YCustomResolution.SelectedIndex = y
                            End If
                        Next
                        If YCustomResolution.SelectedIndex = -1 Then
                            YCustomResolution.Items.Add(res(1))
                            YCustomResolution.SelectedIndex = YCustomResolution.Items.Count - 1
                        End If
                    End If
                    Select Case res(2)
                        Case "15"
                            BitDepth.SelectedIndex = 0
                        Case "32"
                            BitDepth.SelectedIndex = 1
                    End Select
                    
                Case "ppc_start_full_screen"
                    If SubConfig(1) = 1 Then
                        FullscreenCheck.Checked = True
                    End If
                Case "redraw_interval_msec"
                    RedrawTime.Text = SubConfig(1)
                Case "key_compose_dialog"
                    ComposeDialogKey.Text = SubConfig(1)
                Case "key_change_cd_0"
                    ChangeCDKey.Text = SubConfig(1)
                Case "key_toggle_mouse_grab"
                    MouseToggleKey.Text = SubConfig(1)
                Case "key_toggle_full_screen"
                    ToggleFullscreenKey.Text = SubConfig(1)
                Case "prom_bootmethod"
                    Select Case SubConfig(1)
                        Case "auto"
                            BootAuto.Checked = True
                        Case "select"
                            BootSelect.Checked = True
                        Case "force"
                            BootForce.Checked = True
                    End Select
                Case "prom_loadfile"
                    PROMFile.Text = SubConfig(1)
                Case "prom_env_bootpath"
                    PROMBootPath.Text = SubConfig(1)
                Case "prom_env_bootargs"
                    BootArguments.Text = SubConfig(1)
                Case "prom_env_machargs"
                    MachArguments.Text = SubConfig(1)
                Case "prom_driver_graphic"
                    GraphicDriver.Text = SubConfig(1)
                Case "page_table_pa"
                    PageTable.Text = SubConfig(1)
                Case "cpu_pvr"
                    Select Case SubConfig(1)
                        Case "0x00088302"
                            PPCG3.Checked = True
                        Case "0x000c0201"
                            PPCG4.Checked = True
                    End Select
                Case "memory_size"
                    SubConfig(1) = Replace(SubConfig(1), "0x", "")
                    RAM.Text = SubConfig(1) * 0.0000256
                Case "pci_ide0_master_installed"
                    If SubConfig(1) = 1 Then
                        MasterEnabled.Checked = True
                    End If
                Case "pci_ide0_master_image"
                    MasterLoc.Text = SubConfig(1)
                Case "pci_ide0_master_type"
                    Select Case SubConfig(1)
                        Case "hd"
                            MasterDriveType.SelectedIndex = 0
                        Case "cdrom"
                            MasterDriveType.SelectedIndex = 1
                        Case "nativecdrom"
                            MasterDriveType.SelectedIndex = 2
                    End Select
                Case "pci_ide0_slave_installed"
                    If SubConfig(1) = 1 Then
                        SlaveEnabled.Checked = True
                    End If
                Case "pci_ide0_slave_image"
                    SlaveLoc.Text = SubConfig(1)
                Case "pci_ide0_slave_type"
                    Select Case SubConfig(1)
                        Case "hd"
                            SlaveDriveType.SelectedIndex = 0
                        Case "cdrom"
                            SlaveDriveType.SelectedIndex = 1
                        Case "nativecdrom"
                            SlaveDriveType.SelectedIndex = 2
                    End Select
                Case "pci_3c90x_installed"
                    If SubConfig(1) = 1 Then
                        Net3c90x.Checked = True
                    End If
                Case "pci_3c90x_mac"
                    Dim Mac() As String = Split(SubConfig(1), ":")
                    Mac13c90.Text = Mac(0)
                    Mac23c90.Text = Mac(1)
                    Mac33c90.Text = Mac(2)
                    Mac43c90.Text = Mac(3)
                    Mac53c90.Text = Mac(4)
                    Mac63c90.Text = Mac(5)
                Case "pci_rtl8139_installed"
                    If SubConfig(1) = 1 Then
                        NetRTL8139.Checked = True
                    End If
                Case "pci_rtl8139_mac"
                    Dim Mac() As String = Split(SubConfig(1), ":")
                    Mac18139.Text = Mac(0)
                    Mac28139.Text = Mac(1)
                    Mac38139.Text = Mac(2)
                    Mac48139.Text = Mac(3)
                    Mac58139.Text = Mac(4)
                    Mac68139.Text = Mac(5)
                Case "pci_usb_installed"
                    If SubConfig(1) = 1 Then
                        EnableUSB.Checked = True
                    End If
                Case "pci_serial_installed"
                    If SubConfig(1) = 1 Then
                        EnableSerialPort.Checked = True
                    End If
                Case "nvram_file"
                    NVRAMFile.Text = SubConfig(1)
            End Select
        Next
        ProgressBar1.Visible = False
        ProgressBar1.Dispose()
    End Sub

    Public Function GetData() As String()
        Dim Data() As String


        Dim Resolution As String = _
            XCustomResolution.Text.ToString & "x" & _
            YCustomResolution.Text.ToString & "x" & _
            BitDepth.SelectedItem.ToString & "@" & _
            Frequency.Value
        Dim FullScreen As Long
        Dim RedrawTime As Long = Me.RedrawTime.Text
        Dim ComposeDialogKey As String = Me.ComposeDialogKey.Text
        Dim ChangeCDKey As String = Me.ChangeCDKey.Text
        Dim ReleaseMouse As String = MouseToggleKey.Text
        Dim FullScreenKey As String = ToggleFullscreenKey.Text
        Dim BootMode As String = "auto"
        Dim PROMFile As String = Me.PROMFile.Text
        Dim PROMBootPath As String = Me.PROMBootPath.Text
        Dim PROMBootArgs As String = BootArguments.Text
        Dim MachArgs As String = MachArguments.Text
        Dim GraphicDriver As String = Me.GraphicDriver.Text
        Dim PageTable As String = Me.PageTable.Text
        Dim CPUPvr As String = "0x00088302"
        Dim Memory As String = "0x" & (RAM.Text / 0.0000256)
        Dim MasterInstalled As Long = 0
        Dim MasterImage As String = MasterLoc.Text
        Dim MasterType As String = "hd"
        Dim SlaveInstalled As Long = 0
        Dim SlaveImage As String = SlaveLoc.Text
        Dim SlaveType As String = "cdrom"
        Dim Net3c90xInstalled As Long
        Dim Net3c90xMac As String = _
            Mac13c90.Text & ":" & _
            Mac23c90.Text & ":" & _
            Mac33c90.Text & ":" &
            Mac43c90.Text & ":" & _
            Mac53c90.Text & ":" & _
            Mac63c90.Text
        Dim NetRTL8139Installed As Long
        Dim NetRTL8139Mac As String = _
            Mac18139.Text & ":" & _
            Mac28139.Text & ":" & _
            Mac38139.Text & ":" & _
            Mac48139.Text & ":" & _
            Mac58139.Text & ":" & _
            Mac68139.Text
        Dim USBInstalled As Long = 0
        Dim SerialInstalled As Long = 0
        Dim NVRAMFile As String = Me.NVRAMFile.Text

        If FullscreenCheck.Checked = True Then
            FullScreen = 1
        Else
            FullScreen = 0
        End If

        If BootAuto.Checked = True Then
            BootMode = "auto"
        End If
        If BootSelect.Checked = True Then
            BootMode = "select"
        End If
        If BootForce.Checked = True Then
            BootMode = "force"
        End If

        If PPCG3.Checked = True Then
            CPUPvr = "0x00088302"
        End If
        If PPCG4.Checked = True Then
            CPUPvr = "0x000c0201"
        End If

        If MasterEnabled.Checked = True Then
            MasterInstalled = 1
        Else
            MasterInstalled = 0
        End If

        Select Case MasterDriveType.SelectedIndex
            Case 0
                MasterType = "hd"
            Case 1
                MasterType = "cdrom"
            Case 2
                MasterType = "nativecdrom"
        End Select

        If SlaveEnabled.Checked = True Then
            SlaveInstalled = 1
        Else
            SlaveInstalled = 0
        End If

        Select Case SlaveDriveType.SelectedIndex
            Case 0
                SlaveType = "hd"
            Case 1
                SlaveType = "cdrom"
            Case 2
                SlaveType = "nativecdrom"
        End Select

        If Net3c90x.Checked = True Then
            Net3c90xInstalled = 1
        Else
            Net3c90xInstalled = 0
        End If

        If NetRTL8139.Checked = True Then
            NetRTL8139Installed = 1
        Else
            NetRTL8139Installed = 0
        End If

        If EnableUSB.Checked = True Then
            USBInstalled = 1
        Else
            USBInstalled = 0
        End If

        If EnableSerialPort.Checked = True Then
            SerialInstalled = 1
        Else
            SerialInstalled = 0
        End If

        Data = {Resolution,
                FullScreen,
                RedrawTime,
                ComposeDialogKey,
                ChangeCDKey,
                ReleaseMouse,
                FullScreenKey,
                BootMode,
                PROMFile,
                PROMBootPath,
                PROMBootArgs,
                MachArgs,
                GraphicDriver,
                PageTable,
                CPUPvr,
                Memory,
                MasterInstalled,
                MasterImage,
                MasterType,
                SlaveInstalled,
                SlaveImage,
                SlaveType,
                Net3c90xInstalled,
                Net3c90xMac,
                NetRTL8139Installed,
                NetRTL8139Mac,
                USBInstalled,
                SerialInstalled,
                NVRAMFile}

        Return Data

    End Function

    Public Function VerifyData() As Boolean

        Dim Incomplete As Boolean = False

        If MasterEnabled.Checked = True Then
            If MasterLoc.Text = "" Then
                Incomplete = True
            End If
        ElseIf SlaveEnabled.Checked = True Then
            If SlaveLoc.Text = "" Then
                Incomplete = True
            End If
        ElseIf Net3c90x.Checked = True Then
            If Mac13c90.Text = "" Then
                Incomplete = True
            ElseIf Mac23c90.Text = "" Then
                Incomplete = True
            ElseIf Mac33c90.Text = "" Then
                Incomplete = True
            ElseIf Mac43c90.Text = "" Then
                Incomplete = True
            ElseIf Mac53c90.Text = "" Then
                Incomplete = True
            ElseIf Mac63c90.Text = "" Then
                Incomplete = True
            End If
        ElseIf NetRTL8139.Checked = True Then
            If Mac18139.Text = "" Then
                Incomplete = True
            ElseIf Mac28139.Text = "" Then
                Incomplete = True
            ElseIf Mac38139.Text = "" Then
                Incomplete = True
            ElseIf Mac48139.Text = "" Then
                Incomplete = True
            ElseIf Mac58139.Text = "" Then
                Incomplete = True
            ElseIf Mac68139.Text = "" Then
                Incomplete = True
            End If
        ElseIf GraphicDriver.Text = "" Then
            Incomplete = True
        ElseIf YCustomResolution.Text = "" Then
            Incomplete = True
        ElseIf XCustomResolution.Text = "" Then
            Incomplete = True
        ElseIf NVRAMFile.Text = "" Then
            Incomplete = True
        End If

        Return Incomplete

    End Function

    Function isDivisible(x As Integer, d As Integer) As Boolean
        Return (x Mod d) = 0
    End Function

    Public Function FormatLine(ByVal Config As String, ByVal Value As String, Optional Quotes As Boolean = True) As String
        Dim NewLine As String

        If Quotes = True Then
            NewLine = Config & Chr(34) & Value & Chr(34) & vbCrLf
            GoTo EndFunction
        End If
        NewLine = Config & Value & vbCrLf

EndFunction:
        Return NewLine

    End Function

    Private Sub SwitchToPage(NewPage As Panel)
        NameSettings.Visible = False
        GraphicSettings.Visible = False
        DisksSettings.Visible = False
        NetworkSettings.Visible = False
        MiscellaneousSettings.Visible = False
        AdvancedSettings.Visible = False

        NewPage.BringToFront()
        NewPage.Visible = True
    End Sub

    Private Sub MasterBrowseDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterLocBrowse.Click

        Select Case MasterDriveType.SelectedIndex
            Case 0
                Browser.FilterIndex = 2
                Browser.ShowDialog()
                MasterLoc.Text = Browser.FileName
            Case 1
                Browser.FilterIndex = 1
                Browser.ShowDialog()
                MasterLoc.Text = Browser.FileName
            Case 2
                SelectDrive.ShowDialog()
                MasterLoc.Text = SelectDrive.SelectedPath
        End Select

    End Sub

    Private Sub SlaveBrowseDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlaveLocBrowse.Click

        Select Case SlaveDriveType.SelectedIndex
            Case 0
                Browser.FilterIndex = 2
                Browser.ShowDialog()
                SlaveLoc.Text = Browser.FileName
            Case 1
                Browser.FilterIndex = 1
                Browser.ShowDialog()
                SlaveLoc.Text = Browser.FileName
            Case 2
                SelectDrive.ShowDialog()
                SlaveLoc.Text = SelectDrive.SelectedPath
        End Select

    End Sub

    Private Sub MasterEnabled_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MasterEnabled.CheckedChanged
        If MasterEnabled.Checked = True Then
            MasterDriveType.Enabled = True
            MasterDriveTypeLabel.Enabled = True
            MasterLocLabel.Enabled = True
            MasterLoc.Enabled = True
            MasterLocBrowse.Enabled = True
        Else
            MasterDriveType.Enabled = False
            MasterDriveTypeLabel.Enabled = False
            MasterLocLabel.Enabled = False
            MasterLoc.Enabled = False
            MasterLocBrowse.Enabled = False
        End If
    End Sub

    Private Sub SlaveEnabled_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SlaveEnabled.CheckedChanged
        If SlaveEnabled.Checked = True Then
            SlaveDriveType.Enabled = True
            SlaveDriveTypeLabel.Enabled = True
            SlaveLocLabel.Enabled = True
            SlaveLoc.Enabled = True
            SlaveLocBrowse.Enabled = True
        Else
            SlaveDriveType.Enabled = False
            SlaveDriveTypeLabel.Enabled = False
            SlaveLocLabel.Enabled = False
            SlaveLoc.Enabled = False
            SlaveLocBrowse.Enabled = False
        End If
    End Sub

    Private Sub Mac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles Mac13c90.KeyPress, Mac23c90.KeyPress, Mac33c90.KeyPress, Mac43c90.KeyPress, Mac53c90.KeyPress, Mac63c90.KeyPress, _
        Mac18139.KeyPress, Mac28139.KeyPress, Mac38139.KeyPress, Mac48139.KeyPress, Mac58139.KeyPress, Mac68139.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub Net3c90x_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Net3c90x.CheckedChanged
        If Net3c90x.Checked = True Then
            Net3c90MacLabel.Enabled = True
            Mac13c90.Enabled = True
            Mac23c90.Enabled = True
            Mac33c90.Enabled = True
            Mac43c90.Enabled = True
            Mac53c90.Enabled = True
            Mac63c90.Enabled = True
        Else
            Net3c90MacLabel.Enabled = False
            Mac13c90.Enabled = False
            Mac23c90.Enabled = False
            Mac33c90.Enabled = False
            Mac43c90.Enabled = False
            Mac53c90.Enabled = False
            Mac63c90.Enabled = False
        End If
    End Sub

    Private Sub NetRTL8139_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NetRTL8139.CheckedChanged
        If NetRTL8139.Checked = True Then
            Net8139MacLabel.Enabled = True
            Mac18139.Enabled = True
            Mac28139.Enabled = True
            Mac38139.Enabled = True
            Mac48139.Enabled = True
            Mac58139.Enabled = True
            Mac68139.Enabled = True
        Else
            Net8139MacLabel.Enabled = False
            Mac18139.Enabled = False
            Mac28139.Enabled = False
            Mac38139.Enabled = False
            Mac48139.Enabled = False
            Mac58139.Enabled = False
            Mac68139.Enabled = False
        End If
    End Sub

    Private Sub PageTable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PageTable.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToggleFullscreenKey_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToggleFullscreenKey.Click
        ToggleFullscreenKey.SelectAll()
    End Sub

    Private Sub MouseToggleKey_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MouseToggleKey.Click
        MouseToggleKey.SelectAll()
    End Sub

    Private Sub BootForce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BootForce.CheckedChanged
        If BootForce.Checked = True Then
            PROMFileLabel.Enabled = True
            PROMFile.Enabled = True
            PROMBootPathLabel.Enabled = True
            PROMBootPath.Enabled = True
            BootArguments.Enabled = True
            BootArgumentsLabel.Enabled = True
        Else
            PROMFileLabel.Enabled = False
            PROMFile.Enabled = False
            PROMBootPathLabel.Enabled = False
            PROMBootPath.Enabled = False
            BootArguments.Enabled = False
            BootArgumentsLabel.Enabled = False
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(sender As TreeView, e As System.Windows.Forms.TreeViewEventArgs) Handles SettingsPicker.AfterSelect
        Select Case sender.SelectedNode.Index
            Case 0
                SwitchToPage(NameSettings)
            Case 1
                SwitchToPage(GraphicSettings)
            Case 2
                SwitchToPage(DisksSettings)
            Case 3
                SwitchToPage(NetworkSettings)
            Case 4
                SwitchToPage(MiscellaneousSettings)
            Case 5
                SwitchToPage(AdvancedSettings)
        End Select
    End Sub

    Private Sub AdvancedBrowse_Click(sender As System.Object, e As System.EventArgs) _
        Handles PROMFileBrowse.Click, PROMBootPathBrowse.Click, NVRAMFileBrowse.Click, GraphicDriverBrowse.Click
        Browser.Filter = "All files|*.*"
        If Browser.ShowDialog() = Windows.Forms.DialogResult.OK And Browser.FileName <> "" Then
            Select Case sender.Name
                Case "PROMBootPathBrowse"
                    PROMBootPath.Text = Browser.FileName
                Case "PROMFileBrowse"
                    PROMFile.Text = Browser.FileName
                Case "NVRAMFileBrowse"
                    NVRAMFile.Text = Browser.FileName
                Case "GraphicDriverBrowse"
                    GraphicDriver.Text = Browser.FileName
            End Select
        End If
    End Sub
End Class
