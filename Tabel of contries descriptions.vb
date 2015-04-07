Imports System.Xml.Serialization

Public Class Tabel_of_contries_descriptions
    <XmlElement("description")> _
    Public descriptions As List(Of description_of_country)

End Class
