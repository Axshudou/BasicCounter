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
        Me.Total = New System.Windows.Forms.Label()
        Me.Counter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'decrement
        '
        Me.decrement.Location = New System.Drawing.Point(68, 66)
        Me.decrement.Name = "decrement"
        Me.decrement.Size = New System.Drawing.Size(75, 23)
        Me.decrement.TabIndex = 0
        Me.decrement.Text = "-"
        Me.decrement.UseVisualStyleBackColor = True
        '
        'increment
        '
        Me.increment.Location = New System.Drawing.Point(214, 66)
        Me.increment.Name = "increment"
        Me.increment.Size = New System.Drawing.Size(75, 23)
        Me.increment.TabIndex = 1
        Me.increment.Text = "+"
        Me.increment.UseVisualStyleBackColor = True
        '
        'RAZ
        '
        Me.RAZ.Location = New System.Drawing.Point(141, 111)
        Me.RAZ.Name = "RAZ"
        Me.RAZ.Size = New System.Drawing.Size(75, 23)
        Me.RAZ.TabIndex = 2
        Me.RAZ.Text = "RAZ"
        Me.RAZ.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(162, 33)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(31, 13)
        Me.Total.TabIndex = 3
        Me.Total.Text = "Total"
        '
        'Counter
        '
        Me.Counter.AutoSize = True
        Me.Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Counter.Location = New System.Drawing.Point(168, 62)
        Me.Counter.Name = "Counter"
        Me.Counter.Size = New System.Drawing.Size(25, 25)
        Me.Counter.TabIndex = 4
        Me.Counter.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 177)
        Me.Controls.Add(Me.Counter)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.RAZ)
        Me.Controls.Add(Me.increment)
        Me.Controls.Add(Me.decrement)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents decrement As Button
    Friend WithEvents increment As Button
    Friend WithEvents RAZ As Button
    Friend WithEvents Total As Label
    Friend WithEvents Counter As Label
End Class
