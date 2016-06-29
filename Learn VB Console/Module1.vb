Imports System.Runtime
Imports System.Security.Cryptography

Module Module1
    ' This is a comment, comments are cool!
    Sub Main()
        ' Prints "Hello World" to the Console
        Console.WriteLine("Hello World")
        ' Pause in the program, waiting for input from the console
        Console.ReadLine()

        ' Time for Variables: Episode 8 - The New Boston
        Dim name As String = "The name of Names"
        Dim num As Integer = 3
        Dim num1 As Integer = 3
        Dim num2 As Integer = 3
        Dim add As Integer
        Dim subtract As Integer
        Dim divide As Integer
        Dim multiply As Integer
        Dim modulus As Integer
        Dim bool As Boolean = True

        Console.WriteLine("Variables")

        num = 2
        Console.WriteLine(num & " - This is a Integer")
        Console.WriteLine(name & " - This is a String")
        Console.WriteLine(bool & " - This is a Boolean")
        Console.ReadLine()
        Console.WriteLine()

        ' Basic Math Functions

        Console.WriteLine("Time to learn about Math Functions")
        Console.WriteLine()

        num1 = 12
        num2 = 24

        add = num1 + num2
        subtract = num2 - num1
        divide = num2 / num1
        multiply = num1 * num2
        modulus = (num2 + 1) Mod num1

        Console.WriteLine(add & " - Adding")
        Console.WriteLine(subtract & " - Subtracting")
        Console.WriteLine(divide & " - Dividing")
        Console.WriteLine(multiply & " - Multiplying")
        Console.WriteLine(modulus & " - Modulusing")

        Console.ReadLine()
        Console.WriteLine("Time to learn about user input")

        ' User Input Tutorial
        Dim userIn As String
        Console.WriteLine("Enter something:")
        userIn = Console.ReadLine()
        Console.WriteLine("You Entered: " & userIn)
        Console.ReadLine()

        ' Using If, IfElse & Else statements

        Console.WriteLine("What is your name?")
        Dim userName As String = Console.ReadLine()
        Console.WriteLine("What is your password?")
        Dim userPass As String = Console.ReadLine()
        Console.WriteLine()

        If (userName = "Liam") And (userPass = "john") Then
            Console.WriteLine("Welcome Liam")
            Console.WriteLine("Your password was correct")
        ElseIf (userName = "Liam") And (userPass <> "john") Then
            Console.WriteLine("Sorry, your passowrd was incorrect")

        Else
            Console.WriteLine("The username & password that you entered are incorrect")

        End If

        Console.ReadLine()

        '======================
        ' Nested if statements
        '======================

        Console.WriteLine("Nested If Statements")
        Dim age As Integer = 10
        Dim hasInsuranceTemp As String = Nothing
        Dim hasInsurance As Boolean = Nothing

        Console.WriteLine()
        Console.WriteLine("What is your age? - Insurance test")
        'age = Console.ReadLine()

InsuranceTest:
        Console.WriteLine()
        Console.WriteLine("Do you have insurance? true/false")
        hasInsuranceTemp = Console.ReadLine()

        Console.WriteLine()
        If age = 16 Then
            If hasInsurance = True Then
                Console.WriteLine("You can drive legally")
            Else
                Console.WriteLine("You can drive...")
                Threading.Thread.Sleep(500)
                Console.WriteLine("But don't get pulled over :D")
            End If
        Else
            Console.WriteLine("You cannot drive")
        End If

        Console.ReadLine()


        '=======================
        ' Conditional Operators
        '=======================


        Dim isInKiny As Boolean = Nothing
        Dim canDrink As Boolean = Nothing
        Dim isSerior As Boolean = Nothing
        Console.WriteLine("What is your age")
        Dim age3 As Integer = Nothing
        'age3 = Console.ReadLine()
        age3 = 7
        Dim outcomeKindy As String = Nothing
        Dim outcomeDrink As String = Nothing
        Dim outcomeSenior As String = Nothing

        If age3 <> 5 Then
            isInKiny = False
            outcomeKindy = "You are not in Kindy!"
        Else
            isInKiny = True
            outcomeKindy = "You are in Kindy :D"
        End If
        If age3 >= 65 Then
            isSerior = True
            outcomeSenior = "You are getting pretty old, watch the bucket ;)"
        Else
            isSerior = False
            outcomeSenior = "You are a wise, young apple - fresh from the tree"
        End If
        If age >= 18 Then
            canDrink = True
            outcomeDrink = "Time to get DRUNK"
        Else
            canDrink = False
            outcomeDrink = "You have nothing to look forward to when it comes to drinking"
        End If
        Console.WriteLine(outcomeSenior & " and as a bonus " & outcomeKindy & " which means that... " & outcomeDrink)
        Console.ReadLine()


        '===================
        ' Logical Operators
        '===================


        Dim usr As String = Nothing
        Dim usrPass As String = Nothing
        Dim loginAttemps As Integer = Nothing
        Console.WriteLine()
        Console.WriteLine("Logical Operators:")
login:
        If loginAttemps = 3 Then
            Console.WriteLine("Hey, you failed too many times - I'm not letting you in :D")
            GoTo loginFail
        End If
        Console.WriteLine("What is your username?")
        usr = Console.ReadLine()
        Console.WriteLine("What is your password?")
        usrPass = Console.ReadLine()

        If (usr = "Liam" And usrPass = "Ben") Or (usr = "Ben" And usrPass = "Liam") Then
            Console.WriteLine("Welcome " & usr)
            GoTo loginGood
        Else
            Console.WriteLine("Hey you, enter the correct username & password FOOL")
            loginAttemps = loginAttemps + 1
            GoTo loginFail
        End If
loginFail:
        Console.WriteLine("You must have just gotten lock out of the system - Bad Luck")
        GoTo loginEnd
loginGood:
        Console.WriteLine("Welcome to the system, thanks for logging in :D")
        Console.ReadLine()
        GoTo loginEnd
loginEnd:
        Console.ReadLine()


        '=====================
        ' Concatenate Strings
        '=====================

        Console.WriteLine("Let's Concatenate Some Strings")
        Dim usrString As String = Nothing
        Dim progString As String = " catfish"

        Console.WriteLine("What is your favourite kind of fish")
        usrString = Console.ReadLine()
        Console.WriteLine("You wrote " & usrString)

        ' Adding the 2 strings together
        usrString = usrString + ". I like" + progString + " personally."

        Console.WriteLine(usrString)

        Console.ReadLine()

        '===============================
        ' Getting the length of strings
        '===============================

        Dim strLen As Double = Nothing

        Console.WriteLine("Getting the length of strings")

        Console.WriteLine("What is your username?")
        userName = Console.ReadLine()

        If userName.Length = 10 Then
            Console.WriteLine("You have been granted access")
        Else
            strLen = userName.Length
            Console.WriteLine("Username length:")
            Console.WriteLine(strLen)
        End If
        Console.ReadLine()

        '===========================================
        ' Sub Strings - Extracting parts of strings
        '===========================================

        Console.WriteLine("SubStrings")
        Console.WriteLine()
        Console.ReadLine()

        Dim userString As String = Nothing
        Console.WriteLine("Please enter something")
        userString = Console.ReadLine()

        ' The .ToString converts the Object to a string
        Console.WriteLine(userString.Length.ToString())

        Console.WriteLine("The first 3 characters of the string")
        Console.WriteLine(userString.Substring(0, 3))
        Console.WriteLine()

        Console.WriteLine("Chars 2-5")
        Console.WriteLine(userString.Substring(1, 5))
        Console.WriteLine()

        Console.WriteLine("The remaining characters")
        Console.WriteLine(userString.Substring(6))
        Console.WriteLine()

        Console.ReadLine()


        '====================
        ' Formatting Strings
        '====================

        Console.WriteLine("Formatting Strings")

        Dim str As String = Nothing


        Console.ReadLine()
    End Sub

End Module
