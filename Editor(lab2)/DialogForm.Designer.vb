<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogForm
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
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.rbStart = New System.Windows.Forms.RadioButton()
        Me.rbCursor = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnReplaceAll = New System.Windows.Forms.Button()
        Me.lblFind = New System.Windows.Forms.Label()
        Me.lblReplace = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(141, 39)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(177, 20)
        Me.txtFind.TabIndex = 0
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(141, 65)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(177, 20)
        Me.txtReplace.TabIndex = 1
        '
        'rbStart
        '
        Me.rbStart.AutoSize = True
        Me.rbStart.Location = New System.Drawing.Point(189, 112)
        Me.rbStart.Name = "rbStart"
        Me.rbStart.Size = New System.Drawing.Size(55, 17)
        Me.rbStart.TabIndex = 2
        Me.rbStart.TabStop = True
        Me.rbStart.Text = "All File"
        Me.rbStart.UseVisualStyleBackColor = True
        '
        'rbCursor
        '
        Me.rbCursor.AutoSize = True
        Me.rbCursor.Location = New System.Drawing.Point(189, 135)
        Me.rbCursor.Name = "rbCursor"
        Me.rbCursor.Size = New System.Drawing.Size(119, 17)
        Me.rbCursor.TabIndex = 3
        Me.rbCursor.TabStop = True
        Me.rbCursor.Text = "From cursor position"
        Me.rbCursor.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 209)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(84, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(189, 209)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(85, 23)
        Me.btnReplace.TabIndex = 5
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.Location = New System.Drawing.Point(363, 209)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Size = New System.Drawing.Size(86, 23)
        Me.btnReplaceAll.TabIndex = 6
        Me.btnReplaceAll.Text = "Replace All"
        Me.btnReplaceAll.UseVisualStyleBackColor = True
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Location = New System.Drawing.Point(9, 46)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(27, 13)
        Me.lblFind.TabIndex = 8
        Me.lblFind.Text = "Find"
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(9, 72)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(47, 13)
        Me.lblReplace.TabIndex = 9
        Me.lblReplace.Text = "Replace"
        '
        'DialogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 261)
        Me.Controls.Add(Me.lblReplace)
        Me.Controls.Add(Me.lblFind)
        Me.Controls.Add(Me.btnReplaceAll)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.rbCursor)
        Me.Controls.Add(Me.rbStart)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtFind)
        Me.Name = "DialogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents rbStart As System.Windows.Forms.RadioButton
    Friend WithEvents rbCursor As System.Windows.Forms.RadioButton
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents lblFind As System.Windows.Forms.Label
    Friend WithEvents lblReplace As System.Windows.Forms.Label
End Class
