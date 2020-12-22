<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class imageviewFRM
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.employeeLBL = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.serialTBOX = New System.Windows.Forms.ComboBox()
        Me.checkBTN = New System.Windows.Forms.Button()
        Me.winnerLBL = New System.Windows.Forms.Label()
        Me.itemLBL = New System.Windows.Forms.Label()
        Me.supplierLBL = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(937, 294)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(199, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "receive"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'employeeLBL
        '
        Me.employeeLBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.employeeLBL.Dock = System.Windows.Forms.DockStyle.Top
        Me.employeeLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeLBL.ForeColor = System.Drawing.Color.Black
        Me.employeeLBL.Location = New System.Drawing.Point(0, 31)
        Me.employeeLBL.Name = "employeeLBL"
        Me.employeeLBL.Size = New System.Drawing.Size(937, 45)
        Me.employeeLBL.TabIndex = 4
        Me.employeeLBL.Text = "select a winner"
        Me.employeeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.serialTBOX)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.checkBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 31)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Serial"
        '
        'serialTBOX
        '
        Me.serialTBOX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.serialTBOX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.serialTBOX.DropDownHeight = 200
        Me.serialTBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serialTBOX.FormattingEnabled = True
        Me.serialTBOX.IntegralHeight = False
        Me.serialTBOX.Location = New System.Drawing.Point(44, 4)
        Me.serialTBOX.Name = "serialTBOX"
        Me.serialTBOX.Size = New System.Drawing.Size(71, 21)
        Me.serialTBOX.TabIndex = 0
        '
        'checkBTN
        '
        Me.checkBTN.Location = New System.Drawing.Point(121, 4)
        Me.checkBTN.Name = "checkBTN"
        Me.checkBTN.Size = New System.Drawing.Size(72, 24)
        Me.checkBTN.TabIndex = 2
        Me.checkBTN.Text = "check"
        Me.checkBTN.UseVisualStyleBackColor = True
        '
        'winnerLBL
        '
        Me.winnerLBL.BackColor = System.Drawing.Color.Purple
        Me.winnerLBL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.winnerLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winnerLBL.ForeColor = System.Drawing.Color.White
        Me.winnerLBL.Location = New System.Drawing.Point(0, 474)
        Me.winnerLBL.Name = "winnerLBL"
        Me.winnerLBL.Size = New System.Drawing.Size(937, 69)
        Me.winnerLBL.TabIndex = 7
        Me.winnerLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemLBL
        '
        Me.itemLBL.BackColor = System.Drawing.Color.Black
        Me.itemLBL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.itemLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemLBL.ForeColor = System.Drawing.Color.White
        Me.itemLBL.Location = New System.Drawing.Point(0, 422)
        Me.itemLBL.Name = "itemLBL"
        Me.itemLBL.Size = New System.Drawing.Size(937, 52)
        Me.itemLBL.TabIndex = 8
        Me.itemLBL.Text = "item"
        Me.itemLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'supplierLBL
        '
        Me.supplierLBL.BackColor = System.Drawing.Color.Black
        Me.supplierLBL.Dock = System.Windows.Forms.DockStyle.Top
        Me.supplierLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supplierLBL.ForeColor = System.Drawing.Color.MediumOrchid
        Me.supplierLBL.Location = New System.Drawing.Point(0, 76)
        Me.supplierLBL.Name = "supplierLBL"
        Me.supplierLBL.Size = New System.Drawing.Size(937, 52)
        Me.supplierLBL.TabIndex = 9
        Me.supplierLBL.Text = "supplier"
        Me.supplierLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imageviewFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 543)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.supplierLBL)
        Me.Controls.Add(Me.itemLBL)
        Me.Controls.Add(Me.winnerLBL)
        Me.Controls.Add(Me.employeeLBL)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "imageviewFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents employeeLBL As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents serialTBOX As ComboBox
    Friend WithEvents checkBTN As Button
    Friend WithEvents winnerLBL As Label
    Friend WithEvents itemLBL As Label
    Friend WithEvents supplierLBL As Label
End Class
