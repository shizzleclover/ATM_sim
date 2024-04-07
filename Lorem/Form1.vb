Public Class Form1
    ' Class-level variable for balance.
    Private bal As Integer = 200000 ' Example starting balance.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable ATM operations at start.
        'This blocks the ATM from working until the user inputs the username and password
        grpATMOperations.Enabled = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Simple check for username and PIN. Replace with real authentication in a real app.
        If txtUsername.Text = "user" AndAlso txtPIN.Text = "1234" Then
            grpATMOperations.Enabled = True ' Enable ATM operations on successful login.
            MessageBox.Show("Login Successful!")
        Else
            MessageBox.Show("Invalid username or PIN.")
        End If
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        ' Withdraw 
        Dim amount As Integer
        If Integer.TryParse(txtAmount.Text, amount) Then
            If amount > bal Then
                MessageBox.Show("Insufficient Funds. Your current balance is: $" & bal.ToString())
            Else
                bal -= amount
                MessageBox.Show("Withdrawal Successful. New Balance is: $" & bal.ToString())
            End If
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        ' Deposit 
        Dim amount As Integer
        If Integer.TryParse(txtAmount.Text, amount) Then
            bal += amount
            MessageBox.Show("Deposit Successful. New Balance is: ₦" & bal.ToString())
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        ' Check balance 
        MessageBox.Show("Your current balance is: $" & bal.ToString())
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application.
        Me.Close()
    End Sub
End Class
