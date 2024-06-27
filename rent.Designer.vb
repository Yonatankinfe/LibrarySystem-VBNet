<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rent
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
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(76, 316)
        Button1.Name = "Button1"
        Button1.Size = New Size(494, 65)
        Button1.TabIndex = 15
        Button1.Text = "Remove BooK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(261, 204)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(276, 27)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(261, 161)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(276, 27)
        TextBox1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label4.Location = New Point(91, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 25)
        Label4.TabIndex = 11
        Label4.Text = "Auther Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(91, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 25)
        Label2.TabIndex = 9
        Label2.Text = "Book Name "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Red
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 21)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(200, 20, 200, 20)
        Label1.Size = New Size(577, 75)
        Label1.TabIndex = 8
        Label1.Text = "Remove Book"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(261, 125)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(276, 27)
        TextBox3.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label3.Location = New Point(91, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 25)
        Label3.TabIndex = 16
        Label3.Text = "Book id "
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(261, 250)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(276, 27)
        TextBox4.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label5.Location = New Point(91, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 25)
        Label5.TabIndex = 18
        Label5.Text = "Date of Publish"
        ' 
        ' rent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(615, 403)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "rent"
        Text = "Remove Book"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
End Class
