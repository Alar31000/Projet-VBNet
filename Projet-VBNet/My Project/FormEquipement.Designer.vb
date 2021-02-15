<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEquipement
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelMicroOrdi = New System.Windows.Forms.Label()
        Me.LabelModem = New System.Windows.Forms.Label()
        Me.LabelInternet = New System.Windows.Forms.Label()
        Me.CheckBoxMicroOrdi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxModem = New System.Windows.Forms.CheckBox()
        Me.CheckBoxInternet = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLouer = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ButtonFacture = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMicroOrdi
        '
        Me.LabelMicroOrdi.AutoSize = True
        Me.LabelMicroOrdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMicroOrdi.Location = New System.Drawing.Point(193, 31)
        Me.LabelMicroOrdi.Name = "LabelMicroOrdi"
        Me.LabelMicroOrdi.Size = New System.Drawing.Size(129, 21)
        Me.LabelMicroOrdi.TabIndex = 3
        Me.LabelMicroOrdi.Text = "Micro-ordinateur"
        '
        'LabelModem
        '
        Me.LabelModem.AutoSize = True
        Me.LabelModem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelModem.Location = New System.Drawing.Point(193, 70)
        Me.LabelModem.Name = "LabelModem"
        Me.LabelModem.Size = New System.Drawing.Size(64, 21)
        Me.LabelModem.TabIndex = 4
        Me.LabelModem.Text = "Modem"
        '
        'LabelInternet
        '
        Me.LabelInternet.AutoSize = True
        Me.LabelInternet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInternet.Location = New System.Drawing.Point(193, 106)
        Me.LabelInternet.Name = "LabelInternet"
        Me.LabelInternet.Size = New System.Drawing.Size(64, 21)
        Me.LabelInternet.TabIndex = 6
        Me.LabelInternet.Text = "Internet"
        '
        'CheckBoxMicroOrdi
        '
        Me.CheckBoxMicroOrdi.AutoSize = True
        Me.CheckBoxMicroOrdi.Location = New System.Drawing.Point(335, 36)
        Me.CheckBoxMicroOrdi.Name = "CheckBoxMicroOrdi"
        Me.CheckBoxMicroOrdi.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMicroOrdi.TabIndex = 8
        Me.CheckBoxMicroOrdi.UseVisualStyleBackColor = True
        '
        'CheckBoxModem
        '
        Me.CheckBoxModem.AutoSize = True
        Me.CheckBoxModem.Location = New System.Drawing.Point(335, 74)
        Me.CheckBoxModem.Name = "CheckBoxModem"
        Me.CheckBoxModem.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxModem.TabIndex = 9
        Me.CheckBoxModem.UseVisualStyleBackColor = True
        '
        'CheckBoxInternet
        '
        Me.CheckBoxInternet.AutoSize = True
        Me.CheckBoxInternet.Location = New System.Drawing.Point(335, 111)
        Me.CheckBoxInternet.Name = "CheckBoxInternet"
        Me.CheckBoxInternet.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxInternet.TabIndex = 10
        Me.CheckBoxInternet.UseVisualStyleBackColor = True
        '
        'CheckBoxLouer
        '
        Me.CheckBoxLouer.AutoSize = True
        Me.CheckBoxLouer.Location = New System.Drawing.Point(335, 258)
        Me.CheckBoxLouer.Name = "CheckBoxLouer"
        Me.CheckBoxLouer.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxLouer.TabIndex = 11
        Me.CheckBoxLouer.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(493, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 33)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(493, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 33)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(493, 111)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 33)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(493, 200)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 33)
        Me.TextBox4.TabIndex = 15
        '
        'ButtonFacture
        '
        Me.ButtonFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonFacture.Location = New System.Drawing.Point(193, 336)
        Me.ButtonFacture.Name = "ButtonFacture"
        Me.ButtonFacture.Size = New System.Drawing.Size(79, 31)
        Me.ButtonFacture.TabIndex = 16
        Me.ButtonFacture.Text = "Facture"
        Me.ButtonFacture.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBoxLouer)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxInternet)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxMicroOrdi)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxModem)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 447)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipement"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(388, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 33)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(190, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Louer"
        '
        'FormEquipement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonFacture)
        Me.Controls.Add(Me.LabelInternet)
        Me.Controls.Add(Me.LabelModem)
        Me.Controls.Add(Me.LabelMicroOrdi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormEquipement"
        Me.Text = "FormEquipement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMicroOrdi As Label
    Friend WithEvents LabelModem As Label
    Friend WithEvents LabelInternet As Label
    Friend WithEvents CheckBoxMicroOrdi As CheckBox
    Friend WithEvents CheckBoxModem As CheckBox
    Friend WithEvents CheckBoxInternet As CheckBox
    Friend WithEvents CheckBoxLouer As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ButtonFacture As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
