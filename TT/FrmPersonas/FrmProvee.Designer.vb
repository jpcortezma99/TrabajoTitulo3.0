﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProvee
    Inherits TT.FormTamaño

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProvee))
        Me.picEditar = New System.Windows.Forms.PictureBox()
        Me.picEliminar = New System.Windows.Forms.PictureBox()
        Me.picAgregar = New System.Windows.Forms.PictureBox()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.dgvProv = New System.Windows.Forms.DataGridView()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEditar
        '
        Me.picEditar.Image = CType(resources.GetObject("picEditar.Image"), System.Drawing.Image)
        Me.picEditar.Location = New System.Drawing.Point(1100, 435)
        Me.picEditar.Name = "picEditar"
        Me.picEditar.Size = New System.Drawing.Size(39, 36)
        Me.picEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEditar.TabIndex = 23
        Me.picEditar.TabStop = False
        '
        'picEliminar
        '
        Me.picEliminar.Image = CType(resources.GetObject("picEliminar.Image"), System.Drawing.Image)
        Me.picEliminar.Location = New System.Drawing.Point(1055, 435)
        Me.picEliminar.Name = "picEliminar"
        Me.picEliminar.Size = New System.Drawing.Size(39, 36)
        Me.picEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEliminar.TabIndex = 22
        Me.picEliminar.TabStop = False
        '
        'picAgregar
        '
        Me.picAgregar.Image = CType(resources.GetObject("picAgregar.Image"), System.Drawing.Image)
        Me.picAgregar.Location = New System.Drawing.Point(1010, 435)
        Me.picAgregar.Name = "picAgregar"
        Me.picAgregar.Size = New System.Drawing.Size(39, 36)
        Me.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAgregar.TabIndex = 21
        Me.picAgregar.TabStop = False
        '
        'txtProv
        '
        Me.txtProv.Location = New System.Drawing.Point(228, 108)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(911, 20)
        Me.txtProv.TabIndex = 20
        '
        'cmbProv
        '
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(12, 108)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(210, 21)
        Me.cmbProv.TabIndex = 19
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(542, 54)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(173, 25)
        Me.lblUsuario.TabIndex = 18
        Me.lblUsuario.Text = "PROVEEDORES"
        '
        'dgvProv
        '
        Me.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProv.Location = New System.Drawing.Point(12, 150)
        Me.dgvProv.Name = "dgvProv"
        Me.dgvProv.Size = New System.Drawing.Size(1127, 269)
        Me.dgvProv.TabIndex = 17
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(35, 23)
        Me.BtnExit.TabIndex = 67
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmProvee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.picEditar)
        Me.Controls.Add(Me.picEliminar)
        Me.Controls.Add(Me.picAgregar)
        Me.Controls.Add(Me.txtProv)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.dgvProv)
        Me.Name = "FrmProvee"
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEditar As PictureBox
    Friend WithEvents picEliminar As PictureBox
    Friend WithEvents picAgregar As PictureBox
    Friend WithEvents txtProv As TextBox
    Friend WithEvents cmbProv As ComboBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents dgvProv As DataGridView
    Friend WithEvents BtnExit As Button
End Class
