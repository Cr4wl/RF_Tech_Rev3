Public Class TurnTable2
    ' Declaration of Turn Table Image
    Public g As Graphics
    Public g2 As Graphics
    Public g3 As Graphics
    Public img As Image
    Public img2 As Image
    Public img3 As Image
    Public r As Single
    Public r2 As Single
    Public dial2const As Single
    Public FullMouseIn As Boolean = False
    Public distanceTurned As Single = 0

    ' Font declaration
    Dim Font_TurnTable_Button As FontFamily = New FontFamily("Ubuntu")
    Dim Font_TurnTable_Colour = Color.FromArgb(36, 163, 216)

    ' Button declaration
    Dim Button_TurnTable_Turn_Size As Size
    Dim Button_TurnTable_Settings_Size As Size
    Dim Colour_TurnTable_Button_Normal = Color.Transparent
    Dim Colour_TurnTable_Button_Hover = Color.FromArgb(36, 163, 216)
    Dim Colour_TurnTable_Button_Pressed = Color.FromArgb(16, 143, 196)

    ' Variable declaration to check if the size has changed
    Dim Size_TurnTable_Changed As Boolean = False

    ' Selected step value for turn table
    Dim stepsize As String

    Private Sub TurnTable2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Turn table image panel style declaration
        Image_TurnTable_Dial.BackColor = Color.Transparent

        ' Buttons style declaration
        ' Group Direction
        Group_Direction.Text = "Turn Table"
        ' Button 1
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 1
        Button1.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button1.BackColor = Colour_TurnTable_Button_Normal
        Button1.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button1.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button1.Text = ""
        ' Button 2
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 1
        Button2.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button2.BackColor = Colour_TurnTable_Button_Normal
        Button2.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button2.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button2.Text = "Full"
        Button2.ForeColor = Font_TurnTable_Colour
        ' Button 3
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 1
        Button3.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button3.BackColor = Colour_TurnTable_Button_Normal
        Button3.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button3.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button3.Text = ""

        ' Group Speed
        Group_Speed.Text = "Select Speed"
        ' Button 4
        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.BorderSize = 1
        Button4.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button4.BackColor = Colour_TurnTable_Button_Normal
        Button4.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button4.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button4.Text = "Slow"
        Button4.ForeColor = Font_TurnTable_Colour
        ' Button 5
        Button5.FlatStyle = FlatStyle.Flat
        Button5.FlatAppearance.BorderSize = 1
        Button5.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button5.BackColor = Colour_TurnTable_Button_Normal
        Button5.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button5.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button5.Text = "Med"
        Button5.ForeColor = Font_TurnTable_Colour
        ' Button 6
        Button6.FlatStyle = FlatStyle.Flat
        Button6.FlatAppearance.BorderSize = 0 ' 1
        Button6.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button6.BackColor = Colour_TurnTable_Button_Pressed ' Colour_TurnTable_Button_Normal
        Button6.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button6.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button6.Text = "Fast"
        Button6.ForeColor = Color.WhiteSmoke ' Font_TurnTable_Colour

        ' Group Step
        Group_Step.Text = "Select Step Size"
        ' Button 7
        Button7.FlatStyle = FlatStyle.Flat
        Button7.FlatAppearance.BorderSize = 1
        Button7.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button7.BackColor = Colour_TurnTable_Button_Normal
        Button7.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button7.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button7.Text = "Small"
        Button7.ForeColor = Font_TurnTable_Colour
        ' Button 8
        Button8.FlatStyle = FlatStyle.Flat
        Button8.FlatAppearance.BorderSize = 1
        Button8.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button8.BackColor = Colour_TurnTable_Button_Normal
        Button8.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button8.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button8.Text = "Large"
        Button8.ForeColor = Font_TurnTable_Colour
        ' Button 9
        Button9.FlatStyle = FlatStyle.Flat
        Button9.FlatAppearance.BorderSize = 0 ' 1
        Button9.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
        Button9.BackColor = Colour_TurnTable_Button_Pressed ' Colour_TurnTable_Button_Normal
        Button9.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Button9.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Button9.Text = "No Step"
        Button9.ForeColor = Color.WhiteSmoke ' Font_TurnTable_Colour

        ' Turn table image editor buttons
        ' Pen
        Pen.FlatStyle = FlatStyle.Flat
        Pen.FlatAppearance.BorderSize = 0
        Pen.BackColor = Color.Transparent
        Pen.FlatAppearance.MouseDownBackColor = Color.Transparent
        Pen.FlatAppearance.MouseOverBackColor = Color.Transparent
        Pen.Text = "Mark"
        Pen.ForeColor = Color.SlateGray
        Pen.TextAlign = ContentAlignment.MiddleLeft
        ' Eraser
        Eraser.FlatStyle = FlatStyle.Flat
        Eraser.FlatAppearance.BorderSize = 0
        Eraser.BackColor = Color.Transparent
        Eraser.FlatAppearance.MouseDownBackColor = Color.Transparent
        Eraser.FlatAppearance.MouseOverBackColor = Color.Transparent
        Eraser.Text = "Reset"
        Eraser.ForeColor = Color.SlateGray
        Eraser.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub TurnTable2_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' Refresh the turn table image panel if and when the size of the panel changed
        Image_TurnTable_Dial.Refresh()

        ' Reset dial position once turn table image panel size changed for the first time after page loaded
        If Size_TurnTable_Changed Then
            g.TranslateTransform(-Image_TurnTable_Dial.Width / 2, -Image_TurnTable_Dial.Width / 2)
            g.RotateTransform(45)
        End If

        ' Set size of turn table image panel and set background image and style
        Image_TurnTable_Dial.Size = New Size((Me.Height) * 9 / 10, (Me.Height) * 9 / 10)
        Image_TurnTable_Dial.Location = New Point((Me.Width - Image_TurnTable_Dial.Width) * 9 / 10, (Me.Height - Image_TurnTable_Dial.Height) / 2)
        Image_TurnTable_Dial.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\TurnTable.png")
        Image_TurnTable_Dial.BackgroundImageLayout = BackgroundImageLayout.Zoom

        ' Set size and location of groupboxes and buttons
        Button_TurnTable_Turn_Size = New Size(Me.Width / 12, Me.Width / 12)
        Button_TurnTable_Settings_Size = New Size(Me.Width / 12, Me.Width / 12)
        ' Speed Group
        Group_Speed.Size = New Size((Button_TurnTable_Turn_Size.Width + Button_TurnTable_Turn_Size.Width + Button_TurnTable_Turn_Size.Width) * 12 / 10, (Button_TurnTable_Turn_Size.Height) * 15 / 10)
        Group_Speed.Location = New Point(Me.Width * 2 / 10 - Group_Speed.Width / 2, Image_TurnTable_Dial.Location.Y)
        Group_Speed.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Group_Speed.Width * 1 / 25), FontStyle.Regular)
        ' Speed Buttons
        ' Button 4
        Button4.Size = Button_TurnTable_Settings_Size
        Button4.Location = New Point(Group_Speed.Width * 1 / 6 - Button4.Width / 2, (Group_Speed.Height - Button4.Height) / 2 + (Group_Speed.Height - Button4.Height) / 6)
        Button4.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button4.Width * 1 / 5), FontStyle.Regular)
        ' Button 5
        Button5.Size = Button_TurnTable_Settings_Size
        Button5.Location = New Point(Group_Speed.Width * 3 / 6 - Button5.Width / 2, (Group_Speed.Height - Button5.Height) / 2 + (Group_Speed.Height - Button5.Height) / 6)
        Button5.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button5.Width * 1 / 5), FontStyle.Regular)
        ' Button 6
        Button6.Size = Button_TurnTable_Settings_Size
        Button6.Location = New Point(Group_Speed.Width * 5 / 6 - Button6.Width / 2, (Group_Speed.Height - Button6.Height) / 2 + (Group_Speed.Height - Button6.Height) / 6)
        Button6.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button6.Width * 1 / 5), FontStyle.Regular)

        ' Step Group
        Group_Step.Size = New Size((Button_TurnTable_Turn_Size.Width + Button_TurnTable_Turn_Size.Width + Button_TurnTable_Turn_Size.Width) * 12 / 10, (Button_TurnTable_Turn_Size.Height) * 15 / 10)
        Group_Step.Location = New Point(Me.Width * 2 / 10 - Group_Step.Width / 2, Group_Speed.Location.Y + Group_Speed.Height)
        Group_Step.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Group_Step.Width * 1 / 25), FontStyle.Regular)
        ' Step Buttons
        ' Button 7
        Button7.Size = Button_TurnTable_Settings_Size
        Button7.Location = New Point(Group_Step.Width * 1 / 6 - Button7.Width / 2, (Group_Step.Height - Button7.Height) / 2 + (Group_Step.Height - Button7.Height) / 6)
        Button7.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button7.Width * 1 / 5), FontStyle.Regular)
        ' Button 8
        Button8.Size = Button_TurnTable_Settings_Size
        Button8.Location = New Point(Group_Step.Width * 3 / 6 - Button8.Width / 2, (Group_Step.Height - Button8.Height) / 2 + (Group_Step.Height - Button8.Height) / 6)
        Button8.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button8.Width * 1 / 5), FontStyle.Regular)
        ' Button 9
        Button9.Size = Button_TurnTable_Settings_Size
        Button9.Location = New Point(Group_Step.Width * 5 / 6 - Button9.Width / 2, (Group_Step.Height - Button9.Height) / 2 + (Group_Step.Height - Button9.Height) / 6)
        Button9.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button9.Width * 1 / 5), FontStyle.Regular)

        ' Direction Group
        Group_Direction.Size = New Size((Button_TurnTable_Settings_Size.Width + Button_TurnTable_Settings_Size.Width + Button_TurnTable_Settings_Size.Width) * 12 / 10, (Button_TurnTable_Settings_Size.Height) * 15 / 10)
        Group_Direction.Location = New Point(Me.Width * 2 / 10 - Group_Direction.Width / 2, Image_TurnTable_Dial.Location.Y + Image_TurnTable_Dial.Height - Group_Direction.Height)
        Group_Direction.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Group_Direction.Width * 1 / 25), FontStyle.Regular)
        ' Direction Buttons
        ' Button 1
        Button1.Size = Button_TurnTable_Turn_Size
        Button1.Location = New Point(Group_Direction.Width * 1 / 6 - Button1.Width / 2, (Group_Direction.Height - Button1.Height) / 2 + (Group_Direction.Height - Button1.Height) / 6)
        Button1.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button1.Width * 1 / 5), FontStyle.Regular)
        Button1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CC.png")
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        ' Button 2
        Button2.Size = Button_TurnTable_Turn_Size
        Button2.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button2.Width * 1 / 5), FontStyle.Regular)
        Button2.Location = New Point(Group_Direction.Width * 3 / 6 - Button2.Width / 2, (Group_Direction.Height - Button2.Height) / 2 + (Group_Direction.Height - Button2.Height) / 6)
        ' Button 3
        Button3.Size = Button_TurnTable_Turn_Size
        Button3.Location = New Point(Group_Direction.Width * 5 / 6 - Button3.Width / 2, (Group_Direction.Height - Button3.Height) / 2 + (Group_Direction.Height - Button3.Height) / 6)
        Button3.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button3.Width * 1 / 5), FontStyle.Regular)
        Button3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CW.png")
        Button3.BackgroundImageLayout = ImageLayout.Zoom

        ' Set size and location of turn table modification buttons
        ' Pen
        Pen.Size = New Size(Image_TurnTable_Dial.Width * 2 / 15, Image_TurnTable_Dial.Height / 15)
        Pen.Location = New Point(0, Image_TurnTable_Dial.Height - Pen.Height)
        Pen.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Image_TurnTable_Dial.Width * 1 / 50), FontStyle.Regular)
        'Pen.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Pen.png")
        'Pen.BackgroundImageLayout = ImageLayout.Zoom
        ' Eraser
        Eraser.Size = New Size(Image_TurnTable_Dial.Width * 2 / 15, Image_TurnTable_Dial.Height / 15)
        Eraser.Location = New Point(Image_TurnTable_Dial.Width - Eraser.Width, Image_TurnTable_Dial.Height - Eraser.Height)
        Eraser.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Image_TurnTable_Dial.Width * 1 / 50), FontStyle.Regular)
        'Eraser.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Eraser.png")
        'Eraser.BackgroundImageLayout = ImageLayout.Zoom

        ' Declare the graphics to be drawn in the turn table image panel
        g = Image_TurnTable_Dial.CreateGraphics
        g2 = Image_TurnTable_Dial.CreateGraphics
        g3 = Image_TurnTable_Dial.CreateGraphics
        img = Bitmap.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Dial.png")
        img2 = Bitmap.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Dial2.png")
        img3 = Bitmap.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Dial3.png")

        ' Determine the size of the dial for the turn table image
        r = (Math.Sqrt(2 * ((Image_TurnTable_Dial.Width / 2) ^ 2)) / 2) - (Image_TurnTable_Dial.Width / 52)
        r2 = r / 1.5
        dial2const = r * 1.03

        ' Position the dial in the centre of the turn table image
        g.TranslateTransform(Image_TurnTable_Dial.Width / 2, Image_TurnTable_Dial.Height / 2)
        g.RotateTransform(-45)
        g2.TranslateTransform(Image_TurnTable_Dial.Width / 2, Image_TurnTable_Dial.Height / 2)
        g2.RotateTransform(-45)
        g3.TranslateTransform(Image_TurnTable_Dial.Width / 2, Image_TurnTable_Dial.Height / 2)
        g3.RotateTransform(-45)

        ' Turn table image panel text size and style declaration
        Text_TurnTable.Text = "0"
        Text_TurnTable.AutoSize = True
        Text_Turned.Text = "0"
        Text_Turned.AutoSize = True

        ' This seemingly useless if function is here SOLELY to prevent the program from crashing when the form is minimized... comment the function out and run the program if you don't believe me...
        If Image_TurnTable_Dial.Width < 10 Then
            Image_TurnTable_Dial.Width = 10
        End If

        Text_TurnTable.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Image_TurnTable_Dial.Width * 1 / 10), FontStyle.Regular)
        Text_TurnTable.ForeColor = Font_TurnTable_Colour
        Text_TurnTable.TextAlign = ContentAlignment.MiddleCenter
        Text_Turned.Font = New Font(Font_TurnTable_Button, Text_TurnTable.Font.Size / 2, FontStyle.Regular)
        Text_Turned.ForeColor = Color.LightGray
        Text_Turned.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub Text_TurnTable_SizeChanged(sender As Object, e As EventArgs) Handles Text_TurnTable.SizeChanged
        Text_TurnTable.Location = New Point((Image_TurnTable_Dial.Width - Text_TurnTable.Width) / 2 + ((Image_TurnTable_Dial.Width - Text_TurnTable.Width) / 2) / 50, (Image_TurnTable_Dial.Height - Text_TurnTable.Height) / 2)

    End Sub
    Private Sub Text_Turned_SizeChanged(sender As Object, e As EventArgs) Handles Text_Turned.SizeChanged
        Text_Turned.Location = New Point((Image_TurnTable_Dial.Width - Text_Turned.Width) / 2 + ((Image_TurnTable_Dial.Width - Text_Turned.Width) / 2) / 100, (Text_TurnTable.Location.Y + Text_TurnTable.Height))
    End Sub

    '''''' From here the turn table buttons are configured to display correctly after being clicked and hovered upon ''''''
    ''' Turn Buttons '''

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CC_White.png")
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CC.png")
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CC_White_Pressed.png")

        If Button2.Text = "Stop" Then
            Form1.Timer1.Stop()
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
            Form1.Serial_TurnTable.Close()
            distanceTurned = Math.Round(Convert.ToSingle(Form1.serial_substr), 0)
            Button2.ForeColor = Font_TurnTable_Colour
            Button2.BackColor = Colour_TurnTable_Button_Normal
            Button2.FlatAppearance.BorderColor = Font_TurnTable_Colour
            Button2.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
            Button2.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
            Button2.Text = "Full"
        End If

        If Button9.BackColor = Colour_TurnTable_Button_Pressed Then
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:M:sf,d=-1" + Chr(13))
            Form1.Serial_TurnTable.Close()
        Else
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:r=" + stepsize + ",d=-1" + Chr(13))
            Form1.Serial_TurnTable.Close()
        End If

        Image_TurnTable_Dial.Refresh()
        Form1.Timer1.Start()
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        Button1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CC_White.png")
        distanceTurned = math.Abs(Math.Round(Convert.ToSingle(Form1.serial_substr), 0))

        If Button9.BackColor = Colour_TurnTable_Button_Pressed Then
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
            Form1.Serial_TurnTable.Close()
            Form1.rotate = 0
            Form1.Timer1.Stop()
            g2.DrawImage(img2, 0, 0, dial2const, dial2const)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button4.BackColor = Colour_TurnTable_Button_Normal And Button5.BackColor = Colour_TurnTable_Button_Normal And Button6.BackColor = Colour_TurnTable_Button_Normal Then
            Button4.ForeColor = Color.IndianRed
            Button4.FlatAppearance.BorderColor = Color.IndianRed
            Button5.ForeColor = Color.IndianRed
            Button5.FlatAppearance.BorderColor = Color.IndianRed
            Button6.ForeColor = Color.IndianRed
            Button6.FlatAppearance.BorderColor = Color.IndianRed
        Else
            If Button2.Text = "Full" Then
                Image_TurnTable_Dial.Refresh()

                Form1.Serial_TurnTable.Open()
                Form1.Serial_TurnTable.Write(Chr(2) + "TT:F" + Chr(13))
                Form1.Serial_TurnTable.Close()

                Form1.Timer1.Start()

                Button2.Text = "Stop"
                Button2.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button2.Width * 1 / 5), FontStyle.Regular)
                Button2.ForeColor = Color.WhiteSmoke
                Button2.FlatAppearance.MouseOverBackColor = Color.IndianRed
                Button2.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Button2.FlatAppearance.BorderColor = Color.IndianRed
            Else
                Form1.Serial_TurnTable.Open()
                Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
                Form1.Serial_TurnTable.Close()
                g2.DrawImage(img2, 0, 0, dial2const, dial2const)
                Form1.Timer1.Stop()
                Form1.rotate = 0
                distanceTurned = Math.Round(Convert.ToSingle(Form1.serial_substr), 0)

                Button2.Text = "Full"
                Button2.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Button2.Width * 1 / 5), FontStyle.Regular)
                Button2.ForeColor = Color.WhiteSmoke
                Button2.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
                Button2.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
                Button2.FlatAppearance.BorderColor = Colour_TurnTable_Button_Hover
            End If
        End If

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.WhiteSmoke
        FullMouseIn = True
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        If Button2.Text = "Stop" Then
            Button2.ForeColor = Color.IndianRed
            Button2.FlatAppearance.BorderColor = Color.IndianRed
            Button2.FlatAppearance.BorderSize = 1
        ElseIf Button2.Text = "Full" Then
            Button2.ForeColor = Font_TurnTable_Colour
            Button2.FlatAppearance.BorderColor = Font_TurnTable_Colour
            Button2.FlatAppearance.BorderSize = 1
        End If
        FullMouseIn = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CW_White.png")
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CW.png")
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        Button3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CW_White_Pressed.png")

        If Button2.Text = "Stop" Then
            Form1.Timer1.Stop()
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
            Form1.Serial_TurnTable.Close()
            Button2.ForeColor = Font_TurnTable_Colour
            Button2.BackColor = Colour_TurnTable_Button_Normal
            Button2.FlatAppearance.BorderColor = Font_TurnTable_Colour
            Button2.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
            Button2.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
            Button2.Text = "Full"
        End If

        If Button9.BackColor = Colour_TurnTable_Button_Pressed Then
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:M:sf,d=1" + Chr(13))
            Form1.Serial_TurnTable.Close()
        Else
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:r=" + stepsize + Chr(13))
            Form1.Serial_TurnTable.Close()
        End If

        Image_TurnTable_Dial.Refresh()
        Form1.Timer1.Start()
    End Sub

    Private Sub Button3_MouseUp(sender As Object, e As MouseEventArgs) Handles Button3.MouseUp
        Button3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CW_White.png")
        distanceTurned = Math.Round(Convert.ToSingle(Form1.serial_substr), 0)

        If Button9.BackColor = Colour_TurnTable_Button_Pressed Then
            Form1.Serial_TurnTable.Open()
            Form1.Serial_TurnTable.Write(Chr(2) + "TT:A" + Chr(13))
            Form1.Serial_TurnTable.Close()
            Form1.rotate = 0
            Form1.Timer1.Stop()
            g2.DrawImage(img2, 0, 0, dial2const, dial2const)
        End If
    End Sub

    ''' Settings Buttons '''

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Serial_TurnTable.Open()
        Form1.Serial_TurnTable.Write(Chr(2) + "TT:SET:ma=" + Form1.Settings1.Set_Speed_Slow.Text + Chr(13))
        Form1.Serial_TurnTable.Close()

        Button4.FlatAppearance.BorderSize = 0
        Button4.BackColor = Colour_TurnTable_Button_Pressed

        Button5.FlatAppearance.BorderSize = 1
        Button5.BackColor = Colour_TurnTable_Button_Normal
        Button5.ForeColor = Font_TurnTable_Colour
        Button5.FlatAppearance.BorderColor = Font_TurnTable_Colour

        Button6.FlatAppearance.BorderSize = 1
        Button6.BackColor = Colour_TurnTable_Button_Normal
        Button6.ForeColor = Font_TurnTable_Colour
        Button6.FlatAppearance.BorderColor = Font_TurnTable_Colour
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Text = Form1.Settings1.Set_Speed_Slow.Text
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        If Button4.BackColor = Colour_TurnTable_Button_Pressed Then
            Button4.ForeColor = Color.WhiteSmoke
        ElseIf Button4.BackColor = Colour_TurnTable_Button_Normal Then
            Button4.ForeColor = Font_TurnTable_Colour
        End If
        Button4.Text = "Slow"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Serial_TurnTable.Open()
        Form1.Serial_TurnTable.Write(Chr(2) + "TT:SET:ma=" + Form1.Settings1.Set_Speed_Med.Text + Chr(13))
        Form1.Serial_TurnTable.Close()

        Button4.FlatAppearance.BorderSize = 1
        Button4.BackColor = Colour_TurnTable_Button_Normal
        Button4.ForeColor = Font_TurnTable_Colour
        Button4.FlatAppearance.BorderColor = Font_TurnTable_Colour

        Button5.FlatAppearance.BorderSize = 0
        Button5.BackColor = Colour_TurnTable_Button_Pressed

        Button6.FlatAppearance.BorderSize = 1
        Button6.BackColor = Colour_TurnTable_Button_Normal
        Button6.ForeColor = Font_TurnTable_Colour
        Button6.FlatAppearance.BorderColor = Font_TurnTable_Colour
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.WhiteSmoke
        Button5.Text = Form1.Settings1.Set_Speed_Med.Text
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        If Button5.BackColor = Colour_TurnTable_Button_Pressed Then
            Button5.ForeColor = Color.WhiteSmoke
        ElseIf Button5.BackColor = Colour_TurnTable_Button_Normal Then
            Button5.ForeColor = Font_TurnTable_Colour
        End If
        Button5.Text = "Med"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Serial_TurnTable.Open()
        Form1.Serial_TurnTable.Write(Chr(2) + "TT:SET:ma=" + Form1.Settings1.Set_Speed_Fast.Text + Chr(13))
        Form1.Serial_TurnTable.Close()

        Button4.FlatAppearance.BorderSize = 1
        Button4.BackColor = Colour_TurnTable_Button_Normal
        Button4.ForeColor = Font_TurnTable_Colour
        Button4.FlatAppearance.BorderColor = Font_TurnTable_Colour

        Button5.FlatAppearance.BorderSize = 1
        Button5.BackColor = Colour_TurnTable_Button_Normal
        Button5.ForeColor = Font_TurnTable_Colour
        Button5.FlatAppearance.BorderColor = Font_TurnTable_Colour

        Button6.FlatAppearance.BorderSize = 0
        Button6.BackColor = Colour_TurnTable_Button_Pressed
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.WhiteSmoke
        Button6.Text = Form1.Settings1.Set_Speed_Fast.Text
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        If Button6.BackColor = Colour_TurnTable_Button_Pressed Then
            Button6.ForeColor = Color.WhiteSmoke
        ElseIf Button6.BackColor = Colour_TurnTable_Button_Normal Then
            Button6.ForeColor = Font_TurnTable_Colour
        End If
        Button6.Text = "Fast"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        stepsize = Form1.Settings1.Set_Step_Small.Text

        Button7.FlatAppearance.BorderSize = 0
        Button7.BackColor = Colour_TurnTable_Button_Pressed

        Button8.FlatAppearance.BorderSize = 1
        Button8.BackColor = Colour_TurnTable_Button_Normal
        Button8.ForeColor = Font_TurnTable_Colour

        Button9.FlatAppearance.BorderSize = 1
        Button9.BackColor = Colour_TurnTable_Button_Normal
        Button9.ForeColor = Font_TurnTable_Colour
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.WhiteSmoke
        Button7.Text = Form1.Settings1.Set_Step_Small.Text + "°"
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        If Button7.BackColor = Colour_TurnTable_Button_Pressed Then
            Button7.ForeColor = Color.WhiteSmoke
        ElseIf Button7.BackColor = Colour_TurnTable_Button_Normal Then
            Button7.ForeColor = Font_TurnTable_Colour
        End If
        Button7.Text = "Small"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        stepsize = Form1.Settings1.Set_Step_Large.Text

        Button7.FlatAppearance.BorderSize = 1
        Button7.BackColor = Colour_TurnTable_Button_Normal
        Button7.ForeColor = Font_TurnTable_Colour

        Button8.FlatAppearance.BorderSize = 0
        Button8.BackColor = Colour_TurnTable_Button_Pressed

        Button9.FlatAppearance.BorderSize = 1
        Button9.BackColor = Colour_TurnTable_Button_Normal
        Button9.ForeColor = Font_TurnTable_Colour
    End Sub

    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        Button8.ForeColor = Color.WhiteSmoke
        Button8.Text = Form1.Settings1.Set_Step_Large.Text + "°"
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        If Button8.BackColor = Colour_TurnTable_Button_Pressed Then
            Button8.ForeColor = Color.WhiteSmoke
        ElseIf Button8.BackColor = Colour_TurnTable_Button_Normal Then
            Button8.ForeColor = Font_TurnTable_Colour
        End If
        Button8.Text = "Large"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        stepsize = Form1.Settings1.Set_Step_Large.Text

        Button7.FlatAppearance.BorderSize = 1
        Button7.BackColor = Colour_TurnTable_Button_Normal
        Button7.ForeColor = Font_TurnTable_Colour

        Button8.FlatAppearance.BorderSize = 1
        Button8.BackColor = Colour_TurnTable_Button_Normal
        Button8.ForeColor = Font_TurnTable_Colour

        Button9.FlatAppearance.BorderSize = 0
        Button9.BackColor = Colour_TurnTable_Button_Pressed
    End Sub

    Private Sub Button9_MouseEnter(sender As Object, e As EventArgs) Handles Button9.MouseEnter
        Button9.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        If Button9.BackColor = Colour_TurnTable_Button_Pressed Then
            Button9.ForeColor = Color.WhiteSmoke
        ElseIf Button9.BackColor = Colour_TurnTable_Button_Normal Then
            Button9.ForeColor = Font_TurnTable_Colour
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Pen.Click
        g3.DrawImage(img3, 0, 0, r2, r2)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Eraser.Click
        Text_TurnTable.Text = "0"
        Image_TurnTable_Dial.Refresh()

        Form1.Serial_TurnTable.Open()
        Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:h" + Chr(13))
        Form1.Serial_TurnTable.Close()
    End Sub

    Private Sub Text_TurnTable_Click(sender As Object, e As EventArgs) Handles Text_TurnTable.Click

    End Sub

    Private Sub Text_TurnTable_DoubleClick(sender As Object, e As EventArgs) Handles Text_TurnTable.DoubleClick
        'Form1.Serial_TurnTable.Open()
        'Form1.Serial_TurnTable.Write(Chr(2) + "TT:S:h" + Chr(13))
        'Form1.Serial_TurnTable.Close()
    End Sub
End Class
