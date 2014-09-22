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
        Me.btnCounter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCounter
        '
        Me.btnCounter.Location = New System.Drawing.Point(101, 111)
        Me.btnCounter.Name = "btnCounter"
        Me.btnCounter.Size = New System.Drawing.Size(83, 29)
        Me.btnCounter.TabIndex = 0
        Me.btnCounter.Text = "0"
        Me.btnCounter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 267)
        Me.Controls.Add(Me.btnCounter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Reverting Counter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCounter As System.Windows.Forms.Button

End Class
