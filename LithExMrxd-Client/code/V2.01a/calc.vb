Imports System.Math
Public Class calc
    Private Sub plusb1_Click(sender As Object, e As EventArgs) Handles plusb1.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub jianb1_Click(sender As Object, e As EventArgs) Handles jianb1.Click
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub chengb1_Click(sender As Object, e As EventArgs) Handles chengb1.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub chub1_Click(sender As Object, e As EventArgs) Handles chub1.Click
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub mib1_Click(sender As Object, e As EventArgs) Handles mib1.Click
        TextBox3.Text = Val(TextBox1.Text) ^ Val(TextBox2.Text)
    End Sub

    Private Sub rootb1_Click(sender As Object, e As EventArgs) Handles rootb1.Click
        TextBox3.Text = Val(TextBox1.Text) ^ (1 / Val(TextBox2.Text))
    End Sub

    Private Sub Sinb1_Click(sender As Object, e As EventArgs) Handles Sinb1.Click
        TextBox3.Text = Format（Sin((3.1415926535897 / 180) * Val(TextBox1.Text))， “0.000000”)
    End Sub

    Private Sub cosb1_Click(sender As Object, e As EventArgs) Handles cosb1.Click
        TextBox3.Text = Format（Cos((3.1415926535897 / 180) * Val(TextBox1.Text))， “0.000000”)
    End Sub

    Private Sub tanb1_Click(sender As Object, e As EventArgs) Handles tanb1.Click
        TextBox3.Text = Format（Tan((3.1415926535897 / 180) * Val(TextBox1.Text))， “0.000000”)
    End Sub

    Private Sub clearb1_Click(sender As Object, e As EventArgs) Handles clearb1.Click
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub pangen1_Click(sender As Object, e As EventArgs) Handles pangen1.Click
        delta1.Text = (Val(btext1.Text) ^ 2) - (4 * Val(atext1.Text) * Val(ctext1.Text))
        If delta1.Text > 0 Then ssjs.Text = 2
        If delta1.Text = 0 Then ssjs.Text = 1
        If delta1.Text < 0 Then ssjs.Text = 0
    End Sub

    Private Sub recalc2_Click(sender As Object, e As EventArgs) Handles recalc2.Click
        delta1.Text = (Val(btext1.Text) ^ 2) - (4 * Val(atext1.Text) * Val(ctext1.Text))
        If delta1.Text > 0 Then ssjs.Text = 2
        If delta1.Text = 0 Then ssjs.Text = 1
        If delta1.Text < 0 Then ssjs.Text = 0
        resx1.Text = (-Val(btext1.Text) + (Val(delta1.Text) ^ 0.5)) / (2 * Val(atext1.Text))
        resx2.Text = (-Val(btext1.Text) - (Val(delta1.Text) ^ 0.5)) / (2 * Val(atext1.Text))
    End Sub

    Private Sub recalc3_Click(sender As Object, e As EventArgs) Handles recalc3.Click
        k.Text = (Val(f1y2.Text) - Val(f1y1.Text)) / (Val(f1x2.Text) - Val(f1x1.Text))
        b.Text = Val(f1y1.Text) - (Val(k.Text) * Val(f1x1.Text))
    End Sub

    Private Sub startscalc_Click(sender As Object, e As EventArgs) Handles startscalc.Click
        smallcalc.Show()
    End Sub


End Class