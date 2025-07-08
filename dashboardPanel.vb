Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Text
Imports System.Data.SqlTypes
Imports System.Windows.Forms.DataVisualization.Charting

Public Class dashboardPanel
    Dim bdconexion As New Db()
    'Dim Machines As New ComboBoxMachines()



    Private Sub dashboardPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ChartTensionStenciles.Series.Clear()
        ' Crear la lista de datos
        'Dim datos As New List(Of (NombreProyecto As String, Tensiones As List(Of Double))) From
        '{
        '("Proyecto1", New List(Of Double) From {20.5, 32.2, 3.8, 14.5, 30.1}),
        '("Proyecto2", New List(Of Double) From {9.8, 11.2, 13.5, 14.0, 15.7}),
        '("Proyecto3", New List(Of Double) From {20.5, 32.2, 3.8, 14.5, 30.1}),
        '("Proyecto4", New List(Of Double) From {9.8, 11.2, 13.5, 14.0, 15.7}),
        '("Proyecto5", New List(Of Double) From {11.0, 12.5, 13.0, 14.2, 16.0})'}

        ' Configurar el control Chart
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        Dim chartArea As New ChartArea()
        Chart1.ChartAreas.Add(chartArea)

        ' Configurar las series de caja y bigotes
        'For Each Proyecto1 In datos
        'Dim series As New Series(Proyecto1.NombreProyecto)
        'Series.ChartType = SeriesChartType.BoxPlot

        'Dim tensiones = Proyecto1.Tensiones.ToArray()
        'Dim punto As New DataPoint()
        'punto.YValues = tensiones
        'punto.AxisLabel = Proyecto1.NombreProyecto
        'Series.Points.Add(punto)

        ' Agregar la serie al control Chart
        'Chart1.Series.Add(series)
        'Next

        'Dim datosTensiones As New List(Of (NombreTension As String, Datos As List(Of Double)))()
        'datosTensiones.Add(("Tension 1", New List(Of Double) From {10.5, 12.2, 13.8, 14.5, 15.1}))
        'datosTensiones.Add(("Tension 2", New List(Of Double) From {40.8, 11.2, 13.5, 14.0, 15.7}))
        'datosTensiones.Add(("Tension 3", New List(Of Double) From {10.8, 11.2, 13.5, 14.0, 15.7}))
        'datosTensiones.Add(("Tension 4", New List(Of Double) From {65.8, 11.2, 13.5, 14.0, 15.7}))
        'datosTensiones.Add(("Tension 5", New List(Of Double) From {9.8, 11.2, 13.5, 14.0, 15.7}))
        ' Agregar más tensiones según tus necesidades

        ' Configurar el gráfico
        'ConfigurarGraficoCajaYBigotes(Chart1)

        ' Actualizar el gráfico
        'ActualizarGraficoCajaYBigotes(Chart1, datosTensiones)

        Dim chartDataList As List(Of ChartData) = bdconexion.GetChartData()

        bdconexion.CountTooling()

        ToolingTopMachine.Series.Clear()
        DanosChart.Series.Clear()

        For Each chartData In chartDataList
            ToolingTopMachine.Series.Add(chartData.Categoria.ToString)
            DanosChart.Series.Add(chartData.Categoria.ToString)
        Next
        chartDataList.Clear()

        Dim Proyectos = bdconexion.ProyectosChart()
        ToolingTopMachine.ChartAreas("ChartArea1").AxisX.LabelStyle.Angle = -45
        ToolingTopMachine.ChartAreas("ChartArea1").AxisX.LabelStyle.Interval = 1
        DanosChart.ChartAreas("ChartArea1").AxisX.LabelStyle.Angle = -45
        DanosChart.ChartAreas("ChartArea1").AxisX.LabelStyle.Interval = 1
        For Each Proyect In Proyectos

            Dim ClassToolingTopMachineList As List(Of ChartData) = bdconexion.GetChartData()
            For Each chartTooling In ClassToolingTopMachineList

                bdconexion.GetChartDataToolingTopMachine(chartTooling.IdCategoria.ToString, Proyect.IdProyecto.ToString)
                bdconexion.GetDatosParaCriticos(chartTooling.IdCategoria.ToString, Proyect.IdProyecto.ToString)
                If String.IsNullOrEmpty(ChartTotalEnsambles.ConteoMachines) Then
                    ChartTotalEnsambles.ConteoMachines = "0"
                End If
                If String.IsNullOrEmpty(ChartTotalEnsamblesFail.ConteoMachines) Then
                    ChartTotalEnsamblesFail.ConteoMachines = "0"
                End If



                ToolingTopMachine.Series(chartTooling.Categoria.ToString).Points.AddXY(Proyect.NombreProyecto.ToString, ChartTotalEnsambles.ConteoMachines.ToString)
                'ToolingTopMachine.Series(chartTooling.Categoria.ToString).Points.AddY(ChartTotalEnsambles.ConteoMachines.ToString)

                DanosChart.Series(chartTooling.Categoria.ToString).Points.AddXY(Proyect.NombreProyecto.ToString, ChartTotalEnsamblesFail.ConteoMachines.ToString)
                'DanosChart.Series(chartTooling.Categoria.ToString).Points.AddY(Proyect.NombreProyecto.ToString)
                ChartTotalEnsambles.ConteoMachines = "0"
                ChartTotalEnsamblesFail.ConteoMachines = "0"
                'Console.WriteLine("Del proyecto " + Proyect.NombreProyecto.ToString + " de la maquina " + chartTooling.Categoria.ToString + " con un total de " + ChartTotalEnsambles.ConteoMachines.ToString)
                'Console.WriteLine("Del proyecto " + Proyect.NombreProyecto.ToString + " de la maquina " + chartTooling.Categoria.ToString + " con un total de " + ChartTotalEnsamblesFail.ConteoMachines.ToString + " Danados")


            Next
            ClassToolingTopMachineList.Clear()
        Next
        Proyectos.Clear()
        bdconexion.Desconectar()


        Dim ClassToolingTopCountList As List(Of ClassDashboard) = bdconexion.GetChartDataToolingTopCount()

        ToolingTopCount.Series.Clear()
        ToolingTopCount.Series.Add("DataPoint")
        ToolingTopCount.Series("DataPoint").ChartType = SeriesChartType.Pie

        For Each charData In ClassToolingTopCountList
            'bdconexion.GetChartDataTension(charData.ConteoProyectos)
            ToolingTopCount.Series("DataPoint").Points.Add(charData.ConteoProyectos).LegendText = charData.Proyecto + ": " + charData.ConteoProyectos
        Next

        ClassToolingTopCountList.Clear()
        bdconexion.Desconectar()


        TotalUser.Text = Graphics.TotalUsers


        bdconexion.Conectar()
        ComboBoxProyectosListAdd.DataSource = bdconexion.ConsultaComboBoxProyectos()
        Dim IntProyecto As Integer = Convert.ToInt32(DataGridStencil.ListProyectos)
        ComboBoxProyectosListAdd.SelectedIndex = 0

        'ComboBoxStencil.DataSource = bdconexion.ConsultaComboBoxStenciles(ComboBoxProyectosListAdd.SelectedIndex.ToString)
        'Dim IntStencil As Integer = Convert.ToInt32(DataGridStencil.ListStenciles)
        'ComboBoxStencil.SelectedIndex = 0
        bdconexion.Desconectar()



        'LogProyecto = Convert.ToString(IntProyecto)
    End Sub


    Private Sub ConfigurarGraficoCajaYBigotes(chart As Chart)
        'chart.Series.Clear()
        'chart.ChartAreas.Clear()

        ' Configurar el área del gráfico
        'Dim chartArea As New ChartArea()
        'chartArea.BackColor = Color.Transparent ' Establecer el fondo como transparente
        'chart.ChartAreas.Add(chartArea)

        ' Crear una serie
        'Dim serie As New Series("Datos")
        'serie.ChartType = SeriesChartType.BoxPlot
        'serie("BoxPlotWhiskerPercentile") = "15" ' Ajustar el valor según tus necesidades (porcentaje)
        'serie("BoxPlotShowAverage") = "true"
        'serie.Color = Color.Green ' Establecer el color a verde
        'chart.Series.Add(serie)
    End Sub

    'Private Sub ActualizarGraficoCajaYBigotes(chart As Chart, datosTensiones As List(Of '(NombreTension As String, Datos As List(Of Double))))
    ' Limpiar los puntos existentes
    'chart.Series("Datos").Points.Clear()

    ' Agregar datos a la serie
    'For Each tension In datosTensiones
    '   Dim etiqueta As String = tension.NombreTension
    '  chart.Series("Datos").Points.AddY(tension.Datos.ToArray())
    ' chart.Series("Datos").Points.Last().AxisLabel = etiqueta
    'Next
    'End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ComboBoxProyectosListAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProyectosListAdd.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxStencil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStencil.SelectedIndexChanged

    End Sub

    Private Sub BtnUpdateListStenciles_Click(sender As Object, e As EventArgs) Handles BtnUpdateListStenciles.Click
        bdconexion.Conectar()
        ComboBoxStencil.DataSource = bdconexion.ConsultaComboBoxStenciles(ComboBoxProyectosListAdd.SelectedIndex.ToString)
        Dim IntStencil As Integer = Convert.ToInt32(DataGridStencil.ListStenciles)
        ComboBoxStencil.SelectedIndex = 0
        bdconexion.Desconectar()
    End Sub

    Private Sub DanosChart_Click(sender As Object, e As EventArgs) Handles DanosChart.Click

    End Sub

    Private Sub BtnUpdateTensionValuesToChart_Click(sender As Object, e As EventArgs) Handles BtnUpdateTensionValuesToChart.Click
        ' Suponiendo que tu objeto Chart se llama ChartTotalTensiones
        'ChartTensionStenciles.Series.Clear()

        Dim find As String = ComboBoxStencil.SelectedItem.ToString ' Reemplaza con el ID deseado

        ' Obtiene los datos de tensión y el valor de Stencil desde la base de datos
        Dim result As Tuple(Of String, List(Of Double)) = bdconexion.GetChartDataTensionFromStencil(find.ToString)
        Dim stencil As String = result.Item1
        Dim tensionValues As List(Of Double) = result.Item2

        ' Crea una nueva serie para el gráfico de puntos
        Dim seriePuntos As New DataVisualization.Charting.Series(ComboBoxStencil.SelectedItem.ToString)
        seriePuntos.ChartType = DataVisualization.Charting.SeriesChartType.Point

        ' Agrega los puntos a la serie y etiqueta cada punto con el valor de Stencil
        For i As Integer = 0 To tensionValues.Count - 1
            'seriePuntos.Points.AddXY($"TensionValue{i + 1}", tensionValues(i))
            seriePuntos.Points.AddY(tensionValues(i))
        Next

        ' Agrega la serie al gráfico
        ChartTensionStenciles.Series.Add(seriePuntos)
    End Sub

    Private Sub ChartTensionStenciles_Click(sender As Object, e As EventArgs) Handles ChartTensionStenciles.Click

    End Sub

    Private Sub BtnClearTension_Click(sender As Object, e As EventArgs) Handles BtnClearTension.Click
        ChartTensionStenciles.Series.Clear()
    End Sub
End Class