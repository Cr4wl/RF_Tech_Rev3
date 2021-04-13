<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecMenu
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
        Me.NewTest = New System.Windows.Forms.Button()
        Me.AddTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewTest
        '
        Me.NewTest.Location = New System.Drawing.Point(8, 8)
        Me.NewTest.Name = "NewTest"
        Me.NewTest.Size = New System.Drawing.Size(75, 23)
        Me.NewTest.TabIndex = 0
        Me.NewTest.Text = "Button1"
        Me.NewTest.UseVisualStyleBackColor = True
        '
        'AddTest
        '
        Me.AddTest.Location = New System.Drawing.Point(8, 32)
        Me.AddTest.Name = "AddTest"
        Me.AddTest.Size = New System.Drawing.Size(75, 23)
        Me.AddTest.TabIndex = 1
        Me.AddTest.Text = "Button2"
        Me.AddTest.UseVisualStyleBackColor = True
        '
        'SpecMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddTest)
        Me.Controls.Add(Me.NewTest)
        Me.Name = "SpecMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewTest As Button
    Friend WithEvents AddTest As Button
End Class
