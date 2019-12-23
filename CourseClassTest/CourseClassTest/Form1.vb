Public Class Form1
    Public CourseName As String
    Public Dateplayed As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCourse.Items.Add("Valhalla")
        cboCourse.Items.Add("Riverside,Ca")
        cboCourse.Items.Add("Airways")
        cboCourse.Items.Add("Madera Muni")
        cboCourse.Items.Add("Belmont_CC")
        cboCourse.Items.Add("Dragonfly")
        cboCourse.Items.Add("Lemoore")
        cboCourse.Items.Add("Madera_CC")
        cboCourse.Items.Add("Ridge_Creek")
        cboCourse.Items.Add("Sherwood Forest")
        cboCourse.Items.Add("Sunnyside_CC")
        cboCourse.Items.Add("Pheasant_Run")
        cboCourse.Items.Add("Valley Oaks GC-Lakes/Valley")
        cboCourse.Items.Add("Valley Oaks GC-Oaks/Lakes")
        cboCourse.Items.Add("Valley Oaks GC-Valley/Oaks")
        cboHolesPlayed.Items.Add("18")
        cboHolesPlayed.Items.Add("9")
        rbAuto.Checked = True
        txtScore.Select()
    End Sub
    Private Sub txtScore_Leave(sender As Object, e As EventArgs) Handles txtScore.Leave

        If txtScore.Text = "" Then
            txtScore.BackColor = Color.Red
            MessageBox.Show("You must enter a score!")
            txtScore.Focus()
            txtScore.BackColor = Color.White
        End If
    End Sub

    Private Sub RbAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rbAuto.CheckedChanged
        If rbAuto.Checked = True Then
            rbManual.Checked = False
            cboTeePlayed.Visible = True
            cboCourse.Visible = True
            lblCourse.Visible = True
            lblManualCourse.Visible = False
            txtManualCourse.Visible = False
            lblManualRating.Visible = False
            txtManualRating.Visible = False
            lblManualSlope.Visible = False
            txtManualSlope.Visible = False
            lblTeePlayed.Visible = True
        End If
    End Sub
    Private Sub RbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbManual.CheckedChanged
        ' if Manual entry is selected then change visible property of unnecessary controls
        If rbManual.Checked = True Then
            rbAuto.Checked = False
            cboTeePlayed.Visible = False
            lblTeePlayed.Visible = False
            lblCourse.Visible = False
            cboCourse.Visible = False
            lblManualCourse.Visible = True
            txtManualCourse.Visible = True
            lblManualRating.Visible = True
            txtManualRating.Visible = True
            lblManualSlope.Visible = True
            txtManualSlope.Visible = True
        End If
    End Sub




    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        Dim mycourse As New Course
        ' mycourse.Holes = cboHolesPlayed.Text
        ' mycourse.TeeColor = cboTeePlayed.Text
        'mycourse.name = cboCourse.Text

        Dim NumHoles As String = cboHolesPlayed.Text
        Dim CourseName As String = cboCourse.Text
        Dim path As String

        'Function to Create path to Course data from Course Name.
        path = CreatePathForCourse(CourseName)
        'SubRoutine to fill cboTeeplayed with either 9 hole or 18 hole teecolors ,rating and slope. 
        Call FillTeePlayed(NumHoles, path)
        cboTeePlayed.Select()

    End Sub


    'Private Sub cboCourse_MouseDown(sender As Object, e As MouseEventArgs) Handles cboCourse.MouseDown
    '    Dim Score As Integer

    '    If txtScore.Text = "" Then
    '        txtScore.BackColor = Color.Red
    '        MessageBox.Show("You must enter a score!")
    '        txtScore.Focus()
    '        txtScore.BackColor = Color.White
    '    End If
    'End Sub

    Private Sub CboTeeColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeePlayed.SelectedIndexChanged
        Dim CourseName As String
        Dim TeeColor As String
        Dim Holes As Integer
        Dim path As String
        Dim data() As String
        Dim i As Integer
        Dim rating As String
        Dim slope As String
        Dim Score As Integer
        Dim index As Single
        Dim Index9 As Single
        Dim Index18 As Single
        Dim CombinedIndex As Single
        Dim DatePlayed As String
        Dim length As Integer
        Dim NewRating As Single
        Dim NewScore As Integer
        Dim NewSlope As Integer
        Dim FirstNineDate As String
        Dim FirstNineCourseName As String = CourseName
        Dim FirstNineScore As String
        Dim FirstNineRating As Single
        Dim FirstNineSlope As Integer
        Dim FirstNineIndex As Single
        Dim number As String = txtPutts.Text
        Dim SecondNineDate As String
        Dim SecondNineCourseName As String
        Dim SecondNineScore As String
        Dim SecondNineRating As Single
        Dim SecondNineSlope As Integer
        Dim SecondNineIndex As Single
        Dim Course As String
        Dim NinePlayed As String
        Dim TeePlayed As String

        CourseName = cboCourse.Text
        TeeColor = cboTeePlayed.Text
        Holes = CInt(cboHolesPlayed.Text)
        'Score = txtScore.Text
        path = CreatePathForCourse(CourseName)
        DatePlayed = ShortDate()
        TeePlayed = cboTeePlayed.Text

        Select Case Holes
            Case Is = 9   'Select rating and slope for a selected tee color for either Back or Front Nine
                Dim Position As Integer
                Dim String1 As String

                'finds position of "f" in first occurence of "front" and returns -1 if false.Uses position to get rating and slope.
                If cboTeePlayed.Text.IndexOf("Front") > 0 Then
                    Position = InStr(cboTeePlayed.Text, "Front")
                    For i = Position + 5 To Position + 8
                        rating += cboTeePlayed.Text(i)
                    Next i
                    For i = Position + 10 To Position + 12
                        slope += cboTeePlayed.Text(i)
                    Next
                ElseIf cboTeePlayed.Text.IndexOf("Back") > 0 Then
                    Position = InStr(cboTeePlayed.Text, "Back")
                    For i = Position + 4 To Position + 7
                        rating += cboTeePlayed.Text(i)
                    Next
                    For i = Position + 9 To Position + 11
                        slope += cboTeePlayed.Text(i)
                    Next
                End If
                Index9 = CalculateData(rating, slope, Score)

                'String1 = Microsoft.VisualBasic.Right(TeePlayed, 10) 'gets 10 characters from the right of string "TeePlayed"
                'If Microsoft.VisualBasic.Left(String1, 1) = "t" Then ' looks for first letter to left in String1. 
                '    Position = InStr(TeePlayed, "Front") ' get position of "F" in "Front"
                '    rating = Math.Round(CSng(Mid(TeePlayed, Position + 6, 4)), 2) 'use position to get next 4 characters i.e.rating.
                '    slope = CInt(Microsoft.VisualBasic.Right(TeePlayed, 3)) 'get slope from last three characters in string "TeePlayed"
                '    'txtFairwaysHit.Text = CStr(rating)
                '    'TextBox3.Text = CStr(slope)
                'ElseIf Microsoft.VisualBasic.Left(String1, 1) = "k" Then
                '    Position = InStr(TeePlayed, "Back")
                '    rating = Math.Round(CSng(Mid(TeePlayed, Position + 5, 4)), 2)
                '    slope = CInt(Microsoft.VisualBasic.Right(TeePlayed, 3))
                '    'txtFairwaysHit.Text = CStr(rating)
                '    'TextBox3.Text = CStr(slope)
                'End If
                Index9 = CalculateData(rating, slope, Score)

                length = CInt(FileLen("C:\users\ben\golfdata\cct\cctCourseClassTestFirstNine.txt"))
                If length = 0 Then ' if file empty then store first nine hole score
                    FirstNineDate = ShortDate()
                    If rbManual.Checked = True Then
                        FirstNineCourseName = txtManualCourse.Text
                        FirstNineRating = CSng(txtManualRating.Text)
                        FirstNineSlope = CInt(txtManualSlope.Text)
                    ElseIf rbManual.Checked = False Then
                        FirstNineCourseName = cboCourse.Text
                        FirstNineRating = rating
                        FirstNineSlope = slope
                    End If
                    FirstNineScore = Score
                    FirstNineIndex = TruncateIndexToOneDp(Index9)
                    Form2.txtRoundIndex.Text = CStr(Index9)
                    Form2.txtNineHoleDate.Text = ShortDate()
                    Form2.TxtNineHoleCourse.Text = FirstNineCourseName
                    Form2.txtNineHoleScore.Text = Score
                    Form2.txtNineHoleIndex.Text = FirstNineIndex

                    FileOpen(1, "C:\users\ben\golfdata\cct\cctCourseClassTestFirstNine.txt", OpenMode.Append)
                    Write(1, FirstNineDate)
                    Write(1, FirstNineCourseName)
                    Write(1, FirstNineScore)
                    Write(1, FirstNineRating)
                    Write(1, FirstNineSlope)
                    FileClose(1)
                    FileOpen(2, "C:\users\ben\golfdata\cct\cctCourseClassTestForm2Data.txt", OpenMode.Output)
                    Write(2, FirstNineDate) 'Store selected nine hole data for output on form2
                    Write(2, FirstNineCourseName)
                    Write(2, FirstNineScore)
                    Write(2, FirstNineIndex)
                    FileClose(2)
                End If
                If length > 3 Then 'if first nine hole score in file then input first nine hole score
                    'and combine data from both nines
                    FileOpen(1, "C:\users\ben\golfdata\cct\cctCourseClassTestFirstNine.txt", OpenMode.Input)
                    Input(1, FirstNineDate)
                    Input(1, FirstNineCourseName)
                    Input(1, FirstNineScore)
                    Input(1, FirstNineRating)
                    Input(1, FirstNineSlope)
                    FileClose(1)
                    SecondNineDate = ShortDate()
                    If rbManual.Checked = True Then
                        SecondNineCourseName = txtManualCourse.Text
                        SecondNineScore = Score
                        SecondNineRating = CSng(txtManualRating.Text)
                        SecondNineSlope = CInt(txtManualSlope.Text)
                    ElseIf rbManual.Checked = False Then
                        SecondNineCourseName = cboCourse.Text
                        SecondNineScore = Score
                        SecondNineRating = rating
                        SecondNineSlope = slope
                    End If
                    NewRating = CSng(FirstNineRating) + CSng(SecondNineRating) 'add two nine hole ratings.
                    rating = NewRating
                    NewScore = CInt(FirstNineScore) + CInt(SecondNineScore) ' add two nine hole scores
                    Score = CStr(NewScore)
                    NewSlope = CInt(FirstNineSlope) + CInt(SecondNineSlope) 'average two nine hole slopes
                    slope = CInt(NewSlope / 2)
                    'CombinedIndex = CSng(((CSng(Score) - rating) * (113 / slope)) * 0.96)
                    'Index18 = TruncateIndexToOneDp(CStr(CombinedIndex))
                    'Score = Score & "C" ' "C" indicates that score is combined from two nine hole scores
                    CourseName = FirstNineCourseName & " / " & SecondNineCourseName & " C"
                    Index18 = CalculateData(rating, slope, Score)
                    Form2.txtRoundIndex.Text = CStr(Index18)

                    'open for output to clear files after two nine hole scores entered
                    FileOpen(1, "C:\users\ben\golfdata\cct\cctCourseClassTestFirstNine.txt", OpenMode.Output)
                    FileOpen(2, "C:\users\ben\golfdata\cct\cctFirstNineHoleData.txt", OpenMode.Output)
                    FileClose(2)
                    FileClose(1)
                End If
            Case Is = 18
                Dim StringRating As String ' This code relies on the consistent position of rating and slope at the _
                'end of the file i.e (teecolor,rr.r,sss)

                StringRating = Microsoft.VisualBasic.Right(TeePlayed, 8) 'selects rating and slope from string in "cboTeePlayed"
                rating = Microsoft.VisualBasic.Left(StringRating, 4) 'selects rating from string "StringRating" rr.r
                slope = Microsoft.VisualBasic.Right(TeePlayed, 3) 'selects slope from string "TeePlayed" sss
                Index18 = CalculateData(rating, slope, Score) 'Calculate Index and Differential for 18 hole score.
                Form2.txtRoundIndex.Text = CStr(Index18)
                'FileOpen(1, "C:\users\ben\golfdata\cct\cctIndex20.txt", OpenMode.Input)
                'If FileLen("C:\users\ben\golfdata\cct\cctIndex20.txt") < 20 Then
                '    Input(1, Index18)
                '    FileClose(1)
                'ElseIf FileLen("C:\users\ben\golfdata\cct\cctIndex20.txt") > 20 Then
                '    For i = 19 To 0 Step -1
                '        ReDim Preserve data(i)
                '        Input(1, data(i))
                '    Next i
                '    FileClose(1)
                'End If
        End Select
        FileOpen(1, "C:\users\ben\golfdata\cct\cctDcsirs.txt", OpenMode.Append)
        Write(1, DatePlayed)
        Write(1, CourseName)
        Write(1, Score)
        Write(1, Index18)
        Write(1, rating)
        Write(1, slope)
        FileClose(1)
        Call MoveLastEntryToTop(CourseName, Score, Index18, rating, slope)
        txtPutts.Select()

    End Sub

    Private Sub txtFairwaysHit_TextChanged(sender As Object, e As EventArgs) Handles txtFairwaysHit.TextChanged
        Dim TeePlayed As String
        Dim Coursename As String
        ' Dim AvailableFairways As Integer
        Dim LengthTotalFairwaysHit As Integer
        Dim TotalFairwaysHit As Integer
        Dim HolesPlayed As Integer
        ' Dim LengthAvailableFairwaysHit As Integer
        Dim LengthFairwaysHit As Integer
        Dim LengthAvailableFairways As Integer
        Dim TotalAvailableFairways As Integer
        Dim FairwaysHit As Integer
        ' Dim LastTenCharacters As String

        Coursename = cboCourse.Text
        FairwaysHit = CInt(txtFairwaysHit.Text)
        HolesPlayed = cboHolesPlayed.Text
        TeePlayed = cboTeePlayed.Text

        'If txtPutts.Text = "" Then
        '    MessageBox.Show("You must enter a value for Putts")
        '    txtPutts.Focus()
        'End If

        'Select Case HolesPlayed
        '    Case Is = 9
        '        If Coursename = "Riverside,Ca" Or Coursename = "Airways" Then
        '            LastTenCharacters = Microsoft.VisualBasic.Right(TeePlayed, 10)   'Generate 11 character string with first letter "t"
        '            If Microsoft.VisualBasic.Left(LastTenCharacters, 1) = "t" Then 'look for first letter "t" in string
        '                AvailableFairways = 6
        '            End If
        '            LastTenCharacters = Microsoft.VisualBasic.Right(TeePlayed, 10)  ' Generate 11 characteer string with first letter "k"
        '            If Microsoft.VisualBasic.Left(LastTenCharacters, 1) = "k" Then 'look for first letter "k" in string
        '                AvailableFairways = 7
        '            End If
        '        End If
        '        If Coursename = "Sherwood Forest" Then
        '            LastTenCharacters = Microsoft.VisualBasic.Right(TeePlayed, 10)
        '            If Microsoft.VisualBasic.Left(LastTenCharacters, 1) = "t" Then ' look for the "t" in string  "lasttenletters"
        '                AvailableFairways = 8
        '            End If
        '            LastTenCharacters = Microsoft.VisualBasic.Right(TeePlayed, 10)  ' Look for the "k" in string  "lasttenletters"
        '            If Microsoft.VisualBasic.Left(LastTenCharacters, 1) = "k" Then
        '                AvailableFairways = 6
        '            End If
        '        End If

        LengthAvailableFairways = FileLen("C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt")
        If LengthAvailableFairways = 0 Then
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt", OpenMode.Append)
            Write(1, GetAvailableFairways()) 'function to get available fairways from course and holesplayed.
            FileClose(1)
        ElseIf LengthAvailableFairways > 0 Then
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt", OpenMode.Input)
            Input(1, TotalAvailableFairways)
            TotalAvailableFairways += GetAvailableFairways()
            FileClose(1)
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt", OpenMode.Output)
            Write(1, TotalAvailableFairways)
            FileClose(1)
        End If

        'if file is empty then write first data.If data already there then accumulate latest data
        'LengthFairwaysHit = FileLen("C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt")
        '        If LengthAvailableFairways = 0 Then
        '            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt", OpenMode.Append)
        '            Write(1, FairwaysHit)
        '            FileClose(1)
        '        ElseIf LengthFairwaysHit > 0 Then
        '            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt", OpenMode.Input)
        '            Input(1, TotalFairwaysHit)
        '            TotalFairwaysHit += FairwaysHit
        '            FileClose(1)
        '            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt", OpenMode.Output)
        '            Write(1, TotalFairwaysHit)
        '            FileClose(1)
        '        End If
        'Case Is = 18
        '    If Coursename = "RiversideCa" Or Coursename = "Airways" Then
        '        AvailableFairways = 13
        '    Else
        '        AvailableFairways = 14
        '    End If
        '    'if file is empty then write first data.If data already there then accumulate latest data
        '    LengthAvailableFairways = FileLen("C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt")
        '    If LengthAvailableFairways = 0 Then
        '        FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt", OpenMode.Append)
        '        Write(1, AvailableFairways)
        '        FileClose(1)
        '    ElseIf LengthAvailableFairways > 0 Then
        '        FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt", OpenMode.Input)
        '        Input(1, TotalAvailableFairways)
        '        TotalAvailableFairways += AvailableFairways
        '        FileClose(1)
        '        FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalAvailableFairways.txt", OpenMode.Output)
        '        Write(1, TotalAvailableFairways)
        '        FileClose(1)
        '    End If

        LengthFairwaysHit = FileLen("C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt")
        If LengthTotalFairwaysHit = 0 Then
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt", OpenMode.Append)
            Write(1, FairwaysHit)
            FileClose(1)
        ElseIf LengthTotalFairwaysHit > 0 Then
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt", OpenMode.Input)
            Input(1, TotalFairwaysHit)
            TotalFairwaysHit += FairwaysHit
            FileClose(1)
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalFairwaysHit.txt", OpenMode.Output)
            Write(1, TotalFairwaysHit)
            FileClose(1)
        End If

        Form2.txtRndPctFwysHit.Text = CStr(Math.Round((FairwaysHit / GetAvailableFairways()) * 100, 2))
        Form2.txtAvgPctFwysHit.Text = CStr(Math.Round(CInt(TotalFairwaysHit / TotalAvailableFairways) * 100, 2))


    End Sub
    Private Sub txtFairwaysHit_Leave(sender As Object, e As EventArgs) Handles txtFairwaysHit.Leave
        Dim FairWaysHit As Integer
        FairWaysHit = CInt(txtFairwaysHit.Text)

        If FairWaysHit = 0 Then
            MessageBox.Show("Need a number")
            txtFairwaysHit.Focus()


        End If

        If FairwaysHit > GetAvailableFairways() Then
            MessageBox.Show("This number of Fairways is not possible for this course")
            txtFairwaysHit.Focus()
        End If

    End Sub




    Private Sub txtPutts_TextChanged(sender As Object, e As EventArgs) Handles txtPutts.TextChanged
        Dim Putts As Integer
        Dim length As Integer
        Dim TotalPutts As Integer
        Dim HolesThisRound As Integer

        HolesThisRound = CInt(cboHolesPlayed.Text)
        Putts = CInt(txtPutts.Text)

        length = FileLen("C:\users\ben\golfdata\cct\cctTotalPutts.txt")
        If length = 0 Then 'if file empty then write value of putts to file
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalPutts.txt", OpenMode.Append)
            Write(1, Putts)
            FileClose(1, "C:\users\ben\golfdata\cctTotalPutts.txt")
        Else
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalPutts.txt", OpenMode.Input)
            Input(1, TotalPutts)
            TotalPutts += Putts
            FileClose(1)
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalPutts.txt", OpenMode.Output)
            Write(1, TotalPutts)
            FileClose(1)
        End If
        'Select Case HolesThisRound
        '    Case Is = 9
        '        If Putts < 9 Or Putts > 25 Then
        '            txtPutts.BackColor = Color.Red
        '            MessageBox.Show("This Value for Putts is outside a normal range! Continue?")
        '            txtPutts.BackColor = Color.White
        '            txtPutts.Focus()
        '        End If
        '    Case Is = 18
        '        If Putts < 18 Or Putts > 45 Then
        '            txtPutts.BackColor = Color.Red
        '            MessageBox.Show("This value for Putts is outside a normal range! Continue?")
        '            txtPutts.BackColor = Color.White
        '            txtPutts.Focus()
        '        End If
        'End Select
        Form2.txtRoundPPH.Text = CStr(Math.Round(Putts / HolesThisRound, 2))
        Form2.txtAvgPPH.Text = CStr(Math.Round(TotalPutts / GetTotalHoles(), 2))


    End Sub
    Private Sub txtPutts_Leave(sender As Object, e As EventArgs) Handles txtPutts.Leave
        Dim HolesThisRound As Integer
        Dim Putts As String
        HolesThisRound = cboHolesPlayed.Text
        Putts = txtPutts.Text

        If txtPutts.Text = "" Then
            MessageBox.Show("You must enter a value for Putts")
            txtPutts.Focus()
        Else
            Select Case HolesThisRound
                Case Is = CStr(9)
                    If Putts < CStr(9) Or Putts > CStr(25) Then
                        txtPutts.BackColor = Color.Red
                        MessageBox.Show("This Value for Putts is outside a normal range! Continue?")
                        txtPutts.BackColor = Color.White
                        txtPutts.Focus()
                    End If
                Case Is = CStr(18)
                    If Putts < CStr(18) Or Putts > CStr(45) Then
                        txtPutts.BackColor = Color.Red
                        MessageBox.Show("This value for Putts is outside a normal range! Continue?")
                        txtPutts.BackColor = Color.White
                        txtPutts.Focus()
                    End If
            End Select
        End If
    End Sub

    Private Sub txtGreensHit_TextChanged(sender As Object, e As EventArgs) Handles txtGreensHit.TextChanged
        Dim GreensHit As Integer
        Dim TotalGreensHit As Integer
        Dim Holes As Integer
        Dim length As Integer

        GreensHit = CInt(txtGreensHit.Text)
        length = FileLen("C:\users\ben\golfdata\cct\cctTotalGreensHit.txt")
        If length = 0 Then
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalGreensHit.txt", OpenMode.Append)
            Write(1, GreensHit)
            FileClose(1)
        ElseIf length > 0 Then
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalGreensHit.txt", OpenMode.Input)
            Input(1, TotalGreensHit)
            TotalGreensHit += GreensHit
            FileClose(1)
            FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalGreensHit.txt", OpenMode.Output)
            Write(1, TotalGreensHit)
            FileClose(1)
        End If

        Holes = cboHolesPlayed.Text
        Form2.txtRndPctGrnsHit.Text = CStr(Math.Round(GreensHit / Holes * 100, 2))
        Form2.txtAvgPctGrnsHit.Text = CStr(Math.Round(TotalGreensHit / GetTotalHoles() * 100, 2))

    End Sub
    Private Sub txtGreensHit_Leave(sender As Object, e As EventArgs) Handles txtGreensHit.Leave
        Dim GreensHit As Integer
        Dim HolesPlayed As Integer
        GreensHit = txtGreensHit.Text
        HolesPlayed = cboHolesPlayed.Text

        If GreensHit > HolesPlayed Then
            MessageBox.Show("You cannot hit more greens than the number of holes.")
            txtGreensHit.Focus()
        End If

    End Sub
    'Private Sub txtGreensHit_MouseDown(sender As Object, e As MouseEventArgs) Handles txtGreensHit.MouseDown
    '    Dim HolesThisRound As Integer
    '    Dim FairwaysHit As Integer
    '    Dim Course As String
    '    HolesThisRound = CInt(cboHolesPlayed.Text)
    '    FairwaysHit = CInt(txtFairwaysHit.Text)
    '    Course = cboCourse.Text


    '    If e.Button = MouseButtons.Left Then
    '        If FairwaysHit > GetAvailableFairways() Then
    '            MessageBox.Show("This number of Fairways is not possible for this course")
    '            txtFairwaysHit.Text = Focus()
    '        End If
    '    End If

    'End Sub

    Private Sub btnPostScore_Click(sender As Object, e As EventArgs) Handles btnPostScore.Click
        Dim data() As String
        Dim lowindex() As String
        Dim date1 As String
        Dim HolesPlayed As Integer
        Dim MaxColorLines As Integer
        Dim i As Integer
        Dim k As Integer
        Dim w As Integer

        ' Create array "Data" from the file containing data from the latest 20 rounds. 
        FileOpen(1, "C:\users\ben\golfdata\cct\cctdcsirs_20.txt", OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve Data(i)
            Input(1, Data(i))
            i += 1
        Loop
        FileClose(1)

        'Create array "lowindex" from the indexes from the last 20 rounds
        FileOpen(1, "C:\users\ben\golfdata\cct\cctsorted20.txt", OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve lowindex(k)
            Input(1, lowindex(k))
            k += 1
        Loop
        FileClose(1)

        'Fill the data grid with data from the latest rounds.
        Do Until w >= UBound(Data)
            date1 = Data(w)
            Form2.DataGridView1.Rows.Add(date1, Data(w + 1), Data(w + 2), Data(w + 3), Data(w + 4), Data(w + 5))
            w += 6
        Loop

        HolesPlayed = GetTotalHoles() / 18
        Select Case HolesPlayed
            Case Is <= 6
                MaxColorLines = 1
            Case Is = 7
                MaxColorLines = 2
            Case Is = 8
                MaxColorLines = 2
            Case Is = 9
                MaxColorLines = 3
            Case Is = 10
                MaxColorLines = 3
            Case Is = 11
                MaxColorLines = 4
            Case Is = 12
                MaxColorLines = 4
            Case Is = 13
                MaxColorLines = 5
            Case Is = 14
                MaxColorLines = 5
            Case Is = 15
                MaxColorLines = 6
            Case Is = 16
                MaxColorLines = 6
            Case Is = 17
                MaxColorLines = 7
            Case Is = 18
                MaxColorLines = 8
            Case Is = 19
                MaxColorLines = 9
            Case Is >= 20
                MaxColorLines = 10
        End Select

        'Highlight the rows in the data grid that contain the lowest scores for the number of holes played.

        For j = 0 To UBound(lowindex)
            For i = 0 To (MaxColorLines - 1)
                Form2.DataGridView1.Rows.Add(j + 1)
                If CSng(Form2.DataGridView1.Rows(j).Cells(3).Value) = CSng(lowindex(i)) Then
                    Form2.DataGridView1.Rows(j).DefaultCellStyle.BackColor = Color.CornflowerBlue
                End If
            Next i
        Next j
        Form2.Show()
    End Sub



    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        'key trap score textbox only numbers are allowed
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                txtScore.Focus()
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub TxtPutts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPutts.KeyPress
        'key trap putts textbox.Allow only numbers
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtFairwaysHit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFairwaysHit.KeyPress
        'key trap fairways textbox: only numbers are allowed
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                txtScore.Focus()
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtGreensHit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGreensHit.KeyPress
        'key trap greens hit textbox: only numbers are allowed
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                txtScore.Focus()
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Close()
    End Sub




End Class
