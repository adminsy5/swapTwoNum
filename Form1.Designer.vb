<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.swap = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.n1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.n2 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'swap
        '
        Me.swap.Location = New System.Drawing.Point(291, 273)
        Me.swap.Name = "swap"
        Me.swap.Size = New System.Drawing.Size(98, 46)
        Me.swap.TabIndex = 0
        Me.swap.Text = "Swap"
        Me.swap.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(300, 149)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(126, 39)
        Me.num1.TabIndex = 1
        '
        'n1
        '
        Me.n1.AutoSize = True
        Me.n1.Location = New System.Drawing.Point(247, 152)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(27, 32)
        Me.n1.TabIndex = 2
        Me.n1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(229, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 47)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Swap Numbers"
        '
        'n2
        '
        Me.n2.AutoSize = True
        Me.n2.Location = New System.Drawing.Point(247, 197)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(27, 32)
        Me.n2.TabIndex = 5
        Me.n2.Text = "2"
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(300, 194)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(126, 39)
        Me.num2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.n2)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.n1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.swap)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents swap As Button
    Friend WithEvents num1 As TextBox
    Friend WithEvents n1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents n2 As Label
    Friend WithEvents num2 As TextBox
End Class
