<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Créer = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Rechercher = New System.Windows.Forms.Button()
        Me.NomClient = New System.Windows.Forms.TextBox()
        Me.PrénomClient = New System.Windows.Forms.TextBox()
        Me.Adresse = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.N_apt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1030, 188)
        Me.DataGridView1.TabIndex = 0
        '
        'Créer
        '
        Me.Créer.Location = New System.Drawing.Point(13, 485)
        Me.Créer.Name = "Créer"
        Me.Créer.Size = New System.Drawing.Size(94, 29)
        Me.Créer.TabIndex = 1
        Me.Créer.Text = "Créer"
        Me.Créer.UseVisualStyleBackColor = True
        '
        'Modifier
        '
        Me.Modifier.Location = New System.Drawing.Point(113, 485)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(94, 29)
        Me.Modifier.TabIndex = 2
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = True
        '
        'Rechercher
        '
        Me.Rechercher.Location = New System.Drawing.Point(213, 485)
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(94, 29)
        Me.Rechercher.TabIndex = 3
        Me.Rechercher.Text = "Rechercher"
        Me.Rechercher.UseVisualStyleBackColor = True
        '
        'NomClient
        '
        Me.NomClient.Location = New System.Drawing.Point(213, 276)
        Me.NomClient.Name = "NomClient"
        Me.NomClient.Size = New System.Drawing.Size(271, 27)
        Me.NomClient.TabIndex = 4
        '
        'PrénomClient
        '
        Me.PrénomClient.Location = New System.Drawing.Point(213, 309)
        Me.PrénomClient.Name = "PrénomClient"
        Me.PrénomClient.Size = New System.Drawing.Size(271, 27)
        Me.PrénomClient.TabIndex = 5
        '
        'Adresse
        '
        Me.Adresse.Location = New System.Drawing.Point(265, 342)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(219, 27)
        Me.Adresse.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(213, 375)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(219, 27)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(213, 408)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(219, 27)
        Me.TextBox5.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Label5"
        '
        'N_apt
        '
        Me.N_apt.Location = New System.Drawing.Point(213, 342)
        Me.N_apt.Name = "N_apt"
        Me.N_apt.Size = New System.Drawing.Size(34, 27)
        Me.N_apt.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "-"
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 566)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.N_apt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Adresse)
        Me.Controls.Add(Me.PrénomClient)
        Me.Controls.Add(Me.NomClient)
        Me.Controls.Add(Me.Rechercher)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Créer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Clients"
        Me.Text = "Clients"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Créer As Button
    Friend WithEvents Modifier As Button
    Friend WithEvents Rechercher As Button
    Friend WithEvents NomClient As TextBox
    Friend WithEvents PrénomClient As TextBox
    Friend WithEvents Adresse As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents N_apt As TextBox
    Friend WithEvents Label6 As Label
End Class
