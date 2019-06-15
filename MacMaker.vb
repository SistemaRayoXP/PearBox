Imports System.IO.Path
Module MacMaker
    Public Function CreateMac(Path As String, Options As String()) As String

        Dim FolderName As String() = Split(Path, "\")
        Dim FileName As String = Path & "\" & FolderName(FolderName.Length - 1) & ".cfg"
        
        'Here is where the texfile is saved to
        'the TextBox and finally saved to a file

        'Variable for saving all the text without needing a TextBox
        Dim Config As String = ""

        'Adding quotes, if needed
        Config = FormatLine("ppc_start_resolution", "800x600")
        Config = Config & FormatLine("ppc_start_full_screen", 0, False)
        Config = Config & FormatLine("redraw_interval_msec", 40, False)
        Config = Config & FormatLine("key_compose_dialog", "F11")
        Config = Config & FormatLine("key_change_cd_0", "F12")
        Config = Config & FormatLine("key_toggle_mouse_grab", "CTRL+F12")
        Config = Config & FormatLine("key_toggle_full_screen", "CTRL+RETURN")
        Config = Config & FormatLine("prom_bootmethod", "select")
        Config = Config & FormatLine("prom_env_machargs", "-v")
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
        Config = Config & FormatLine("pci_rtl8139_mac", "PE:AR:PC:FO:RE:VA")
        Config = Config & FormatLine("pci_usb_installed", 1, False)
        Config = Config & FormatLine("pci_serial_installed", 0, False)
        Config = Config & FormatLine("nvram_file", "nvram")

        My.Computer.FileSystem.WriteAllText(FileName, Config, False)

        Return FileName
    End Function

    Public Sub EditMac(FileName As String, Options() As String)

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
