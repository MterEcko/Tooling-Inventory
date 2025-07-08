Public Class ClassAsemblys
    Dim IdAsembly As Integer

    Dim Final As String
    Dim TD As String
    Dim HM As String
    Dim SM As String

    Dim Proyecto As String
    Dim Familia As String

    Dim PCB As String
    Dim WG As String

    Dim Pad As String
    Dim PadX As String

    Dim Stencil As String
    Dim Router As String
    Dim Selectiva As String
    Dim Regular As String
    Dim Conformal As String
    Dim Comentarios As String


    'Dim IdProvedorStencil As String

    Public Property IdAsem() As String
        Get
            Return Me.IdAsembly
        End Get
        Set(value As String)
            Me.IdAsembly = value
        End Set
    End Property

    Public Property Fin() As String
        Get
            Return Me.Final
        End Get
        Set(value As String)
            Me.Final = value
        End Set
    End Property


    Public Property T() As String
        Get
            Return Me.TD
        End Get
        Set(value As String)
            Me.TD = value
        End Set
    End Property

    Public Property H() As String
        Get
            Return Me.HM
        End Get
        Set(value As String)
            Me.HM = value
        End Set
    End Property

    Public Property S() As String
        Get
            Return Me.SM
        End Get
        Set(value As String)
            Me.SM = value
        End Set
    End Property

    'Public Property Proy() As String
    'Get
    'Return Me.Proyecto
    'End Get
    'Set(value As String)
    'Me.Proyecto = value
    'End Set
    'End Property

    Public Property PC() As String
        Get
            Return Me.PCB
        End Get
        Set(value As String)
            Me.PCB = value
        End Set
    End Property

    Public Property Com() As String
        Get
            Return Me.Comentarios
        End Get
        Set(value As String)
            Me.Comentarios = value
        End Set
    End Property
End Class
