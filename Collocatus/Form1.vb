Imports System.IO

Public Class Form1

    Private Loc As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Grab User Path
        Loc = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        ListView1.Items.Add("test")

    End Sub

    Private Sub MoveFiles(ByVal Dir As String)

        Dim Files As String() = Directory.GetFiles(Loc & Dir)
        Dim File_ As String
        Dim FileDir As String
        Dim FileName As String
        Dim FileExt As String
        Dim MoveFile As Boolean

        Try

            For Each File_ In Files

                FileDir = vbNull
                FileExt = vbNull
                MoveFile = True
                FileName = Path.GetFileNameWithoutExtension(File_)

                If File_.EndsWith(".exe") Then
                    FileDir = "\Programs\Windows\"
                    FileExt = ".exe"
                ElseIf File_.EndsWith(".msi") Then
                    FileDir = "\Programs\Windows\"
                    FileExt = ".msi"
                ElseIf File_.EndsWith(".deb") Then
                    FileDir = "\Programs\Linux\"
                    FileExt = ".deb"
                ElseIf File_.EndsWith(".rpm") Then
                    FileDir = "\Programs\Linux\"
                    FileExt = ".rpm"
                ElseIf File_.EndsWith(".bin") Then
                    FileDir = "\Programs\Linux\"
                    FileExt = ".bin"
                ElseIf File_.EndsWith(".apk") Then
                    FileDir = "\Programs\Android\"
                    FileExt = ".apk"
                ElseIf File_.EndsWith(".air") Then
                    FileDir = "\Programs\"
                    FileExt = ".air"

                ElseIf File_.EndsWith(".XWidgetPkg") Then
                    FileDir = "\Widgets\"
                    FileExt = ".XWidgetPkg"

                ElseIf File_.EndsWith(".mkv") Then
                    FileDir = "\Videos\"
                    FileExt = ".mkv"
                ElseIf File_.EndsWith(".avi") Then
                    FileDir = "\Videos\"
                    FileExt = ".avi"

                ElseIf File_.EndsWith(".ogg") Then
                    FileDir = "\Music\"
                    FileExt = ".ogg"
                ElseIf File_.EndsWith(".mid") Then
                    FileDir = "\Music\"
                    FileExt = ".mid"
                ElseIf File_.EndsWith(".wav") Then
                    FileDir = "\Music\"
                    FileExt = ".wav"
                ElseIf File_.EndsWith(".mp3") Then
                    FileDir = "\Music\"
                    FileExt = ".mp3"
                ElseIf File_.EndsWith(".m4a") Then
                    FileDir = "\Music\"
                    FileExt = ".m4a"

                ElseIf File_.EndsWith(".ico") Then
                    FileDir = "\Pictures\"
                    FileExt = ".ico"
                ElseIf File_.EndsWith(".png") Then
                    FileDir = "\Pictures\"
                    FileExt = ".png"
                ElseIf File_.EndsWith(".gif") Then
                    FileDir = "\Pictures\"
                    FileExt = ".gif"
                ElseIf File_.EndsWith(".jpg") Then
                    FileDir = "\Pictures\"
                    FileExt = ".jpg"
                ElseIf File_.EndsWith(".psd") Then
                    FileDir = "\Pictures\"
                    FileExt = ".psd"

                ElseIf File_.EndsWith(".torrent") Then
                    FileDir = "\Torrents\"
                    FileExt = ".torrent"

                ElseIf File_.EndsWith(".pdf") Then
                    FileDir = "\Documents\"
                    FileExt = ".pdf"
                ElseIf File_.EndsWith(".doc") Then
                    FileDir = "\Documents\"
                    FileExt = ".doc"
                ElseIf File_.EndsWith(".docx") Then
                    FileDir = "\Documents\"
                    FileExt = ".docx"
                ElseIf File_.EndsWith(".csv") Then
                    FileDir = "\Documents\"
                    FileExt = ".csv"
                ElseIf File_.EndsWith(".xls") Then
                    FileDir = "\Documents\"
                    FileExt = ".xls"
                ElseIf File_.EndsWith(".xlsx") Then
                    FileDir = "\Documents\"
                    FileExt = ".xlsx"
                ElseIf File_.EndsWith(".nb") Then
                    FileDir = "\Documents\"
                    FileExt = ".nb"
                ElseIf File_.EndsWith(".md") Then
                    FileDir = "\Documents\"
                    FileExt = ".md"
                ElseIf File_.EndsWith(".txt") Then
                    FileDir = "\Documents\"
                    FileExt = ".txt"
                ElseIf File_.EndsWith(".rtf") Then
                    FileDir = "\Documents\"
                    FileExt = ".rtf"

                ElseIf File_.EndsWith(".crx") Then
                    FileDir = "\Extensions\"
                    FileExt = ".crx"
                ElseIf File_.EndsWith(".xpi") Then
                    FileDir = "\Extensions\"
                    FileExt = ".xpi"

                ElseIf File_.EndsWith(".cpp") Then
                    FileDir = "\Programming\"
                    FileExt = ".cpp"
                ElseIf File_.EndsWith(".h") Then
                    FileDir = "\Programming\"
                    FileExt = ".h"
                ElseIf File_.EndsWith(".php") Then
                    FileDir = "\Programming\"
                    FileExt = ".php"
                ElseIf File_.EndsWith(".py") Then
                    FileDir = "\Programming\"
                    FileExt = ".py"
                ElseIf File_.EndsWith(".rb") Then
                    FileDir = "\Programming\"
                    FileExt = ".rb"
                ElseIf File_.EndsWith(".vb") Then
                    FileDir = "\Programming\"
                    FileExt = ".vb"
                ElseIf File_.EndsWith(".html") Then
                    FileDir = "\Programming\"
                    FileExt = ".html"
                ElseIf File_.EndsWith(".cs") Then
                    FileDir = "\Programming\"
                    FileExt = ".cs"
                ElseIf File_.EndsWith(".cc") Then
                    FileDir = "\Programming\"
                    FileExt = ".cc"

                ElseIf File_.EndsWith(".zip") Then
                    FileDir = "\Archives\"
                    FileExt = ".zip"
                ElseIf File_.EndsWith(".rar") Then
                    FileDir = "\Archives\"
                    FileExt = ".rar"
                ElseIf File_.EndsWith(".tar") Then
                    FileDir = "\Archives\"
                    FileExt = ".tar"
                ElseIf File_.EndsWith(".gz") Then
                    FileDir = "\Archives\"
                    FileExt = ".gz"
                ElseIf File_.EndsWith(".tgz") Then
                    FileDir = "\Archives\"
                    FileExt = ".tgz"

                ElseIf File_.EndsWith(".sql") Then
                    FileDir = "\Backups\"
                    FileExt = ".sql"

                Else
                    MoveFile = False
                End If

                If (MoveFile) Then
                    File.Move(File_, Loc & FileDir & FileName & FileExt)
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub OrganizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizeToolStripMenuItem.Click

        MoveFiles("\Downloads\")
        MoveFiles("\Programs\")
        MoveFiles("\Misc\")

    End Sub

End Class
