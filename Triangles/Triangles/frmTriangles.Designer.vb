<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriClassifier
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblSide1 = New System.Windows.Forms.Label()
        Me.lblSide2 = New System.Windows.Forms.Label()
        Me.txtS1 = New System.Windows.Forms.TextBox()
        Me.lblSClassTitle = New System.Windows.Forms.Label()
        Me.lblAngleClassTitle = New System.Windows.Forms.Label()
        Me.lblSideClass = New System.Windows.Forms.Label()
        Me.lblAngClass = New System.Windows.Forms.Label()
        Me.txtS2 = New System.Windows.Forms.TextBox()
        Me.txtS3 = New System.Windows.Forms.TextBox()
        Me.lblSide3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(457, 371)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Clos&e"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 315)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 42)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblSide1
        '
        Me.lblSide1.AutoSize = True
        Me.lblSide1.Location = New System.Drawing.Point(24, 30)
        Me.lblSide1.Name = "lblSide1"
        Me.lblSide1.Size = New System.Drawing.Size(40, 13)
        Me.lblSide1.TabIndex = 3
        Me.lblSide1.Text = "Side 1:"
        '
        'lblSide2
        '
        Me.lblSide2.AutoSize = True
        Me.lblSide2.Location = New System.Drawing.Point(132, 30)
        Me.lblSide2.Name = "lblSide2"
        Me.lblSide2.Size = New System.Drawing.Size(40, 13)
        Me.lblSide2.TabIndex = 4
        Me.lblSide2.Text = "Side 2:"
        '
        'txtS1
        '
        Me.txtS1.Location = New System.Drawing.Point(27, 67)
        Me.txtS1.Name = "txtS1"
        Me.txtS1.Size = New System.Drawing.Size(66, 20)
        Me.txtS1.TabIndex = 5
        '
        'lblSClassTitle
        '
        Me.lblSClassTitle.AutoSize = True
        Me.lblSClassTitle.Location = New System.Drawing.Point(24, 184)
        Me.lblSClassTitle.Name = "lblSClassTitle"
        Me.lblSClassTitle.Size = New System.Drawing.Size(95, 13)
        Me.lblSClassTitle.TabIndex = 6
        Me.lblSClassTitle.Text = "Side Classification:"
        '
        'lblAngleClassTitle
        '
        Me.lblAngleClassTitle.AutoSize = True
        Me.lblAngleClassTitle.Location = New System.Drawing.Point(24, 228)
        Me.lblAngleClassTitle.Name = "lblAngleClassTitle"
        Me.lblAngleClassTitle.Size = New System.Drawing.Size(101, 13)
        Me.lblAngleClassTitle.TabIndex = 7
        Me.lblAngleClassTitle.Text = "Angle Classification:"
        '
        'lblSideClass
        '
        Me.lblSideClass.AutoSize = True
        Me.lblSideClass.Location = New System.Drawing.Point(147, 184)
        Me.lblSideClass.Name = "lblSideClass"
        Me.lblSideClass.Size = New System.Drawing.Size(16, 13)
        Me.lblSideClass.TabIndex = 8
        Me.lblSideClass.Text = "---"
        '
        'lblAngClass
        '
        Me.lblAngClass.AutoSize = True
        Me.lblAngClass.Location = New System.Drawing.Point(147, 228)
        Me.lblAngClass.Name = "lblAngClass"
        Me.lblAngClass.Size = New System.Drawing.Size(16, 13)
        Me.lblAngClass.TabIndex = 9
        Me.lblAngClass.Text = "---"
        '
        'txtS2
        '
        Me.txtS2.Location = New System.Drawing.Point(135, 67)
        Me.txtS2.Name = "txtS2"
        Me.txtS2.Size = New System.Drawing.Size(66, 20)
        Me.txtS2.TabIndex = 10
        '
        'txtS3
        '
        Me.txtS3.Location = New System.Drawing.Point(243, 67)
        Me.txtS3.Name = "txtS3"
        Me.txtS3.Size = New System.Drawing.Size(66, 20)
        Me.txtS3.TabIndex = 11
        '
        'lblSide3
        '
        Me.lblSide3.AutoSize = True
        Me.lblSide3.Location = New System.Drawing.Point(240, 30)
        Me.lblSide3.Name = "lblSide3"
        Me.lblSide3.Size = New System.Drawing.Size(40, 13)
        Me.lblSide3.TabIndex = 12
        Me.lblSide3.Text = "Side 3:"
        '
        'frmTriClassifier
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 406)
        Me.Controls.Add(Me.lblSide3)
        Me.Controls.Add(Me.txtS3)
        Me.Controls.Add(Me.txtS2)
        Me.Controls.Add(Me.lblAngClass)
        Me.Controls.Add(Me.lblSideClass)
        Me.Controls.Add(Me.lblAngleClassTitle)
        Me.Controls.Add(Me.lblSClassTitle)
        Me.Controls.Add(Me.txtS1)
        Me.Controls.Add(Me.lblSide2)
        Me.Controls.Add(Me.lblSide1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "frmTriClassifier"
        Me.Text = "Triangle Classifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblSide1 As System.Windows.Forms.Label
    Friend WithEvents lblSide2 As System.Windows.Forms.Label
    Friend WithEvents txtS1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSClassTitle As System.Windows.Forms.Label
    Friend WithEvents lblAngleClassTitle As System.Windows.Forms.Label
    Friend WithEvents lblSideClass As System.Windows.Forms.Label
    Friend WithEvents lblAngClass As System.Windows.Forms.Label
    Friend WithEvents txtS2 As System.Windows.Forms.TextBox
    Friend WithEvents txtS3 As System.Windows.Forms.TextBox
    Friend WithEvents lblSide3 As System.Windows.Forms.Label

End Class
