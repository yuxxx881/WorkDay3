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
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.txtSecondNum = New System.Windows.Forms.TextBox()
        Me.btnFindLarger = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Location = New System.Drawing.Point(155, 26)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(100, 22)
        Me.txtFirstNum.TabIndex = 0
        '
        'txtSecondNum
        '
        Me.txtSecondNum.Location = New System.Drawing.Point(155, 54)
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(100, 22)
        Me.txtSecondNum.TabIndex = 1
        '
        'btnFindLarger
        '
        Me.btnFindLarger.Location = New System.Drawing.Point(79, 91)
        Me.btnFindLarger.Name = "btnFindLarger"
        Me.btnFindLarger.Size = New System.Drawing.Size(154, 28)
        Me.btnFindLarger.TabIndex = 2
        Me.btnFindLarger.Text = "Find Larger Number"
        Me.btnFindLarger.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Number"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(42, 135)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(213, 22)
        Me.txtResult.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 194)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFindLarger)
        Me.Controls.Add(Me.txtSecondNum)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Name = "Form1"
        Me.Text = "FindLarger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstNum As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondNum As System.Windows.Forms.TextBox
    Friend WithEvents btnFindLarger As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
