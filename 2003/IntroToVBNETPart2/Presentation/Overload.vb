Imports System
Imports Microsoft.VisualBasic

Public Class DisplayIt
   Overloads Public Sub Display ( theChar As Char )
       Console.WriteLine ( "Display: theChar      : {0}", theChar )
   End Sub
   Overloads Public Sub Display ( theInteger As Integer )
        Console.WriteLine ( "Display: theInteger   : {0}", theInteger )
   End Sub
   Overloads Public Sub Display ( theString As String )
        Console.WriteLine ( "Display: theString    : {0}", theString )
   End Sub
End Class

Public Class Test
    Shared Sub Main()
        Dim d As New DisplayIt
        d.Display ( ChrW ( 86 ) )
        d.Display ( "B"C )
        d.Display ( "."C )
        d.Display ( "NET" ) 
        d.Display ( 12345 )
    End Sub
End Class