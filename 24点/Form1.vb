Public Class 巧算24点

    Dim AnswerN As Integer
    Dim equation2 As String
    Dim equation1 As String
    Public Function Count3(ByVal a As Integer, b As Integer)
        '作为三级，由从二级得到的两个数通过加减乘除判断是否满足条件，满足则输出满足结果的等式组
        '两数相加等于24的情况
        If (a + b = 24) Then
            AnswerN = AnswerN + 1
            Ans.Items.Add(equation1 + "  " + equation2 + "  " + CStr(a) + "+" + CStr(b) + " =" + CStr(24))
        End If
        '两数相乘等于24的情况
        If (a * b = 24) Then
            AnswerN = AnswerN + 1
            Ans.Items.Add(equation1 + "  " + equation2 + "  " + CStr(a) + "*" + CStr(b) + " =" + CStr(24))
        End If
        '两数相减等于24的情况
        If (a - b = 24) Then
            AnswerN = AnswerN + 1
            Ans.Items.Add(equation1 + "  " + equation2 + "  " + CStr(a) + "-" + CStr(b) + " =" + CStr(24))
        ElseIf (b - a = 24) Then
            AnswerN = AnswerN + 1
            Ans.Items.Add(equation1 + "  " + equation2 + "  " + CStr(b) + "-" + CStr(a) + " =" + CStr(24))
        End If
        '两数相除等于24的情况
        If ((b <> 0) And (a = 24 * b)) Then
            AnswerN = AnswerN + 1
            Ans.Items.Add(equation1 + "  " + equation2 + "  " + CStr(a) + "/" + CStr(b) + " =" + CStr(24))
        End If
        If ((a <> 0) And (b = 24 * a)) Then
            AnswerN = AnswerN + 1
            Ans.Items.Add(equation1 + "  " + equation2 + "  " + CStr(b) + "/" + CStr(a) + " =" + CStr(24))
        End If
    End Function

    Public Function Count2(ByVal a As Integer, b As Integer, c As Integer)
        '作为二级，由从一级得到三个数，用两个通过加减乘除得到一个新数与一个等式，并将另一个数，新数与等式输出给三级
        Dim value(2) As Integer
        Dim i, j, k, newvalue As Integer
        value(0) = a
        value(1) = b
        value(2) = c

        For i = 0 To 2
            For j = i + 1 To 2
                If j > 2 Then
                    Exit For
                End If
                k = 3 - i - j   '输出给上级的数
                '两数相加得新数
                newvalue = value(i) + value(j)
                equation2 = CStr(value(i)) + "+" + CStr(value(j)) + " =" + CStr(newvalue) '//得到一个等式输给三级
                Count3(newvalue, value(k)) '将新数和另一个数输出给三级
                '两数相乘得新数
                newvalue = value(i) * value(j)
                equation2 = CStr(value(i)) + "*" + CStr(value(j)) + " =" + CStr(newvalue)
                Count3(newvalue, value(k))
                '两数相减得新数
                If (value(i) > value(j)) Then
                    newvalue = value(i) - value(j)
                    equation2 = CStr(value(i)) + "-" + CStr(value(j)) + " =" + CStr(newvalue)
                    Count3(newvalue, value(k))
                Else
                    newvalue = value(j) - value(i)
                    equation2 = CStr(value(j)) + "-" + CStr(value(i)) + " =" + CStr(newvalue)
                    Count3(newvalue, value(k))
                End If
                '两数相除得新数
                If ((value(j) <> 0) And (value(i) Mod value(j) = 0)) Then
                    newvalue = value(i) / value(j)
                    equation2 = CStr(value(i)) + "/" + CStr(value(j)) + " =" + CStr(newvalue)
                    Count3(newvalue, value(k))
                ElseIf ((value(i) <> 0) And (value(j) Mod value(i) = 0)) Then
                    newvalue = value(j) / value(i)
                    equation2 = CStr(value(j)) + "/" + CStr(value(i)) + " =" + CStr(newvalue)
                    Count3(newvalue, value(k))
                End If
            Next j
        Next i
    End Function

    Public Function Count1(ByVal a As Integer, b As Integer, c As Integer, d As Integer)
        '作为一级，由输入的四个数，用两个通过加减乘除得到一个新数与一个等式，并将另两个数，新数输出给二级，等式输出给三级
        Dim value(3) As Integer
        Dim i, j, k, m, newvalue As Integer
        value(0) = a
        value(1) = b
        value(2) = c
        value(3） = d
        For i = 0 To 3

            For j = i + 1 To 3
                If j > 3 Then
                    Exit For
                End If
                'For k = 0 To ((k == i) || (k == j))'输出给中级的数
                k = 0
                Do While (k = i Or k = j)
                    'for (k = 0;(k == i) || (k == j);k++)
                    k = k + 1
                Loop
                m = 6 - i - j - k '//输出给中级的数
                '//两数相加得新数
                newvalue = value(i) + value(j)
                equation1 = CStr(value(i)) + "+" + CStr(value(j)) + " =" + CStr(newvalue) ';//得到一个等式输给上级
                Count2(newvalue, value(k), value(m)) ';//将新数和另两个数输出给中级
                '//两数相乘得新数
                newvalue = value(i) * value(j)
                equation1 = CStr(value(i)) + "*" + CStr(value(j)) + " =" + CStr(newvalue)
                Count2(newvalue, value(k), value(m))
                '//两数相减得新数
                If (value(i) > value(j)) Then
                    newvalue = value(i) - value(j)
                    equation1 = CStr(value(i)) + "-" + CStr(value(j)) + " =" + CStr(newvalue)
                    Count2(newvalue, value(k), value(m))
                Else
                    newvalue = value(j) - value(i)
                    equation1 = CStr(value(j)) + "-" + CStr(value(i)) + " =" + CStr(newvalue)
                    Count2(newvalue, value(k), value(m))
                End If
                '//两数相除得新数
                If ((value(j) <> 0) And (value(i) Mod value(j) = 0)) Then
                    newvalue = value(i) / value(j)
                    equation1 = CStr(value(i)) + "/" + CStr(value(j)) + " =" + CStr(newvalue)
                    Count2(newvalue, value(k), value(m))
                ElseIf ((value(i) <> 0) And (value(j) Mod value(i) = 0)) Then
                    newvalue = value(j) / value(i)
                    equation1 = CStr(value(j)) + "/" + CStr(value(i)) + " =" + CStr(newvalue)
                    Count2(newvalue, value(k), value(m))
                End If
            Next j
        Next i
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Randomize()
        NUM1.Text = 0
        NUM2.Text = 0
        NUM3.Text = 0
        NUM4.Text = 0
        Do Until (NUM1.Text <> NUM2.Text And NUM1.Text <> NUM3.Text And NUM1.Text <> NUM4.Text And NUM2.Text <> NUM3.Text And NUM2.Text <> NUM4.Text And NUM3.Text <> NUM4.Text)
            NUM1.Text = Int(Rnd() * 13) + 1
            NUM2.Text = Int(Rnd() * 13) + 1
            NUM3.Text = Int(Rnd() * 13) + 1
            NUM4.Text = Int(Rnd() * 13) + 1
        Loop
        If (NUM1.Text = 1) Then
            NUM1.Text = "A"
        ElseIf (NUM1.Text = 11) Then
            NUM1.Text = "J"
        ElseIf (NUM1.Text = 12) Then
            NUM1.Text = "Q"
        ElseIf (NUM1.Text = 13) Then
            NUM1.Text = "K"
        End If
        If (NUM2.Text = 1) Then
            NUM2.Text = "A"
        ElseIf (NUM2.Text = 11) Then
            NUM2.Text = "J"
        ElseIf (NUM2.Text = 12) Then
            NUM2.Text = "Q"
        ElseIf (NUM2.Text = 13) Then
            NUM2.Text = "K"
        End If
        If (NUM3.Text = 1) Then
            NUM3.Text = "A"
        ElseIf (NUM3.Text = 11) Then
            NUM3.Text = "J"
        ElseIf (NUM3.Text = 12) Then
            NUM3.Text = "Q"
        ElseIf (NUM3.Text = 13) Then
            NUM3.Text = "K"
        End If
        If (NUM4.Text = 1) Then
            NUM4.Text = "A"
        ElseIf (NUM4.Text = 11) Then
            NUM4.Text = "J"
        ElseIf (NUM4.Text = 12) Then
            NUM4.Text = "Q"
        ElseIf (NUM4.Text = 13) Then
            NUM4.Text = "K"
        End If

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btncount.Click
        Ans.Items.Clear()
        If (NUM1.Text = "A") Then
            NUM1.Text = 1
        ElseIf (NUM1.Text = "J") Then
            NUM1.Text = 11
        ElseIf (NUM1.Text = "Q") Then
            NUM1.Text = 12
        ElseIf (NUM1.Text = "K") Then
            NUM1.Text = 13
        End If
        If (NUM2.Text = "A") Then
            NUM2.Text = 1
        ElseIf (NUM2.Text = "J") Then
            NUM2.Text = 11
        ElseIf (NUM2.Text = "Q") Then
            NUM2.Text = 12
        ElseIf (NUM2.Text = "K") Then
            NUM2.Text = 13
        End If
        If (NUM3.Text = "A") Then
            NUM3.Text = 1
        ElseIf (NUM3.Text = "J") Then
            NUM3.Text = 11
        ElseIf (NUM3.Text = "Q") Then
            NUM3.Text = 12
        ElseIf (NUM3.Text = "K") Then
            NUM3.Text = 13
        End If
        If (NUM4.Text = "A") Then
            NUM4.Text = 1
        ElseIf (NUM4.Text = "J") Then
            NUM4.Text = 11
        ElseIf (NUM4.Text = "Q") Then
            NUM4.Text = 12
        ElseIf (NUM4.Text = "K") Then
            NUM4.Text = 13
        End If
        Dim a, b, c, d As Integer
        a = NUM1.Text
        b = NUM2.Text
        c = NUM3.Text
        d = NUM4.Text
        If (NUM1.Text = 1) Then
            NUM1.Text = "A"
        ElseIf (NUM1.Text = 11) Then
            NUM1.Text = "J"
        ElseIf (NUM1.Text = 12) Then
            NUM1.Text = "Q"
        ElseIf (NUM1.Text = 13) Then
            NUM1.Text = "K"
        End If
        If (NUM2.Text = 1) Then
            NUM2.Text = "A"
        ElseIf (NUM2.Text = 11) Then
            NUM2.Text = "J"
        ElseIf (NUM2.Text = 12) Then
            NUM2.Text = "Q"
        ElseIf (NUM2.Text = 13) Then
            NUM2.Text = "K"
        End If
        If (NUM3.Text = 1) Then
            NUM3.Text = "A"
        ElseIf (NUM3.Text = 11) Then
            NUM3.Text = "J"
        ElseIf (NUM3.Text = 12) Then
            NUM3.Text = "Q"
        ElseIf (NUM3.Text = 13) Then
            NUM3.Text = "K"
        End If
        If (NUM4.Text = 1) Then
            NUM4.Text = "A"
        ElseIf (NUM4.Text = 11) Then
            NUM4.Text = "J"
        ElseIf (NUM4.Text = 12) Then
            NUM4.Text = "Q"
        ElseIf (NUM4.Text = 13) Then
            NUM4.Text = "K"
        End If
        AnswerN = 0
        Count1(a, b, c, d)
        Label1.Text = Ans.Items.Count.ToString
        If (AnswerN = 0) Then
            Ans.Items.Add("No answer")
            Label1.Text = 0
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Ans.Items.Clear()
        Label1.Text = 0
    End Sub

End Class
