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


    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cboHolesPlayed.Focus()
    End Sub
    Private Sub cboHolesPlayed_Leave(sender As Object, e As EventArgs) Handles cboHolesPlayed.Leave
        If cboHolesPlayed.Text = "" Then
            MessageBox.Show("You must select a value for Holes!")
            cboHolesPlayed.Focus()
        End If
    End Sub

    Private Sub cboHolesPlayed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHolesPlayed.SelectedIndexChanged
        Dim TotalHolesPlayed As Integer
        Dim HolesPlayed As Integer

        HolesPlayed = CInt(cboHolesPlayed.Text)

        FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
        Input(1, TotalHolesPlayed)
        FileClose(1)
        TotalHolesPlayed += HolesPlayed
        FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Output)
        Write(1, TotalHolesPlayed)
        FileClose(1)
        txtScore.Select()

    End Sub

    Private Sub TxtScore_Leave(sender As Object, e As EventArgs) Handles txtScore.Leave
        Dim HolesPlayed As Integer = cboHolesPlayed.Text
        Dim Score As String = txtScore.Text
        Dim MessageScore As String = ("You must enter a value for Score!")



        Select Case HolesPlayed
            Case Is = 9
                If Score = "" Then
                    MessageBox.Show("You must enter a score.")
                    txtScore.Focus()
                ElseIf score < CStr(36) Or score >= CStr(50) Then
                    MessageBox.Show("This score is outside normal limits.Continue?")
                    txtScore.Focus()
                End If
            Case Is = 18
                If Score = "" Then
                    MessageBox.Show(MessageScore, "Score")
                    txtScore.Select()
                ElseIf Score < CStr(72) Or Score > CStr(95) Then
                    MessageBox.Show("This score is outside normanl limits! Continue?")
                    txtScore.Select()
                End If
        End Select


    End Sub


    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged

        Dim path As String
        Dim NumHoles As String = cboHolesPlayed.Text
        Dim CourseName As String = cboCourse.Text

        'Function to Create path to Course data from Course Name.
        path = CreatePathForCourse(CourseName)
        'SubRoutine to fill cboTeeplayed with either 9 hole or 18 hole teecolors ,rating and slope. 
        Call FillTeeplayed(NumHoles, path)

    End Sub


    'Private Sub cboFairwaysHit_Leave(sender As Object, e As EventArgs)

    '    Dim Holesplayed As String = cboHolesPlayed.Text
    '    Dim FairwaysHit As String = txtFairwaysHit.Text
    '    Dim CourseName As String = cboCourse.Text
    '    Dim TotalAvailableFairways As Integer
    '    Dim TotalFairwaysHit As Integer

    '    If Holesplayed = CStr(9) Or Holesplayed = CStr(18) Then
    '        If FairwaysHit = "" Then
    '            MessageBox.Show("You must enter a value for FairwaysHit!")
    '            cboAvailableFairways.Focus()
    '        ElseIf FairwaysHit > AvailableFairways(CInt(Holesplayed), CourseName) Then
    '            MessageBox.Show("You can't hit more fairways than the number of fairways available!")
    '            cboFairwaysHit.Focus()
    '        End If
    '    End If


    'End Sub


    'Private Sub txtPutts_Enter(sender As Object, e As EventArgs) Handles txtPutts.Enter


    'Private Sub txtGreensHit_Enter(sender As Object, e As EventArgs) Handles txtGreensHit.Enter
    '    Dim Coursename As String
    '    Dim HolesPlayed As Integer
    '    Dim FairwaysHit As Integer
    '    Dim TotalAvailableFairways As Integer
    '    Dim TotalFairwaysHit As Integer

    '    Coursename = cboCourse.Text
    '    FairwaysHit = CInt(txtFairwaysHit.Text)
    '    HolesPlayed = cboHolesPlayed.Text

    '    FileOpen(1, "C\users\ben\golfdata\cct\TtlAvailableFairways.txt", OpenMode.Input)
    '    Input(1, TotalAvailableFairways)
    '    TotalAvailableFairways += AvailableFairways(HolesPlayed, Coursename)
    '    FileClose(1)

    '    FileOpen(1, "C\users\ben\golfdata\cct\TtlAvailableFairways.txt", OpenMode.Output)
    '    Write(1, TotalAvailableFairways)
    '    FileClose(1)

    '    FileOpen(1, "C\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Input)
    '    Input(1, TotalFairwaysHit)
    '    FileClose(1)
    '    TotalFairwaysHit += FairwaysHit


    '    FileOpen(1, "C\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Output)
    '    Write(1, TotalFairwaysHit)
    '    FileClose(1)

    '    txtRndPctFwysHit.Text = CStr(Math.Round(FairwaysHit / AvailableFairways(HolesPlayed, Coursename) * 100, 2))
    '    txtAvgPctFwysHit.Text = CStr(Math.Round(TotalFairwaysHit / TotalAvailableFairways * 100, 2))
    '    'txtGreensHit.Focus()
    'End Sub


    'Private Sub txtGreensHit_Leave(sender As Object, e As EventArgs) Handles txtGreensHit.Leave

    '    Dim GreensHit As Integer = CInt(txtGreensHit.Text)
    '    Dim HolesPlayed As String = cboHolesPlayed.Text
    '    Dim Message As String
    '    Dim Heading As String

    '    If GreensHit = 0 Then
    '        txtGreensHit.BackColor = Color.Red
    '        If MessageBox.Show("You must enter a value for GreensHit", "GreensHit", MessageBoxButtons.OK) = DialogResult.OK Then
    '            txtGreensHit.Focus()
    '            txtGreensHit.BackColor = Color.White
    '        End If
    '    ElseIf GreensHit > HolesPlayed Then
    '        If MessageBox.Show("This value Is Impossible. You can't hit more greens than are on the course!", "GreensHit", MessageBoxButtons.OK) = DialogResult.OK Then
    '            txtGreensHit.Focus()
    '        End If
    '    End If

    'End Sub



    'Private Sub txtPutts_Enter(sender As Object, e As EventArgs) Handles txtPutts.Enter




    'Private Sub txtFairwaysHit_TextChanged(sender As Object, e As EventArgs)

    '    Dim Coursename As String
    '    Dim HolesPlayed As Integer
    '    Dim FairwaysHit As Integer
    '    Dim TotalAvailableFairways As Integer
    '    Dim TotalFairwaysHit As Integer

    '    Coursename = cboCourse.Text
    '    HolesPlayed = cboHolesPlayed.Text
    '    FairwaysHit = CInt(txtFairwaysHit.Text)

    '    FileOpen(1, "C:\users\ben\golfdata\cct\TtlAvailableFairways.txt", OpenMode.Input)
    '    Input(1, TotalAvailableFairways)
    '    TotalAvailableFairways += AvailableFairways(HolesPlayed, Coursename)
    '    FileClose(1)

    '    FileOpen(1, "C:\users\ben\golfdata\cct\TtlAvailableFairways.txt", OpenMode.Output)
    '    Write(1, TotalAvailableFairways)
    '    FileClose(1)

    '    FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Input)
    '    Input(1, TotalFairwaysHit)
    '    FileClose(1)
    '    TotalFairwaysHit += FairwaysHit

    '    FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Output)
    '    Write(1, TotalFairwaysHit)
    '    FileClose(1)

    '    txtRndPctFwysHit.Text = CStr(Math.Round(FairwaysHit / AvailableFairways(HolesPlayed, Coursename) * 100, 2))
    '    txtAvgPctFwysHit.Text = CStr(Math.Round(TotalFairwaysHit / TotalAvailableFairways * 100, 2))

    '    If CStr(FairwaysHit).Length = 2 Then
    '        txtGreensHit.Focus()
    '    End If

    'End Sub


    'Private Sub txtPutts_Leave(sender As Object, e As EventArgs) Handles txtPutts.Leave
    '    Dim TotalPutts As Integer
    '    Dim Putts As Integer
    '    Dim RoundPPH As Single
    '    Dim Holes As Integer
    '    Dim length As Integer


    '    Holes = CInt(cboHolesPlayed.Text)
    '    Putts = CInt(txtPutts.Text)
    '    length = FileLen("C:\users\ben\golfdata\cct\cctTotalPutts.txt")
    '    If length = 0 Then 'if file empty then write in first value
    '        FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalPutts.txt", OpenMode.Append)
    '        Write(1, Putts)
    '        FileClose(1)
    '    Else
    '        FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalPutts.txt", OpenMode.Input)
    '        Input(1, TotalPutts)
    '        FileClose(1)
    '        TotalPutts += Putts
    '        FileOpen(1, "C:\users\ben\golfdata\cct\cctTotalPutts.txt", OpenMode.Output)
    '        Write(1, TotalPutts)
    '        FileClose(1)
    '    End If

    '    RoundPPH = Putts / Holes
    '    txtAvgPPH.Text = CStr(Math.Round(TotalPutts / GetTotalHoles(), 2))
    'End Sub

    ''uses value Of String nineplayed ("Front" Or "Back") To give number Of available fairways.


    'Sub CalcNumOfAvailableFairways(Nineplayed As String)
    '    Dim Holes As Integer
    '    Dim CourseName As String
    '    Dim FairwaysHit As Integer
    '    Dim AvailableFairways As Integer
    '    Dim PctFwysHit As Single
    '    Dim Path As String
    '    Dim data() As String
    '    Dim i As Integer
    '    Dim TeeColor As String
    '    Dim Nine As String

    '    'Holes = CInt(cboHoles.Text)
    '    CourseName = cboCourse.Text
    '    ' FairwaysHit = CInt(txtFairwaysHit.Text)
    '    'Path = CreatePathForCourse(CourseName)
    '    'TeeColor = cboTeeColor.Text

    '    Nine = Microsoft.VisualBasic.Right(Nineplayed, 1) 'Look for last letter of NinePlayed
    '    If CourseName = "Airways" Or CourseName = "Riverside,Ca" Then
    '        If Nine = "t" Then ' last letter of "Front"
    '            AvailableFairways = 3
    '        ElseIf Nine = "k" Then ' Last letter of "Back"
    '            AvailableFairways = 2
    '        End If
    '    End If
    '    If CourseName = "Sherwood Forest" Then
    '        If Nine = "t" Then
    '            AvailableFairways = 8
    '        ElseIf Nine = "k" Then
    '            AvailableFairways = 6
    '        End If
    '    End If
    'End Sub


    'Private Sub txtFairwaysHit_TextChanged(sender As Object, e As EventArgs) Handles txtFairwaysHit.TextChanged
    '    Dim TeePlayed As String
    '    Dim Coursename As String
    '    Dim AvailableFairways As Integer
    '    Dim LengthTotalFairwaysHit As Integer
    '    Dim TotalFairwaysHit As Integer
    '    Dim HolesPlayed As Integer
    '    Dim LengthTotalAvailableFairways As Integer
    '    Dim TotalAvailableFairways As Integer
    '    Dim FairwaysHit As Integer
    '    Dim PathAvailableFairways As String
    '    Dim PathTotalFairwaysHit As String

    '    Coursename = cboCourse.Text
    '    FairwaysHit = CInt(txtFairwaysHit.Text)
    '    HolesPlayed = cboHolesPlayed.Text
    '    'PathAvailablefairways = "C:\users\ben\golfdata\cct\AvailableFairways.txt"
    '    PathTotalFairwaysHit = "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt"
    '    Select Case HolesPlayed
    '        Case Is = 9
    '            If Coursename = "Riverside,Ca" Or Coursename = "Airways" Then
    '                If Microsoft.VisualBasic.Right(TeePlayed, 10) = "t" Then ' look for the "t" in "Front" string of TeePlayed
    '                    AvailableFairways = 6
    '                ElseIf Microsoft.VisualBasic.Right(TeePlayed, 10) = "k" Then ' Look for the "k" in "Back" string of TeePlayed
    '                    AvailableFairways = 7
    '                End If
    '            End If
    '            If Coursename = "Sherwood Forest" Then
    '                If Microsoft.VisualBasic.Right(TeePlayed, 10) = "t" Then ' look for the "t" in "Front" string of TeePlayed
    '                    AvailableFairways = 8
    '                ElseIf Microsoft.VisualBasic.Right(TeePlayed, 10) = "k" Then ' Look for the "k" in "Back" string of TeePlayed
    '                    AvailableFairways = 6
    '                End If
    '            Else
    '                AvailableFairways = 7
    '            End If
    '            LengthTotalAvailableFairways = FileLen("C:\users\ben\golfdata\cct\TotalAvailableFairways.txt")
    '            If LengthTotalAvailableFairways = 0 Then
    '                FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Append)
    '                Write(1, AvailableFairways)
    '                FileClose(1)
    '            Else
    '                FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Input)
    '                Input(1, TotalAvailableFairways)
    '                TotalAvailableFairways += AvailableFairways
    '                FileClose(1)
    '                FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Output)
    '                Write(1, TotalAvailableFairways)
    '                FileClose(1)
    '            End If

    '            'if file is empty then write first data.If data already there then accumulate latest data
    '            LengthTotalFairwaysHit = FileLen("C:\users\ben\golfdata\cct\TotalFairwaysHit.txt")
    '            If LengthTotalFairwaysHit = 0 Then
    '                FileOpen(1, PathTotalFairwaysHit, OpenMode.Append)
    '                Write(1, FairwaysHit)
    '                FileClose(1)
    '            Else
    '                FileOpen(1, PathTotalFairwaysHit, OpenMode.Input)
    '                Input(1, TotalFairwaysHit)
    '                TotalFairwaysHit += FairwaysHit
    '                FileClose(1)
    '                FileOpen(1, PathTotalFairwaysHit, OpenMode.Output)
    '                Write(1, TotalFairwaysHit)
    '                FileClose(1)
    '            End If
    '        Case Is = 18
    '            If Coursename = "Riverside,Ca" Or Coursename = "Airways" Then
    '                AvailableFairways = 13
    '            Else
    '                AvailableFairways = 14
    '            End If

    '            'call CalculateFairways(AvailableFairways,FairwaysHit)
    '            'If file Is Empty Then Write first data.If data already there then accumulate latest data
    '            'LengthTotalAvailableFairways = FileLen("C:\users\ben\golfdata\cct\TotalAvailableFairways.txt")

    '            If FileLen("C:\users\ben\golfdata\cct\TotalAvailableFairways.txt") = 0 Then
    '                FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Output)
    '                Write(1, AvailableFairways)
    '                FileClose(1)
    '                TotalAvailableFairways = AvailableFairways
    '            End If
    '            If FileLen("C:\users\ben\golfdata\cct\TotalFairwaysHit.txt") = 0 Then
    '                FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Output)
    '                Write(1, FairwaysHit)
    '                FileClose(1)
    '                TotalFairwaysHit = FairwaysHit
    '            End If
    '            txtRndPctFwysHit.Text = CStr(Math.Round(FairwaysHit / AvailableFairways * 100, 2))
    '            txtAvgPctFwysHit.Text = CStr(Math.Round(TotalFairwaysHit / TotalAvailableFairways * 100, 2))
    '            Exit Sub

    '            FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Input)
    '            Input(1, TotalAvailableFairways)
    '            TotalAvailableFairways += AvailableFairways
    '            FileClose(1)
    '            FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Output)
    '            Write(1, TotalAvailableFairways)
    '            FileClose(1)

    '            FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Input)
    '            Input(1, FairwaysHit)
    '            TotalFairwaysHit += FairwaysHit
    '            FileClose(1)
    '            FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Output)
    '            Write(1, TotalFairwaysHit)
    '    End Select
    '    txtRndPctFwysHit.Text = CStr(Math.Round(FairwaysHit / AvailableFairways * 100, 2))
    '    txtAvgPctFwysHit.Text = CStr(Math.Round(TotalFairwaysHit / TotalAvailableFairways * 100, 2))



    'End Sub



    'Private Sub txtGreensHit_TextChanged(sender As Object, e As EventArgs) Handles txtGreensHit.TextChanged
    '    Dim GreensHit As Integer
    '    Dim TotalGreensHit As Integer
    '    Dim HolesThisRound As Integer
    '    Dim TotalHoles As Integer

    '    GreensHit = CInt(txtGreensHit.Text)
    '    HolesThisRound = cboHolesPlayed.Text
    '    TotalHoles = GetTotalHoles(cboHolesPlayed.Text)
    '    Call CalculateGreensHit(GreensHit)

    '    If FileLen("C:\users\ben\golfdata\cct\TotalGreensHit.txt") = 0 Then
    '        FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Append)
    '        Write(1, GreensHit)
    '        FileClose(1)
    '        TotalGreensHit = GreensHit
    '        txtRndPctGrnsHit.Text = CStr(Math.Round(GreensHit / HolesThisRound * 100, 2))
    '        txtAvgPctGrnsHit.Text = CStr(Math.Round(TotalGreensHit / TotalHoles * 100, 2))
    '        Exit Sub
    '    ElseIf FileLen("C:\users\ben\golfdata\cct\TotalGreensHit.txt") > 0 Then
    '        FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Input)
    '        Input(1, TotalGreensHit)
    '        TotalGreensHit += GreensHit
    '        FileClose(1)
    '        FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Output)
    '        Write(1, TotalGreensHit)
    '        FileClose(1)
    '        txtRndPctGrnsHit.Text = CStr(Math.Round(GreensHit / HolesThisRound * 100, 2))
    '        txtAvgPctGrnsHit.Text = CStr(Math.Round(TotalGreensHit / TotalHoles * 100, 2))
    '    End If

    'End Sub



    'Function TruncateToOneDecimalPlace(total As Single) As Single
    '    If total >= 10 Or total < 0 Then
    '        txtIndex10.Text = Mid(CStr(total), 1, 4)
    '    Else
    '        txtIndex10.Text = Mid(CStr(total), 1, 3)
    '    End If
    '    Return total
    'End Function

    Private Sub btnPostScore_Click(sender As Object, e As EventArgs) Handles btnPostScore.Click
        Dim putts As String = txtPutts.Text

        Call CheckPuttsInput(putts)

        Dim CourseName As String
        Dim TeeColor As String
        Dim Holes As Integer
        Dim path As String
        Dim data() As String
        Dim i As Integer
        Dim rating As Single
        Dim slope As Integer
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
        'TeeColor = cboTeePlayed.Text
        Holes = CInt(cboHolesPlayed.Text)
        Score = CInt(txtScore.Text)
        path = CreatePathForCourse(CourseName)
        DatePlayed = ShortDate()
        TeePlayed = cboTeePlayed.Text

        Select Case Holes
            Case Is = 9   'Select rating and slope for a selected tee color for either Back or Front Nine
                Dim Position As Integer
                Dim String1 As String

                String1 = Microsoft.VisualBasic.Right(TeePlayed, 10) 'gets 10 characters from the right of string "TeePlayed"
                If Microsoft.VisualBasic.Left(String1, 1) = "t" Then ' looks for first letter to left in String1. 
                    Position = InStr(TeePlayed, "Front") ' get position of "F" in "Front"
                    rating = Math.Round(CSng(Mid(TeePlayed, Position + 6, 4)), 2) 'use position to get next 4 characters i.e.rating.
                    slope = CInt(Microsoft.VisualBasic.Right(TeePlayed, 3)) 'get slope from last three characters in string "TeePlayed"
                    'txtFairwaysHit.Text = CStr(rating)
                    'TextBox3.Text = CStr(slope)
                ElseIf Microsoft.VisualBasic.Left(String1, 1) = "k" Then
                    Position = InStr(TeePlayed, "Back")
                    rating = Math.Round(CSng(Mid(TeePlayed, Position + 5, 4)), 2)
                    slope = CInt(Microsoft.VisualBasic.Right(TeePlayed, 3))
                    'txtFairwaysHit.Text = CStr(rating)
                    'TextBox3.Text = CStr(slope)
                End If
                Index9 = CalculateIndex(rating, slope, Score)

                length = CInt(FileLen("C:\users\ben\golfdata\cctFirstNineIndex.txt"))
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
                    txtRoundIndex.Text = TruncateIndexToOneDp(CStr(Index9))
                    'index = CalculateData(rating, slope, Score)
                    FileOpen(1, "C:\users\ben\golfdata\cctFirstNineIndex.txt", OpenMode.Append)
                    Write(1, FirstNineDate)
                    Write(1, FirstNineCourseName)
                    Write(1, FirstNineScore)
                    Write(1, FirstNineRating)
                    Write(1, FirstNineSlope)
                    FileClose(1)
                    FileOpen(2, "C:\users\ben\golfdata\cctForm2FirstNineData.txt", OpenMode.Output)
                    Write(2, FirstNineDate) 'Store selected nine hole data for output on form2
                    Write(2, FirstNineCourseName)
                    Write(2, FirstNineScore)
                    Write(2, FirstNineIndex)
                    FileClose(2)
                End If
                If length > 3 Then 'if first nine hole score in file then input first nine hole score
                    'and combine data from both nines
                    FileOpen(1, "C:\users\ben\golfdata\cctFirstNineIndex.txt", OpenMode.Input)
                    Input(1, FirstNineDate)
                    Input(1, FirstNineCourseName)
                    Input(1, FirstNineScore)
                    Input(1, FirstNineRating)
                    Input(1, FirstNineSlope)
                    FileClose(1)
                    DatePlayed = ShortDate()
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
                    CombinedIndex = CSng(((CSng(Score) - rating) * (113 / slope)) * 0.96)
                    Index18 = TruncateIndexToOneDp(CStr(CombinedIndex))
                    'Score = Score & "C" 
                    CourseName = FirstNineCourseName & " / " & SecondNineCourseName & "-C" ' "C" indicates that score is combined from two nine hole scores
                    txtRoundIndex.Text = CStr(Index18)

                    'open for output to clear files after two nine hole scores entered
                    FileOpen(1, "C:\users\ben\golfdata\cctFirstNineIndex.txt", OpenMode.Output)
                    'FileOpen(2, "C:\users\ben\golfdata\cct\FirstNineHoleData.txt", OpenMode.Output)
                    'FileClose(2)
                    FileClose(1)
                End If
            Case Is = 18
                Dim StringRating As String ' This code relies on the consistent position of rating and slope at the _
                'end of the file i.e (teecolor,rr.r,sss)

                StringRating = Microsoft.VisualBasic.Right(TeePlayed, 8) 'selects rating and slope from string in "cboTeePlayed"
                rating = Microsoft.VisualBasic.Left(StringRating, 4) 'selects rating from string "StringRating" rr.r
                slope = Microsoft.VisualBasic.Right(TeePlayed, 3) 'selects slope from string "TeePlayed" sss
                Index18 = CalculateIndex(rating, slope, Score) 'Calculate Index and Differential for 18 hole score.

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
        'FileOpen(1, "C:\users\ben\golfdata\cct\DCSIRS_20.txt", OpenMode.Append)
        'Write(1, DatePlayed)
        'Write(1, CourseName)
        'Write(1, Score)
        'Write(1, Index18)
        'Write(1, rating)
        'Write(1, slope)
        'FileClose(1)
        Call MoveLastEntryToTop(DatePlayed, CourseName, Score, Index18, rating, slope)
    End Sub

    ' Private Sub txtPutts_Leave(sender As Object, e As EventArgs) Handles txtPutts.Leave 'Dim Putts As String
    'Dim TotalPutts As Integer
    'Dim HolesThisRound As Integer
    'Dim TotalHolesPlayed As Integer
    'Dim Message As String
    'Dim Heading As String

    'HolesThisRound = CInt(cboHolesPlayed.Text)
    'Putts = txtPutts.Text

    'If Putts = "" Then
    '    txtPutts.BackColor = Color.Red
    '    MessageBox.Show("You must enter a value for GreensHit")
    '    txtGreensHit.Focus()
    '    txtGreensHit.BackColor = Color.White
    'End If
    'If Putts < HolesThisRound Then
    '    Message = "This value is too low"
    '    Heading = "GreensHit"
    '    MessageBox.Show(Message, Heading)
    '    txtPutts.BackColor = Color.Red
    '    txtPutts.Focus()
    'End If
    'If Putts > HolesThisRound * 3 Then
    '    Message = "This value is outside a normal range.Continue"
    '    Heading = "GreensHit"
    '    If MessageBox.Show(Message, Heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.OK Then
    '        txtFairwaysHit.Focus()
    '    ElseIf MessageBox.Show(Message, Heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
    '        txtPutts.Focus()
    '    End If
    'End If

    'FileOpen(1, "C:\users\ben\golfdata\cct\TotalPutts.txt", OpenMode.Input)
    '    Input(1, TotalPutts)
    '    FileClose(1)
    '    TotalPutts += CInt(Putts)
    '    FileOpen(1, "C:\users\ben\golfdata\cct\TotalPutts.txt", OpenMode.Output)
    '    Write(1, TotalPutts)
    'FileClose(1)
    'FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
    'Input(1, TotalHolesPlayed)
    'FileClose(1)

    'txtRoundPPH.Text = CStr(Math.Round(CInt(Putts) / HolesThisRound, 2))
    'txtAvgPPH.Text = CStr(Math.Round(TotalPutts / TotalHolesPlayed, 2))
    'End Sub



    'Private Sub cboHolesPlayed_Leave(sender As Object, e As EventArgs) Handles cboHolesPlayed.Leave
    'Dim TotalHolesPlayed As Integer
    'Dim HolesPlayed As Integer

    'HolesPlayed = CInt(cboHolesPlayed.Text)

    'FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
    'Input(1, totalholesplayed)
    'FileClose(1)
    'TotalHolesPlayed += HolesPlayed
    'FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Output)
    'Write(1, TotalHolesPlayed)

    'End Sub



    Private Sub TxtPutts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPutts.KeyPress
        'key trap putts textbox.Allow only numbers
        Dim i As Integer


        Select Case e.KeyChar
                Case CChar("0") To CChar("9"), ControlChars.Back
                    e.Handled = False
                Case ControlChars.Cr
                    e.Handled = False
                Case Else
                    e.Handled = True
            End Select


    End Sub
    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        'key trap score textbox only numbers are allowed
        Dim i As Integer

        For i = 0 To 1
            Select Case e.KeyChar
                Case CChar("0") To CChar("9"), ControlChars.Back
                    e.Handled = False
                Case ControlChars.Cr
                    txtScore.Focus()
                    e.Handled = False
                Case Else
                    e.Handled = True
            End Select
        Next i

    End Sub

    Private Sub txtFairwaysHit_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtGreensHit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGreensHit.KeyPress
        'key trap score textbox only numbers are allowed
        Dim i As Integer

        For i = 0 To 1
            Select Case e.KeyChar
                Case CChar("0") To CChar("9"), ControlChars.Back
                    e.Handled = False
                Case ControlChars.Cr
                    txtScore.Focus()
                    e.Handled = False
                Case Else
                    e.Handled = True
            End Select
        Next i
    End Sub

    'Private Sub txtPutts_TextChanged(sender As Object, e As EventArgs) Handles txtPutts.TextChanged


    'Private Sub txtFairwaysHit_MouseDown(sender As Object, e As MouseEventArgs) Handles txtFairwaysHit.MouseDown
    '    Dim TeePlayed As String
    '    Dim Coursename As String
    '    Dim AvailableFairways As Integer
    '    Dim HolesPlayed As Integer
    '    Dim FairwaysHit As Integer
    '    Dim PathTotalFairwaysHit As String
    '    Dim Letter As String

    '    Dim Putts As String
    '    Dim TotalPutts As Integer
    '    Dim HolesThisRound As Integer
    '    Dim TotalHolesPlayed As Integer
    '    Dim Message As String
    '    Dim Heading As String

    '    HolesThisRound = CInt(cboHolesPlayed.Text)
    '    Putts = txtPutts.Text

    '    'If Putts = "" Then
    '    '    txtPutts.BackColor = Color.Red
    '    '    If MessageBox.Show("You must enter a value for Putts", "Putts", MessageBoxButtons.OK) = DialogResult.OK Then
    '    '        txtPutts.BackColor = Color.White
    '    '        txtPutts.Clear()
    '    '        txtPutts.Focus()
    '    '    End If
    '    'End If
    '    'If Putts < HolesThisRound Then
    '    '    Message = "This value is too low.Enter a valid number"
    '    '    Heading = "Putts"
    '    '    If MessageBox.Show(Message, Heading, MessageBoxButtons.OK) = DialogResult.OK Then
    '    '        txtPutts.Select()
    '    '        Putts = txtPutts.Text
    '    '    End If
    '    'End If
    '    '    If Putts > HolesThisRound * 3 Then
    '    '    Message = "This value is outside a normal range.Continue"
    '    '    Heading = "Putts"
    '    '    If MessageBox.Show(Message, Heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '    '        txtFairwaysHit.Select()
    '    '        FairwaysHit = txtFairwaysHit.Text
    '    '    ElseIf MessageBox.Show(Message, Heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
    '    '        txtPutts.Select()
    '    '        Putts = txtPutts.Text
    '    '    End If
    '    'End If

    '    Coursename = cboCourse.Text
    '    FairwaysHit = CInt(txtFairwaysHit.Text)
    '    HolesPlayed = cboHolesPlayed.Text
    '    'PathAvailablefairways = "C:\users\ben\golfdata\cct\AvailableFairways.txt"
    '    PathTotalFairwaysHit = "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt"
    '    Select Case HolesPlayed
    '        Case Is = 9
    '            If Coursename = "Riverside,Ca" Or Coursename = "Airways" Then
    '                Letter = Microsoft.VisualBasic.Right(cboTeePlayed.Text, 10) ' get 10 characters from right for string letter
    '                If Microsoft.VisualBasic.Left(Letter, 1) = "t" Then 'look for "t" in first character
    '                    AvailableFairways = 6
    '                ElseIf Letter = "k" Then ' Look for the "k" in "Back" string of TeePlayed
    '                    AvailableFairways = 7
    '                End If

    '                If Coursename = "Sherwood Forest" Then
    '                    Letter = Microsoft.VisualBasic.Right(cboTeePlayed.Text, 10)
    '                    If Microsoft.VisualBasic.Left(Letter, 1) = "t" Then
    '                        AvailableFairways = 8
    '                    ElseIf Letter = "k" Then ' Look for the "k" in "Back" string of TeePlayed
    '                        AvailableFairways = 6
    '                    End If
    '                End If
    '            ElseIf Coursename <> "Riverside,Ca" Or Coursename <> "Airways" Or Coursename <> "Sherwood Forest" Then
    '                AvailableFairways = 7
    '            End If
    '            Call CalculateFairways(AvailableFairways, FairwaysHit)

    '        Case Is = 18
    '            If Coursename = "Riverside,Ca" Or Coursename = "Airways" Then
    '                AvailableFairways = 13
    '            Else
    '                AvailableFairways = 14
    '            End If
    '            Call CalculateFairways(AvailableFairways, FairwaysHit)
    '    End Select
    'End Sub

    Private Sub btnDisplayTable_Click(sender As Object, e As EventArgs) Handles btnDisplayTable.Click
        Dim data() As String
        Dim lowindex() As String
        Dim date1 As String
        Dim HolesPlayed As Integer
        Dim MaxColorLines As Integer
        Dim i As Integer
        Dim k As Integer
        Dim w As Integer
        Dim score As Integer
        score = CInt(txtScore.Text)

        LowIndexForHolesPlayed() 'call function to keep current index displayed on form2 when leaving and returning to form.
        Call TimesShotAge(score)

        ' Create array "Data" from the file containing data from the latest 20 rounds. 
        FileOpen(1, "C:\users\ben\golfdata\cct\dcsirs_20.txt", OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve data(i)
            Input(1, data(i))
            i += 1
        Loop
        FileClose(1)

        'Create array "lowindex" from the indexes from the last 20 rounds
        FileOpen(1, "C:\users\ben\golfdata\cct\sorted20.txt", OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve lowindex(k)
            Input(1, lowindex(k))
            k += 1
        Loop
        FileClose(1)

        'Fill the data grid with data from the latest rounds.
        Do Until w >= UBound(data)
            date1 = data(w)
            Form2.DataGridView1.Rows.Add(date1, data(w + 1), data(w + 2), data(w + 3), data(w + 4), data(w + 5))
            w += 6
        Loop

        HolesPlayed = cboHolesPlayed.Text / 18
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

    'Private Sub txtGreensHit_TextChanged(sender As Object, e As EventArgs) Handles txtGreensHit.TextChanged
    '    Dim GreensHit As String = txtGreensHit.Text
    '    Dim TotalGreensHit As Integer
    '    Dim TotalHolesPlayed As Integer
    '    Dim HolesPlayed As Integer = cboHolesPlayed.Text


    '    FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Input)
    '    Input(1, TotalGreensHit)
    '    FileClose(1)
    '    TotalGreensHit += CInt(GreensHit)
    '    FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Output)
    '    Write(1, TotalGreensHit)
    '    FileClose(1)

    '    FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
    '    Input(1, TotalHolesPlayed)
    '    FileClose(1)

    '    txtRndPctGrnsHit.Text = CStr(Math.Round(GreensHit / HolesPlayed * 100, 2))
    '    txtAvgPctGrnsHit.Text = CStr(Math.Round(TotalGreensHit / TotalHolesPlayed * 100, 2))

    '    txtPutts.Focus()
    'End Sub




    Private Sub cboTeePlayed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeePlayed.SelectedIndexChanged
        cboFairwaysHit.Focus()
    End Sub

    Private Sub cboTeePlayed_Leave(sender As Object, e As EventArgs) Handles cboTeePlayed.Leave
        Dim CourseName As String = cboCourse.Text
        Dim HolesPlayed As Integer = CInt(cboHolesPlayed.Text)
        Dim i As Integer

        For i = 0 To AvailableFairways(HolesPlayed, CourseName)
            cboFairwaysHit.Items.Add(i)
        Next
    End Sub

    Private Sub cboFairwaysHit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFairwaysHit.SelectedIndexChanged
        Dim FairwaysHit As Integer

        FairwaysHit = CInt(cboFairwaysHit.Text)
        txtGreensHit.Focus()
    End Sub
    Private Sub txtGreensHit_TextChanged(sender As Object, e As EventArgs) Handles txtGreensHit.TextChanged
        Dim GreensHit As Integer = CInt(txtGreensHit.Text)
        Dim holesplayed As Integer = CInt(cboHolesPlayed.Text)
        Dim message As String = "You can't hit more greens than there are holes on the course"
        Dim TotalGreensHit As Integer
        Dim TotalHolesPlayed As Integer

        Select Case holesplayed
            Case Is = 9
                If GreensHit > (9) Then
                    txtGreensHit.Focus()
                    txtGreensHit.BackColor = Color.Red
                    MessageBox.Show(message)
                    txtGreensHit.BackColor = Color.White
                Else
                    GreensHit = CInt(txtGreensHit.Text)
                End If
            Case Is = 18
                If GreensHit > (18) Then
                    txtGreensHit.Focus()
                    txtGreensHit.BackColor = Color.Red
                    MessageBox.Show(message)
                    txtGreensHit.BackColor = Color.White
                Else
                    GreensHit = CInt(txtGreensHit.Text)
                End If
        End Select

        FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Input)
        Input(1, TotalGreensHit)
        FileClose(1)
        TotalGreensHit += GreensHit
        FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Output)
        Write(1, TotalGreensHit)
        FileClose(1)

        FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
        Input(1, TotalHolesPlayed)
        FileClose(1)

        txtRndPctGrnsHit.Text = CStr(Math.Round(GreensHit / holesplayed * 100, 2))
        txtAvgPctGrnsHit.Text = CStr(Math.Round(TotalGreensHit / TotalHolesPlayed * 100, 2))


    End Sub

    Private Sub txtGreensHit_Leave(sender As Object, e As EventArgs) Handles txtGreensHit.Leave
        Dim HolesPlayed As Integer = cboHolesPlayed.Text
        Dim message As String = "You can't hit more greens than holes on the course!"

        If txtGreensHit.Text = "" Then
            txtGreensHit.Focus()
            MessageBox.Show("You must enter a value for greens hit!")
        End If

    End Sub


    Private Sub txtPutts_TextChanged(sender As Object, e As EventArgs) Handles txtPutts.TextChanged
        Dim Putts As String = txtPutts.Text
        Dim TotalPutts As Integer
        Dim HolesThisRound As Integer = cboHolesPlayed.Text
        Dim TotalHolesPlayed As Integer
        Dim Message As String
        Dim Heading As String
        Dim count As Integer

        Call CalculatePuttPerCent(Putts)



        'HolesThisRound = CInt(cboHolesPlayed.Text)

        'Select Case HolesThisRound
        '    Case Is = 9
        '        If Putts < 9 Then
        '            Message = "This value is too low"
        '            Heading = "Putts"
        '            MessageBox.Show(Message, Heading)
        '            txtPutts.BackColor = Color.Red
        '            txtPutts.Focus()
        '            txtPutts.BackColor = Color.White
        '        Else
        '            Putts = CInt(txtPutts.Text)
        '        End If

        '    Case Is = 18
        '        If Putts > 3 * 18 Then
        '            Message = "This value is outside a normal range."
        '            Heading = "Putts"
        '            MessageBox.Show(Message, Heading)
        '            txtPutts.BackColor = Color.Red
        '            txtPutts.Focus()
        '            txtPutts.BackColor = Color.White
        '        ElseIf Putts < 18 Then
        '            MessageBox.Show("You can't have fewer Putts than there are holes on the course", "Putts")
        '            txtPutts.BackColor = Color.White
        '            txtPutts.Focus()
        '            txtPutts.BackColor = Color.White
        '        Else
        '            Putts = CInt(txtPutts.Text)
        '        End If

        'End Select


        'FileOpen(1, "C:\users\ben\golfdata\cct\TotalPutts.txt", OpenMode.Input)
        'Input(1, TotalPutts)
        'FileClose(1)
        'TotalPutts += CInt(Putts)
        'FileOpen(1, "C:\users\ben\golfdata\cct\TotalPutts.txt", OpenMode.Output)
        'Write(1, TotalPutts)
        'FileClose(1)
        'FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
        'Input(1, TotalHolesPlayed)
        'FileClose(1)

        'txtRoundPPH.Text = CStr(Math.Round(CInt(Putts) / HolesThisRound, 2))
        'txtAvgPPH.Text = CStr(Math.Round(TotalPutts / TotalHolesPlayed, 2))
    End Sub


End Class
