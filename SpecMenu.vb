Public Class SpecMenu
    Public SpecMenuSelected As String = ""
    Public FileLocation As String
    Private Sub SpecMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' New Test Button
        NewTest.Text = ""
        NewTest.BackColor = Color.Transparent
        NewTest.ForeColor = Color.WhiteSmoke
        NewTest.FlatStyle = FlatStyle.Flat
        NewTest.FlatAppearance.BorderSize = 0
        NewTest.FlatAppearance.MouseDownBackColor = Color.Transparent 'Colour_TurnTable_Button_Pressed
        NewTest.FlatAppearance.MouseOverBackColor = Color.Transparent 'Colour_TurnTable_Button_Hover
        NewTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\NewTest_Normal.png")
        NewTest.BackgroundImageLayout = ImageLayout.Zoom

        ' Add Test Button
        AddTest.Text = ""
        AddTest.BackColor = Color.Transparent
        AddTest.ForeColor = Color.WhiteSmoke
        AddTest.FlatStyle = FlatStyle.Flat
        AddTest.FlatAppearance.BorderSize = 0
        AddTest.FlatAppearance.MouseDownBackColor = Color.Transparent 'Colour_TurnTable_Button_Pressed
        AddTest.FlatAppearance.MouseOverBackColor = Color.Transparent 'Colour_TurnTable_Button_Hover
        AddTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\AddTest_Normal.png")
        AddTest.BackgroundImageLayout = ImageLayout.Zoom

    End Sub

    Private Sub SpecMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' New Test Button
        NewTest.Size = New Size(Me.Width / 3, Me.Height * 9 / 10)
        NewTest.Location = New Point((Me.Width - NewTest.Width) * 1 / 6, (Me.Height - NewTest.Height) / 2)

        ' Add Test Button
        AddTest.Size = New Size(Me.Width / 3, Me.Height * 9 / 10)
        AddTest.Location = New Point((Me.Width - NewTest.Width) * 5 / 6, (Me.Height - NewTest.Height) / 2)

    End Sub

    Private Sub NewTest_Click(sender As Object, e As EventArgs) Handles NewTest.Click
        SpecMenuSelected = "NewTest"
        SaveFileDialog1.DefaultExt = ".cfg"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.Filter = "New Test Configuration Files (*.cfg)|*.cfg"
        'SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FileName <> "" Then
                FileLocation = SaveFileDialog1.FileName
                My.Computer.FileSystem.WriteAllText(FileLocation, "First entry of a new test started on: " & vbNewLine & Date.Now & vbNewLine & vbNewLine, True)
            End If
        End If

        Form1.NewTest1.Visible = True
        Form1.NewTest1.BringToFront()
    End Sub

    Private Sub NewTest_MouseEnter(sender As Object, e As EventArgs) Handles NewTest.MouseEnter
        NewTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\NewTest_Hover.png")
    End Sub

    Private Sub NewTest_MouseDown(sender As Object, e As MouseEventArgs) Handles NewTest.MouseDown
        NewTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\NewTest_Pressed.png")
    End Sub

    Private Sub NewTest_MouseLeave(sender As Object, e As EventArgs) Handles NewTest.MouseLeave
        NewTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\NewTest_Normal.png")
    End Sub

    Private Sub NewTest_MouseUp(sender As Object, e As MouseEventArgs) Handles NewTest.MouseUp
        NewTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\NewTest_Hover.png")
    End Sub

    Private Sub AddTest_Click(sender As Object, e As EventArgs) Handles AddTest.Click
        SpecMenuSelected = "AddTest"
        OpenFileDialog1.Filter = "New Test Configuration Files (*.cfg)|*.cfg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileLocation = OpenFileDialog1.FileName
        End If

        Form1.NewTest1.Visible = True
        Form1.NewTest1.BringToFront()
    End Sub

    Private Sub AddTest_MouseDown(sender As Object, e As MouseEventArgs) Handles AddTest.MouseDown
        AddTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\AddTest_Pressed.png")
    End Sub

    Private Sub AddTest_MouseEnter(sender As Object, e As EventArgs) Handles AddTest.MouseEnter
        AddTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\AddTest_Hover.png")
    End Sub

    Private Sub AddTest_MouseLeave(sender As Object, e As EventArgs) Handles AddTest.MouseLeave
        AddTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\AddTest_Normal.png")
    End Sub

    Private Sub AddTest_MouseUp(sender As Object, e As MouseEventArgs) Handles AddTest.MouseUp
        AddTest.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Safety\Documents\VBA Projects\Resources\Rev3\Spectrum Analyzer Menu\AddTest_Hover.png")
    End Sub
End Class
