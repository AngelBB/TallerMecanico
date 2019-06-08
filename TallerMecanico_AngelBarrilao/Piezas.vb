Public Class Piezas

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Piezas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPedir_Click(sender As Object, e As EventArgs) Handles btnPedir.Click
        MessageBox.Show("Pedido realizado")
    End Sub

    Private Sub lbAtras_Click(sender As Object, e As EventArgs) Handles lbAtras.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub
End Class