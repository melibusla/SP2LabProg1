Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Inicializacion del formulario
        'preseleccionada cabaña A'
        cmbTipo.SelectedIndex = 0
        'no muestra ningun tipo de tarjeta'
        cmbTarjetas.SelectedIndex = -1
        'combo inhabilitado'
        cmbTarjetas.Enabled = False
        'casillas sin chequear'
        chkCocina.Checked = False
        chkHeladera.Checked = False
        chkTv.Checked = False
        optContado.Checked = True
        btnAceptar.Enabled = False
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim Dias As Integer
        Dim Personas As Integer
        Dim Costo As Decimal
        Const BASE_A As Decimal = 200.0
        Const BASE_B As Decimal = 400.0
        Const PERSONA_DIA As Decimal = 10

        Dias = numDias.Value
        Personas = numPersonas.Value
        Costo = 0

        If cmbTipo.SelectedIndex = 0 Then
            Costo = Costo + BASE_A
        Else
            Costo = Costo + BASE_B
        End If
        Costo = Costo + (PERSONA_DIA * Dias) * Personas
        If chkCocina.Checked = True Then
            Costo = Costo + (10 * Dias)
        End If
        If chkHeladera.Checked = True Then
            Costo = Costo + (15 * Dias)
        End If
        If chkTv.Checked = True Then
            Costo = Costo + (20 * Dias)
        End If
        If optCredito.Checked = True Then
            If cmbTarjetas.SelectedIndex = 0 Then
                Costo = Costo + (Costo * 10 / 100)
            Else
                Costo = Costo + (Costo * 20 / 100)
            End If
        End If
        txtCosto.Text = Costo.ToString()
    End Sub

    Private Sub optCredito_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optCredito.CheckedChanged
        cmbTarjetas.Enabled = True
        cmbTarjetas.SelectedIndex = 0
    End Sub

    Private Sub optContado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optContado.CheckedChanged
        cmbTarjetas.Enabled = False
        cmbTarjetas.SelectedIndex = -1
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            btnAceptar.Enabled = True
        Else
            btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTelefono.TextChanged
        If txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            btnAceptar.Enabled = True
        Else
            btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.SelectedIndex = 0 Then
            numPersonas.Maximum = 4
        Else
            numPersonas.Maximum = 8
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        cmbTipo.SelectedIndex = 0
        cmbTarjetas.SelectedIndex = -1
        cmbTarjetas.Enabled = False
        chkCocina.Checked = False
        chkHeladera.Checked = False
        chkTv.Checked = False
        optContado.Checked = True
        btnAceptar.Enabled = False
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtCosto.Text = ""
        numDias.Value = 1
        numPersonas.Value = 1
    End Sub
End Class
