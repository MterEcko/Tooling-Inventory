Imports System.Data.SqlTypes

Public Class ComboBoxProvedores
    Public Property IdProvedor() As Integer
    Public Property NombreProvedor() As SqlString

    'Public Property Contacto() As SqlString
    'Public Property Domicilio() As SqlString
    'Public Property NombreProvedor() As SqlString

    Public Overrides Function ToString() As String
        Return NombreProvedor
    End Function
End Class
