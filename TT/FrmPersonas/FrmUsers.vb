﻿Public Class FrmUsers
    Private _usuario As New Usuario
    Dim dataset As New DataSet
    Dim BsnUsuario As New BsnUsuario
    Dim validacion As New Validacionesv2
    Dim BsnEmpleado As New BsnEmpleado


    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        txtRut.MaxLength = validacion.MaxRut
        txtDV.MaxLength = validacion.MaxRutVerificador
        txtContraseña.MaxLength = validacion.MaxPassword

        dataset = BsnUsuario.obtenerUsuarios()
        dgvUsua.DataSource = dataset.Tables(0).DefaultView


        reset()
    End Sub

    Public Sub recargarDGV()
        dataset = BsnUsuario.obtenerUsuarios()
        dgvUsua.DataSource = dataset.Tables(0).DefaultView
    End Sub

    Private Sub picEliminar_Click(sender As Object, e As EventArgs) Handles picEliminar.Click
        If dgvUsua.Rows.Count > 0 Then
            If dgvUsua.CurrentRow.Index > -1 Then
                Dim rut_empleado As String = dgvUsua.CurrentRow.Cells(1).Value
                Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
                Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
                'MsgBox(response)

                If response = 6 Then
                    BsnUsuario.eliminarUsuario(rut_empleado)
                    Dim Empleado As New Empleado
                    Empleado.Rut = rut_empleado
                    BsnEmpleado.eliminarEmpleado(Empleado)

                    txtRut.Text = ""
                    txtContraseña.Text = ""
                    cmbPermisos.ResetText()
                    recargarDGV()
                End If
            End If
        End If
    End Sub

    Private Sub picEditar_Click(sender As Object, e As EventArgs) Handles picEditar.Click
        If dgvUsua.Rows.Count > 0 Then
            pnlComponentes.Enabled = True
            If dgvUsua.CurrentRow.Index > -1 Then
                Dim fila() As String = {dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(0).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(1).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(2).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(3).Value}
                txtRut.Text = fila(1)
                txtContraseña.Text = fila(2)
                'setear el combobox    
                'MsgBox(fila(0) & " " & fila(1) & " " & fila(2) & " " & fila(3))
                cmbPermisos.SelectedIndex = CInt(fila(3)) - 1
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'PRIMERO VALIDAR
        If RealizarValidacion() Then

        End If
        If dgvUsua.Rows.Count > 0 Then
            Dim pal As String = ""
            Dim contador As Byte = 0
            Dim isCorrect As Boolean = True


            If txtContraseña.Text = "" Then
                contador = contador + 1
                pal = pal & contador & "-Por favor complete la contraseña..." & vbCrLf
                isCorrect = False
            End If

            If cmbPermisos.SelectedIndex <= -1 Then
                contador = contador + 1
                pal = pal & contador & "-Por favor seleccione permisos para el usuario..."
                isCorrect = False
            End If

            If Not isCorrect Then
                MsgBox(pal)
            Else
                Dim Usuario As New Usuario
                Usuario.Rut = txtRut.Text
                Usuario.Password = txtContraseña.Text
                Usuario.Permisos = cmbPermisos.Text
                BsnUsuario.editarUsuario(Usuario)

                txtRut.Text = ""
                txtContraseña.Text = ""
                cmbPermisos.ResetText()
                recargarDGV()
            End If

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
    End Sub

    Private Sub dgvUsua_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsua.SelectionChanged
        If dgvUsua.CurrentRow.Index > -1 Then
            Dim fila() As String = {dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(0).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(1).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(2).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(3).Value}
            txtRut.Text = fila(1)
            txtContraseña.Text = fila(2)
            'setear el combobox    
            'MsgBox(fila(0) & " " & fila(1) & " " & fila(2) & " " & fila(3))
            cmbPermisos.SelectedIndex = CInt(fila(3)) - 1
        End If
    End Sub






    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
        e.Handled = validacion.IRut(e)
    End Sub

    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDV.KeyPress
        e.Handled = validacion.IRutVerificador(e)
    End Sub
    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        e.Handled = validacion.IPassword(e)
    End Sub

    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        Dim ListaText As New List(Of String())
        ListaText.Add({"rut", txtRut.Text})
        ListaText.Add({"digito verificador", txtDV.Text})
        ListaText.Add({"password", txtContraseña.Text})
        Dim receptor = validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX 
        If receptor(0) Then
            'VALIDAR QUE LOS CMD , SI EXISTEN U OTRO ELEMENTO CUMPLE CON LA VAL
            If Not cmbPermisos.SelectedIndex < 0 Then

                'VALIDAR QUE LOS DATOS CUMPLAN ESTRUTURA -> RUT O EMAIL
                If validacion.ValidarRut(txtRut.Text, txtDV.Text) Then '<- INGRESAR RUT Y DV
                    cumple = True
                Else
                    MsgBox("SR ADMINISTRADOR EL RUT NO ES VALIDO")
                End If
            Else
                MsgBox("SR ADMINISTRADOR POR FAVOR ESTABLESCA LOS PERMISOS")
            End If
        Else
            MsgBox(receptor(1))
        End If


        Return cumple
    End Function
    Private Sub reset()
        Dim permiso As New Permisos
        picEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "USUARIOS", "AGREGAR", "")
        picEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "USUARIOS", "EDITAR", "")
        picEliminar = permiso.OtorgarAcceso(_usuario.Permisos, "USUARIOS", "ELIMINAR", "")
    End Sub
End Class
