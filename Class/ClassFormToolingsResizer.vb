Imports System.Windows.Forms

Public Class ClassFormToolingsResizer


    Private _beforeWidth As Integer
    Private _beforeHeight As Integer

    ' Variables para almacenar el formulario y el control asociado
    Private WithEvents _form As Form
    Private WithEvents _control As Control

    ' Ratios de redimensionamiento para ancho y alto
    Private _resizeWidthRatio As Double
    Private _resizeHeightRatio As Double

    ' Dimensiones y ubicación originales del control
    Private _originalWidth As Integer
    Private _originalHeight As Integer
    Private _originalLocationX As Integer
    Private _originalLocationY As Integer
    Private _originalFontSize As Integer


    ' Constructor de la clase
    Public Sub New(form As Form, control As Control)
        _form = form
        _control = control
        InitializeResizeRatios()
        InitializeOriginalSize()
    End Sub

    ' Inicializa los ratios de redimensionamiento
    Public Sub InitializeResizeRatios()
        _resizeWidthRatio = _form.ClientSize.Width / _control.Width
        _resizeHeightRatio = _form.ClientSize.Height / _control.Height
        _beforeWidth = _form.Width
        _beforeHeight = _form.Height
    End Sub

    ' Evento Resize del formulario, se llama cuando cambia el tamaño del formulario
    Public Sub _form_Resize(sender As Object, e As EventArgs) Handles _form.Resize
        ResizeControl()
    End Sub

    ' Inicializa el tamaño original del control
    Public Sub InitializeOriginalSize()
        _originalWidth = _control.Width
        _originalHeight = _control.Height
        _originalLocationX = _control.Location.X
        _originalLocationY = _control.Location.Y
        _originalFontSize = _control.Font.Size
    End Sub

    ' Redimensiona el control y ajusta su fuente al cambiar el tamaño del formulario
    Public Sub ResizeControl()
        Dim changeWidthRatio As Double = _form.Width / _beforeWidth
        Dim changeHeightRatio As Double = _form.Height / _beforeHeight

        Dim newWidth As Integer = CInt(_originalWidth * changeWidthRatio)
        Dim newHeight As Integer = CInt(_originalHeight * changeHeightRatio)
        ' Redimensiona el control
        _control.Size = New Size(newWidth, newHeight)

        ' Mueve el control si es necesario
        MoveControl(changeWidthRatio, changeHeightRatio)

        ' Ajusta la fuente del control según el ratio de cambio de altura
        If TypeOf _control Is TextBox Then
            Dim textBox As TextBox = DirectCast(_control, TextBox)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            textBox.Font = New Font(textBox.Font.FontFamily, fontSize + 1)
            'textBox.BackColor = Color.FromArgb(255, 255, 255)
            textBox.ForeColor = Color.FromArgb(255, 255, 255)

        End If

        If TypeOf _control Is Label Then

            Dim label As Label = CType(_control, Label)

            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            Dim LabelSize As Single = fontSize
            label.Font = New Font(label.Font.FontFamily, fontSize)
            'label.BackColor = Color.FromArgb(255, 255, 255)
            label.ForeColor = Color.FromArgb(255, 255, 255)

        End If

        If TypeOf _control Is ComboBox Then
            Dim ComboBox As ComboBox = CType(_control, ComboBox)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            ComboBox.Font = New Font(ComboBox.Font.FontFamily, fontSize)
            ComboBox.ForeColor = Color.FromArgb(255, 255, 255)

        End If

        If TypeOf _control Is RadioButton Then
            Dim RadioButton As RadioButton = CType(_control, RadioButton)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            RadioButton.Font = New Font(RadioButton.Font.FontFamily, fontSize)
            RadioButton.ForeColor = Color.FromArgb(255, 255, 255)
        End If

        If TypeOf _control Is RichTextBox Then
            Dim RichTextBox As RichTextBox = CType(_control, RichTextBox)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            RichTextBox.Font = New Font(RichTextBox.Font.FontFamily, fontSize)
            RichTextBox.ForeColor = Color.FromArgb(255, 255, 255)

        End If

        If TypeOf _control Is DateTimePicker Then
            Dim DateTimePicker As DateTimePicker = CType(_control, DateTimePicker)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            DateTimePicker.Font = New Font(DateTimePicker.Font.FontFamily, fontSize)
            DateTimePicker.ForeColor = Color.FromArgb(255, 255, 255)

        End If

        If TypeOf _control Is Button Then
            Dim Button As Button = CType(_control, Button)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            Button.Font = New Font(Button.Font.FontFamily, fontSize)
            Button.ForeColor = Color.FromArgb(255, 255, 255)
        End If

        If TypeOf _control Is DataGridView Then
            Dim DataGridView As DataGridView = CType(_control, DataGridView)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            DataGridView.Font = New Font(DataGridView.Font.FontFamily, fontSize)
            'DataGridView.BackColor = Color.FromArgb(255, 255, 255)

        End If

        If TypeOf _control Is TabControl Then
            Dim TabControl As TabControl = CType(_control, TabControl)
            Dim fontSize As Single = _originalFontSize * changeHeightRatio
            TabControl.Font = New Font(TabControl.Font.FontFamily, fontSize)
            TabControl.BackColor = Color.FromArgb(255, 255, 255)

        End If

        If TypeOf _control Is Panel Then
            Dim Panel As Panel = CType(_control, Panel)
            'Panel.BackColor = Color.FromArgb(23, 23, 23)

        End If


        If TypeOf _control Is PictureBox Then
            Dim pictureBox As PictureBox = DirectCast(_control, PictureBox)
            pictureBox.Size = New Size(_originalWidth * changeWidthRatio, _originalWidth * changeHeightRatio)
            'MsgBox(_originalWidth.ToString + " el original en px por el ancho en %" + changeWidthRatio.ToString + " y ek original Heigh" + _originalHeight.ToString + " por change" + changeHeightRatio.ToString)

        End If
    End Sub

    ' Mueve el control según los ratios de cambio de ancho y alto
    Public Sub MoveControl(changeWidthRatio As Double, changeHeightRatio As Double)

        ' Calcular las nuevas coordenadas del control
        Dim newX As Integer = CInt(_originalLocationX * changeWidthRatio)
        Dim newY As Integer = CInt(_originalLocationY * changeHeightRatio)

        ' Establecer la nueva posición del control
        _control.Location = New Point(newX, newY)


    End Sub

End Class