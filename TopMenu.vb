Public Class TopMenu
    Public Form_State_Minimize As Boolean = False
    Dim Font_TurnTable_Colour = Color.FromArgb(36, 163, 216)
    Dim Colour_TurnTable_Button_Pressed = Color.FromArgb(16, 143, 196)
    Private Sub Button_Form_Minimize_Click(sender As Object, e As EventArgs) Handles Button_Form_Minimize.Click
        Try
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:h" + Chr(13))
            Form1.Serial_TurnTable.Close()
        Catch
        End Try

        Form1.degdelta = 0

        Form_State_Minimize = True
        Form1.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button_Form_Resize_Click(sender As Object, e As EventArgs) Handles Button_Form_Resize.Click
        Try
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:h" + Chr(13))
            Form1.Serial_TurnTable.Close()
        Catch
        End Try

        Form1.degdelta = 0

        If Form1.WindowState = FormWindowState.Normal Then
            Form1.WindowState = FormWindowState.Maximized
        ElseIf Form1.WindowState = FormWindowState.Maximized Then
            Form1.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button_Form_Close_Click(sender As Object, e As EventArgs) Handles Button_Form_Close.Click
        Try
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:h" + Chr(13))
            Form1.Serial_TurnTable.Close()
        Catch
        End Try

        Form1.Close()
    End Sub

    Private Sub Button_Form_GoBack_Click(sender As Object, e As EventArgs) Handles Button_Form_GoBack.Click
        'Form1.Serial_TurnTable.Open()
        'Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
        'Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:h" + Chr(13))
        'Form1.Serial_TurnTable.Close()

        'If Form1.TurnTable1.Visible Then
        '    Form1.TurnTable1.Visible = False
        '    Button_Form_GoBack.Visible = False
        '    Form1.Settings1.Visible = False
        '    Form1.TurnTable21.Visible = False
        'ElseIf Form1.Settings1.Visible Then
        '    Form1.Settings1.Visible = False
        '    Button_Form_GoBack.Visible = False
        '    Form1.TurnTable1.Visible = False
        '    Form1.TurnTable21.Visible = False
        'ElseIf Form1.TurnTable21.Visible Then
        '    Form1.Settings1.Visible = False
        '    Button_Form_GoBack.Visible = False
        '    Form1.TurnTable1.Visible = False
        '    Form1.TurnTable21.Visible = False
        'End If

        ' Clear Turn Table selection
        'Form1.TurnTable21.Button4.BackColor = Color.Transparent
        'Form1.TurnTable21.Button4.ForeColor = Font_TurnTable_Colour
        'Form1.TurnTable21.Button4.FlatAppearance.BorderSize = 1
        'Form1.TurnTable21.Button5.BackColor = Color.Transparent
        'Form1.TurnTable21.Button5.ForeColor = Font_TurnTable_Colour
        'Form1.TurnTable21.Button5.FlatAppearance.BorderSize = 1
        'Form1.TurnTable21.Button6.BackColor = Colour_TurnTable_Button_Pressed
        'Form1.TurnTable21.Button6.ForeColor = Color.WhiteSmoke
        'Form1.TurnTable21.Button6.FlatAppearance.BorderSize = 0
        'Form1.TurnTable21.Button7.BackColor = Color.Transparent
        'Form1.TurnTable21.Button7.ForeColor = Font_TurnTable_Colour
        'Form1.TurnTable21.Button7.FlatAppearance.BorderSize = 1
        'Form1.TurnTable21.Button8.BackColor = Color.Transparent
        'Form1.TurnTable21.Button8.ForeColor = Font_TurnTable_Colour
        'Form1.TurnTable21.Button8.FlatAppearance.BorderSize = 1
        'Form1.TurnTable21.Button9.BackColor = Colour_TurnTable_Button_Pressed
        'Form1.TurnTable21.Button9.ForeColor = Color.WhiteSmoke
        'Form1.TurnTable21.Button9.FlatAppearance.BorderSize = 0

        If Form1.MenuSelected = "TurnTable" And Form1.BottomMenu1.BotMenuSelected = "" Then
            'Form1.TurnTable21.Visible = True
            'Form1.TurnTable21.BringToFront()
            'Form1.TurnTable21.SendToBack()
            Form1.TurnTable21.Visible = False
            Form1.MenuSelected = ""
            Form1.BottomMenu1.BotMenuSelected = ""
            Button_Form_GoBack.Visible = False
        ElseIf Form1.MenuSelected = "Spectrum" And Form1.BottomMenu1.BotMenuSelected = "" Then
            'Form1.SpecMenu1.Visible = True
            'Form1.SpecMenu1.BringToFront()
            'Form1.SpecMenu1.SendToBack()
            Form1.SpecMenu1.Visible = False
            Form1.MenuSelected = ""
            Form1.BottomMenu1.BotMenuSelected = ""
            Button_Form_GoBack.Visible = False
        End If
        If Form1.BottomMenu1.BotMenuSelected = "Settings" And Form1.MenuSelected = "TurnTable" Then
            Form1.Settings1.Visible = False
            Form1.BottomMenu1.BotMenuSelected = ""
            Form1.TurnTable21.Visible = True
            Form1.TurnTable21.BringToFront()
        ElseIf Form1.BottomMenu1.BotMenuSelected = "Settings" And Form1.MenuSelected = "Spectrum" Then
            Form1.Settings1.Visible = False
            Form1.BottomMenu1.BotMenuSelected = ""
            Form1.SpecMenu1.Visible = True
            Form1.SpecMenu1.BringToFront()
        ElseIf Form1.BottomMenu1.BotMenuSelected = "Settings" And Form1.MenuSelected = "" Then
            Form1.Settings1.Visible = False
            Form1.BottomMenu1.BotMenuSelected = ""
            Button_Form_GoBack.Visible = False
        End If

    End Sub
End Class
