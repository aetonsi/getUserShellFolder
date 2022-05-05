Module Module1

    Sub Main()
        If My.Application.CommandLineArgs.Count = 0 Then
            Exit Sub
        End If
        Console.WriteLine(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", My.Application.CommandLineArgs(0), ""))
    End Sub

End Module
