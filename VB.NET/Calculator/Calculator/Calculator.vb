Public Class CalculatorModify

    Private Sub ButtonCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalculate.Click
        Select Case ComboBoxOperator.Text
            Case "+"
                LabelResult.Text = AdditionParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "-"
                LabelResult.Text = SubtractionParameter(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "/"
                LabelResult.Text = DivisionParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "\"
                LabelResult.Text = Division2Paramater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "Modulus"
                LabelResult.Text = ModulusParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "*"
                LabelResult.Text = MultiplicationParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "^"
                LabelResult.Text = PowerParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "%"
                LabelResult.Text = PercentageParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "√"
                LabelResult.Text = SquareRootParamater(TextBoxOperand1.Text)
            Case "^2"
                LabelResult.Text = SquareRootOf2Paramater(TextBoxOperand1.Text)
            Case "Triangle"
                LabelResult.Text = TriangleParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "Pythagoras"
                LabelResult.Text = PythagorasParamater(TextBoxOperand1.Text, TextBoxOperand2.Text)
            Case "Sin"
                LabelResult.Text = SinParamater(TextBoxOperand1.Text)
            Case "Cos"
                LabelResult.Text = CosParamater(TextBoxOperand1.Text)
            Case "Tan"
                LabelResult.Text = TanParamater(TextBoxOperand1.Text)
        End Select
    End Sub

    Private Function Addition() As Double 'Function Without Parameter
        Addition = CInt(TextBoxOperand1.Text) + CInt(TextBoxOperand2.Text)
    End Function

    Private Function AdditionParamater(ByVal operand1 As Double, ByVal operand2 As Double) As Double    'Function With Parameter
        AdditionParamater = operand1 + operand2
    End Function

    Private Function Subtraction() As Double   'Function Without Parameter
        Subtraction = CInt(TextBoxOperand1.Text) - CInt(TextBoxOperand2.Text)
    End Function

    Private Function SubtractionParameter(ByVal operand1 As Double, ByVal operand2 As Double) As Double   'Function With Parameter
        SubtractionParameter = operand1 - operand2
    End Function

    Private Function Division() As Double  'Function Without Parameter
        Division = CInt(TextBoxOperand1.Text) / CInt(TextBoxOperand2.Text)
    End Function

    Private Function DivisionParamater(ByVal operand1 As Double, ByVal operand2 As Double) As Double  'Function With Parameter
        DivisionParamater = operand1 / operand2
    End Function

    Private Function Division2() As Double  'Function Without Parameter
        Division2 = CInt(TextBoxOperand1.Text) \ CInt(TextBoxOperand2.Text)
    End Function

    Private Function Division2Paramater(ByVal operand1 As Double, ByVal operand2 As Double) As Double  'Function With Parameter
        Division2Paramater = operand1 / operand2
    End Function

    Private Function Modulus() As Double  'Function Without Parameter
        Modulus = CInt(TextBoxOperand1.Text) Mod CInt(TextBoxOperand2.Text)
    End Function

    Private Function ModulusParamater(ByVal operand1 As Double, ByVal operand2 As Double) As Double  'Function With Parameter
        ModulusParamater = operand1 Mod operand2
    End Function

    Private Function Multiplication() As Integer 'Function Without Parameter
        Multiplication = CInt(TextBoxOperand1.Text) * CInt(TextBoxOperand2.Text)
    End Function

    Private Function MultiplicationParamater(ByVal operand1 As Double, ByVal operand2 As Double) As Double 'Function With Parameter
        MultiplicationParamater = operand1 * operand2
    End Function

    Private Function Power() As Double 'Function Without Parameter
        Power = CInt(TextBoxOperand1.Text) ^ CInt(TextBoxOperand2.Text)
    End Function

    Private Function PowerParamater(ByVal operand1 As Double, ByVal operand2 As Double) As Double 'Function With Parameter
        PowerParamater = operand1 ^ operand2
    End Function

    Private Function Percentage() As Double 'Function Without Parameter
        Percentage = (CInt(TextBoxOperand1.Text) * CInt(TextBoxOperand2.Text)) / 100
    End Function

    Private Function PercentageParamater(ByVal operand1 As Double, ByVal operand2 As Double) As Double 'Function With Parameter
        PercentageParamater = (operand1 * operand2) / 100
    End Function

    Private Function SquareRoot() As Double 'Function Without Parameter
        SquareRoot = CInt(TextBoxOperand1.Text) * (1 / 2)
    End Function

    Private Function SquareRootParamater(ByVal operand1 As Double) As Double 'Function With Parameter
        SquareRootParamater = operand1 * (1 / 2)
    End Function

    Private Function SquareRootOf2() As Double 'Function Without Parameter
        SquareRootOf2 = CInt(TextBoxOperand1.Text) ^ (1 / 2)
    End Function

    Private Function SquareRootOf2Paramater(ByVal operand1 As Double) As Double 'Function With Parameter
        SquareRootOf2Paramater = operand1 ^ (1 / 2)
    End Function

    Private Function Triangle() As Double 'Function Without Parameter
        Triangle = (CInt(TextBoxOperand1.Text)) * (CInt(TextBoxOperand2.Text)) * (0.5)
    End Function

    Private Function TriangleParamater(ByVal Base As Double, ByVal Height As Double) As Double 'Function With Parameter
        TriangleParamater = (Base * Height) * 0.5
    End Function

    Private Function Pythagoras() As Double 'Function Without Parameter
        Pythagoras = (CInt(TextBoxOperand1.Text) ^ 2) + (CInt(TextBoxOperand2.Text) ^ 2) ^ (1 / 2)
    End Function

    Private Function PythagorasParamater(ByVal operand1 As Double, ByVal operand2 As Double) As Double 'Function With Parameter
        PythagorasParamater = (operand1 ^ 2) + (operand2 ^ 2) ^ (1 / 2)
    End Function

    Private Function Sin() As Double 'Function Without Parameter
        Sin = Math.Sin(TextBoxOperand1.Text * (Math.PI / 180))
    End Function

    Private Function SinParamater(ByVal operand1 As Double) As Double 'Function With Parameter
        SinParamater = Math.Sin(operand1 * (Math.PI / 180))
    End Function

    Private Function Cos() As Double 'Function Without Parameter
        Cos = Math.Sin(TextBoxOperand1.Text * (Math.PI / 180))
    End Function

    Private Function CosParamater(ByVal operand1 As Double ) As Double  'Function With Parameter
        CosParamater = Math.Cos(operand1 * (Math.PI / 180))
    End Function

    Private Function Tan() As Double   'Function Without Parameter
        Tan = Math.Sin(TextBoxOperand1.Text * (Math.PI / 180))
    End Function

    Private Function TanParamater(ByVal operand1 As Double) As Double   'Function With Parameter
        TanParamater = Math.Tan(operand1 * (Math.PI / 180))
    End Function

    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click
        TextBoxOperand1.Clear()
        TextBoxOperand2.Clear()
        LabelResult.Text = ""
        ComboBoxOperator.Text = ""
    End Sub

    Private Sub CheckBoxReset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxReset.CheckedChanged
        TextBoxOperand1.Clear()
        TextBoxOperand2.Clear()
        LabelResult.Text = ""
        ComboBoxOperator.Text = ""
    End Sub

    Private Sub LabelHover_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles LabelHover.MouseHover
        TextBoxOperand1.Clear()
        TextBoxOperand2.Clear()
        LabelResult.Text = ""
        ComboBoxOperator.Text = ""
    End Sub
End Class
