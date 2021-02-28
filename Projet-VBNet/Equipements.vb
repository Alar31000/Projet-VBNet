Public Class Equipements
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBoxEquipement.Enter

    End Sub

    Private Sub TextBoxTotal_TextChanged(sender As Object, e As EventArgs)
        Dim prixOrdi As Decimal
        LabelMOrdinateurCost.Visible = False
        prixOrdi = Val(TextBoxMOrdi.Text) * Val(LabelMOrdinateurCost.Text)
        LabelMOrdinateurCost.Text = ToString(prixOrdi)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim total As Decimal
        total = Val(LabelMOrdinateurCost) + Val(LabelModemCost) + Val(LabelInternetCost)
        LabelTotal.Text = String.Format("{0:c}", total)
    End Sub

    Private Sub LabelMOrdinateurCost_Click(sender As Object, e As EventArgs) Handles LabelMOrdinateurCost.Click

    End Sub

    Private Sub LabelModemCost_Click(sender As Object, e As EventArgs) Handles LabelModemCost.Click
        Dim prixModem As Decimal
        LabelModemCost.Visible = False
        prixModem = Val(TextBoxMOrdi.Text) * Val(LabelMOrdinateurCost.Text)
        LabelModemCost.Text = ToString(prixModem)
    End Sub

    Private Sub LabelInternetCost_Click(sender As Object, e As EventArgs) Handles LabelInternetCost.Click
        Dim prixInternet As Decimal
        LabelInternetCost.Visible = False
        prixInternet = Val(TextBoxMOrdi.Text) * Val(LabelMOrdinateurCost.Text)
        LabelInternetCost.Text = ToString(prixInternet + "/mois")
    End Sub

    Private Sub ButtonFacture_Click(sender As Object, e As EventArgs) Handles ButtonFacture.Click
        If CheckBoxLouer.Checked = False Then
            MsgBox("veuillez cocher la case louer")
        Else

            FormFacture.Show()
        End If
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        End
    End Sub
End Class