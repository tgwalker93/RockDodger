Option Strict On

Public Class Rock
    Private xPosition As Integer
    Private yPosition As Integer
    Public random As New Random
    Sub New()
        MyBase.New()
        'All Rocks start from 0 on the Y axis (just above the cannons) 
        yPosition = 400
        'Multiples of 50 from 0 to 500 (min and max width of the game board) 
        xPosition = random.Next(0, 10) * 50
    End Sub

    Public Property X As Integer
        Get
            Return xPosition
        End Get
        Set(value As Integer)
            xPosition = value
        End Set
    End Property

    Public ReadOnly Property Y As Integer
        Get
            Return yPosition
        End Get
    End Property

End Class
