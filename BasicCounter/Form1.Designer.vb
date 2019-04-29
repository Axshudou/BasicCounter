<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.decrement = New System.Windows.Forms.Button()
        Me.increment = New System.Windows.Forms.Button()
        Me.RAZ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'decrement
        '
        Me.decrement.Location = New System.Drawing.Point(67, 66)
        Me.decrement.Name = "decrement"
        Me.decrement.Size = New System.Drawing.Size(75, 23)
        Me.decrement.TabIndex = 0
        Me.decrement.Text = "-"
        Me.decrement.UseVisualStyleBackColor = True
        '
        'increment
        '
        Me.increment.Location = New System.Drawing.Point(238, 66)
        Me.increment.Name = "increment"
        Me.increment.Size = New System.Drawing.Size(75, 23)
        Me.increment.TabIndex = 1
        Me.increment.Text = "+"
        Me.increment.UseVisualStyleBackColor = True
        '
        'RAZ
        '
        Me.RAZ.Location = New System.Drawing.Point(149, 151)
        Me.RAZ.Name = "RAZ"
        Me.RAZ.Size = New System.Drawing.Size(75, 23)
        Me.RAZ.TabIndex = 2
        Me.RAZ.Text = "RAZ"
        Me.RAZ.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 232)
        Me.Controls.Add(Me.RAZ)
        Me.Controls.Add(Me.increment)
        Me.Controls.Add(Me.decrement)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents decrement As Button
    Friend WithEvents increment As Button
    Friend WithEvents RAZ As Button
End Class
