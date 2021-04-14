Public Class BottomMenu
    ' Button state colour declaration
    ''Dim Button_Normal As Color = Form1.Colour_Menu_Button_Normal
    ''Dim Button_Hover As Color = Form1.Colour_Menu_Button_Normal
    ''Dim Button_Pressed As Color = Form1.Colour_Menu_Button_Normal
    ' Button size declaration
    Dim Button_Size As Size
    ' Button font declaration
    Dim Button_Font As Font = New Font("Ubuntu", 10, FontStyle.Regular)

    Public BotMenuSelected As String = ""

    Private Sub BottomMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Declare flat style and button text
        ' Settings
        Settings.FlatStyle = FlatStyle.Flat
        Settings.FlatAppearance.BorderSize = 0
        ''Settings.FlatAppearance.MouseDownBackColor = Button_Pressed
        ''Settings.FlatAppearance.MouseOverBackColor = Button_Hover
        ''Settings.BackColor = Button_Normal
        Settings.ForeColor = Color.WhiteSmoke
        Settings.Text = "Settings"

        ' About
        About.FlatStyle = FlatStyle.Flat
        About.FlatAppearance.BorderSize = 0
        ''About.FlatAppearance.MouseDownBackColor = Button_Pressed
        ''About.FlatAppearance.MouseOverBackColor = Button_Hover
        ''About.BackColor = Button_Normal
        About.ForeColor = Color.WhiteSmoke
        About.Text = "About"

        ' Help
        Help.FlatStyle = FlatStyle.Flat
        Help.FlatAppearance.BorderSize = 0
        ''Help.FlatAppearance.MouseDownBackColor = Button_Pressed
        ''Help.FlatAppearance.MouseOverBackColor = Button_Hover
        ''Help.BackColor = Button_Normal
        Help.ForeColor = Color.WhiteSmoke
        Help.Text = "Help"

        ' Specs
        Specifications.FlatStyle = FlatStyle.Flat
        Specifications.FlatAppearance.BorderSize = 0
        ''Specifications.FlatAppearance.MouseDownBackColor = Button_Pressed
        ''Specifications.FlatAppearance.MouseOverBackColor = Button_Hover
        ''Specifications.BackColor = Button_Normal
        Specifications.ForeColor = Color.WhiteSmoke
        Specifications.Text = "Specifications"

        ' Powered by iSERT picturebox declaration
        PoweredByiSERT.BackColor = Color.Transparent
        PoweredByiSERT.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Bottom Menu\Powered_by_iSERT.png")
        PoweredByiSERT.BackgroundImageLayout = ImageLayout.Zoom
        PoweredByiSERT.Size = New Size(Me.Width, 20)


    End Sub

    Private Sub BottomMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' Button size, font and location declaration
        ' Variable change on user control size change
        Button_Size = New Size(Me.Width / 4, Me.Height / 2)

        ' Settings
        Settings.Size = Button_Size
        Settings.Font = Button_Font
        Settings.Location = New Point(0, 0)

        ' About
        About.Size = Button_Size
        About.Font = Button_Font
        About.Location = New Point(Settings.Location.X + Settings.Width, 0)

        ' Help
        Help.Size = Button_Size
        Help.Font = Button_Font
        Help.Location = New Point(About.Location.X + About.Width, 0)

        ' Specs
        Specifications.Size = Button_Size
        Specifications.Font = Button_Font
        Specifications.Location = New Point(Help.Location.X + Help.Width, 0)

        PoweredByiSERT.Location = New Point((Me.Width - PoweredByiSERT.Width) / 2, (Me.Height - PoweredByiSERT.Height) * 3 / 4)

    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        BotMenuSelected = "Settings"
        Form1.Settings1.Visible = True
        Form1.Settings1.BringToFront()
        Form1.TopMenu1.Button_Form_GoBack.Visible = True
    End Sub
End Class
