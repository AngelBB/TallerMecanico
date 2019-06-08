
Public Class Login
    'Con esta clase no logeamos 
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If tbUser.Text = "usuario" And tbPass.Text = "usuario" Then 'Comprobamos que los datos sean correctos
            Me.Hide() 'Ocultamos nuestra ventana
            MenuPrincipal.Show() 'Mostramos otro formulario
        Else
            MessageBox.Show("Datos incorrectos") 'De lo contrario le informamos
        End If
    End Sub
End Class