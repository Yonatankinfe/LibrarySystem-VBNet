<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup
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
        Label1 = New Label()
        Label2 = New Label()
        username = New TextBox()
        Label4 = New Label()
        passowrd = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Location = New Point(62, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 57)
        Label1.TabIndex = 0
        Label1.Text = "Welcome Back"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MediumTurquoise
        Label2.Location = New Point(117, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 26)
        Label2.TabIndex = 1
        Label2.Text = "User name"
        ' 
        ' username
        ' 
        username.Location = New Point(117, 192)
        username.Name = "username"
        username.Size = New Size(202, 27)
        username.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MediumTurquoise
        Label4.Location = New Point(117, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 26)
        Label4.TabIndex = 4
        Label4.Text = "Password"
        ' 
        ' passowrd
        ' 
        passowrd.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        passowrd.Location = New Point(117, 277)
        passowrd.Name = "passowrd"
        passowrd.PasswordChar = "."c
        passowrd.Size = New Size(202, 32)
        passowrd.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(117, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(202, 57)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(99, 417)
        Label5.Name = "Label5"
        Label5.Size = New Size(190, 20)
        Label5.TabIndex = 7
        Label5.Text = "If you don't have account "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MintCream
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Blue
        Label6.Location = New Point(283, 417)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 20)
        Label6.TabIndex = 8
        Label6.Text = "Sign up"
        ' 
        ' signup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(434, 520)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(passowrd)
        Controls.Add(Label4)
        Controls.Add(username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "signup"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents passowrd As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
