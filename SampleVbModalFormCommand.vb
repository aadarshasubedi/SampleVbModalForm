Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Rhino
Imports Rhino.Commands
Imports Rhino.Geometry
Imports Rhino.Input
Imports Rhino.Input.Custom

Namespace SampleVbModalForm

  <System.Runtime.InteropServices.Guid("65198076-9105-40a3-af46-2848784bcd4e")> _
  Public Class SampleVbModalFormCommand
    Inherits Command

    ''' <summary>
    ''' Public constructor
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <returns>
    ''' The command name as it appears on the Rhino command line.
    ''' </returns>
    Public Overrides ReadOnly Property EnglishName() As String
      Get
        Return "SampleVbModalFormCommand"
      End Get
    End Property

    ''' <summary>
    ''' Called by Rhino to run your command
    ''' </summary>
    Protected Overrides Function RunCommand(ByVal doc As RhinoDoc, ByVal mode As RunMode) As Result

      Dim result As Result = Result.Cancel

      If (mode = RunMode.Interactive) Then
        Dim form As New SampleVbForm()
        form.StartPosition = FormStartPosition.CenterParent
        Dim dialogResult = form.ShowDialog(RhinoApp.MainWindow())
        If (dialogResult = Windows.Forms.DialogResult.OK) Then
          result = Result.Success
        End If
      Else
        Dim msg As String = String.Format("Scriptable version of {0} command not implemented.", EnglishName)
        RhinoApp.WriteLine(msg)
      End If

      Return result

    End Function

  End Class

End Namespace