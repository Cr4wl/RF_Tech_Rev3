<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BottomMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Settings = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.Button()
        Me.Help = New System.Windows.Forms.Button()
        Me.Specifications = New System.Windows.Forms.Button()
        Me.PoweredByiSERT = New System.Windows.Forms.PictureBox()
        CType(Me.PoweredByiSERT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Settings
        '
        Me.Settings.Location = New System.Drawing.Point(24, 24)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(75, 23)
        Me.Settings.TabIndex = 0
        Me.Settings.Text = "Button1"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.Location = New System.Drawing.Point(152, 24)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(75, 23)
        Me.About.TabIndex = 1
        Me.About.Text = "Button2"
        Me.About.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(360, 24)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(75, 23)
        Me.Help.TabIndex = 2
        Me.Help.Text = "Button3"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Specifications
        '
        Me.Specifications.Location = New System.Drawing.Point(488, 24)
        Me.Specifications.Name = "Specifications"
        Me.Specifications.Size = New System.Drawing.Size(75, 23)
        Me.Specifications.TabIndex = 3
        Me.Specifications.Text = "Button4"
        Me.Specifications.UseVisualStyleBackColor = True
        '
        'PoweredByiSERT
        '
        Me.PoweredByiSERT.Location = New System.Drawing.Point(240, 80)
        Me.PoweredByiSERT.Name = "PoweredByiSERT"
        Me.PoweredByiSERT.Size = New System.Drawing.Size(100, 50)
        Me.PoweredByiSERT.TabIndex = 4
        Me.PoweredByiSERT.TabStop = False
        '
        'BottomMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PoweredByiSERT)
        Me.Controls.Add(Me.Specifications)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.Settings)
        Me.Name = "BottomMenu"
        Me.Size = New System.Drawing.Size(616, 161)
        CType(Me.PoweredByiSERT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Settings As Button
    Friend WithEvents About As Button
    Friend WithEvents Help As Button
    Friend WithEvents Specifications As Button
    Friend WithEvents PoweredByiSERT As PictureBox
End Class
