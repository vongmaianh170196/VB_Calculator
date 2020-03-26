Public Class CalculatorForm

    'Public numb1 As Double = txtNumb1.Text
    'Public numb2 As Double = txtNumb2.Text
    Private Sub CalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function add(ByVal first As Double, ByVal second As Double) As Double
        Return Math.Round(first + second, 2)
    End Function
    Private Function subtract(ByVal first As Double, ByVal second As Double) As Double
        Return Math.Round(first - second, 2)
    End Function

    Private Function multiply(ByVal first As Double, ByVal second As Double) As Double
        Return Math.Round(first * second, 2)
    End Function

    Private Function divide(ByVal first As Double, ByVal second As Double) As Double
        Return Math.Round(first / second, 2)
    End Function

    Private Function modulus(ByVal first As Double, ByVal second As Double) As Double
        Return Math.Round(first Mod second, 2)
    End Function

    Private Function sqrt(ByVal first As Double) As Double
        Return Math.Round(Math.Sqrt(first), 2)
    End Function
    Private Function checkInput(ByVal inp As String) As Boolean
        Dim value As Double
        Return Double.TryParse(inp, value)

    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If checkInput(txtNumb1.Text) And checkInput(txtNumb2.Text) Then
            Dim res As Double = add(CType(txtNumb1.Text, Double), CType(txtNumb2.Text, Double))
            txtResult.Text = res
        Else
            MessageBox.Show("Please input correct Double value")
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If checkInput(txtNumb1.Text) And checkInput(txtNumb2.Text) Then
            Dim res As Double = subtract(CType(txtNumb1.Text, Double), CType(txtNumb2.Text, Double))
            txtResult.Text = res
        Else
            MessageBox.Show("Please input correct Double value")
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If checkInput(txtNumb1.Text) And checkInput(txtNumb2.Text) Then
            Dim res As Double = multiply(CType(txtNumb1.Text, Double), CType(txtNumb2.Text, Double))
            txtResult.Text = res
        Else
            MessageBox.Show("Please input correct Double value")
        End If

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If checkInput(txtNumb1.Text) And checkInput(txtNumb2.Text) And txtNumb2.Text <> 0 Then
            Dim res As Double = divide(CType(txtNumb1.Text, Double), CType(txtNumb2.Text, Double))
            txtResult.Text = res
        Else
            MessageBox.Show("Please input correct Double value")
        End If

    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If checkInput(txtNumb1.Text) And checkInput(txtNumb2.Text) Then
            Dim res As Double = modulus(CType(txtNumb1.Text, Double), CType(txtNumb2.Text, Double))
            txtResult.Text = res
        Else
            MessageBox.Show("Please input correct Double value")
        End If

    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        If Not checkInput(txtNumb1.Text) Then
            MessageBox.Show("Please input correct Double value")
        ElseIf txtNumb1.Text.Length >= 1 And txtNumb2.Text.Length >= 1 Then
            MessageBox.Show("Square root calculation only accepts one value")
        ElseIf txtNumb1.Text.Length >= 1 And txtNumb2.Text.Length < 1 Then
            Dim res As Double = sqrt(CType(txtNumb1.Text, Double))
            txtResult.Text = res
        ElseIf txtNumb2.Text.Length >= 1 And txtNumb1.Text.Length < 1 Then
            Dim res As Double = sqrt(CType(txtNumb2.Text, Double))
            txtResult.Text = res
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumb1.Text = 0
        txtNumb2.Text = 0
        txtResult.Text = 0
    End Sub
End Class
