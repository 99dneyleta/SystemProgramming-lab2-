<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorForm
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
        Me.RTBText = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RTBText
        '
        Me.RTBText.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.RTBText.ForeColor = System.Drawing.SystemColors.Window
        Me.RTBText.Location = New System.Drawing.Point(12, 4)
        Me.RTBText.Name = "RTBText"
        Me.RTBText.Size = New System.Drawing.Size(370, 347)
        Me.RTBText.TabIndex = 0
        Me.RTBText.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Replace"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(388, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "openFile"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 363)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RTBText)
        Me.Name = "EditorForm"
        Me.Text = "Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RTBText As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
