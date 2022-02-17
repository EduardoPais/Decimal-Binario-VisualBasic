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
        Me.TextDecimal = New System.Windows.Forms.TextBox()
        Me.TextBinario = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextDecimal
        '
        Me.TextDecimal.Location = New System.Drawing.Point(322, 124)
        Me.TextDecimal.Name = "TextDecimal"
        Me.TextDecimal.Size = New System.Drawing.Size(185, 27)
        Me.TextDecimal.TabIndex = 0
        '
        'TextBinario
        '
        Me.TextBinario.Location = New System.Drawing.Point(138, 245)
        Me.TextBinario.Name = "TextBinario"
        Me.TextBinario.ReadOnly = True
        Me.TextBinario.Size = New System.Drawing.Size(575, 27)
        Me.TextBinario.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBinario)
        Me.Controls.Add(Me.TextDecimal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextDecimal As TextBox
    Friend WithEvents TextBinario As TextBox
    Friend WithEvents Button1 As Button
End Class
