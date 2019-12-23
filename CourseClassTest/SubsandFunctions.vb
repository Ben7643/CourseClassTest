Module SubsandFunctions
    Function CreatePathForCourse(CourseName As String) As String

        Dim path As String
        Dim NumHoles As String

        NumHoles = Form1.cboHolesPlayed.Text
        Select Case CourseName
            Case Is = "Valhalla"
                path = "C:\users\ben\golfdata\cct\Valhalla.txt"
            Case Is = "Riverside,Ca"
                path = "C:\users\ben\golfdata\cct\Riverside,Ca.txt"
            Case Is = "Madera Muni"
                path = "C:\users\ben\golfdata\cct\Madera Muni.txt"
            Case Is = "Airways"
                path = "C:\users\ben\golfdata\cct\Airways.txt"
            Case Is = "Belmont_CC"
                path = "C:\users\ben\golfdata\cct\Belmont_CC.txt"
            Case Is = "Dragonfly"
                path = "C:\users\ben\golfdata\cct\Dragonfly.txt"
            Case Is = "Lemoore      "
                path = "C:\users\ben\golfdata\cct\Lemoore.txt"
            Case Is = "Madera_CC"
                path = "C:\users\ben\golfdata\cct\Madera_CC.txt"
            Case Is = "Ridge_Creek"
                path = "C:\users\ben\golfdata\cct\Ridge_Creek.txt"
            Case Is = "Sherwood Forest"
                path = "C:\users\ben\golfdata\cct\Sherwood Forest.txt"
            Case Is = "Sunnyside_CC"
                path = "C:\users\ben\golfdata\cct\Sunnyside_CC.txt"
            Case Is = "Pheasant_Run"
                path = "C:\users\ben\golfdata\cct\Pheasant_Run.txt"
            Case Is = "Valley Oaks GC-Lakes/Valley.txt"
                path = "C:\users\ben\golfdata\cct\Valley Oaks GC-Lakes/Valley.txt"
            Case Is = "Valley Oaks GC-Oaks/Lakes"
                path = "C:\users\ben\golfdata\cct\Valley Oaks GC-Oaks/Lakes.txt"
            Case Is = "Valley Oaks GC-Valley/Oaks"
                path = "C:\users\ben\golfdata\cct\Valley Oaks GC-Valley/Oaks.txt"
        End Select
        Return path
    End Function
    'Calculates differential and Index.
    Function CalculateIndex(rating As String, slope As String, score As Integer)
        Dim Difference As Single
        Dim Differential As Single
        Dim Index As Single
        Dim DatePlayed As String

        Difference = score - CSng(rating)
        Differential = Difference * (113 / CInt(slope))
        Index = Differential * 0.96
        Index = TruncateIndexToOneDp(Index) 'Truncate index to one decimal point
        Form1.txtRoundIndex.Text = CStr(Index)
        Return Index

    End Function
    Function TruncateIndexToOneDp(index As Single) As Single

        If CSng(index) < 0 Or CSng(index) >= 10 Then
            index = Mid(CStr(index), 1, 4)
        Else
            index = Mid(CStr(index), 1, 3)
        End If
        Return index
    End Function

    Function ShortDate() As String
        Dim ThisMonth As String
        Dim ThisDay As String
        Dim ThisYear As String
        Dim DatePlayed As String
        'DateTimePicker1.Value = Now

        ThisMonth = CStr(Form1.DateTimePicker1.Value.Month)
        ThisDay = CStr(Form1.DateTimePicker1.Value.Day)
        ThisYear = CStr(Form1.DateTimePicker1.Value.Year)
        DatePlayed = ThisMonth & "/" & ThisDay & "/" & ThisYear
        Return DatePlayed

    End Function
    'always keeps latest dated entry on top of file.Limits size of file to data from 
    'the last 20 rounds.

    Sub MoveLastEntryToTop(Dateplayed As String, CourseName As String, score As Integer, index18 As Single, rating As Single, slope As Integer)
        Dim j As Integer
        Dim i As Integer
        Dim OldFileName As String
        Dim NewFileName As String
        Dim OrigData() As String
        Dim PathTemp As String
        Dim PathOrig As String

        'Dateplayed = ShortDate()

        PathTemp = "C:\users\ben\golfdata\cct\DCSIRS_temp.txt"
        PathOrig = "C:\users\ben\golfdata\cct\DCSIRS_20.txt"

        If FileLen(PathOrig) = 0 Then
            FileOpen(1, PathOrig, OpenMode.Append)
            Write(1, Dateplayed)
            Write(1, CourseName)
            Write(1, score)
            Write(1, index18)
            Write(1, rating)
            Write(1, slope)
            FileClose(1)
            Exit Sub
        Else
            FileOpen(1, PathTemp, OpenMode.Append)
            Write(1, Dateplayed)
            Write(1, CourseName)
            Write(1, score)
            Write(1, index18)
            Write(1, rating)
            Write(1, slope)
            FileClose(1)

            FileOpen(1, PathOrig, OpenMode.Input) 'load date,course,score and index from DCSIRS_20.txt into an array
            Do While Not EOF(1)
                ReDim Preserve OrigData(j)
                Input(1, OrigData(j))
                j += 1
            Loop
            FileClose(1)

            FileOpen(1, PathTemp, OpenMode.Append) ' append data from only 20 rounds (6x20)  from array OrigData to DCSIRS_temp
            For i = LBound(OrigData) To UBound(OrigData)
                Write(1, OrigData(i))
                If i = 113 Then   '6 entries are already in file.i = 0 to 115 limits size to 120.
                    Exit For
                End If
            Next i
            FileClose(1)

            'delete original DCSIRS_20 and rename DCSIRS_temp to DCSIRS_20
            Kill("C:\users\ben\golfdata\cct\DCSIRS_20.txt")
            OldFileName = "C:\users\ben\golfdata\cct\DCSIRS_temp.txt"
            NewFileName = "C:\users\ben\golfdata\cct\DCSIRS_20.txt"
            Rename(OldFileName, NewFileName)
        End If
        Call Get20Index(NewFileName) ' put latest 20 indexes into separate file
    End Sub


    Sub Get20Index(newfilename As String)
        Dim j As Integer
        Dim k As Integer
        Dim i As Integer
        Dim Index_20() As String
        Dim TempIndex() As Single
        Dim Index10 As Single
        Dim SortedIndex() As String

        'If Flag = 1 Then
        '    Exit Sub
        'End If

        FileOpen(1, newfilename, OpenMode.Input) ' newfile name = "C:\users\ben\golfdata\cct\DCSIRS_20.txt"
        Do While Not EOF(1)
            ReDim Preserve Index_20(k)
            Input(1, Index_20(k))
            k += 1
        Loop
        FileClose(1)

        For j = 3 To UBound(Index_20) Step 6 ' puts only every fourth entry(Index) into array
            ReDim Preserve TempIndex(i)
            TempIndex(i) = CSng(Index_20(j))
            i += 1
        Next j
        Array.Sort(TempIndex)

        FileOpen(1, "C:\users\ben\golfdata\cct\Sorted20.txt", OpenMode.Output)
        For i = 0 To UBound(TempIndex)
            ReDim Preserve SortedIndex(i)
            SortedIndex(i) = TempIndex(i)
            Write(1, SortedIndex(i))
        Next
        FileClose(1)

        Index10 = CSng(LowIndexForHolesPlayed())
        Form1.txtIndex10.Text = CStr(TruncateIndexToOneDp(Index10))
        Form2.txtCurrentIndex.Text = CStr(TruncateIndexToOneDp(Index10))


    End Sub

    'Sub CheckPutts()
    '    Dim HolesPlayed As Integer
    '    HolesPlayed = CInt(Form1.cboHolesPlayed.Text)

    '    If Form1.txtPutts.Text = "" Then
    '        If MessageBox.Show("You must enter a value for putts", "Putts", MessageBoxButtons.OKCancel) = DialogResult.OK Then
    '            Form1.txtPutts.Focus()
    '        End If
    '    End If

    '    If Form1.txtPutts.Text < HolesPlayed Then
    '        If MessageBox.Show("You can't have fewer putts than the course has holes!", "Putts", MessageBoxButtons.OK) = DialogResult.OK Then
    '            Form1.txtPutts.Focus()
    '        End If
    '    ElseIf Form1.txtPutts.Text > HolesPlayed * 3 Then
    '        MessageBox.Show("This value is outside a normal range! Are you sure?")
    '        Form1.txtPutts.Focus()
    '    End If

    'End Sub
    'follow NCGA rules for calc. of HDCP for less than 20 rounds

    Function LowIndexForHolesPlayed() As String
        Dim golfindex() As String
        Dim X As Single
        Dim total As Single
        Dim m As Integer
        Dim Index10 As String
        Dim i As Integer
        Dim TotalHolesPlayed As Integer
        Dim HolesPlayed As Integer

        HolesPlayed = CInt(Form1.cboHolesPlayed.Text)
        FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
        Input(1, TotalHolesPlayed)
        FileClose(1)


        FileOpen(1, "C:\users\ben\golfdata\cct\Index20.txt", OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve golfindex(i)
            Input(1, golfindex(i))
            i += 1
        Loop
        FileClose(1)

        'calculate index based on lowest from first 6 rounds
        If TotalHolesPlayed < (7 * 18) Then          'if less than 7 rounds played set index to lowest index of 6 rounds.
            X = CSng(golfindex(m))
            If X >= 10 Or X < 0 Then  'displays only one unrounded decimal place for indexes < 10.
                Form1.txtIndex10.Text = Mid(CStr(X), 1, 4)
            Else
                Form1.txtIndex10.Text = Mid(CStr(X), 1, 3) 'displays one unrounded decimal place for indexes > 10
            End If
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            'form1.txtIndex10.text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
        End If
        'calculate index based on lowest 2 of 7 or 8 rounds
        If TotalHolesPlayed > (6 * 18) And TotalHolesPlayed <= (9.5 * 18) Then
            For i = 0 To 1
                total += CSng(golfindex(i))
            Next i
            total = total / 2
            Form1.txtIndex10.Text = CStr(TruncateIndexToOneDp(total))
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 3 of 9 or 10 rounds
        If TotalHolesPlayed > (8 * 18) And TotalHolesPlayed <= (11.5 * 18) Then
            For i = 0 To 2
                total += CSng(golfindex(i))
            Next i
            total = total / 3
            Form1.txtIndex10.Text = TruncateIndexToOneDp(total)
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 4 of 10 or 11 rounds.
        If TotalHolesPlayed > (10 * 18) And TotalHolesPlayed <= (13.5 * 18) Then
            For i = 0 To 3
                total += CSng(golfindex(i))
            Next i
            total = total / 4
            Form1.txtIndex10.Text = TruncateIndexToOneDp(total)
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 5 of 13 or 14 rounds
        If TotalHolesPlayed > (12 * 18) And TotalHolesPlayed <= (15.5 * 18) Then
            For i = 0 To 4
                total += CSng(golfindex(i))
            Next i
            total = total / 5
            Form1.txtIndex10.Text = TruncateIndexToOneDp(total)
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 6 of 15 or 16 rounds.
        If TotalHolesPlayed > (14 * 18) And TotalHolesPlayed <= (17.5 * 18) Then
            For i = 0 To 5
                total += CSng(golfindex(i))
            Next i
            total = total / 6
            Form1.txtIndex10.Text = TruncateIndexToOneDp(total)
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 7 of 17 rounds
        If TotalHolesPlayed >= (17 * 18) And TotalHolesPlayed < 18 * 18 Then
            For i = 0 To 6
                total += CSng(golfindex(i))
            Next i
            total = total / 7
            Form1.txtIndex10.Text = TruncateIndexToOneDp(total)
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 8 of 18 rounds
        If TotalHolesPlayed >= (18 * 18) And TotalHolesPlayed < 19 * 18 Then
            For i = 0 To 7
                total += CSng(golfindex(i))
            Next i
            total = total / 8
            Form1.txtIndex10.Text = TruncateIndexToOneDp(total)
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 9 of 19 rounds
        If TotalHolesPlayed >= (19 * 18) And TotalHolesPlayed < 20 * 18 Then
            For i = 0 To 8
                total += CSng(golfindex(i))
            Next i
            total = total / 9
            Form1.txtIndex10.Text = TruncateIndexToOneDp(total)
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        'calculate index based on lowest 10 of latest 20 rounds.
        If TotalHolesPlayed >= (20 * 18) Then
            For i = 0 To 9
                total = total + CSng(golfindex(i))
            Next i
            total = total / 10
            Form1.txtIndex10.Text = CStr(TruncateIndexToOneDp(total))
            Index10 = Form1.txtIndex10.Text
            Form2.txtCurrentIndex.Text = Index10
            Return Index10
            Call StoreRecentIndex(Form1.txtIndex10.Text)
            total = 0
        End If
        Return Index10
        'BtnPostScore.Visible = False
    End Function
    'Fills cboTeeColor with front nine and back nine teecolors,ratings and slopes
    Sub FillTeeplayed(numholes As String, path As String)
        Dim i As Integer
        Dim j As Integer
        Dim data() As String
        Dim Rating As Single
        Dim Slope As Integer
        Dim FRating As Single
        Dim BRating As Single
        Dim fSlope As Integer
        Dim bSlope As Integer
        Dim Newrating() As String

        FileOpen(1, path, OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve data(i)
            Input(1, data(i))
            i += 1
        Loop
        FileClose(1)
        'populate cbotee with teecolors,rating and slope for front and back nines for selected course.
        If numholes = 9 Then
            For i = 1 To UBound(data) Step 4
                Form1.cboTeePlayed.Items.Add(data(i) & data(i + 1) & "," & data(i + 2) _
            & "," & data(i + 3))
            Next i
        ElseIf numholes = 18 Then
            For i = 3 To UBound(data) Step 8
                If i > UBound(data) Then
                    Exit For
                End If
                FRating = CSng(data(i))
                BRating = CSng(data(i + 4))
                Rating = Math.Round(FRating + BRating, 2)
                fSlope = CInt(data(i + 1))
                bSlope = CInt(data(i + 5))
                Slope = (fSlope + bSlope) / 2
                Form1.cboTeePlayed.Items.Add(data(i - 2) & "," & Rating & "," & Slope)
            Next i
        End If


    End Sub
    'Function GetTotalHoles(HolesThisRound As Integer) As Integer
    '    'Dim HolesThisRound As Integer
    '    Dim TotalHoles As String
    '    Dim PathTotalHoles As String

    '    'HolesThisRound = CInt(Form1.cboHolesPlayed.Text)


    '    ''If FileLen(PathTotalHoles) = 0 Then 'if file is empty then write value of cboholes.text to file
    '    'FileOpen(1, PathTotalHoles, OpenMode.Append)
    '    '    Write(1, HolesThisRound)
    '    '    FileClose(1)
    '    '    TotalHoles = CStr(HolesThisRound)
    '    '    Return TotalHoles
    '    '    Exit Function

    '    '    'AveragePutts = CSng(totalputts / Holes_Played)
    '    '    'TxtTotalPPH.Text = CStr(Math.Round(AveragePutts, 2))
    '    '    'Call GetGreens_ForHolesPlayed(Holes_Played)
    '    'ElseIf FileLen(PathTotalHoles) > 0 Then
    '    FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Input)
    '    Input(1, CInt(TotalHoles))
    '        FileClose(1)
    '        TotalHoles = CInt(TotalHoles) + HolesThisRound
    '    FileOpen(1, "C:\users\ben\golfdata\cct\totalholes.txt", OpenMode.Output)
    '    Write(1, TotalHoles)
    '        FileClose(1)
    '    'AveragePutts = CSng(totalputts / TotalHoles)
    '    'TxtTotalPPH.Text = CStr(Math.Round(AveragePutts, 2))
    '    'Call getgreens(TotalHoles)

    '    Return TotalHoles

    'End Function



    Function AvailableFairways(HolesPlayed As Integer, CourseName As String)

        'Dim FairwaysHit As Integer
        Dim Letter As String

        CourseName = Form1.cboCourse.Text

        Select Case HolesPlayed
            Case Is = 9
                If CourseName = "Riverside,Ca" Or CourseName = "Airways" Then
                    Letter = Right(Form1.cboTeePlayed.Text, 10) ' get 10 characters from right for string letter
                    If Left(Letter, 1) = "t" Then 'look for "t" in first character
                        AvailableFairways = 6
                    ElseIf Letter = "k" Then ' Look for the "k" in "Back" string of TeePlayed
                        AvailableFairways = 7
                    End If

                    If CourseName = "Sherwood Forest" Then
                        Letter = Right(Form1.cboTeePlayed.Text, 10)
                        If Left(Letter, 1) = "t" Then
                            AvailableFairways = 8
                        ElseIf Letter = "k" Then ' Look for the "k" in "Back" string of TeePlayed
                            AvailableFairways = 6
                        End If
                    End If
                ElseIf CourseName <> "Riverside,Ca" Or CourseName <> "Airways" Or CourseName <> "Sherwood Forest" Then
                    AvailableFairways = 7
                End If
            Case Is = 18
                If CourseName = "Riverside,Ca" Or CourseName = "Airways" Then
                    AvailableFairways = 13
                Else
                    AvailableFairways = 14
                End If
                'Call CalculateFairways(AvailableFairways, FairwaysHit)
                Return AvailableFairways
        End Select

    End Function
    'Sub CalculateFairways(AvailableFairways As Integer, FairwaysHit As Integer)

    'If file Is Empty Then Write first data and exit Sub.If data already there then accumulate latest data and store it.
    'Dim TotalAvailableFairways As Integer
    'Dim TotalFairwaysHit As Integer

    'If FileLen("C:\users\ben\golfdata\cct\TotalAvailableFairways.txt") = 0 Then
    '    FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Output)
    '    Write(1, AvailableFairways)
    '    FileClose(1)
    '    'TotalAvailableFairways = AvailableFairways

    '    If FileLen("C:\users\ben\golfdata\cct\TotalFairwaysHit.txt") = 0 Then
    '        FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Output)
    '        Write(1, FairwaysHit)
    '        FileClose(1)
    '        'TotalFairwaysHit = FairwaysHit

    '        Form1.txtRndPctFwysHit.Text = CStr(Math.Round(FairwaysHit / AvailableFairways * 100, 2))
    '        'Form1.txtAvgPctFwysHit.Text = CStr(Math.Round(TotalFairwaysHit / TotalAvailableFairways * 100, 2))
    '        Exit Sub
    '    End If
    'Else
    'FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Input)
    'Input(1, TotalAvailableFairways)
    'TotalAvailableFairways += AvailableFairways
    'FileClose(1)
    'FileOpen(1, "C:\users\ben\golfdata\cct\TotalAvailableFairways.txt", OpenMode.Output)
    'Write(1, TotalAvailableFairways)
    'FileClose(1)

    'FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Input)
    'Input(1, TotalFairwaysHit)
    'FileClose(1)
    'TotalFairwaysHit += FairwaysHit
    'FileOpen(1, "C:\users\ben\golfdata\cct\TotalFairwaysHit.txt", OpenMode.Output)
    'Write(1, TotalFairwaysHit)
    'FileClose(1)
    'Form1.txtRndPctFwysHit.Text = CStr(Math.Round(FairwaysHit / AvailableFairways * 100, 2))
    'Form1.txtAvgPctFwysHit.Text = CStr(Math.Round(TotalFairwaysHit / TotalAvailableFairways * 100, 2))
    'End If

    ' End Sub
    Sub CalculateGreensHit(greenshit As Integer, HolesThisRound As Integer, TotalHoles As Integer)
        Dim totalgreenshit As Integer

        'FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Input)
        '    Input(1, totalgreenshit)
        '    totalgreenshit += greenshit
        '    FileClose(1)
        '    FileOpen(1, "C:\users\ben\golfdata\cct\TotalGreensHit.txt", OpenMode.Output)
        '    Write(1, totalgreenshit)
        '    FileClose(1)
        '    Form1.txtRndPctGrnsHit.Text = CStr(Math.Round(greenshit / HolesThisRound * 100, 2))
        '    Form1.txtAvgPctGrnsHit.Text = CStr(Math.Round(totalgreenshit / TotalHoles * 100, 2))
        'End If
    End Sub
    Sub TimesShotAge(score As String)

        Dim TodayDate As Date = Now
        Dim MyDate As Date = #05/22/1936#
        Dim Age As Long = DateDiff(DateInterval.Year, MyDate, TodayDate)
        Dim Times As Integer
        Dim Num As Integer
        Dim Number As Integer
        Dim totalholes As Integer
        Dim Rounds As Integer

        If CInt(score) <= Age Then
            FileOpen(1, "C:\users\ben\golfdata\TimesShotAge.txt", OpenMode.Input)
            Input(1, Num)
            Times = Num + 1
            Form2.txtTimesShotAge.Text = CStr(Times)
            FileClose(1)
        Else
            FileOpen(1, "C:\users\ben\golfdata\TimesShotAge.txt", OpenMode.Input)
            Input(1, Number)
            Form2.txtTimesShotAge.Text = CStr(Number)
            FileClose(1)
        End If
        FileOpen(1, "C:\users\ben\golfdata\RoundsFrom 1-1-2018.txt", OpenMode.Input)
        FileOpen(2, "C:\users\ben\golfdata\TimesShotAge.txt", OpenMode.Input)
        Input(2, Times)
        Input(1, Rounds)
        Form2.txtShotAgePct.Text = CStr(Math.Round(Times / Rounds * 100, 2))
        FileClose(1)
        FileClose(2)

    End Sub
    Sub StoreRecentIndex(TxtIndex10 As String)
        FileOpen(1, "C:\users\ben\golfdata\cct\RecentIndex.txt", OpenMode.Output)
        Write(1, TxtIndex10)
        FileClose(1)
    End Sub

End Module
