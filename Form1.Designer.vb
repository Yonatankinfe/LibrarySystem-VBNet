<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        view_book = New Button()
        Label1 = New Label()
        remove_book = New Button()
        add_book = New Button()
        ListView1 = New ListView()
        Label2 = New Label()
        Label3 = New Label()
        rent = New Button()
        SuspendLayout()
        ' 
        ' view_book
        ' 
        view_book.BackColor = Color.Turquoise
        view_book.Font = New Font("Sans Serif Collection", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        view_book.ForeColor = SystemColors.ButtonHighlight
        view_book.Location = New Point(12, 100)
        view_book.Name = "view_book"
        view_book.Size = New Size(239, 79)
        view_book.TabIndex = 0
        view_book.Text = "View Book's"
        view_book.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DodgerBlue
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(15, 9)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(315, 20, 400, 20)
        Label1.Size = New Size(998, 75)
        Label1.TabIndex = 1
        Label1.Text = "Hellow! Welcome back"
        ' 
        ' remove_book
        ' 
        remove_book.BackColor = Color.Crimson
        remove_book.FlatAppearance.BorderSize = 0
        remove_book.Font = New Font("Sans Serif Collection", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        remove_book.ForeColor = SystemColors.ButtonHighlight
        remove_book.Location = New Point(517, 100)
        remove_book.Name = "remove_book"
        remove_book.Size = New Size(244, 79)
        remove_book.TabIndex = 2
        remove_book.Text = "Remove Book"
        remove_book.UseVisualStyleBackColor = False
        ' 
        ' add_book
        ' 
        add_book.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        add_book.Font = New Font("Sans Serif Collection", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        add_book.ForeColor = SystemColors.ButtonHighlight
        add_book.Location = New Point(257, 100)
        add_book.Name = "add_book"
        add_book.Size = New Size(254, 79)
        add_book.TabIndex = 3
        add_book.Text = "Add book"
        add_book.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.WhiteSmoke
        ListView1.Location = New Point(15, 253)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(977, 273)
        ListView1.TabIndex = 5
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DeepSkyBlue
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(15, 197)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 8, 819, 8)
        Label2.Size = New Size(993, 36)
        Label2.TabIndex = 6
        Label2.Text = "Recently Added Bookes"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DeepSkyBlue
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(15, 548)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 8, 840, 8)
        Label3.Size = New Size(991, 36)
        Label3.TabIndex = 7
        Label3.Text = "Admin Desktop App"
        ' 
        ' rent
        ' 
        rent.BackColor = Color.Orange
        rent.FlatAppearance.BorderSize = 0
        rent.Font = New Font("Sans Serif Collection", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rent.ForeColor = SystemColors.ButtonHighlight
        rent.Location = New Point(769, 100)
        rent.Name = "rent"
        rent.Size = New Size(223, 79)
        rent.TabIndex = 8
        rent.Text = "Rented Book"
        rent.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1040, 593)
        Controls.Add(rent)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Controls.Add(add_book)
        Controls.Add(remove_book)
        Controls.Add(Label1)
        Controls.Add(view_book)
        Name = "Form1"
        Text = "Home Admin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents view_book As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents remove_book As Button
    Friend WithEvents add_book As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rent As Button

End Class
