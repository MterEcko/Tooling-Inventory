Public Class ClassUsers
    Dim IdUser As Integer
    Dim Nombre As String
    Dim Apellido As String
    Dim Email As String
    Dim Lvl As String
    Dim PWD As String



    Public Property IdUs() As Integer
        Get
            Return Me.IdUser
        End Get
        Set(value As Integer)
            Me.IdUser = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return Me.Nombre
        End Get
        Set(value As String)
            Me.Nombre = value
        End Set
    End Property



    Public Property LastName() As String
        Get
            Return Me.Apellido
        End Get
        Set(value As String)
            Me.Apellido = value
        End Set
    End Property

    Public Property Mail() As String
        Get
            Return Me.Email
        End Get
        Set(value As String)
            Me.Email = value
        End Set
    End Property


    Public Property Level() As String
        Get
            Return Me.Lvl
        End Get
        Set(value As String)
            Me.Lvl = value
        End Set
    End Property




End Class
