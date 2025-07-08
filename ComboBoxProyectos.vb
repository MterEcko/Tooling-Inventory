Imports GPV.Db
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Text
Imports System.Data.SqlTypes
Public Class ComboBoxProyectos


    Public Property IdProyecto() As Integer
    Public Property NombreProyecto() As SqlString

    Public Overrides Function ToString() As String
        Return NombreProyecto
    End Function


    'Dim IdProyecto As Integer
    'Dim NombreProyecto As String

    'Public Property IdProyect() As Integer
    'Get
    'Return Me.IdProyecto
    'End Get
    'Set(value As Integer)
    'Me.IdProyecto = value
    'End Set
    'End Property


    'Public Property NombreProyect() As String
    '   Get
    'Return Me.NombreProyecto
    'End Get
    '   Set(value As String)
    'Me.NombreProyecto = value
    'End Set
    'End Property

    'Public Property DataSourceProyecto()
    'Get
    'Return Me.ComboBox
    'End Get
    'Set(value)
    '
    'End Set
    'End Property

End Class

'Public Class Combo
'Dim bdconexion As New Db()
'Public DataTable Cargarproyectos

'Public Comando As New SqlCommand("Select * From dbo.Proyectos")
'Public Adapter As New SqlDataAdapter(Comando)

'Public Tabla As New DataTable()




'End Class
