Module Module1

    Dim pNumber As String
    Dim pCOde As String
    Dim firstdName As String
    Dim secondDname
    Dim mNumber As Integer
    Dim rtotal As Single
    Dim fItem As String
    Dim deci As String
    Dim dob As String
    Dim lop As String
    Dim taxedtotal As Single
    Dim discountedTotal As Single
    Dim finaltotal As Single
    Dim lofname As Integer
    Dim password As String
    Dim correctPassword As String
    Dim counter1 As Integer




    Sub security()
        counter1 = 0
        correctPassword = ("JCC")
        Console.WriteLine("Please enter master password")
        password = Console.ReadLine()

        If password <> correctPassword Then
            Do
                counter1 = counter1 + 1
                Console.WriteLine("Incorrect password,you have " & 3 - counter1 & " Reamining attemps.")
                password = Console.ReadLine()

            Loop Until counter1 = 3 Or password = correctPassword

            If password = correctPassword Then
                Console.WriteLine("Correct password entered.Welcome")

            Else
                Console.WriteLine("You have entered a incorrect password too many times.Program will now terminate")
                Console.ReadLine()
                End


            End If





        End If




    End Sub

    Sub studentDiscount(ByRef taxedtotal)
        Console.WriteLine("Please enter your ID Number,press <enter> if you do not have one")
        Dim id_number As String = Console.ReadLine()

        If LCase(Mid(id_number, 1, 1)) = "d" Then
            Console.WriteLine("Student number found.You are eligible for the 10% off student discount")
            taxedtotal = FormatNumber(taxedtotal * 0.9, 2)

        ElseIf id_number = "" Then



        Else
            Console.WriteLine("Unfortuately you are not eligible for the student discount")
            taxedtotal = taxedtotal







        End If



    End Sub




    Sub Main()

        security()


        Do
            rtotal = 0

            Do
                Console.WriteLine("Welcome to M's Coffee.Could you please provide your phone number?")
                pNumber = Console.ReadLine()
            Loop Until pNumber <> "" ' presence check

            Do
                Console.WriteLine("And please could you also input your postcode ?")
                pCOde = Console.ReadLine()

            Loop Until pCOde <> ""




            Console.WriteLine("What is the first name for the delivery?")
            firstdName = Console.ReadLine()



            Do
                lofname = Len(firstdName)

                If lofname > 10 Or firstdName = "" Then
                    Console.WriteLine("Invalid Input,Please reinput name")

                    firstdName = Console.ReadLine()

                End If


            Loop Until firstdName <> "" And lofname < 10

            Do

                Console.WriteLine("What is the second name for the delivery?")
                secondDname = Console.ReadLine()

            Loop Until secondDname <> ""


            Do
                Console.WriteLine("Please input DOB in format DDMM")
                dob = Console.ReadLine()
            Loop Until dob <> ""






            Console.WriteLine("Please enter which menu you would like to view 1)Hot drinks 2)Cold drinks 3)Pastries")

            mNumber = Console.ReadLine()

            If mNumber = 1 Then
                Console.WriteLine("Hot Chocolate - 2.99
Americano - 3.99
Latte - 1.99
Black coffee - 0.99")

            ElseIf mNumber = 2 Then
                Console.WriteLine("Iced coffee - 1.99
Iced Moccha - 3.99
Iced Latte - 4.99")

            ElseIf mNumber = 3 Then
                Console.WriteLine("Pan au chocolate - 0.99
Crossaint - 1.99
Cinnamon Bun - 3.50")


            End If

            While rtotal = 0



                Console.WriteLine("What would you like to add to your order")

                fItem = LCase(Console.ReadLine)

                If fItem = "americano" Then
                    rtotal = rtotal + 3.99



                ElseIf fItem = "latte" Then
                    rtotal = rtotal + 1.99



                ElseIf fItem = "black coffee" Then
                    rtotal = rtotal + 0.99



                ElseIf fItem = "iced moccha" Then
                    rtotal = rtotal + 3.99



                ElseIf fItem = "iced coffee" Then
                    rtotal = rtotal + 1.99



                ElseIf fItem = "iced latte" Then
                    rtotal = rtotal + 4.99



                ElseIf fItem = "crossaint" Then
                    rtotal = rtotal + 1.99



                ElseIf fItem = "cinnamon bun" Then
                    rtotal = rtotal + 3.5



                ElseIf fItem = "pan au chocolate" Then
                    rtotal = rtotal + 0.99

                ElseIf fItem = "hot Chocolate" Then
                    rtotal = rtotal + 2.99



                End If

                If rtotal = 0 Then
                    Console.WriteLine("Invalid input,we will resrtart the item selection process")
                End If

            End While

            Dim choc As String

            Console.WriteLine("Would you like to add chocolate topping for an extra 45p")
            choc = Console.ReadLine()

            If choc = "yes" Then
                rtotal = rtotal + 0.45
            End If







            Console.WriteLine("Thank you, your order total is " & rtotal & " would you like to see the menu and order again?")
            deci = LCase(Console.ReadLine())


            If deci = "yes" Then

                Console.WriteLine("Please enter which menu you would like to view 1)Hot drinks 2)Cold drinks 3)Pastries")

                mNumber = Console.ReadLine()

                If mNumber = 1 Then
                    Console.WriteLine("Hot Chocolate - 2.99
Americano - 3.99
Latte - 1.99
Black coffee - 0.99")

                ElseIf mNumber = 2 Then
                    Console.WriteLine("Iced coffee - 1.99
Iced Moccha - 3.99
Iced Latte - 4.99")

                ElseIf mNumber = 3 Then
                    Console.WriteLine("Pan au chocolate - 0.99
Crossaint - 1.99
Cinnamon Bun - 3.50")


                End If

                Console.WriteLine("What would you like to add to your order")

                fItem = LCase(Console.ReadLine())

                If fItem = "americano" Then
                    rtotal = rtotal + 3.99



                End If

                If fItem = "latte" Then
                    rtotal = rtotal + 1.99

                End If

                If fItem = "black coffee" Then
                    rtotal = rtotal + 0.99

                End If

                If fItem = "iced moccha" Then
                    rtotal = rtotal + 3.99

                End If

                If fItem = "iced coffee" Then
                    rtotal = rtotal + 1.99

                End If

                If fItem = "iced latte" Then
                    rtotal = rtotal + 4.99

                End If

                If fItem = "crossaint" Then
                    rtotal = rtotal + 1.99

                End If

                If fItem = "cinnamon bun" Then
                    rtotal = rtotal + 3.5

                End If

                If fItem = "pan au chocolate" Then
                    rtotal = rtotal + 0.99
                End If


            Else
                Console.WriteLine("Thank you for your order")





            End If

            Dim cash As Single
            Dim change As Single
            Dim pMeth As String
            Dim tipD As String
            Dim ntotal As Single


            Const TAX As Single = 1.2

            taxedtotal = rtotal * 1.2


            Dim identifier As String
            identifier = "MR " & Mid(firstdName, 1, 1) & secondDname

            Dim reference As String

            'account ref concat

            reference = UCase(Mid(firstdName, 1, 1)) & UCase(secondDname) & dob






            Console.WriteLine("Name: " & UCase(identifier))
            Console.WriteLine("Phone number: " & pNumber)
            Console.WriteLine("Post code : " & pCOde)
            Console.WriteLine("Your order total is " & FormatNumber(taxedtotal), 2)
            Console.WriteLine("Your account refrence number is " & reference)

            Dim tipdec As String




            If rtotal < 10 Then

                Console.WriteLine("Would you like to add a 5% tip today?(Y/N)")
                tipdec = LCase(Console.ReadLine())
            End If





            If tipdec = "yes" Then

                ' add 5% to the total to make for tip
                taxedtotal = rtotal * 1.05
                Console.WriteLine("Your new total is " & FormatCurrency(FormatNumber(taxedtotal), 2), 2)



            End If

            Dim Sdiscount As String



            studentDiscount(taxedtotal)









            Console.WriteLine("Your final total is " & taxedtotal)
            Console.WriteLine("Please press <ENTER> to input your card")
            Console.ReadLine()

            Console.WriteLine("Transaction Approved")

            Console.WriteLine("Have a nice day,dont forget to give us a review on google.")

            Console.WriteLine("Would you like the program to loop?")

            lop = Console.ReadLine()



            lop = UCase(lop)


        Loop Until lop = "NO"













        Console.WriteLine("Press <ENTER> to terminate program")
        Console.ReadLine()






















    End Sub

End Module
