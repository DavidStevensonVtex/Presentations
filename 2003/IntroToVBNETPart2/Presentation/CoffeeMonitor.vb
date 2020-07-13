Imports System

Public Class CoffeeMonitor
    Shared WithEvents monitor As Coffee = New Coffee()
    Shared Sub MyCoffeeIsReady()
        Console.WriteLine("My Coffee Is Ready")
    End Sub
    Shared Sub YourCoffeeIsReady() Handles monitor.CoffeeReady
        Console.WriteLine("Your coffee is ready")
    End Sub
    Shared Sub Main()
        Dim coffee As New Coffee()
        monitor.NotifyCoffeeReady()
        ' A reference to a static method
        AddHandler coffee.CoffeeReady, AddressOf MyCoffeeIsReady
        Dim coffeeClanMember(10) As CoffeeClanMember
        Dim i As Integer
        For i = 0 To 10
            coffeeClanMember(i) = New CoffeeClanMember()
            ' A reference to an instance method.
            AddHandler coffee.CoffeeReady, AddressOf coffeeClanMember(i).MyCoffeeIsReady
        Next
        ' A single RaiseEvent will notify me and the entire coffee clan.
        coffee.NotifyCoffeeReady()
    End Sub
End Class
