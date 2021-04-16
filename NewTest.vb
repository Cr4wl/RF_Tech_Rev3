Public Class NewTest
    Dim CFGText As String

    Dim pageFont As FontFamily = New FontFamily("Ubuntu")

    Dim buttonBackColour = Color.Transparent
    Dim buttonHoverColour = Color.FromArgb(36, 163, 216)
    Dim buttonPressColour = Color.FromArgb(16, 143, 196)
    Dim buttonBorderColour = Color.FromArgb(36, 163, 216)
    Dim buttonErrorColour = Color.IndianRed
    Dim buttonErrorHoverColour = Color.IndianRed
    Dim buttonErrorPressColour = Color.DarkRed
    Dim fontNormalColour = Color.FromArgb(36, 163, 216)
    Dim fontPressColour = Color.WhiteSmoke
    Dim buttonBorderSize = 1
    Dim buttonSize As Size
    Dim buttonLocation(3, 3) As Point
    Dim buttongap As Single = 20
    Dim widthDiv1 As Single = 3 / 16
    Dim widthDiv2 As Single = 8 / 16
    Dim widthDiv3 As Single = 13 / 16
    Dim heightDiv1 As Single = 3 / 16
    Dim heightDiv2 As Single = 8 / 16
    Dim heightDiv3 As Single = 13 / 16
    Dim specs() As Button
    Dim specNames() As String = {"ETSI EN 300220", "ETSI EN 300330", "ETSI EN 300440", "ETSI EN 300328", "ETSI EN 301489", "ETSI EN 301893", "ETSI EN 301511", "ETSI EN 301908", "Proceed"}
    Dim specIter As Integer = 0

    Private Sub NewTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        specs = {ETSI_EN_300220, ETSI_EN_300330, ETSI_EN_300440, ETSI_EN_300328, ETSI_EN_301489, ETSI_EN_301893, ETSI_EN_301511, ETSI_EN_301908, Proceed}

        For Each button As Button In Me.Controls.OfType(Of Button)
            specs(specIter).Text = specNames(specIter)
            button.BackColor = buttonBackColour
            button.ForeColor = fontNormalColour
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.MouseOverBackColor = buttonHoverColour
            button.FlatAppearance.MouseDownBackColor = buttonPressColour
            button.FlatAppearance.BorderColor = buttonBorderColour
            button.FlatAppearance.BorderSize = buttonBorderSize
            specIter += 1
        Next
    End Sub

    Private Sub NewTest_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' Buttons Size and Location
        buttonSize = New Size(Me.Width * 30 / 100, Me.Height * 28 / 100)

        buttonLocation(0, 0) = New Point(Me.Width * widthDiv1 - buttonSize.Width / 2, Me.Height * heightDiv1 - buttonSize.Height / 2)
        buttonLocation(0, 1) = New Point(Me.Width * widthDiv2 - buttonSize.Width / 2, Me.Height * heightDiv1 - buttonSize.Height / 2)
        buttonLocation(0, 2) = New Point(Me.Width * widthDiv3 - buttonSize.Width / 2, Me.Height * heightDiv1 - buttonSize.Height / 2)
        buttonLocation(1, 0) = New Point(Me.Width * widthDiv1 - buttonSize.Width / 2, Me.Height * heightDiv2 - buttonSize.Height / 2)
        buttonLocation(1, 1) = New Point(Me.Width * widthDiv2 - buttonSize.Width / 2, Me.Height * heightDiv2 - buttonSize.Height / 2)
        buttonLocation(1, 2) = New Point(Me.Width * widthDiv3 - buttonSize.Width / 2, Me.Height * heightDiv2 - buttonSize.Height / 2)
        buttonLocation(2, 0) = New Point(Me.Width * widthDiv1 - buttonSize.Width / 2, Me.Height * heightDiv3 - buttonSize.Height / 2)
        buttonLocation(2, 1) = New Point(Me.Width * widthDiv2 - buttonSize.Width / 2, Me.Height * heightDiv3 - buttonSize.Height / 2)
        buttonLocation(2, 2) = New Point(Me.Width * widthDiv3 - buttonSize.Width / 2, Me.Height * heightDiv3 - buttonSize.Height / 2)

        ' ETSI EN 300 220 Button Size and Location
        ETSI_EN_300220.Size = buttonSize
        ETSI_EN_300220.Location = buttonLocation(0, 0)
        ' ETSI EN 300 330 Button Size and Location
        ETSI_EN_300330.Size = buttonSize
        ETSI_EN_300330.Location = buttonLocation(1, 0)
        ' ETSI EN 300 440 Button Size and Location
        ETSI_EN_300440.Size = buttonSize
        ETSI_EN_300440.Location = buttonLocation(2, 0)

        ' ETSI EN 300 328 Button Size and Location
        ETSI_EN_300328.Size = buttonSize
        ETSI_EN_300328.Location = buttonLocation(0, 1)
        ' ETSI EN 301 489 Button Size and Location
        ETSI_EN_301489.Size = buttonSize
        ETSI_EN_301489.Location = buttonLocation(1, 1)
        ' ETSI EN 301 893 Button Size and Location
        ETSI_EN_301893.Size = buttonSize
        ETSI_EN_301893.Location = buttonLocation(2, 1)

        ' ETSI EN 301 511 Button Size and Location
        ETSI_EN_301511.Size = buttonSize
        ETSI_EN_301511.Location = buttonLocation(0, 2)
        ' ETSI EN 301 511 Button Size and Location
        ETSI_EN_301908.Size = buttonSize
        ETSI_EN_301908.Location = buttonLocation(1, 2)
        ' Button 9 Size and Location
        Proceed.Size = buttonSize
        Proceed.Location = buttonLocation(2, 2)

        For Each button As Button In Me.Controls.OfType(Of Button)
            button.Font = New Font(pageFont, Convert.ToSingle(button.Height / 5), FontStyle.Regular)
        Next
    End Sub

    Private Sub ETSI_EN_300220_Click(sender As Object, e As EventArgs) Handles ETSI_EN_300220.Click
        If ETSI_EN_300220.BackColor = buttonBackColour Then
            ETSI_EN_300220.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 300220" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_300220.BackColor = buttonErrorColour
                ETSI_EN_300220.FlatAppearance.BorderSize = 1
                ETSI_EN_300220.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_300220.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_300220.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_300220.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_300220.BackColor = buttonPressColour Then
            ETSI_EN_300220.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 300220" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_300220_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_300220.MouseEnter
        ETSI_EN_300220.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_300220_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_300220.MouseLeave
        If ETSI_EN_300220.BackColor = buttonBackColour Then
            ETSI_EN_300220.ForeColor = fontNormalColour
        ElseIf ETSI_EN_300220.BackColor = buttonPressColour Then
            ETSI_EN_300220.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub ETSI_EN_300330_Click(sender As Object, e As EventArgs) Handles ETSI_EN_300330.Click
        If ETSI_EN_300330.BackColor = buttonBackColour Then
            ETSI_EN_300330.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 300330" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_300330.BackColor = buttonErrorColour
                ETSI_EN_300330.FlatAppearance.BorderSize = 1
                ETSI_EN_300330.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_300330.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_300330.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_300330.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_300330.BackColor = buttonPressColour Then
            ETSI_EN_300330.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 300330" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_300330_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_300330.MouseEnter
        ETSI_EN_300330.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_300330_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_300330.MouseLeave
        If ETSI_EN_300330.BackColor = buttonBackColour Then
            ETSI_EN_300330.ForeColor = fontNormalColour
        ElseIf ETSI_EN_300330.BackColor = buttonPressColour Then
            ETSI_EN_300330.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub ETSI_EN_300440_Click(sender As Object, e As EventArgs) Handles ETSI_EN_300440.Click
        If ETSI_EN_300440.BackColor = buttonBackColour Then
            ETSI_EN_300440.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 300440" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_300440.BackColor = buttonErrorColour
                ETSI_EN_300440.FlatAppearance.BorderSize = 1
                ETSI_EN_300440.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_300440.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_300440.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_300440.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_300440.BackColor = buttonPressColour Then
            ETSI_EN_300440.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 300440" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_300440_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_300440.MouseEnter
        ETSI_EN_300440.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_300440_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_300440.MouseLeave
        If ETSI_EN_300440.BackColor = buttonBackColour Then
            ETSI_EN_300440.ForeColor = fontNormalColour
        ElseIf ETSI_EN_300440.BackColor = buttonPressColour Then
            ETSI_EN_300440.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub ETSI_EN_300328_Click(sender As Object, e As EventArgs) Handles ETSI_EN_300328.Click
        If ETSI_EN_300328.BackColor = buttonBackColour Then
            ETSI_EN_300328.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 300328" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_300328.BackColor = buttonErrorColour
                ETSI_EN_300328.FlatAppearance.BorderSize = 1
                ETSI_EN_300328.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_300328.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_300328.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_300328.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_300328.BackColor = buttonPressColour Then
            ETSI_EN_300328.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 300328" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_300328_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_300328.MouseEnter
        ETSI_EN_300328.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_300328_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_300328.MouseLeave
        If ETSI_EN_300328.BackColor = buttonBackColour Then
            ETSI_EN_300328.ForeColor = fontNormalColour
        ElseIf ETSI_EN_300328.BackColor = buttonPressColour Then
            ETSI_EN_300328.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub ETSI_EN_301489_Click(sender As Object, e As EventArgs) Handles ETSI_EN_301489.Click
        If ETSI_EN_301489.BackColor = buttonBackColour Then
            ETSI_EN_301489.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 301489" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_301489.BackColor = buttonErrorColour
                ETSI_EN_301489.FlatAppearance.BorderSize = 1
                ETSI_EN_301489.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_301489.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_301489.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_301489.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_301489.BackColor = buttonPressColour Then
            ETSI_EN_301489.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 301489" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_301489_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_301489.MouseEnter
        ETSI_EN_301489.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_301489_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_301489.MouseLeave
        If ETSI_EN_301489.BackColor = buttonBackColour Then
            ETSI_EN_301489.ForeColor = fontNormalColour
        ElseIf ETSI_EN_301489.BackColor = buttonPressColour Then
            ETSI_EN_301489.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub ETSI_EN_301893_Click(sender As Object, e As EventArgs) Handles ETSI_EN_301893.Click
        If ETSI_EN_301893.BackColor = buttonBackColour Then
            ETSI_EN_301893.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 301893" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_301893.BackColor = buttonErrorColour
                ETSI_EN_301893.FlatAppearance.BorderSize = 1
                ETSI_EN_301893.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_301893.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_301893.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_301893.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_301893.BackColor = buttonPressColour Then
            ETSI_EN_301893.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 301893" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_301893_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_301893.MouseEnter
        ETSI_EN_301893.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_301893_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_301893.MouseLeave
        If ETSI_EN_301893.BackColor = buttonBackColour Then
            ETSI_EN_301893.ForeColor = fontNormalColour
        ElseIf ETSI_EN_301893.BackColor = buttonPressColour Then
            ETSI_EN_301893.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub ETSI_EN_301511_Click(sender As Object, e As EventArgs) Handles ETSI_EN_301511.Click
        If ETSI_EN_301511.BackColor = buttonBackColour Then
            ETSI_EN_301511.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 301511" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_301511.BackColor = buttonErrorColour
                ETSI_EN_301511.FlatAppearance.BorderSize = 1
                ETSI_EN_301511.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_301511.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_301511.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_301511.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_301511.BackColor = buttonPressColour Then
            ETSI_EN_301511.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 301511" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_301511_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_301511.MouseEnter
        ETSI_EN_301511.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_301511_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_301511.MouseLeave
        If ETSI_EN_301511.BackColor = buttonBackColour Then
            ETSI_EN_301511.ForeColor = fontNormalColour
        ElseIf ETSI_EN_301511.BackColor = buttonPressColour Then
            ETSI_EN_301511.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub ETSI_EN_301908_Click(sender As Object, e As EventArgs) Handles ETSI_EN_301908.Click
        If ETSI_EN_301908.BackColor = buttonBackColour Then
            ETSI_EN_301908.BackColor = buttonPressColour

            Try
                My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, "ETSI EN 301908" & vbNewLine, True)
            Catch ex As Exception
                ETSI_EN_301908.BackColor = buttonErrorColour
                ETSI_EN_301908.FlatAppearance.BorderSize = 1
                ETSI_EN_301908.FlatAppearance.BorderColor = buttonErrorColour
                ETSI_EN_301908.FlatAppearance.MouseDownBackColor = buttonErrorPressColour
                ETSI_EN_301908.FlatAppearance.MouseOverBackColor = buttonErrorHoverColour
                ETSI_EN_301908.Text = "Incorrect File Location"
            End Try

        ElseIf ETSI_EN_301908.BackColor = buttonPressColour Then
            ETSI_EN_301908.BackColor = buttonBackColour
            CFGText = My.Computer.FileSystem.ReadAllText(Form1.SpecMenu1.FileLocation)
            CFGText = CFGText.Replace("ETSI EN 301908" & vbNewLine, "")
            My.Computer.FileSystem.WriteAllText(Form1.SpecMenu1.FileLocation, CFGText, False)
        End If

    End Sub

    Private Sub ETSI_EN_301908_MouseEnter(sender As Object, e As EventArgs) Handles ETSI_EN_301908.MouseEnter
        ETSI_EN_301908.ForeColor = fontPressColour
    End Sub

    Private Sub ETSI_EN_301908_MouseLeave(sender As Object, e As EventArgs) Handles ETSI_EN_301908.MouseLeave
        If ETSI_EN_301908.BackColor = buttonBackColour Then
            ETSI_EN_301908.ForeColor = fontNormalColour
        ElseIf ETSI_EN_301908.BackColor = buttonPressColour Then
            ETSI_EN_301908.ForeColor = fontPressColour
        End If
    End Sub

    Private Sub Proceed_Click(sender As Object, e As EventArgs) Handles Proceed.Click

    End Sub

    Private Sub Proceed_MouseEnter(sender As Object, e As EventArgs) Handles Proceed.MouseEnter
        Proceed.ForeColor = fontPressColour
    End Sub

    Private Sub Proceed_MouseLeave(sender As Object, e As EventArgs) Handles Proceed.MouseLeave
        Proceed.ForeColor = fontNormalColour
    End Sub
End Class
