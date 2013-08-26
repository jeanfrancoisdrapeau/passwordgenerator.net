Public Class frmMain

    Private Structure strAutresCars

        Dim sAc As Char

    End Structure

    Private Structure strCars

        Dim sC As Char
        Dim a_sAc() As strAutresCars

    End Structure

    Private array_Cars() As strCars

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReDim array_Cars(35)
        Dim i As Integer

        i = 0
        array_Cars(i).sC = "1"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "2"
        array_Cars(i).a_sAc(1).sAc = "q"

        i += 1
        array_Cars(i).sC = "2"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "q"
        array_Cars(i).a_sAc(1).sAc = "w"

        i += 1
        array_Cars(i).sC = "3"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "w"
        array_Cars(i).a_sAc(1).sAc = "e"

        i += 1
        array_Cars(i).sC = "4"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "e"
        array_Cars(i).a_sAc(1).sAc = "r"

        i += 1
        array_Cars(i).sC = "5"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "r"
        array_Cars(i).a_sAc(1).sAc = "t"

        i += 1
        array_Cars(i).sC = "6"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "t"
        array_Cars(i).a_sAc(1).sAc = "y"

        i += 1
        array_Cars(i).sC = "7"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "y"
        array_Cars(i).a_sAc(1).sAc = "u"

        i += 1
        array_Cars(i).sC = "8"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "u"
        array_Cars(i).a_sAc(1).sAc = "i"

        i += 1
        array_Cars(i).sC = "9"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "i"
        array_Cars(i).a_sAc(1).sAc = "o"

        i += 1
        array_Cars(i).sC = "0"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "o"
        array_Cars(i).a_sAc(1).sAc = "p"

        '----------------------------------------------------------
        i += 1
        array_Cars(i).sC = "q"
        ReDim array_Cars(i).a_sAc(2)
        array_Cars(i).a_sAc(0).sAc = "1"
        array_Cars(i).a_sAc(1).sAc = "2"
        array_Cars(i).a_sAc(2).sAc = "a"

        i += 1
        array_Cars(i).sC = "w"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "2"
        array_Cars(i).a_sAc(1).sAc = "3"
        array_Cars(i).a_sAc(2).sAc = "a"
        array_Cars(i).a_sAc(3).sAc = "s"

        i += 1
        array_Cars(i).sC = "e"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "3"
        array_Cars(i).a_sAc(1).sAc = "4"
        array_Cars(i).a_sAc(2).sAc = "s"
        array_Cars(i).a_sAc(3).sAc = "d"

        i += 1
        array_Cars(i).sC = "r"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "4"
        array_Cars(i).a_sAc(1).sAc = "5"
        array_Cars(i).a_sAc(2).sAc = "d"
        array_Cars(i).a_sAc(3).sAc = "f"

        i += 1
        array_Cars(i).sC = "t"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "5"
        array_Cars(i).a_sAc(1).sAc = "6"
        array_Cars(i).a_sAc(2).sAc = "f"
        array_Cars(i).a_sAc(3).sAc = "g"

        i += 1
        array_Cars(i).sC = "y"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "6"
        array_Cars(i).a_sAc(1).sAc = "7"
        array_Cars(i).a_sAc(2).sAc = "g"
        array_Cars(i).a_sAc(3).sAc = "h"

        i += 1
        array_Cars(i).sC = "u"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "7"
        array_Cars(i).a_sAc(1).sAc = "8"
        array_Cars(i).a_sAc(2).sAc = "h"
        array_Cars(i).a_sAc(3).sAc = "j"

        i += 1
        array_Cars(i).sC = "i"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "8"
        array_Cars(i).a_sAc(1).sAc = "9"
        array_Cars(i).a_sAc(2).sAc = "j"
        array_Cars(i).a_sAc(3).sAc = "k"

        i += 1
        array_Cars(i).sC = "o"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "9"
        array_Cars(i).a_sAc(1).sAc = "0"
        array_Cars(i).a_sAc(2).sAc = "k"
        array_Cars(i).a_sAc(3).sAc = "l"

        i += 1
        array_Cars(i).sC = "p"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "0"
        array_Cars(i).a_sAc(1).sAc = "l"

        '----------------------------------------------------------
        i += 1
        array_Cars(i).sC = "a"
        ReDim array_Cars(i).a_sAc(2)
        array_Cars(i).a_sAc(0).sAc = "q"
        array_Cars(i).a_sAc(1).sAc = "w"
        array_Cars(i).a_sAc(2).sAc = "z"

        i += 1
        array_Cars(i).sC = "s"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "w"
        array_Cars(i).a_sAc(1).sAc = "e"
        array_Cars(i).a_sAc(2).sAc = "z"
        array_Cars(i).a_sAc(3).sAc = "x"

        i += 1
        array_Cars(i).sC = "d"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "e"
        array_Cars(i).a_sAc(1).sAc = "r"
        array_Cars(i).a_sAc(2).sAc = "x"
        array_Cars(i).a_sAc(3).sAc = "c"

        i += 1
        array_Cars(i).sC = "f"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "r"
        array_Cars(i).a_sAc(1).sAc = "t"
        array_Cars(i).a_sAc(2).sAc = "c"
        array_Cars(i).a_sAc(3).sAc = "v"

        i += 1
        array_Cars(i).sC = "g"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "t"
        array_Cars(i).a_sAc(1).sAc = "y"
        array_Cars(i).a_sAc(2).sAc = "v"
        array_Cars(i).a_sAc(3).sAc = "b"

        i += 1
        array_Cars(i).sC = "h"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "y"
        array_Cars(i).a_sAc(1).sAc = "u"
        array_Cars(i).a_sAc(2).sAc = "b"
        array_Cars(i).a_sAc(3).sAc = "n"

        i += 1
        array_Cars(i).sC = "j"
        ReDim array_Cars(i).a_sAc(3)
        array_Cars(i).a_sAc(0).sAc = "u"
        array_Cars(i).a_sAc(1).sAc = "i"
        array_Cars(i).a_sAc(2).sAc = "n"
        array_Cars(i).a_sAc(3).sAc = "m"

        i += 1
        array_Cars(i).sC = "k"
        ReDim array_Cars(i).a_sAc(2)
        array_Cars(i).a_sAc(0).sAc = "i"
        array_Cars(i).a_sAc(1).sAc = "o"
        array_Cars(i).a_sAc(2).sAc = "m"

        i += 1
        array_Cars(i).sC = "l"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "o"
        array_Cars(i).a_sAc(1).sAc = "p"

        '----------------------------------------------------------
        i += 1
        array_Cars(i).sC = "z"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "a"
        array_Cars(i).a_sAc(1).sAc = "s"

        i += 1
        array_Cars(i).sC = "x"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "s"
        array_Cars(i).a_sAc(1).sAc = "d"

        i += 1
        array_Cars(i).sC = "c"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "d"
        array_Cars(i).a_sAc(1).sAc = "f"

        i += 1
        array_Cars(i).sC = "v"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "f"
        array_Cars(i).a_sAc(1).sAc = "g"

        i += 1
        array_Cars(i).sC = "b"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "g"
        array_Cars(i).a_sAc(1).sAc = "h"

        i += 1
        array_Cars(i).sC = "n"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "h"
        array_Cars(i).a_sAc(1).sAc = "j"

        i += 1
        array_Cars(i).sC = "m"
        ReDim array_Cars(i).a_sAc(1)
        array_Cars(i).a_sAc(0).sAc = "j"
        array_Cars(i).a_sAc(1).sAc = "k"

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        If cmbNombreCars.Text.Length = 0 Then Exit Sub

        Dim i As Integer, j As Integer, cCur As Char, sPass As String, rand As Integer

        sPass = ""
        txtPassword.Text = ""

        Dim r As New Random(System.DateTime.Now.Millisecond)

        rand = r.Next(10, array_Cars.Length)
        cCur = array_Cars(rand).sC

        sPass = sPass & cCur.ToString.ToUpper()

        For i = 1 To Val(cmbNombreCars.Text) - 1

            Dim iPos As Integer = ReturnPos(cCur)

            j = 1
            Do

                rand = r.Next(0, array_Cars(iPos).a_sAc.Length)
                cCur = array_Cars(iPos).a_sAc(rand).sAc
                j += 1

                If InStr(sPass, cCur) = 0 Or j = 500 Then Exit Do

            Loop

            sPass = sPass & cCur

        Next

        txtPassword.Text = sPass

        Clipboard.SetText(sPass)

    End Sub

    Private Function ReturnPos(ByVal c As Char) As Integer

        Dim i As Integer
        For i = 0 To array_Cars.Length - 1

            If c = array_Cars(i).sC Then

                ReturnPos = i
                Exit Function

            End If

        Next

    End Function

End Class
