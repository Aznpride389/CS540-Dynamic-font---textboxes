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
        Me.resizeControlLabel = New System.Windows.Forms.Label()
        Me.resizeFontLabel = New System.Windows.Forms.Label()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'resizeControlLabel
        '
        Me.resizeControlLabel.AutoSize = True
        Me.resizeControlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resizeControlLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resizeControlLabel.Location = New System.Drawing.Point(63, 129)
        Me.resizeControlLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.resizeControlLabel.Name = "resizeControlLabel"
        Me.resizeControlLabel.Size = New System.Drawing.Size(216, 31)
        Me.resizeControlLabel.TabIndex = 0
        Me.resizeControlLabel.Text = "resizeControlLabel "
        '
        'resizeFontLabel
        '
        Me.resizeFontLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resizeFontLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resizeFontLabel.Location = New System.Drawing.Point(57, 279)
        Me.resizeFontLabel.Name = "resizeFontLabel"
        Me.resizeFontLabel.Size = New System.Drawing.Size(511, 28)
        Me.resizeFontLabel.TabIndex = 1
        Me.resizeFontLabel.Text = "resizeFontLabel"
        '
        'nextButton
        '
        Me.nextButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nextButton.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(63, 364)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(219, 85)
        Me.nextButton.TabIndex = 2
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Maintains Font Size and Resize Controls"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 230)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(493, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maintains Controls and Resize Fonts"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(833, 462)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.resizeFontLabel)
        Me.Controls.Add(Me.resizeControlLabel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resizeControlLabel As Label
    Friend WithEvents resizeFontLabel As Label
    Friend WithEvents nextButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
