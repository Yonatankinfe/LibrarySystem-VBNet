<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label4 = New Label()
        Label2 = New Label()
        username = New TextBox()
        password = New TextBox()
        Label3 = New Label()
        Admin = New RadioButton()
        user = New RadioButton()
        create = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(81, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 57)
        Label1.TabIndex = 1
        Label1.Text = "Create Account"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(158, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 26)
        Label4.TabIndex = 6
        Label4.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(158, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 26)
        Label2.TabIndex = 5
        Label2.Text = "User name"
        ' 
        ' username
        ' 
        username.Location = New Point(158, 167)
        username.Name = "username"
        username.Size = New Size(155, 27)
        username.TabIndex = 7
        ' 
        ' password
        ' 
        password.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        password.Location = New Point(158, 238)
        password.Name = "password"
        password.PasswordChar = "."c
        password.Size = New Size(155, 32)
        password.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MediumTurquoise
        Label3.Location = New Point(159, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 26)
        Label3.TabIndex = 10
        Label3.Text = "Select your Role"
        ' 
        ' Admin
        ' 
        Admin.AutoSize = True
        Admin.Location = New Point(175, 314)
        Admin.Name = "Admin"
        Admin.Size = New Size(74, 24)
        Admin.TabIndex = 11
        Admin.TabStop = True
        Admin.Text = "Admin"
        Admin.UseVisualStyleBackColor = True
        ' 
        ' user
        ' 
        user.AutoSize = True
        user.Location = New Point(175, 344)
        user.Name = "user"
        user.Size = New Size(59, 24)
        user.TabIndex = 12
        user.TabStop = True
        user.Text = "User"
        user.UseVisualStyleBackColor = True
        ' 
        ' create
        ' 
        create.BackColor = Color.RoyalBlue
        create.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        create.ForeColor = Color.White
        create.Location = New Point(99, 388)
        create.Name = "create"
        create.Size = New Size(309, 52)
        create.TabIndex = 13
        create.Text = "Sign up"
        create.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(485, 507)
        Controls.Add(create)
        Controls.Add(user)
        Controls.Add(Admin)
        Controls.Add(Label3)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Sign up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Admin As RadioButton
    Friend WithEvents user As RadioButton
    Friend WithEvents create As Button
End Class
