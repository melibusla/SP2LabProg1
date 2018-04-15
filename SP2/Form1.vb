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
End Class
