<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopMenu
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
        Me.Button_Form_Minimize = New System.Windows.Forms.Button()
        Me.Button_Form_Resize = New System.Windows.Forms.Button()
        Me.Button_Form_Close = New System.Windows.Forms.Button()
        Me.Button_Form_GoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Form_Minimize
        '
        Me.Button_Form_Minimize.Location = New System.Drawing.Point(160, 8)
        Me.Button_Form_Minimize.Name = "Button_Form_Minimize"
        Me.Button_Form_Minimize.Size = New System.Drawing.Size(75, 23)
        Me.Button_Form_Minimize.TabIndex = 0
        Me.Button_Form_Minimize.UseVisualStyleBackColor = True
        '
        'Button_Form_Resize
        '
        Me.Button_Form_Resize.Location = New System.Drawing.Point(248, 8)
        Me.Button_Form_Resize.Name = "Button_Form_Resize"
        Me.Button_Form_Resize.Size = New System.Drawing.Size(75, 23)
        Me.Button_Form_Resize.TabIndex = 1
        Me.Button_Form_Resize.UseVisualStyleBackColor = True
        '
        'Button_Form_Close
        '
        Me.Button_Form_Close.Location = New System.Drawing.Point(336, 8)
        Me.Button_Form_Close.Name = "Button_Form_Close"
        Me.Button_Form_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Form_Close.TabIndex = 2
        Me.Button_Form_Close.UseVisualStyleBackColor = True
        '
        'Button_Form_GoBack
        '
        Me.Button_Form_GoBack.Location = New System.Drawing.Point(8, 8)
        Me.Button_Form_GoBack.Name = "Button_Form_GoBack"
        Me.Button_Form_GoBack.Size = New System.Drawing.Size(75, 23)
        Me.Button_Form_GoBack.TabIndex = 3
        Me.Button_Form_GoBack.UseVisualStyleBackColor = True
        '
        'TopMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Form_GoBack)
        Me.Controls.Add(Me.Button_Form_Close)
        Me.Controls.Add(Me.Button_Form_Resize)
        Me.Controls.Add(Me.Button_Form_Minimize)
        Me.Name = "TopMenu"
        Me.Size = New System.Drawing.Size(441, 150)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Form_Minimize As Button
    Friend WithEvents Button_Form_Resize As Button
    Friend WithEvents Button_Form_Close As Button
    Friend WithEvents Button_Form_GoBack As Button
End Class
