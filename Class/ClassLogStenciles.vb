Public Class ClassLogStenciles
    Dim IdLog As Integer
    Dim LogTexto As String
    Dim LogUser As String
    Dim LogFecha As String


    Public Property Id() As String
        Get
            Return Me.IdLog
        End Get
        Set(value As String)
            Me.IdLog = value
        End Set
    End Property
    Public Property Text() As String
        Get
            Return Me.LogTexto
        End Get
        Set(value As String)
            Me.LogTexto = value
        End Set
    End Property

    Public Property User() As String
        Get
            Return Me.LogUser
        End Get
        Set(value As String)
            Me.LogUser = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return Me.LogFecha
        End Get
        Set(value As String)
            Me.LogFecha = value
        End Set
    End Property
End Class
