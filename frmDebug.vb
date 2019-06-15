Imports System.Runtime.InteropServices
Module frmDebug
    Public Sub Show()
        Win32.AllocConsole()
        Console.WriteLine("Welcome to the PearBox Debugger.")
CommandReader:
        Console.WriteLine()
        Console.Write("PearBox>")
        Dim UserInput As String = Console.ReadLine
        Select Case UserInput
            Case "cls"
                Console.Clear()
                GoTo CommandReader
            Case "exit"
                Win32.FreeConsole()
                Exit Sub
            Case Else
                If UserInput.Contains("edit config") Then
                    Dim ParArray As String() = Split(UserInput, " ")
                    Select Case ParArray(ParArray.Length - 1)
                        Case "size"
                            Console.WriteLine()
                            Console.Write("Write the new values for the size in the format X,Y: ")
                            Dim Answer As String = Replace(Console.ReadLine, " ", "")

                            Dim allowed As String = ("1234567890,")
                            For Each c As Char In Answer
                                If allowed.Contains(c) = False Then
                                    Console.WriteLine()
                                    Console.Write("Invalid values!")
                                    GoTo CommandReader
                                End If
                            Next

                            Dim NewSize As String() = Split(Answer, ",")
                            My.Settings.LastSize = _
                                New System.Drawing.Size(NewSize(0), NewSize(1))
                            My.Settings.Save()
                            Console.WriteLine("Values written correctly.")
                        Case "location"
                            Console.WriteLine()
                            Console.Write("Write the new values for the location in the format X,Y: ")
                            Dim Answer As String = Replace(Console.ReadLine, " ", "")

                            Dim allowed As String = ("1234567890,")
                            For Each c As Char In Answer
                                If allowed.Contains(c) = False Then
                                    Console.WriteLine()
                                    Console.Write("Invalid values!")
                                    GoTo CommandReader
                                End If
                            Next

                            Dim NewSize As String() = Split(Answer, ",")
                            My.Settings.LastLocation = _
                                New System.Drawing.Point(NewSize(0), NewSize(1))
                            My.Settings.Save()
                            Console.WriteLine("Values written correctly.")
                    End Select
                End If
        End Select
        GoTo CommandReader
    End Sub
End Module
Public Class Win32
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean

    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean

    End Function

End Class