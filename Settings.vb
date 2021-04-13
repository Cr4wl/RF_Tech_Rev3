Public Class Settings
    Public red As Integer = 0
    Public blue As Integer = 0
    Public green As Integer = 0

    Dim delta1 As Integer = 10
    Dim delta_red1 As Integer
    Dim delta_green1 As Integer
    Dim delta_blue1 As Integer
    Dim delta2 As Integer = 20
    Dim delta_red2 As Integer
    Dim delta_green2 As Integer
    Dim delta_blue2 As Integer

    Dim button_recolour_hover As Color
    Dim button_recolour_pressed As Color

    Dim font_recolour As Color

    Public Layout_Selection As Integer = 2

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.LargeChange = 10
        HScrollBar1.SmallChange = 1
        HScrollBar1.Maximum = 255
        HScrollBar1.Minimum = 1
        Label1.Text = "Red"
        HScrollBar2.LargeChange = 10
        HScrollBar2.SmallChange = 1
        HScrollBar2.Maximum = 255
        HScrollBar2.Minimum = 1
        Label2.Text = "Blue"
        HScrollBar3.LargeChange = 10
        HScrollBar3.SmallChange = 1
        HScrollBar3.Maximum = 255
        HScrollBar3.Minimum = 1
        Label3.Text = "Green"
        Panel1.BackColor = Color.FromArgb(red, green, blue)

        '' Turn table settings
        ' Group Label
        Setting_TurnTable.Text = "Turn Table Settings"

        ' Labels
        Label_Speed_Slow.Text = "Slow"
        Label_Speed_Med.Text = "Medium"
        Label_Speed_Fast.Text = "Fast"
        Label_Step_Small.Text = "Small"
        Label_Step_Large.Text = "Large"

        ' Default text box values
        Set_Speed_Slow.Text = 50
        Set_Speed_Med.Text = 100
        Set_Speed_Fast.Text = 200
        Set_Step_Small.Text = 5
        Set_Step_Large.Text = 45

        ' Default Serial Port
        Label_SerialPort.Text = "COM Port"
        Set_SerialPort.Text = "3"
    End Sub

    Private Sub Settings_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        red = HScrollBar1.Value
        Panel1.BackColor = Color.FromArgb(red, green, blue)
        Label4.Text = Math.Round((red + green + blue) / 3, 0)
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        blue = HScrollBar2.Value
        Panel1.BackColor = Color.FromArgb(red, green, blue)
        Label4.Text = Math.Round((red + green + blue) / 3, 0)
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        green = HScrollBar3.Value
        Panel1.BackColor = Color.FromArgb(red, green, blue)
        Label4.Text = Math.Round((red + green + blue) / 3, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Recolour.Click
        ' Recolour Bottom and Top Menus
        Form1.TopMenu1.BackColor = Color.FromArgb(red, green, blue)
        Form1.BottomMenu1.BackColor = Color.FromArgb(red, green, blue)

        ' If the menu background colour is too light, change buttons and font colours dark
        If Math.Round((red + green + blue) / 3, 0) > 125 Then
            ' Set Font Colour
            font_recolour = Color.FromArgb(30, 30, 30)

            ' Bottom Menu
            Form1.BottomMenu1.Settings.ForeColor = font_recolour
            Form1.BottomMenu1.About.ForeColor = font_recolour
            Form1.BottomMenu1.Help.ForeColor = font_recolour
            Form1.BottomMenu1.Specifications.ForeColor = font_recolour

            ' Top Menu
            Form1.TopMenu1.Button_Form_Close.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Close_Dark.png")
            Form1.TopMenu1.Button_Form_Minimize.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Minimize_Dark.png")
            Form1.TopMenu1.Button_Form_Resize.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Resize_Dark.png")
            Form1.TopMenu1.Button_Form_GoBack.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\GoBack_Dark.png")

            ' Change in delte1 and delta2 to subract instead of add
            delta1 = -delta1
            delta2 = -delta2
        Else
            ' Set Font Colour
            font_recolour = Color.WhiteSmoke

            ' Bottom Menu
            Form1.BottomMenu1.Settings.ForeColor = font_recolour
            Form1.BottomMenu1.About.ForeColor = font_recolour
            Form1.BottomMenu1.Help.ForeColor = font_recolour
            Form1.BottomMenu1.Specifications.ForeColor = font_recolour

            ' Top Menu
            Form1.TopMenu1.Button_Form_Close.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Close_Resize.png")
            Form1.TopMenu1.Button_Form_Minimize.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Minimize_Resize.png")
            Form1.TopMenu1.Button_Form_Resize.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\Resize_Resize.png")
            Form1.TopMenu1.Button_Form_GoBack.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Top Menu Buttons\GoBack_Resize.png")

            ' Change in delte1 and delta2 to subract instead of add
            delta1 = Math.Abs(delta1)
            delta2 = Math.Abs(delta2)

        End If

        ' Check that colour values do not go out of bounds
        delta_red1 = red + delta1
        delta_green1 = green + delta1
        delta_blue1 = blue + delta1
        delta_red2 = red + delta2
        delta_green2 = green + delta2
        delta_blue2 = blue + delta2

        If delta_red1 < 0 Then
            delta_red1 = 10
        End If
        If delta_red2 < 0 Then
            delta_red2 = 20
        End If
        If delta_green1 < 0 Then
            delta_green1 = 10
        End If
        If delta_green2 < 0 Then
            delta_green2 = 20
        End If
        If delta_blue1 < 0 Then
            delta_blue1 = 10
        End If
        If delta_blue2 < 0 Then
            delta_blue2 = 20
        End If

        If delta_red1 > 255 Then
            delta_red1 = 245
        End If
        If delta_red2 > 255 Then
            delta_red2 = 235
        End If
        If delta_green1 > 255 Then
            delta_green1 = 245
        End If
        If delta_green2 > 255 Then
            delta_green2 = 235
        End If
        If delta_blue1 > 255 Then
            delta_blue1 = 245
        End If
        If delta_blue2 > 255 Then
            delta_blue2 = 235
        End If

        ' Button Hover and Press recolour
        button_recolour_hover = Color.FromArgb(delta_red1, delta_green1, delta_blue1)
        button_recolour_pressed = Color.FromArgb(delta_red2, delta_green2, delta_blue2)

        ' Bottom Menu
        Form1.BottomMenu1.Settings.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.BottomMenu1.Settings.FlatAppearance.MouseDownBackColor = button_recolour_pressed
        Form1.BottomMenu1.About.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.BottomMenu1.About.FlatAppearance.MouseDownBackColor = button_recolour_pressed
        Form1.BottomMenu1.Help.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.BottomMenu1.Help.FlatAppearance.MouseDownBackColor = button_recolour_pressed
        Form1.BottomMenu1.Specifications.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.BottomMenu1.Specifications.FlatAppearance.MouseDownBackColor = button_recolour_pressed

        ' Top Menu
        Form1.TopMenu1.Button_Form_Close.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.TopMenu1.Button_Form_Close.FlatAppearance.MouseDownBackColor = button_recolour_pressed
        Form1.TopMenu1.Button_Form_Minimize.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.TopMenu1.Button_Form_Minimize.FlatAppearance.MouseDownBackColor = button_recolour_pressed
        Form1.TopMenu1.Button_Form_Resize.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.TopMenu1.Button_Form_Resize.FlatAppearance.MouseDownBackColor = button_recolour_pressed
        Form1.TopMenu1.Button_Form_GoBack.FlatAppearance.MouseOverBackColor = button_recolour_hover
        Form1.TopMenu1.Button_Form_GoBack.FlatAppearance.MouseDownBackColor = button_recolour_pressed

    End Sub

    Private Sub Layout_1_Click(sender As Object, e As EventArgs) Handles Layout_1.Click
        Layout_Selection = 1
    End Sub

    Private Sub Layout_2_Click(sender As Object, e As EventArgs) Handles Layout_2.Click
        Layout_Selection = 2
    End Sub
End Class
