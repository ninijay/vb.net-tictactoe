



Public Class frmTicTacToe

#Region " Global declarations"



    Inherits System.Windows.Forms.Form

    Dim PlayerTurn As Integer

    Dim ClickedSquare(3, 3) As Boolean

    Dim ClickedX(3, 3) As Boolean
    Dim ClickedO(3, 3) As Boolean
    Dim sqr(3, 3) As PictureBox


#End Region


#Region ".Click Events"



    Private Sub sqr1_1_Click(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If ClickedSquare(1, 1) = False Then

            If PlayerTurn Mod 2 = 0 Then
                sqr1_1.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(1, 1) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr1_1.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1

                ClickedO(1, 1) = True
            End If

            ClickedSquare(1, 1) = True

        End If


        CheckForWinnerO()
        CheckForWinnerX()
        If ClickedSquare(3, 1) = False Then

            If PlayerTurn Mod 2 = 0 Then
                sqr2_1.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(2, 1) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr2_1.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1
                ClickedO(2, 1) = True
            End If

            ClickedSquare(2, 1) = True


        End If





        CheckForWinnerO()
        CheckForWinnerX()



  
        If ClickedSquare(3, 1) = False Then

            If PlayerTurn Mod 2 = 0 Then
                sqr3_1.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(3, 1) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr3_1.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1
                ClickedO(3, 1) = True
            End If
            ClickedSquare(3, 1) = True

        End If

      

        CheckForWinnerO()
        CheckForWinnerX()


        If ClickedSquare(1, 2) = False Then
            If PlayerTurn Mod 2 = 0 Then
                sqr1_2.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(1, 2) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr1_2.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1
                ClickedO(1, 2) = True
            End If

            ClickedSquare(1, 2) = True

        End If

      


        CheckForWinnerO()
        CheckForWinnerX()



 
        If ClickedSquare(2, 2) = False Then
            If PlayerTurn Mod 2 = 0 Then
                sqr2_2.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(2, 2) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr2_2.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1
                ClickedO(2, 2) = True
            End If

            ClickedSquare(2, 2) = True

        End If

        
        CheckForWinnerO()
        CheckForWinnerX()


        If ClickedSquare(3, 2) = False Then

            If PlayerTurn Mod 2 = 0 Then
                sqr3_2.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(3, 2) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr3_2.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1
                ClickedO(3, 2) = True

            End If
            ClickedSquare(3, 2) = True


        End If

   

        CheckForWinnerO()
        CheckForWinnerX()


        If ClickedSquare(1, 3) = False Then


            If PlayerTurn Mod 2 = 0 Then
                sqr1_3.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(1, 3) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr1_3.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1
                ClickedO(1, 3) = True
            End If
            ClickedSquare(1, 3) = True

        End If




        CheckForWinnerO()
        CheckForWinnerX()




        If ClickedSquare(2, 3) = False Then

            If PlayerTurn Mod 2 = 0 Then
                sqr2_3.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(2, 3) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr2_3.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1
                ClickedO(2, 3) = True
            End If
            ClickedSquare(2, 3) = True

        End If



        CheckForWinnerO()
        CheckForWinnerX()



        If ClickedSquare(3, 3) = False Then

            If PlayerTurn Mod 2 = 0 Then
                sqr3_3.Image = Image.FromFile("x.jpg")
                PlayerTurn += 1
                ClickedX(3, 3) = True
            ElseIf PlayerTurn Mod 2 = 1 Then
                sqr3_3.Image = Image.FromFile("o.jpg")
                PlayerTurn += 1

                ClickedO(3, 3) = True
            End If
            ClickedSquare(3, 3) = True

        End If

       


        CheckForWinnerX()
        CheckForWinnerO()


    End Sub

#End Region


#Region "User Created Subs"


    Private Sub Sound()


        My.Computer.Audio.Play("C:\Windows\Media\tada.wav")


    End Sub





    Private Sub CheckForWinnerX()

        If ClickedX(1, 1) And ClickedX(1, 2) And ClickedX(1, 3) Then
            Sound()
            MessageBox.Show("Player X won!")
        ElseIf ClickedX(2, 1) And ClickedX(2, 2) And ClickedX(2, 3) Then
            Sound()
            MessageBox.Show("Player X won!")

        ElseIf ClickedX(3, 1) And ClickedX(3, 2) And ClickedX(3, 3) Then
            Sound()
            MessageBox.Show("Player X won!")

        End If


        If ClickedX(1, 1) And ClickedX(2, 1) And ClickedX(3, 1) Then
            Sound()
            MessageBox.Show("Player X won!")

        ElseIf ClickedX(1, 2) And ClickedX(2, 2) And ClickedX(3, 2) Then
            Sound()
            MessageBox.Show("Player X won!")

        ElseIf ClickedX(1, 3) And ClickedX(2, 3) And ClickedX(3, 3) Then
            Sound()

            MessageBox.Show("Player X won!")

        End If


        If ClickedX(1, 3) And ClickedX(2, 2) And ClickedX(3, 1) Then
            Sound()

            MessageBox.Show("Player X won!")

        ElseIf ClickedX(1, 1) And ClickedX(2, 2) And ClickedX(3, 3) Then
            Sound()

            MessageBox.Show("Player X won!")

        End If


    End Sub


    Private Sub CheckForWinnerO()




        If ClickedO(1, 1) And ClickedO(1, 2) And ClickedO(1, 3) Then
            Sound()

            MessageBox.Show("Player O won!")


        ElseIf ClickedO(2, 1) And ClickedO(2, 2) And ClickedO(2, 3) Then
            Sound()

            MessageBox.Show("Player O won!")
        ElseIf ClickedO(3, 1) And ClickedO(3, 2) And ClickedO(3, 3) Then
            Sound()
            MessageBox.Show("Player O won!")

        End If




        If ClickedO(1, 1) And ClickedO(2, 1) And ClickedO(3, 1) Then
            Sound()

            MessageBox.Show("Player O won!")


        ElseIf ClickedO(1, 2) And ClickedO(2, 2) And ClickedO(3, 2) Then
            Sound()

            MessageBox.Show("Player O won!")


        ElseIf ClickedO(1, 3) And ClickedO(2, 3) And ClickedO(3, 3) Then
            Sound()

            MessageBox.Show("Player O won!")


        End If



        If ClickedO(1, 3) And ClickedO(2, 2) And ClickedO(3, 1) Then
            Sound()

            MessageBox.Show("Player O won!")


        ElseIf ClickedO(1, 1) And ClickedO(2, 2) And ClickedO(3, 3) Then
            Sound()

            MessageBox.Show("Player O won!")


        End If







    End Sub


#End Region



End Class
