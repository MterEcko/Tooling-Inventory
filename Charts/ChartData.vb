Public Class ChartData

    Public Property IdCategoria As String
    Public Property Categoria As String

    Public Property MachineToolingXY As String
    Public Property Valor As Double
    Public Property OtraColumna As String

    Public Sub New(idcategoria As String, categoria As String)
        Me.Categoria = categoria
        Me.IdCategoria = idcategoria
    End Sub

End Class