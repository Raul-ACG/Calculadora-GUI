Public Class Form1
  Dim logoPath As String = System.IO.Path.Combine(Application.StartupPath, "assets\img\logo.jpeg")
  Dim current As Double = 0
  Dim op As String = ""
  Dim newOp As Boolean = True

  Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Logo.Click

  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If Not System.IO.File.Exists(logoPath) Then
      MessageBox.Show("No se encontró la imagen en: " & logoPath)
      Return
    End If

    Logo.Image = Image.FromFile(logoPath)
    Logo.SizeMode = PictureBoxSizeMode.Zoom
  End Sub

  Private Sub NumberPress(sender As Object, e As EventArgs) Handles N0.Click, N1.Click, N2.Click, N3.Click, N4.Click, N5.Click, N6.Click, N7.Click, N8.Click, N9.Click
    Dim Button As Button = CType(sender, Button)

    If Display.Text = "0" Or newOp Then
      Display.Text = ""
      newOp = False
    End If

    If Button.Text = "." Then
      If Not Display.Text.Contains(".") Then
        Display.Text &= "."
      End If
    Else
      Display.Text &= Button.Text
    End If
  End Sub

  Private Sub OperatorPress(sender As Object, e As EventArgs) Handles Addition.Click, Substract.Click, Times.Click, Divide.Click
    Dim Button As Button = CType(sender, Button)

    If current <> 0 Then
      Equal.PerformClick()
    End If

    current = Double.Parse(Display.Text)
    op = Button.Text
    newOp = True
  End Sub

  Private Sub EqualPress(sender As Object, e As EventArgs) Handles Equal.Click
    Dim otherValue As Double = Double.Parse(Display.Text)
    Dim result As Double

    Select Case op
      Case "+"
        result = current + otherValue
      Case "-"
        result = current - otherValue
      Case "×"
        result = current * otherValue
      Case "÷"
        If otherValue = 0 Then
          MessageBox.Show("No se puede dividir entre cero")
          Exit Sub
        End If
        result = current / otherValue
      Case Else
        result = otherValue
    End Select

    Display.Text = result.ToString().Replace(",", ".")
    current = result
    op = ""
    newOp = True
  End Sub

  Private Sub ClearAllPress(sender As Object, e As EventArgs) Handles ClearAll.Click
    Display.Text = "0"
    current = 0
    op = ""
  End Sub

  Private Sub ClearLastPress(sender As Object, e As EventArgs) Handles ClearLast.Click
    Display.Text = "0"
  End Sub
End Class
