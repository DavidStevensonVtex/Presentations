Imports System

Class Test
    Shared Sub RememberLastItem(ByVal item As String)
        Static lastItem As String = ""
        Console.WriteLine("item: '{0}' last item: '{1}'", item, lastItem)
        lastItem = item
    End Sub
    Shared Sub Main()
        RememberLastItem("Apple")
        RememberLastItem("Orange")
        RememberLastItem("Banana")
    End Sub
End Class