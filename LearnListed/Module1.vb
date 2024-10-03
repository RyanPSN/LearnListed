Module Module1

    Sub Main()


        For u As Integer = 0 To 4

            Console.WriteLine("Enter Num: ")
            Dim num As Integer = Console.ReadLine()

            For j As Integer = num To num + 1

                Console.WriteLine("Enter List: ")
                Dim List = Console.ReadLine()

                Console.WriteLine("Num: {0} Value: {1}", j, List)
                Console.ReadLine()


            Next

        Next

    End Sub

End Module
