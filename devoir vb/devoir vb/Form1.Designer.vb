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
        grpbx1 = New GroupBox()
        errlab5 = New Label()
        errlab4 = New Label()
        txt3 = New TextBox()
        lab4 = New Label()
        bt1 = New Button()
        errlab3 = New Label()
        txt2 = New TextBox()
        lab3 = New Label()
        errlab2 = New Label()
        errlab1 = New Label()
        rad2 = New RadioButton()
        rad1 = New RadioButton()
        lab2 = New Label()
        txt1 = New TextBox()
        lab1 = New Label()
        grpbx1.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpbx1
        ' 
        grpbx1.Controls.Add(errlab5)
        grpbx1.Controls.Add(errlab4)
        grpbx1.Controls.Add(txt3)
        grpbx1.Controls.Add(lab4)
        grpbx1.Controls.Add(bt1)
        grpbx1.Controls.Add(errlab3)
        grpbx1.Controls.Add(txt2)
        grpbx1.Controls.Add(lab3)
        grpbx1.Controls.Add(errlab2)
        grpbx1.Controls.Add(errlab1)
        grpbx1.Controls.Add(rad2)
        grpbx1.Controls.Add(rad1)
        grpbx1.Controls.Add(lab2)
        grpbx1.Controls.Add(txt1)
        grpbx1.Controls.Add(lab1)
        grpbx1.Location = New Point(12, 24)
        grpbx1.Name = "grpbx1"
        grpbx1.Size = New Size(454, 257)
        grpbx1.TabIndex = 0
        grpbx1.TabStop = False
        grpbx1.Text = "gestion enregistrement taxi"
        ' 
        ' errlab5
        ' 
        errlab5.AutoSize = True
        errlab5.Location = New Point(351, 239)
        errlab5.Name = "errlab5"
        errlab5.Size = New Size(0, 15)
        errlab5.TabIndex = 14
        ' 
        ' errlab4
        ' 
        errlab4.AutoSize = True
        errlab4.Location = New Point(318, 190)
        errlab4.Name = "errlab4"
        errlab4.Size = New Size(0, 15)
        errlab4.TabIndex = 13
        ' 
        ' txt3
        ' 
        txt3.Location = New Point(181, 182)
        txt3.Name = "txt3"
        txt3.Size = New Size(100, 23)
        txt3.TabIndex = 12
        ' 
        ' lab4
        ' 
        lab4.AutoSize = True
        lab4.Location = New Point(27, 185)
        lab4.Name = "lab4"
        lab4.Size = New Size(87, 15)
        lab4.TabIndex = 11
        lab4.Text = "LOCALISATION"
        ' 
        ' bt1
        ' 
        bt1.Location = New Point(192, 222)
        bt1.Name = "bt1"
        bt1.Size = New Size(119, 35)
        bt1.TabIndex = 10
        bt1.Text = "SAVE"
        bt1.UseVisualStyleBackColor = True
        ' 
        ' errlab3
        ' 
        errlab3.AutoSize = True
        errlab3.Location = New Point(387, 151)
        errlab3.Name = "errlab3"
        errlab3.Size = New Size(0, 15)
        errlab3.TabIndex = 9
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(181, 143)
        txt2.Name = "txt2"
        txt2.Size = New Size(178, 23)
        txt2.TabIndex = 8
        ' 
        ' lab3
        ' 
        lab3.AutoSize = True
        lab3.Location = New Point(21, 151)
        lab3.Name = "lab3"
        lab3.Size = New Size(62, 15)
        lab3.TabIndex = 7
        lab3.Text = "NOM TAXI"
        ' 
        ' errlab2
        ' 
        errlab2.AutoSize = True
        errlab2.Location = New Point(351, 99)
        errlab2.Name = "errlab2"
        errlab2.Size = New Size(0, 15)
        errlab2.TabIndex = 6
        ' 
        ' errlab1
        ' 
        errlab1.AutoSize = True
        errlab1.Location = New Point(418, 54)
        errlab1.Name = "errlab1"
        errlab1.Size = New Size(0, 15)
        errlab1.TabIndex = 5
        ' 
        ' rad2
        ' 
        rad2.AutoSize = True
        rad2.Location = New Point(275, 95)
        rad2.Name = "rad2"
        rad2.Size = New Size(42, 19)
        rad2.TabIndex = 4
        rad2.TabStop = True
        rad2.Text = "VIP"
        rad2.UseVisualStyleBackColor = True
        ' 
        ' rad1
        ' 
        rad1.AutoSize = True
        rad1.Location = New Point(137, 97)
        rad1.Name = "rad1"
        rad1.Size = New Size(70, 19)
        rad1.TabIndex = 3
        rad1.TabStop = True
        rad1.Text = "CLASSIC"
        rad1.UseVisualStyleBackColor = True
        ' 
        ' lab2
        ' 
        lab2.AutoSize = True
        lab2.Location = New Point(21, 99)
        lab2.Name = "lab2"
        lab2.Size = New Size(47, 15)
        lab2.TabIndex = 2
        lab2.Text = "CLASSE"
        ' 
        ' txt1
        ' 
        txt1.AcceptsReturn = True
        txt1.Location = New Point(220, 54)
        txt1.Name = "txt1"
        txt1.Size = New Size(183, 23)
        txt1.TabIndex = 1
        ' 
        ' lab1
        ' 
        lab1.AutoSize = True
        lab1.Location = New Point(21, 54)
        lab1.Name = "lab1"
        lab1.Size = New Size(129, 15)
        lab1.TabIndex = 0
        lab1.Text = "ENREGISTREMENT TAXI"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grpbx1)
        Name = "Form1"
        Text = "Form1"
        grpbx1.ResumeLayout(False)
        grpbx1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpbx1 As GroupBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents lab1 As Label
    Friend WithEvents rad2 As RadioButton
    Friend WithEvents rad1 As RadioButton
    Friend WithEvents lab2 As Label
    Friend WithEvents errlab2 As Label
    Friend WithEvents errlab1 As Label
    Friend WithEvents errlab3 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents lab3 As Label
    Friend WithEvents errlab5 As Label
    Friend WithEvents errlab4 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents lab4 As Label
    Friend WithEvents bt1 As Button
End Class
