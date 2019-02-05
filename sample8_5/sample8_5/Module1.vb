Module Module1

    Sub Main()
        Dim Reservation As New Queue()

        Reservation.Enqueue("Bさん")
        Reservation.Enqueue("Cさん")
        Reservation.Enqueue("Aさん")
        Reservation.Enqueue("Dさん")

        Dim TicketNo As Integer = 1

        Do Until Reservation.Count = 0
            Console.WriteLine("チケットNo.{0}:{1}", TicketNo, Reservation.Dequeue())
            TicketNo += 1
        Loop

        Console.ReadLine()

    End Sub

End Module
