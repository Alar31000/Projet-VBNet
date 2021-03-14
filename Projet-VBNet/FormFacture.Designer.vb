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
        Me.TextBoxNumeroCarte = New System.Windows.Forms.TextBox()
        Me.TextBoxDateEx = New System.Windows.Forms.TextBox()
        Me.LabelNumeroCarte = New System.Windows.Forms.Label()
        Me.LabelDateEx = New System.Windows.Forms.Label()
        Me.TextBoxCVV = New System.Windows.Forms.TextBox()
        Me.LabelCvv = New System.Windows.Forms.Label()
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.TextBoxNComptec = New System.Windows.Forms.TextBox()
        Me.LabelComptec = New System.Windows.Forms.Label()
        Me.LabelInstitution = New System.Windows.Forms.Label()
        Me.TextBoxNCompte = New System.Windows.Forms.TextBox()
        Me.LabelSuccursale = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxChèque = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCarte = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPrélèvement = New System.Windows.Forms.CheckBox()
        Me.LabelFacture = New System.Windows.Forms.Label()
        Me.TextBoxNSuccursale = New System.Windows.Forms.TextBox()
        Me.TextBoxNInstitution = New System.Windows.Forms.TextBox()
        Me.TextBoxNIP = New System.Windows.Forms.TextBox()
        Me.LabelNIP = New System.Windows.Forms.Label()
        Me.LabelNumeroCompte = New System.Windows.Forms.Label()
        Me.GroupBoxPrélèvement = New System.Windows.Forms.GroupBox()
        Me.GroupBoxChèque = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCarte = New System.Windows.Forms.GroupBox()
        Me.GroupBoxPayement = New System.Windows.Forms.GroupBox()
        Me.GroupBoxFacture.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPaye
        '
        Me.ButtonPaye.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonPaye.Location = New System.Drawing.Point(39, 199)
        Me.ButtonPaye.Name = "ButtonPaye"
        Me.ButtonPaye.Size = New System.Drawing.Size(155, 31)
        Me.ButtonPaye.TabIndex = 0
        Me.ButtonPaye.Text = "Payer Maintenant"
        Me.ButtonPaye.UseVisualStyleBackColor = True
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
        Me.LabelNumeroCarte.Visible = False
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
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNComptec)
        Me.GroupBoxFacture.Controls.Add(Me.LabelComptec)
        Me.GroupBoxFacture.Controls.Add(Me.LabelInstitution)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNCompte)
        Me.GroupBoxFacture.Controls.Add(Me.LabelSuccursale)
        Me.GroupBoxFacture.Controls.Add(Me.Button1)
        Me.GroupBoxFacture.Controls.Add(Me.CheckBoxChèque)
        Me.GroupBoxFacture.Controls.Add(Me.CheckBoxCarte)
        Me.GroupBoxFacture.Controls.Add(Me.CheckBoxPrélèvement)
        Me.GroupBoxFacture.Controls.Add(Me.LabelFacture)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNSuccursale)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNInstitution)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNIP)
        Me.GroupBoxFacture.Controls.Add(Me.LabelCvv)
        Me.GroupBoxFacture.Controls.Add(Me.ButtonPaye)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNIP)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNumeroCompte)
        Me.GroupBoxFacture.Controls.Add(Me.LabelDateEx)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNumeroCarte)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPrélèvement)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxChèque)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxCarte)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPayement)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(1, 1)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Size = New System.Drawing.Size(817, 465)
        Me.GroupBoxFacture.TabIndex = 12
        Me.GroupBoxFacture.TabStop = False
        Me.GroupBoxFacture.Text = "Facture"
        '
        'TextBoxNComptec
        '
        Me.TextBoxNComptec.Location = New System.Drawing.Point(641, 379)
        Me.TextBoxNComptec.Name = "TextBoxNComptec"
        Me.TextBoxNComptec.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNComptec.TabIndex = 26
        Me.TextBoxNComptec.Visible = False
        '
        'LabelComptec
        '
        Me.LabelComptec.AutoSize = True
        Me.LabelComptec.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelComptec.ForeColor = System.Drawing.Color.Navy
        Me.LabelComptec.Location = New System.Drawing.Point(483, 396)
        Me.LabelComptec.Name = "LabelComptec"
        Me.LabelComptec.Size = New System.Drawing.Size(142, 21)
        Me.LabelComptec.TabIndex = 0
        Me.LabelComptec.Text = "numéro de compte"
        Me.LabelComptec.Visible = False
        '
        'LabelInstitution
        '
        Me.LabelInstitution.AutoSize = True
        Me.LabelInstitution.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInstitution.ForeColor = System.Drawing.Color.Navy
        Me.LabelInstitution.Location = New System.Drawing.Point(473, 347)
        Me.LabelInstitution.Name = "LabelInstitution"
        Me.LabelInstitution.Size = New System.Drawing.Size(152, 21)
        Me.LabelInstitution.TabIndex = 1
        Me.LabelInstitution.Text = "numéro d'institution"
        Me.LabelInstitution.Visible = False
        '
        'TextBoxNCompte
        '
        Me.TextBoxNCompte.Location = New System.Drawing.Point(641, 185)
        Me.TextBoxNCompte.Name = "TextBoxNCompte"
        Me.TextBoxNCompte.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNCompte.TabIndex = 14
        Me.TextBoxNCompte.Visible = False
        Me.TextBoxNCompte.WordWrap = False
        '
        'LabelSuccursale
        '
        Me.LabelSuccursale.AutoSize = True
        Me.LabelSuccursale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelSuccursale.ForeColor = System.Drawing.Color.Navy
        Me.LabelSuccursale.Location = New System.Drawing.Point(460, 304)
        Me.LabelSuccursale.Name = "LabelSuccursale"
        Me.LabelSuccursale.Size = New System.Drawing.Size(165, 21)
        Me.LabelSuccursale.TabIndex = 2
        Me.LabelSuccursale.Text = "Numéro de succursale"
        Me.LabelSuccursale.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 39)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxChèque
        '
        Me.CheckBoxChèque.AutoSize = True
        Me.CheckBoxChèque.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBoxChèque.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxChèque.Location = New System.Drawing.Point(237, 250)
        Me.CheckBoxChèque.Name = "CheckBoxChèque"
        Me.CheckBoxChèque.Size = New System.Drawing.Size(145, 25)
        Me.CheckBoxChèque.TabIndex = 23
        Me.CheckBoxChèque.Text = "Chèque bancaire"
        Me.CheckBoxChèque.UseVisualStyleBackColor = True
        Me.CheckBoxChèque.Visible = False
        '
        'CheckBoxCarte
        '
        Me.CheckBoxCarte.AutoSize = True
        Me.CheckBoxCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBoxCarte.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxCarte.Location = New System.Drawing.Point(237, 227)
        Me.CheckBoxCarte.Name = "CheckBoxCarte"
        Me.CheckBoxCarte.Size = New System.Drawing.Size(109, 25)
        Me.CheckBoxCarte.TabIndex = 22
        Me.CheckBoxCarte.Text = "Carte credit"
        Me.CheckBoxCarte.UseVisualStyleBackColor = True
        Me.CheckBoxCarte.Visible = False
        '
        'CheckBoxPrélèvement
        '
        Me.CheckBoxPrélèvement.AutoSize = True
        Me.CheckBoxPrélèvement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBoxPrélèvement.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxPrélèvement.Location = New System.Drawing.Point(237, 203)
        Me.CheckBoxPrélèvement.Name = "CheckBoxPrélèvement"
        Me.CheckBoxPrélèvement.Size = New System.Drawing.Size(208, 25)
        Me.CheckBoxPrélèvement.TabIndex = 21
        Me.CheckBoxPrélèvement.Text = "Prélèvement automatique"
        Me.CheckBoxPrélèvement.UseVisualStyleBackColor = True
        Me.CheckBoxPrélèvement.Visible = False
        '
        'LabelFacture
        '
        Me.LabelFacture.AutoSize = True
        Me.LabelFacture.ForeColor = System.Drawing.Color.Red
        Me.LabelFacture.Location = New System.Drawing.Point(0, 73)
        Me.LabelFacture.Name = "LabelFacture"
        Me.LabelFacture.Size = New System.Drawing.Size(805, 30)
        Me.LabelFacture.TabIndex = 17
        Me.LabelFacture.Text = "Nous sommes désolé, cette option sera développée dans la prochaine version."
        '
        'TextBoxNSuccursale
        '
        Me.TextBoxNSuccursale.Location = New System.Drawing.Point(641, 294)
        Me.TextBoxNSuccursale.Name = "TextBoxNSuccursale"
        Me.TextBoxNSuccursale.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNSuccursale.TabIndex = 15
        Me.TextBoxNSuccursale.Visible = False
        '
        'TextBoxNInstitution
        '
        Me.TextBoxNInstitution.Location = New System.Drawing.Point(641, 337)
        Me.TextBoxNInstitution.Name = "TextBoxNInstitution"
        Me.TextBoxNInstitution.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNInstitution.TabIndex = 15
        Me.TextBoxNInstitution.Visible = False
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(641, 227)
        Me.TextBoxNIP.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxNIP.TabIndex = 12
        Me.TextBoxNIP.Visible = False
        '
        'LabelNIP
        '
        Me.LabelNIP.AutoSize = True
        Me.LabelNIP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNIP.Location = New System.Drawing.Point(550, 237)
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
        Me.LabelNumeroCompte.Location = New System.Drawing.Point(480, 195)
        Me.LabelNumeroCompte.Name = "LabelNumeroCompte"
        Me.LabelNumeroCompte.Size = New System.Drawing.Size(145, 21)
        Me.LabelNumeroCompte.TabIndex = 8
        Me.LabelNumeroCompte.Text = "Numéro de compte"
        Me.LabelNumeroCompte.Visible = False
        '
        'GroupBoxPrélèvement
        '
        Me.GroupBoxPrélèvement.Location = New System.Drawing.Point(467, 175)
        Me.GroupBoxPrélèvement.Name = "GroupBoxPrélèvement"
        Me.GroupBoxPrélèvement.Size = New System.Drawing.Size(290, 101)
        Me.GroupBoxPrélèvement.TabIndex = 18
        Me.GroupBoxPrélèvement.TabStop = False
        Me.GroupBoxPrélèvement.Visible = False
        '
        'GroupBoxChèque
        '
        Me.GroupBoxChèque.Location = New System.Drawing.Point(467, 294)
        Me.GroupBoxChèque.Name = "GroupBoxChèque"
        Me.GroupBoxChèque.Size = New System.Drawing.Size(290, 136)
        Me.GroupBoxChèque.TabIndex = 19
        Me.GroupBoxChèque.TabStop = False
        Me.GroupBoxChèque.Visible = False
        '
        'GroupBoxCarte
        '
        Me.GroupBoxCarte.Location = New System.Drawing.Point(158, 286)
        Me.GroupBoxCarte.Name = "GroupBoxCarte"
        Me.GroupBoxCarte.Size = New System.Drawing.Size(287, 130)
        Me.GroupBoxCarte.TabIndex = 20
        Me.GroupBoxCarte.TabStop = False
        Me.GroupBoxCarte.Visible = False
        '
        'GroupBoxPayement
        '
        Me.GroupBoxPayement.Location = New System.Drawing.Point(237, 203)
        Me.GroupBoxPayement.Name = "GroupBoxPayement"
        Me.GroupBoxPayement.Size = New System.Drawing.Size(208, 72)
        Me.GroupBoxPayement.TabIndex = 24
        Me.GroupBoxPayement.TabStop = False
        Me.GroupBoxPayement.Visible = False
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
    Friend WithEvents TextBoxNumeroCarte As TextBox
    Friend WithEvents TextBoxDateEx As TextBox
    Friend WithEvents LabelNumeroCarte As Label
    Friend WithEvents LabelDateEx As Label
    Friend WithEvents TextBoxCVV As TextBox
    Friend WithEvents LabelCvv As Label
    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents LabelFacture As Label
    Friend WithEvents TextBoxNSuccursale As TextBox
    Friend WithEvents TextBoxNInstitution As TextBox
    Friend WithEvents TextBoxNCompte As TextBox
    Friend WithEvents TextBoxNIP As TextBox
    Friend WithEvents LabelSuccursale As Label
    Friend WithEvents LabelNIP As Label
    Friend WithEvents LabelInstitution As Label
    Friend WithEvents LabelComptec As Label
    Friend WithEvents LabelNumeroCompte As Label
    Friend WithEvents GroupBoxPrélèvement As GroupBox
    Friend WithEvents GroupBoxChèque As GroupBox
    Friend WithEvents GroupBoxCarte As GroupBox
    Friend WithEvents CheckBoxChèque As CheckBox
    Friend WithEvents CheckBoxCarte As CheckBox
    Friend WithEvents CheckBoxPrélèvement As CheckBox
    Friend WithEvents GroupBoxPayement As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxNComptec As TextBox
End Class
