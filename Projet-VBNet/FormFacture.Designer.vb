<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFacture
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
        Me.ButtonPaye = New System.Windows.Forms.Button()
        Me.CheckedListBoxModePaiement = New System.Windows.Forms.CheckedListBox()
        Me.TextBoxNumeroCarte = New System.Windows.Forms.TextBox()
        Me.TextBoxDateEx = New System.Windows.Forms.TextBox()
        Me.LabelNumeroCarte = New System.Windows.Forms.Label()
        Me.LabelDateEx = New System.Windows.Forms.Label()
        Me.LabelNIP = New System.Windows.Forms.Label()
        Me.LabelNumeroCompte = New System.Windows.Forms.Label()
        Me.TextBoxCVV = New System.Windows.Forms.TextBox()
        Me.LabelCvv = New System.Windows.Forms.Label()
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.LabelFacture = New System.Windows.Forms.Label()
        Me.TextBoxNSuccursale = New System.Windows.Forms.TextBox()
        Me.TextBoxNInstitution = New System.Windows.Forms.TextBox()
        Me.TextBoxNCompte = New System.Windows.Forms.TextBox()
        Me.TextBoxNComptec = New System.Windows.Forms.TextBox()
        Me.TextBoxNIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxFacture.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPaye
        '
        Me.ButtonPaye.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonPaye.Location = New System.Drawing.Point(72, 207)
        Me.ButtonPaye.Name = "ButtonPaye"
        Me.ButtonPaye.Size = New System.Drawing.Size(155, 31)
        Me.ButtonPaye.TabIndex = 0
        Me.ButtonPaye.Text = "Payer Maintenant"
        Me.ButtonPaye.UseVisualStyleBackColor = True
        '
        'CheckedListBoxModePaiement
        '
        Me.CheckedListBoxModePaiement.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckedListBoxModePaiement.FormattingEnabled = True
        Me.CheckedListBoxModePaiement.Items.AddRange(New Object() {"Prélèvement  automatique", "Carte credit ", "Chèque bancaire"})
        Me.CheckedListBoxModePaiement.Location = New System.Drawing.Point(252, 207)
        Me.CheckedListBoxModePaiement.Name = "CheckedListBoxModePaiement"
        Me.CheckedListBoxModePaiement.Size = New System.Drawing.Size(177, 64)
        Me.CheckedListBoxModePaiement.TabIndex = 1
        Me.CheckedListBoxModePaiement.Visible = False
        '
        'TextBoxNumeroCarte
        '
        Me.TextBoxNumeroCarte.Location = New System.Drawing.Point(330, 287)
        Me.TextBoxNumeroCarte.Name = "TextBoxNumeroCarte"
        Me.TextBoxNumeroCarte.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNumeroCarte.TabIndex = 2
        Me.TextBoxNumeroCarte.Visible = False
        '
        'TextBoxDateEx
        '
        Me.TextBoxDateEx.Location = New System.Drawing.Point(330, 335)
        Me.TextBoxDateEx.Name = "TextBoxDateEx"
        Me.TextBoxDateEx.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxDateEx.TabIndex = 3
        Me.TextBoxDateEx.Visible = False
        '
        'LabelNumeroCarte
        '
        Me.LabelNumeroCarte.AutoSize = True
        Me.LabelNumeroCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNumeroCarte.Location = New System.Drawing.Point(195, 288)
        Me.LabelNumeroCarte.Name = "LabelNumeroCarte"
        Me.LabelNumeroCarte.Size = New System.Drawing.Size(127, 21)
        Me.LabelNumeroCarte.TabIndex = 5
        Me.LabelNumeroCarte.Text = "Numéro de carte"
        '
        'LabelDateEx
        '
        Me.LabelDateEx.AutoSize = True
        Me.LabelDateEx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelDateEx.Location = New System.Drawing.Point(184, 336)
        Me.LabelDateEx.Name = "LabelDateEx"
        Me.LabelDateEx.Size = New System.Drawing.Size(128, 21)
        Me.LabelDateEx.TabIndex = 6
        Me.LabelDateEx.Text = "Date d'expiration"
        Me.LabelDateEx.Visible = False
        '
        'LabelNIP
        '
        Me.LabelNIP.AutoSize = True
        Me.LabelNIP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNIP.Location = New System.Drawing.Point(501, 250)
        Me.LabelNIP.Name = "LabelNIP"
        Me.LabelNIP.Size = New System.Drawing.Size(35, 21)
        Me.LabelNIP.TabIndex = 7
        Me.LabelNIP.Text = "NIP"
        Me.LabelNIP.Visible = False
        '
        'LabelNumeroCompte
        '
        Me.LabelNumeroCompte.AutoSize = True
        Me.LabelNumeroCompte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNumeroCompte.Location = New System.Drawing.Point(451, 207)
        Me.LabelNumeroCompte.Name = "LabelNumeroCompte"
        Me.LabelNumeroCompte.Size = New System.Drawing.Size(145, 21)
        Me.LabelNumeroCompte.TabIndex = 8
        Me.LabelNumeroCompte.Text = "Numéro de compte"
        Me.LabelNumeroCompte.Visible = False
        '
        'TextBoxCVV
        '
        Me.TextBoxCVV.Location = New System.Drawing.Point(330, 385)
        Me.TextBoxCVV.Name = "TextBoxCVV"
        Me.TextBoxCVV.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxCVV.TabIndex = 10
        Me.TextBoxCVV.Visible = False
        '
        'LabelCvv
        '
        Me.LabelCvv.AutoSize = True
        Me.LabelCvv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelCvv.Location = New System.Drawing.Point(229, 386)
        Me.LabelCvv.Name = "LabelCvv"
        Me.LabelCvv.Size = New System.Drawing.Size(40, 21)
        Me.LabelCvv.TabIndex = 11
        Me.LabelCvv.Text = "CVV"
        Me.LabelCvv.Visible = False
        '
        'GroupBoxFacture
        '
        Me.GroupBoxFacture.AutoSize = True
        Me.GroupBoxFacture.Controls.Add(Me.LabelFacture)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNSuccursale)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNInstitution)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNCompte)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNComptec)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNIP)
        Me.GroupBoxFacture.Controls.Add(Me.LabelCvv)
        Me.GroupBoxFacture.Controls.Add(Me.ButtonPaye)
        Me.GroupBoxFacture.Controls.Add(Me.CheckedListBoxModePaiement)
        Me.GroupBoxFacture.Controls.Add(Me.Label3)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNIP)
        Me.GroupBoxFacture.Controls.Add(Me.Label2)
        Me.GroupBoxFacture.Controls.Add(Me.Label1)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNumeroCompte)
        Me.GroupBoxFacture.Controls.Add(Me.LabelDateEx)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNumeroCarte)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(1, 1)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Size = New System.Drawing.Size(806, 449)
        Me.GroupBoxFacture.TabIndex = 12
        Me.GroupBoxFacture.TabStop = False
        Me.GroupBoxFacture.Text = "Facture"
        '
        'LabelFacture
        '
        Me.LabelFacture.AutoSize = True
        Me.LabelFacture.ForeColor = System.Drawing.Color.Red
        Me.LabelFacture.Location = New System.Drawing.Point(6, 83)
        Me.LabelFacture.Name = "LabelFacture"
        Me.LabelFacture.Size = New System.Drawing.Size(794, 30)
        Me.LabelFacture.TabIndex = 17
        Me.LabelFacture.Text = "Nous sommes désolé, cette option sera développé dans la prochaine version."
        '
        'TextBoxNSuccursale
        '
        Me.TextBoxNSuccursale.Location = New System.Drawing.Point(632, 289)
        Me.TextBoxNSuccursale.Name = "TextBoxNSuccursale"
        Me.TextBoxNSuccursale.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNSuccursale.TabIndex = 16
        Me.TextBoxNSuccursale.Visible = False
        '
        'TextBoxNInstitution
        '
        Me.TextBoxNInstitution.Location = New System.Drawing.Point(632, 331)
        Me.TextBoxNInstitution.Name = "TextBoxNInstitution"
        Me.TextBoxNInstitution.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNInstitution.TabIndex = 15
        Me.TextBoxNInstitution.Visible = False
        '
        'TextBoxNCompte
        '
        Me.TextBoxNCompte.Location = New System.Drawing.Point(632, 207)
        Me.TextBoxNCompte.Name = "TextBoxNCompte"
        Me.TextBoxNCompte.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNCompte.TabIndex = 14
        Me.TextBoxNCompte.Visible = False
        '
        'TextBoxNComptec
        '
        Me.TextBoxNComptec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNComptec.Location = New System.Drawing.Point(632, 372)
        Me.TextBoxNComptec.Name = "TextBoxNComptec"
        Me.TextBoxNComptec.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNComptec.TabIndex = 13
        Me.TextBoxNComptec.Visible = False
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(632, 248)
        Me.TextBoxNIP.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNIP.TabIndex = 12
        Me.TextBoxNIP.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(477, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numéro de succursale"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(477, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "numéro d'institution"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(477, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "numéro de compte"
        Me.Label1.Visible = False
        '
        'FormFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 450)
        Me.Controls.Add(Me.TextBoxCVV)
        Me.Controls.Add(Me.TextBoxDateEx)
        Me.Controls.Add(Me.TextBoxNumeroCarte)
        Me.Controls.Add(Me.GroupBoxFacture)
        Me.Name = "FormFacture"
        Me.Text = "FormFacture"
        Me.GroupBoxFacture.ResumeLayout(False)
        Me.GroupBoxFacture.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPaye As Button
    Friend WithEvents CheckedListBoxModePaiement As CheckedListBox
    Friend WithEvents TextBoxNumeroCarte As TextBox
    Friend WithEvents TextBoxDateEx As TextBox
    Friend WithEvents LabelNumeroCarte As Label
    Friend WithEvents LabelDateEx As Label
    Friend WithEvents LabelNIP As Label
    Friend WithEvents LabelNumeroCompte As Label
    Friend WithEvents TextBoxCVV As TextBox
    Friend WithEvents LabelCvv As Label
    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelFacture As Label
    Friend WithEvents TextBoxNSuccursale As TextBox
    Friend WithEvents TextBoxNInstitution As TextBox
    Friend WithEvents TextBoxNCompte As TextBox
    Friend WithEvents TextBoxNComptec As TextBox
    Friend WithEvents TextBoxNIP As TextBox
End Class
