Public Class PageConsulter
    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        '  StatusStrip1.Visible = True
        'StatusStrip1.Text = "Bonjour, Yaseen"
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Services_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Facture_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Équipements_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Contrats_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PageConsulter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Déconnexion_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub mnuContrat_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles SGARI.ItemClicked

    End Sub
End Class