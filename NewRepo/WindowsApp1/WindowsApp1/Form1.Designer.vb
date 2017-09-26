<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.sendButton = New System.Windows.Forms.Button()
        Me.textContent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'sendButton
        '
        Me.sendButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.sendButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendButton.ForeColor = System.Drawing.Color.Blue
        Me.sendButton.Location = New System.Drawing.Point(227, 38)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(75, 23)
        Me.sendButton.TabIndex = 0
        Me.sendButton.Text = "Send"
        Me.sendButton.UseVisualStyleBackColor = False
        '
        'textContent
        '
        Me.textContent.BackColor = System.Drawing.SystemColors.Menu
        Me.textContent.Location = New System.Drawing.Point(12, 12)
        Me.textContent.Name = "textContent"
        Me.textContent.Size = New System.Drawing.Size(523, 20)
        Me.textContent.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(547, 72)
        Me.Controls.Add(Me.textContent)
        Me.Controls.Add(Me.sendButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sendButton As Button
    Friend WithEvents textContent As TextBox
End Class
