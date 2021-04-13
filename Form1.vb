Public Class Form1
    ' Sizes
    Dim Size_TopMenu_Button As New Size(40, 40)

    ' Navigation Buttons
    Dim Colour_Navigation_Button_Normal = Color.FromArgb(36, 163, 216)
    Dim Colour_Navigation_Button_Hover = Color.FromArgb(66, 193, 246)
    Dim Colour_Navigation_Button_Pressed = Color.FromArgb(27, 116, 147)

    ' Top and Bottom Menu Buttons
    Public Colour_Menu_Button_Normal = Color.Transparent
    Public Colour_Menu_Button_Hover = Color.FromArgb(60, 67, 80)
    Public Colour_Menu_Button_Pressed = Color.FromArgb(70, 77, 90)

    ' Turn table buttons
    Dim Colour_TurnTable_Button_Normal = Color.Transparent
    Dim Colour_TurnTable_Button_Hover = Color.FromArgb(36, 163, 216)
    Dim Colour_TurnTable_Button_Pressed = Color.FromArgb(16, 143, 196)

    ' Turn table variables
    Dim serial_string As String
    Public serial_substr As String
    Public degrees As Single = 0
    Public degdelta As Single = 0
    Dim check As String = ""
    Dim check_count As Single = 0

    Dim dist As Single = 0
    Dim steps As Single = 0
    Dim step_inc As Single = 0
    Public rotate As Single = 0
    'Dim read As Single

    ' Top and Bottom Menu Background
    Public Colour_Menu_Background = Color.FromArgb(50, 57, 70)

    ' Boolean declarations
    Dim Button_SpectrumAnalyzer_MouseIn As Boolean = False
    Dim Button_TurnTable_MouseIn As Boolean = False

    ' Fonts
    Dim Font_Navigation_Button As FontFamily = New FontFamily("Ubuntu")
    Dim Font_TurnTable_Colour = Color.FromArgb(36, 163, 216)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open Serial Port to Turn Table
        Serial_TurnTable.PortName = "COM" + Settings1.Set_SerialPort.Text
        Serial_TurnTable.BaudRate = "115200"

        ' Turn Table default values
        Serial_TurnTable.Open()
        Serial_TurnTable.Write(Chr(2) + "TT:SET:ma=200" + Chr(13))
        Serial_TurnTable.Close()

        ''''''''''''
        'TurnTable21.Text_Turned.Visible = False

        ' Sizes
        Dim Size_TopMenu_Button As New Size(40, 40)

        ' Form size and style declaration
        Me.MinimumSize = New Size(800, 600)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.White

        ' Button style and colour declaration
        ' Turn Table
        Button_TurnTable.FlatStyle = FlatStyle.Flat
        Button_TurnTable.BackColor = Color.White 'Colour_Navigation_Button_Normal
        Button_TurnTable.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Navigation Buttons\TurnTable_Normal.png")
        Button_TurnTable.BackgroundImageLayout = ImageLayout.Zoom
        Button_TurnTable.FlatAppearance.BorderSize = 0
        Button_TurnTable.FlatAppearance.MouseOverBackColor = Colour_Navigation_Button_Hover
        Button_TurnTable.FlatAppearance.MouseDownBackColor = Colour_Navigation_Button_Pressed
        Button_TurnTable.Text = "Turn Table"
        Button_TurnTable.Font = New Font(Font_Navigation_Button, 25, FontStyle.Regular)
        Button_TurnTable.ForeColor = Colour_Navigation_Button_Normal 'Color.WhiteSmoke
        Button_TurnTable.TextAlign = ContentAlignment.BottomCenter

        ' Spectrum Analyzer
        Button_SpectrumAnalizer.FlatStyle = FlatStyle.Flat
        Button_SpectrumAnalizer.BackColor = Color.White 'Colour_Navigation_Button_Normal
        Button_SpectrumAnalizer.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Navigation Buttons\Spectrum_Normal.png")
        Button_SpectrumAnalizer.BackgroundImageLayout = ImageLayout.Zoom
        Button_SpectrumAnalizer.FlatAppearance.BorderSize = 0
        Button_SpectrumAnalizer.FlatAppearance.MouseOverBackColor = Colour_Navigation_Button_Normal
        Button_SpectrumAnalizer.FlatAppearance.MouseDownBackColor = Colour_Navigation_Button_Pressed
        Button_SpectrumAnalizer.Text = "Spectrum Analyzer"
        Button_SpectrumAnalizer.Font = New Font(Font_Navigation_Button, 25, FontStyle.Regular)
        Button_SpectrumAnalizer.ForeColor = Colour_Navigation_Button_Normal 'Color.WhiteSmoke
        Button_SpectrumAnalizer.TextAlign = ContentAlignment.BottomCenter

        ' Top Menu size and style declaration
        TopMenu1.Size = New Size(Me.Width, 40)
        TopMenu1.BackColor = Colour_Menu_Background
        TopMenu1.Location = New Point(0, 0)

        ' Top Menu Buttons sizes and styles declaration
        ' Minimize
        TopMenu1.Button_Form_Minimize.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Minimize_Resize.png")
        TopMenu1.Button_Form_Minimize.BackgroundImageLayout = ImageLayout.Center
        TopMenu1.Button_Form_Minimize.Size = Size_TopMenu_Button
        TopMenu1.Button_Form_Minimize.Location = New Point(TopMenu1.Width - Size_TopMenu_Button.Width * 3, 0)
        TopMenu1.Button_Form_Minimize.FlatStyle = FlatStyle.Flat
        TopMenu1.Button_Form_Minimize.FlatAppearance.BorderSize = 0
        TopMenu1.Button_Form_Minimize.BackColor = Colour_Menu_Button_Normal
        TopMenu1.Button_Form_Minimize.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        TopMenu1.Button_Form_Minimize.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' Resize
        TopMenu1.Button_Form_Resize.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Resize_Resize.png")
        TopMenu1.Button_Form_Resize.BackgroundImageLayout = ImageLayout.Center
        TopMenu1.Button_Form_Resize.Size = Size_TopMenu_Button
        TopMenu1.Button_Form_Resize.Location = New Point(TopMenu1.Width - Size_TopMenu_Button.Width * 2, 0)
        TopMenu1.Button_Form_Resize.FlatStyle = FlatStyle.Flat
        TopMenu1.Button_Form_Resize.FlatAppearance.BorderSize = 0
        TopMenu1.Button_Form_Resize.BackColor = Colour_Menu_Button_Normal
        TopMenu1.Button_Form_Resize.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        TopMenu1.Button_Form_Resize.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' Close
        TopMenu1.Button_Form_Close.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Close_Resize.png")
        TopMenu1.Button_Form_Close.BackgroundImageLayout = ImageLayout.Center
        TopMenu1.Button_Form_Close.Size = Size_TopMenu_Button
        TopMenu1.Button_Form_Close.Location = New Point(TopMenu1.Width - Size_TopMenu_Button.Width, 0)
        TopMenu1.Button_Form_Close.FlatStyle = FlatStyle.Flat
        TopMenu1.Button_Form_Close.FlatAppearance.BorderSize = 0
        TopMenu1.Button_Form_Close.BackColor = Colour_Menu_Button_Normal
        TopMenu1.Button_Form_Close.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        TopMenu1.Button_Form_Close.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' Go Back
        TopMenu1.Button_Form_GoBack.Visible = False
        TopMenu1.Button_Form_GoBack.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\GoBack_Resize.png")
        TopMenu1.Button_Form_GoBack.BackgroundImageLayout = ImageLayout.Center
        TopMenu1.Button_Form_GoBack.Size = Size_TopMenu_Button
        TopMenu1.Button_Form_GoBack.Location = New Point(0, 0)
        TopMenu1.Button_Form_GoBack.FlatStyle = FlatStyle.Flat
        TopMenu1.Button_Form_GoBack.FlatAppearance.BorderSize = 0
        TopMenu1.Button_Form_GoBack.BackColor = Colour_Menu_Button_Normal
        TopMenu1.Button_Form_GoBack.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        TopMenu1.Button_Form_GoBack.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' Bottom Menu size and style declaration
        BottomMenu1.Size = New Size(Me.Width, 100)
        BottomMenu1.BackColor = Color.FromArgb(50, 57, 70)
        BottomMenu1.Location = New Point(0, Me.Height - BottomMenu1.Height)

        ' Bottom Menu button colour declaration
        ' Settings
        BottomMenu1.Settings.BackColor = Colour_Menu_Button_Normal
        BottomMenu1.Settings.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        BottomMenu1.Settings.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' About
        BottomMenu1.About.BackColor = Colour_Menu_Button_Normal
        BottomMenu1.About.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        BottomMenu1.About.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' Help
        BottomMenu1.Help.BackColor = Colour_Menu_Button_Normal
        BottomMenu1.Help.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        BottomMenu1.Help.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' Specifications
        BottomMenu1.Specifications.BackColor = Colour_Menu_Button_Normal
        BottomMenu1.Specifications.FlatAppearance.MouseDownBackColor = Colour_Menu_Button_Pressed
        BottomMenu1.Specifications.FlatAppearance.MouseOverBackColor = Colour_Menu_Button_Hover

        ' Turn table user control hidden on load
        TurnTable1.Visible = False
        Settings1.Visible = False
        TurnTable21.Visible = False
        SpecMenu1.Visible = False
    End Sub

    Private Sub Button_TurnTable_Click(sender As Object, e As EventArgs) Handles Button_TurnTable.Click
        TurnTable1.BringToFront()

        Serial_TurnTable.Open()
        Serial_TurnTable.Write(Chr(2) + "TT:S:h" + Chr(13))
        Serial_TurnTable.Close()

        If Settings1.Layout_Selection = 1 Then
            TurnTable1.Visible = True
        ElseIf Settings1.Layout_Selection = 2 Then
            TurnTable21.Visible = True
        End If

        TopMenu1.Button_Form_GoBack.Visible = True
    End Sub

    Private Sub Button_TurnTable_MouseEnter(sender As Object, e As EventArgs) Handles Button_TurnTable.MouseEnter
        Button_TurnTable_MouseIn = True

        Button_TurnTable.ForeColor = Color.White
        Button_TurnTable.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Navigation Buttons\TurnTable_Hover.png")
        Button_TurnTable.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 16, FontStyle.Regular)
        Button_TurnTable.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 9)
    End Sub

    Private Sub Button_TurnTable_MouseLeave(sender As Object, e As EventArgs) Handles Button_TurnTable.MouseLeave
        Button_TurnTable_MouseIn = False

        Button_TurnTable.ForeColor = Colour_Navigation_Button_Normal
        Button_TurnTable.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Navigation Buttons\TurnTable_Normal.png")
        Button_TurnTable.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 13, FontStyle.Regular)
        Button_TurnTable.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 15)
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' Top Menu Change
        TopMenu1.Width = Me.Width
        TopMenu1.Button_Form_Minimize.Location = New Point(TopMenu1.Width - Size_TopMenu_Button.Width * 3, 0)
        TopMenu1.Button_Form_Resize.Location = New Point(TopMenu1.Width - Size_TopMenu_Button.Width * 2, 0)
        TopMenu1.Button_Form_Close.Location = New Point(TopMenu1.Width - Size_TopMenu_Button.Width, 0)

        ' Bottom Menu Change
        BottomMenu1.Width = Me.Width
        BottomMenu1.Location = New Point(0, Me.Height - BottomMenu1.Height)

        ' Settings Menu Change
        Settings1.Size = New Size(Me.Width, Me.Height - TopMenu1.Height - BottomMenu1.Height)
        Settings1.Location = New Point(0, TopMenu1.Height)

        ' Navigation Buttons Change
        Dim Size_Navigation_Button As New Size((Me.Width / 2) - 50 - 25, (Me.Width / 2) - 50 - 25) ' width is half the window, minus the distance from the edge of the window, minus half the distance between the buttons, so every button is 50 units from the side of the window and each other

        Button_SpectrumAnalizer.Size = Size_Navigation_Button
        Button_SpectrumAnalizer.Location = New Point(Me.Width - Button_SpectrumAnalizer.Width - 50, (Me.Height + TopMenu1.Height - BottomMenu1.Height - Button_SpectrumAnalizer.Height) / 2) 'TopMenu1.Height + 50)
        If Button_SpectrumAnalyzer_MouseIn Then
            Button_SpectrumAnalizer.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 9)
            Button_SpectrumAnalizer.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 16, FontStyle.Regular)
        Else
            Button_SpectrumAnalizer.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 15)
            Button_SpectrumAnalizer.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 13, FontStyle.Regular)
        End If

        Button_TurnTable.Size = Size_Navigation_Button
        Button_TurnTable.Location = New Point(50, (Me.Height + TopMenu1.Height - BottomMenu1.Height - Button_SpectrumAnalizer.Height) / 2)
        If Button_TurnTable_MouseIn Then
            Button_TurnTable.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 9)
            Button_TurnTable.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 16, FontStyle.Regular)
        Else
            Button_TurnTable.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 15)
            Button_TurnTable.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 13, FontStyle.Regular)
        End If

        ' Turn table layout 1 screen customization
        TurnTable1.BackColor = Color.White
        TurnTable1.Location = New Point(0, TopMenu1.Height)
        TurnTable1.Size = New Size(Me.Width, Me.Height - TopMenu1.Height - BottomMenu1.Height)

        ' Turn table layout 2 screen customization
        TurnTable21.BackColor = Color.White
        TurnTable21.Location = New Point(0, TopMenu1.Height)
        TurnTable21.Size = New Size(Me.Width, Me.Height - TopMenu1.Height - BottomMenu1.Height)
    End Sub

    Private Sub Button_SpectrumAnalizer_Click(sender As Object, e As EventArgs) Handles Button_SpectrumAnalizer.Click
        SpecMenu1.BringToFront()
        SpecMenu1.Visible = True
    End Sub

    Private Sub Button_SpectrumAnalizer_MouseEnter(sender As Object, e As EventArgs) Handles Button_SpectrumAnalizer.MouseEnter
        Button_SpectrumAnalyzer_MouseIn = True

        Button_SpectrumAnalizer.ForeColor = Color.White
        Button_SpectrumAnalizer.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Navigation Buttons\Spectrum_Hover.png")
        Button_SpectrumAnalizer.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 16, FontStyle.Regular)
        Button_SpectrumAnalizer.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 9)
    End Sub

    Private Sub Button_SpectrumAnalizer_MouseLeave(sender As Object, e As EventArgs) Handles Button_SpectrumAnalizer.MouseLeave
        Button_SpectrumAnalyzer_MouseIn = False

        Button_SpectrumAnalizer.ForeColor = Colour_Navigation_Button_Normal
        Button_SpectrumAnalizer.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Navigation Buttons\Spectrum_Normal.png")
        Button_SpectrumAnalizer.Font = New Font(Font_Navigation_Button, Convert.ToSingle(Button_SpectrumAnalizer.Height) / 13, FontStyle.Regular)
        Button_SpectrumAnalizer.Padding = New Padding(0, 0, 0, Button_SpectrumAnalizer.Height / 15)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Serial_TurnTable.IsOpen Then
            Serial_TurnTable.Close()
        End If

        Serial_TurnTable.Open()
        serial_string = Serial_TurnTable.ReadLine

        If serial_string.Length >= 3 Then
            serial_substr = serial_string.Substring(serial_string.IndexOf(":"c) + 1)
            degrees = Math.Round(Convert.ToSingle(serial_substr) / 5, 0) * 5
            'read = Math.Round(Convert.ToSingle(serial_substr), 0)
            TurnTable21.Text_TurnTable.Text = Math.Round(Convert.ToSingle(serial_substr), 0)

            steps = degrees - dist 'read - dist
            step_inc = Math.Abs(steps - step_inc)
            If step_inc > 5 Then
                step_inc = 0
            End If
            rotate += step_inc
            TurnTable21.Text_Turned.Text = rotate
            step_inc = steps
        End If

        Serial_TurnTable.Close()

        degdelta = degrees - degdelta

        TurnTable21.g.RotateTransform(degdelta)
        TurnTable21.g2.RotateTransform(degdelta)
        TurnTable21.g3.RotateTransform(degdelta)
        TurnTable21.g.DrawImage(TurnTable21.img, 0, 0, TurnTable21.r, TurnTable21.r)

        degdelta = degrees

        If serial_string Like check Then
            check_count += 1
        End If

        If check_count > 3 Then 'serial_string Like "*M:0.0" Or check_count > 3 Then
            check_count = 0
            TurnTable21.Button2.Text = "Full"
            If TurnTable21.FullMouseIn Then
                TurnTable21.Button2.ForeColor = Color.WhiteSmoke
            Else
                TurnTable21.Button2.ForeColor = Font_TurnTable_Colour
            End If
            TurnTable21.Button2.BackColor = Colour_TurnTable_Button_Normal
            TurnTable21.Button2.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
            TurnTable21.Button2.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
            TurnTable21.Button2.Font = New Font(Font_Navigation_Button, Convert.ToSingle(TurnTable21.Button2.Width * 1 / 5), FontStyle.Regular)
            TurnTable21.Button2.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
            TurnTable21.Button2.FlatAppearance.BorderSize = 1
            TurnTable21.g2.DrawImage(TurnTable21.img2, 0, 0, TurnTable21.dial2const, TurnTable21.dial2const)
            rotate = 0
            Timer1.Stop()
        Else
            check = serial_string
        End If
    End Sub

End Class
