<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleVbForm
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
    Me.btnPickMe = New System.Windows.Forms.Button()
    Me.btnOk = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'btnPickMe
    '
    Me.btnPickMe.Location = New System.Drawing.Point(102, 31)
    Me.btnPickMe.Name = "btnPickMe"
    Me.btnPickMe.Size = New System.Drawing.Size(75, 23)
    Me.btnPickMe.TabIndex = 0
    Me.btnPickMe.Text = "Pick Me!"
    Me.btnPickMe.UseVisualStyleBackColor = True
    '
    'btnOk
    '
    Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnOk.Location = New System.Drawing.Point(42, 79)
    Me.btnOk.Name = "btnOk"
    Me.btnOk.Size = New System.Drawing.Size(75, 23)
    Me.btnOk.TabIndex = 1
    Me.btnOk.Text = "OK"
    Me.btnOk.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Location = New System.Drawing.Point(159, 79)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 2
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'SampleVbForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 130)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnOk)
    Me.Controls.Add(Me.btnPickMe)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "SampleVbForm"
    Me.Text = "SampleVbForm"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnPickMe As System.Windows.Forms.Button
  Friend WithEvents btnOk As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
