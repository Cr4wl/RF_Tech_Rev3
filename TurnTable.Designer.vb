<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TurnTable
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Turn_Slow_CC = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Turn_360_CC = New System.Windows.Forms.Button()
        Me.Turn_Fast_CC = New System.Windows.Forms.Button()
        Me.Turn_FixedStep_CC = New System.Windows.Forms.Button()
        Me.Turn_Slow_CW = New System.Windows.Forms.Button()
        Me.Turn_Fast_CW = New System.Windows.Forms.Button()
        Me.Turn_FixedStep_CW = New System.Windows.Forms.Button()
        Me.Turn_360_CW = New System.Windows.Forms.Button()
        Me.Reset_Image_TurnTable = New System.Windows.Forms.Button()
        Me.Mark_Image_TurnTable = New System.Windows.Forms.Button()
        Me.Text_TurnTable = New System.Windows.Forms.Label()
        Me.Image_TurnTable_Dial = New System.Windows.Forms.Panel()
        Me.Image_TurnTable_Dial.SuspendLayout()
        Me.SuspendLayout()
        '
        'Turn_Slow_CC
        '
        Me.Turn_Slow_CC.Location = New System.Drawing.Point(24, 168)
        Me.Turn_Slow_CC.Name = "Turn_Slow_CC"
        Me.Turn_Slow_CC.Size = New System.Drawing.Size(75, 23)
        Me.Turn_Slow_CC.TabIndex = 0
        Me.Turn_Slow_CC.Text = "Button1"
        Me.Turn_Slow_CC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Turn_360_CC
        '
        Me.Turn_360_CC.Location = New System.Drawing.Point(128, 240)
        Me.Turn_360_CC.Name = "Turn_360_CC"
        Me.Turn_360_CC.Size = New System.Drawing.Size(75, 23)
        Me.Turn_360_CC.TabIndex = 4
        Me.Turn_360_CC.Text = "Button1"
        Me.Turn_360_CC.UseVisualStyleBackColor = True
        '
        'Turn_Fast_CC
        '
        Me.Turn_Fast_CC.Location = New System.Drawing.Point(24, 240)
        Me.Turn_Fast_CC.Name = "Turn_Fast_CC"
        Me.Turn_Fast_CC.Size = New System.Drawing.Size(75, 23)
        Me.Turn_Fast_CC.TabIndex = 5
        Me.Turn_Fast_CC.Text = "Button1"
        Me.Turn_Fast_CC.UseVisualStyleBackColor = True
        '
        'Turn_FixedStep_CC
        '
        Me.Turn_FixedStep_CC.Location = New System.Drawing.Point(24, 312)
        Me.Turn_FixedStep_CC.Name = "Turn_FixedStep_CC"
        Me.Turn_FixedStep_CC.Size = New System.Drawing.Size(75, 23)
        Me.Turn_FixedStep_CC.TabIndex = 6
        Me.Turn_FixedStep_CC.Text = "Button2"
        Me.Turn_FixedStep_CC.UseVisualStyleBackColor = True
        '
        'Turn_Slow_CW
        '
        Me.Turn_Slow_CW.Location = New System.Drawing.Point(536, 168)
        Me.Turn_Slow_CW.Name = "Turn_Slow_CW"
        Me.Turn_Slow_CW.Size = New System.Drawing.Size(75, 23)
        Me.Turn_Slow_CW.TabIndex = 7
        Me.Turn_Slow_CW.Text = "Button3"
        Me.Turn_Slow_CW.UseVisualStyleBackColor = True
        '
        'Turn_Fast_CW
        '
        Me.Turn_Fast_CW.Location = New System.Drawing.Point(536, 240)
        Me.Turn_Fast_CW.Name = "Turn_Fast_CW"
        Me.Turn_Fast_CW.Size = New System.Drawing.Size(75, 23)
        Me.Turn_Fast_CW.TabIndex = 8
        Me.Turn_Fast_CW.Text = "Button4"
        Me.Turn_Fast_CW.UseVisualStyleBackColor = True
        '
        'Turn_FixedStep_CW
        '
        Me.Turn_FixedStep_CW.Location = New System.Drawing.Point(536, 312)
        Me.Turn_FixedStep_CW.Name = "Turn_FixedStep_CW"
        Me.Turn_FixedStep_CW.Size = New System.Drawing.Size(75, 23)
        Me.Turn_FixedStep_CW.TabIndex = 9
        Me.Turn_FixedStep_CW.Text = "Button5"
        Me.Turn_FixedStep_CW.UseVisualStyleBackColor = True
        '
        'Turn_360_CW
        '
        Me.Turn_360_CW.Location = New System.Drawing.Point(432, 240)
        Me.Turn_360_CW.Name = "Turn_360_CW"
        Me.Turn_360_CW.Size = New System.Drawing.Size(75, 23)
        Me.Turn_360_CW.TabIndex = 10
        Me.Turn_360_CW.Text = "Button6"
        Me.Turn_360_CW.UseVisualStyleBackColor = True
        '
        'Reset_Image_TurnTable
        '
        Me.Reset_Image_TurnTable.Location = New System.Drawing.Point(0, 16)
        Me.Reset_Image_TurnTable.Name = "Reset_Image_TurnTable"
        Me.Reset_Image_TurnTable.Size = New System.Drawing.Size(75, 23)
        Me.Reset_Image_TurnTable.TabIndex = 3
        Me.Reset_Image_TurnTable.Text = "Button7"
        Me.Reset_Image_TurnTable.UseVisualStyleBackColor = True
        '
        'Mark_Image_TurnTable
        '
        Me.Mark_Image_TurnTable.Location = New System.Drawing.Point(0, 40)
        Me.Mark_Image_TurnTable.Name = "Mark_Image_TurnTable"
        Me.Mark_Image_TurnTable.Size = New System.Drawing.Size(75, 23)
        Me.Mark_Image_TurnTable.TabIndex = 11
        Me.Mark_Image_TurnTable.Text = "Button8"
        Me.Mark_Image_TurnTable.UseVisualStyleBackColor = True
        '
        'Text_TurnTable
        '
        Me.Text_TurnTable.AutoSize = True
        Me.Text_TurnTable.Location = New System.Drawing.Point(80, 72)
        Me.Text_TurnTable.Name = "Text_TurnTable"
        Me.Text_TurnTable.Size = New System.Drawing.Size(71, 13)
        Me.Text_TurnTable.TabIndex = 2
        Me.Text_TurnTable.Text = "turn table text"
        '
        'Image_TurnTable_Dial
        '
        Me.Image_TurnTable_Dial.Controls.Add(Me.Text_TurnTable)
        Me.Image_TurnTable_Dial.Location = New System.Drawing.Point(216, 168)
        Me.Image_TurnTable_Dial.Name = "Image_TurnTable_Dial"
        Me.Image_TurnTable_Dial.Size = New System.Drawing.Size(200, 164)
        Me.Image_TurnTable_Dial.TabIndex = 1
        '
        'TurnTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Mark_Image_TurnTable)
        Me.Controls.Add(Me.Reset_Image_TurnTable)
        Me.Controls.Add(Me.Turn_360_CW)
        Me.Controls.Add(Me.Turn_FixedStep_CW)
        Me.Controls.Add(Me.Turn_Fast_CW)
        Me.Controls.Add(Me.Turn_Slow_CW)
        Me.Controls.Add(Me.Turn_FixedStep_CC)
        Me.Controls.Add(Me.Turn_Fast_CC)
        Me.Controls.Add(Me.Turn_360_CC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Image_TurnTable_Dial)
        Me.Controls.Add(Me.Turn_Slow_CC)
        Me.Name = "TurnTable"
        Me.Size = New System.Drawing.Size(646, 483)
        Me.Image_TurnTable_Dial.ResumeLayout(False)
        Me.Image_TurnTable_Dial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Turn_Slow_CC As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Turn_360_CC As Button
    Friend WithEvents Turn_Fast_CC As Button
    Friend WithEvents Turn_FixedStep_CC As Button
    Friend WithEvents Turn_Slow_CW As Button
    Friend WithEvents Turn_Fast_CW As Button
    Friend WithEvents Turn_FixedStep_CW As Button
    Friend WithEvents Turn_360_CW As Button
    Friend WithEvents Reset_Image_TurnTable As Button
    Friend WithEvents Mark_Image_TurnTable As Button
    Friend WithEvents Text_TurnTable As Label
    Friend WithEvents Image_TurnTable_Dial As Panel
End Class
