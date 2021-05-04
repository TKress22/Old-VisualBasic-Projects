<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameSetupScreen
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
        Me.nudPlayerNum = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtP1Name = New System.Windows.Forms.TextBox()
        Me.txtP2Name = New System.Windows.Forms.TextBox()
        Me.txtP3Name = New System.Windows.Forms.TextBox()
        Me.txtP4Name = New System.Windows.Forms.TextBox()
        Me.lblP1Ti = New System.Windows.Forms.Label()
        Me.lblP2Ti = New System.Windows.Forms.Label()
        Me.lblP3Ti = New System.Windows.Forms.Label()
        Me.lblP4Ti = New System.Windows.Forms.Label()
        Me.btnCommence = New System.Windows.Forms.Button()
        CType(Me.nudPlayerNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudPlayerNum
        '
        Me.nudPlayerNum.Location = New System.Drawing.Point(163, 36)
        Me.nudPlayerNum.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudPlayerNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPlayerNum.Name = "nudPlayerNum"
        Me.nudPlayerNum.Size = New System.Drawing.Size(31, 20)
        Me.nudPlayerNum.TabIndex = 0
        Me.nudPlayerNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number O' Players"
        '
        'txtP1Name
        '
        Me.txtP1Name.Location = New System.Drawing.Point(94, 78)
        Me.txtP1Name.Name = "txtP1Name"
        Me.txtP1Name.Size = New System.Drawing.Size(100, 20)
        Me.txtP1Name.TabIndex = 2
        Me.txtP1Name.Text = "Player 1"
        '
        'txtP2Name
        '
        Me.txtP2Name.Location = New System.Drawing.Point(94, 104)
        Me.txtP2Name.Name = "txtP2Name"
        Me.txtP2Name.Size = New System.Drawing.Size(100, 20)
        Me.txtP2Name.TabIndex = 3
        Me.txtP2Name.Text = "Player 2"
        Me.txtP2Name.Visible = False
        '
        'txtP3Name
        '
        Me.txtP3Name.Location = New System.Drawing.Point(94, 130)
        Me.txtP3Name.Name = "txtP3Name"
        Me.txtP3Name.Size = New System.Drawing.Size(100, 20)
        Me.txtP3Name.TabIndex = 4
        Me.txtP3Name.Text = "Player 3"
        Me.txtP3Name.Visible = False
        '
        'txtP4Name
        '
        Me.txtP4Name.Location = New System.Drawing.Point(94, 156)
        Me.txtP4Name.Name = "txtP4Name"
        Me.txtP4Name.Size = New System.Drawing.Size(100, 20)
        Me.txtP4Name.TabIndex = 5
        Me.txtP4Name.Text = "Player 4"
        Me.txtP4Name.Visible = False
        '
        'lblP1Ti
        '
        Me.lblP1Ti.AutoSize = True
        Me.lblP1Ti.Location = New System.Drawing.Point(12, 81)
        Me.lblP1Ti.Name = "lblP1Ti"
        Me.lblP1Ti.Size = New System.Drawing.Size(45, 13)
        Me.lblP1Ti.TabIndex = 6
        Me.lblP1Ti.Text = "Player 1"
        '
        'lblP2Ti
        '
        Me.lblP2Ti.AutoSize = True
        Me.lblP2Ti.Location = New System.Drawing.Point(12, 107)
        Me.lblP2Ti.Name = "lblP2Ti"
        Me.lblP2Ti.Size = New System.Drawing.Size(45, 13)
        Me.lblP2Ti.TabIndex = 7
        Me.lblP2Ti.Text = "Player 2"
        Me.lblP2Ti.Visible = False
        '
        'lblP3Ti
        '
        Me.lblP3Ti.AutoSize = True
        Me.lblP3Ti.Location = New System.Drawing.Point(12, 133)
        Me.lblP3Ti.Name = "lblP3Ti"
        Me.lblP3Ti.Size = New System.Drawing.Size(45, 13)
        Me.lblP3Ti.TabIndex = 8
        Me.lblP3Ti.Text = "Player 3"
        Me.lblP3Ti.Visible = False
        '
        'lblP4Ti
        '
        Me.lblP4Ti.AutoSize = True
        Me.lblP4Ti.Location = New System.Drawing.Point(12, 159)
        Me.lblP4Ti.Name = "lblP4Ti"
        Me.lblP4Ti.Size = New System.Drawing.Size(45, 13)
        Me.lblP4Ti.TabIndex = 9
        Me.lblP4Ti.Text = "Player 4"
        Me.lblP4Ti.Visible = False
        '
        'btnCommence
        '
        Me.btnCommence.Location = New System.Drawing.Point(15, 190)
        Me.btnCommence.Name = "btnCommence"
        Me.btnCommence.Size = New System.Drawing.Size(179, 23)
        Me.btnCommence.TabIndex = 10
        Me.btnCommence.Text = "Commence!"
        Me.btnCommence.UseVisualStyleBackColor = True
        '
        'GameSetupScreen
        '
        Me.AcceptButton = Me.btnCommence
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 225)
        Me.Controls.Add(Me.btnCommence)
        Me.Controls.Add(Me.lblP4Ti)
        Me.Controls.Add(Me.lblP3Ti)
        Me.Controls.Add(Me.lblP2Ti)
        Me.Controls.Add(Me.lblP1Ti)
        Me.Controls.Add(Me.txtP4Name)
        Me.Controls.Add(Me.txtP3Name)
        Me.Controls.Add(Me.txtP2Name)
        Me.Controls.Add(Me.txtP1Name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudPlayerNum)
        Me.Name = "GameSetupScreen"
        Me.Text = "Game Setup"
        CType(Me.nudPlayerNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudPlayerNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtP1Name As System.Windows.Forms.TextBox
    Friend WithEvents txtP2Name As System.Windows.Forms.TextBox
    Friend WithEvents txtP3Name As System.Windows.Forms.TextBox
    Friend WithEvents txtP4Name As System.Windows.Forms.TextBox
    Friend WithEvents lblP1Ti As System.Windows.Forms.Label
    Friend WithEvents lblP2Ti As System.Windows.Forms.Label
    Friend WithEvents lblP3Ti As System.Windows.Forms.Label
    Friend WithEvents lblP4Ti As System.Windows.Forms.Label
    Friend WithEvents btnCommence As System.Windows.Forms.Button
End Class
