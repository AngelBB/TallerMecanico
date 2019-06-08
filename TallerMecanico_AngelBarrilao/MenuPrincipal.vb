Public Class MenuPrincipal

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'Cerramos todas las ventanas que se hallan podido habrir para que asi no se nos quede la app colgada
        facturas.Close()
        Login.Close()
        Piezas.Close()
        Trabajadores.Close()
        Me.Close()
    End Sub

    Private Sub btn_informes_Click(sender As Object, e As EventArgs) Handles btn_informes.Click
        facturas.Show()
        Me.Hide()
    End Sub

    Private Sub btn_trabajadores_Click(sender As Object, e As EventArgs) Handles btn_trabajadores.Click
        Trabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btn_piezas_Click(sender As Object, e As EventArgs) Handles btn_piezas.Click
        Piezas.Show()
        Me.Hide()
    End Sub
End Class