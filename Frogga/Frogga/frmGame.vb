Public Class frmGame
    Dim x, y As Integer
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loading events
        LoadMobs()
        gameTime.Start()
        Lives = 5
    End Sub
    Private Sub frmGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Handles all keypress events
        If e.KeyChar = "`" Then
            'displays list of themes
            input = InputBox("List O' Themes" & vbNewLine & vbNewLine _
                             & "-Classic                                  /classic" & vbNewLine _
                             & "-Classic(Gore Mode)              /classicgore" & vbNewLine _
                             & "-Kunz the Great                     /kunztg" & vbNewLine _
                             & "-Kunz the Noob                     /kunztn" & vbNewLine _
                             & "-Football                                /football" & vbNewLine _
                             & "-Doge                                    /doge" & vbNewLine _
                             & "-Troll Mode                            /troll" & vbNewLine _
                             & "-Space                                  /space" & vbNewLine _
                             & vbNewLine & vbNewLine)
        End If
        'handles movement keys keypress events
        If e.KeyChar = "w" And Player.Top <> 20 Then Player.Top -= 60
        If e.KeyChar = "s" And Player.Top <> 500 Then Player.Top += 60
        If e.KeyChar = "a" And Player.Left <> 17 Then Player.Left -= 60
        If e.KeyChar = "d" And Player.Left <> 617 Then Player.Left += 60
        Label1.Text = Player.Location.X
        Label2.Text = Player.Location.Y

    End Sub
    Private Sub gameTime_Tick(sender As Object, e As EventArgs) Handles gameTime.Tick
        'timer events that handle game control
        MoveMobs()
        CheckHits()
        CheckLogTouch()
        CheckWater()
        If Player.Top = 20 Then
            Player.Location = New Point(317, 500)
            Score += 5
            moveSpeed += 2
        End If
        lblLives.Text = "Lives: " & Lives
        lblScore.Text = "Score: " & Score
    End Sub
End Class