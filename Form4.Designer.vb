<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        book_name = New TextBox()
        Label2 = New Label()
        auther = New TextBox()
        Label3 = New Label()
        show_text = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(614, 29)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(0, 5, 0, 5)
        Button1.Size = New Size(174, 53)
        Button1.TabIndex = 0
        Button1.Text = "search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(23, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 28)
        Label1.TabIndex = 1
        Label1.Text = "Book Name"
        ' 
        ' book_name
        ' 
        book_name.Location = New Point(151, 42)
        book_name.Name = "book_name"
        book_name.Size = New Size(165, 27)
        book_name.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(322, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 28)
        Label2.TabIndex = 3
        Label2.Text = "Auther "
        ' 
        ' auther
        ' 
        auther.Location = New Point(411, 46)
        auther.Name = "auther"
        auther.Size = New Size(182, 27)
        auther.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Highlight
        Label3.Location = New Point(23, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 28)
        Label3.TabIndex = 5
        Label3.Text = "Search Result:"
        ' 
        ' show_text
        ' 
        show_text.Location = New Point(191, 127)
        show_text.Name = "show_text"
        show_text.ReadOnly = True
        show_text.Size = New Size(402, 27)
        show_text.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrange
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(614, 105)
        Button2.Name = "Button2"
        Button2.Size = New Size(174, 53)
        Button2.TabIndex = 7
        Button2.Text = "Rent"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 227)
        Controls.Add(Button2)
        Controls.Add(show_text)
        Controls.Add(Label3)
        Controls.Add(auther)
        Controls.Add(Label2)
        Controls.Add(book_name)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents book_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents auther As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents show_text As TextBox
    Friend WithEvents Button2 As Button
End Class
