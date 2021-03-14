<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
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
        Me.lstBoxService = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxService
        '
        Me.lstBoxService.FormattingEnabled = True
        Me.lstBoxService.ItemHeight = 15
        Me.lstBoxService.Items.AddRange(New Object() {"Programmation Page Web Standars", "Formation Personnel", "Conception des pages Web Supplementaires", "Installation des equipements de logiciels"})
        Me.lstBoxService.Location = New System.Drawing.Point(12, 12)
        Me.lstBoxService.Name = "lstBoxService"
        Me.lstBoxService.Size = New System.Drawing.Size(471, 259)
        Me.lstBoxService.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 346)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstBoxService)
        Me.Name = "Services"
        Me.Text = "Services"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBoxService As ListBox
    Friend WithEvents Button1 As Button
End Class
