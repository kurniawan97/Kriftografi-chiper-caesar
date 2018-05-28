<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.plain = New System.Windows.Forms.TextBox()
        Me.btnenkripsi = New System.Windows.Forms.Button()
        Me.btndeskripsi = New System.Windows.Forms.Button()
        Me.chiper = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.number = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.plain2 = New System.Windows.Forms.TextBox()
        Me.chiper2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.number, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plain
        '
        Me.plain.Location = New System.Drawing.Point(140, 80)
        Me.plain.Multiline = True
        Me.plain.Name = "plain"
        Me.plain.Size = New System.Drawing.Size(411, 63)
        Me.plain.TabIndex = 0
        '
        'btnenkripsi
        '
        Me.btnenkripsi.Location = New System.Drawing.Point(559, 119)
        Me.btnenkripsi.Name = "btnenkripsi"
        Me.btnenkripsi.Size = New System.Drawing.Size(137, 54)
        Me.btnenkripsi.TabIndex = 2
        Me.btnenkripsi.Text = "Enkripsi"
        Me.btnenkripsi.UseVisualStyleBackColor = True
        '
        'btndeskripsi
        '
        Me.btndeskripsi.Location = New System.Drawing.Point(559, 271)
        Me.btndeskripsi.Name = "btndeskripsi"
        Me.btndeskripsi.Size = New System.Drawing.Size(137, 54)
        Me.btndeskripsi.TabIndex = 3
        Me.btndeskripsi.Text = "Deskripsi"
        Me.btndeskripsi.UseVisualStyleBackColor = True
        '
        'chiper
        '
        Me.chiper.Location = New System.Drawing.Point(140, 149)
        Me.chiper.Multiline = True
        Me.chiper.Name = "chiper"
        Me.chiper.Size = New System.Drawing.Size(411, 59)
        Me.chiper.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(364, 383)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 57)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 57)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kriptografi"
        '
        'number
        '
        Me.number.Location = New System.Drawing.Point(589, 206)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(68, 20)
        Me.number.TabIndex = 10
        Me.number.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(558, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Key"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'plain2
        '
        Me.plain2.Location = New System.Drawing.Point(140, 301)
        Me.plain2.Multiline = True
        Me.plain2.Name = "plain2"
        Me.plain2.Size = New System.Drawing.Size(411, 59)
        Me.plain2.TabIndex = 13
        '
        'chiper2
        '
        Me.chiper2.Location = New System.Drawing.Point(140, 232)
        Me.chiper2.Multiline = True
        Me.chiper2.Name = "chiper2"
        Me.chiper2.Size = New System.Drawing.Size(411, 63)
        Me.chiper2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Chiper Text"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Chiper Text"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Plain Text"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Plain Text"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(708, 481)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.plain2)
        Me.Controls.Add(Me.chiper2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chiper)
        Me.Controls.Add(Me.btndeskripsi)
        Me.Controls.Add(Me.btnenkripsi)
        Me.Controls.Add(Me.plain)
        Me.Name = "Form1"
        Me.Text = "Caesar Chiper"
        CType(Me.number, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents plain As System.Windows.Forms.TextBox
    Friend WithEvents btnenkripsi As System.Windows.Forms.Button
    Friend WithEvents btndeskripsi As System.Windows.Forms.Button
    Friend WithEvents chiper As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents number As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents plain2 As System.Windows.Forms.TextBox
    Friend WithEvents chiper2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
