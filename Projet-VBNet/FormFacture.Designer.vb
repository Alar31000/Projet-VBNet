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
        Me.TextBoxNIP = New System.Windows.Forms.TextBox()
        Me.LabelNumeroCarte = New System.Windows.Forms.Label()
        Me.LabelDateEx = New System.Windows.Forms.Label()
        Me.LabelNIP = New System.Windows.Forms.Label()
        Me.LabelNumeroCompte = New System.Windows.Forms.Label()
        Me.TextBoxNumeroCompte = New System.Windows.Forms.TextBox()
        Me.TextBoxCVV = New System.Windows.Forms.TextBox()
        Me.LabelCvv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonPaye
        '
        Me.ButtonPaye.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonPaye.Location = New System.Drawing.Point(71, 208)
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
        Me.CheckedListBoxModePaiement.Items.AddRange(New Object() {"Prélèvement  automatique", "Carte credit "})
        Me.CheckedListBoxModePaiement.Location = New System.Drawing.Point(253, 208)
        Me.CheckedListBoxModePaiement.Name = "CheckedListBoxModePaiement"
        Me.CheckedListBoxModePaiement.Size = New System.Drawing.Size(195, 24)
        Me.CheckedListBoxModePaiement.TabIndex = 1
        '
        'TextBoxNumeroCarte
        '
        Me.TextBoxNumeroCarte.Location = New System.Drawing.Point(330, 287)
        Me.TextBoxNumeroCarte.Name = "TextBoxNumeroCarte"
        Me.TextBoxNumeroCarte.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNumeroCarte.TabIndex = 2
        '
        'TextBoxDateEx
        '
        Me.TextBoxDateEx.Location = New System.Drawing.Point(330, 335)
        Me.TextBoxDateEx.Name = "TextBoxDateEx"
        Me.TextBoxDateEx.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxDateEx.TabIndex = 3
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(642, 253)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNIP.TabIndex = 4
        '
        'LabelNumeroCarte
        '
        Me.LabelNumeroCarte.AutoSize = True
        Me.LabelNumeroCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNumeroCarte.Location = New System.Drawing.Point(196, 287)
        Me.LabelNumeroCarte.Name = "LabelNumeroCarte"
        Me.LabelNumeroCarte.Size = New System.Drawing.Size(127, 21)
        Me.LabelNumeroCarte.TabIndex = 5
        Me.LabelNumeroCarte.Text = "Numero de carte"
        '
        'LabelDateEx
        '
        Me.LabelDateEx.AutoSize = True
        Me.LabelDateEx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelDateEx.Location = New System.Drawing.Point(196, 336)
        Me.LabelDateEx.Name = "LabelDateEx"
        Me.LabelDateEx.Size = New System.Drawing.Size(128, 21)
        Me.LabelDateEx.TabIndex = 6
        Me.LabelDateEx.Text = "Date d'expiration"
        '
        'LabelNIP
        '
        Me.LabelNIP.AutoSize = True
        Me.LabelNIP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNIP.Location = New System.Drawing.Point(516, 251)
        Me.LabelNIP.Name = "LabelNIP"
        Me.LabelNIP.Size = New System.Drawing.Size(35, 21)
        Me.LabelNIP.TabIndex = 7
        Me.LabelNIP.Text = "NIP"
        '
        'LabelNumeroCompte
        '
        Me.LabelNumeroCompte.AutoSize = True
        Me.LabelNumeroCompte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNumeroCompte.Location = New System.Drawing.Point(477, 208)
        Me.LabelNumeroCompte.Name = "LabelNumeroCompte"
        Me.LabelNumeroCompte.Size = New System.Drawing.Size(145, 21)
        Me.LabelNumeroCompte.TabIndex = 8
        Me.LabelNumeroCompte.Text = "Numero de compte"
        '
        'TextBoxNumeroCompte
        '
        Me.TextBoxNumeroCompte.Location = New System.Drawing.Point(642, 210)
        Me.TextBoxNumeroCompte.Name = "TextBoxNumeroCompte"
        Me.TextBoxNumeroCompte.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNumeroCompte.TabIndex = 9
        '
        'TextBoxCVV
        '
        Me.TextBoxCVV.Location = New System.Drawing.Point(330, 385)
        Me.TextBoxCVV.Name = "TextBoxCVV"
        Me.TextBoxCVV.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxCVV.TabIndex = 10
        '
        'LabelCvv
        '
        Me.LabelCvv.AutoSize = True
        Me.LabelCvv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelCvv.Location = New System.Drawing.Point(235, 385)
        Me.LabelCvv.Name = "LabelCvv"
        Me.LabelCvv.Size = New System.Drawing.Size(40, 21)
        Me.LabelCvv.TabIndex = 11
        Me.LabelCvv.Text = "CVV"
        '
        'FormFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 450)
        Me.Controls.Add(Me.LabelCvv)
        Me.Controls.Add(Me.TextBoxCVV)
        Me.Controls.Add(Me.TextBoxNumeroCompte)
        Me.Controls.Add(Me.LabelNumeroCompte)
        Me.Controls.Add(Me.LabelNIP)
        Me.Controls.Add(Me.LabelDateEx)
        Me.Controls.Add(Me.LabelNumeroCarte)
        Me.Controls.Add(Me.TextBoxNIP)
        Me.Controls.Add(Me.TextBoxDateEx)
        Me.Controls.Add(Me.TextBoxNumeroCarte)
        Me.Controls.Add(Me.CheckedListBoxModePaiement)
        Me.Controls.Add(Me.ButtonPaye)
        Me.Name = "FormFacture"
        Me.Text = "FormFacture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPaye As Button
    Friend WithEvents CheckedListBoxModePaiement As CheckedListBox
    Friend WithEvents TextBoxNumeroCarte As TextBox
    Friend WithEvents TextBoxDateEx As TextBox
    Friend WithEvents TextBoxNIP As TextBox
    Friend WithEvents LabelNumeroCarte As Label
    Friend WithEvents LabelDateEx As Label
    Friend WithEvents LabelNIP As Label
    Friend WithEvents LabelNumeroCompte As Label
    Friend WithEvents TextBoxNumeroCompte As TextBox
    Friend WithEvents TextBoxCVV As TextBox
    Friend WithEvents LabelCvv As Label
End Class
