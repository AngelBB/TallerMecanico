Public Class facturas

    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbEntradasTaller.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles datePickerEntrada.ValueChanged

    End Sub

    Private Sub lbPersonaTrae_Click(sender As Object, e As EventArgs) Handles lbPersonaTrae.Click

    End Sub

    Private Sub Entrantes_Click(sender As Object, e As EventArgs) Handles Entrantes.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbPeritoAseguradora.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbNumPoliza.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbEA.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbEmpresaAs.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbNp.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles tbPA.TextChanged

    End Sub

    Private Sub lbEstadoReparacion_Click(sender As Object, e As EventArgs) Handles lbEstadoReparacion.Click

    End Sub

    Private Sub CheckBoxEntradaActiva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEntradaActiva.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MessageBox.Show("Datos guardados correctamente")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        MessageBox.Show("Factura generada correctamente")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        'Recorremos todos los controles del formulario que enviamos  
        For Each control As Control In Me.Controls

            'Filtramos solo aquellos de tipo TextBox
            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto  
            End If
        Next
        MessageBox.Show("Datos borrados")
    End Sub
End Class