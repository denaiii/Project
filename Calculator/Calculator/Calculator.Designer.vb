<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorModify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculatorModify))
        Me.TextBoxOperand1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelHover = New System.Windows.Forms.Label()
        Me.CheckBoxReset = New System.Windows.Forms.CheckBox()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxOperator = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxOperand2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxOperand1
        '
        Me.TextBoxOperand1.BackColor = System.Drawing.Color.DimGray
        Me.TextBoxOperand1.ForeColor = System.Drawing.Color.White
        Me.TextBoxOperand1.Location = New System.Drawing.Point(107, 40)
        Me.TextBoxOperand1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxOperand1.Name = "TextBoxOperand1"
        Me.TextBoxOperand1.Size = New System.Drawing.Size(189, 27)
        Me.TextBoxOperand1.TabIndex = 0
        Me.TextBoxOperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operand 1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelHover)
        Me.GroupBox1.Controls.Add(Me.CheckBoxReset)
        Me.GroupBox1.Controls.Add(Me.ButtonReset)
        Me.GroupBox1.Controls.Add(Me.ButtonCalculate)
        Me.GroupBox1.Controls.Add(Me.LabelResult)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxOperator)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxOperand2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxOperand1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.GroupBox1.Location = New System.Drawing.Point(29, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 253)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculator "
        '
        'LabelHover
        '
        Me.LabelHover.AutoSize = True
        Me.LabelHover.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHover.Location = New System.Drawing.Point(328, 220)
        Me.LabelHover.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHover.Name = "LabelHover"
        Me.LabelHover.Size = New System.Drawing.Size(113, 15)
        Me.LabelHover.TabIndex = 10
        Me.LabelHover.Text = "Hover Here To Reset"
        '
        'CheckBoxReset
        '
        Me.CheckBoxReset.AutoSize = True
        Me.CheckBoxReset.Location = New System.Drawing.Point(352, 193)
        Me.CheckBoxReset.Name = "CheckBoxReset"
        Me.CheckBoxReset.Size = New System.Drawing.Size(64, 24)
        Me.CheckBoxReset.TabIndex = 3
        Me.CheckBoxReset.Text = "Reset"
        Me.CheckBoxReset.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(331, 115)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(103, 69)
        Me.ButtonReset.TabIndex = 9
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(331, 40)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(103, 69)
        Me.ButtonCalculate.TabIndex = 8
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'LabelResult
        '
        Me.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelResult.ForeColor = System.Drawing.Color.Snow
        Me.LabelResult.Location = New System.Drawing.Point(107, 192)
        Me.LabelResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(189, 30)
        Me.LabelResult.TabIndex = 7
        Me.LabelResult.Text = "0"
        Me.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Result"
        '
        'ComboBoxOperator
        '
        Me.ComboBoxOperator.BackColor = System.Drawing.Color.DimGray
        Me.ComboBoxOperator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxOperator.ForeColor = System.Drawing.Color.White
        Me.ComboBoxOperator.FormattingEnabled = True
        Me.ComboBoxOperator.Items.AddRange(New Object() {"+", "-", "/", "\", "Modulus", "*", "^", "%", "√", "^2", "Triangle", "Pythagoras", "Sin", "Cos", "Tan"})
        Me.ComboBoxOperator.Location = New System.Drawing.Point(107, 133)
        Me.ComboBoxOperator.Name = "ComboBoxOperator"
        Me.ComboBoxOperator.Size = New System.Drawing.Size(189, 28)
        Me.ComboBoxOperator.TabIndex = 5
        Me.ComboBoxOperator.Text = "Choose The Operator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Operator"
        '
        'TextBoxOperand2
        '
        Me.TextBoxOperand2.BackColor = System.Drawing.Color.DimGray
        Me.TextBoxOperand2.ForeColor = System.Drawing.Color.White
        Me.TextBoxOperand2.Location = New System.Drawing.Point(107, 86)
        Me.TextBoxOperand2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxOperand2.Name = "TextBoxOperand2"
        Me.TextBoxOperand2.Size = New System.Drawing.Size(189, 27)
        Me.TextBoxOperand2.TabIndex = 3
        Me.TextBoxOperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Operand 2"
        '
        'CalculatorModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(523, 330)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CalculatorModify"
        Me.Text = "Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxOperand1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOperand2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxOperator As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents ButtonCalculate As System.Windows.Forms.Button
    Friend WithEvents LabelResult As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxReset As System.Windows.Forms.CheckBox
    Friend WithEvents LabelHover As System.Windows.Forms.Label

End Class
