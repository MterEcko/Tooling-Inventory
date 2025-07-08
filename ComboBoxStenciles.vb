Imports System.Data.SqlTypes

Public Class ComboBoxStenciles
    Public Property IdStencil() As Integer
    Public Property NombreStencil() As SqlString

    Public Overrides Function ToString() As String
        Return NombreStencil
    End Function
End Class
