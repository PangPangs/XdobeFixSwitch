<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LocationBox = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CngToEnglish = New System.Windows.Forms.Button()
        Me.CngToHangul = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "어도비 애프터 이펙트 경로"
        '
        'LocationBox
        '
        Me.LocationBox.BackColor = System.Drawing.Color.White
        Me.LocationBox.Location = New System.Drawing.Point(14, 24)
        Me.LocationBox.Name = "LocationBox"
        Me.LocationBox.ReadOnly = True
        Me.LocationBox.Size = New System.Drawing.Size(635, 21)
        Me.LocationBox.TabIndex = 1
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(533, 51)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(116, 32)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "경로 찾기"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.CngToEnglish)
        Me.Panel1.Controls.Add(Me.CngToHangul)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(14, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 259)
        Me.Panel1.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RichTextBox1.Location = New System.Drawing.Point(135, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(500, 259)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'CngToEnglish
        '
        Me.CngToEnglish.Location = New System.Drawing.Point(13, 97)
        Me.CngToEnglish.Name = "CngToEnglish"
        Me.CngToEnglish.Size = New System.Drawing.Size(116, 32)
        Me.CngToEnglish.TabIndex = 2
        Me.CngToEnglish.Text = "영어로 변경"
        Me.CngToEnglish.UseVisualStyleBackColor = True
        '
        'CngToHangul
        '
        Me.CngToHangul.Location = New System.Drawing.Point(13, 59)
        Me.CngToHangul.Name = "CngToHangul"
        Me.CngToHangul.Size = New System.Drawing.Size(116, 32)
        Me.CngToHangul.TabIndex = 1
        Me.CngToHangul.Text = "한글로 변경"
        Me.CngToHangul.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-2, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "프리셋 이름 한/영 전환"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Location = New System.Drawing.Point(12, 51)
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(515, 32)
        Me.StatusLabel1.TabIndex = 4
        Me.StatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(637, 46)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "미디어 편집자가 보다 나은 환경에서 작업할 수 있도록 도움을 드리고자 만든 프로그램입니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://pang2h.tistory.com/ 에" &
    "서 정식으로 다운로드 받을 수 있습니다."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(13, 231)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 16)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "로그파일 작성"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 406)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.LocationBox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LocationBox As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusLabel1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CngToEnglish As Button
    Friend WithEvents CngToHangul As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
