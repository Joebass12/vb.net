Public Class Form1

    Private isadding As Boolean = False
    Private issubtracting As Boolean = False
    Private ismultiplying As Boolean = False
    Private isdividing As Boolean = False
    Private ismodulus As Boolean = False
    Private isPI As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isadding = False Then
            Dim answer As Double = add(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isadding = True
        ElseIf isadding Then
            Dim ans As Double = add(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And issubtracting = False 
            Dim answer As Double = subtract(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
                txtAnswer.Text = answer.ToString()
                txtNum2.ReadOnly = True
            issubtracting = True
        ElseIf issubtracting Then
            Dim ans As Double = subtract(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()
            Else
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And ismultiplying = False Then
            Dim answer As Double = multiply(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isadding = True
        ElseIf ismultiplying Then
            Dim ans As Double = multiply(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isdividing = False Then
            Dim answer As Double = divide(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isadding = True
        ElseIf isdividing Then
            Dim ans As Double = divide(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnModulus_Click(sender As Object, e As EventArgs) Handles BtnModulus.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And ismodulus = False Then
            Dim answer As Double = modulus(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            ismodulus = True
        ElseIf ismodulus Then
            Dim ans As Double = modulus(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnPI_Click(sender As Object, e As EventArgs) Handles BtnPI.Click
        If txtNum1.Text.Length <> 0 Then
            Dim answer As Double = PI(CType(txtNum1.Text, Double))
            txtAnswer.Text = String.Format("{0:n3}", answer)
            txtNum2.Text = String.Format("{0.n3}", Math.PI)
            txtNum2.ReadOnly = True
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function add(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function
    Private Function subtract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function
    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function
    Private Function divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function
    Private Function modulus(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 Mod num2
    End Function
    Private Function PI(ByVal num1 As Double) As Double
        Return num1 * Math.PI
    End Function

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtNum2.ReadOnly = False
        revertBool()
        txtNum1.Clear()
        txtNum2.Clear()
        txtAnswer.Clear()
    End Sub

    Private Sub revertBool()
        isadding = False
        issubtracting = False
        ismultiplying = False
        isdividing = False
        ismodulus = False
        isPI = False
    End Sub
    Private Sub BtnOff_Click(sender As Object, e As EventArgs) Handles BtnOff.Click
        Me.Close()
    End Sub

    Private Sub BtnPI_MouseHover(sender As Object, e As EventArgs) Handles BtnPI.MouseHover
        tlTipPI.SetToolTip(BtnPI, "only one value is needed in the first value field")
    End Sub
End Class
