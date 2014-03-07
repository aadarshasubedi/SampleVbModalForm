Imports System.Windows.Forms

Public Class SampleVbForm

  Private Sub btnPickMe_Click(sender As System.Object, e As System.EventArgs) Handles btnPickMe.Click
    MessageBox.Show("Hello Rhino!", "SampleVbForm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
  End Sub

  Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
    ' TODO:
  End Sub

  Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
    ' TODO:
  End Sub

End Class