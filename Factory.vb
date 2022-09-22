Module Factory

    Sub Main()
        Dim c1 As New Box(10, 10, 10),
            c2 As New Box(20, 20, 20),
            c3 As New Box(1, 1, 1)

        Dim lista As New List(Of Box)
        Dim listaOrdenada As New SortedList(Of Box, Box)

        Console.WriteLine(c1.ToString)
        Console.WriteLine(c2.ToString)
        Console.WriteLine(c3.ToString)
        Console.WriteLine()

        lista.Add(c1)
        lista.Add(c2)

        listaOrdenada.Add(c1, c1)
        listaOrdenada.Add(c2, c2)

        'Probamos a sumar
        c3 = c1 + c2
        Console.WriteLine(c3.ToString)
        Console.WriteLine()

        lista.Add(c3)
        listaOrdenada.Add(c3, c3)

        'Probamos a restar
        c3 = c2 - c1
        Console.WriteLine(c3.ToString)
        Console.WriteLine()
        lista.Add(c3)

        Try
            listaOrdenada.Add(c3, c3)
        Catch ex As ArgumentException
            Console.WriteLine("El elemento " & c3.ToString & " ya se encuentra en la lista.")
            Console.WriteLine()
        End Try

        Console.WriteLine("Lista antes de ordenar--------------------------")
        For Each elemento In lista
            Console.WriteLine(elemento.ToString)
        Next
        Console.WriteLine()

        Console.WriteLine("Lista después de ordenar--------------------------")
        lista.Sort()
        For Each elemento In lista
            Console.WriteLine(elemento.ToString)
        Next
        Console.WriteLine()

        Console.WriteLine("Lista ordenada --------------------------")
        For Each elemento In listaOrdenada
            Console.WriteLine(elemento.ToString)
        Next
        Console.WriteLine()

        Console.WriteLine("Lista ordenada inversa--------------------------")
        For Each elemento In listaOrdenada.Reverse()
            Console.WriteLine(elemento.ToString)
        Next
        Console.WriteLine()

        Console.Read()
    End Sub

End Module
