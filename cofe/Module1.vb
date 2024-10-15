Imports System.IO


Module Module1
    Dim pNumber As String
    Dim pCOde As String
    Dim firstdName As String
    Dim secondDname
    Dim mNumber As String
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
    Dim invalid_mNumber As Boolean
    Dim invalid_mNumber2 As Boolean
    Dim orderline(4, 5) As String
    Dim index, ArrayCounter As Integer
    Dim array_3d As Integer = 0
    Dim orderline_info As String
    Dim shopping_data() As String = File.ReadAllLines("orders.txt")
    Dim pFunction As String
    Dim iInput As Boolean



    '' cash payment system


    Sub p_cash()
        Dim cash_input As Single
        Dim change_due As Single
        Dim moneyOwed As Single
        Dim money_given As Single



        ' displays how much the customer needs to owe
        taxedtotal = Math.Round(taxedtotal, 2)
        Console.WriteLine("Yout total is £" & taxedtotal & "How much would you like to pay in cash")
        cash_input = Console.ReadLine()

        ' works out the change

        change_due = cash_input - taxedtotal

        ' if change is positive(they gave more than req) then output the change
        If change_due > 0 Then

            Console.WriteLine("your change is £" & FormatNumber(change_due), 2)

        End If

        ' if change is less then 0(they didnt give enough)
        If change_due < 0 Then
            Console.WriteLine("uhoh,you did not give enough cash")
            ' makes the change into the debt they owe and assign it to moneyOwed
            moneyOwed = Math.Round(change_due * -1, 2)
            Console.WriteLine("You owe £" & FormatNumber(moneyOwed), 2)
            ' tells them to give more money and assigns the money given to money_given
            Console.WriteLine("how much more would you like to pay")
            money_given = Console.ReadLine()

            ' if the money given is less than the money they owe

            If money_given < moneyOwed Then
                ' it calculates the rest they owe
                moneyOwed = moneyOwed - money_given

                ' slaps it into a loop which loops untll the moneyOwed is 0 or less than zero
                '

                Do Until moneyOwed <= 0

                    Console.WriteLine("you still owe £" & FormatNumber(moneyOwed, 2) & " plese pay the due amount")
                    money_given = Console.ReadLine()
                    'following calculation takes away the money given to moneyowed becomes less each time
                    moneyOwed = moneyOwed - money_given
                Loop

                'if the money owed is more than 0 it means they have given more than needed so it prints out the change

                If moneyOwed < 0 Then
                    Console.WriteLine("Your change is £" & FormatNumber(moneyOwed, 2) * -1)
                End If
            End If
        End If
    End Sub
    '' password check at the start of the program
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
    '' if user does not tip this tells them how much they would of paid with the tip and it used ByVal

    Sub pTip(ByVal taxedtotal)
        Dim tip_amount As Single = taxedtotal * 1.05
        Console.WriteLine("If you would of gave a tip your total would of been £" & FormatNumber(tip_amount, 2))
    End Sub


    ' if users id number starts with 'd' it will apply student discount and it uses ByRef
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

    Sub order_read()
        shopping_data = File.ReadAllLines("orders.txt")
        For si = 0 To UBound(shopping_data)
            Console.WriteLine(shopping_data(si))

        Next
    End Sub



    ' MAIN PROGRAM BEGINS HERE
    Sub Main()
        security()

        Console.WriteLine("Welcome to the program,What would you like to do")
        Console.WriteLine("1)Make order")
        Console.WriteLine("2)View Past orders")
        Console.WriteLine("3) Terminate program")

        pFunction = Console.ReadLine




        Do

            If pFunction = "2" Then
                order_read()

                Console.WriteLine("press <ENTER> to terminate")
                Console.ReadLine()
                End

            ElseIf pFunction = "3" Then
                Console.WriteLine("press <ENTER> to terminate")
                Console.ReadLine()
                End

            ElseIf pFunction = "1" Then

            Else
                Console.WriteLine("invalid input")
                iInput = True
                Console.WriteLine("invalid input")

            End If

        Loop Until iInput = False




        If array_3d <> 0 Then
            Console.WriteLine("this is loop numner: " & array_3d)
        End If

        Do


            rtotal = 0

            Console.WriteLine("Welcome to M's Coffee.Could you please provide your phone number?")

            Do

                pNumber = Console.ReadLine()

                If pNumber = "" Or Len(pNumber) > 12 Then
                    Console.WriteLine("invalid input,please make sure phone number is no more than 11 digits")

                End If
                '' loops untill the input is real and less than/equal to 11 digits
            Loop Until pNumber <> "" And Len(pNumber) <= 11

            orderline(array_3d, 0) = pNumber

            Do
                Console.WriteLine("And please could you also input your postcode ?")
                pCOde = Console.ReadLine()
                ' loops untill there is real input for postcode

            Loop Until pCOde <> ""

            orderline(array_3d, 1) = pCOde
            'capitalises first letter
            Console.WriteLine("What is the first name for the delivery?")
            firstdName = LCase(Console.ReadLine())
            firstdName = UCase(Mid(firstdName, 1, 1)) & Mid(firstdName, 2)


            '' loops untill legnth of first name is less than 10 and has real input
            Do
                lofname = Len(firstdName)

                If lofname > 10 Or firstdName = "" Then
                    Console.WriteLine("Invalid Input,Please reinput name")



                    firstdName = Console.ReadLine()

                End If


            Loop Until firstdName <> "" And lofname < 10

            orderline(array_3d, 2) = firstdName

            Console.WriteLine("What is the second name for the delivery?")
            ' loops unill second name has real input
            Do
                'capitalises first letter
                secondDname = LCase(Console.ReadLine())
                secondDname = UCase(Mid(secondDname, 1, 1)) & Mid(secondDname, 2)
                If secondDname = "" Then
                    Console.WriteLine("Invalid input,please try again")
                End If

            Loop Until secondDname <> ""

            orderline(array_3d, 3) = secondDname

            Console.WriteLine("Please input DOB in format DDMM")

            ' loops untill len(dob) = 4 and input is real
            Do

                dob = Console.ReadLine()
                If dob = "" Or Len(dob) <> 4 Then
                    Console.WriteLine("Invlaid DOB input,please make sure the format is DDMM")
                End If
            Loop Until dob <> "" And Len(dob) = 4

            ' adds a / in between DOB
            dob = Mid(dob, 1, 2) & "/" & Mid(dob, 3, 2)

            orderline(array_3d, 4) = dob

            Console.WriteLine("Please enter which menu you would like to view 1)Hot drinks 2)Cold drinks 3)Pastries")

            '' makes sure the inputed number is appropiate if not it will loop
            Do

                invalid_mNumber = False


                mNumber = Console.ReadLine()

                If mNumber = "1" Then
                    Console.WriteLine("Hot Chocolate - 2.99
Americano - 3.99
Latte - 1.99
Black coffee - 0.99")

                ElseIf mNumber = "2" Then
                    Console.WriteLine("Iced coffee - 1.99
Iced Moccha - 3.99
Iced Latte - 4.99")

                ElseIf mNumber = "3" Then
                    Console.WriteLine("Pan au chocolate - 0.99
Crossaint - 1.99
Cinnamon Bun - 3.50")

                Else
                    ' if the input is invalid (not on the menu) it will let the boolean variable be true
                    invalid_mNumber = True
                    Console.WriteLine("Invalid Input,Try again")
                End If
                ' post conditioned loop - will loop aslong as input is invalid
            Loop While invalid_mNumber = True

            While rtotal = 0

                Console.WriteLine("What would you like to add to your order")
                fItem = LCase(Console.ReadLine)
                ' pricce list
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
                    ' validation check
                    Console.WriteLine("Invalid input,we will resrtart the item selection process")
                End If

            End While

            Dim choc As String


            ' asks user if they want extra
            Console.WriteLine("Would you like to add chocolate topping for an extra 45p")
            choc = Console.ReadLine()
            'extras
            If choc = "yes" Then
                rtotal = rtotal + 0.45
            End If

            Console.WriteLine("Thank you, your order total is " & rtotal & " would you like to see the menu and order again?")
            deci = LCase(Console.ReadLine())

            If deci = "yes" Then

                Do
                    invalid_mNumber2 = False
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

                    Else
                        invalid_mNumber2 = True
                        Console.WriteLine("Invalid input try again")
                    End If

                Loop While invalid_mNumber2 = True

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

            ' declares constant for  tax
            Const TAX As Single = 1.2
            ' applies the tax
            taxedtotal = rtotal * TAX

            ' creates a local variable for indentifer
            Dim identifier As String
            identifier = "MR " & Mid(firstdName, 1, 1) & secondDname
            'account ref concat using DOB and indetifier
            Dim reference As String
            reference = UCase(Mid(firstdName, 1, 1)) & UCase(secondDname) & dob
            '' prints out a reciept
            Console.WriteLine("Name: " & UCase(identifier))
            Console.WriteLine("Phone number: " & pNumber)
            Console.WriteLine("Post code : " & pCOde)
            Console.WriteLine("Your order total is " & FormatNumber(taxedtotal), 2)
            Console.WriteLine("Your account refrence number is " & reference)
            ' declares a variable to store users choice to tip
            Dim tipdec As String
            '' if the total is less than 10 it will ask for a 5% tip
            If rtotal < 10 Then
                Console.WriteLine("Would you like to add a 5% tip today?")
                tipdec = LCase(Console.ReadLine())
            End If
            ' if they want to tip it adds 5% to their total
            If tipdec = "yes" Then
                ' add 5% to the total to make for tip
                taxedtotal = taxedtotal * 1.05
                Console.WriteLine("Your new total is £" & FormatNumber(taxedtotal), 2)
                '' refers to "you would of payed xyz" submodule 
            Else
                pTip(taxedtotal)

            End If
            ' student submodule
            studentDiscount(taxedtotal)
            ' tells user final total and lets them choose the payment methof
            Console.WriteLine("Your final total is £" & FormatNumber(taxedtotal), 2)
            Console.WriteLine("would you like to pay cash or card")
            Dim p_decision As String = LCase(Console.ReadLine())
            If p_decision = "cash" Then

                'calls cash payment method
                p_cash()

                ' card payment confirmation(need to make a way to change the choice again)
            Else
                Console.WriteLine("Press <ENTER> to input your card")
                Console.ReadLine()
            End If
            Console.WriteLine("Transaction Approved")
            Console.WriteLine("Have a nice day,dont forget to give us a review on google.")
            Console.WriteLine("Would you like the program to loop?")

            ' stores decision to loop 
            lop = Console.ReadLine()
            'formats total to 2DP
            orderline(array_3d, 5) = FormatNumber(taxedtotal, 2)
            'ucases the input to avoid error
            lop = UCase(lop)
            ' if the user want to loop it adds 1 to the array counter and then goes back to the start of the program
            If lop = "YES" Then
                array_3d = array_3d + 1
            End If


            ' loops the whole progam untill they dont want to loop OR the array counter goes over 3
        Loop Until lop = "NO" Or array_3d = 5

        Dim sw As New StreamWriter("orders.txt", True)

        sw.WriteLine("-----------------------------------------------------------------------------------------------")

        For aCounter = 0 To array_3d ' loops the amount of orders made in given session
            Console.WriteLine()
            For bCounter = 0 To 5 ' loops orderlines
                If bCounter = 0 Then
                    orderline_info = "Phone:"
                ElseIf bCounter = 1 Then
                    orderline_info = "Postcode:"
                ElseIf bCounter = 2 Then
                    orderline_info = "First Name:"
                ElseIf bCounter = 3 Then
                    orderline_info = "Second Name"

                ElseIf bCounter = 4 Then
                    orderline_info = "Date Of Birth:"

                ElseIf bCounter = 5 Then
                    orderline_info = "Total: £"


                End If



                Console.WriteLine(orderline_info & "   " & orderline(aCounter, bCounter))
                sw.WriteLine(orderline_info & "   " & orderline(aCounter, bCounter))
            Next
        Next
        sw.Close() ' closes the streamwriter

        ' orderline 0 is phone number
        ' orderline 1 is postcode
        ' orderline 2 is first name
        ' orderline 3 is second name
        ' orderline 4 is dob
        ' orderline 5 is taxedtotal
        Console.WriteLine("Press <ENTER> to terminate program")
        Console.ReadLine()


    End Sub

End Module