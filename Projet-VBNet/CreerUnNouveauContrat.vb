Public Class CreerUnNouveauContrat
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub btnLocationEquipement_Click(sender As Object, e As EventArgs) Handles btnLocationEquipement.Click
        Equipements.Show()
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Services.Show()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub
End Class