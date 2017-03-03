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
            Dim stayCharges As Double = CalcStayCharges(daysSpentInHospital)

            ' Calculate misc charges
            Dim miscCharges As Double = CalcMiscCharges(medicationCharges, surgicalCharges, labFees, physicalRehabCharges)

            ' Calculate total charges
            TotalCost.Text = CalcTotalCharges(stayCharges, miscCharges).ToString("c")
        End If
    End Sub

    Private Function ValidateInputFields() As Boolean
        ' Try to convert each of the input fields. return False if
        ' any field is invalid, and display a suitable error message.
        If Not Integer.TryParse(LengthOfStayInputBox.Text, daysSpentInHospital) Then
            ErrorMessageLabel.Text = "Length of Stay must be an integer."
            Return False
        ElseIf (daysSpentInHospital < 0) Then
            ErrorMessageLabel.Text = "Length of Stay must be a positive integer."
            Return False
        End If

        If Not Double.TryParse(MedicationInputBox.Text, medicationCharges) Then
            ErrorMessageLabel.Text = "Medication charges must be a number."
            Return False
        ElseIf (medicationCharges < 0) Then
            ErrorMessageLabel.Text = "Medication charges must be a positive number."
            Return False
        End If

        If Not Double.TryParse(SurgicalChargesInputBox.Text, surgicalCharges) Then
            ErrorMessageLabel.Text = "Surgical charges must be a number."
            Return False
        ElseIf (surgicalCharges < 0) Then
            ErrorMessageLabel.Text = "Surgical charges must be a positive number."
            Return False
        End If

        If Not Double.TryParse(LabFeesInputBox.Text, labFees) Then
            ErrorMessageLabel.Text = "Lab fees must be a number."
            Return False
        ElseIf (labFees < 0) Then
            ErrorMessageLabel.Text = "Lab fees must be a positive number."
            Return False
        End If

        If Not Double.TryParse(PhysicalRehabInputBox.Text, physicalRehabCharges) Then
            ErrorMessageLabel.Text = "Physical Rehab charges must be a number."
            Return False
        ElseIf (physicalRehabCharges < 0) Then
            ErrorMessageLabel.Text = "Physical rehab charges must be a positive number."
            Return False
        End If

        Return True
    End Function

    Function CalcStayCharges(daysOccupied As Integer) As Double
        Const CHARGE_PER_DAY = 350.0
        Return (daysOccupied * CHARGE_PER_DAY)

    End Function

    Function CalcMiscCharges(medicalCharges As Double, surgicalCharges As Double, labFees As Double, physicalRehabCharges As Double) As Double
        Return (medicalCharges + surgicalCharges + labFees + physicalRehabCharges)
    End Function

    Function CalcTotalCharges(room As Double, other As Double) As Double
        Return (room + other)
    End Function

End Class
