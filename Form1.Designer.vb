<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_TurnTable = New System.Windows.Forms.Button()
        Me.Button_SpectrumAnalizer = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Serial_TurnTable = New System.IO.Ports.SerialPort(Me.components)
        Me.TurnTable21 = New RF_Tech_Rev3.TurnTable2()
        Me.Settings1 = New RF_Tech_Rev3.Settings()
        Me.BottomMenu1 = New RF_Tech_Rev3.BottomMenu()
        Me.TurnTable1 = New RF_Tech_Rev3.TurnTable()
        Me.TopMenu1 = New RF_Tech_Rev3.TopMenu()
        Me.SuspendLayout()
        '
        'Button_TurnTable
        '
        Me.Button_TurnTable.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_TurnTable.FlatAppearance.BorderSize = 0
        Me.Button_TurnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.Button_TurnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button_TurnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_TurnTable.Location = New System.Drawing.Point(96, 128)
        Me.Button_TurnTable.Name = "Button_TurnTable"
        Me.Button_TurnTable.Size = New System.Drawing.Size(75, 25)
        Me.Button_TurnTable.TabIndex = 0
        Me.Button_TurnTable.Text = "Turntable"
        Me.Button_TurnTable.UseVisualStyleBackColor = True
        '
        'Button_SpectrumAnalizer
        '
        Me.Button_SpectrumAnalizer.Location = New System.Drawing.Point(184, 128)
        Me.Button_SpectrumAnalizer.Name = "Button_SpectrumAnalizer"
        Me.Button_SpectrumAnalizer.Size = New System.Drawing.Size(75, 23)
        Me.Button_SpectrumAnalizer.TabIndex = 1
        Me.Button_SpectrumAnalizer.Text = "Spectrum Analyzer"
        Me.Button_SpectrumAnalizer.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'TurnTable21
        '
        Me.TurnTable21.Location = New System.Drawing.Point(200, 168)
        Me.TurnTable21.Name = "TurnTable21"
        Me.TurnTable21.Size = New System.Drawing.Size(171, 120)
        Me.TurnTable21.TabIndex = 7
        '
        'Settings1
        '
        Me.Settings1.Location = New System.Drawing.Point(600, 80)
        Me.Settings1.Name = "Settings1"
        Me.Settings1.Size = New System.Drawing.Size(152, 104)
        Me.Settings1.TabIndex = 6
        '
        'BottomMenu1
        '
        Me.BottomMenu1.Location = New System.Drawing.Point(232, 320)
        Me.BottomMenu1.Name = "BottomMenu1"
        Me.BottomMenu1.Size = New System.Drawing.Size(144, 88)
        Me.BottomMenu1.TabIndex = 5
        '
        'TurnTable1
        '
        Me.TurnTable1.Location = New System.Drawing.Point(40, 184)
        Me.TurnTable1.Name = "TurnTable1"
        Me.TurnTable1.Size = New System.Drawing.Size(136, 104)
        Me.TurnTable1.TabIndex = 4
        '
        'TopMenu1
        '
        Me.TopMenu1.Location = New System.Drawing.Point(96, 8)
        Me.TopMenu1.Name = "TopMenu1"
        Me.TopMenu1.Size = New System.Drawing.Size(424, 56)
        Me.TopMenu1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TurnTable21)
        Me.Controls.Add(Me.Settings1)
        Me.Controls.Add(Me.BottomMenu1)
        Me.Controls.Add(Me.TurnTable1)
        Me.Controls.Add(Me.TopMenu1)
        Me.Controls.Add(Me.Button_SpectrumAnalizer)
        Me.Controls.Add(Me.Button_TurnTable)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_TurnTable As Button
    Friend WithEvents Button_SpectrumAnalizer As Button
    Friend WithEvents TopMenu1 As TopMenu
    Friend WithEvents TurnTable1 As TurnTable
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BottomMenu1 As BottomMenu
    Friend WithEvents Settings1 As Settings
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TurnTable21 As TurnTable2
    Friend WithEvents Serial_TurnTable As IO.Ports.SerialPort
End Class
