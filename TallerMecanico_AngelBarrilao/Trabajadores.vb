Public Class Trabajadores


    Private control = False 'Declaramos esta varible para controlar 


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDir.Click

    End Sub

    Private Sub ComboBoxTipoMecanico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoMecanico.SelectedIndexChanged

    End Sub

    Private Sub TipoMecanico_Click(sender As Object, e As EventArgs) Handles TipoMecanico.Click

    End Sub

    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MessageBox.Show("Datos guardados correctamente")
    End Sub

    Private Sub Salario_Click(sender As Object, e As EventArgs) Handles Salario.Click

    End Sub

    Private Sub tbSalario_TextChanged(sender As Object, e As EventArgs) Handles tbSalario.TextChanged

    End Sub

    Private Sub Trabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbMecanico_Click(sender As Object, e As EventArgs) Handles lbMecanico.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevouser.Click
        If control = False Then
            ComboBoxMecanico.Hide()
            control = True
            'Recorremos todos los controles del formulario que enviamos  
            For Each control As Control In Me.Controls

                'Filtramos solo aquellos de tipo TextBox
                If TypeOf control Is TextBox Then
                    control.Text = "" ' eliminar el texto  
                End If
            Next
        Else
            control = False
            ComboBoxMecanico.Show()
        End If
    End Sub
End Class