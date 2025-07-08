Public Class ClassDashboard

    Public Property IDMachine As String
    Public Property Machine As String
    Public Property IDProyecto As String
    Public Property Proyecto As String
    Public Property ConteoMachines As String
    Public Property ConteoProyectos As String



    Public Sub New(IDMachine As String, Machine As String, IDProyecto As String, Proyecto As String, ConteoMachines As String, ConteoProyectos As String)
        Me.IDMachine = IDMachine
        Me.Machine = Machine
        Me.IDProyecto = IDProyecto
        Me.Proyecto = Proyecto
        Me.ConteoMachines = ConteoMachines
        Me.ConteoProyectos = ConteoProyectos
    End Sub
End Class
