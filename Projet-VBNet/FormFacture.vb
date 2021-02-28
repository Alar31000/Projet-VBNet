Public Class FormFacture
    Private Sub CheckedListBoxModePaiement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxModePaiement.SelectedIndexChanged

    End Sub

    Private Sub TextBoxNIP_TextChanged(sender As Object, e As EventArgs)
        LabelFacture.Visible = True
    End Sub

    Private Sub LabelFacture_Click(sender As Object, e As EventArgs) Handles LabelFacture.Click

    End Sub

    Private Sub ButtonPaye_Click(sender As Object, e As EventArgs) Handles ButtonPaye.Click
        CheckedListBoxModePaiement.Visible = True
    End Sub
End Class