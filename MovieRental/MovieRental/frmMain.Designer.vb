<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.rdb2Day = New System.Windows.Forms.RadioButton()
        Me.rdb5Day = New System.Windows.Forms.RadioButton()
        Me.rdb7Day = New System.Windows.Forms.RadioButton()
        Me.lstMovSel = New System.Windows.Forms.ListBox()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.cmbGen = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnRem = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdb2Day
        '
        Me.rdb2Day.AutoSize = True
        Me.rdb2Day.Enabled = False
        Me.rdb2Day.Location = New System.Drawing.Point(24, 13)
        Me.rdb2Day.Name = "rdb2Day"
        Me.rdb2Day.Size = New System.Drawing.Size(184, 17)
        Me.rdb2Day.TabIndex = 1
        Me.rdb2Day.TabStop = True
        Me.rdb2Day.Text = "2 Day Rental (New Release Only)"
        Me.rdb2Day.UseVisualStyleBackColor = True
        '
        'rdb5Day
        '
        Me.rdb5Day.AutoSize = True
        Me.rdb5Day.Location = New System.Drawing.Point(24, 57)
        Me.rdb5Day.Name = "rdb5Day"
        Me.rdb5Day.Size = New System.Drawing.Size(87, 17)
        Me.rdb5Day.TabIndex = 2
        Me.rdb5Day.TabStop = True
        Me.rdb5Day.Text = "5 Day Rental"
        Me.rdb5Day.UseVisualStyleBackColor = True
        '
        'rdb7Day
        '
        Me.rdb7Day.AutoSize = True
        Me.rdb7Day.Location = New System.Drawing.Point(24, 101)
        Me.rdb7Day.Name = "rdb7Day"
        Me.rdb7Day.Size = New System.Drawing.Size(87, 17)
        Me.rdb7Day.TabIndex = 3
        Me.rdb7Day.TabStop = True
        Me.rdb7Day.Text = "7 Day Rental"
        Me.rdb7Day.UseVisualStyleBackColor = True
        '
        'lstMovSel
        '
        Me.lstMovSel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMovSel.FormattingEnabled = True
        Me.lstMovSel.Location = New System.Drawing.Point(181, 57)
        Me.lstMovSel.Name = "lstMovSel"
        Me.lstMovSel.Size = New System.Drawing.Size(271, 95)
        Me.lstMovSel.TabIndex = 4
        '
        'lstCart
        '
        Me.lstCart.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 19
        Me.lstCart.Location = New System.Drawing.Point(12, 244)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(456, 99)
        Me.lstCart.TabIndex = 5
        '
        'cmbGen
        '
        Me.cmbGen.FormattingEnabled = True
        Me.cmbGen.Items.AddRange(New Object() {"Action/Adventure", "Classic", "Comedy", "Drama/Romance", "Horror", "Musical", "Suspense", "New Release"})
        Me.cmbGen.Location = New System.Drawing.Point(259, 12)
        Me.cmbGen.Name = "cmbGen"
        Me.cmbGen.Size = New System.Drawing.Size(193, 21)
        Me.cmbGen.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(59, 175)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Selection"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(348, 175)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(120, 23)
        Me.btnCheckout.TabIndex = 8
        Me.btnCheckout.Text = "Proceed to Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(199, 175)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(111, 23)
        Me.btnCart.TabIndex = 9
        Me.btnCart.Text = "Show Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnRem
        '
        Me.btnRem.Location = New System.Drawing.Point(119, 358)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Size = New System.Drawing.Size(102, 23)
        Me.btnRem.TabIndex = 13
        Me.btnRem.Text = "Remove Item"
        Me.btnRem.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(259, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 207)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRem)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbGen)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.lstMovSel)
        Me.Controls.Add(Me.rdb7Day)
        Me.Controls.Add(Me.rdb5Day)
        Me.Controls.Add(Me.rdb2Day)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMain"
        Me.Text = "Movie Rentals and BS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdb2Day As System.Windows.Forms.RadioButton
    Friend WithEvents rdb5Day As System.Windows.Forms.RadioButton
    Friend WithEvents rdb7Day As System.Windows.Forms.RadioButton
    Friend WithEvents lstMovSel As System.Windows.Forms.ListBox
    Friend WithEvents lstCart As System.Windows.Forms.ListBox
    Friend WithEvents cmbGen As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents btnCart As System.Windows.Forms.Button
    Friend WithEvents btnRem As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
