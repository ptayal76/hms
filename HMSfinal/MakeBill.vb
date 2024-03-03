Public Class MakeBill

    Private medicines As New List(Of Tuple(Of String, String, Double, Integer)) From {
        Tuple.Create("Dolo", "Antidepressent", 12.0, 20),
        Tuple.Create("Panadol", "Painkiller", 10.0, 15),
        Tuple.Create("Aspirin", "Anthistamine", 8.0, 30),
        Tuple.Create("Benadryl", "Antihistamine", 15.0, 10),
        Tuple.Create("Cough Syrup", "Medicine", 20.0, 25)
    }

    Dim data As String(,) = {}
    Private filtering As Boolean = False


    Private Sub MakeBill_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate the DataGridView with initial data
        For i As Integer = 0 To data.GetLength(0) - 1
            Dim rowData(data.GetLength(1) - 1) As String
            For j As Integer = 0 To data.GetLength(1) - 1
                rowData(j) = data(i, j)
            Next
            medicineTableBil.Rows.Add(rowData)
        Next

        ' Populate the ComboBox with medicine names
        For Each dummy In medicines
            medicineComboBox.Items.Add(dummy.Item1)
        Next
        ' Attach event handler to the DataGridView
        AddHandler medicineTableBil.CellMouseDown, AddressOf DataGridView_CellMouseDown
    End Sub

    Private Sub DataGridView_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            medicineTableBil.ClearSelection()
            medicineTableBil.Rows(e.RowIndex).Selected = True
            DeleteRowToolStripMenuItem.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        If medicineTableBil.SelectedRows.Count > 0 Then
            medicineTableBil.Rows.Remove(medicineTableBil.SelectedRows(0))
        End If
    End Sub

    Private Sub quantityVal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles quantityValue.KeyPress
        ' Check whether entered text is a valid integer
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub medicineComboBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles medicineComboBox.TextChanged
        If Not filtering Then
            ' Store the current cursor position
            Dim selectionStart As Integer = medicineComboBox.SelectionStart
            Dim selectionLength As Integer = medicineComboBox.SelectionLength

            ' Filter the items in the ComboBox based on the entered text
            Dim enteredText As String = medicineComboBox.Text.ToLower()

            ' Check for exact match
            Dim exactMatch = medicines.FirstOrDefault(Function(m) m.Item1.ToLower() = enteredText)

            ' If there's an exact match, select it
            If exactMatch IsNot Nothing Then
                medicineComboBox.SelectedItem = exactMatch.Item1

                Dim selectedMedicineDetails = medicines.Find(Function(m) m.Item1 = exactMatch.Item1)
                Dim type As String = selectedMedicineDetails.Item2
                Dim rate As Double = selectedMedicineDetails.Item3
                Dim stock As Integer = selectedMedicineDetails.Item4
                rateValue.Text = rate.ToString()
                stockValue.Text = stock.ToString()
                typeValue.Text = type

                ' Check stock before calculating the amount
                CheckStock()

                ' Calculate the amount
                CalculateAmount()

            Else
                ' Otherwise, filter the items
                Dim filteredMedicines = From m In medicines Where m.Item1.ToLower().StartsWith(enteredText) Select m.Item1

                ' Clear and repopulate the ComboBox with filtered items
                filtering = True ' Set filtering flag to true to prevent SelectedIndexChanged event
                medicineComboBox.Items.Clear()
                For Each medicineName In filteredMedicines
                    medicineComboBox.Items.Add(medicineName)
                Next
                medicineComboBox.DroppedDown = True
                filtering = False ' Reset filtering flag

                ' Reset the cursor position after a delay
                BeginInvoke(Sub()
                                medicineComboBox.Select(selectionStart, selectionLength)
                                Cursor.Position = medicineComboBox.PointToScreen(New Point(medicineComboBox.Width, medicineComboBox.Height))
                            End Sub)
            End If
        End If
    End Sub



    Private Sub medicineComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles medicineComboBox.SelectedIndexChanged
        If medicineComboBox.SelectedItem IsNot Nothing AndAlso Not filtering Then
            ' Get the selected item from the ComboBox
            Dim selectedMedicine = medicineComboBox.SelectedItem.ToString()

            ' Update other controls based on the selected medicine
            Dim selectedMedicineDetails = medicines.Find(Function(m) m.Item1 = selectedMedicine)
            Dim type As String = selectedMedicineDetails.Item2
            Dim rate As Double = selectedMedicineDetails.Item3
            Dim stock As Integer = selectedMedicineDetails.Item4
            rateValue.Text = rate.ToString()
            stockValue.Text = stock.ToString()
            typeValue.Text = type

            ' Check stock before calculating the amount
            CheckStock()

            ' Calculate the amount
            CalculateAmount()
        End If
    End Sub



    Private Sub quantityVal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles quantityValue.TextChanged
        ' Calculate the amount whenever the quantity changes
        CalculateAmount()
        CheckStock()
    End Sub

    Private Sub CalculateAmount()
        ' Check if both medicine and quantity are selected
        If Not String.IsNullOrEmpty(medicineComboBox.Text) AndAlso IsNumeric(quantityValue.Text) Then
            ' Compute the amount

            Dim rate As Double = CDbl(rateValue.Text)
            Dim quantity As Integer = CInt(quantityValue.Text)
            Dim amount As Double = rate * quantity

            ' Update the amount label
            amountValue.Text = amount.ToString()
        Else
            ' Reset the amount label if either medicine or quantity is not selected
            amountValue.Text = ""
        End If
    End Sub
    Private Sub CheckStock()
        ' Check if both medicine and quantity are selected
        If Not String.IsNullOrEmpty(medicineComboBox.Text) AndAlso IsNumeric(stockValue.Text) Then
            ' Get the selected medicine's stock
            Dim stock As Integer = CInt(stockValue.Text)
            ' Get the entered quantity
            Dim quantity As Integer
            If Integer.TryParse(quantityValue.Text, quantity) Then
                ' If the entered quantity exceeds stock, display a warning
                If quantity > stock Then
                    ' Display a warning message or change the background color of the quantityVal TextBox
                    quantityValue.BackColor = Color.Red
                Else
                    ' Reset the background color of the quantityVal TextBox
                    quantityValue.BackColor = SystemColors.Window
                End If
            Else
                ' Reset the background color of the quantityVal TextBox if the entered value is not a valid integer
                quantityValue.BackColor = SystemColors.Window
            End If
        End If
    End Sub


    Private Sub addMedButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addMedButton.Click
        ' Get the selected medicine from the ComboBox
        Dim selectedMedicine As String = medicineComboBox.SelectedItem.ToString()

        ' Get the type label, rate, and stock of the selected medicine
        Dim selectedMedicineDetails = medicines.Find(Function(m) m.Item1 = selectedMedicine)
        Dim type As String = selectedMedicineDetails.Item2
        Dim rate As Double = selectedMedicineDetails.Item3
        Dim stock As Integer = selectedMedicineDetails.Item4

        ' Get the quantity from the TextBox
        Dim quantity As Integer
        If Integer.TryParse(quantityValue.Text, quantity) Then
            ' Check if the quantity exceeds the stock
            If quantity > stock Then
                MessageBox.Show("The entered quantity exceeds the available stock for " & selectedMedicine & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Calculate the amount based on the rate and quantity
            Dim amount As Double = rate * quantity

            ' Check if the medicine already exists in the medicineTableBil table
            Dim existingRow As DataGridViewRow = medicineTableBil.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(row) row.Cells("medicineCol").Value.ToString() = selectedMedicine)

            If existingRow IsNot Nothing Then
                ' If the medicine already exists, update the quantity and amount columns of the existing row
                Dim existingQuantity As Integer = Convert.ToInt32(existingRow.Cells("quantityCol").Value)
                existingRow.Cells("quantityCol").Value = existingQuantity + quantity

                Dim existingAmount As Double = Convert.ToDouble(existingRow.Cells("amountCol").Value)
                existingRow.Cells("amountCol").Value = existingAmount + amount
            Else
                ' If the medicine does not exist, add a new row with the details
                medicineTableBil.Rows.Add(selectedMedicine, type, rate.ToString(), quantity.ToString(), amount.ToString())
            End If

            ' Update the stock of the selected medicine in the medicines list
            Dim updatedStock As Integer = stock - quantity
            Dim updatedMedicineDetails = New Tuple(Of String, String, Double, Integer)(selectedMedicine, type, rate, updatedStock)
            Dim index As Integer = medicines.FindIndex(Function(m) m.Item1 = selectedMedicine)
            If index <> -1 Then
                medicines(index) = updatedMedicineDetails
            End If

            ' Clear the text box of quantity and combo box
            quantityValue.Text = ""
            medicineComboBox.Text = ""
            rateValue.Text = ""
            stockValue.Text = ""
            typeValue.Text = ""
            UpdateNetPrice()
        Else
            ' Show an error message if the quantity is not a valid integer
            MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub UpdateNetPrice()
        Dim totalAmount As Double = 0.0

        ' Iterate through each row in the medicineTableBil
        For Each row As DataGridViewRow In medicineTableBil.Rows
            ' Check if the row is not a new row and the amount cell is not null or empty
            If Not row.IsNewRow AndAlso Not IsNothing(row.Cells("amountCol").Value) AndAlso Not String.IsNullOrEmpty(row.Cells("amountCol").Value.ToString()) Then
                ' Parse the amount from the cell and add it to the totalAmount
                totalAmount += Convert.ToDouble(row.Cells("amountCol").Value)
            End If
        Next

        ' Update the netPrice label with the total amount
        netPriceValue.Text = totalAmount.ToString()
    End Sub


End Class
