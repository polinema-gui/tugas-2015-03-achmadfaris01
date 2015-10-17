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
        Me.LabelPola = New System.Windows.Forms.Label()
        Me.ComboBoxPola = New System.Windows.Forms.ComboBox()
        Me.LabelBaris = New System.Windows.Forms.Label()
        Me.TextBoxBaris = New System.Windows.Forms.TextBox()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.TextBoxHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelPola
        '
        Me.LabelPola.AutoSize = True
        Me.LabelPola.Location = New System.Drawing.Point(13, 23)
        Me.LabelPola.Name = "LabelPola"
        Me.LabelPola.Size = New System.Drawing.Size(34, 13)
        Me.LabelPola.TabIndex = 0
        Me.LabelPola.Text = "Pola :"
        '
        'ComboBoxPola
        '
        Me.ComboBoxPola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPola.FormattingEnabled = True
        Me.ComboBoxPola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.ComboBoxPola.Location = New System.Drawing.Point(54, 14)
        Me.ComboBoxPola.Name = "ComboBoxPola"
        Me.ComboBoxPola.Size = New System.Drawing.Size(380, 21)
        Me.ComboBoxPola.TabIndex = 2
        '
        'LabelBaris
        '
        Me.LabelBaris.AutoSize = True
        Me.LabelBaris.Location = New System.Drawing.Point(13, 65)
        Me.LabelBaris.Name = "LabelBaris"
        Me.LabelBaris.Size = New System.Drawing.Size(36, 13)
        Me.LabelBaris.TabIndex = 2
        Me.LabelBaris.Text = "Baris :"
        '
        'TextBoxBaris
        '
        Me.TextBoxBaris.Location = New System.Drawing.Point(56, 65)
        Me.TextBoxBaris.Name = "TextBoxBaris"
        Me.TextBoxBaris.Size = New System.Drawing.Size(274, 20)
        Me.TextBoxBaris.TabIndex = 3
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(349, 61)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(85, 23)
        Me.ButtonProses.TabIndex = 4
        Me.ButtonProses.Text = "Proses"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'TextBoxHasil
        '
        Me.TextBoxHasil.Location = New System.Drawing.Point(16, 109)
        Me.TextBoxHasil.Multiline = True
        Me.TextBoxHasil.Name = "TextBoxHasil"
        Me.TextBoxHasil.Size = New System.Drawing.Size(418, 304)
        Me.TextBoxHasil.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.TextBoxHasil)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.TextBoxBaris)
        Me.Controls.Add(Me.LabelBaris)
        Me.Controls.Add(Me.ComboBoxPola)
        Me.Controls.Add(Me.LabelPola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPola As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPola As System.Windows.Forms.ComboBox
    Friend WithEvents LabelBaris As System.Windows.Forms.Label
    Friend WithEvents TextBoxBaris As System.Windows.Forms.TextBox
    Friend WithEvents ButtonProses As System.Windows.Forms.Button
    Friend WithEvents TextBoxHasil As System.Windows.Forms.TextBox
End Class
