Imports GPV.Db
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Text
Imports System.Data.SqlTypes
Public Class ComboBoxMachines


    Public Property IdMachine() As Integer
    Public Property NombreMachine() As SqlString

    Public Property SeriesNombreMachine As SqlString

    Public Property NombreStencil As SqlString

    Public Overrides Function ToString() As String
        Return NombreMachine
    End Function

    Public Property NombreSten() As String
        Get
            Return Me.NombreStencil
        End Get
        Set(value As String)
            Me.NombreStencil = value
        End Set
    End Property
    Public Property ListMachine() As String
        Get
            Return Me.SeriesNombreMachine
        End Get
        Set(value As String)
            Me.SeriesNombreMachine = value
        End Set
    End Property



End Class

