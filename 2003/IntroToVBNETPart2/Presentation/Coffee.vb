Public Class Coffee
    Public Event CoffeeReady()
    Public Sub NotifyCoffeeReady()
        RaiseEvent CoffeeReady()
    End Sub
End Class
