Public Class frmSettings
    Private Sub CreateConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        On Error GoTo ErrorHandler
        Dim DataArray() As String = GetData()

        If VerifyData() = True Then
            MsgBox("Incomplete data, please fill all the required fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Here is where the texfile is saved to
        'the TextBox and finally saved to a file

        'Variable for saving all the text without needing a TextBox
        Dim Config As String = ""

        'Formatting the text with a function, which returns
        'the text formatted as the documentation says

        'Emulator Resolution
        Config = FormatLine("ppc_start_resolution = ", DataArray(0), False)

        'Full screen (Enabled or disabled)
        Config = Config & FormatLine("ppc_start_full_screen = ", DataArray(1), True)

        'Image redraw time
        Config = Config & FormatLine("redraw_interval_msec = ", DataArray(2), True)

        'Compose dialog key
        Config = Config & FormatLine("key_compose_dialog = ", DataArray(3), False)

        'Change CD Key
        Config = Config & FormatLine("key_change_cd_0 = ", DataArray(4), False)

        'Release/Capture mouse key
        Config = Config & FormatLine("key_toggle_mouse_grab = ", DataArray(5), False)

        'Toggle Fullscreen/Windowed modes key
        Config = Config & FormatLine("key_toggle_full_screen = ", DataArray(6), False)

        'Boot mode (Auto, select or force)
        Config = Config & FormatLine("prom_bootmethod = ", DataArray(7), False)

        'Bugfix: File generated does not work with PearPC running on modern systems
        'Bugfix description: If the bootmethod is force, these lines are included
        'otherwise, they're not included.

        If DataArray(7) = "force" Then
            'PROM file (File to load in case BootMethod = Force)
            Config = Config & FormatLine("prom_loadfile = ", DataArray(8), False)
            'PROM Booth Path (Directory where PROM/PearPC boots)(Used with PROMFile)
            Config = Config & FormatLine("prom_env_bootpath = ", DataArray(9), False)
            'Boot Arguments
            Config = Config & FormatLine("prom_env_bootargs = ", DataArray(10), False)
        End If

        'Mach Arguments
        Config = Config & FormatLine("prom_env_machargs = ", DataArray(11), False)

        'Graphic driver (video.x is recommended OS X)
        Config = Config & FormatLine("prom_driver_graphic = ", DataArray(12), False)

        'Initial page table(Don't change)
        Config = Config & FormatLine("page_table_pa = ", DataArray(13), True)

        'Processor Version Register (To emulate G3 or G4)
        Config = Config & FormatLine("cpu_pvr = ", DataArray(14), True)

        'Memory size (must be >= 64 MiB)
        Config = Config & FormatLine("memory_size = ", DataArray(15), True)

        'Master drive Installed (Yes or No , 1 or 0)
        Config = Config & FormatLine("pci_ide0_master_installed = ", DataArray(16), True)

        'Route to the Master drive image
        Config = Config & FormatLine("pci_ide0_master_image = ", DataArray(17), False)

        'Master Drive Type(Hard disk or CD-ROM)
        Config = Config & FormatLine("pci_ide0_master_type = ", DataArray(18), False)

        'Slave drive Installed (Yes or No , 1 or 0)
        Config = Config & FormatLine("pci_ide0_slave_installed = ", DataArray(19), True)

        'Route to the Slave drive image
        Config = Config & FormatLine("pci_ide0_slave_image = ", DataArray(20), False)

        'Slave Drive Type(Hard disk or CD-ROM)
        Config = Config & FormatLine("pci_ide0_slave_type = ", DataArray(21), False)

        'Network card 3c90x Installed (Yes or No)
        Config = Config & FormatLine("pci_3c90x_installed = ", DataArray(22), True)

        'MAC of this card (3c90x)
        Config = Config & FormatLine("pci_3c90x_mac = ", DataArray(23), False)

        'Network card RTL8139 installed (Yes or No)
        Config = Config & FormatLine("pci_rtl8139_installed = ", DataArray(24), True)

        'MAC of this card (RTL8139)
        Config = Config & FormatLine("pci_rtl8139_mac = ", DataArray(25), False)

        'PCI USB capability installed (Yes or No)
        Config = Config & FormatLine("pci_usb_installed = ", DataArray(26), True)

        'PCI Serial port installed installed (Yes or No)(For debugging only)
        Config = Config & FormatLine("pci_serial_installed = ", DataArray(27), True)

        'NVRAM file route
        Config = Config & FormatLine("nvram_file = ", DataArray(28), False)

        'For debug purposes: Shows an MsgBox of what's in the Config variable
        Dim Proceed As Integer
        Proceed = MsgBox(Config, MsgBoxStyle.YesNo)
        If Proceed = 7 Then Exit Sub

        'Show the Save dialog for choosing the config file route
        SaveConfigFile.ShowDialog()

        If Not SaveConfigFile.FileName = "" Then
            My.Computer.FileSystem.WriteAllText(SaveConfigFile.FileName, Config, False)
        End If

ErrorHandler:

        If Err.Number <> 0 Then
            MsgBox(Err.Description)
        End If

    End Sub

    Public Function FormatLine(ByVal Config As String, ByVal Value As String, ByVal NoQuotes As Boolean) As String
        Dim NewLine As String

        If NoQuotes = True Then
            NewLine = Config & Value & vbCrLf
            GoTo EndFunction
        End If

        NewLine = Config & Chr(34) & Value & Chr(34) & vbCrLf

EndFunction:
        Return NewLine

    End Function

    Public Function GetData() As String()
        Dim Data() As String


        Dim Resolution As String = StandardResolution.SelectedItem.ToString & "x" & BitDepth.SelectedItem.ToString & "@" & Frequency.Value
        Dim FullScreen As Long
        Dim RedrawTime As Long = Me.RedrawTime.Text
        Dim ComposeDialogKey As String = Me.ComposeDialogKey.Text
        Dim ChangeCDKey As String = Me.ChangeCDKey.Text
        Dim ReleaseMouse As String = MouseToggleKey.Text
        Dim SwitchFullScreen As String = ToggleFullscreenKey.Text
        Dim BootMode As String = "auto"
        Dim PROMFile As String = Me.PROMFile.Text
        Dim PROMBootPath As String = Me.PROMBootPath.Text
        Dim BootArgs As String = BootArguments.Text
        Dim MachArgs As String = MachArguments.Text
        Dim GraphicDriver As String = Me.GraphicDriver.Text
        Dim PageTable As String = Me.PageTable.Text
        Dim CPUPvr As String = "0x00088302"
        Dim Memory As String = "0x" & (RAM.Text / 0.0000256)
        Dim MasterInstalled As Long = 0
        Dim MasterImage As String = MasterDrive.Text
        Dim MasterType As String = "hd"
        Dim SlaveInstalled As Long = 0
        Dim SlaveImage As String = SlaveDrive.Text
        Dim SlaveType As String = "cdrom"
        Dim Net3c90xInstalled As Long
        Dim Net3c90xMac As String = Mac13c90.Text & ":" & Mac23c90.Text & ":" & Mac33c90.Text & ":" & Mac43c90.Text & ":" & Mac53c90.Text & ":" & Mac63c90.Text
        Dim NetRTL8139Installed As Long
        Dim NetRTL8139Mac As String = Mac18139.Text & ":" & Mac28139.Text & ":" & Mac38139.Text & ":" & Mac48139.Text & ":" & Mac58139.Text & ":" & Mac68139.Text
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

        Data = {Resolution, FullScreen, RedrawTime, ComposeDialogKey, ChangeCDKey, _
                ReleaseMouse, SwitchFullScreen, BootMode, PROMFile, PROMBootPath, _
                BootArgs, MachArgs, GraphicDriver, PageTable, CPUPvr, Memory, _
                MasterInstalled, MasterImage, MasterType, SlaveInstalled, SlaveImage, _
                SlaveType, Net3c90xInstalled, Net3c90xMac, NetRTL8139Installed, _
                NetRTL8139Mac, USBInstalled, SerialInstalled, NVRAMFile}

        Return Data

    End Function

    Public Function VerifyData() As Boolean

        Dim Incomplete As Boolean = False

        If MasterEnabled.Checked = True Then
            If MasterDrive.Text = "" Then
                Incomplete = True
            End If
        End If

        If SlaveEnabled.Checked = True Then
            If SlaveDrive.Text = "" Then
                Incomplete = True
            End If
        End If

        If Net3c90x.Checked = True Then
            If Mac13c90.Text = "" Then
                Incomplete = True
            End If
            If Mac23c90.Text = "" Then
                Incomplete = True
            End If
            If Mac33c90.Text = "" Then
                Incomplete = True
            End If
            If Mac43c90.Text = "" Then
                Incomplete = True
            End If
            If Mac53c90.Text = "" Then
                Incomplete = True
            End If
            If Mac63c90.Text = "" Then
                Incomplete = True
            End If
        End If

        If NetRTL8139.Checked = True Then
            If Mac18139.Text = "" Then
                Incomplete = True
            End If
            If Mac28139.Text = "" Then
                Incomplete = True
            End If
            If Mac38139.Text = "" Then
                Incomplete = True
            End If
            If Mac48139.Text = "" Then
                Incomplete = True
            End If
            If Mac58139.Text = "" Then
                Incomplete = True
            End If
            If Mac68139.Text = "" Then
                Incomplete = True
            End If
        End If

        If GraphicDriver.Text = "" Then
            Incomplete = True
        End If

        If CustomResolutionCheck.Checked = True Then
            If YCustomResolution.Text = "" Then
                Incomplete = True
            End If
            If XCustomResolution.Text = "" Then
                Incomplete = True
            End If
        End If

        If NVRAMFile.Text = "" Then
            Incomplete = True
        End If

        Return Incomplete

    End Function
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TreeView1.SelectedNode = TreeView1.TopNode
        StandardResolution.SelectedIndex = 1
        BitDepth.SelectedIndex = 1
        MasterDriveType.SelectedIndex = 0
        SlaveDriveType.SelectedIndex = 1
    End Sub

    Private Sub CustomResolutionCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomResolutionCheck.Click
        Dim CustRes As String() = Split(StandardResolution.SelectedItem.ToString, "x")
        If CustomResolutionCheck.Checked Then
            XCustomResolution.Text = CustRes(0)
            YCustomResolution.Text = CustRes(1)
            StandardResolution.Visible = False
            XCustomResolution.Visible = True
            YCustomResolution.Visible = True
            Frequency.Enabled = True
        Else
            StandardResolution.Visible = True
            XCustomResolution.Visible = False
            YCustomResolution.Visible = False
            Frequency.Enabled = False
        End If
    End Sub

    Private Sub BrowseDriver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrowseDriver.Click
        Browser.Filter = "All files (*.*)|*.*"
        Browser.ShowDialog()
        GraphicDriver.Text = Browser.FileName
    End Sub

    Private Sub MasterBrowseDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterBrowseDrive.Click

        Select Case MasterDriveType.SelectedIndex
            Case 0
                Browser.FilterIndex = 2
                Browser.ShowDialog()
                MasterDrive.Text = Browser.FileName
            Case 1
                Browser.FilterIndex = 1
                Browser.ShowDialog()
                MasterDrive.Text = Browser.FileName
            Case 2
                SelectDrive.ShowDialog()
                MasterDrive.Text = SelectDrive.SelectedPath
        End Select

    End Sub

    Private Sub MasterEnabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MasterEnabled.Click

        If Not MasterEnabled.Checked = True Then
            MasterTypeLabel.Enabled = False
            MasterImageLabel.Enabled = False
            If MasterDriveType.Visible Then
                MasterDriveType.Enabled = False
            Else
                MasterDriveTypeBasic.Enabled = False
            End If
            MasterDrive.Enabled = False
            MasterBrowseDrive.Enabled = False
        Else
            MasterTypeLabel.Enabled = True
            MasterImageLabel.Enabled = True
            If MasterDriveType.Visible Then
                MasterDriveType.Enabled = True
            Else
                MasterDriveTypeBasic.Enabled = True
            End If
            MasterDrive.Enabled = True
            MasterBrowseDrive.Enabled = True
        End If

    End Sub

    Private Sub SlaveEnabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SlaveEnabled.Click
        If Not SlaveEnabled.Checked = True Then
            SlaveTypeLabel.Enabled = False
            SlaveImageLabel.Enabled = False
            SlaveDriveType.Enabled = False
            SlaveDrive.Enabled = False
            SlaveBrowseDrive.Enabled = False
        Else
            SlaveTypeLabel.Enabled = True
            SlaveImageLabel.Enabled = True
            SlaveDriveType.Enabled = True
            SlaveDrive.Enabled = True
            SlaveBrowseDrive.Enabled = True
        End If
    End Sub

    Private Sub SlaveBrowseDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlaveBrowseDrive.Click

        Select Case SlaveDriveType.SelectedIndex
            Case 0
                Browser.FilterIndex = 2
                Browser.ShowDialog()
                SlaveDrive.Text = Browser.FileName
            Case 1
                Browser.FilterIndex = 1
                Browser.ShowDialog()
                SlaveDrive.Text = Browser.FileName
            Case 2
                SelectDrive.ShowDialog()
                SlaveDrive.Text = SelectDrive.SelectedPath
        End Select

    End Sub

    Private Sub Mac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Mac13c90.KeyPress, Mac68139.KeyPress, Mac63c90.KeyPress, Mac58139.KeyPress, Mac53c90.KeyPress, Mac48139.KeyPress, Mac43c90.KeyPress, Mac38139.KeyPress, Mac33c90.KeyPress, Mac28139.KeyPress, Mac23c90.KeyPress, Mac18139.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub Net3c90x_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Net3c90x.Click
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

    Private Sub NetRTL8139_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NetRTL8139.Click
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

    Private Sub MasterDriveType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterDriveType.SelectedIndexChanged
        MasterDriveTypeBasic.Text = MasterDriveType.SelectedItem.ToString
    End Sub

    Private Sub TreeView1_AfterSelect(sender As TreeView, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
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

End Class
