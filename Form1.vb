Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Xml.XmlElement
Imports System.Xml.Serialization
Imports System.Xml.XPath
'Imports stateDepartmentTravel
'Imports System.Globalization

'Public Class samaplesCultureInfo
'    Public Shared Sub Main()
'        'Display several properrties 

'    End Sub
'End Class
Public Class Form1

    Private _countryletters As Object

    Private Property countryletters(Item As String) As Object
        Get
            Return _countryletters
        End Get
        Set(value As Object)
            _countryletters = value
        End Set
    End Property


Private Sub Button1_Click(sender As Object, e As EventArgs) Handles checkstateDeptravelAdvisories.Click
        'Dim statedepAdvisoryWindow As StateDepAdivisory = New StateDepAdivisory
        'statedepAdvisoryWindow.Show()


        ''http://travel.state.gov/_res/rss/TWs.xml


    ' Dim xmlNode As String = <?xmlns:dc ="http://purl.org/dc/elements/1.1/" version="2.0"?>

    ''Dim doc = XDocument.Load("http://travel.state.gov/_res/rss/TAs.xml")
    ''Dim serializer As XmlSerializer = New XmlSerializer(GetType(Tabel_of_contries_descriptions))
    ''Dim Table As Tabel_of_contries_descriptions = CType(serializer.CanDeserialize(HtmlDocument.Write(doc)), Tabel_of_contries_descriptions)

    ''(File.OpenRead("http://travel.state.gov/_res/rss/TAs.xml")))
    'For Each Desprition As description_of_country In

    '    Dim country As Integer = Desprition.descprition
    'Next
    'Dim docUrl As XmlDocument = New XmlDocument()
    'docUrl.Load("http://travel.state.gov/_res/rss/TAs.xml")
    'Dim descriptons As String = docUrl.SelectNode("descrpition").InnerText
    Dim doc = XDocument.Load("http://travel.state.gov/_res/rss/TWs.xml")
    'Dim members = From m In doc.Element("

    Dim travelConditionsURL As String = "http://travel.state.gov/_res/rss/TWs.xml"
    ListBox1.Text = "Fetching state department travel report for your country...."
    If Not currentStateDepTravelAdivisorybackgroundworker.IsBusy Then
        currentStateDepTravelAdivisorybackgroundworker.RunWorkerAsync(travelConditionsURL)
    End If
End Sub


Private Sub currentStateDepTravelAdivisorybackgroundworker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles currentStateDepTravelAdivisorybackgroundworker.DoWork
    Dim url As String = CStr(e.Argument)
    Dim webRequestTravelCConditions As WebRequest = WebRequest.Create(url)
    Dim conditionsResponseStream As Stream = webRequestTravelCConditions.GetResponse.GetResponseStream()
    Dim xmlTravelAdvisoryReader As New XmlDocument
    xmlTravelAdvisoryReader.Load(conditionsResponseStream)
    Dim travelwarningNode As XmlNode = xmlTravelAdvisoryReader.SelectSingleNode("//guid")
    Dim resultString As String = "travel conditions : " & travelwarningNode.InnerText
    e.Result = resultString

End Sub


Public Sub currentStateDepTravelAdivisorybackgroundworker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles currentStateDepTravelAdivisorybackgroundworker.RunWorkerCompleted
    If IsNothing(e.Error) Then
        ListBox1.Text = CStr(e.Result)
    Else
        If TypeOf e.Error Is WebException Then
            MessageBox.Show("Error connecting to State Dep Page" & vbNewLine & e.Error.Message, "Error!")
        ElseIf TypeOf e.Error Is NullReferenceException Then
            ListBox1.Text = "Your destination country is not under a current state department warning or alter. Have A Great Trip"

        Else
            MessageBox.Show("error occured" & vbNewLine & e.Error.Message, "Error")

        End If
    End If

End Sub


Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim countries As String() = New String() {"afghanistan", "albania", "algeria", "andorra", "antigua-and-barbuda", "argentina", "armenia", "australia",
                                 "austria", "azerbaijan", "bahamas", "bahrain", "bangladesh", "barbados",
                                 "belarus", "belgium", "belize", "benin", "bhutan", "boliva", "bosna and herzegovina", "botswana", "brazil", "brunei",
                                 "bulgaria", "burkina faso", "burundi", "cabo verde", "cambodia", "cameroon", "central-african-republic",
                                 "chad", "chile", "china", "colombia", "comoros", "congo", "democratic reublic of the congo",
                                 "costa-rica", "cote d'ivoire", "croatia", "cuba", "cyprus", "czech-republic", "denmark", "djibouti", "dominica",
                                 "domincan-republic", "ecuador", "egypt", "el-salvador", "equatorial-guinea", "eritrea", "estonia", "ethiopia",
                                 "fiji", "finland", "france", "gabon", "georgia", "germany", "ghana", "greece", "grenada", "guatemala", "guinea",
                                 "guinea-bissau", "guyana", "haiti", "honduras", "hungary", "iceland", "india", "indonesia", "iran", "iraq",
                                 "ireland", "israel", "italy", "jamaica", "japan", "jordan", "kazakhstan", "kenya", "kirbati", "kosovo", "kuwait",
                                 "kyrgystan", "laos", "lativia", "lebanon", "lesotho", "liberia", "libya", "liechtenstein", "lithuania", "luxemboug",
                                 "macedonia", "madagascar", "malawi", "malaysia", "maldives", "mali", "malta", "marshall-islands", "mauritania",
                                 "mauritius", "mexico", "micronesia", "monaco", "mongloia", "montenegro", "morocco", "mozambique", "myanmar", "nambia",
                                 "nauru", "nepal", "netherlands", "new zealand", "nicaragua", "niger", "nigeria", "north-korea", "norway", "oman",
                                 "pakistan", "palau", "palestine", "panama", "papau-new-guinea", "paragguay", "peru", "philippines", "poland",
                                 "portugal", "qatar", "romania", "russia", "rwanda", "st.-kitts-and-nevis", "st. lucia", "st.-vincent-and-grenadines",
                                 "samoas", "san-marinao", "sao-tome-and-rincipe", "saudi-arabia", "senegal", "serbia", "seychelles", "sierra-leone",
                                 "sinagpore", "slovakia", "slovenia", "solomon-islands", "somalia", "south africa", "south-korea", "south-sudan",
                                 "spain", "suriname", "swaziland", "sweden", "switzerland", "syria", "taiwan", "tajikistan", "tanzania", "thailand",
                                 "timor-leste", "togo", "tonga", "trinidad-and-tobago", "tunisia", "turkey", "turkmenistan", "tuvalu", "uganda", "ukraine",
                                 "united-arab-emirates", "uk", "usa", "uruguay", "uzbekistan", "vanuatu", "vatican-city", "venezuela", "vietnam", "yemen",
                                 "zambia", "zimbabwe"}
        Dim countryletters As String() = New String() {"af", "al", "dz", "as", "ad", "ao", "ai", "aq", "ag", "ar", "am", "aw", "au", "at", "az", "bs", "bh", "bd",
                                       "bb", "by", "be", "bz", "bj", "bm", "bt", "bo", "bw", "bv", "br", "io", "bn", "bg", "bf", "bi", "kh", "cm", "ca",
                                       "cv", "ky", "cf", "td", "cl", "cn", "cx", "cc", "co", "km", "cg", "cd", "ck", "cr", "ci", "hr", "cu", "cy", "cz",
                                       "dk", "dj", "dm", "do", "tp", "ec", "eg", "sv", "gq", "er", "ee", "et", "fk", "fo", "fj", "fi", "fr", "fx", "gf",
                                       "pf", "tf", "ga", "gm", "ge", "ge", "de", "gh", "gi", "gr", "gl", "gd", "gp", "gu", "gt", "gn", "gw", "gy", "ht",
                                       "hm", "va", "hn", "hk", "hu", "is", "in", "id", "ir", "iq", "ie", "il", "it", "jm", "jp", "jo", "kz", "ke", "ki",
                                       "kp", "kr", "kw", "kg", "la", "lv", "lb", "ls", "lr", "ly", "li", "lt", "lu", "mo", "mk", "mg", "mw", "my", "mv",
                                       "ml", "mt", "mh", "mq", "mr", "mu", "yt", "mx", "fm", "md", "mc", "mn", "me", "ms", "ma", "mz", "mm", "na", "nr",
                                       "np", "nl", "an", "nc", "nz", "ni", "ne", "ng", "nu", "nf", "mp", "no", "om", "pk", "pw", "pa", "pg", "py", "pe",
                                       "ph", "pn", "pl", "pt", "pr", "qa", "re", "ru", "rw", "kn", "lc", "vc", "ws", "sm", "st", "sa", "sn", "rs", "sc",
                                       "sl", "sg", "sk", "si", "sb", "so", "za", "ss", "gs", "es", "lk", "sh", "pm", "sd", "sr", "sz", "se", "ch", "sy",
                                       "tw", "tj", "tz", "th", "tg", "tk", "to", "tt", "tn", "tr", "tm", "tc", "tv", "ug", "ua", "ae", "gb", "us", "um",
                                       "uy", "uz", "vu", "ve", "vn", "vg", "vi", "wf", "eh", "ye", "zm", "zw"}

        For Each element As String In countries
            countries(CInt(element)) = countryletters(CInt(element))

        Next

        For Each item As String In countries

        Next

        'Form1.BackgroundImage = Image
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = ComboBox1.Text.ToString()
        Dim iz As String = id.Substring(id.Length - 2)
        Dim lz As String = id.Remove(id.Length - 3)
        'TextBox1.Text = id.Substring(id.Length - 2)
        Dim folder As String = "C:\Users\Harry\Desktop\flags\flag icons"
        'TextBox1.Text = CStr(id.Length - 2).ToString
        Dim filename As String = System.IO.Path.Combine(folder, iz & ".png")
        'Dim filename As String = System.IO.Path.Combine(folder)
        PictureBox1.Image = Image.FromFile(filename)
        Label1.Text = "The Flag of " & lz
        'StateDepAdivisory.TextBox1.Text = ComboBox1.Text

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Function countries(Item As String) As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim statedepAdvisoryWindow As StateDepAdivisory = New StateDepAdivisory
        'statedepAdvisoryWindow.Show()
        Dim Obj As New StateDepAdivisory
        Obj.GlobalString = ComboBox1.Text.ToString().Substring(ComboBox1.Text.Length - 2).ToUpper()
        Obj.Show()
        'Me.Hide()

    End Sub

   
End Class
