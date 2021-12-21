Imports System.IO
Imports System.IO.Path
Module MacMaker
    Public Function CreateMac(MacName As String, Options As String()) As String

        'Variable for saving all the text without needing a TextBox
        Dim Config As String = ""

        'Adding quotes, if needed
        Config = FormatLine("ppc_start_resolution", "800x600x32")
        Config = Config & FormatLine("ppc_start_full_screen", 0, False)
        Config = Config & FormatLine("redraw_interval_msec", 40, False)
        Config = Config & FormatLine("key_compose_dialog", "F11")
        Config = Config & FormatLine("key_change_cd_0", "F12")
        Config = Config & FormatLine("key_toggle_mouse_grab", "Ctrl+F12")
        Config = Config & FormatLine("key_toggle_full_screen", "Ctrl+Return")
        Config = Config & FormatLine("prom_bootmethod", "auto")
        Config = Config & FormatLine("prom_env_machargs", "")
        Config = Config & FormatLine("prom_driver_graphic", "video.x")
        Config = Config & FormatLine("page_table_pa", "0x00300000", False)
        Config = Config & FormatLine("cpu_pvr", "0x00088302", False)
        Config = Config & FormatLine("memory_size", Options(0), False)
        Config = Config & FormatLine("pci_ide0_master_installed", Options(1), False)
        Config = Config & FormatLine("pci_ide0_master_image", Options(2))
        Config = Config & FormatLine("pci_ide0_master_type", "hd")
        Config = Config & FormatLine("pci_ide0_slave_installed", 0, False)
        Config = Config & FormatLine("pci_ide0_slave_image", "")
        Config = Config & FormatLine("pci_ide0_slave_type", "cdrom")
        Config = Config & FormatLine("pci_3c90x_installed", 0, False)
        Config = Config & FormatLine("pci_3c90x_mac", "DE:AD:CA:FE:12:34")
        Config = Config & FormatLine("pci_rtl8139_installed", 0, False)
        Config = Config & FormatLine("pci_rtl8139_mac", "C4:2A:D0:21:10:02")
        Config = Config & FormatLine("pci_usb_installed", 1, False)
        Config = Config & FormatLine("pci_serial_installed", 0, False)
        Config = Config & FormatLine("nvram_file", "nvram")

        Dim FolderName As String = My.Settings.DefaultNewMacPath & DirectorySeparatorChar & MacName
        Dim FileName As String = FolderName & DirectorySeparatorChar & MacName & ".cfg"
        My.Computer.FileSystem.CreateDirectory(FolderName)
        Dim wrt As StreamWriter = New StreamWriter(FileName, False, System.Text.Encoding.ASCII)
        wrt.AutoFlush = True
        wrt.WriteLine(Config)
        wrt.Close()
        Return FileName
    End Function

    Public Sub EditMac(FileName As String, Options() As String)
        'Variable for saving all the text without needing a TextBox
        Dim Config As String = ""
        
        'Adding quotes, if needed
        Config = FormatLine("ppc_start_resolution", Options(0))
        Config = Config & FormatLine("ppc_start_full_screen", Options(1), False)
        Config = Config & FormatLine("redraw_interval_msec", Options(2), False)
        Config = Config & FormatLine("key_compose_dialog", Options(3))
        Config = Config & FormatLine("key_change_cd_0", Options(4))
        Config = Config & FormatLine("key_toggle_mouse_grab", Options(5))
        Config = Config & FormatLine("key_toggle_full_screen", Options(6))
        Config = Config & FormatLine("prom_bootmethod", Options(7))
        If Options(7) = "force" Then
            Config = Config & FormatLine("prom_loadfile = ", Options(8), False)
            Config = Config & FormatLine("prom_env_bootpath = ", Options(9), False)
            Config = Config & FormatLine("prom_env_bootargs = ", Options(10), False)
        End If
        Config = Config & FormatLine("prom_env_machargs", Options(11))
        Config = Config & FormatLine("prom_driver_graphic", Options(12))
        Config = Config & FormatLine("page_table_pa", Options(13), False)
        Config = Config & FormatLine("cpu_pvr", Options(14), False)
        Config = Config & FormatLine("memory_size", Options(15), False)
        Config = Config & FormatLine("pci_ide0_master_installed", Options(16), False)
        Config = Config & FormatLine("pci_ide0_master_image", Options(17))
        Config = Config & FormatLine("pci_ide0_master_type", Options(18))
        Config = Config & FormatLine("pci_ide0_slave_installed", Options(19), False)
        Config = Config & FormatLine("pci_ide0_slave_image", Options(20))
        Config = Config & FormatLine("pci_ide0_slave_type", Options(21))
        Config = Config & FormatLine("pci_3c90x_installed", Options(22), False)
        Config = Config & FormatLine("pci_3c90x_mac", Options(23))
        Config = Config & FormatLine("pci_rtl8139_installed", Options(24), False)
        Config = Config & FormatLine("pci_rtl8139_mac", Options(25))
        Config = Config & FormatLine("pci_usb_installed", Options(26), False)
        Config = Config & FormatLine("pci_serial_installed", Options(27), False)
        Config = Config & FormatLine("nvram_file", Options(28))

        Dim wrt As StreamWriter = New StreamWriter(FileName, False, System.Text.Encoding.ASCII)
        wrt.AutoFlush = True
        wrt.WriteLine(Config)
        wrt.Close()
    End Sub

    Private Function FormatLine(ByVal Config As String, ByVal Value As String, Optional Quotes As Boolean = True) As String
        Dim NewLine As String

        If Quotes = False Then
            NewLine = Config & " = " & Value & vbCrLf
            GoTo EndFunction
        End If

        NewLine = Config & " = " & Chr(34) & Value & Chr(34) & vbCrLf

EndFunction:
        Return NewLine

    End Function
End Module
