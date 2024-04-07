<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtAmount = New TextBox()
        grpATMOperations = New GroupBox()
        Label1 = New Label()
        btnExit = New Button()
        btnDeposit = New Button()
        btnCheckBalance = New Button()
        btnWithdraw = New Button()
        GroupBox2 = New GroupBox()
        btnLogin = New Button()
        txtPIN = New TextBox()
        txtUsername = New TextBox()
        lblPIN = New Label()
        lblUsername = New Label()
        grpATMOperations.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(377, 310)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(167, 31)
        txtAmount.TabIndex = 0
        ' 
        ' grpATMOperations
        ' 
        grpATMOperations.BackColor = SystemColors.AppWorkspace
        grpATMOperations.Controls.Add(Label1)
        grpATMOperations.Controls.Add(txtAmount)
        grpATMOperations.Controls.Add(btnExit)
        grpATMOperations.Controls.Add(btnDeposit)
        grpATMOperations.Controls.Add(btnCheckBalance)
        grpATMOperations.Controls.Add(btnWithdraw)
        grpATMOperations.Location = New Point(12, 13)
        grpATMOperations.Margin = New Padding(3, 4, 3, 4)
        grpATMOperations.Name = "grpATMOperations"
        grpATMOperations.Padding = New Padding(3, 4, 3, 4)
        grpATMOperations.Size = New Size(596, 388)
        grpATMOperations.TabIndex = 0
        grpATMOperations.TabStop = False
        grpATMOperations.Text = "ATM Operations"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(6, 310)
        Label1.Name = "Label1"
        Label1.Size = New Size(355, 25)
        Label1.TabIndex = 4
        Label1.Text = "Input Amount To Be Withdrawn/Deposited:"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.SteelBlue
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(377, 164)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(167, 62)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.SteelBlue
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(377, 46)
        btnDeposit.Margin = New Padding(3, 4, 3, 4)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(167, 62)
        btnDeposit.TabIndex = 2
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = True
        ' 
        ' btnCheckBalance
        ' 
        btnCheckBalance.BackColor = Color.SteelBlue
        btnCheckBalance.FlatStyle = FlatStyle.Flat
        btnCheckBalance.ForeColor = Color.White
        btnCheckBalance.Location = New Point(17, 174)
        btnCheckBalance.Margin = New Padding(3, 4, 3, 4)
        btnCheckBalance.Name = "btnCheckBalance"
        btnCheckBalance.Size = New Size(167, 62)
        btnCheckBalance.TabIndex = 1
        btnCheckBalance.Text = "Check Balance"
        btnCheckBalance.UseVisualStyleBackColor = True
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.SteelBlue
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.ForeColor = Color.White
        btnWithdraw.Location = New Point(17, 46)
        btnWithdraw.Margin = New Padding(3, 4, 3, 4)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(167, 62)
        btnWithdraw.TabIndex = 0
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.AppWorkspace
        GroupBox2.Controls.Add(btnLogin)
        GroupBox2.Controls.Add(txtPIN)
        GroupBox2.Controls.Add(txtUsername)
        GroupBox2.Controls.Add(lblPIN)
        GroupBox2.Controls.Add(lblUsername)
        GroupBox2.Location = New Point(664, 13)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(412, 209)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Login"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(142, 144)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(111, 44)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPIN
        ' 
        txtPIN.Location = New Point(142, 99)
        txtPIN.Margin = New Padding(3, 4, 3, 4)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(222, 31)
        txtPIN.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(142, 46)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(222, 31)
        txtUsername.TabIndex = 2
        ' 
        ' lblPIN
        ' 
        lblPIN.AutoSize = True
        lblPIN.Location = New Point(18, 102)
        lblPIN.Name = "lblPIN"
        lblPIN.Size = New Size(44, 25)
        lblPIN.TabIndex = 1
        lblPIN.Text = "PIN:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(18, 50)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(95, 25)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(1094, 433)
        Controls.Add(GroupBox2)
        Controls.Add(grpATMOperations)
        ForeColor = SystemColors.HotTrack
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ATM Simulator"
        grpATMOperations.ResumeLayout(False)
        grpATMOperations.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)




    End Sub

    Friend WithEvents grpATMOperations As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPIN As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
End Class
