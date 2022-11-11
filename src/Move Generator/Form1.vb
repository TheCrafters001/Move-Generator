Imports Squirrel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SquirrelAwareApp.HandleEvents(onInitialInstall:=AddressOf OnAppInstall, onAppUninstall:=AddressOf OnAppUninstall, onEveryRun:=AddressOf OnAppRun)
        UpdateMyApp()

        category_cmbBox.SelectedIndex = 0
        targets_cmbBox.SelectedIndex = 0
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        Generator.CreateMove()
    End Sub


    Private Shared Sub OnAppInstall(ByVal version As SemanticVersion, ByVal tools As IAppTools)
        tools.CreateShortcutForThisExe(ShortcutLocation.StartMenu Or ShortcutLocation.Desktop)
    End Sub

    Private Shared Sub OnAppUninstall(ByVal version As SemanticVersion, ByVal tools As IAppTools)
        tools.RemoveShortcutForThisExe(ShortcutLocation.StartMenu Or ShortcutLocation.Desktop)
    End Sub

    Private Shared Sub OnAppRun(ByVal version As SemanticVersion, ByVal tools As IAppTools, ByVal firstRun As Boolean)
        tools.SetProcessAppUserModelId()
    End Sub

    Private Shared Async Function UpdateMyApp() As Task
        Dim mgr = New GithubUpdateManager("https://github.com/TheCrafters001/Move-Generator/releases/latest")

        Dim newVersion = Await mgr.UpdateApp()

        If newVersion IsNot Nothing Then
            UpdateManager.RestartApp()
        End If
    End Function
End Class
