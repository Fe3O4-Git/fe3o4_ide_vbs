Public Class FormMain
    Dim fileName
    Dim utf8NoBom As New System.Text.UTF8Encoding(False)

    Sub DialogError(context)
        MsgBox(context, vbCritical + vbOKOnly, "Error")
    End Sub

    Function DialogWarningThree(context)
        Return MsgBox(context, vbExclamation + vbYesNoCancel, "Warning")
    End Function

    Function FunctionFileOpen()
        Dim t
        t = 0
        Try
            If DialogFileOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
                t = DialogFileOpen.FileName
            End If
        Catch e As Exception
            DialogError(e.Message)
        End Try
        Return t
    End Function
    Sub SubFileSave(context, text)
        Try
            My.Computer.FileSystem.WriteAllText(context, text, False, utf8NoBom)
        Catch e As Exception
            DialogError(e.Message)
        End Try
    End Sub

    Sub SubRun(context, text)
        Try
            With ProcessMain.StartInfo
                .FileName = context
                .Arguments = text
                .UseShellExecute = False
                .WorkingDirectory = My.Computer.FileSystem.CurrentDirectory
            End With
            ProcessMain.EnableRaisingEvents = True
            ProcessMain.Start()
        Catch e As Exception
            DialogError(e.Message)
        End Try
    End Sub
    Private Sub ButtonOpenMain_Click(sender As Object, e As EventArgs) Handles ButtonOpenMain.Click
        fileName = FunctionFileOpen()
        If My.Computer.FileSystem.GetFileInfo(fileName).Length >= 1024 ^ 2 Then
            If DialogWarningThree("File is bigger than 1MB, are you sure?") <> vbYes Then Exit Sub
        End If
        TextboxMain.Text = My.Computer.FileSystem.ReadAllText(fileName)
    End Sub

    Private Sub ButtonSaveMain_Click(sender As Object, e As EventArgs) Handles ButtonSaveMain.Click
        SubFileSave(fileName, TextboxMain.Text)
    End Sub

    Private Sub ButtonStopMain_Click(sender As Object, e As EventArgs) Handles ButtonStopMain.Click
        ProcessMain.Kill()
    End Sub

    Private Sub ButtonRunMain_Click(sender As Object, e As EventArgs) Handles ButtonRunMain.Click
        ButtonStopMain.Enabled = True
        ButtonRunMain.Enabled = False
        SubFileSave("debug.vbs", TextboxMain.Text)
        SubRun("wscript.exe", "debug.vbs")

    End Sub

    Private Sub ProcessMain_Exited(sender As Object, e As EventArgs) Handles ProcessMain.Exited
        ButtonStopMain.Enabled = False
        ButtonRunMain.Enabled = True
    End Sub
End Class
