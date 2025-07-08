Imports System.Data.SqlClient
Imports System.Data.SqlTypes


Module DataGridStencil
    'Conexion.Open
    Public IdStencil As String
    Public LocalidadEdit As String
    Public StencilNameEdit As String
    Public EnsambleEdit As String
    Public NumberPartStencilEdit As String

    Public JobEdit As String
    Public ComentariosStencilEdit As String

    Public DanoEdit As String


    Public ListProyectos As String
    Public ListStenciles As String
    Public FechaFabricanteEdit As Date?
    Public FechaRegistroEdit As Date?

    Public XEdit As String
    Public YEdit As String
    Public RevisionEdit As String
    Public Num1TensionEdit As String
    Public Num2TensionEdit As String
    Public Num3TensionEdit As String
    Public Num4TensionEdit As String
    Public Num5TensionEdit As String
    Public ListProvedores As String

    Public Cycles As String

    Public User As String
    Public TotalCycle As String
    Public Log As String
    'Public TablasProyectos As DataTable
    'Public conexion As SqlConnection
    'Public FindEditStencil As String = "SELECT   * FROM dbo.Stencil Where id = '" + Id + "'"
    'Public lector As SqlDataReader
    'Dim ConsulCon As New SqlDataAdapter(consulta, conexionEditStencil)



    'comando = New SqlCommand
End Module
