<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulter
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnContrat = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnCréer = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnConsulter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRenouveler = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnModifier = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnResilier = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnEquipements = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnServices = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFacturation = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFournisseurs = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRapports = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSécurité = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnAide = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnContrat, Me.MnEquipements, Me.MnServices, Me.MnFacturation, Me.MnFournisseurs, Me.MnRapports, Me.MnSécurité, Me.MnAide})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnContrat
        '
        Me.MnContrat.Checked = True
        Me.MnContrat.CheckOnClick = True
        Me.MnContrat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MnContrat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnCréer, Me.MnConsulter, Me.MnRenouveler, Me.MnModifier, Me.MnResilier, Me.MnQuitter})
        Me.MnContrat.Name = "MnContrat"
        Me.MnContrat.Size = New System.Drawing.Size(59, 20)
        Me.MnContrat.Text = "&Contrat"
        '
        'MnCréer
        '
        Me.MnCréer.Name = "MnCréer"
        Me.MnCréer.Size = New System.Drawing.Size(133, 22)
        Me.MnCréer.Text = "&Créer"
        '
        'MnConsulter
        '
        Me.MnConsulter.Name = "MnConsulter"
        Me.MnConsulter.Size = New System.Drawing.Size(133, 22)
        Me.MnConsulter.Text = "&Consulter"
        '
        'MnRenouveler
        '
        Me.MnRenouveler.Name = "MnRenouveler"
        Me.MnRenouveler.Size = New System.Drawing.Size(133, 22)
        Me.MnRenouveler.Text = "&Renouveler"
        '
        'MnModifier
        '
        Me.MnModifier.Name = "MnModifier"
        Me.MnModifier.Size = New System.Drawing.Size(133, 22)
        Me.MnModifier.Text = "&Modifier"
        '
        'MnResilier
        '
        Me.MnResilier.Name = "MnResilier"
        Me.MnResilier.Size = New System.Drawing.Size(133, 22)
        Me.MnResilier.Text = "&Resilier"
        '
        'MnQuitter
        '
        Me.MnQuitter.Name = "MnQuitter"
        Me.MnQuitter.Size = New System.Drawing.Size(133, 22)
        Me.MnQuitter.Text = "&Quitter"
        '
        'MnEquipements
        '
        Me.MnEquipements.Name = "MnEquipements"
        Me.MnEquipements.Size = New System.Drawing.Size(88, 20)
        Me.MnEquipements.Text = "&Equipements"
        '
        'MnServices
        '
        Me.MnServices.Name = "MnServices"
        Me.MnServices.Size = New System.Drawing.Size(61, 20)
        Me.MnServices.Text = "&Services"
        '
        'MnFacturation
        '
        Me.MnFacturation.Name = "MnFacturation"
        Me.MnFacturation.Size = New System.Drawing.Size(79, 20)
        Me.MnFacturation.Text = "&Facturation"
        '
        'MnFournisseurs
        '
        Me.MnFournisseurs.Name = "MnFournisseurs"
        Me.MnFournisseurs.Size = New System.Drawing.Size(85, 20)
        Me.MnFournisseurs.Text = "&Fournisseurs"
        '
        'MnRapports
        '
        Me.MnRapports.Name = "MnRapports"
        Me.MnRapports.Size = New System.Drawing.Size(66, 20)
        Me.MnRapports.Text = "&Rapports"
        '
        'MnSécurité
        '
        Me.MnSécurité.Name = "MnSécurité"
        Me.MnSécurité.Size = New System.Drawing.Size(61, 20)
        Me.MnSécurité.Text = "&Sécurité"
        '
        'MnAide
        '
        Me.MnAide.Name = "MnAide"
        Me.MnAide.Size = New System.Drawing.Size(43, 20)
        Me.MnAide.Text = "&Aide"
        '
        'FrmConsulter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmConsulter"
        Me.Text = "FrmConsulterPrincipale"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnContrat As ToolStripMenuItem
    Friend WithEvents MnCréer As ToolStripMenuItem
    Friend WithEvents MnConsulter As ToolStripMenuItem
    Friend WithEvents MnRenouveler As ToolStripMenuItem
    Friend WithEvents MnEquipements As ToolStripMenuItem
    Friend WithEvents MnServices As ToolStripMenuItem
    Friend WithEvents MnFacturation As ToolStripMenuItem
    Friend WithEvents MnFournisseurs As ToolStripMenuItem
    Friend WithEvents MnRapports As ToolStripMenuItem
    Friend WithEvents MnSécurité As ToolStripMenuItem
    Friend WithEvents MnAide As ToolStripMenuItem
    Friend WithEvents MnModifier As ToolStripMenuItem
    Friend WithEvents MnResilier As ToolStripMenuItem
    Friend WithEvents MnQuitter As ToolStripMenuItem
End Class
