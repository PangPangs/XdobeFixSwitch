Module Initialize

    Public Const w As String = Chr(13)

    Public Sub Initialize()
        With My.Forms.main
            .Text = My.Application.Info.Title
            .Icon = My.Resources.icon

            With .Panel1
                .Enabled = False

            End With


        End With

    End Sub

End Module
