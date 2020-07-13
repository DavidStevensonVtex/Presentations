Imports System

Public Class CoffeeClanMember
    Shared memberCount As Integer = 1
    Dim memberNumber As Integer = memberCount
    Public Sub New()
        memberCount = memberCount + 1
    End Sub
    Public Sub MyCoffeeIsReady()
        Console.WriteLine("Coffee Clan Member #" & memberNumber & ": My Coffee Is Ready")
    End Sub
End Class
