Public Class Form2
    Private Sub btnEnterAnother_Click(sender As Object, e As EventArgs) Handles btnEnterAnother.Click
        Hide()
        Form1.cboHolesPlayed.Text = ""
        Form1.txtScore.Text = ""
        Form1.cboCourse.Text = ""
        Form1.cboTeePlayed.Text = ""
        Form1.txtPutts.Text = ""
        Form1.txtFairwaysHit.Text = ""
        Form1.txtGreensHit.Text = ""
        Form1.txtRoundIndex.Text = ""
        Form1.txtIndex10.Text = ""

    End Sub


End Class