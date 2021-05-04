<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.C1R1R = New System.Windows.Forms.PictureBox()
        Me.C2R1R = New System.Windows.Forms.PictureBox()
        Me.C2R2L = New System.Windows.Forms.PictureBox()
        Me.C1R2L = New System.Windows.Forms.PictureBox()
        Me.C1R3R = New System.Windows.Forms.PictureBox()
        Me.C2R3R = New System.Windows.Forms.PictureBox()
        Me.C2R4L = New System.Windows.Forms.PictureBox()
        Me.C1R4L = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gameTime = New System.Windows.Forms.Timer(Me.components)
        Me.pbroad = New System.Windows.Forms.PictureBox()
        Me.River = New System.Windows.Forms.PictureBox()
        Me.LG1R5 = New System.Windows.Forms.PictureBox()
        Me.LG2R5 = New System.Windows.Forms.PictureBox()
        Me.LG2R6 = New System.Windows.Forms.PictureBox()
        Me.LG1R6 = New System.Windows.Forms.PictureBox()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1R1R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2R1R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2R2L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1R2L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1R3R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2R3R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2R4L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1R4L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbroad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.River, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LG1R5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LG2R5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LG2R6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LG1R6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Green
        Me.Player.Location = New System.Drawing.Point(317, 500)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(50, 50)
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'C1R1R
        '
        Me.C1R1R.BackColor = System.Drawing.Color.Maroon
        Me.C1R1R.Location = New System.Drawing.Point(25, 440)
        Me.C1R1R.Name = "C1R1R"
        Me.C1R1R.Size = New System.Drawing.Size(65, 50)
        Me.C1R1R.TabIndex = 1
        Me.C1R1R.TabStop = False
        '
        'C2R1R
        '
        Me.C2R1R.BackColor = System.Drawing.Color.Maroon
        Me.C2R1R.Location = New System.Drawing.Point(379, 440)
        Me.C2R1R.Name = "C2R1R"
        Me.C2R1R.Size = New System.Drawing.Size(65, 50)
        Me.C2R1R.TabIndex = 2
        Me.C2R1R.TabStop = False
        '
        'C2R2L
        '
        Me.C2R2L.BackColor = System.Drawing.Color.Navy
        Me.C2R2L.Location = New System.Drawing.Point(453, 384)
        Me.C2R2L.Name = "C2R2L"
        Me.C2R2L.Size = New System.Drawing.Size(65, 50)
        Me.C2R2L.TabIndex = 3
        Me.C2R2L.TabStop = False
        '
        'C1R2L
        '
        Me.C1R2L.BackColor = System.Drawing.Color.Navy
        Me.C1R2L.Location = New System.Drawing.Point(41, 384)
        Me.C1R2L.Name = "C1R2L"
        Me.C1R2L.Size = New System.Drawing.Size(65, 50)
        Me.C1R2L.TabIndex = 4
        Me.C1R2L.TabStop = False
        '
        'C1R3R
        '
        Me.C1R3R.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.C1R3R.Location = New System.Drawing.Point(41, 320)
        Me.C1R3R.Name = "C1R3R"
        Me.C1R3R.Size = New System.Drawing.Size(65, 50)
        Me.C1R3R.TabIndex = 6
        Me.C1R3R.TabStop = False
        '
        'C2R3R
        '
        Me.C2R3R.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.C2R3R.Location = New System.Drawing.Point(336, 320)
        Me.C2R3R.Name = "C2R3R"
        Me.C2R3R.Size = New System.Drawing.Size(65, 50)
        Me.C2R3R.TabIndex = 5
        Me.C2R3R.TabStop = False
        '
        'C2R4L
        '
        Me.C2R4L.BackColor = System.Drawing.Color.Maroon
        Me.C2R4L.Location = New System.Drawing.Point(547, 260)
        Me.C2R4L.Name = "C2R4L"
        Me.C2R4L.Size = New System.Drawing.Size(65, 50)
        Me.C2R4L.TabIndex = 8
        Me.C2R4L.TabStop = False
        '
        'C1R4L
        '
        Me.C1R4L.BackColor = System.Drawing.Color.Maroon
        Me.C1R4L.Location = New System.Drawing.Point(180, 260)
        Me.C1R4L.Name = "C1R4L"
        Me.C1R4L.Size = New System.Drawing.Size(65, 50)
        Me.C1R4L.TabIndex = 7
        Me.C1R4L.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(612, 595)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(612, 618)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 10
        '
        'gameTime
        '
        Me.gameTime.Enabled = True
        '
        'pbroad
        '
        Me.pbroad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbroad.Location = New System.Drawing.Point(1, 250)
        Me.pbroad.Name = "pbroad"
        Me.pbroad.Size = New System.Drawing.Size(700, 250)
        Me.pbroad.TabIndex = 11
        Me.pbroad.TabStop = False
        '
        'River
        '
        Me.River.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.River.Location = New System.Drawing.Point(1, 72)
        Me.River.Name = "River"
        Me.River.Size = New System.Drawing.Size(700, 124)
        Me.River.TabIndex = 12
        Me.River.TabStop = False
        '
        'LG1R5
        '
        Me.LG1R5.BackColor = System.Drawing.Color.Sienna
        Me.LG1R5.Location = New System.Drawing.Point(160, 140)
        Me.LG1R5.Name = "LG1R5"
        Me.LG1R5.Size = New System.Drawing.Size(125, 50)
        Me.LG1R5.TabIndex = 13
        Me.LG1R5.TabStop = False
        '
        'LG2R5
        '
        Me.LG2R5.BackColor = System.Drawing.Color.Sienna
        Me.LG2R5.Location = New System.Drawing.Point(547, 140)
        Me.LG2R5.Name = "LG2R5"
        Me.LG2R5.Size = New System.Drawing.Size(125, 50)
        Me.LG2R5.TabIndex = 14
        Me.LG2R5.TabStop = False
        '
        'LG2R6
        '
        Me.LG2R6.BackColor = System.Drawing.Color.Sienna
        Me.LG2R6.Location = New System.Drawing.Point(379, 80)
        Me.LG2R6.Name = "LG2R6"
        Me.LG2R6.Size = New System.Drawing.Size(125, 50)
        Me.LG2R6.TabIndex = 16
        Me.LG2R6.TabStop = False
        '
        'LG1R6
        '
        Me.LG1R6.BackColor = System.Drawing.Color.Sienna
        Me.LG1R6.Location = New System.Drawing.Point(29, 80)
        Me.LG1R6.Name = "LG1R6"
        Me.LG1R6.Size = New System.Drawing.Size(125, 50)
        Me.LG1R6.TabIndex = 15
        Me.LG1R6.TabStop = False
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Location = New System.Drawing.Point(22, 517)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(38, 13)
        Me.lblLives.TabIndex = 17
        Me.lblLives.Text = "Lives: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(22, 540)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(41, 13)
        Me.lblScore.TabIndex = 18
        Me.lblScore.Text = "Score: "
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(684, 562)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.LG2R6)
        Me.Controls.Add(Me.LG1R6)
        Me.Controls.Add(Me.LG2R5)
        Me.Controls.Add(Me.LG1R5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C2R4L)
        Me.Controls.Add(Me.C1R4L)
        Me.Controls.Add(Me.C1R3R)
        Me.Controls.Add(Me.C2R3R)
        Me.Controls.Add(Me.C1R2L)
        Me.Controls.Add(Me.C2R2L)
        Me.Controls.Add(Me.C2R1R)
        Me.Controls.Add(Me.C1R1R)
        Me.Controls.Add(Me.pbroad)
        Me.Controls.Add(Me.River)
        Me.KeyPreview = True
        Me.Name = "frmGame"
        Me.Text = "Frogga"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1R1R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2R1R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2R2L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1R2L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1R3R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2R3R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2R4L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1R4L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbroad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.River, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LG1R5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LG2R5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LG2R6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LG1R6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Player As System.Windows.Forms.PictureBox
    Friend WithEvents C1R1R As System.Windows.Forms.PictureBox
    Friend WithEvents C2R1R As System.Windows.Forms.PictureBox
    Friend WithEvents C2R2L As System.Windows.Forms.PictureBox
    Friend WithEvents C1R2L As System.Windows.Forms.PictureBox
    Friend WithEvents C1R3R As System.Windows.Forms.PictureBox
    Friend WithEvents C2R3R As System.Windows.Forms.PictureBox
    Friend WithEvents C2R4L As System.Windows.Forms.PictureBox
    Friend WithEvents C1R4L As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gameTime As System.Windows.Forms.Timer
    Friend WithEvents pbroad As System.Windows.Forms.PictureBox
    Friend WithEvents River As System.Windows.Forms.PictureBox
    Friend WithEvents LG1R5 As System.Windows.Forms.PictureBox
    Friend WithEvents LG2R5 As System.Windows.Forms.PictureBox
    Friend WithEvents LG2R6 As System.Windows.Forms.PictureBox
    Friend WithEvents LG1R6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label

End Class
