Imports System.Security.Cryptography
Public Class main
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click

        Using fld As New FolderBrowserDialog
            With fld
                .Description = $"어도비 애프터 이펙트가 설치된 폴더(Adobe After Effect CC ~)를 선택하세요."
                .SelectedPath = $"{My.Computer.FileSystem.SpecialDirectories.ProgramFiles}\Adobe\"

                If (.ShowDialog = DialogResult.OK) Then
                    LocationBox.Text = $"{ .SelectedPath}\Support Files\Presets"
                    If Not My.Computer.FileSystem.DirectoryExists(LocationBox.Text) Then
                        StatusLabel1.ForeColor = Color.Red
                        StatusLabel1.Text = $"프리셋 폴더를 찾을 수 없습니다.{w}애프터 이펙트가 설치된 폴더를 지정해주세요."
                    Else
                        StatusLabel1.ForeColor = Color.Blue
                        StatusLabel1.Text = $"프리셋 폴더를 찾았습니다.{w}이제 다음 작업을 진행하실 수 있습니다."
                        SearchBtn.Enabled = False
                        Panel1.Enabled = True
                    End If


                End If

            End With
        End Using

    End Sub

    Private Sub CngToHangul_Click(sender As Object, e As EventArgs) Handles CngToHangul.Click
        ChangeLanguage(True)
    End Sub

    Private Sub CngToEnglish_Click(sender As Object, e As EventArgs) Handles CngToEnglish.Click
        ChangeLanguage(False)
    End Sub

    Enum State
        OK = 0
        SameName
        ShareName
        NoFile
        UnKnown
        NoDatabase
    End Enum

    Private Sub ChangeLanguage(ByVal isHangul As Boolean)
        RichTextBox1.Clear()
        Log($"작업 시작을 준비중입니다...")
        Dim index As Integer = IIf(isHangul, 1, 2)
        Dim LogWrite As Boolean = CheckBox1.Checked
        Dim LogFileName As String = $"{My.Application.Info.DirectoryPath}\Log-{Now.Hour}{Now.Minute}{Now.Second}.txt"
        Dim fList As New List(Of String)
        Dim HashDataList As New List(Of String)
        Dim Result(6) As Integer
        Dim isInDB As Boolean
        HashDataList.AddRange(Split(My.Resources.PresetLangData, w))

        For Each pos As String In My.Computer.FileSystem.GetFiles(LocationBox.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.ffx")
            fList.Add(pos)
        Next

        While (fList.Count)
            isInDB = False
            If fList(0) = Nothing Then
                Continue While
            End If
            Log($"{Replace(fList(0), LocationBox.Text, "")}")
            If Not (My.Computer.FileSystem.FileExists(fList(0))) Then
                Log($" >> 해당하는 파일이 존재하지 않습니다.")
                Result(State.NoFile) += 1
            Else
                Dim fData() As Byte = My.Computer.FileSystem.ReadAllBytes(fList(0))
                Using sha As SHA256 = SHA256.Create()
                    Dim HashString As String = GetHashString(sha.ComputeHash(fData))
                    For Each v As String In HashDataList
                        Dim data() As String = Split(v, " | ")
                        If HashString = data(0) Then
                            Try
                                My.Computer.FileSystem.RenameFile(fList(0), data(index))
                                Result(State.OK) += 1
                                Log($" >> {data(index)}")
                            Catch ex As Exception
                                Dim LogTemp As String
                                If data(1) = data(2) Then
                                    Result(State.ShareName) += 1
                                    Log($" >> 한/영 이름이 동일합니다.")
                                    LogTemp = $"{fList(0)}{w}  >> {data(index)}{w}파일명 동일"
                                ElseIf GetFileName(fList(0)) = data(index) Then
                                    Result(State.SameName) += 1
                                    Log($" >> 이전 파일명과 같게 작성중입니다.")
                                    LogTemp = $"{fList(0)}{w}  >> {data(index)}{w}이전 파일명과 같게 작성"
                                Else
                                    Result(State.UnKnown) += 1
                                    Log($" >> 알 수 없는 오류입니다.")
                                    Log($" >> 프로그램 권한을 확인하세요.")
                                    LogTemp = $"{fList(0)}{w}  >> {data(index)}{w}{ex.Message}{w _
                                                                }-----------------------------------------"
                                End If
                                If (LogWrite) Then
                                    My.Computer.FileSystem.WriteAllText(LogFileName, LogTemp, True)
                                End If
                            End Try
                            isInDB = True
                            Exit For
                        End If
                    Next
                    If isInDB = False Then
                        Log($" >> DB에 존재하지 않는 파일")
                        Result(State.NoDatabase) += 1
                    End If
                End Using

            End If

            fList.RemoveAt(0)
        End While
        Log("")
        Log("")
        Log("")
        Log("----------------결과 보고----------------")
        Log($"전체 파일 : {Result(State.OK) + Result(State.NoFile) + Result(State.SameName) + Result(State.ShareName) +
            Result(State.UnKnown) + Result(State.NoDatabase)}")
        Log($"정상 처리 : {Result(State.OK)}")
        Log($"비정상 처리 : {Result(State.NoFile) + Result(State.SameName) + Result(State.ShareName) +
            Result(State.UnKnown) + Result(State.NoDatabase)}")
        Log($" >> 파일 없음 : {Result(State.NoFile)}")
        Log($" >> 변경 전/후 같은 이름 : {Result(State.SameName)}")
        Log($" >> 한/영 파일명 동일 : {Result(State.ShareName)}")
        Log($" >> DB에 없는 파일 : {Result(State.NoDatabase)}")
        Log($" >> 알 수 없음 : {Result(State.UnKnown)}")

    End Sub

    Private Function GetFileName(ByVal pos As String) As String
        Dim temp As String
        temp = StrReverse(pos)
        temp = Mid(temp, 1, InStr(temp, "\") - 1)
        Return StrReverse(temp)
    End Function

    Private Function GetHashString(ByVal b() As Byte) As String
        Dim temp As String = Nothing

        For i = 0 To b.Count - 1
            temp &= $"{b(i):X2}"
        Next
        Return temp
    End Function

    Private Sub Log(ByVal str As String, Optional ByVal isNewLine As Boolean = True)
        With RichTextBox1
            .Text &= str & IIf(isNewLine, w, "")
            .SelectionStart = .TextLength
            .ScrollToCaret()
            .Refresh()
        End With
    End Sub

End Class
