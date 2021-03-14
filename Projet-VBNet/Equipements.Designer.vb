<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipements
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
        Me.ButtonFacture = New System.Windows.Forms.Button()
        Me.LabelInternet = New System.Windows.Forms.Label()
        Me.LabelModem = New System.Windows.Forms.Label()
        Me.LabelMicroOrdi = New System.Windows.Forms.Label()
        Me.GroupBoxEquipement = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMOrdinateurCost = New System.Windows.Forms.Label()
        Me.LabelModemCost = New System.Windows.Forms.Label()
        Me.LabelInternetCost = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.CheckBoxLouer = New System.Windows.Forms.CheckBox()
        Me.TextBoxInternet = New System.Windows.Forms.TextBox()
        Me.TextBoxModem = New System.Windows.Forms.TextBox()
        Me.TextBoxMOrdi = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.GroupBoxEquipement.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonFacture
        '
        Me.ButtonFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonFacture.Location = New System.Drawing.Point(228, 373)
        Me.ButtonFacture.Name = "ButtonFacture"
        Me.ButtonFacture.Size = New System.Drawing.Size(79, 31)
        Me.ButtonFacture.TabIndex = 22
        Me.ButtonFacture.Text = "Facture"
        Me.ButtonFacture.UseVisualStyleBackColor = True
        '
        'LabelInternet
        '
        Me.LabelInternet.AutoSize = True
        Me.LabelInternet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInternet.Location = New System.Drawing.Point(293, 123)
        Me.LabelInternet.Name = "LabelInternet"
        Me.LabelInternet.Size = New System.Drawing.Size(64, 21)
        Me.LabelInternet.TabIndex = 21
        Me.LabelInternet.Text = "Internet"
        '
        'LabelModem
        '
        Me.LabelModem.AutoSize = True
        Me.LabelModem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelModem.Location = New System.Drawing.Point(293, 80)
        Me.LabelModem.Name = "LabelModem"
        Me.LabelModem.Size = New System.Drawing.Size(64, 21)
        Me.LabelModem.TabIndex = 20
        Me.LabelModem.Text = "Modem"
        '
        'LabelMicroOrdi
        '
        Me.LabelMicroOrdi.AutoSize = True
        Me.LabelMicroOrdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMicroOrdi.Location = New System.Drawing.Point(293, 37)
        Me.LabelMicroOrdi.Name = "LabelMicroOrdi"
        Me.LabelMicroOrdi.Size = New System.Drawing.Size(129, 21)
        Me.LabelMicroOrdi.TabIndex = 19
        Me.LabelMicroOrdi.Text = "Micro-ordinateur"
        '
        'GroupBoxEquipement
        '
        Me.GroupBoxEquipement.Controls.Add(Me.Label1)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelMOrdinateurCost)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelModemCost)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelInternetCost)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelTotal)
        Me.GroupBoxEquipement.Controls.Add(Me.ButtonQuitter)
        Me.GroupBoxEquipement.Controls.Add(Me.ButtonFacture)
        Me.GroupBoxEquipement.Controls.Add(Me.CheckBoxLouer)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBoxInternet)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBoxModem)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBoxMOrdi)
        Me.GroupBoxEquipement.Controls.Add(Me.ButtonCalculate)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelInternet)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelModem)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelMicroOrdi)
        Me.GroupBoxEquipement.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxEquipement.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxEquipement.Location = New System.Drawing.Point(2, 4)
        Me.GroupBoxEquipement.Name = "GroupBoxEquipement"
        Me.GroupBoxEquipement.Size = New System.Drawing.Size(798, 445)
        Me.GroupBoxEquipement.TabIndex = 23
        Me.GroupBoxEquipement.TabStop = False
        Me.GroupBoxEquipement.Text = "Equipements"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(425, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Total :"
        '
        'LabelMOrdinateurCost
        '
        Me.LabelMOrdinateurCost.AutoSize = True
        Me.LabelMOrdinateurCost.ForeColor = System.Drawing.Color.Black
        Me.LabelMOrdinateurCost.Location = New System.Drawing.Point(493, 42)
        Me.LabelMOrdinateurCost.Name = "LabelMOrdinateurCost"
        Me.LabelMOrdinateurCost.Size = New System.Drawing.Size(45, 25)
        Me.LabelMOrdinateurCost.TabIndex = 30
        Me.LabelMOrdinateurCost.Text = "500"
        '
        'LabelModemCost
        '
        Me.LabelModemCost.AutoSize = True
        Me.LabelModemCost.ForeColor = System.Drawing.Color.Black
        Me.LabelModemCost.Location = New System.Drawing.Point(493, 85)
        Me.LabelModemCost.Name = "LabelModemCost"
        Me.LabelModemCost.Size = New System.Drawing.Size(34, 25)
        Me.LabelModemCost.TabIndex = 29
        Me.LabelModemCost.Text = "50"
        '
        'LabelInternetCost
        '
        Me.LabelInternetCost.AutoSize = True
        Me.LabelInternetCost.ForeColor = System.Drawing.Color.Black
        Me.LabelInternetCost.Location = New System.Drawing.Point(493, 123)
        Me.LabelInternetCost.Name = "LabelInternetCost"
        Me.LabelInternetCost.Size = New System.Drawing.Size(50, 25)
        Me.LabelInternetCost.TabIndex = 28
        Me.LabelInternetCost.Text = "100 "
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.ForeColor = System.Drawing.Color.Black
        Me.LabelTotal.Location = New System.Drawing.Point(493, 208)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(61, 25)
        Me.LabelTotal.TabIndex = 27
        Me.LabelTotal.Text = "$0.00"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(493, 374)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(86, 30)
        Me.ButtonQuitter.TabIndex = 26
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'CheckBoxLouer
        '
        Me.CheckBoxLouer.AutoSize = True
        Me.CheckBoxLouer.Location = New System.Drawing.Point(228, 262)
        Me.CheckBoxLouer.Name = "CheckBoxLouer"
        Me.CheckBoxLouer.Size = New System.Drawing.Size(81, 29)
        Me.CheckBoxLouer.TabIndex = 25
        Me.CheckBoxLouer.Text = "Louer"
        Me.CheckBoxLouer.UseVisualStyleBackColor = True
        '
        'TextBoxInternet
        '
        Me.TextBoxInternet.Location = New System.Drawing.Point(228, 123)
        Me.TextBoxInternet.Name = "TextBoxInternet"
        Me.TextBoxInternet.Size = New System.Drawing.Size(41, 33)
        Me.TextBoxInternet.TabIndex = 24
        Me.TextBoxInternet.Text = "0"
        Me.TextBoxInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxModem
        '
        Me.TextBoxModem.Location = New System.Drawing.Point(229, 74)
        Me.TextBoxModem.Name = "TextBoxModem"
        Me.TextBoxModem.Size = New System.Drawing.Size(40, 33)
        Me.TextBoxModem.TabIndex = 23
        Me.TextBoxModem.Text = "0"
        Me.TextBoxModem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMOrdi
        '
        Me.TextBoxMOrdi.Location = New System.Drawing.Point(229, 25)
        Me.TextBoxMOrdi.Name = "TextBoxMOrdi"
        Me.TextBoxMOrdi.Size = New System.Drawing.Size(41, 33)
        Me.TextBoxMOrdi.TabIndex = 22
        Me.TextBoxMOrdi.Text = "0"
        Me.TextBoxMOrdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCalculate.ForeColor = System.Drawing.Color.Black
        Me.ButtonCalculate.Location = New System.Drawing.Point(493, 262)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(86, 33)
        Me.ButtonCalculate.TabIndex = 16
        Me.ButtonCalculate.Text = "Calculer"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'Equipements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBoxEquipement)
        Me.Name = "Equipements"
        Me.Text = "Equipements"
        Me.GroupBoxEquipement.ResumeLayout(False)
        Me.GroupBoxEquipement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFacture As Button
    Friend WithEvents LabelInternet As Label
    Friend WithEvents LabelModem As Label
    Friend WithEvents LabelMicroOrdi As Label
    Friend WithEvents GroupBoxEquipement As GroupBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents CheckBoxLouer As CheckBox
    Friend WithEvents TextBoxInternet As TextBox
    Friend WithEvents TextBoxModem As TextBox
    Friend WithEvents TextBoxMOrdi As TextBox
    Friend WithEvents LabelMOrdinateurCost As Label
    Friend WithEvents LabelModemCost As Label
    Friend WithEvents LabelInternetCost As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label1 As Label
End Class
