Public Class TurnTable
    ' Declaration of Turn Table Image
    Dim g As Graphics
    Dim g2 As Graphics
    Dim img As Image
    Dim img2 As Image
    Dim r As Single

    ' Font declaration
    Dim Font_TurnTable_Button As FontFamily = New FontFamily("Ubuntu")
    Dim Font_TurnTable_Colour = Color.FromArgb(36, 163, 216)
    Dim Font_TurnTable_Button_Colour = Color.FromArgb(150, 150, 150)

    ' Button declaration
    Dim Button_TurnTable_Size As Size
    Dim Colour_TurnTable_Button_Normal = Color.Transparent
    Dim Colour_TurnTable_Button_Hover = Color.Transparent
    Dim Colour_TurnTable_Button_Pressed = Color.Transparent

    Private Sub TurnTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Turn table image panel style declaration
        Image_TurnTable_Dial.BackColor = Color.Transparent

        ' Turn table button flat style declaration
        ' CC 360
        Turn_360_CC.FlatStyle = FlatStyle.Flat
        Turn_360_CC.FlatAppearance.BorderSize = 0
        Turn_360_CC.BackColor = Colour_TurnTable_Button_Normal
        Turn_360_CC.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_360_CC.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_360_CC.Text = "360°"

        ' CC Slow
        Turn_Slow_CC.FlatStyle = FlatStyle.Flat
        Turn_Slow_CC.FlatAppearance.BorderSize = 0
        Turn_Slow_CC.BackColor = Colour_TurnTable_Button_Normal
        Turn_Slow_CC.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_Slow_CC.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_Slow_CC.Text = ""

        ' CC Fast
        Turn_Fast_CC.FlatStyle = FlatStyle.Flat
        Turn_Fast_CC.FlatAppearance.BorderSize = 0
        Turn_Fast_CC.BackColor = Colour_TurnTable_Button_Normal
        Turn_Fast_CC.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_Fast_CC.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_Fast_CC.Text = ""

        ' CC Fixed
        Turn_FixedStep_CC.FlatStyle = FlatStyle.Flat
        Turn_FixedStep_CC.FlatAppearance.BorderSize = 0
        Turn_FixedStep_CC.BackColor = Colour_TurnTable_Button_Normal
        Turn_FixedStep_CC.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_FixedStep_CC.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_FixedStep_CC.Text = "5°"

        ' CW 360
        Turn_360_CW.FlatStyle = FlatStyle.Flat
        Turn_360_CW.FlatAppearance.BorderSize = 0
        Turn_360_CW.BackColor = Colour_TurnTable_Button_Normal
        Turn_360_CW.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_360_CW.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_360_CW.Text = "360°"

        ' CW Slow
        Turn_Slow_CW.FlatStyle = FlatStyle.Flat
        Turn_Slow_CW.FlatAppearance.BorderSize = 0
        Turn_Slow_CW.BackColor = Colour_TurnTable_Button_Normal
        Turn_Slow_CW.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_Slow_CW.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_Slow_CW.Text = ""

        ' CW Fast
        Turn_Fast_CW.FlatStyle = FlatStyle.Flat
        Turn_Fast_CW.FlatAppearance.BorderSize = 0
        Turn_Fast_CW.BackColor = Colour_TurnTable_Button_Normal
        Turn_Fast_CW.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_Fast_CW.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_Fast_CW.Text = ""

        ' CW Fixed
        Turn_FixedStep_CW.FlatStyle = FlatStyle.Flat
        Turn_FixedStep_CW.FlatAppearance.BorderSize = 0
        Turn_FixedStep_CW.BackColor = Colour_TurnTable_Button_Normal
        Turn_FixedStep_CW.FlatAppearance.MouseDownBackColor = Colour_TurnTable_Button_Pressed
        Turn_FixedStep_CW.FlatAppearance.MouseOverBackColor = Colour_TurnTable_Button_Hover
        Turn_FixedStep_CW.Text = "5°"


    End Sub

    Dim Size_TurnTable_Changed As Boolean = False
    Private Sub TurnTable_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        '' This will be commented out once degrees from table is received
        Timer1.Stop()
        Degrees = 0

        ' Refresh the turn table image panel if and when the size of the panel changed
        Image_TurnTable_Dial.Refresh()

        ' Reset dial position once turn table image panel size changed for the first time after page loaded
        If Size_TurnTable_Changed Then
            g.TranslateTransform(-Image_TurnTable_Dial.Width / 2, -Image_TurnTable_Dial.Width / 2)
            g.RotateTransform(45)
        End If

        ' Set size of turn table image panel and set background image and style
        Image_TurnTable_Dial.Size = New Size((Me.Height) * 9 / 10, (Me.Height) * 9 / 10)
        Image_TurnTable_Dial.Location = New Point((Me.Width - Image_TurnTable_Dial.Width) / 2, (Me.Height - Image_TurnTable_Dial.Height) / 2)
        Image_TurnTable_Dial.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\TurnTable.png")
        Image_TurnTable_Dial.BackgroundImageLayout = BackgroundImageLayout.Zoom

        ' Declare the graphics to be drawn in the turn table image panel
        g = Image_TurnTable_Dial.CreateGraphics
        g2 = Image_TurnTable_Dial.CreateGraphics
        img = Bitmap.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Dial.png")
        img2 = Bitmap.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Dial2.png")

        ' Determine the size of the dial for the turn table image
        r = (Math.Sqrt(2 * ((Image_TurnTable_Dial.Width / 2) ^ 2)) / 2) - (Image_TurnTable_Dial.Width / 52)

        ' Position the dial in the centre of the turn table image
        g.TranslateTransform(Image_TurnTable_Dial.Width / 2, Image_TurnTable_Dial.Height / 2)
        g.RotateTransform(-45)
        g2.TranslateTransform(Image_TurnTable_Dial.Width / 2, Image_TurnTable_Dial.Height / 2)
        g2.RotateTransform(-45)

        ' Turn table image panel text size and style declaration
        Text_TurnTable.Text = Degrees

        ' This seemingly useless if function is here SOLELY to prevent the program from crashing when the form is minimized... comment the function out and run the program if you don't believe me...
        If Image_TurnTable_Dial.Width < 10 Then
            Image_TurnTable_Dial.Width = 10
        End If

        Text_TurnTable.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Image_TurnTable_Dial.Width * 1 / 10), FontStyle.Regular)
        Text_TurnTable.ForeColor = Font_TurnTable_Colour

        ' Turn table button size declaration after page size change
        Button_TurnTable_Size = New Size(Me.Width / 12, Me.Width / 12)

        ' Slow turn counter clockwise (CC) style and size declaration
        Turn_Slow_CC.Size = Button_TurnTable_Size
        Turn_Slow_CC.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 2 / 7 - (Turn_Slow_CC.Width / 2), (Me.Height) * 2 / 7 - Turn_Slow_CC.Height / 2)
        Turn_Slow_CC.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Slow_CC.png")
        Turn_Slow_CC.BackgroundImageLayout = ImageLayout.Zoom
        Turn_Slow_CC.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_Slow_CC.ForeColor = Font_TurnTable_Button_Colour
        Turn_Slow_CC.TextAlign = ContentAlignment.MiddleCenter

        ' Turn 360 counter clockwise (CC) style and size declaration
        Turn_360_CC.Size = Button_TurnTable_Size
        Turn_360_CC.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 5 / 7 - (Turn_Slow_CC.Width / 2), (Me.Height) * 5 / 7 - Turn_360_CC.Height / 2)
        Turn_360_CC.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CC.png")
        Turn_360_CC.BackgroundImageLayout = ImageLayout.Zoom
        Turn_360_CC.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_360_CC.ForeColor = Font_TurnTable_Button_Colour
        Turn_360_CC.TextAlign = ContentAlignment.MiddleCenter

        ' Fast turn counter clockwise (CC) style and size declaration
        Turn_Fast_CC.Size = Button_TurnTable_Size
        Turn_Fast_CC.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 2 / 7 - (Turn_Slow_CC.Width / 2), (Me.Height) * 4 / 7 - Turn_Slow_CC.Height / 2)
        Turn_Fast_CC.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CC.png")
        Turn_Fast_CC.BackgroundImageLayout = ImageLayout.Zoom
        Turn_Fast_CC.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_Fast_CC.ForeColor = Font_TurnTable_Button_Colour
        Turn_Fast_CC.TextAlign = ContentAlignment.MiddleCenter

        ' Turn a fixed step counter clockwise (CC) style and size declaration
        Turn_FixedStep_CC.Size = Button_TurnTable_Size
        Turn_FixedStep_CC.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 5 / 7 - (Turn_Slow_CC.Width / 2), (Me.Height) * 3 / 7 - Turn_Slow_CC.Height / 2)
        Turn_FixedStep_CC.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Slow_CC.png")
        Turn_FixedStep_CC.BackgroundImageLayout = ImageLayout.Zoom
        Turn_FixedStep_CC.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_FixedStep_CC.ForeColor = Font_TurnTable_Button_Colour
        Turn_FixedStep_CC.TextAlign = ContentAlignment.MiddleCenter

        ' Slow turn clockwise (CW) style and size declaration
        Turn_Slow_CW.Size = Button_TurnTable_Size
        Turn_Slow_CW.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 5 / 7 + (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width) - (Turn_Slow_CC.Width / 2), (Me.Height) * 2 / 7 - Turn_Slow_CC.Height / 2)
        Turn_Slow_CW.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Slow_CW.png")
        Turn_Slow_CW.BackgroundImageLayout = ImageLayout.Zoom
        Turn_Slow_CW.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_Slow_CW.ForeColor = Font_TurnTable_Button_Colour
        Turn_Slow_CW.TextAlign = ContentAlignment.MiddleCenter

        ' Turn 360 clockwise (CW) style and size declaration
        Turn_360_CW.Size = Button_TurnTable_Size
        Turn_360_CW.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 2 / 7 + (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width) - (Turn_Slow_CC.Width / 2), (Me.Height) * 5 / 7 - Turn_Slow_CC.Height / 2)
        Turn_360_CW.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CW.png")
        Turn_360_CW.BackgroundImageLayout = ImageLayout.Zoom
        Turn_360_CW.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_360_CW.ForeColor = Font_TurnTable_Button_Colour
        Turn_360_CW.TextAlign = ContentAlignment.MiddleCenter

        ' Fast turn clockwise (CW) style and size declaration
        Turn_Fast_CW.Size = Button_TurnTable_Size
        Turn_Fast_CW.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 5 / 7 + (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width) - (Turn_Slow_CC.Width / 2), (Me.Height) * 4 / 7 - Turn_Slow_CC.Height / 2)
        Turn_Fast_CW.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Fast_CW.png")
        Turn_Fast_CW.BackgroundImageLayout = ImageLayout.Zoom
        Turn_Fast_CW.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_Fast_CW.ForeColor = Font_TurnTable_Button_Colour
        Turn_Fast_CW.TextAlign = ContentAlignment.MiddleCenter

        ' Turn a fixed step clockwise (CW) style and size declaration
        Turn_FixedStep_CW.Size = Button_TurnTable_Size
        Turn_FixedStep_CW.Location = New Point((Me.Width - (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width)) * 2 / 7 + (Image_TurnTable_Dial.Location.X + Image_TurnTable_Dial.Width) - (Turn_Slow_CC.Width / 2), (Me.Height) * 3 / 7 - Turn_Slow_CC.Height / 2)
        Turn_FixedStep_CW.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Turn Table\Slow_CW.png")
        Turn_FixedStep_CW.BackgroundImageLayout = ImageLayout.Zoom
        Turn_FixedStep_CW.Font = New Font(Font_TurnTable_Button, Convert.ToSingle(Turn_Slow_CC.Width * 1 / 5), FontStyle.Regular)
        Turn_FixedStep_CW.ForeColor = Font_TurnTable_Button_Colour
        Turn_FixedStep_CW.TextAlign = ContentAlignment.MiddleCenter

        Size_TurnTable_Changed = True ' Declare that the turn table image has changed in size
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Turn_Slow_CC.Click
        ' Stop the timer if it is currently running or start the timer if it is not currently running
        If Timer1.Enabled Then
            Timer1.Stop()
            g2.DrawImage(img2, 0, 0, r, r)
        Else
            Image_TurnTable_Dial.Refresh()
            Timer1.Start()
        End If
    End Sub

    Dim Degrees As Single = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Draw dial for every tic of the timer.
        g.DrawImage(img, 0, 0, r, r)
        g.RotateTransform(-1 / 5)
        g2.RotateTransform(-1 / 5)

        ' Display degrees on turn table image
        Text_TurnTable.Text = Convert.ToString(Math.Abs(Math.Round(Degrees / 5, 0))) '+ "°"
        Degrees += 1
        If Math.Abs(Degrees / 5) > 360 Then
            Degrees = 0
            Image_TurnTable_Dial.Refresh()
        End If
    End Sub

    Private Sub Text_TurnTable_SizeChanged(sender As Object, e As EventArgs) Handles Text_TurnTable.SizeChanged
        Text_TurnTable.Location = New Point((Image_TurnTable_Dial.Width - Text_TurnTable.Width) / 2, (Image_TurnTable_Dial.Height - Text_TurnTable.Height) / 2)
    End Sub
End Class
