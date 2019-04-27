Option Strict On
Imports System.Threading
Imports System.Threading.Tasks

Public Class Rock
    Private xPosition As Integer
    Private yPosition As Integer
    Private currentTimePrivate As Integer
    Private maxTimePrivate As Integer
    Private random As New Random
    Public graphicsObj As Graphics

    Sub New()
        MyBase.New()
        'All Rocks start from 400 on the Y axis (just above the cannons) 
        yPosition = 400
        'Multiples of 50 from 0 to 500 (min and max width of the game board) 
        xPosition = random.Next(0, 10) * 50

    End Sub
    Sub New(xArg As Integer)
        MyBase.New()
        'All Rocks start from 400 on the Y axis (just above the cannons) 
        yPosition = 400
        'Multiples of 50 from 0 to 500 (min and max width of the game board) 
        xPosition = xArg

    End Sub
    Public Property X As Integer
        Get
            Return xPosition
        End Get
        Set(value As Integer)
            xPosition = value
        End Set
    End Property

    Public Property Y As Integer
        Get
            Return yPosition
        End Get
        Set(value As Integer)
            yPosition = value
        End Set
    End Property


    Public Property currentTime As Integer
        Get
            Return currentTime
        End Get
        Set(value As Integer)
            currentTimePrivate = value
        End Set
    End Property

    Public Property maxTime As Integer
        Get
            Return maxTime
        End Get
        Set(value As Integer)
            maxTimePrivate = value
        End Set
    End Property

End Class
