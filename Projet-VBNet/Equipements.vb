Public Class Equipements
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBoxEquipement.Enter

    End Sub

    Private Sub TextBoxTotal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click

        'declaration des variable
        Dim prix1 As Decimal
        Dim prix2 As Decimal
        Dim prix3 As Decimal

        'attribut des valeurs entrées par utilisateur
        prix1 = Val(TextBoxMOrdi.Text)
        prix2 = Val(TextBoxModem.Text)
        prix3 = Val(TextBoxInternet.Text)

        'Appelle se la procedure calculer
        calculer(prix1, prix2, prix3)
    End Sub

    Private Sub LabelMOrdinateurCost_Click(sender As Object, e As EventArgs) Handles LabelMOrdinateurCost.Click

    End Sub

    Private Sub LabelModemCost_Click(sender As Object, e As EventArgs) Handles LabelModemCost.Click

    End Sub

    Private Sub LabelInternetCost_Click(sender As Object, e As EventArgs) Handles LabelInternetCost.Click

    End Sub

    Private Sub ButtonFacture_Click(sender As Object, e As EventArgs) Handles ButtonFacture.Click
        If CheckBoxLouer.Checked = False Then
            MsgBox("veuillez cocher la case louer") 'message box si le case louer n'est pas coché
        Else

            FormFacture.Show()
        End If
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) 
        'quitter la fenêtre
        End
    End Sub

    'Calcule prix total  par  rapport au prix des equipements dependamenet du son choix du client 
    Sub calculer(ByVal nbreOrdi As Decimal, nbreModem As Decimal, nobreMoisInternet As Decimal)

        Dim prixModem As Decimal
        Dim prixOrdi As Decimal
        Dim prixInternet As Decimal
        Dim total As Decimal

        'prix du nombre de ordinateur
        prixOrdi = nbreOrdi * Val(LabelMOrdinateurCost.Text)

        'prix du nombre de modem
        prixModem = nbreModem * Val(LabelModemCost.Text)

        'calcule du prix d'internet selon le nombre de mois
        prixInternet = nobreMoisInternet * Val(LabelInternetCost.Text)

        'LabelInternetCost.Text = ToString(prixInternet + "/mois")

        ' somme des prix des Articles choisir par l'utilisateur
        total = prixModem + prixOrdi + prixInternet
        LabelTotal.Text = String.Format("{0:c}", total)

    End Sub
    Private Sub LabelTotal_Click(sender As Object, e As EventArgs) Handles LabelTotal.Click
        'Calculer()

        'pour affichier la resultat du calcule
    End Sub
End Class