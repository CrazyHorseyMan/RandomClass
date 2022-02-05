Public Class Form1
    Dim checked(22), duration(22), i As Integer
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If checked(1) = 1 Then
            checked(1) = 0
        Else
            checked(1) = 1
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If checked(7) = 1 Then
            checked(7) = 0
        Else
            checked(7) = 1
        End If
    End Sub

    Private Sub Timer1_Elapsed(sender As System.Object, e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        Dim z As Integer
        For z = 1 To 22
            checked(z) = 1
        Next z
        For i = 1 To 22
            duration(i) = 2
        Next
        Timer1.Stop()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If checked(2) = 1 Then
            checked(2) = 0
        Else
            checked(2) = 1
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If checked(3) = 1 Then
            checked(3) = 0
        Else
            checked(3) = 1
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If checked(4) = 1 Then
            checked(4) = 0
        Else
            checked(4) = 1
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If checked(5) = 1 Then
            checked(5) = 0
        Else
            checked(5) = 1
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If checked(6) = 1 Then
            checked(6) = 0
        Else
            checked(6) = 1
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If checked(8) = 1 Then
            checked(8) = 0
        Else
            checked(8) = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim student(22), count(22), j, death, problem, list As Integer
        Dim namen(22) As String
        list = -1
        namen(1) = "Erik"
        namen(2) = "Jonas"
        namen(3) = "Haley"
        namen(4) = "David"
        namen(5) = "Max"
        namen(6) = "Simon"
        namen(7) = "Florian"
        namen(8) = "Solice"
        namen(9) = "Jennifer"
        namen(10) = "Anika"
        namen(11) = "Manu"
        namen(12) = "Lena"
        namen(13) = "Niklas"
        namen(14) = "Sönke"
        namen(15) = "Tom"
        namen(16) = "Emma"
        namen(17) = "Leon"
        namen(18) = "Noelle"
        namen(19) = "Sabrina"
        namen(20) = "Farrell"
        namen(21) = "Anastasia"
        namen(22) = "Alex"
        Randomize()
        list = -list
        Do
            j = 0
            For i = 1 To 22
                If count(i) > 8 Then
                    j = j + 1
                End If
            Next
            problem = 0
            death = Int(Rnd() * 22 + 1)
            If checked(death) = 0 Then
                problem = 1
            End If
            If duration(death) < 2 Then
                problem = 1
            End If
            If list = 1 Then
                If j > 1 Then
                    If duration(death) < 9 Then
                        problem = 1
                    End If
                End If
            End If
        Loop Until problem = 0
        MsgBox(namen(death))
        For i = 1 To 22
            duration(i) = i + 1
        Next
        duration(death) = 0
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If checked(9) = 1 Then
            checked(9) = 0
        Else
            checked(9) = 1
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If checked(10) = 1 Then
            checked(10) = 0
        Else
            checked(10) = 1
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If checked(11) = 1 Then
            checked(11) = 0
        Else
            checked(11) = 1
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If checked(12) = 1 Then
            checked(12) = 0
        Else
            checked(12) = 1
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If checked(13) = 1 Then
            checked(13) = 0
        Else
            checked(13) = 1
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If checked(14) = 1 Then
            checked(14) = 0
        Else
            checked(14) = 1
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If checked(15) = 1 Then
            checked(15) = 0
        Else
            checked(15) = 1
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If checked(16) = 1 Then
            checked(16) = 0
        Else
            checked(16) = 1
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If checked(17) = 1 Then
            checked(17) = 0
        Else
            checked(17) = 1
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If checked(18) = 1 Then
            checked(18) = 0
        Else
            checked(18) = 1
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox19.CheckedChanged
        If checked(19) = 1 Then
            checked(19) = 0
        Else
            checked(19) = 1
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox20.CheckedChanged
        If checked(20) = 1 Then
            checked(20) = 0
        Else
            checked(20) = 1
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox21.CheckedChanged
        If checked(21) = 1 Then
            checked(21) = 0
        Else
            checked(21) = 1
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox22.CheckedChanged
        If checked(22) = 1 Then
            checked(22) = 0
        Else
            checked(22) = 1
        End If
    End Sub
End Class
