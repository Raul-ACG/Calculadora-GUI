<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.Logo = New System.Windows.Forms.PictureBox()
    Me.Display = New System.Windows.Forms.TextBox()
    Me.N7 = New System.Windows.Forms.Button()
    Me.N8 = New System.Windows.Forms.Button()
    Me.Divide = New System.Windows.Forms.Button()
    Me.Times = New System.Windows.Forms.Button()
    Me.Substract = New System.Windows.Forms.Button()
    Me.Addition = New System.Windows.Forms.Button()
    Me.N4 = New System.Windows.Forms.Button()
    Me.N9 = New System.Windows.Forms.Button()
    Me.N5 = New System.Windows.Forms.Button()
    Me.N6 = New System.Windows.Forms.Button()
    Me.N1 = New System.Windows.Forms.Button()
    Me.N2 = New System.Windows.Forms.Button()
    Me.N3 = New System.Windows.Forms.Button()
    Me.N0 = New System.Windows.Forms.Button()
    Me.Comma = New System.Windows.Forms.Button()
    Me.ClearLast = New System.Windows.Forms.Button()
    Me.ClearAll = New System.Windows.Forms.Button()
    Me.Equal = New System.Windows.Forms.Button()
    CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Logo
    '
    Me.Logo.InitialImage = CType(resources.GetObject("Logo.InitialImage"), System.Drawing.Image)
    Me.Logo.Location = New System.Drawing.Point(25, 25)
    Me.Logo.Name = "Logo"
    Me.Logo.Size = New System.Drawing.Size(331, 87)
    Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.Logo.TabIndex = 0
    Me.Logo.TabStop = False
    '
    'Display
    '
    Me.Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
    Me.Display.Location = New System.Drawing.Point(25, 138)
    Me.Display.MaxLength = 1023
    Me.Display.Name = "Display"
    Me.Display.ReadOnly = True
    Me.Display.Size = New System.Drawing.Size(331, 46)
    Me.Display.TabIndex = 1
    Me.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'N7
    '
    Me.N7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N7.Location = New System.Drawing.Point(25, 211)
    Me.N7.Name = "N7"
    Me.N7.Size = New System.Drawing.Size(55, 54)
    Me.N7.TabIndex = 2
    Me.N7.Text = "7"
    Me.N7.UseVisualStyleBackColor = True
    '
    'N8
    '
    Me.N8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N8.Location = New System.Drawing.Point(116, 211)
    Me.N8.Name = "N8"
    Me.N8.Size = New System.Drawing.Size(55, 54)
    Me.N8.TabIndex = 3
    Me.N8.Text = "8"
    Me.N8.UseVisualStyleBackColor = True
    '
    'Divide
    '
    Me.Divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.Divide.Location = New System.Drawing.Point(301, 211)
    Me.Divide.Name = "Divide"
    Me.Divide.Size = New System.Drawing.Size(55, 54)
    Me.Divide.TabIndex = 4
    Me.Divide.Text = "÷"
    Me.Divide.UseVisualStyleBackColor = True
    '
    'Times
    '
    Me.Times.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.Times.Location = New System.Drawing.Point(301, 287)
    Me.Times.Name = "Times"
    Me.Times.Size = New System.Drawing.Size(55, 54)
    Me.Times.TabIndex = 5
    Me.Times.Text = "×"
    Me.Times.UseVisualStyleBackColor = True
    '
    'Substract
    '
    Me.Substract.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.Substract.Location = New System.Drawing.Point(301, 364)
    Me.Substract.Name = "Substract"
    Me.Substract.Size = New System.Drawing.Size(55, 54)
    Me.Substract.TabIndex = 6
    Me.Substract.Text = "-"
    Me.Substract.UseVisualStyleBackColor = True
    '
    'Addition
    '
    Me.Addition.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.Addition.Location = New System.Drawing.Point(301, 442)
    Me.Addition.Name = "Addition"
    Me.Addition.Size = New System.Drawing.Size(55, 54)
    Me.Addition.TabIndex = 7
    Me.Addition.Text = "+"
    Me.Addition.UseVisualStyleBackColor = True
    '
    'N4
    '
    Me.N4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N4.Location = New System.Drawing.Point(25, 287)
    Me.N4.Name = "N4"
    Me.N4.Size = New System.Drawing.Size(55, 54)
    Me.N4.TabIndex = 8
    Me.N4.Text = "4"
    Me.N4.UseVisualStyleBackColor = True
    '
    'N9
    '
    Me.N9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N9.Location = New System.Drawing.Point(209, 211)
    Me.N9.Name = "N9"
    Me.N9.Size = New System.Drawing.Size(55, 54)
    Me.N9.TabIndex = 9
    Me.N9.Text = "9"
    Me.N9.UseVisualStyleBackColor = True
    '
    'N5
    '
    Me.N5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N5.Location = New System.Drawing.Point(116, 287)
    Me.N5.Name = "N5"
    Me.N5.Size = New System.Drawing.Size(55, 54)
    Me.N5.TabIndex = 10
    Me.N5.Text = "5"
    Me.N5.UseVisualStyleBackColor = True
    '
    'N6
    '
    Me.N6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N6.Location = New System.Drawing.Point(209, 287)
    Me.N6.Name = "N6"
    Me.N6.Size = New System.Drawing.Size(55, 54)
    Me.N6.TabIndex = 11
    Me.N6.Text = "6"
    Me.N6.UseVisualStyleBackColor = True
    '
    'N1
    '
    Me.N1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N1.Location = New System.Drawing.Point(25, 364)
    Me.N1.Name = "N1"
    Me.N1.Size = New System.Drawing.Size(55, 54)
    Me.N1.TabIndex = 12
    Me.N1.Text = "1"
    Me.N1.UseVisualStyleBackColor = True
    '
    'N2
    '
    Me.N2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N2.Location = New System.Drawing.Point(116, 364)
    Me.N2.Name = "N2"
    Me.N2.Size = New System.Drawing.Size(55, 54)
    Me.N2.TabIndex = 13
    Me.N2.Text = "2"
    Me.N2.UseVisualStyleBackColor = True
    '
    'N3
    '
    Me.N3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N3.Location = New System.Drawing.Point(209, 364)
    Me.N3.Name = "N3"
    Me.N3.Size = New System.Drawing.Size(55, 54)
    Me.N3.TabIndex = 14
    Me.N3.Text = "3"
    Me.N3.UseVisualStyleBackColor = True
    '
    'N0
    '
    Me.N0.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.N0.Location = New System.Drawing.Point(25, 442)
    Me.N0.Name = "N0"
    Me.N0.Size = New System.Drawing.Size(55, 54)
    Me.N0.TabIndex = 15
    Me.N0.Text = "0"
    Me.N0.UseVisualStyleBackColor = True
    '
    'Comma
    '
    Me.Comma.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!)
    Me.Comma.Location = New System.Drawing.Point(116, 442)
    Me.Comma.Name = "Comma"
    Me.Comma.Size = New System.Drawing.Size(55, 54)
    Me.Comma.TabIndex = 16
    Me.Comma.Text = "."
    Me.Comma.UseVisualStyleBackColor = True
    '
    'ClearLast
    '
    Me.ClearLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
    Me.ClearLast.Location = New System.Drawing.Point(209, 442)
    Me.ClearLast.Name = "ClearLast"
    Me.ClearLast.Size = New System.Drawing.Size(55, 54)
    Me.ClearLast.TabIndex = 17
    Me.ClearLast.Text = "CE"
    Me.ClearLast.UseVisualStyleBackColor = True
    '
    'ClearAll
    '
    Me.ClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.ClearAll.Location = New System.Drawing.Point(25, 518)
    Me.ClearAll.Name = "ClearAll"
    Me.ClearAll.Size = New System.Drawing.Size(146, 54)
    Me.ClearAll.TabIndex = 18
    Me.ClearAll.Text = "C"
    Me.ClearAll.UseVisualStyleBackColor = True
    '
    'Equal
    '
    Me.Equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
    Me.Equal.Location = New System.Drawing.Point(209, 518)
    Me.Equal.Name = "Equal"
    Me.Equal.Size = New System.Drawing.Size(147, 54)
    Me.Equal.TabIndex = 19
    Me.Equal.Text = "="
    Me.Equal.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(379, 598)
    Me.Controls.Add(Me.Equal)
    Me.Controls.Add(Me.ClearAll)
    Me.Controls.Add(Me.ClearLast)
    Me.Controls.Add(Me.Comma)
    Me.Controls.Add(Me.N0)
    Me.Controls.Add(Me.N3)
    Me.Controls.Add(Me.N2)
    Me.Controls.Add(Me.N1)
    Me.Controls.Add(Me.N6)
    Me.Controls.Add(Me.N5)
    Me.Controls.Add(Me.N9)
    Me.Controls.Add(Me.N4)
    Me.Controls.Add(Me.Addition)
    Me.Controls.Add(Me.Substract)
    Me.Controls.Add(Me.Times)
    Me.Controls.Add(Me.Divide)
    Me.Controls.Add(Me.N8)
    Me.Controls.Add(Me.N7)
    Me.Controls.Add(Me.Display)
    Me.Controls.Add(Me.Logo)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Logo As PictureBox
  Friend WithEvents Display As TextBox
  Friend WithEvents N7 As Button
  Friend WithEvents N8 As Button
  Friend WithEvents Divide As Button
  Friend WithEvents Times As Button
  Friend WithEvents Substract As Button
  Friend WithEvents Addition As Button
  Friend WithEvents N4 As Button
  Friend WithEvents N9 As Button
  Friend WithEvents N5 As Button
  Friend WithEvents N6 As Button
  Friend WithEvents N1 As Button
  Friend WithEvents N2 As Button
  Friend WithEvents N3 As Button
  Friend WithEvents N0 As Button
  Friend WithEvents Comma As Button
  Friend WithEvents ClearLast As Button
  Friend WithEvents ClearAll As Button
  Friend WithEvents Equal As Button
End Class
