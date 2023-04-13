' Programmer: ArRionne Hickson
' Date: 4 April 2023
' Program: Karaoke Music Night Applicaton
' Purpose: User selects which karaoke experience they want and how long they
' are renting the space. The program will return the cost of the experience to the user.
Public Class frmKaraoke
    Private _decSong As Decimal = 2.99D
    Private _decHourly As Decimal = 8.99D
    Private Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub
    Private Function ValidateInput() As Boolean
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            intNumber = Convert.ToInt32(txtInput.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0.", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount.", , "Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable amount.", , "Error")
        Catch Exception As SystemException
            MsgBox("Entry invalid. Please enter a valid number representing the number in your party.", , "Error")
        End Try
        txtInput.Focus()
        txtInput.Clear()
        Return blnValid

    End Function

    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong

        Return decPassCost
    End Function

    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourly

        Return decTicketCost
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cboSelection.SelectedIndex = -1
        lblTotal.Visible = False
        txtInput.Visible = False
        btnClear.Visible = False
        btnCost.Visible = False
        lblDisplay.Visible = False
        txtInput.Clear()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim blnAmountValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        blnAmountValid = ValidateInput()
        If blnAmountValid = True Then
            intValue = Convert.ToInt32(txtInput.Text)
            If cboSelection.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)
            End If

            lblTotal.Visible = True
            lblTotal.Text = "Total cost of Karaoke Night: " & decTotal.ToString("C")
        End If
    End Sub

    Private Sub cboSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelection.SelectedIndexChanged
        If cboSelection.SelectedIndex = 0 Then
            lblDisplay.Text = "Number of Karaoke Songs"
            lblDisplay.Visible = True
            txtInput.Visible = True
            btnCost.Visible = True
            btnClear.Visible = True
            txtInput.Focus()
        End If
        If cboSelection.SelectedIndex = 1 Then
            lblDisplay.Text = "Hourly Rental of Karaoke Room: "
            lblDisplay.Visible = True
            txtInput.Visible = True
            btnCost.Visible = True
            btnClear.Visible = True
            txtInput.Focus()
        End If
    End Sub
End Class
