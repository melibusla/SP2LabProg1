<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Adicionales = New System.Windows.Forms.GroupBox()
        Me.chkTv = New System.Windows.Forms.CheckBox()
        Me.chkHeladera = New System.Windows.Forms.CheckBox()
        Me.chkCocina = New System.Windows.Forms.CheckBox()
        Me.numDias = New System.Windows.Forms.NumericUpDown()
        Me.Personas = New System.Windows.Forms.Label()
        Me.numPersonas = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTarjetas = New System.Windows.Forms.ComboBox()
        Me.optCredito = New System.Windows.Forms.RadioButton()
        Me.optContado = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Adicionales.SuspendLayout()
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(178, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(75, 48)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(128, 20)
        Me.txtTelefono.TabIndex = 1
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(13, 27)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 2
        Me.Nombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo de Cabaña"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Cabaña A", "Cabaña B"})
        Me.cmbTipo.Location = New System.Drawing.Point(103, 78)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dias"
        '
        'Adicionales
        '
        Me.Adicionales.Controls.Add(Me.chkTv)
        Me.Adicionales.Controls.Add(Me.chkHeladera)
        Me.Adicionales.Controls.Add(Me.chkCocina)
        Me.Adicionales.Location = New System.Drawing.Point(19, 160)
        Me.Adicionales.Name = "Adicionales"
        Me.Adicionales.Size = New System.Drawing.Size(200, 100)
        Me.Adicionales.TabIndex = 7
        Me.Adicionales.TabStop = False
        Me.Adicionales.Text = "Adicionales"
        '
        'chkTv
        '
        Me.chkTv.AutoSize = True
        Me.chkTv.Location = New System.Drawing.Point(6, 65)
        Me.chkTv.Name = "chkTv"
        Me.chkTv.Size = New System.Drawing.Size(40, 17)
        Me.chkTv.TabIndex = 2
        Me.chkTv.Text = "TV"
        Me.chkTv.UseVisualStyleBackColor = True
        '
        'chkHeladera
        '
        Me.chkHeladera.AutoSize = True
        Me.chkHeladera.Location = New System.Drawing.Point(6, 42)
        Me.chkHeladera.Name = "chkHeladera"
        Me.chkHeladera.Size = New System.Drawing.Size(69, 17)
        Me.chkHeladera.TabIndex = 1
        Me.chkHeladera.Text = "Heladera"
        Me.chkHeladera.UseVisualStyleBackColor = True
        '
        'chkCocina
        '
        Me.chkCocina.AutoSize = True
        Me.chkCocina.Location = New System.Drawing.Point(6, 19)
        Me.chkCocina.Name = "chkCocina"
        Me.chkCocina.Size = New System.Drawing.Size(59, 17)
        Me.chkCocina.TabIndex = 0
        Me.chkCocina.Text = "Cocina"
        Me.chkCocina.UseVisualStyleBackColor = True
        '
        'numDias
        '
        Me.numDias.Location = New System.Drawing.Point(103, 106)
        Me.numDias.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDias.Name = "numDias"
        Me.numDias.Size = New System.Drawing.Size(42, 20)
        Me.numDias.TabIndex = 8
        Me.numDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Personas
        '
        Me.Personas.AutoSize = True
        Me.Personas.Location = New System.Drawing.Point(16, 135)
        Me.Personas.Name = "Personas"
        Me.Personas.Size = New System.Drawing.Size(51, 13)
        Me.Personas.TabIndex = 9
        Me.Personas.Text = "Personas"
        '
        'numPersonas
        '
        Me.numPersonas.Location = New System.Drawing.Point(103, 133)
        Me.numPersonas.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numPersonas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPersonas.Name = "numPersonas"
        Me.numPersonas.Size = New System.Drawing.Size(42, 20)
        Me.numPersonas.TabIndex = 10
        Me.numPersonas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTarjetas)
        Me.GroupBox1.Controls.Add(Me.optCredito)
        Me.GroupBox1.Controls.Add(Me.optContado)
        Me.GroupBox1.Location = New System.Drawing.Point(225, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formas de Pago"
        '
        'cmbTarjetas
        '
        Me.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTarjetas.FormattingEnabled = True
        Me.cmbTarjetas.Items.AddRange(New Object() {"Tarjeta A", "Tarjeta B", "Tarjeta C"})
        Me.cmbTarjetas.Location = New System.Drawing.Point(122, 43)
        Me.cmbTarjetas.Name = "cmbTarjetas"
        Me.cmbTarjetas.Size = New System.Drawing.Size(121, 21)
        Me.cmbTarjetas.TabIndex = 2
        '
        'optCredito
        '
        Me.optCredito.AutoSize = True
        Me.optCredito.Location = New System.Drawing.Point(6, 43)
        Me.optCredito.Name = "optCredito"
        Me.optCredito.Size = New System.Drawing.Size(109, 17)
        Me.optCredito.TabIndex = 1
        Me.optCredito.Text = "Tarjeta de Credito"
        Me.optCredito.UseVisualStyleBackColor = True
        '
        'optContado
        '
        Me.optContado.AutoSize = True
        Me.optContado.Checked = True
        Me.optContado.Location = New System.Drawing.Point(6, 19)
        Me.optContado.Name = "optContado"
        Me.optContado.Size = New System.Drawing.Size(65, 17)
        Me.optContado.TabIndex = 0
        Me.optContado.TabStop = True
        Me.optContado.Text = "Contado"
        Me.optContado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Costo de Reserva Total"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(153, 273)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 13
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(333, 44)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(105, 56)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 323)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.numPersonas)
        Me.Controls.Add(Me.Personas)
        Me.Controls.Add(Me.numDias)
        Me.Controls.Add(Me.Adicionales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Form1"
        Me.Text = "Cabaña Alquiler"
        Me.Adicionales.ResumeLayout(False)
        Me.Adicionales.PerformLayout()
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Adicionales As System.Windows.Forms.GroupBox
    Friend WithEvents chkTv As System.Windows.Forms.CheckBox
    Friend WithEvents chkHeladera As System.Windows.Forms.CheckBox
    Friend WithEvents chkCocina As System.Windows.Forms.CheckBox
    Friend WithEvents numDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents Personas As System.Windows.Forms.Label
    Friend WithEvents numPersonas As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTarjetas As System.Windows.Forms.ComboBox
    Friend WithEvents optCredito As System.Windows.Forms.RadioButton
    Friend WithEvents optContado As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button

End Class
