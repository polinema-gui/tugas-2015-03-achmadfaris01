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
        Me.LabelMatrix = New System.Windows.Forms.Label()
        Me.TextBoxMatrix1 = New System.Windows.Forms.TextBox()
        Me.LabelOperasi = New System.Windows.Forms.Label()
        Me.ComboBoxOperasi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxMatrix2 = New System.Windows.Forms.TextBox()
        Me.LabelHasil = New System.Windows.Forms.Label()
        Me.TextBoxHasil = New System.Windows.Forms.TextBox()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelMatrix
        '
        Me.LabelMatrix.AutoSize = True
        Me.LabelMatrix.Location = New System.Drawing.Point(13, 13)
        Me.LabelMatrix.Name = "LabelMatrix"
        Me.LabelMatrix.Size = New System.Drawing.Size(44, 13)
        Me.LabelMatrix.TabIndex = 0
        Me.LabelMatrix.Text = "Matrix 1"
        '
        'TextBoxMatrix1
        '
        Me.TextBoxMatrix1.Location = New System.Drawing.Point(64, 13)
        Me.TextBoxMatrix1.Multiline = True
        Me.TextBoxMatrix1.Name = "TextBoxMatrix1"
        Me.TextBoxMatrix1.Size = New System.Drawing.Size(355, 88)
        Me.TextBoxMatrix1.TabIndex = 1
        '
        'LabelOperasi
        '
        Me.LabelOperasi.AutoSize = True
        Me.LabelOperasi.Location = New System.Drawing.Point(12, 110)
        Me.LabelOperasi.Name = "LabelOperasi"
        Me.LabelOperasi.Size = New System.Drawing.Size(43, 13)
        Me.LabelOperasi.TabIndex = 2
        Me.LabelOperasi.Text = "Operasi"
        '
        'ComboBoxOperasi
        '
        Me.ComboBoxOperasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxOperasi.FormattingEnabled = True
        Me.ComboBoxOperasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.ComboBoxOperasi.Location = New System.Drawing.Point(64, 110)
        Me.ComboBoxOperasi.Name = "ComboBoxOperasi"
        Me.ComboBoxOperasi.Size = New System.Drawing.Size(355, 21)
        Me.ComboBoxOperasi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Matrix 2"
        '
        'TextBoxMatrix2
        '
        Me.TextBoxMatrix2.Location = New System.Drawing.Point(64, 149)
        Me.TextBoxMatrix2.Multiline = True
        Me.TextBoxMatrix2.Name = "TextBoxMatrix2"
        Me.TextBoxMatrix2.Size = New System.Drawing.Size(355, 90)
        Me.TextBoxMatrix2.TabIndex = 5
        '
        'LabelHasil
        '
        Me.LabelHasil.AutoSize = True
        Me.LabelHasil.Location = New System.Drawing.Point(14, 265)
        Me.LabelHasil.Name = "LabelHasil"
        Me.LabelHasil.Size = New System.Drawing.Size(30, 13)
        Me.LabelHasil.TabIndex = 6
        Me.LabelHasil.Text = "Hasil"
        '
        'TextBoxHasil
        '
        Me.TextBoxHasil.Location = New System.Drawing.Point(64, 265)
        Me.TextBoxHasil.Multiline = True
        Me.TextBoxHasil.Name = "TextBoxHasil"
        Me.TextBoxHasil.Size = New System.Drawing.Size(355, 91)
        Me.TextBoxHasil.TabIndex = 7
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(344, 367)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProses.TabIndex = 8
        Me.ButtonProses.Text = "Proses"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.TextBoxHasil)
        Me.Controls.Add(Me.LabelHasil)
        Me.Controls.Add(Me.TextBoxMatrix2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxOperasi)
        Me.Controls.Add(Me.LabelOperasi)
        Me.Controls.Add(Me.TextBoxMatrix1)
        Me.Controls.Add(Me.LabelMatrix)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMatrix As System.Windows.Forms.Label
    Friend WithEvents TextBoxMatrix1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOperasi As System.Windows.Forms.Label
    Friend WithEvents ComboBoxOperasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMatrix2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelHasil As System.Windows.Forms.Label
    Friend WithEvents TextBoxHasil As System.Windows.Forms.TextBox
    Friend WithEvents ButtonProses As System.Windows.Forms.Button
End Class
