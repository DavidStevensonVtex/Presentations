Imports System

Public Class MyEventClass
    ' Declare an event for this class.
    Public Event MyEvent(ByVal EventNumber As Integer)
    ' Define a method that raises an event.
    Sub CauseEvent(ByVal EventNumber As Integer)
        RaiseEvent MyEvent(EventNumber)
    End Sub
End Class

Public Class TestEvent
    Shared Sub EventHandler(ByVal EventNumber As Integer)
        Console.WriteLine("Received event number {0}", EventNumber )
    End Sub

    Shared Sub Main()
        Dim MyObject As New MyEventClass()
        AddHandler MyObject.MyEvent, AddressOf TestEvent.EventHandler
        ' Cause the object to raise an event.
        MyObject.CauseEvent(123)
    End Sub
End Class
