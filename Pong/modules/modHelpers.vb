Imports System.Runtime.CompilerServices

Public Module modHelpers
    ' POSITIONING HELPERS:
    <Extension()>
    Sub horizontallyCentre(control As Object)
        control.Left = Menu.Width / 2 - control.Width / 2
    End Sub

    <Extension()>
    Sub verticallyCentre(control As Object)
        control.Top = Menu.Height / 2 - control.Height / 2
    End Sub

    <Extension()>
    Sub placeAbove(control As Object, relativeControl As Object, pixels As Integer)
        control.Top = relativeControl.Top - control.Height - pixels
    End Sub

    <Extension()>
    Sub placeBelow(control As Object, relativeControl As Object, pixels As Integer)
        control.Top = relativeControl.Top + relativeControl.Height + pixels
    End Sub

    <Extension()>
    Sub placeRight(control As Object, relativeControl As Object, pixels As Integer)
        control.Left = relativeControl.Left + relativeControl.Width + pixels
    End Sub

    <Extension()>
    Sub placeLeft(control As Object, relativeControl As Object, pixels As Integer)
        control.Left = relativeControl.Left - relativeControl.Width - pixels
    End Sub

    <Extension()>
    Sub setX(control As Object, x As Integer)
        control.Left = x - control.Width / 2
    End Sub

    <Extension()>
    Sub setY(control As Object, y As Integer)
        control.Top = y - control.Height / 2
    End Sub

    ' BORDER DRAWING
    <Extension()>
    Sub drawBorder(control As Control, color As Color)
        Dim g As Graphics = control.FindForm().CreateGraphics()
        Dim pen As New Pen(color, 4)

        g.DrawRectangle(pen, New Rectangle(control.Location, control.Size))

        pen.Dispose()
        g.Dispose()
    End Sub

    ' This is used inside the onPaint event. Doesn't work elsewhere for some reason.
    <Extension()>
    Sub drawBottomBorder(control As Control, g As Graphics, color As Color)
        Dim pen As New Pen(color, 4)
        g.DrawLine(pen, New Point(control.Left, control.Top + control.Height), New Point(control.Left + control.Width, control.Top + control.Height))

        pen.Dispose()
    End Sub

    ' Better border drawing that works in Panels.
    <Extension()>
    Sub drawBorderInPanel(control As Control, g As Graphics, color As Color)
        Dim pen As New Pen(color, 4)

        g.DrawRectangle(pen, New Rectangle(control.Location, control.Size))

        pen.Dispose()
    End Sub

    ' CHANGING A CHARACTER IN A STRNIG
    Function changeCharacter(s As String, replaceWith As Char, index As Integer) As String
        Dim sb As New System.Text.StringBuilder(s)
        sb(index) = replaceWith
        Return sb.ToString()
    End Function

    ' -------------------- GAME HELPERS -----------------------
    ' In an imaginary circle, gets the angle subtended at the origin (Game.CENTRE_X, GAME.CENTRE_Y) 
    ' by the arc formed by the mouse's position and the intersection of the circle and the positive x-axis.
    ' Basically, it works just like normal maths.
    Function getMouseAngle(cursorLocation As Point) As Double
        Dim angle As Double = Math.Atan2(cursorLocation.Y - Game.CENTRE_Y, cursorLocation.X - Game.CENTRE_X)

        ' Normalise atan2's results to be like normal maths.
        If angle < 0 Then
            angle = angle + 2 * Math.PI
        End If

        Return angle
    End Function
End Module
