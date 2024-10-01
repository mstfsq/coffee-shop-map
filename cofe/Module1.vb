Module Module1

    Dim pNumber As String
    Dim pCOde As String
    Dim firstdName As String
    Dim secondDname
    Dim mNumber As string
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
    Dim invalid_mNumber as Boolean
    Dim invalid_mNumber2 As Boolean
    Dim orderline(6) As String
    Dim index As Integer
    ' Orderline 1 is phone number
    ' orderline 2 is postcode
    ' orderline 3 is first name
    ' orderline 4 is second name
    ' orderline 5 is dob
    ' orderline 6 is taxedtotal





'' password check at the start of the program
    Sub security()
        counter1 = 0
        correctPassword = ("JCC")
        console.WriteLine("Please enter master password")
        password = console.ReadLine()

        If password <> correctPassword Then
            Do
                counter1 = counter1 + 1
                console.WriteLine("Incorrect password,you have " & 3 - counter1 & " Reamining attemps.")
                password = console.ReadLine()

            Loop Until counter1 = 3 Or password = correctPassword

            If password = correctPassword Then
                console.WriteLine("Correct password entered.Welcome")

            Else
                console.WriteLine("You have entered a incorrect password too many times.Program will now terminate")
                console.ReadLine()
                End


            End If





        End If




    End Sub
'' if user does not tip this tells them how much they would of paid with the tip and it used ByVal

    Sub pTip(ByVal taxedtotal)
        Dim tip_amount As Single = taxedtotal * 1.05
        console.WriteLine("If you would of gave a tip your total would of been " & FormatNumber(tip_amount, 2))


    End Sub

    
    ' if users id number starts with 'd' it will apply student discount
    Sub studentDiscount(ByRef taxedtotal)
        console.WriteLine("Please enter your ID Number,press <enter> if you do not have one")
        Dim id_number As String = console.ReadLine()

        If LCase(Mid(id_number, 1, 1)) = "d" Then
            console.WriteLine("Student number found.You are eligible for the 10% off student discount")
            taxedtotal = FormatNumber(taxedtotal * 0.9, 2)

        ElseIf id_number = "" Then
        



        Else
            console.WriteLine("Unfortuately you are not eligible for the student discount")
            taxedtotal = taxedtotal







        End If



    End Sub



' main program
    Sub Main()

        security()


        Do
            rtotal = 0
            
            console.WriteLine("Welcome to M's Coffee.Could you please provide your phone number?")

            Do
                
                pNumber = console.ReadLine()
                
                if pnumber = "" or Len(pnumber) > 12 Then
                    Console.WriteLine("invalid input,please make sure phone number is no more than 11 digits")
                    
                End If
                '' loops untill the input is real and less than/equal to 11 digits
            Loop Until pNumber <> "" and Len(pNumber) <= 11

            orderline(1) = pNumber

            Do
                console.WriteLine("And please could you also input your postcode ?")
                pCOde = console.ReadLine()
' loops untill there is real input for postcode
                
            Loop Until pCOde <> ""

            orderline(2) = pCOde




            Console.WriteLine("What is the first name for the delivery?")
            firstdName = console.ReadLine()


'' loops untill legnth of first name is less than 10 and has real input
            Do
                lofname = Len(firstdName)

                If lofname > 10 Or firstdName = "" Then
                    console.WriteLine("Invalid Input,Please reinput name")

                    firstdName = console.ReadLine()

                End If


            Loop Until firstdName <> "" And lofname < 10

            orderline(3) = firstdName
            
            console.WriteLine("What is the second name for the delivery?")
' loops unill second name has real input
            Do
                secondDname = console.ReadLine()
                if secondDname = "" Then
                    Console.writeline("Invalid input,please try again")
                End If

            Loop Until secondDname <> "" 

            orderline(4) = secondDname
            
            console.WriteLine("Please input DOB in format DDMM")

' loops untill len(dob) = 4 and input is real
            Do
                
                dob = console.ReadLine()
                if dob = "" or Len(dob) <> 4 Then
                    Console.WriteLine("Invlaid DOB input,please make sure the format is DDMM")
                End If
            Loop Until dob <> "" and Len(dob) = 4

            orderline(5) = dob

            Console.WriteLine("Please enter which menu you would like to view 1)Hot drinks 2)Cold drinks 3)Pastries")

'' makes sure the inputed number is appropiate if not it will loop
            Do

                invalid_mNumber = False


                mNumber = console.ReadLine()

                If mNumber = "1" Then
                    console.WriteLine("Hot Chocolate - 2.99
Americano - 3.99
Latte - 1.99
Black coffee - 0.99")

                ElseIf mNumber = "2" Then
                    console.WriteLine("Iced coffee - 1.99
Iced Moccha - 3.99
Iced Latte - 4.99")

                ElseIf mNumber = "3" Then
                    console.WriteLine("Pan au chocolate - 0.99
Crossaint - 1.99
Cinnamon Bun - 3.50")

                Else
                    invalid_mNumber = True
                    Console.WriteLine("Invalid Input,Try again")




                End If

            Loop While invalid_mNumber = True




            While rtotal = 0



                console.WriteLine("What would you like to add to your order")

                fItem = LCase(console.ReadLine)

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
                    console.WriteLine("Invalid input,we will resrtart the item selection process")
                End If

            End While

            Dim choc As String

            console.WriteLine("Would you like to add chocolate topping for an extra 45p")
            choc = console.ReadLine()

            If choc = "yes" Then
                rtotal = rtotal + 0.45
            End If







            console.WriteLine("Thank you, your order total is " & rtotal & " would you like to see the menu and order again?")
            deci = LCase(console.ReadLine())


            If deci = "yes" Then

                Do
                    invalid_mNumber2 = False
                    console.WriteLine("Please enter which menu you would like to view 1)Hot drinks 2)Cold drinks 3)Pastries")

                    mNumber = console.ReadLine()

                    If mNumber = 1 Then
                        console.WriteLine("Hot Chocolate - 2.99
Americano - 3.99
Latte - 1.99
Black coffee - 0.99")

                    ElseIf mNumber = 2 Then
                        console.WriteLine("Iced coffee - 1.99
Iced Moccha - 3.99
Iced Latte - 4.99")

                    ElseIf mNumber = 3 Then
                        console.WriteLine("Pan au chocolate - 0.99
Crossaint - 1.99
Cinnamon Bun - 3.50")

                    Else
                        invalid_mNumber2 = True
                        console.WriteLine("Invalid input try again")



                    End If

                Loop While invalid_mNumber2 = True



                console.WriteLine("What would you like to add to your order")

                fItem = LCase(console.ReadLine())

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
                console.WriteLine("Thank you for your order")





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





'' prints out a reciept
            console.WriteLine("Name: " & UCase(identifier))
            console.WriteLine("Phone number: " & pNumber)
            console.WriteLine("Post code : " & pCOde)
            console.WriteLine("Your order total is " & FormatNumber(taxedtotal), 2)
            console.WriteLine("Your account refrence number is " & reference)

            Dim tipdec As String


'' if the total is less than 10 it will ask for a 5% tip

            If rtotal < 10 Then

                console.WriteLine("Would you like to add a 5% tip today?(Y/N)")
                tipdec = LCase(console.ReadLine())
            End If





            If tipdec = "yes" Then

                ' add 5% to the total to make for tip
                taxedtotal = rtotal * 1.05
                console.WriteLine("Your new total is " & FormatNumber(taxedtotal), 2)
'' refers to "you would of payed xyz" submodule 
            Else
                pTip(taxedtotal)

            End If

            Dim Sdiscount As String


' student submodule
            studentDiscount(taxedtotal)









            Console.WriteLine("Your final total is " & FormatNumber(taxedtotal), 2)
            Console.WriteLine("Please press <ENTER> to input your card")
            console.ReadLine()

            console.WriteLine("Transaction Approved")

            console.WriteLine("Have a nice day,dont forget to give us a review on google.")

            console.WriteLine("Would you like the program to loop?")

            lop = Console.ReadLine()

            orderline(6) = taxedtotal



            lop = UCase(lop)


        Loop Until lop = "NO"
        index = 1

        For index = 1 To 6
            Console.WriteLine(orderline(index))
        Next
        ' Orderline 1 is phone number
        ' orderline 2 is postcode
        ' orderline 3 is first name
        ' orderline 4 is second name
        ' orderline 5 is dob
        ' orderline 6 is taxedtotal
        

        Console.WriteLine("Press <ENTER> to terminate program")
        console.ReadLine()
        

    End Sub

End Module