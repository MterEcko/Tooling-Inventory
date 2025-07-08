Public Class ClassSqueegees
    Dim IdSqueegee As Integer
    Dim WidthSqueegee As String
    Dim NombreSqueegee As String
    Dim ComentarioSqueegee As String

    'Dim IdProvedorStencil As String

    'Public Property IdSten() As String
    'Get
    'Return Me.IdStencil
    'End Get
    'Set(value As String)
    'Me.IdStencil = value
    'End Set
    'End Property

    Public Property IdSqueeg() As String
        Get
            Return Me.IdSqueegee
        End Get
        Set(value As String)
            Me.IdSqueegee = value
        End Set
    End Property


    Public Property NombreSquee() As String
        Get
            Return Me.NombreSqueegee
        End Get
        Set(value As String)
            Me.NombreSqueegee = value
        End Set
    End Property

    Public Property WidthSquee() As String
        Get
            Return Me.WidthSqueegee
        End Get
        Set(value As String)
            Me.WidthSqueegee = value
        End Set
    End Property

    Public Property ComentsSquee() As String
        Get
            Return Me.ComentarioSqueegee
        End Get
        Set(value As String)
            Me.ComentarioSqueegee = value
        End Set
    End Property



End Class
