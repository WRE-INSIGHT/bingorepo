<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BingoOption
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.patternTBOX = New System.Windows.Forms.TextBox()
        Me.priceTBOX = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.callspeedCbox = New System.Windows.Forms.ComboBox()
        Me.animationspeedCbox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.setCbox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.prevPatternTbox = New System.Windows.Forms.TextBox()
        Me.prevPriceTbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pattern"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prize"
        '
        'patternTBOX
        '
        Me.patternTBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patternTBOX.Location = New System.Drawing.Point(101, 30)
        Me.patternTBOX.Name = "patternTBOX"
        Me.patternTBOX.Size = New System.Drawing.Size(285, 23)
        Me.patternTBOX.TabIndex = 2
        '
        'priceTBOX
        '
        Me.priceTBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTBOX.Location = New System.Drawing.Point(101, 61)
        Me.priceTBOX.Name = "priceTBOX"
        Me.priceTBOX.Size = New System.Drawing.Size(285, 23)
        Me.priceTBOX.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'callspeedCbox
        '
        Me.callspeedCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.callspeedCbox.FormattingEnabled = True
        Me.callspeedCbox.Items.AddRange(New Object() {"50", "100", "200", "300", "400", "500"})
        Me.callspeedCbox.Location = New System.Drawing.Point(147, 111)
        Me.callspeedCbox.Name = "callspeedCbox"
        Me.callspeedCbox.Size = New System.Drawing.Size(121, 21)
        Me.callspeedCbox.TabIndex = 5
        '
        'animationspeedCbox
        '
        Me.animationspeedCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.animationspeedCbox.FormattingEnabled = True
        Me.animationspeedCbox.Items.AddRange(New Object() {"10", "20", "50", "100", "150", "200", "250", "300", "350", "400", "450", "500"})
        Me.animationspeedCbox.Location = New System.Drawing.Point(147, 139)
        Me.animationspeedCbox.Name = "animationspeedCbox"
        Me.animationspeedCbox.Size = New System.Drawing.Size(121, 21)
        Me.animationspeedCbox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Animation Speed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Call Speed"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 223)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.patternTBOX)
        Me.TabPage1.Controls.Add(Me.animationspeedCbox)
        Me.TabPage1.Controls.Add(Me.priceTBOX)
        Me.TabPage1.Controls.Add(Me.callspeedCbox)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 197)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.prevPatternTbox)
        Me.TabPage2.Controls.Add(Me.prevPriceTbox)
        Me.TabPage2.Controls.Add(Me.setCbox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Previous Sets"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'setCbox
        '
        Me.setCbox.FormattingEnabled = True
        Me.setCbox.Location = New System.Drawing.Point(102, 34)
        Me.setCbox.Name = "setCbox"
        Me.setCbox.Size = New System.Drawing.Size(121, 21)
        Me.setCbox.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Pattern"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Prize"
        '
        'prevPatternTbox
        '
        Me.prevPatternTbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevPatternTbox.Location = New System.Drawing.Point(102, 71)
        Me.prevPatternTbox.Name = "prevPatternTbox"
        Me.prevPatternTbox.Size = New System.Drawing.Size(285, 23)
        Me.prevPatternTbox.TabIndex = 6
        '
        'prevPriceTbox
        '
        Me.prevPriceTbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevPriceTbox.Location = New System.Drawing.Point(102, 102)
        Me.prevPriceTbox.Name = "prevPriceTbox"
        Me.prevPriceTbox.Size = New System.Drawing.Size(285, 23)
        Me.prevPriceTbox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Select Set"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(312, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "SUBMIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BingoOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 248)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BingoOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BingoOption"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents patternTBOX As TextBox
    Friend WithEvents priceTBOX As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents callspeedCbox As ComboBox
    Friend WithEvents animationspeedCbox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents prevPatternTbox As TextBox
    Friend WithEvents prevPriceTbox As TextBox
    Friend WithEvents setCbox As ComboBox
End Class
