<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HospitalCharges
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
        Me.InputValuesPanel = New System.Windows.Forms.Panel()
        Me.ErrorMessageLabel = New System.Windows.Forms.Label()
        Me.PhysicalRehabLabel = New System.Windows.Forms.Label()
        Me.LabFeesLabel = New System.Windows.Forms.Label()
        Me.SurgicalChargesLabel = New System.Windows.Forms.Label()
        Me.MedicationLabel = New System.Windows.Forms.Label()
        Me.lengthOfStayLabel = New System.Windows.Forms.Label()
        Me.PhysicalRehabInputBox = New System.Windows.Forms.TextBox()
        Me.LabFeesInputBox = New System.Windows.Forms.TextBox()
        Me.SurgicalChargesInputBox = New System.Windows.Forms.TextBox()
        Me.MedicationInputBox = New System.Windows.Forms.TextBox()
        Me.LengthOfStayInputBox = New System.Windows.Forms.TextBox()
        Me.TotalCostPanel = New System.Windows.Forms.Panel()
        Me.TotalCost = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearFormButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.InputValuesPanel.SuspendLayout()
        Me.TotalCostPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputValuesPanel
        '
        Me.InputValuesPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.InputValuesPanel.Controls.Add(Me.ErrorMessageLabel)
        Me.InputValuesPanel.Controls.Add(Me.PhysicalRehabLabel)
        Me.InputValuesPanel.Controls.Add(Me.LabFeesLabel)
        Me.InputValuesPanel.Controls.Add(Me.SurgicalChargesLabel)
        Me.InputValuesPanel.Controls.Add(Me.MedicationLabel)
        Me.InputValuesPanel.Controls.Add(Me.lengthOfStayLabel)
        Me.InputValuesPanel.Controls.Add(Me.PhysicalRehabInputBox)
        Me.InputValuesPanel.Controls.Add(Me.LabFeesInputBox)
        Me.InputValuesPanel.Controls.Add(Me.SurgicalChargesInputBox)
        Me.InputValuesPanel.Controls.Add(Me.MedicationInputBox)
        Me.InputValuesPanel.Controls.Add(Me.LengthOfStayInputBox)
        Me.InputValuesPanel.Location = New System.Drawing.Point(12, 12)
        Me.InputValuesPanel.Name = "InputValuesPanel"
        Me.InputValuesPanel.Size = New System.Drawing.Size(375, 227)
        Me.InputValuesPanel.TabIndex = 0
        '
        'ErrorMessageLabel
        '
        Me.ErrorMessageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ErrorMessageLabel.Location = New System.Drawing.Point(17, 192)
        Me.ErrorMessageLabel.Name = "ErrorMessageLabel"
        Me.ErrorMessageLabel.Size = New System.Drawing.Size(339, 23)
        Me.ErrorMessageLabel.TabIndex = 10
        Me.ErrorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PhysicalRehabLabel
        '
        Me.PhysicalRehabLabel.AutoSize = True
        Me.PhysicalRehabLabel.Location = New System.Drawing.Point(49, 162)
        Me.PhysicalRehabLabel.Name = "PhysicalRehabLabel"
        Me.PhysicalRehabLabel.Size = New System.Drawing.Size(103, 16)
        Me.PhysicalRehabLabel.TabIndex = 9
        Me.PhysicalRehabLabel.Text = "Physical Rehab"
        '
        'LabFeesLabel
        '
        Me.LabFeesLabel.AutoSize = True
        Me.LabFeesLabel.Location = New System.Drawing.Point(87, 130)
        Me.LabFeesLabel.Name = "LabFeesLabel"
        Me.LabFeesLabel.Size = New System.Drawing.Size(65, 16)
        Me.LabFeesLabel.TabIndex = 8
        Me.LabFeesLabel.Text = "Lab Fees"
        '
        'SurgicalChargesLabel
        '
        Me.SurgicalChargesLabel.AutoSize = True
        Me.SurgicalChargesLabel.Location = New System.Drawing.Point(41, 96)
        Me.SurgicalChargesLabel.Name = "SurgicalChargesLabel"
        Me.SurgicalChargesLabel.Size = New System.Drawing.Size(111, 16)
        Me.SurgicalChargesLabel.TabIndex = 7
        Me.SurgicalChargesLabel.Text = "Surgical Charges"
        '
        'MedicationLabel
        '
        Me.MedicationLabel.AutoSize = True
        Me.MedicationLabel.Location = New System.Drawing.Point(78, 65)
        Me.MedicationLabel.Name = "MedicationLabel"
        Me.MedicationLabel.Size = New System.Drawing.Size(74, 16)
        Me.MedicationLabel.TabIndex = 6
        Me.MedicationLabel.Text = "Medication"
        '
        'lengthOfStayLabel
        '
        Me.lengthOfStayLabel.AutoSize = True
        Me.lengthOfStayLabel.Location = New System.Drawing.Point(17, 31)
        Me.lengthOfStayLabel.Name = "lengthOfStayLabel"
        Me.lengthOfStayLabel.Size = New System.Drawing.Size(135, 16)
        Me.lengthOfStayLabel.TabIndex = 5
        Me.lengthOfStayLabel.Text = "Length of Stay (Days)"
        '
        'PhysicalRehabInputBox
        '
        Me.PhysicalRehabInputBox.Location = New System.Drawing.Point(179, 159)
        Me.PhysicalRehabInputBox.Name = "PhysicalRehabInputBox"
        Me.PhysicalRehabInputBox.Size = New System.Drawing.Size(100, 22)
        Me.PhysicalRehabInputBox.TabIndex = 4
        '
        'LabFeesInputBox
        '
        Me.LabFeesInputBox.Location = New System.Drawing.Point(179, 127)
        Me.LabFeesInputBox.Name = "LabFeesInputBox"
        Me.LabFeesInputBox.Size = New System.Drawing.Size(100, 22)
        Me.LabFeesInputBox.TabIndex = 3
        '
        'SurgicalChargesInputBox
        '
        Me.SurgicalChargesInputBox.Location = New System.Drawing.Point(179, 93)
        Me.SurgicalChargesInputBox.Name = "SurgicalChargesInputBox"
        Me.SurgicalChargesInputBox.Size = New System.Drawing.Size(100, 22)
        Me.SurgicalChargesInputBox.TabIndex = 2
        '
        'MedicationInputBox
        '
        Me.MedicationInputBox.Location = New System.Drawing.Point(179, 62)
        Me.MedicationInputBox.Name = "MedicationInputBox"
        Me.MedicationInputBox.Size = New System.Drawing.Size(100, 22)
        Me.MedicationInputBox.TabIndex = 1
        '
        'LengthOfStayInputBox
        '
        Me.LengthOfStayInputBox.Location = New System.Drawing.Point(179, 28)
        Me.LengthOfStayInputBox.Name = "LengthOfStayInputBox"
        Me.LengthOfStayInputBox.Size = New System.Drawing.Size(100, 22)
        Me.LengthOfStayInputBox.TabIndex = 0
        '
        'TotalCostPanel
        '
        Me.TotalCostPanel.Controls.Add(Me.TotalCost)
        Me.TotalCostPanel.Controls.Add(Me.totalCostLabel)
        Me.TotalCostPanel.Location = New System.Drawing.Point(12, 249)
        Me.TotalCostPanel.Name = "TotalCostPanel"
        Me.TotalCostPanel.Size = New System.Drawing.Size(375, 39)
        Me.TotalCostPanel.TabIndex = 1
        '
        'TotalCost
        '
        Me.TotalCost.Cursor = System.Windows.Forms.Cursors.Default
        Me.TotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCost.Location = New System.Drawing.Point(206, 12)
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Size = New System.Drawing.Size(150, 16)
        Me.TotalCost.TabIndex = 1
        '
        'totalCostLabel
        '
        Me.totalCostLabel.AutoSize = True
        Me.totalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCostLabel.Location = New System.Drawing.Point(111, 12)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(87, 16)
        Me.totalCostLabel.TabIndex = 0
        Me.totalCostLabel.Text = "Total Cost: "
        '
        'CalculateButton
        '
        Me.CalculateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CalculateButton.Location = New System.Drawing.Point(12, 305)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(137, 49)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calculate Charges"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearFormButton
        '
        Me.ClearFormButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearFormButton.Location = New System.Drawing.Point(172, 305)
        Me.ClearFormButton.Name = "ClearFormButton"
        Me.ClearFormButton.Size = New System.Drawing.Size(109, 49)
        Me.ClearFormButton.TabIndex = 3
        Me.ClearFormButton.Text = "Clear Form"
        Me.ClearFormButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(301, 305)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(86, 49)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'HospitalCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 371)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearFormButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalCostPanel)
        Me.Controls.Add(Me.InputValuesPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HospitalCharges"
        Me.Text = "Hospital Charges"
        Me.InputValuesPanel.ResumeLayout(False)
        Me.InputValuesPanel.PerformLayout()
        Me.TotalCostPanel.ResumeLayout(False)
        Me.TotalCostPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputValuesPanel As Panel
    Friend WithEvents LabFeesLabel As Label
    Friend WithEvents SurgicalChargesLabel As Label
    Friend WithEvents MedicationLabel As Label
    Friend WithEvents lengthOfStayLabel As Label
    Friend WithEvents PhysicalRehabInputBox As TextBox
    Friend WithEvents LabFeesInputBox As TextBox
    Friend WithEvents SurgicalChargesInputBox As TextBox
    Friend WithEvents MedicationInputBox As TextBox
    Friend WithEvents LengthOfStayInputBox As TextBox
    Friend WithEvents TotalCostPanel As Panel
    Friend WithEvents TotalCost As Label
    Friend WithEvents totalCostLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearFormButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PhysicalRehabLabel As Label
    Friend WithEvents ErrorMessageLabel As Label
End Class
