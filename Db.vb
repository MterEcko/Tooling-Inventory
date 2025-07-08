Imports System.Configuration
Imports System.Data.SqlClient


Public Class Db
    Dim Conexiones As New SqlConnection()
    'Dim prueba As Drawing.Graphics.FromImage()
    Dim Direccion As ConnectionStringSettings
    Dim Comando As SqlCommand
    Dim ComandoDataAdapter As SqlCommand
    Dim CountAll As SqlDataAdapter
    Dim ComandoProvedores As SqlCommand
    Dim PCB As Object
    Dim CountSten As String




    Sub Conectar()
        Direccion = ConfigurationManager.ConnectionStrings("ConexionPrueba")
        Conexiones.ConnectionString = Direccion.ConnectionString
        Conexiones.Open()

        'MsgBox("Conectado")

    End Sub

    Sub Desconectar()

        Conexiones.Close()
    End Sub



    Public Function AuthenticateUser(username As String, password As String) As Boolean
        Conectar()
        Try
            Using command As New SqlCommand("SELECT COUNT(*) FROM dbo.Usuarios WHERE Email = @Username AND PWD = @Password", Conexiones)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Desconectar()

                If count > 0 Then
                    ' Autenticación exitosa
                    ' Puedes realizar acciones adicionales si es necesario antes de cerrar la conexión
                    User.Usuario = username
                    User.Pwd = password
                    ' Por ejemplo, abrir el nuevo formulario
                    'Dim inicio As New inicio()
                    'inicio.Show()

                    ' Cerrar el formulario actual
                    Return True
                Else
                    ' Autenticación fallida
                    Return False
                End If
            End Using
        Catch ex As Exception
            ' Captura cualquier excepción y muestra un mensaje de error
            Desconectar()
            MessageBox.Show("Error en la autenticación: " & ex.Message)
            Return False
        End Try
    End Function
    Sub InsertarSqueegee(WidthSqueeegee As String, NombreSqueegee As String, ComentarioSqueegee As String)


        Conectar()

        Comando = New SqlCommand("Insert Into Squeegees (Width,Name, Coments) Values('" + WidthSqueeegee + "','" + NombreSqueegee + "', '" + ComentarioSqueegee + "')", Conexiones)



        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error ffavor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub
    Sub InsertarProvedor(Provedor As String, Contacto As String, Domicilio As String, NombreProvedor As String)


        Conectar()

        Comando = New SqlCommand("Insert Into Provedores (Provedor,Contacto,Domicilio,NombreProvedor) Values('" + Provedor + "','" + Contacto + "','" + Domicilio + "','" + NombreProvedor + "')", Conexiones)



        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error ffavor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub
    Sub InsertarProyecto(Proyecto As String)


        Conectar()

        Comando = New SqlCommand("Insert Into Proyectos (Proyecto) Values('" + Proyecto + "')", Conexiones)



        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error ffavor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub

    Sub InsertarExtra(PartNumber As String, Description As String, Qty As String, Type As String)


        Conectar()

        Comando = New SqlCommand("Insert Into Extras (PartNumber,Description,Qty,Type) Values('" + PartNumber + "','" + Description + "','" + Qty + "','" + Type + "')", Conexiones)



        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error ffavor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub

    Sub InsertarStencil(Localidad As String, NombreStencil As String, Ensamble As String, PartPCB As String, Job As String, Comentarios As String,
                        Proyecto As String, DateManufacture As String, DateRun As String, X As String, Y As String, Rev As String, Tension1 As String,
                        Tension2 As String, Tension3 As String, Tension4 As String, Tension5 As String, Provedor As String, Cycle As String)


        Conectar()

        Comando = New SqlCommand("Insert Into Stencil (Ubicacion,Stencil,Ensamble,PCB,JOB,Comentarios,Condicion,Dano, Id_Proyecto,DateManufacture,DateRun,X ,Y,Revision,TensionValue1,TensionValue2,TensionValue3,TensionValue4, TensionValue5,Id_Provedor, Cycles) Values('" + Localidad + "','" + NombreStencil + "', '" + Ensamble + "', '" + PartPCB + "', '" + Job + "','" + Comentarios + "','Condicion', 'Dano', '" + Proyecto + "', '" + DateManufacture + "', '" + DateRun + "', '" + X + "', '" + Y + "', '" + Rev + "','" + Tension1 + "', '" + Tension2 + "','" + Tension3 + "','" + Tension4 + "','" + Tension5 + "','" + Provedor + "', '" + Cycle + "')", Conexiones)



        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub

    Sub InsertarPallet(NombrePallet As String, Ensamble As String, PartPCB As String, Id_Proyecto As String, DateManufacture As String, X As String, Y As String, Id_Provedor As String,
                        Revision As String, Job As String, Ubicacion As String, Cycles As String, X_Array As String, Y_Array As String, Qty As String,
                          Id_Machine As String, Id_Pallet As String, Comentarios As String, Dano As String)


        Conectar()

        Comando = New SqlCommand("Insert Into Pallets (Pallet, Ensamble, PCB,Id_Proyecto,DateManufacture,X,Y,Id_Provedor,Revision,Job, Ubicacion,Cycles,X_Array,Y_Array ,Qty ,Id_Machine,Id_Pallet,Comentarios, Dano) Values('" + NombrePallet + "','" + Ensamble + "','" + PartPCB + "','" + Id_Proyecto + "', '" + DateManufacture + "', '" + X + "', '" + Y + "','" + Id_Provedor + "','" + Revision + "', '" + Job + "', '" + Ubicacion + "', '" + Cycles + "', '" + X_Array + "', '" + Y_Array + "', '" + Qty + "', '" + Id_Machine + "','" + Id_Pallet + "', '" + Comentarios + "', '" + Dano + "')", Conexiones)

        'Comando = New SqlCommand("Insert Into Pallets (PCB,Id_Proyecto,DateManufacture,X,Y,Id_Provedor,Revision,Job, Ubicacion,Cycles,X_Array,Y_Array ,Qty ,Id_Machine,Id_Pallet,Comentarios) Values('" + PartPCB + "','" + Id_Proyecto + "', '" + DateManufacture + "', '" + X + "', '" + Y + "','" + Id_Provedor + "','" + Revision + "', '" + Job + "', '" + Ubicacion + "', '" + Cycles + "', '" + X_Array + "', '" + Y_Array + "', '" + Qty + "', '" + Id_Machine + "','" + Id_Pallet + "', '" + Comentarios + "')", Conexiones)



        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub
    Sub InsertarUser(Id As String, FirstName As String, LastName As String, Email As String, Level As String, Pwd As String)


        Conectar()

        Comando = New SqlCommand("Insert Into dbo.usuarios (Id,Nombre,Apellido,Email,Lvl,PWD) Values('" + Id + "','" + FirstName + "','" + LastName + "', '" + Email + "', '" + Level + "', '" + Pwd + "')", Conexiones)
        'Comando = New SqlCommand("Insert Into dbo.usuarios (Id, Nombre,Apellido,Email,Lvl) Values('" + Id + "', '" + FirstName + "', '" + LastName + "','" + Email + "','" + Level + "')", Conexiones)


        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub

    Sub ActualizarUser(Id As String, FirstName As String, LastName As String, Email As String, Level As String, Pwd As String)


        Conectar()

        Comando = New SqlCommand("UPDATE dbo.usuarios Set Nombre='" + FirstName + "', Apellido='" + LastName + "',Email='" + Email + "',Lvl='" + Level + "',PWD='" + Pwd + "' Where Id='" + Id + "'", Conexiones)
        'Comando = New SqlCommand("Insert Into dbo.usuarios (Id, Nombre,Apellido,Email,Lvl) Values('" + Id + "', '" + FirstName + "', '" + LastName + "','" + Email + "','" + Level + "')", Conexiones)


        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then
            MsgBox("Se realizo con exito la actualizacion")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub
    Sub ConsultarUser(Identificador As String)


        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Usuarios Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        'Dim StencilView As New editstencilform


        If (lector.Read()) Then

            DataGridUser.IdUser = lector("Id").ToString()
            DataGridUser.FirstName = lector("Nombre").ToString()
            DataGridUser.LastName = lector("Apellido").ToString()
            DataGridUser.Email = lector("Email").ToString()
            DataGridUser.Lvl = lector("Lvl").ToString()
            DataGridUser.Password = lector("PWD").ToString()


        End If
        lector.Close()
        Desconectar()
    End Sub

    Sub ActualizarSqueegee(WidthSqueegee As String, NombreSqueegee As String, IdSqueegee As String, ComentsSqueegee As String)


        Conectar()

        Comando = New SqlCommand("Update GPV.dbo.Squeegees Set Name='" + NombreSqueegee + "', Width='" + WidthSqueegee + "', Coments='" + ComentsSqueegee + "' Where Id='" + IdSqueegee + "'", Conexiones)


        Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then

        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If
        Desconectar()


    End Sub

    Sub ActualizarStencil(Localidad As String, NombreStencil As String, Ensamble As String, PartPCB As String, JobUpdate As String, Comentarios As String,
                        CondicionStencil As Integer, DanoStencil As String, Proyecto As String, DateManufacture As String, DateRun As String, X As String, Y As String,
                          Rev As String, Tension1 As String, Tension2 As String, Tension3 As String, Tension4 As String,
                        Tension5 As String, Provedor As String, Cycle As String)


        Conectar()

        Comando = New SqlCommand("Update GPV.dbo.Stencil Set Stencil='" + NombreStencil + "', Ensamble='" + Ensamble + "', PCB='" + PartPCB + "', JOB='" + JobUpdate + "', Comentarios='" + Comentarios + "', Condicion='" + DanoStencil + "',Dano='" + DanoStencil + "', Id_Proyecto='" + Proyecto + "', DateManufacture='" + DateManufacture + "', DateRun='" + DateRun + "', Revision='" + Rev + "', X='" + X + "', Y='" + Y + "', TensionValue1 ='" + Tension1 + "', TensionValue2='" + Tension2 + "', TensionValue3='" + Tension3 + "', TensionValue4='" + Tension4 + "', TensionValue5='" + Tension5 + "', Id_Provedor='" + Provedor + "', Cycles='" + Cycle + "' Where ubicacion='" + Localidad + "'", Conexiones)


        Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then

        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If
        Desconectar()


    End Sub

    Sub InsertarTensiones(IdStencil As String, Comentarios As String,
                         CondicionStencil As String, DanoStencil As String,
                          Tension1 As String, Tension2 As String, Tension3 As String, Tension4 As String,
                        Tension5 As String, TotalCycles As String)

        Dim Fecha As String
        Fecha = Convert.ToString(Date.Now)
        Conectar()

        Comando = New SqlCommand("Insert INTO dbo.Tensiones (Id_Stencil, Comentarios, Condicion, Dano, Date, TensionValue1, TensionValue2, TensionValue3, TensionValue4, TensionValue5, Cycles) Values('" + IdStencil + "','" + Comentarios + "', '" + CondicionStencil + "', '" + DanoStencil + "', '" + Fecha + "', '" + Tension1 + "', '" + Tension2 + "', '" + Tension3 + "', '" + Tension4 + "', '" + Tension5 + "', '" + TotalCycles + "')", Conexiones)
        'Dim consultaInsercion As String = "INSERT INTO Tensiones (IdStencil, Comentarios, Condicion, Dano, Date, TensionValue1, TensionValue2, TensionValue3, TensionValue4, TensionValue5) VALUES (@IdStencil, @Comentarios, @Condicion, @Dano, @Date, @TensionValue1, @TensionValue2, @TensionValue3, @TensionValue4, @TensionValue5)"


        'Comando.ExecuteNonQuery()

        If (Comando.ExecuteNonQuery <> 0) Then

            '("Se realizo con exito el registro")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If

        Desconectar()


    End Sub
    Public Sub ActualizarYInsertarDatos(idStencil As String, nuevosDatos As List(Of Double))
        Conectar()

        ' Iniciar transacción
        Using transaccion As SqlTransaction = Conexiones.BeginTransaction()
            Try
                ' Actualizar datos en la tabla Stencil
                ActualizarDatosStencil(Conexiones, transaccion, idStencil, nuevosDatos)

                ' Insertar datos en la tabla Tensiones
                InsertarDatosTensiones(Conexiones, transaccion, idStencil, nuevosDatos)

                ' Confirmar la transacción si todo fue exitoso
                transaccion.Commit()
            Catch ex As Exception
                ' Revertir la transacción si hay un error
                transaccion.Rollback()
                ' Puedes manejar el error aquí
            End Try
        End Using
    End Sub

    Private Sub ActualizarDatosStencil(conexion As SqlConnection, transaccion As SqlTransaction, idStencil As String, nuevosDatos As List(Of Double))
        ' Aquí deberías escribir la lógica para actualizar los datos en la tabla Stencil
        ' Utiliza el objeto SqlCommand para ejecutar la consulta de actualización
        Dim consultaActualizar As String = "UPDATE Stencil SET Comentarios= @Comentarios, Condicion= @Condicion, Dano= @Dano, TensionValue1 = @TensionValue1, TensionValue2 = @TensionValue2, TensionValue3 = @TensionValue3, TensionValue4 = @TensionValue4, TensionValue5 = @TensionValue5 WHERE Id = @Id"

        ' Crear el comando SQL para la actualización
        Using comandoActualizar As New SqlCommand(consultaActualizar, conexion, transaccion)
            ' Asignar parámetros
            comandoActualizar.Parameters.AddWithValue("@Comentarios", nuevosDatos(0))
            comandoActualizar.Parameters.AddWithValue("@Condicion", nuevosDatos(1))
            comandoActualizar.Parameters.AddWithValue("@Dano", nuevosDatos(2))
            comandoActualizar.Parameters.AddWithValue("@TensionValue1", nuevosDatos(3))
            comandoActualizar.Parameters.AddWithValue("@TensionValue2", nuevosDatos(4))
            comandoActualizar.Parameters.AddWithValue("@TensionValue3", nuevosDatos(5))
            comandoActualizar.Parameters.AddWithValue("@TensionValue4", nuevosDatos(6))
            comandoActualizar.Parameters.AddWithValue("@TensionValue5", nuevosDatos(7))
            comandoActualizar.Parameters.AddWithValue("@Id", idStencil)

            ' Ejecutar la consulta de actualización
            comandoActualizar.ExecuteNonQuery()
        End Using

    End Sub

    Private Sub InsertarDatosTensiones(conexion As SqlConnection, transaccion As SqlTransaction, idStencil As String, nuevosDatos As List(Of Double))
        ' Aquí deberías escribir la lógica para insertar nuevos datos en la tabla Tensiones
        ' Utiliza el objeto SqlCommand para ejecutar la consulta de inserción

        Dim consultaInsercion As String = "INSERT INTO Tensiones (IdStencil, Comentarios, Condicion, Dano, Date, TensionValue1, TensionValue2, TensionValue3, TensionValue4, TensionValue5) VALUES (@IdStencil, @Comentarios, @Condicion, @Dano, @Date, @TensionValue1, @TensionValue2, @TensionValue3, @TensionValue4, @TensionValue5)"

        ' Crear el comando SQL para la inserción
        Using comandoInsercion As New SqlCommand(consultaInsercion, conexion, transaccion)
            ' Asignar parámetros e insertar cada TensionValue
            For i As Integer = 0 To nuevosDatos.Count - 1
                comandoInsercion.Parameters.Clear()
                comandoInsercion.Parameters.AddWithValue("@IdStencil", idStencil)
                comandoInsercion.Parameters.AddWithValue("@Comentarios", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@Condicion", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@Dano", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@TensionValue1", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@TensionValue2", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@TensionValue3", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@TensionValue4", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@TensionValue5", nuevosDatos(i))
                comandoInsercion.Parameters.AddWithValue("@Date", Date.Today())

                ' Ejecutar la consulta de inserción
                comandoInsercion.ExecuteNonQuery()
            Next
        End Using
    End Sub
    Sub ActualizarTension(IdStencil As String, Comentarios As String,
                         CondicionStencil As String, DanoStencil As String,
                          Tension1 As String, Tension2 As String, Tension3 As String, Tension4 As String,
                        Tension5 As String, Cycle As String, TotalCycle As String)


        Dim Sumatoria As Integer

        Sumatoria = CDbl(Cycle) + CDbl(TotalCycle)
        Conectar()

        Comando = New SqlCommand("Update GPV.dbo.Stencil Set Comentarios='" + Comentarios + "', Condicion='" + CondicionStencil + "',Dano='" + DanoStencil + "', TensionValue1 ='" + Tension1 + "', TensionValue2='" + Tension2 + "', TensionValue3='" + Tension3 + "', TensionValue4='" + Tension4 + "', TensionValue5='" + Tension5 + "' , Cycles='" + Sumatoria.ToString + "' Where Id='" + IdStencil + "'", Conexiones)


        Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then
            'MsgBox("Se han guardado los datos correctamente")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If
        Desconectar()


    End Sub

    Sub ActualizarPallet(Pallet As String, Ensamble As String, PartPCB As String, DateManufacture As String, X As String, Y As String, Rev As String,
                         Job As String, Ubicacion As String, Cycles As String, X_Array As String, Y_Array As String, Qty As String,
                         ListMachines As String, Id_Proyecto As String, Id_Provedor As String, Comentarios As String, Id As String, Dano As String)

        'Sub ActualizarPallet(Pallet As String, Ensamble As String, PartPCB As String, DateManufacture As String, X As String, Y As String, Rev As String,
        'Job As String, Ubicacion As String, Cycles As String, X_Array As String, Y_Array As String, Qty As String,
        'Id_Proyecto As String, Id_Provedor As String, Comentarios As String)
        ' van dentro de actualizar pallet antes de comentarios Id_Machine As String, Id_Pallet As String,

        Conectar()

        Comando = New SqlCommand("Update GPV.dbo.Pallets Set Pallet='" + Pallet + "', Ensamble='" + Ensamble + "',PCB='" + PartPCB + "', Id_Proyecto='" + Id_Proyecto + "', DateManufacture='" + DateManufacture + "', X='" + X + "', Y='" + Y + "', Id_Provedor='" + Id_Provedor + "', Revision='" + Rev + "', Job='" + Job + "', Ubicacion='" + Ubicacion + "', Cycles='" + Cycles + "', X_Array='" + X_Array + "', Y_Array='" + Y_Array + "', Qty='" + Qty + "', Id_Machine='" + ListMachines + "', Id_Pallet='0', Comentarios='" + Comentarios + "', Dano='" + Dano + "' Where Id='" + Id + "'", Conexiones)


        Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Se han guardado los datos correctamente")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If
        Desconectar()


    End Sub

    Sub ActualizarProvedor(Suplier As String, PhoneNumber As String, Address As String, NameSuplier As String, IdSuplier As String)

        'Sub ActualizarPallet(Pallet As String, Ensamble As String, PartPCB As String, DateManufacture As String, X As String, Y As String, Rev As String,
        'Job As String, Ubicacion As String, Cycles As String, X_Array As String, Y_Array As String, Qty As String,
        'Id_Proyecto As String, Id_Provedor As String, Comentarios As String)
        ' van dentro de actualizar pallet antes de comentarios Id_Machine As String, Id_Pallet As String,

        Conectar()

        Comando = New SqlCommand("Update dbo.Provedores Set Provedor='" + Suplier + "', Contacto='" + PhoneNumber + "',Domicilio='" + Address + "', NombreProvedor='" + NameSuplier + "' Where Id='" + IdSuplier + "'", Conexiones)


        Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Se han guardado los datos correctamente")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If
        Desconectar()


    End Sub
    Sub ActualizarProyecto(Proyect As String, IdProyect As String)

        'Sub ActualizarPallet(Pallet As String, Ensamble As String, PartPCB As String, DateManufacture As String, X As String, Y As String, Rev As String,
        'Job As String, Ubicacion As String, Cycles As String, X_Array As String, Y_Array As String, Qty As String,
        'Id_Proyecto As String, Id_Provedor As String, Comentarios As String)
        ' van dentro de actualizar pallet antes de comentarios Id_Machine As String, Id_Pallet As String,

        Conectar()

        Comando = New SqlCommand("Update dbo.Proyectos Set Proyecto='" + Proyect + "' Where Id='" + IdProyect + "'", Conexiones)


        Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Se han guardado los datos correctamente")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If
        Desconectar()


    End Sub

    Sub ActualizarExtra(PartNumber As String, Description As String, Qty As String, Type As String, IdExtra As String)

        'Sub ActualizarPallet(Pallet As String, Ensamble As String, PartPCB As String, DateManufacture As String, X As String, Y As String, Rev As String,
        'Job As String, Ubicacion As String, Cycles As String, X_Array As String, Y_Array As String, Qty As String,
        'Id_Proyecto As String, Id_Provedor As String, Comentarios As String)
        ' van dentro de actualizar pallet antes de comentarios Id_Machine As String, Id_Pallet As String,

        Conectar()

        Comando = New SqlCommand("Update dbo.Extras Set PartNumber='" + PartNumber + "', Description='" + Description + "',Qty='" + Qty + "', Type='" + Type + "' Where Id='" + IdExtra + "'", Conexiones)


        Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Se han guardado los datos correctamente")
        Else
            MsgBox("Ha ocurrido un error favor de verificar los datos, si el problema persiste contactar al administrador")
        End If
        Desconectar()


    End Sub

    Sub FinStencilFromAssembly(Identificador As String)
        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Stencil Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        'Dim StencilView As New editstencilform


        If (lector.Read()) Then

        End If

        lector.Close()
        Desconectar()
    End Sub

    Sub FinPalletSelectivaFromAssembly(Identificador As String)
        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Stencil Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        'Dim StencilView As New editstencilform


        If (lector.Read()) Then

        End If

        lector.Close()
        Desconectar()
    End Sub

    Sub FinPalletRegularFromAssembly(Identificador As String)
        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Stencil Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        'Dim StencilView As New editstencilform


        If (lector.Read()) Then

        End If

        lector.Close()
        Desconectar()
    End Sub

    Sub FinPalletConformalFromAssembly(Identificador As String)
        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Stencil Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        'Dim StencilView As New editstencilform


        If (lector.Read()) Then

        End If

        lector.Close()
        Desconectar()
    End Sub


    Sub ConsultarStencil(Identificador As String)


        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Stencil Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        'Dim StencilView As New editstencilform


        If (lector.Read()) Then

            DataGridStencil.StencilNameEdit = lector("Stencil").ToString()
            DataGridStencil.EnsambleEdit = lector("Ensamble").ToString()
            DataGridStencil.NumberPartStencilEdit = lector("PCB").ToString()
            DataGridStencil.XEdit = lector("X").ToString()
            DataGridStencil.YEdit = lector("Y").ToString()
            DataGridStencil.RevisionEdit = lector("Revision").ToString()
            DataGridStencil.JobEdit = lector("JOB").ToString()
            DataGridStencil.DanoEdit = lector("Dano").ToString()
            DataGridStencil.LocalidadEdit = lector("Ubicacion").ToString()

            DataGridStencil.Num1TensionEdit = lector("TensionValue1").ToString()
            DataGridStencil.Num2TensionEdit = lector("TensionValue2").ToString()
            DataGridStencil.Num3TensionEdit = lector("TensionValue3").ToString()
            DataGridStencil.Num4TensionEdit = lector("TensionValue4").ToString()
            DataGridStencil.Num5TensionEdit = lector("TensionValue5").ToString()
            DataGridStencil.ComentariosStencilEdit = lector("Comentarios").ToString()
            DataGridStencil.ListProyectos = lector("Id_Proyecto").ToString()
            DataGridStencil.FechaFabricanteEdit = lector("DateManufacture").ToString()
            DataGridStencil.FechaRegistroEdit = lector("DateRun").ToString()
            DataGridStencil.ListProvedores = lector("Id_Provedor").ToString
            DataGridStencil.Cycles = lector("Cycles").ToString()

        End If
        lector.Close()
        Desconectar()
    End Sub
    Sub ReturnStencil(Identificador As String)


        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Stencil Where Stencil='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        'Dim StencilView As New editstencilform


        If (lector.Read()) Then
            DataGridStencil.IdStencil = lector("Id").ToString()
            DataGridStencil.StencilNameEdit = lector("Stencil").ToString()
            DataGridStencil.EnsambleEdit = lector("Ensamble").ToString()
            DataGridStencil.NumberPartStencilEdit = lector("PCB").ToString()
            DataGridStencil.XEdit = lector("X").ToString()
            DataGridStencil.YEdit = lector("Y").ToString()
            DataGridStencil.RevisionEdit = lector("Revision").ToString()
            DataGridStencil.JobEdit = lector("JOB").ToString()
            DataGridStencil.DanoEdit = lector("Dano").ToString()
            DataGridStencil.LocalidadEdit = lector("Ubicacion").ToString()

            DataGridStencil.Num1TensionEdit = lector("TensionValue1").ToString()
            DataGridStencil.Num2TensionEdit = lector("TensionValue2").ToString()
            DataGridStencil.Num3TensionEdit = lector("TensionValue3").ToString()
            DataGridStencil.Num4TensionEdit = lector("TensionValue4").ToString()
            DataGridStencil.Num5TensionEdit = lector("TensionValue5").ToString()
            DataGridStencil.ComentariosStencilEdit = lector("Comentarios").ToString()
            DataGridStencil.ListProyectos = lector("Id_Proyecto").ToString()
            DataGridStencil.FechaFabricanteEdit = lector("DateManufacture").ToString()
            DataGridStencil.FechaRegistroEdit = lector("DateRun").ToString()
            DataGridStencil.ListProvedores = lector("Id_Provedor").ToString()
            DataGridStencil.Cycles = lector("Cycles").ToString()

        End If
        lector.Close()
        Desconectar()
    End Sub
    Sub ConsultarPallet(Identificador As String)


        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Pallets Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim PalletView As New editpalletform


        If (lector.Read()) Then

            DataGridPallet.PalletNameEdit = lector("Pallet").ToString()

            DataGridPallet.PalletEnsambleEdit = lector("Ensamble").ToString()
            DataGridPallet.PalletNumberPartEdit = lector("PCB").ToString()
            DataGridPallet.ListProyectos = lector("Id_Proyecto").ToString()
            DataGridPallet.PalletFechaFabricanteEdit = lector("DateManufacture").ToString()
            DataGridPallet.PalletXEdit = lector("X").ToString()
            DataGridPallet.PalletYEdit = lector("Y").ToString()
            DataGridPallet.ListProvedores = lector("Id_Provedor").ToString
            DataGridPallet.PalletRevisionEdit = lector("Revision").ToString()
            DataGridPallet.PalletJobEdit = lector("Job").ToString()
            DataGridPallet.PalletLocalidadEdit = lector("Ubicacion").ToString()

            DataGridPallet.PalletCyclesEdit = lector("Cycles").ToString()
            DataGridPallet.PalletXArrayEdit = lector("X_Array").ToString()
            DataGridPallet.PalletYArrayEdit = lector("Y_Array").ToString()
            DataGridPallet.PalletQtyEdit = lector("Qty").ToString()
            DataGridPallet.ListMachines = lector("Id_Machine").ToString()

            DataGridPallet.PalletComentariosEdit = lector("Comentarios").ToString()
            DataGridPallet.PalletDanoEdit = lector("Dano").ToString


            'DataGridPallet.FechaRegistroEdit = lector("DateRun").ToString()


        End If
        lector.Close()
        Desconectar()
    End Sub

    Sub ConsultarRouterDish(Identificador As String)


        Conectar()
        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "Select * From dbo.Router Where Id='" + Identificador + "'"

        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim RouterDishView As New editrouterdishform


        If (lector.Read()) Then

            DataGridRouterDish.RouterDishNameEdit = lector("RouterDish").ToString()

            DataGridRouterDish.RouterDishEnsambleEdit = lector("Ensamble").ToString()
            DataGridRouterDish.RouterDishNumberPartEdit = lector("PCB").ToString()
            DataGridRouterDish.ListProyectos = lector("Id_Proyecto").ToString()
            DataGridRouterDish.RouterDishFechaFabricanteEdit = lector("DateManufacture").ToString()
            DataGridRouterDish.RouterDishXEdit = lector("X").ToString()
            DataGridRouterDish.RouterDishYEdit = lector("Y").ToString()
            DataGridRouterDish.ListProvedores = lector("Id_Provedor").ToString
            DataGridRouterDish.RouterDishRevisionEdit = lector("Revision").ToString()
            DataGridRouterDish.RouterDishJobEdit = lector("Job").ToString()
            DataGridRouterDish.RouterDishLocalidadEdit = lector("Ubicacion").ToString()

            DataGridRouterDish.RouterDishCyclesEdit = lector("Cycles").ToString()
            DataGridRouterDish.RouterDishXArrayEdit = lector("X_Array").ToString()
            DataGridRouterDish.RouterDishYArrayEdit = lector("Y_Array").ToString()
            DataGridRouterDish.RouterDishQtyEdit = lector("Qty").ToString()
            DataGridRouterDish.ListMachine = lector("Id_Machine").ToString()

            DataGridRouterDish.RouterDishComentariosEdit = lector("Comentarios").ToString()


            'DataGridPallet.FechaRegistroEdit = lector("DateRun").ToString()


        End If

        Desconectar()
        lector.Close()

    End Sub

    Function ConsultaComboBoxProvedores() As List(Of ComboBoxProvedores)

        Comando = Conexiones.CreateCommand()



        Comando.CommandText = "Select Id, Provedor From dbo.Provedores"
        Dim lectorProvedores As SqlDataReader = Comando.ExecuteReader()

        Dim ComboBoxProvedores = New List(Of ComboBoxProvedores)

        While (lectorProvedores.Read())
            ComboBoxProvedores.Add(New ComboBoxProvedores() With
            {
            .IdProvedor = lectorProvedores.GetInt32(0),
            .NombreProvedor = lectorProvedores.GetString(1)
            })

        End While
        'Conexiones.Close()
        lectorProvedores.Close()
        Return ComboBoxProvedores

    End Function
    Public Function ConsultaComboBoxProyectos() As List(Of ComboBoxProyectos)

        Comando = Conexiones.CreateCommand()



        Comando.CommandText = "Select ID, Proyecto From dbo.Proyectos"
        Dim lectorProyectos As SqlDataReader = Comando.ExecuteReader()

        Dim ComboBoxProyectos = New List(Of ComboBoxProyectos)

        While (lectorProyectos.Read())
            ComboBoxProyectos.Add(New ComboBoxProyectos() With
      {
        .IdProyecto = lectorProyectos.GetInt32(0),
        .NombreProyecto = lectorProyectos.GetString(1)
        })

        End While
        'Conexiones.Close()
        lectorProyectos.Close()
        Return ComboBoxProyectos


    End Function
    Public Function ConsultaComboBoxStenciles(id_stencil) As List(Of ComboBoxStenciles)

        Comando = Conexiones.CreateCommand()

        If id_stencil >= 0 Then
            Comando.CommandText = "Select Id, Stencil From dbo.Stencil WHERE Id_Proyecto = '" + id_stencil + "'"
        Else
            Comando.CommandText = "Select Id, Stencil From dbo.Stencil"
        End If


        'Comando.CommandText = "Select ID, Stencil From dbo.Stencil WHERE Id_Proyecto = '" + id_stencil + "'"
        Dim lectorStenciles As SqlDataReader = Comando.ExecuteReader()

        Dim ComboBoxStenciles = New List(Of ComboBoxStenciles)

        While (lectorStenciles.Read())
            ' Verificar si la columna tiene un valor nulo
            Dim nombreStencil As String = If(lectorStenciles.IsDBNull(1), "Sin nombre Stencil", lectorStenciles.GetString(1))

            ComboBoxStenciles.Add(New ComboBoxStenciles() With
            {
                .IdStencil = lectorStenciles.GetInt32(0),
                .NombreStencil = nombreStencil
            })
        End While
        'Conexiones.Close()
        lectorStenciles.Close()
        Return ComboBoxStenciles

    End Function
    Function ConsultaComboBoxMachines() As List(Of ComboBoxMachines)

        Comando = Conexiones.CreateCommand()



        Comando.CommandText = "Select * From dbo.Machines"
        Dim lectorMachines As SqlDataReader = Comando.ExecuteReader()

        Dim ComboBoxMachines = New List(Of ComboBoxMachines)


        Dim SeriesMachines = New List(Of ComboBoxMachines)
        'Dim Machines As ComboBoxMachines
        While (lectorMachines.Read())

            ComboBoxMachines.Add(New ComboBoxMachines() With
            {
                .IdMachine = lectorMachines.GetInt32(0),
                .NombreMachine = lectorMachines.GetString(1)
            })




        End While
        'Conexiones.Close()
        lectorMachines.Close()
        Return ComboBoxMachines


    End Function

    Public Function ProyectosChart() As List(Of Proyectos)
        Conectar()
        Comando = Conexiones.CreateCommand()



        Comando.CommandText = "Select * From dbo.Proyectos"


        Dim reader As SqlDataReader = Comando.ExecuteReader()
        Dim lectorProyectos As New List(Of Proyectos)

        While (reader.Read())

            Dim IdProyect As String = reader("ID").ToString()
            Dim Proyect As String = reader("Proyecto").ToString()

            Dim chartProyect As New Proyectos(IdProyect, Proyect)
            lectorProyectos.Add(chartProyect)
        End While
        'Conexiones.Close()
        reader.Close()
        Desconectar()
        Return lectorProyectos


    End Function
    Public Function GetChartData() As List(Of ChartData)

        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "SELECT Id, Machine FROM dbo.Machines"
        Dim reader As SqlDataReader = Comando.ExecuteReader()

        Dim chartDataList As New List(Of ChartData)
        While (reader.Read())
            Dim idcategoria As String = reader("Id").ToString()
            Dim categoria As String = reader("Machine").ToString()
            Dim chartCategoria As New ChartData(idcategoria, categoria)
            chartDataList.Add(chartCategoria)
        End While
        reader.Close()
        Desconectar()
        Return chartDataList

    End Function
    Public Function GetChartProyectos() As List(Of ChartData)

        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "SELECT Id, Machine FROM dbo.Machines"
        Dim reader As SqlDataReader = Comando.ExecuteReader()

        Dim chartDataList As New List(Of ChartData)
        While (reader.Read())
            Dim idcategoria As String = reader("Id").ToString()
            Dim categoria As String = reader("Machine").ToString()
            Dim chartCategoria As New ChartData(idcategoria, categoria)
            chartDataList.Add(chartCategoria)
        End While
        reader.Close()
        Desconectar()
        Return chartDataList

    End Function

    Sub GetChartDataToolingTopMachine(find As String, find2 As String)

        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "SELECT 
                                Proyectos.ID AS IDProyecto, 
                                Proyectos.Proyecto, 
                                Machines.Id AS IDMachine,
                                Machines.Machine, 
                                COALESCE(COUNT(UnionResult.Id_Machine), 0) AS ConteoMachine,
                                COALESCE(COUNT(UnionResult.Id_Proyecto), 0) AS ConteoProyectos
                            FROM (
                                SELECT Id_Proyecto, Id_Machine
                                FROM dbo.Pallets
                                WHERE Id_Machine = '" + find + "' AND Id_Proyecto= '" + find2 + "' -- Reemplaza 'tu_valor_aqui' con el valor deseado
                                UNION ALL
                                SELECT Id_Proyecto, Id_Machine
                                FROM dbo.Stencil
                                WHERE Id_Machine = '" + find + "' AND Id_Proyecto= '" + find2 + "' -- Reemplaza 'tu_valor_aqui' con el valor deseado
                            ) AS UnionResult
                            RIGHT JOIN Machines ON UnionResult.Id_Machine = Machines.Id
                            INNER JOIN Proyectos ON UnionResult.Id_Proyecto = Proyectos.ID
                            GROUP BY Proyectos.Proyecto, Proyectos.ID, Machines.Id, Machines.Machine"
        Dim reader As SqlDataReader = Comando.ExecuteReader()

        While (reader.Read())

            ChartTotalEnsambles.IDMachine = reader("IDMachine").ToString()
            ChartTotalEnsambles.Machine = reader("Machine").ToString()
            ChartTotalEnsambles.IDProyecto = reader("IDProyecto").ToString()
            ChartTotalEnsambles.Proyecto = reader("Proyecto").ToString()
            ChartTotalEnsambles.ConteoMachines = reader("ConteoMachine").ToString()
            ChartTotalEnsambles.ConteoProyectos = reader("ConteoProyectos").ToString()

        End While
        reader.Close()
        Desconectar()

    End Sub

    Public Function GetChartDataTensionFromStencil(find As String) As Tuple(Of String, List(Of Double))
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "SELECT Stencil, TensionValue1, TensionValue2, TensionValue3, TensionValue4, TensionValue5 FROM Stencil WHERE Stencil = '" + find + "'"

        Dim stencil As String = ""
        Dim tensionValues As New List(Of Double)()

        Try
            Dim reader As SqlDataReader = Comando.ExecuteReader()

            While (reader.Read())
                stencil = reader("Stencil").ToString()

                For i As Integer = 0 To 4 ' Suponiendo que hay 5 columnas de TensionValue en la base de datos
                    tensionValues.Add(Convert.ToDouble(reader($"TensionValue{i + 1}")))
                Next
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos de tensión: " & ex.Message)
        Finally
            Desconectar()
        End Try

        Return Tuple.Create(stencil, tensionValues)
    End Function
    Sub GetChartDataTensionFromStencilNouse(find As String)

        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "SELECT Id, Stencil, TensionValue1, TensionValue2, TensionValue3, TensionValue4, TensionValue5 FROM Stencil WHERE Id = '" + find + "'"


        Dim reader As SqlDataReader = Comando.ExecuteReader()

        While (reader.Read())

            ChartTotalTensionesForStencil.IDStencil = reader("Id").ToString()
            ChartTotalTensionesForStencil.Stencil = reader("Stencil").ToString()
            ChartTotalTensionesForStencil.TensionValue1 = reader("TensionValue1").ToString()
            ChartTotalTensionesForStencil.TensionValue2 = reader("TensionValue2").ToString()
            ChartTotalTensionesForStencil.TensionValue3 = reader("TensionValue3").ToString()
            ChartTotalTensionesForStencil.TensionValue4 = reader("TensionValue4").ToString()
            ChartTotalTensionesForStencil.TensionValue5 = reader("TensionValue5").ToString()


        End While
        reader.Close()
        Desconectar()

    End Sub
    Sub GetChartDataTension(find As String)

        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "SELECT 
                            Proyectos.ID AS IDProyecto, 
                            Proyectos.Proyecto,
                            COALESCE(SUM(Stencil.TensionValue1), 0) AS SumaTensionValue1,
	                        COALESCE(SUM(Stencil.TensionValue2), 0) AS SumaTensionValue2,
	                        COALESCE(SUM(Stencil.TensionValue3), 0) AS SumaTensionValue3,
	                        COALESCE(SUM(Stencil.TensionValue4), 0) AS SumaTensionValue4,
	                        COALESCE(SUM(Stencil.TensionValue5), 0) AS SumaTensionValue5,
                            COUNT(*) AS TotalResultados
                        FROM (
                            SELECT Id_Proyecto, TensionValue1,TensionValue2,TensionValue3,TensionValue4,TensionValue5
                            FROM dbo.Stencil
                            WHERE Id_Proyecto = '" + find + "' -- Reemplaza 'Tu_Id_Proyecto_Aqui' con el valor deseado
                        ) AS Stencil
                        INNER JOIN Proyectos ON Stencil.Id_Proyecto = Proyectos.ID
                        GROUP BY Proyectos.Proyecto, Proyectos.ID;"


        Dim reader As SqlDataReader = Comando.ExecuteReader()

        While (reader.Read())

            'ChartTotalTensiones.IDProyecto = reader("IDProyecto").ToString()
            'ChartTotalTensiones.Proyecto = reader("Proyecto").ToString()
            'ChartTotalTensiones.ConteoProyectos = reader("ConteoProyectos").ToString()
            'ChartTotalTensiones.TensionValue1 = reader("SumaTensionValue1").ToString()
            'ChartTotalTensiones.TensionValue2 = reader("SumaTensionValue2").ToString()
            'ChartTotalTensiones.TensionValue3 = reader("SumaTensionValue3").ToString()
            'ChartTotalTensiones.TensionValue4 = reader("SumaTensionValue4").ToString()
            'ChartTotalTensiones.TensionValue5 = reader("SumaTensionValue5").ToString()


        End While
        reader.Close()
        Desconectar()

    End Sub
    Public Function GetChartDataToolingTopCount() As List(Of ClassDashboard)

        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "SELECT 
                                Proyectos.ID AS IDProyecto, 
                                Proyectos.Proyecto, 
                                COALESCE(COUNT(UnionResult.Id_Proyecto), 0) AS ConteoProyectos
                            FROM (
                                SELECT Id_Proyecto
                                FROM dbo.Pallets
                                 -- Reemplaza 'tu_valor_aqui' con el valor deseado
                                UNION ALL
                                SELECT Id_Proyecto
                                FROM dbo.Stencil-- Reemplaza 'tu_valor_aqui' con el valor deseado
                            ) AS UnionResult
                            RIGHT JOIN Proyectos ON UnionResult.Id_Proyecto = Proyectos.ID
                            GROUP BY Proyectos.Proyecto, Proyectos.ID"
        Dim reader As SqlDataReader = Comando.ExecuteReader()

        Dim chartDataList As New List(Of ClassDashboard)
        While (reader.Read())

            Dim IdProyecto As String = reader("IDProyecto").ToString()
            Dim Proyecto As String = reader("Proyecto").ToString()
            Dim ConteoProyectos As String = reader("ConteoProyectos").ToString()

            Dim chartIDMachine As New ClassDashboard(vbEmpty, vbEmpty, IdProyecto, Proyecto, vbEmpty, ConteoProyectos)
            chartDataList.Add(chartIDMachine)
        End While
        reader.Close()
        Desconectar()
        Return chartDataList

    End Function
    Public Function ObtenerDatosParaGrafico() As List(Of ClassDashboard)



        Conectar()

        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "SELECT COALESCE(COUNT(UnionResult.Id_Machine), 0) AS Conteo, 
                                Proyectos.Proyecto, Machines.Machine, Machines.Id  AS IDMachine , 
                                COALESCE(COUNT(UnionResult.Id_Proyecto), 0) AS ConteoProyectos, 
                                Proyectos.ID AS IDProyecto
                                FROM (
                                    SELECT Id_Machine, Id_Proyecto FROM dbo.Pallets
                                    UNION ALL
                                    SELECT Id_Machine, Id_Proyecto FROM dbo.Stencil
                                ) AS UnionResult
                                RIGHT JOIN Machines ON UnionResult.Id_Machine = Machines.Id
                                LEFT JOIN Proyectos ON UnionResult.Id_Proyecto = Proyectos.ID
                                GROUP BY Machines.Machine, Machines.Id, Proyectos.Proyecto, Proyectos.ID"
        Dim ClassDashboardList As New List(Of ClassDashboard)
        'Dim ClassDashboard As ClassDashboard
        Dim reader As SqlDataReader = Comando.ExecuteReader()
        While (reader.Read())

            'If reader.IsDBNull(0) Then
            'Dim IdMachine As S = 0
            'Else
            'Dim IdMachine = reader.GetString(1)
            'End If
            Dim IdMachine As String = reader("IDMachine").ToString()
            Dim Machine As String = reader("Machine").ToString()

            Dim IdProyecto As String = reader("IDProyecto").ToString()
            Dim Proyecto As String = reader("Proyecto").ToString()

            Dim ConteoMachine As String = reader("ConteoMachine").ToString()
            Dim ConteoProyecto As String = reader("ConteoProyecto").ToString()

            Dim chartTooling As New ClassDashboard(IdMachine, Machine, IdProyecto, Proyecto, ConteoMachine, ConteoProyecto)
            ClassDashboardList.Add(chartTooling)
        End While

        reader.Close()
        Desconectar()
        Return ClassDashboardList


    End Function

    Sub GetDatosParaCriticos(find As String, find2 As String)



        Conectar()

        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "SELECT 
                                Proyectos.ID AS IDProyecto, 
                                Proyectos.Proyecto, 
                                Machines.Id AS IDMachine,
                                Machines.Machine, 
                                COALESCE(COUNT(UnionResult.Id_Machine), 0) AS ConteoMachine,
                                COALESCE(COUNT(UnionResult.Id_Proyecto), 0) AS ConteoProyectos
                            FROM (
                                SELECT Id_Proyecto, Id_Machine
                                FROM dbo.Pallets
                                WHERE Id_Machine = '" + find + "' AND Id_Proyecto= '" + find2 + "' AND Dano=1 -- Reemplaza 'tu_valor_aqui' con el valor deseado
                                UNION ALL
                                SELECT Id_Proyecto, Id_Machine
                                FROM dbo.Stencil
                                WHERE Id_Machine = '" + find + "' AND Id_Proyecto= '" + find2 + "' AND Dano=1-- Reemplaza 'tu_valor_aqui' con el valor deseado
                            ) AS UnionResult
                            RIGHT JOIN Machines ON UnionResult.Id_Machine = Machines.Id
                            INNER JOIN Proyectos ON UnionResult.Id_Proyecto = Proyectos.ID
                            GROUP BY Proyectos.Proyecto, Proyectos.ID, Machines.Id, Machines.Machine"

        'Dim ClassDashboard As ClassDashboard
        Dim reader As SqlDataReader = Comando.ExecuteReader()
        While (reader.Read())

            ChartTotalEnsamblesFail.IDMachine = reader("IDMachine").ToString()
            ChartTotalEnsamblesFail.Machine = reader("Machine").ToString()
            ChartTotalEnsamblesFail.IDProyecto = reader("IDProyecto").ToString()
            ChartTotalEnsamblesFail.Proyecto = reader("Proyecto").ToString()
            ChartTotalEnsamblesFail.ConteoMachines = reader("ConteoMachine").ToString()
            ChartTotalEnsamblesFail.ConteoProyectos = reader("ConteoProyectos").ToString()
        End While

        reader.Close()
        Desconectar()


    End Sub
    Public Function ConsultaProyectsDataGridView() As List(Of ComboBoxProyectos)
        Conectar()
        Comando = Conexiones.CreateCommand()



        Comando.CommandText = "Select ID, Proyecto From dbo.Proyectos"
        Dim lectorProyectos As SqlDataReader = Comando.ExecuteReader()

        Dim ComboBoxProyectos = New List(Of ComboBoxProyectos)

        While (lectorProyectos.Read())
            ComboBoxProyectos.Add(New ComboBoxProyectos() With
      {
        .IdProyecto = lectorProyectos.GetInt32(0),
        .NombreProyecto = lectorProyectos.GetString(1)
        })

        End While
        'Conexiones.Close()
        lectorProyectos.Close()
        Desconectar()
        Return ComboBoxProyectos


    End Function
    Function ConsultaSupplierDataGridView() As List(Of ClassProvedores)
        Conectar()
        Comando = Conexiones.CreateCommand()



        Comando.CommandText = "Select Id, Provedor,Contacto, Domicilio, NombreProvedor From dbo.Provedores"
        Dim lectorProvedores As SqlDataReader = Comando.ExecuteReader()

        Dim ClassProvedores = New List(Of ClassProvedores)

        While (lectorProvedores.Read())
            ClassProvedores.Add(New ClassProvedores() With
            {
            .IdProvedor = lectorProvedores.GetInt32(0),
            .Provedor = lectorProvedores.GetString(1),
            .Contacto = lectorProvedores.GetString(2),
            .Domicilio = lectorProvedores.GetString(3),
            .NombreProvedor = lectorProvedores.GetString(4)
            })

            '
            '.Domicilio = lectorProvedores.GetString(3),
            '.NombreProvedor = lectorProvedores.GetString(4)
        End While
        'Conexiones.Close()
        lectorProvedores.Close()
        Desconectar()
        Return ClassProvedores

    End Function

    Function ConsultaExtraDataGridView() As List(Of ClassExtras)
        Conectar()
        Comando = Conexiones.CreateCommand()



        Comando.CommandText = "Select Id, PartNumber,Description, Qty, Type From dbo.Extras"
        Dim lectorExtras As SqlDataReader = Comando.ExecuteReader()

        Dim ClassExtras = New List(Of ClassExtras)

        While (lectorExtras.Read())
            ClassExtras.Add(New ClassExtras() With
            {
            .IdExtra = lectorExtras.GetInt32(0),
            .PartNumber = lectorExtras.GetString(1),
            .Description = lectorExtras.GetString(2),
            .Qty = lectorExtras.GetString(3),
            .Type = lectorExtras.GetString(4)
            })

            '
            '.Domicilio = lectorProvedores.GetString(3),
            '.NombreProvedor = lectorProvedores.GetString(4)
        End While
        'Conexiones.Close()
        lectorExtras.Close()
        Desconectar()
        Return ClassExtras

    End Function
    Function ConsultaSquegeeDataGridViewer() As List(Of ClassSqueegees)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select * from dbo.Squeegees"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassSqueegees)
        Dim ClassSqueegees As ClassSqueegees
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassSqueegees = New ClassSqueegees

            If lector.IsDBNull(0) Then
                ClassSqueegees.IdSqueeg = "Sin ubicacion"
            Else
                ClassSqueegees.IdSqueeg = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ClassSqueegees.NombreSquee = "Sin nombre"
            Else
                ClassSqueegees.NombreSquee = lector.GetString(2)
            End If


            If lector.IsDBNull(2) Then
                ClassSqueegees.WidthSquee = "Sin ancho"
            Else
                ClassSqueegees.WidthSquee = lector.GetString(1)
            End If

            If lector.IsDBNull(3) Then
                ClassSqueegees.ComentsSquee = "Sin comentarios"
            Else
                ClassSqueegees.ComentsSquee = lector.GetString(3)
            End If

            Lista.Add(ClassSqueegees)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function ConsultaStencilDataGridViewer() As List(Of ClassStenciles)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Id,Ubicacion,Stencil,Ensamble,PCB,Comentarios from dbo.Stencil"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassStenciles)
        Dim ClassStenciles As ClassStenciles
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassStenciles = New ClassStenciles

            If lector.IsDBNull(0) Then
                ClassStenciles.IdSten = "Sin Id"
            Else
                ClassStenciles.IdSten = lector.GetInt32(0)
            End If

            If lector.IsDBNull(1) Then
                ClassStenciles.UbicacionSten = "Sin ubicacion"
            Else
                ClassStenciles.UbicacionSten = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassStenciles.NombreSten = "Sin nombre"
            Else
                ClassStenciles.NombreSten = lector.GetString(2)
            End If


            If lector.IsDBNull(3) Then
                ClassStenciles.EnsambleSten = "Sin ensamble"
            Else
                ClassStenciles.EnsambleSten = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassStenciles.PCBSten = "Sin PCB"
            Else
                ClassStenciles.PCBSten = lector.GetString(4)
            End If

            If lector.IsDBNull(5) Then
                ClassStenciles.ComentariosSten = "Sin comentarios"
            Else
                ClassStenciles.ComentariosSten = lector.GetString(5)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassStenciles)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function ConsultaStencilDataGridViewerStencilSearch() As List(Of ClassStenciles)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Ubicacion,Stencil,Ensamble,PCB,Comentarios from dbo.Stencil"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassStenciles)
        Dim ClassStenciles As ClassStenciles
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassStenciles = New ClassStenciles


            If lector.IsDBNull(0) Then
                ClassStenciles.UbicacionSten = "Sin ubicacion"
            Else
                ClassStenciles.UbicacionSten = lector.GetString(0)
            End If


            If lector.IsDBNull(1) Then
                ClassStenciles.NombreSten = "Sin nombre"
            Else
                ClassStenciles.NombreSten = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassStenciles.EnsambleSten = "Sin ensamble"
            Else
                ClassStenciles.EnsambleSten = lector.GetString(2)
            End If

            If lector.IsDBNull(3) Then
                ClassStenciles.PCBSten = "Sin PCB"
            Else
                ClassStenciles.PCBSten = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassStenciles.ComentariosSten = "Sin comentarios"
            Else
                ClassStenciles.ComentariosSten = lector.GetString(4)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassStenciles)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function ConsultaAsemblyDataGridViewer() As List(Of ClassAsemblys)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Id,Final,TD,HM,SM,PCB,Comentarios from dbo.Assembly"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassAsemblys)
        Dim ClassAsemblys As ClassAsemblys
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassAsemblys = New ClassAsemblys

            If lector.IsDBNull(0) Then
                ClassAsemblys.IdAsem = "Sin Id"
            Else
                ClassAsemblys.IdAsem = lector.GetInt32(0)
            End If

            If lector.IsDBNull(1) Then
                ClassAsemblys.Fin = "Sin ubicacion"
            Else
                ClassAsemblys.Fin = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassAsemblys.T = "Sin nombre"
            Else
                ClassAsemblys.T = lector.GetString(2)
            End If


            If lector.IsDBNull(3) Then
                ClassAsemblys.H = "Sin ensamble"
            Else
                ClassAsemblys.H = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassAsemblys.S = "Sin PCB"
            Else
                ClassAsemblys.S = lector.GetString(4)
            End If

            If lector.IsDBNull(5) Then
                ClassAsemblys.PC = "Sin comentarios"
            Else
                ClassAsemblys.PC = lector.GetString(5)
            End If

            If lector.IsDBNull(5) Then
                ClassAsemblys.Com = "Sin comentarios"
            Else
                ClassAsemblys.Com = lector.GetString(5)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassAsemblys)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function ConsultaAsemblyDataGridViewerAsemblySearch() As List(Of ClassAsemblys)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Id,Final,TD,HM,SM,PCB,Comentarios from dbo.Assembly"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassAsemblys)
        Dim ClassAsemblys As ClassAsemblys
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassAsemblys = New ClassAsemblys

            If lector.IsDBNull(0) Then
                ClassAsemblys.IdAsem = "Sin Id"
            Else
                ClassAsemblys.IdAsem = lector.GetInt32(0)
            End If

            If lector.IsDBNull(1) Then
                ClassAsemblys.Fin = "Sin ubicacion"
            Else
                ClassAsemblys.Fin = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassAsemblys.T = "Sin nombre"
            Else
                ClassAsemblys.T = lector.GetString(2)
            End If


            If lector.IsDBNull(3) Then
                ClassAsemblys.H = "Sin ensamble"
            Else
                ClassAsemblys.H = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassAsemblys.S = "Sin PCB"
            Else
                ClassAsemblys.S = lector.GetString(4)
            End If

            If lector.IsDBNull(5) Then
                ClassAsemblys.PC = "Sin comentarios"
            Else
                ClassAsemblys.PC = lector.GetString(5)
            End If

            If lector.IsDBNull(5) Then
                ClassAsemblys.Com = "Sin comentarios"
            Else
                ClassAsemblys.Com = lector.GetString(5)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassAsemblys)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function FindProyectsDataGridView(Find) As List(Of ComboBoxProyectos)
        Conectar()
        Comando = Conexiones.CreateCommand()

        'Comando.CommandText = "Select * From dbo.Provedores Where Provedor Like '%" + Find + "%' or  Contacto Like '%" + Find + "%' or  Domicilio Like '%" + Find + "%' or  NombreProvedor Like '%" + Find + "%'"
        Comando.CommandText = "Select ID, Proyecto From dbo.Proyectos Where Proyecto Like '%" + Find + "%'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ComboBoxProyectos)
        Dim ComboBoxProyectos As ComboBoxProyectos
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ComboBoxProyectos = New ComboBoxProyectos

            If lector.IsDBNull(0) Then
                ComboBoxProyectos.IdProyecto = "Sin id"
            Else
                ComboBoxProyectos.IdProyecto = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ComboBoxProyectos.NombreProyecto = "Sin nombre"
            Else
                ComboBoxProyectos.NombreProyecto = lector.GetString(1)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ComboBoxProyectos)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function FindSupplierDataGridView(Find) As List(Of ClassProvedores)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select * From dbo.Provedores Where Provedor Like '%" + Find + "%' or  Contacto Like '%" + Find + "%' or  Domicilio Like '%" + Find + "%' or  NombreProvedor Like '%" + Find + "%'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassProvedores)
        Dim ClassProvedores As ClassProvedores
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassProvedores = New ClassProvedores

            If lector.IsDBNull(0) Then
                ClassProvedores.IdProvedor = "Sin id"
            Else
                ClassProvedores.IdProvedor = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ClassProvedores.Provedor = "Sin nombre"
            Else
                ClassProvedores.Provedor = lector.GetString(2)
            End If


            If lector.IsDBNull(2) Then
                ClassProvedores.Contacto = "Sin numero"
            Else
                ClassProvedores.Contacto = lector.GetString(1)
            End If

            If lector.IsDBNull(3) Then
                ClassProvedores.Domicilio = "Sin domicilio"
            Else
                ClassProvedores.Domicilio = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassProvedores.NombreProvedor = "Sin responsable"
            Else
                ClassProvedores.NombreProvedor = lector.GetString(4)
            End If



            'MsgBox(lector.GetString(0))
            Lista.Add(ClassProvedores)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function FindExtraDataGridViewer(Find) As List(Of ClassExtras)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select * From dbo.Extras Where PartNumber Like '%" + Find + "%' or  Description Like '%" + Find + "%' or  Type Like '%" + Find + "%'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassExtras)
        Dim ClassExtras As ClassExtras
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassExtras = New ClassExtras

            If lector.IsDBNull(0) Then
                ClassExtras.IdExtra = "Sin id"
            Else
                ClassExtras.IdExtra = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ClassExtras.PartNumber = "Sin numero de parte"
            Else
                ClassExtras.PartNumber = lector.GetString(2)
            End If


            If lector.IsDBNull(2) Then
                ClassExtras.Description = "Sin descripcion"
            Else
                ClassExtras.Description = lector.GetString(1)
            End If

            If lector.IsDBNull(3) Then
                ClassExtras.Qty = "Sin stock"
            Else
                ClassExtras.Qty = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassExtras.Type = "Sin categoria"
            Else
                ClassExtras.Type = lector.GetString(4)
            End If



            'MsgBox(lector.GetString(0))
            Lista.Add(ClassExtras)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function

    Function FindSqueegeeDataGridViewer(Find) As List(Of ClassSqueegees)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select * From dbo.Squeegees Where Name Like '%" + Find + "%' or  Coments Like '%" + Find + "%'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassSqueegees)
        Dim ClassSqueegees As ClassSqueegees
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassSqueegees = New ClassSqueegees

            If lector.IsDBNull(0) Then
                ClassSqueegees.IdSqueeg = "Sin id"
            Else
                ClassSqueegees.IdSqueeg = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ClassSqueegees.NombreSquee = "Sin nombre"
            Else
                ClassSqueegees.NombreSquee = lector.GetString(2)
            End If


            If lector.IsDBNull(2) Then
                ClassSqueegees.WidthSquee = "Sin ancho"
            Else
                ClassSqueegees.WidthSquee = lector.GetString(1)
            End If

            If lector.IsDBNull(3) Then
                ClassSqueegees.ComentsSquee = "Sin comentarios"
            Else
                ClassSqueegees.ComentsSquee = lector.GetString(3)
            End If



            'MsgBox(lector.GetString(0))
            Lista.Add(ClassSqueegees)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function

    Function FindAssemblyDataGridViewer(Find) As List(Of ClassAsemblys)
        Conectar()
        Comando = Conexiones.CreateCommand()


        Comando.CommandText = "Select Id,Final,TD,HM,SM,PCB,Comentarios from dbo.Assembly Where Final Like '%" + Find + "%' or TD Like '%" + Find + "%' or HM Like '%" + Find + "%' or SM Like '%" + Find + "%' or PCB Like '%" + Find + "%' or SM Comentarios '%" + Find + "%'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassAsemblys)
        Dim ClassAsemblys As ClassAsemblys
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassAsemblys = New ClassAsemblys

            If lector.IsDBNull(0) Then
                ClassAsemblys.IdAsem = "Sin Id"
            Else
                ClassAsemblys.IdAsem = lector.GetInt32(0)
            End If

            If lector.IsDBNull(1) Then
                ClassAsemblys.Fin = "Sin ubicacion"
            Else
                ClassAsemblys.Fin = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassAsemblys.T = "Sin nombre"
            Else
                ClassAsemblys.T = lector.GetString(2)
            End If


            If lector.IsDBNull(3) Then
                ClassAsemblys.H = "Sin ensamble"
            Else
                ClassAsemblys.H = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassAsemblys.S = "Sin PCB"
            Else
                ClassAsemblys.S = lector.GetString(4)
            End If

            If lector.IsDBNull(5) Then
                ClassAsemblys.PC = "Sin comentarios"
            Else
                ClassAsemblys.PC = lector.GetString(5)
            End If

            If lector.IsDBNull(5) Then
                ClassAsemblys.Com = "Sin comentarios"
            Else
                ClassAsemblys.Com = lector.GetString(5)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassAsemblys)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function

    Function FindStencilDataGridViewer(Find) As List(Of ClassStenciles)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Id,Ubicacion,Stencil,Ensamble,PCB,Comentarios From dbo.Stencil Where Stencil Like '%" + Find + "%' or Ensamble Like '%" + Find + "%' or PCB Like '%" + Find + "%' or Comentarios Like '%" + Find + "%'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassStenciles)
        Dim ClassStenciles As ClassStenciles
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassStenciles = New ClassStenciles


            If lector.IsDBNull(0) Then
                ClassStenciles.IdSten = "Sin ubicacion"
            Else
                ClassStenciles.IdSten = lector.GetInt32(0)
            End If

            If lector.IsDBNull(1) Then
                ClassStenciles.UbicacionSten = "Sin ubicacion"
            Else
                ClassStenciles.UbicacionSten = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassStenciles.NombreSten = "Sin nombre"
            Else
                ClassStenciles.NombreSten = lector.GetString(2)
            End If


            If lector.IsDBNull(3) Then
                ClassStenciles.EnsambleSten = "Sin ensamble"
            Else
                ClassStenciles.EnsambleSten = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassStenciles.PCBSten = "Sin PCB"
            Else
                ClassStenciles.PCBSten = lector.GetString(4)
            End If

            If lector.IsDBNull(5) Then
                ClassStenciles.ComentariosSten = "Sin comentarios"
            Else
                ClassStenciles.ComentariosSten = lector.GetString(5)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassStenciles)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function

    Function LogConsultaStencilDataGridViewer(NameStencil) As List(Of ClassLogStenciles)
        Conectar()
        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Id,String,Id_User,Date from dbo.Logs WHERE String Like '%" + NameStencil + "%'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassLogStenciles)
        Dim ClassLogStenciles As ClassLogStenciles
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassLogStenciles = New ClassLogStenciles

            If lector.IsDBNull(0) Then
                ClassLogStenciles.Id = 0
            Else
                ClassLogStenciles.Id = lector.GetInt32(0)
            End If

            If lector.IsDBNull(1) Then
                ClassLogStenciles.Text = "Sin registro"
            Else
                ClassLogStenciles.Text = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassLogStenciles.User = "Sin user"
            Else
                ClassLogStenciles.User = lector.GetString(2)
            End If


            If lector.IsDBNull(3) Then
                ClassLogStenciles.Fecha = "Sin fecha"
            Else
                ClassLogStenciles.Fecha = lector.GetString(3)
            End If



            'MsgBox(lector.GetString(0))
            Lista.Add(ClassLogStenciles)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function

    Function FindLogStencilDataGridViewer(Find, NameStencil) As List(Of ClassLogStenciles)
        Conectar()
        Comando = Conexiones.CreateCommand()
        'MsgBox(Find)
        Comando.CommandText = "Select Id,String,Id_User,Date From dbo.Logs Where String Like '%" + Find + "%' or Id_User Like '%" + Find + "%' 
                        AND String Like '% Edit Stencil %' or String like '% Take stencil %' 
                        or String like '% Return stencil %' or String like '% Add stencil %' 
                        AND String like '% " + NameStencil + " %'"
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassLogStenciles)
        Dim ClassLogStenciles As ClassLogStenciles
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassLogStenciles = New ClassLogStenciles

            If lector.IsDBNull(0) Then
                ClassLogStenciles.Id = 0
            Else
                ClassLogStenciles.Id = lector.GetInt32(0)
            End If

            If lector.IsDBNull(1) Then
                ClassLogStenciles.Text = "Sin registro"
            Else
                ClassLogStenciles.Text = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassLogStenciles.User = "Sin user"
            Else
                ClassLogStenciles.User = lector.GetString(2)
            End If


            If lector.IsDBNull(3) Then
                ClassLogStenciles.Fecha = "Sin fecha"
            Else
                ClassLogStenciles.Fecha = lector.GetString(3)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassLogStenciles)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function

    Function ConsultaPalletDataGridViewer(Machine) As List(Of ClassPallets)
        Conectar()

        Comando = Conexiones.CreateCommand()
        If (Machine <> "") Then
            Comando.CommandText = "Select Ubicacion,Ensamble,Id,PCB,Comentarios from dbo.Pallets Where Id_Machine='" + Machine + "'"
        Else
            Comando.CommandText = "Select Ubicacion,Ensamble,Id,PCB,Comentarios from dbo.Pallets Where Id_Machine='0' Or Id_Machine='1'"
        End If


        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassPallets)
        Dim ClassPallets As ClassPallets
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassPallets = New ClassPallets

            If lector.IsDBNull(0) Then
                ClassPallets.UbicacionPall = "Sin ubicacion"
            Else
                ClassPallets.UbicacionPall = lector.GetString(0)
            End If


            If lector.IsDBNull(1) Then
                ClassPallets.EnsamblePall = "Sin nombre"
            Else
                ClassPallets.EnsamblePall = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassPallets.IdPall = "0"
            Else
                ClassPallets.IdPall = lector.GetInt32(2)
            End If

            If lector.IsDBNull(3) Then
                ClassPallets.PCBPall = "Sin PCB"
            Else
                ClassPallets.PCBPall = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassPallets.ComentariosPall = "Sin comentarios"
            Else
                ClassPallets.ComentariosPall = lector.GetString(4)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassPallets)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function ConsultaUserDataGridViewer() As List(Of ClassUsers)
        Conectar()

        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Id,Nombre,Apellido,Email,Lvl from dbo.Usuarios"



        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassUsers)
        Dim ClassUsers As ClassUsers
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassUsers = New ClassUsers

            If lector.IsDBNull(0) Then
                ClassUsers.IdUs = "0"
            Else
                ClassUsers.IdUs = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ClassUsers.Name = "Sin nombre"
            Else
                ClassUsers.Name = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassUsers.LastName = "0"
            Else
                ClassUsers.LastName = lector.GetString(2)
            End If

            If lector.IsDBNull(3) Then
                ClassUsers.Mail = "Sin PCB"
            Else
                ClassUsers.Mail = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassUsers.Level = "Sin comentarios"
            Else
                ClassUsers.Level = lector.GetInt32(4)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassUsers)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function FindUserDataGridViewer(Find) As List(Of ClassUsers)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Dim Validar = Find.GetType()

        If IsNumeric(Find) Then
            Comando.CommandText = "Select Id,Nombre,Apellido,Email,Lvl from dbo.Usuarios Where Id Like'%" + Find + "%' or Nombre Like '%" + Find + "%' or Apellido Like '%" + Find + "%' or  Email Like '%" + Find + "%'"
            'MsgBox("Es un numero")
        ElseIf TypeOf Find Is String Then

            Comando.CommandText = "Select Id,Nombre,Apellido,Email,Lvl from dbo.Usuarios Where Nombre Like '%" + Find + "%' or Apellido Like '%" + Find + "%' or  Email Like '%" + Find + "%'"
            'MsgBox("Es un string")
        End If

        'Comando.CommandText = "Select Id,Nombre,Apellido,Email,Lvl from dbo.Usuarios Where Id='" + User + "' or Nombre Like '%" + Find + "%' or Apellido Like '%" + Find + "%' or  Email Like '%" + Find + "%'"



        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassUsers)
        Dim ClassUsers As ClassUsers
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassUsers = New ClassUsers

            If lector.IsDBNull(0) Then
                ClassUsers.IdUs = "0"
            Else
                ClassUsers.IdUs = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ClassUsers.Name = "Sin nombre"
            Else
                ClassUsers.Name = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassUsers.LastName = "0"
            Else
                ClassUsers.LastName = lector.GetString(2)
            End If

            If lector.IsDBNull(3) Then
                ClassUsers.Mail = "Sin PCB"
            Else
                ClassUsers.Mail = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassUsers.Level = "Sin comentarios"
            Else
                ClassUsers.Level = lector.GetInt32(4)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassUsers)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function ConsultaUserAdminDataGridViewer() As List(Of ClassUsers)
        Conectar()

        Comando = Conexiones.CreateCommand()

        Comando.CommandText = "Select Id,Nombre,Apellido,Email,Lvl from dbo.Usuarios Where Lvl='10'"



        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassUsers)
        Dim ClassUsers As ClassUsers
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassUsers = New ClassUsers

            If lector.IsDBNull(0) Then
                ClassUsers.IdUs = "0"
            Else
                ClassUsers.IdUs = lector.GetInt32(0)
            End If


            If lector.IsDBNull(1) Then
                ClassUsers.Name = "Sin nombre"
            Else
                ClassUsers.Name = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassUsers.LastName = "0"
            Else
                ClassUsers.LastName = lector.GetString(2)
            End If

            If lector.IsDBNull(3) Then
                ClassUsers.Mail = "Sin PCB"
            Else
                ClassUsers.Mail = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassUsers.Level = "Sin comentarios"
            Else
                ClassUsers.Level = lector.GetInt32(4)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassUsers)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function
    Function FindPalletDataGridViewer(Find, Machine) As List(Of ClassPallets)
        Conectar()



        Comando = Conexiones.CreateCommand()
        If (Machine <> "") Then
            Comando.CommandText = "Select Ubicacion,Ensamble,Id,PCB,Comentarios from dbo.Pallets Where Pallet Like '%" + Find + "%' or Id_Pallet Like '%" + Find + "%' or PCB Like '%" + Find + "%' or Comentarios Like '%" + Find + "%' AND Id_Machine='" + Machine + "'"
        Else
            Comando.CommandText = "Select Ubicacion,Ensamble,Id,PCB,Comentarios from dbo.Pallets Where Pallet Like '%" + Find + "%' or Id_Pallet Like '%" + Find + "%' or PCB Like '%" + Find + "%' or Comentarios Like '%" + Find + "%' AND Id_Machine='0' Or Id_Machine='1'"
        End If
        Dim lector As SqlDataReader = Comando.ExecuteReader()

        Dim Lista As New List(Of ClassPallets)
        Dim ClassPallets As ClassPallets
        While (lector.Read())
            'Se va a crear uno nuevo sin repetirse
            ClassPallets = New ClassPallets

            If lector.IsDBNull(0) Then
                ClassPallets.UbicacionPall = "Sin ubicacion"
            Else
                ClassPallets.UbicacionPall = lector.GetString(0)
            End If


            If lector.IsDBNull(1) Then
                ClassPallets.EnsamblePall = "Sin nombre"
            Else
                ClassPallets.EnsamblePall = lector.GetString(1)
            End If


            If lector.IsDBNull(2) Then
                ClassPallets.IdPall = "0"
            Else
                ClassPallets.IdPall = lector.GetInt32(2)
            End If

            If lector.IsDBNull(3) Then
                ClassPallets.PCBPall = "Sin PCB"
            Else
                ClassPallets.PCBPall = lector.GetString(3)
            End If

            If lector.IsDBNull(4) Then
                ClassPallets.ComentariosPall = "Sin comentarios"
            Else
                ClassPallets.ComentariosPall = lector.GetString(4)
            End If

            'MsgBox(lector.GetString(0))
            Lista.Add(ClassPallets)
        End While
        lector.Close()
        'MsgBox(ex.ToString)
        Desconectar()
        Return Lista
    End Function


    Sub LogAdd(Accion As String, User As String)
        Conectar()
        Dim RegistroLog = Convert.ToString(Accion)
        Dim Fecha As String
        Fecha = Convert.ToString(Date.Now)
        Comando = New SqlCommand("Insert Into Logs(String, Id_User, Date) Values ('" + RegistroLog + "','" + User + "', '" + Fecha + "')", Conexiones)

        'Comando.ExecuteNonQuery()
        If (Comando.ExecuteNonQuery() <> 0) Then
            'Si se ejecuto correctamente.
            MsgBox("Datos guardados exitosamente")
            DataGridStencil.Log = "1"
        Else
            'Si no se ejecuto correctamente.
        End If

        Desconectar()

    End Sub

    Sub DeleteUser(Id)
        Conectar()



        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Usuarios WHERE id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            'Si se ejecuto correctamente.

            MsgBox("Usuario eliminado exitosamente")
            'DataGridStencil.Log = "1"
        Else
            MsgBox("Usuario eliminado fallado")
        End If

        'MsgBox(ex.ToString)
        Desconectar()
    End Sub
    Sub DeleteSqueege(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Squeegees WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            'Si se ejecuto correctamente.

            MsgBox("Squeege eliminada exitosamente")
            'DataGridStencil.Log = "1"
        Else
            MsgBox("Squeege eliminado fallado")
        End If

        'MsgBox(ex.ToString)
        Desconectar()
    End Sub
    Sub DeleteAssembly(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Assembly WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Ensamble eliminado exitosamente")
        Else
            MsgBox("Ensamble eliminado fallado")
        End If

        Desconectar()
    End Sub
    Sub DeleteMachine(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Machines WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Machine eliminada exitosamente")
        Else
            MsgBox("Machine eliminado fallado")
        End If

        Desconectar()
    End Sub
    Sub DeleteProvedor(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Provedores WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Provedor eliminado exitosamente")
        Else
            MsgBox("Provedor eliminado fallado")
        End If

        Desconectar()
    End Sub
    Sub DeleteProyecto(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Proyectos WHERE ID = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Proyecto eliminado exitosamente")
        Else
            MsgBox("Proyecto eliminado fallado")
        End If

        Desconectar()
    End Sub

    Sub DeleteExtra(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Extras WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Part Number eliminado exitosamente")
        Else
            MsgBox("Part Number  eliminado fallado")
        End If

        Desconectar()
    End Sub
    Sub DeleteTension(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Tenciones WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Tension eliminada exitosamente")
        Else
            MsgBox("Tension eliminada fallado")
        End If

        Desconectar()
    End Sub

    Sub DeleteLog(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Logs WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            MsgBox("Log eliminado exitosamente")
        Else
            MsgBox("Log eliminado fallado")
        End If

        Desconectar()
    End Sub
    Sub DeleteStencil(Id)
        Conectar()



        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Stencil WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            'Si se ejecuto correctamente.

            MsgBox("Stencil eliminado exitosamente")
            'DataGridStencil.Log = "1"
        Else
            MsgBox("Stencil eliminado fallado")
        End If

        'MsgBox(ex.ToString)
        Desconectar()
    End Sub
    Sub DeletePallet(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Pallets WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            'Si se ejecuto correctamente.

            MsgBox("Pallet eliminada exitosamente")
            'DataGridStencil.Log = "1"
        Else
            MsgBox("Pallet eliminado fallado")
        End If

        'MsgBox(ex.ToString)
        Desconectar()
    End Sub

    Sub DeleteFrame(Id)
        Conectar()

        Comando = Conexiones.CreateCommand()
        Comando.CommandText = "DELETE FROM dbo.Frames WHERE Id = '" + Id + "'"
        If (Comando.ExecuteNonQuery() <> 0) Then
            'Si se ejecuto correctamente.

            MsgBox("Frame eliminado exitosamente")
            'DataGridStencil.Log = "1"
        Else
            MsgBox("Frame eliminado fallado")
        End If

        'MsgBox(ex.ToString)
        Desconectar()
    End Sub
    Sub CountTooling()
        Conectar()
        'Dim TotalCount As String
        Comando = New SqlCommand("Select COUNT(*) From dbo.Pallets Where Id_Machine='0'", Conexiones)
        Graphics.CountPalletRegular = Comando.ExecuteScalar()

        Comando = New SqlCommand("Select COUNT(*) From dbo.Pallets Where Id_Machine='1'", Conexiones)
        Graphics.CountPalletSelectiva = Comando.ExecuteScalar()

        Comando = New SqlCommand("Select COUNT(*) From Usuarios", Conexiones)
        Graphics.TotalUsers = Comando.ExecuteScalar()

        Desconectar()
    End Sub

End Class


