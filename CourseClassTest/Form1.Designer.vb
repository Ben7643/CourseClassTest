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
        Me.btnPostScore = New System.Windows.Forms.Button()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.cboHolesPlayed = New System.Windows.Forms.ComboBox()
        Me.cboTeePlayed = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHoles = New System.Windows.Forms.Label()
        Me.lblTeePlayed = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DTPicker = New System.Windows.Forms.Label()
        Me.rbAuto = New System.Windows.Forms.RadioButton()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.lblAutoManual = New System.Windows.Forms.Label()
        Me.txtRoundIndex = New System.Windows.Forms.TextBox()
        Me.txtIndex10 = New System.Windows.Forms.TextBox()
        Me.lblTxtRoundIndex = New System.Windows.Forms.Label()
        Me.lblIndex10 = New System.Windows.Forms.Label()
        Me.txtManualCourse = New System.Windows.Forms.TextBox()
        Me.txtManualRating = New System.Windows.Forms.TextBox()
        Me.txtManualSlope = New System.Windows.Forms.TextBox()
        Me.lblManualCourse = New System.Windows.Forms.Label()
        Me.lblManualRating = New System.Windows.Forms.Label()
        Me.lblManualSlope = New System.Windows.Forms.Label()
        Me.txtPutts = New System.Windows.Forms.TextBox()
        Me.lblPutts = New System.Windows.Forms.Label()
        Me.txtRoundPPH = New System.Windows.Forms.TextBox()
        Me.lblRoundPPH = New System.Windows.Forms.Label()
        Me.txtAvgPPH = New System.Windows.Forms.TextBox()
        Me.lblAVGPPH = New System.Windows.Forms.Label()
        Me.lblFairwaysHit = New System.Windows.Forms.Label()
        Me.txtRndPctFwysHit = New System.Windows.Forms.TextBox()
        Me.txtAvgPctFwysHit = New System.Windows.Forms.TextBox()
        Me.lblRndPctFwysHit = New System.Windows.Forms.Label()
        Me.lblAvgPctFwysHit = New System.Windows.Forms.Label()
        Me.txtGreensHit = New System.Windows.Forms.TextBox()
        Me.lblGreensHit = New System.Windows.Forms.Label()
        Me.txtRndPctGrnsHit = New System.Windows.Forms.TextBox()
        Me.lblRndPctGrnsHIt = New System.Windows.Forms.Label()
        Me.txtAvgPctGrnsHit = New System.Windows.Forms.TextBox()
        Me.lblAvgPctGrnsHit = New System.Windows.Forms.Label()
        Me.btnDisplayTable = New System.Windows.Forms.Button()
        Me.cboFairwaysHit = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnPostScore
        '
        Me.btnPostScore.Location = New System.Drawing.Point(153, 411)
        Me.btnPostScore.Name = "btnPostScore"
        Me.btnPostScore.Size = New System.Drawing.Size(75, 23)
        Me.btnPostScore.TabIndex = 0
        Me.btnPostScore.Text = "Post Score"
        Me.btnPostScore.UseVisualStyleBackColor = True
        '
        'cboCourse
        '
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(107, 186)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(121, 21)
        Me.cboCourse.TabIndex = 2
        '
        'cboHolesPlayed
        '
        Me.cboHolesPlayed.FormattingEnabled = True
        Me.cboHolesPlayed.Location = New System.Drawing.Point(116, 73)
        Me.cboHolesPlayed.Name = "cboHolesPlayed"
        Me.cboHolesPlayed.Size = New System.Drawing.Size(46, 21)
        Me.cboHolesPlayed.TabIndex = 3
        '
        'cboTeePlayed
        '
        Me.cboTeePlayed.FormattingEnabled = True
        Me.cboTeePlayed.Location = New System.Drawing.Point(107, 224)
        Me.cboTeePlayed.Name = "cboTeePlayed"
        Me.cboTeePlayed.Size = New System.Drawing.Size(157, 21)
        Me.cboTeePlayed.TabIndex = 4
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(61, 189)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(40, 13)
        Me.lblCourse.TabIndex = 5
        Me.lblCourse.Text = "Course"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(116, 109)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(33, 20)
        Me.txtScore.TabIndex = 6
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(75, 112)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 13)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "Score"
        '
        'lblHoles
        '
        Me.lblHoles.AutoSize = True
        Me.lblHoles.Location = New System.Drawing.Point(41, 76)
        Me.lblHoles.Name = "lblHoles"
        Me.lblHoles.Size = New System.Drawing.Size(69, 13)
        Me.lblHoles.TabIndex = 10
        Me.lblHoles.Text = "Holes Played"
        '
        'lblTeePlayed
        '
        Me.lblTeePlayed.AutoSize = True
        Me.lblTeePlayed.Location = New System.Drawing.Point(40, 227)
        Me.lblTeePlayed.Name = "lblTeePlayed"
        Me.lblTeePlayed.Size = New System.Drawing.Size(61, 13)
        Me.lblTeePlayed.TabIndex = 11
        Me.lblTeePlayed.Text = "Tee Played"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'DTPicker
        '
        Me.DTPicker.AutoSize = True
        Me.DTPicker.Location = New System.Drawing.Point(45, 41)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.Size = New System.Drawing.Size(65, 13)
        Me.DTPicker.TabIndex = 13
        Me.DTPicker.Text = "Date Played"
        '
        'rbAuto
        '
        Me.rbAuto.AutoSize = True
        Me.rbAuto.Location = New System.Drawing.Point(116, 143)
        Me.rbAuto.Name = "rbAuto"
        Me.rbAuto.Size = New System.Drawing.Size(47, 17)
        Me.rbAuto.TabIndex = 14
        Me.rbAuto.TabStop = True
        Me.rbAuto.Text = "Auto"
        Me.rbAuto.UseVisualStyleBackColor = True
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Location = New System.Drawing.Point(180, 143)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(60, 17)
        Me.rbManual.TabIndex = 15
        Me.rbManual.TabStop = True
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'lblAutoManual
        '
        Me.lblAutoManual.AutoSize = True
        Me.lblAutoManual.Location = New System.Drawing.Point(32, 145)
        Me.lblAutoManual.Name = "lblAutoManual"
        Me.lblAutoManual.Size = New System.Drawing.Size(69, 13)
        Me.lblAutoManual.TabIndex = 16
        Me.lblAutoManual.Text = "Auto/Manual"
        '
        'txtRoundIndex
        '
        Me.txtRoundIndex.Location = New System.Drawing.Point(483, 38)
        Me.txtRoundIndex.Name = "txtRoundIndex"
        Me.txtRoundIndex.Size = New System.Drawing.Size(41, 20)
        Me.txtRoundIndex.TabIndex = 17
        '
        'txtIndex10
        '
        Me.txtIndex10.Location = New System.Drawing.Point(639, 38)
        Me.txtIndex10.Name = "txtIndex10"
        Me.txtIndex10.Size = New System.Drawing.Size(46, 20)
        Me.txtIndex10.TabIndex = 18
        '
        'lblTxtRoundIndex
        '
        Me.lblTxtRoundIndex.AutoSize = True
        Me.lblTxtRoundIndex.Location = New System.Drawing.Point(409, 41)
        Me.lblTxtRoundIndex.Name = "lblTxtRoundIndex"
        Me.lblTxtRoundIndex.Size = New System.Drawing.Size(68, 13)
        Me.lblTxtRoundIndex.TabIndex = 19
        Me.lblTxtRoundIndex.Text = "Round Index"
        '
        'lblIndex10
        '
        Me.lblIndex10.AutoSize = True
        Me.lblIndex10.Location = New System.Drawing.Point(600, 41)
        Me.lblIndex10.Name = "lblIndex10"
        Me.lblIndex10.Size = New System.Drawing.Size(33, 13)
        Me.lblIndex10.TabIndex = 20
        Me.lblIndex10.Text = "Index"
        '
        'txtManualCourse
        '
        Me.txtManualCourse.Location = New System.Drawing.Point(318, 142)
        Me.txtManualCourse.Name = "txtManualCourse"
        Me.txtManualCourse.Size = New System.Drawing.Size(100, 20)
        Me.txtManualCourse.TabIndex = 21
        '
        'txtManualRating
        '
        Me.txtManualRating.Location = New System.Drawing.Point(466, 143)
        Me.txtManualRating.Name = "txtManualRating"
        Me.txtManualRating.Size = New System.Drawing.Size(100, 20)
        Me.txtManualRating.TabIndex = 22
        '
        'txtManualSlope
        '
        Me.txtManualSlope.Location = New System.Drawing.Point(603, 143)
        Me.txtManualSlope.Name = "txtManualSlope"
        Me.txtManualSlope.Size = New System.Drawing.Size(100, 20)
        Me.txtManualSlope.TabIndex = 23
        '
        'lblManualCourse
        '
        Me.lblManualCourse.AutoSize = True
        Me.lblManualCourse.Location = New System.Drawing.Point(353, 118)
        Me.lblManualCourse.Name = "lblManualCourse"
        Me.lblManualCourse.Size = New System.Drawing.Size(40, 13)
        Me.lblManualCourse.TabIndex = 24
        Me.lblManualCourse.Text = "Course"
        '
        'lblManualRating
        '
        Me.lblManualRating.AutoSize = True
        Me.lblManualRating.Location = New System.Drawing.Point(498, 118)
        Me.lblManualRating.Name = "lblManualRating"
        Me.lblManualRating.Size = New System.Drawing.Size(38, 13)
        Me.lblManualRating.TabIndex = 25
        Me.lblManualRating.Text = "Rating"
        '
        'lblManualSlope
        '
        Me.lblManualSlope.AutoSize = True
        Me.lblManualSlope.Location = New System.Drawing.Point(636, 118)
        Me.lblManualSlope.Name = "lblManualSlope"
        Me.lblManualSlope.Size = New System.Drawing.Size(34, 13)
        Me.lblManualSlope.TabIndex = 26
        Me.lblManualSlope.Text = "Slope"
        '
        'txtPutts
        '
        Me.txtPutts.Location = New System.Drawing.Point(107, 345)
        Me.txtPutts.Name = "txtPutts"
        Me.txtPutts.Size = New System.Drawing.Size(31, 20)
        Me.txtPutts.TabIndex = 27
        '
        'lblPutts
        '
        Me.lblPutts.AutoSize = True
        Me.lblPutts.Location = New System.Drawing.Point(70, 348)
        Me.lblPutts.Name = "lblPutts"
        Me.lblPutts.Size = New System.Drawing.Size(31, 13)
        Me.lblPutts.TabIndex = 28
        Me.lblPutts.Text = "Putts"
        '
        'txtRoundPPH
        '
        Me.txtRoundPPH.Location = New System.Drawing.Point(377, 347)
        Me.txtRoundPPH.Name = "txtRoundPPH"
        Me.txtRoundPPH.Size = New System.Drawing.Size(41, 20)
        Me.txtRoundPPH.TabIndex = 29
        '
        'lblRoundPPH
        '
        Me.lblRoundPPH.AutoSize = True
        Me.lblRoundPPH.Location = New System.Drawing.Point(292, 352)
        Me.lblRoundPPH.Name = "lblRoundPPH"
        Me.lblRoundPPH.Size = New System.Drawing.Size(64, 13)
        Me.lblRoundPPH.TabIndex = 30
        Me.lblRoundPPH.Text = "Round PPH"
        '
        'txtAvgPPH
        '
        Me.txtAvgPPH.Location = New System.Drawing.Point(542, 351)
        Me.txtAvgPPH.Name = "txtAvgPPH"
        Me.txtAvgPPH.Size = New System.Drawing.Size(43, 20)
        Me.txtAvgPPH.TabIndex = 31
        '
        'lblAVGPPH
        '
        Me.lblAVGPPH.AutoSize = True
        Me.lblAVGPPH.Location = New System.Drawing.Point(463, 354)
        Me.lblAVGPPH.Name = "lblAVGPPH"
        Me.lblAVGPPH.Size = New System.Drawing.Size(48, 13)
        Me.lblAVGPPH.TabIndex = 32
        Me.lblAVGPPH.Text = "AvgPPH"
        '
        'lblFairwaysHit
        '
        Me.lblFairwaysHit.AutoSize = True
        Me.lblFairwaysHit.Location = New System.Drawing.Point(37, 271)
        Me.lblFairwaysHit.Name = "lblFairwaysHit"
        Me.lblFairwaysHit.Size = New System.Drawing.Size(64, 13)
        Me.lblFairwaysHit.TabIndex = 34
        Me.lblFairwaysHit.Text = "Fairways Hit"
        '
        'txtRndPctFwysHit
        '
        Me.txtRndPctFwysHit.Location = New System.Drawing.Point(377, 264)
        Me.txtRndPctFwysHit.Name = "txtRndPctFwysHit"
        Me.txtRndPctFwysHit.Size = New System.Drawing.Size(41, 20)
        Me.txtRndPctFwysHit.TabIndex = 35
        '
        'txtAvgPctFwysHit
        '
        Me.txtAvgPctFwysHit.Location = New System.Drawing.Point(542, 267)
        Me.txtAvgPctFwysHit.Name = "txtAvgPctFwysHit"
        Me.txtAvgPctFwysHit.Size = New System.Drawing.Size(43, 20)
        Me.txtAvgPctFwysHit.TabIndex = 36
        '
        'lblRndPctFwysHit
        '
        Me.lblRndPctFwysHit.AutoSize = True
        Me.lblRndPctFwysHit.Location = New System.Drawing.Point(292, 261)
        Me.lblRndPctFwysHit.Name = "lblRndPctFwysHit"
        Me.lblRndPctFwysHit.Size = New System.Drawing.Size(79, 26)
        Me.lblRndPctFwysHit.TabIndex = 37
        Me.lblRndPctFwysHit.Text = "Round Percent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fairways Hit"
        '
        'lblAvgPctFwysHit
        '
        Me.lblAvgPctFwysHit.AutoSize = True
        Me.lblAvgPctFwysHit.Location = New System.Drawing.Point(449, 261)
        Me.lblAvgPctFwysHit.Name = "lblAvgPctFwysHit"
        Me.lblAvgPctFwysHit.Size = New System.Drawing.Size(87, 26)
        Me.lblAvgPctFwysHit.TabIndex = 38
        Me.lblAvgPctFwysHit.Text = "Average Percent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fairways Hit"
        '
        'txtGreensHit
        '
        Me.txtGreensHit.Location = New System.Drawing.Point(107, 306)
        Me.txtGreensHit.Name = "txtGreensHit"
        Me.txtGreensHit.Size = New System.Drawing.Size(31, 20)
        Me.txtGreensHit.TabIndex = 39
        '
        'lblGreensHit
        '
        Me.lblGreensHit.AutoSize = True
        Me.lblGreensHit.Location = New System.Drawing.Point(45, 309)
        Me.lblGreensHit.Name = "lblGreensHit"
        Me.lblGreensHit.Size = New System.Drawing.Size(57, 13)
        Me.lblGreensHit.TabIndex = 40
        Me.lblGreensHit.Text = "Greens Hit"
        '
        'txtRndPctGrnsHit
        '
        Me.txtRndPctGrnsHit.Location = New System.Drawing.Point(377, 309)
        Me.txtRndPctGrnsHit.Name = "txtRndPctGrnsHit"
        Me.txtRndPctGrnsHit.Size = New System.Drawing.Size(41, 20)
        Me.txtRndPctGrnsHit.TabIndex = 41
        '
        'lblRndPctGrnsHIt
        '
        Me.lblRndPctGrnsHIt.AutoSize = True
        Me.lblRndPctGrnsHIt.Location = New System.Drawing.Point(292, 306)
        Me.lblRndPctGrnsHIt.Name = "lblRndPctGrnsHIt"
        Me.lblRndPctGrnsHIt.Size = New System.Drawing.Size(79, 26)
        Me.lblRndPctGrnsHIt.TabIndex = 42
        Me.lblRndPctGrnsHIt.Text = "Round Percent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Greens Hit"
        '
        'txtAvgPctGrnsHit
        '
        Me.txtAvgPctGrnsHit.Location = New System.Drawing.Point(542, 312)
        Me.txtAvgPctGrnsHit.Name = "txtAvgPctGrnsHit"
        Me.txtAvgPctGrnsHit.Size = New System.Drawing.Size(43, 20)
        Me.txtAvgPctGrnsHit.TabIndex = 43
        '
        'lblAvgPctGrnsHit
        '
        Me.lblAvgPctGrnsHit.AutoSize = True
        Me.lblAvgPctGrnsHit.Location = New System.Drawing.Point(449, 309)
        Me.lblAvgPctGrnsHit.Name = "lblAvgPctGrnsHit"
        Me.lblAvgPctGrnsHit.Size = New System.Drawing.Size(87, 26)
        Me.lblAvgPctGrnsHit.TabIndex = 44
        Me.lblAvgPctGrnsHit.Text = "Average Percent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Greens Hit"
        '
        'btnDisplayTable
        '
        Me.btnDisplayTable.Location = New System.Drawing.Point(639, 411)
        Me.btnDisplayTable.Name = "btnDisplayTable"
        Me.btnDisplayTable.Size = New System.Drawing.Size(88, 23)
        Me.btnDisplayTable.TabIndex = 45
        Me.btnDisplayTable.Text = "Display Table"
        Me.btnDisplayTable.UseVisualStyleBackColor = True
        '
        'cboFairwaysHit
        '
        Me.cboFairwaysHit.FormattingEnabled = True
        Me.cboFairwaysHit.Location = New System.Drawing.Point(107, 268)
        Me.cboFairwaysHit.Name = "cboFairwaysHit"
        Me.cboFairwaysHit.Size = New System.Drawing.Size(42, 21)
        Me.cboFairwaysHit.TabIndex = 46
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboFairwaysHit)
        Me.Controls.Add(Me.btnDisplayTable)
        Me.Controls.Add(Me.lblAvgPctGrnsHit)
        Me.Controls.Add(Me.txtAvgPctGrnsHit)
        Me.Controls.Add(Me.lblRndPctGrnsHIt)
        Me.Controls.Add(Me.txtRndPctGrnsHit)
        Me.Controls.Add(Me.lblGreensHit)
        Me.Controls.Add(Me.txtGreensHit)
        Me.Controls.Add(Me.lblAvgPctFwysHit)
        Me.Controls.Add(Me.lblRndPctFwysHit)
        Me.Controls.Add(Me.txtAvgPctFwysHit)
        Me.Controls.Add(Me.txtRndPctFwysHit)
        Me.Controls.Add(Me.lblFairwaysHit)
        Me.Controls.Add(Me.lblAVGPPH)
        Me.Controls.Add(Me.txtAvgPPH)
        Me.Controls.Add(Me.lblRoundPPH)
        Me.Controls.Add(Me.txtRoundPPH)
        Me.Controls.Add(Me.lblPutts)
        Me.Controls.Add(Me.txtPutts)
        Me.Controls.Add(Me.lblManualSlope)
        Me.Controls.Add(Me.lblManualRating)
        Me.Controls.Add(Me.lblManualCourse)
        Me.Controls.Add(Me.txtManualSlope)
        Me.Controls.Add(Me.txtManualRating)
        Me.Controls.Add(Me.txtManualCourse)
        Me.Controls.Add(Me.lblIndex10)
        Me.Controls.Add(Me.lblTxtRoundIndex)
        Me.Controls.Add(Me.txtIndex10)
        Me.Controls.Add(Me.txtRoundIndex)
        Me.Controls.Add(Me.lblAutoManual)
        Me.Controls.Add(Me.rbManual)
        Me.Controls.Add(Me.rbAuto)
        Me.Controls.Add(Me.DTPicker)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblTeePlayed)
        Me.Controls.Add(Me.lblHoles)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.cboTeePlayed)
        Me.Controls.Add(Me.cboHolesPlayed)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.btnPostScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPostScore As Button
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents cboHolesPlayed As ComboBox
    Friend WithEvents cboTeePlayed As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtScore As TextBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHoles As Label
    Friend WithEvents lblTeePlayed As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DTPicker As Label
    Friend WithEvents rbAuto As RadioButton
    Friend WithEvents rbManual As RadioButton
    Friend WithEvents lblAutoManual As Label
    Friend WithEvents txtRoundIndex As TextBox
    Friend WithEvents txtIndex10 As TextBox
    Friend WithEvents lblTxtRoundIndex As Label
    Friend WithEvents lblIndex10 As Label
    Friend WithEvents txtManualCourse As TextBox
    Friend WithEvents txtManualRating As TextBox
    Friend WithEvents txtManualSlope As TextBox
    Friend WithEvents lblManualCourse As Label
    Friend WithEvents lblManualRating As Label
    Friend WithEvents lblManualSlope As Label
    Friend WithEvents txtPutts As TextBox
    Friend WithEvents lblPutts As Label
    Friend WithEvents txtRoundPPH As TextBox
    Friend WithEvents lblRoundPPH As Label
    Friend WithEvents txtAvgPPH As TextBox
    Friend WithEvents lblAVGPPH As Label
    Friend WithEvents lblFairwaysHit As Label
    Friend WithEvents txtRndPctFwysHit As TextBox
    Friend WithEvents txtAvgPctFwysHit As TextBox
    Friend WithEvents lblRndPctFwysHit As Label
    Friend WithEvents lblAvgPctFwysHit As Label
    Friend WithEvents txtGreensHit As TextBox
    Friend WithEvents lblGreensHit As Label
    Friend WithEvents txtRndPctGrnsHit As TextBox
    Friend WithEvents lblRndPctGrnsHIt As Label
    Friend WithEvents txtAvgPctGrnsHit As TextBox
    Friend WithEvents lblAvgPctGrnsHit As Label
    Friend WithEvents btnDisplayTable As Button
    Friend WithEvents cboFairwaysHit As ComboBox
End Class
