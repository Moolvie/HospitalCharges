Public Class HospitalCharges
    ' Declare variables
    Private daysSpentInHospital As Integer
    Private medicationCharges As Double
    Private surgicalCharges As Double
    Private labFees As Double
    Private physicalRehabCharges As Double
    Private totalCharges As Double
    Private Sub HospitalCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LengthOfStayInputBox.Focus()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ClearFormButton_Click(sender As Object, e As EventArgs) Handles ClearFormButton.Click
        LengthOfStayInputBox.Clear()
        MedicationInputBox.Clear()
        SurgicalChargesInputBox.Clear()
        LabFeesInputBox.Clear()
        PhysicalRehabInputBox.Clear()
        TotalCost.Text = String.Empty
        ErrorMessageLabel.Text = String.Empty
        LengthOfStayInputBox.Focus()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' clear any previous error messages
        ErrorMessageLabel.Text = String.Empty
        ' Validate input values
        If ValidateInputFields() Then
            ' Calculate stay charges

            ' Calculate misc charges

            ' Calculate total charges
        End If
    End Sub
    Private Function ValidateInputFields() As Boolean
        ' Try to convert each of the input fields return False if
        ' any field is invalid, and display an suitable error message.
        If Not Integer.TryParse(lengthOfStayLabel.Text, daysSpentInHospital) Then
            ErrorMessageLabel.Text = "Length of Stay must be an integer."
            Return False
        End If

        If Not Double.TryParse(MedicationInputBox.Text, medicationCharges) Then
            ErrorMessageLabel.Text = "Medication charges must be a number."
            Return False
        End If
        If Not Double.TryParse(SurgicalChargesInputBox.Text, surgicalCharges) Then
            ErrorMessageLabel.Text = "Surgical charges must be a number."
            Return False
        End If
        If Not Double.TryParse(LabFeesInputBox.Text, labFees) Then
            ErrorMessageLabel.Text = "Lab fees must be a number."
            Return False
        End If
        If Not Double.TryParse(PhysicalRehabInputBox.Text, physicalRehabCharges) Then
            ErrorMessageLabel.Text = "Physical Rehab charges must be a number."
            Return False
        End If
        Return True
    End Function
End Class
