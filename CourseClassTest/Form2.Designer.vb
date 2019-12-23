<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCurrentIndex = New System.Windows.Forms.TextBox()
        Me.lblCurrentIndex = New System.Windows.Forms.Label()
        Me.txtTimesShotAge = New System.Windows.Forms.TextBox()
        Me.lblTimesShotAge = New System.Windows.Forms.Label()
        Me.txtShotAgePct = New System.Windows.Forms.TextBox()
        Me.lblTxtShotAgePct = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.col4, Me.col5, Me.Col6})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Location = New System.Drawing.Point(94, 235)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(568, 418)
        Me.DataGridView1.TabIndex = 2
        '
        'Col1
        '
        Me.Col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col1.HeaderText = "Date"
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        Me.Col1.Width = 64
        '
        'Col2
        '
        Me.Col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Col2.HeaderText = "Course"
        Me.Col2.Name = "Col2"
        Me.Col2.Width = 82
        '
        'Col3
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Col3.HeaderText = "Score"
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        Me.Col3.Width = 73
        '
        'col4
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col4.DefaultCellStyle = DataGridViewCellStyle6
        Me.col4.HeaderText = "Index"
        Me.col4.Name = "col4"
        Me.col4.Width = 67
        '
        'col5
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col5.DefaultCellStyle = DataGridViewCellStyle7
        Me.col5.HeaderText = "Rating"
        Me.col5.Name = "col5"
        Me.col5.Width = 75
        '
        'Col6
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col6.DefaultCellStyle = DataGridViewCellStyle8
        Me.Col6.HeaderText = "Slope"
        Me.Col6.Name = "Col6"
        Me.Col6.Width = 71
        '
        'txtCurrentIndex
        '
        Me.txtCurrentIndex.Location = New System.Drawing.Point(769, 40)
        Me.txtCurrentIndex.Name = "txtCurrentIndex"
        Me.txtCurrentIndex.Size = New System.Drawing.Size(37, 20)
        Me.txtCurrentIndex.TabIndex = 3
        '
        'lblCurrentIndex
        '
        Me.lblCurrentIndex.AutoSize = True
        Me.lblCurrentIndex.Location = New System.Drawing.Point(693, 43)
        Me.lblCurrentIndex.Name = "lblCurrentIndex"
        Me.lblCurrentIndex.Size = New System.Drawing.Size(70, 13)
        Me.lblCurrentIndex.TabIndex = 4
        Me.lblCurrentIndex.Text = "Current Index"
        '
        'txtTimesShotAge
        '
        Me.txtTimesShotAge.Location = New System.Drawing.Point(158, 122)
        Me.txtTimesShotAge.Name = "txtTimesShotAge"
        Me.txtTimesShotAge.Size = New System.Drawing.Size(31, 20)
        Me.txtTimesShotAge.TabIndex = 5
        '
        'lblTimesShotAge
        '
        Me.lblTimesShotAge.AutoSize = True
        Me.lblTimesShotAge.Location = New System.Drawing.Point(76, 125)
        Me.lblTimesShotAge.Name = "lblTimesShotAge"
        Me.lblTimesShotAge.Size = New System.Drawing.Size(82, 13)
        Me.lblTimesShotAge.TabIndex = 6
        Me.lblTimesShotAge.Text = "Times Shot Age"
        '
        'txtShotAgePct
        '
        Me.txtShotAgePct.Location = New System.Drawing.Point(315, 122)
        Me.txtShotAgePct.Name = "txtShotAgePct"
        Me.txtShotAgePct.Size = New System.Drawing.Size(37, 20)
        Me.txtShotAgePct.TabIndex = 7
        '
        'lblTxtShotAgePct
        '
        Me.lblTxtShotAgePct.AutoSize = True
        Me.lblTxtShotAgePct.Location = New System.Drawing.Point(205, 125)
        Me.lblTxtShotAgePct.Name = "lblTxtShotAgePct"
        Me.lblTxtShotAgePct.Size = New System.Drawing.Size(104, 13)
        Me.lblTxtShotAgePct.TabIndex = 8
        Me.lblTxtShotAgePct.Text = "Times Shot Age Pct."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 655)
        Me.Controls.Add(Me.lblTxtShotAgePct)
        Me.Controls.Add(Me.txtShotAgePct)
        Me.Controls.Add(Me.lblTimesShotAge)
        Me.Controls.Add(Me.txtTimesShotAge)
        Me.Controls.Add(Me.lblCurrentIndex)
        Me.Controls.Add(Me.txtCurrentIndex)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Col1 As DataGridViewTextBoxColumn
    Friend WithEvents Col2 As DataGridViewTextBoxColumn
    Friend WithEvents Col3 As DataGridViewTextBoxColumn
    Friend WithEvents col4 As DataGridViewTextBoxColumn
    Friend WithEvents col5 As DataGridViewTextBoxColumn
    Friend WithEvents Col6 As DataGridViewTextBoxColumn
    Friend WithEvents txtCurrentIndex As TextBox
    Friend WithEvents lblCurrentIndex As Label
    Friend WithEvents txtTimesShotAge As TextBox
    Friend WithEvents lblTimesShotAge As Label
    Friend WithEvents txtShotAgePct As TextBox
    Friend WithEvents lblTxtShotAgePct As Label
End Class
