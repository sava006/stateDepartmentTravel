<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.checkstateDeptravelAdvisories = New System.Windows.Forms.Button()
        Me.lblreport = New System.Windows.Forms.Label()
        Me.currentStateDepTravelAdivisorybackgroundworker = New System.ComponentModel.BackgroundWorker()
        Me.Advisorydiscriptionbackgroundworker = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkstateDeptravelAdvisories
        '
        Me.checkstateDeptravelAdvisories.Location = New System.Drawing.Point(12, 264)
        Me.checkstateDeptravelAdvisories.Name = "checkstateDeptravelAdvisories"
        Me.checkstateDeptravelAdvisories.Size = New System.Drawing.Size(75, 103)
        Me.checkstateDeptravelAdvisories.TabIndex = 0
        Me.checkstateDeptravelAdvisories.Text = "check state dep warnings concering your trip"
        Me.checkstateDeptravelAdvisories.UseVisualStyleBackColor = True
        '
        'lblreport
        '
        Me.lblreport.AutoSize = True
        Me.lblreport.Location = New System.Drawing.Point(133, 62)
        Me.lblreport.Name = "lblreport"
        Me.lblreport.Size = New System.Drawing.Size(0, 13)
        Me.lblreport.TabIndex = 2
        '
        'currentStateDepTravelAdivisorybackgroundworker
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(247, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Red
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"afghanistan af", "albania al", "algeria dz", "american-somas as", "andorra ad", "angola ao", "antartica aq", "antigua and barbuda ag", "argentina ar", "armenia am", "australia au", "austria at", "azerbaijan az", "bahamas bs", "bahrain bh", "bangladesh bd", "barbados bb", "belarus by", "belgium be", "belize bz", "benin bj", "bhutan bt", "boliva bo", "bosna and herzegovina  bq", "botswana bw", "brazil br", "brunei bn", "bulgaria bg", "burkina faso bf", "burundi bi", "cabo verde ky", "cambodia kh", "cameroon cm", "central-african-republic cf", "chad td", "chile cl", "china cn", "colombia co", "comoros km", "congo cg", "democratic-reublic-of-the-congo  cd", "costa-rica ck", "cote d'ivoire ci", "croatia hr", "cuba cu", "cyprus cy", "czech-republic cz", "denmark dk", "djibouti dj", "dominica dm", "domincan-republic do", "ecuador ec", "egypt eg", "el-salvador sv", "equatorial-guinea gq", "eritrea er", "estonia ee", "ethiopia et", "fiji fj", "finland fi", "france fr", "gabon ga", "georgia ge", "germany de", "ghana gh", "greece gr", "grenada gd", "guatemala gt", "guinea gn", "guinea-bissau gw", "guyana gy", "haiti ht", "honduras hn", "hungary hu", "iceland is", "india in", "indonesia id", "iran ir", "iraq iq", "ireland ie", "israel il", "italy it", "jamaica jm", "japan jp", "jordan jo", "kazakhstan kz", "kenya ke", "kirbati ki", "kosovo kp", "kuwait kw", "kyrgystan kg", "laos la", "lativia lv", "lebanon lb", "lesotho ls", "liberia lr", "libya ly", "liechtenstein li", "lithuania lt", "luxembourg lu", "macedonia mk", "madagascar mg", "malawi mw", "malaysia my", "maldives mv", "mali ml", "malta mt", "marshall-islands mh", "mauritania mr", "mauritius mu", "mexico mx", "micronesia fm", "moldova md", "monaco mc", "mongloia mn", "montenegro me", "morocco ma", "mozambique mz", "myanmar mm", "nambia na", "nauru nr", "nepal np", "netherlands nl", "new zealand nz", "nicaragua ni", "niger ne", "nigeria ng", "north-korea kp", "norway no", "oman om", "pakistan pk", "palau pw", "palestine ps", "panama pa", "papau-new-guinea pg", "paragguay  py", "peru pe", "philippines ph", "poland pl", "portugal pt", "qatar qa", "romania ro", "russia ru", "rwanda rw", "st.-kitts-and-nevis kn", "st. lucia lc", "st.-vincent-and-grenadines vc", "samoas ws", "san-marinao sm", "sao-tome -and -principe st", "saudi-arabia sa", "senegal sn", "serbia rs", "seychelles sc", "sierra-leone sl", "sinagpore sg", "slovakia sk", "slovenia si", "solomon-islands sb", "somalia so", "south africa za", "south-korea kr", "south-sudan ss", "spain es", "suriname sr", "swaziland sz", "sweden se", "switzerland ch", "syria sy", "taiwan tw", "tajikistan tj", "tanzania tz", "thailand th", "timor-leste tl", "togo tg", "tonga to", "trinidad-and-tobago tt", "tunisia tn", "turkey tr", "turkmenistan tm", "tuvalu tv", "uganda ug", "ukraine ua", "united-arab-emirates ae", "united-Kingdom gb", "usa us", "uruguay uy", "uzbekistann uz", "vanuatu vu", "vatican-city va", "venezuela ve", "vietnam vn", "yemen ye", "zambia zm", "zimbabwe zw"})
        Me.ComboBox1.Location = New System.Drawing.Point(61, 168)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "selet a country"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 399)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(259, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 15)
        Me.Label1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(283, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.stateDepartmentTravel.My.Resources.Resources.spaceworldview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 473)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblreport)
        Me.Controls.Add(Me.checkstateDeptravelAdvisories)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkstateDeptravelAdvisories As System.Windows.Forms.Button
    Friend WithEvents lblreport As System.Windows.Forms.Label
    Friend WithEvents currentStateDepTravelAdivisorybackgroundworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Advisorydiscriptionbackgroundworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
