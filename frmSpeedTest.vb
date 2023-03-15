Public Class frmSpeedTest
    Private Sub btnEnterSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterSpeed.Click
        ' declare variables
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strIBoxMsgOriginal As String = "Enter your home internet speed in Mbps, user #"
        Dim strIBoxMsg As String = "Enter your home internet speed in Mbps, user #"
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error - Input must be numeric; please re-enter input user #"
        Dim strNegErrMsg As String = "Error - Input cannot be negative or zero; please re-enter input user #"

        ' loop variables
        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        ' main input box loop
        Do Until intEntries > intMaxEntries Or strSpeed = ""
            ' validate speed as numeric
            If IsNumeric(strSpeed) Then
                ' convert speed to decimal
                decSpeed = Convert.ToDecimal(strSpeed)
                ' validate that decimal is positive
                If decSpeed > 0 Then
                    lstSpeeds.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsgOriginal
                Else
                    ' value entered was a negative number
                    strIBoxMsg = strNegErrMsg
                End If
            Else
                ' value entered was not numeric
                strIBoxMsg = strNotNumericErrMsg
            End If

            ' check if the entries have reached maximum; avoid recreating input box if so
            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If

        Loop

        ' make label visible
        lblAverageSpeed.Visible = True
        ' calculate and display average speed
        If intEntries > 1 Then
            ' calculate average
            decAverage = decSumOfSpeeds / (intEntries - 1)
            ' set text and display average in lblAverageSpeed
            lblAverageSpeed.Text = "Average Internet Speed: " & decAverage.ToString("F2") & " Mbps"
        Else
            lblAverageSpeed.Text = "No Speed Values Entered"
        End If

        btnEnterSpeed.Enabled = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear form elements
        lstSpeeds.Items.Clear()
        lblAverageSpeed.Text = ""
        lblAverageSpeed.Visible = False
        ' ensure input button is enabled
        btnEnterSpeed.Enabled = True

    End Sub

    Private Sub frmSpeedTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' clear form elements
        lstSpeeds.Items.Clear()
        lblAverageSpeed.Text = ""
        lblAverageSpeed.Visible = False
        ' ensure input button is enabled
        btnEnterSpeed.Enabled = True
    End Sub
End Class
