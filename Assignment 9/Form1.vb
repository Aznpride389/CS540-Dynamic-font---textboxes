Imports System.IO

Public Class Form1
    Dim words As List(Of String)
    Dim index As Integer = 0
    Dim current As String = String.Empty
    Dim shouldEnd As Boolean = False

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        If shouldEnd Then
            End
        End If
        resizelabel()
        resizeFont()
        If index + 1 < words.Count Then
            index += 1
            current = words(index)
        Else
            shouldEnd = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        words = New List(Of String)()
        readFile()

    End Sub

    Private Sub readFile()
        Dim objStreamReader As StreamReader
        Dim strLine As String = String.Empty

        objStreamReader = New StreamReader("cs540hw8input.txt")
        strLine = objStreamReader.ReadLine

        Do While Not strLine Is Nothing
            If String.IsNullOrEmpty(strLine) Then
                strLine = objStreamReader.ReadLine
                Continue Do
            End If
            words.Add(strLine)
            strLine = objStreamReader.ReadLine
        Loop
        objStreamReader.Close()
        current = words(0)
    End Sub

    Private Sub resizelabel()
        Dim g1 As Graphics
        Dim s1 As SizeF
        Dim marginBuffer As Integer
        g1 = Me.resizeFontLabel.CreateGraphics
        s1 = g1.MeasureString(current, resizeControlLabel.Font)
        marginBuffer = g1.MeasureString("  ", resizeControlLabel.Font).Width
        g1.Dispose()
        resizeControlLabel.Width = s1.Width + 20 * marginBuffer
        resizeControlLabel.Text = current
    End Sub

    Private Sub resizeFont()
        Dim f2 As Font
        Dim g2 As Graphics
        Dim s2 As SizeF
        Dim Factor_, FactorX, FactorY As Single
        g2 = Me.resizeFontLabel.CreateGraphics
        s2 = g2.MeasureString("    " + current, resizeFontLabel.Font)
        g2.Dispose()
        FactorX = resizeFontLabel.Width / s2.Width
        FactorY = resizeFontLabel.Height / s2.Height
        If FactorX > FactorY Then
            Factor_ = FactorY
        Else
            Factor_ = FactorX
        End If
        f2 = resizeFontLabel.Font
        Dim size As Integer = Math.Floor(f2.SizeInPoints * Factor_)
        resizeFontLabel.Font = New Font(f2.Name, size)
        resizeFontLabel.Text = current
    End Sub

    Private Sub resizeControlLabel_Click(sender As Object, e As EventArgs) Handles resizeControlLabel.Click

    End Sub
End Class
