Imports System.Data.SqlClient
Imports System.Data.SqlTypes


Module DataGridPallet
    'Conexion.Open
    Public IdPallet As String
    Public PalletEnsambleEdit As String
    Public PalletNumberPartEdit As String
    Public PalletNameEdit As String
    Public ListProyectos As String
    Public PalletFechaFabricanteEdit As Date?
    Public PalletXEdit As String
    Public PalletYEdit As String
    Public ListProvedores As String
    Public PalletRevisionEdit As String
    Public PalletJobEdit As String
    Public PalletLocalidadEdit As String
    Public PalletCyclesEdit As String
    Public PalletXArrayEdit As String
    Public PalletYArrayEdit As String
    Public PalletQtyEdit As String
    Public ListMachines As String
    Public PalletComentariosEdit As String

    Public PalletDanoEdit As Integer


    Public PalletFechaRegistroEdit As Date?

    Public Machine As String

    Public IdSetup As String
    'Public TablasProyectos As DataTable
    'Public conexion As SqlConnection
    'Public FindEditStencil As String = "SELECT   * FROM dbo.Stencil Where id = '" + Id + "'"
    'Public lector As SqlDataReader
    'Dim ConsulCon As New SqlDataAdapter(consulta, conexionEditStencil)



    'comando = New SqlCommand
End Module
