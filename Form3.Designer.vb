<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        ListView1 = New ListView()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DodgerBlue
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(18, 9)
        Label1.MinimumSize = New Size(0, 150)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(275, 20, 400, 20)
        Label1.Size = New Size(985, 150)
        Label1.TabIndex = 2
        Label1.Text = "Hellow! Welcome back"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(504, 79)
        Button1.TabIndex = 3
        Button1.Text = "View Books"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RoyalBlue
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(506, 162)
        Button2.Name = "Button2"
        Button2.Size = New Size(485, 79)
        Button2.TabIndex = 4
        Button2.Text = "Rent "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.CornflowerBlue
        Label2.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.ImageAlign = ContentAlignment.MiddleRight
        Label2.Location = New Point(18, 244)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(20, 8, 830, 8)
        Label2.Size = New Size(990, 38)
        Label2.TabIndex = 5
        Label2.Text = "Recently Added"
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.PowderBlue
        ListView1.Location = New Point(16, 285)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(975, 325)
        ListView1.TabIndex = 6
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Blue
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(18, 617)
        Label3.MinimumSize = New Size(200, 0)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(10, 5, 0, 5)
        Label3.Size = New Size(200, 30)
        Label3.TabIndex = 7
        Label3.Text = "User Page "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Blue
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Location = New Point(224, 617)
        Label4.MinimumSize = New Size(400, 0)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(20, 5, 20, 5)
        Label4.Size = New Size(400, 30)
        Label4.TabIndex = 8
        Label4.Text = "Open souce Project"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Blue
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Location = New Point(630, 617)
        Label5.MinimumSize = New Size(380, 0)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(20, 5, 20, 5)
        Label5.Size = New Size(380, 30)
        Label5.TabIndex = 9
        Label5.Text = "V1.0.0"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1020, 654)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ListView1)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "User_home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
