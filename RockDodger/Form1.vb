Option Strict On
Imports System.Drawing.Drawing2D
Imports System.Timers

Public Class Form1

    Dim gr As Graphics
    Dim birdMovegr As Graphics
    Const Square_Size = 50
    Const Board_Width = 500
    Const Board_Height = 500
    Dim CannonPic As Image = RockDodger.My.Resources.cannon
    Dim RockPic As Image = RockDodger.My.Resources.brownAsteroid
    Dim BirdPic As Image = RockDodger.My.Resources.giphy
    Dim ExplosionPic As Image = RockDodger.My.Resources.Explosion
    Dim currentBirdXPosition As Integer = 250
    Dim currentBirdYPosition As Integer = 250
    Private levelTimer As System.Timers.Timer
    Private secondsSinceGameStart As System.Timers.Timer
    Dim gameSpeed As Integer = 100
    Dim count As Integer = 0
    Dim firstRock As Rock = New Rock()
    Dim rockGr As Graphics
    Dim rockArray As New List(Of Rock)
    Dim GameIsActive As Boolean = False
    Dim HighScore As Integer = 0
    Dim currentLevelTime As Integer
    Dim currentLevel As Integer = 1
    Private Sub StartGame_Click(sender As Object, e As EventArgs) Handles StartGame.Click
        rockArray.Clear()
        GameIsActive = True
        Console.WriteLine("Start game was selected!")
        Console.ReadLine()
        EndGame.Show()
        StartGame.Hide()
        'Draw the initial board
        RedrawBoard(currentBirdXPosition, currentBirdYPosition)

        'Summon a rock
        'gr.DrawImage(RockPic, firstRock.X, firstRock.Y, Square_Size, Square_Size)
        StartTimer()

        'firstRock.graphicsObj = GameBox.CreateGraphics()

        'Initialize a rock object for every posible x position on the grid
        Dim currentX As Integer = 0
        For index As Integer = 0 To 9
            Dim currentRock As Rock = New Rock(currentX)
            rockArray.Add(currentRock)
            currentX = currentX + 50
            currentRock.graphicsObj = GameBox.CreateGraphics()
        Next


    End Sub

    Private Sub EndGame_Click(sender As Object, e As EventArgs) Handles EndGame.Click
        StopGame()
    End Sub
    Private Sub StopGame()
        GameIsActive = False


        If count > HighScore Then
            HighScore = count
        End If
        StartGame.Show()
        EndGame.Hide()
        Me.HighScoreValue.Text = CStr(HighScore)
        Me.TimeValue.Text = "0"
        count = 0
        levelTimer.Stop()
        levelTimer.Dispose()
        'secondsSinceGameStart.Stop()
        'secondsSinceGameStart.Dispose()
        secondTimer.Stop()
        secondTimer.Dispose()
    End Sub

    'Create Lock to prevent rock image being edited from two different threads at the same time (InvalidOperationException)
    'Private Object _locker = New Object();



    Private Sub moveOneRock(currentRock As Rock)

        Call currentRock.graphicsObj.DrawImage(RockPic, currentRock.X, currentRock.Y, Square_Size, Square_Size)
        'Create Rectangle where position would be at current location of rock
        Dim rockLocation As New Rectangle()
        rockLocation.Size = New Size(Square_Size, Square_Size)
        rockLocation.Location = New Point(currentRock.X, currentRock.Y)
        'Fill Location of the Bird
        Dim aquaBrush As New SolidBrush(Color.Aqua)

        currentRock.graphicsObj.FillRectangle(aquaBrush, rockLocation)


        'Fill blank square in old rock's position 
        'currentRock.graphicsObj.DrawRectangle(Pens.Red, currentRock.X, currentRock.Y, Square_Size, Square_Size)

        currentRock.Y -= 50

        If currentRock.Y = currentBirdYPosition AndAlso currentRock.X = currentBirdXPosition Then
            Debug.Print("StopGame Called!")
            gr.DrawImage(ExplosionPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
            Me.Invoke(Sub() StopGame())
            Return
        End If
        'currentRock.Y = currentRock.Y - 50
        If currentRock.Y < 0 Then
            'currentRock.Y = 450
            currentRock.Y = 400
            'I have to redraw the cannonPic becuase for some reason this is getting deleted 
            Call gr.DrawImage(RockPic, currentRock.X, 400, Square_Size, Square_Size)
            Return
        End If

        'Insert Rock into new position
        Call currentRock.graphicsObj.DrawImage(RockPic, currentRock.X, currentRock.Y, Square_Size, Square_Size)

    End Sub

    Private Function findRockInList(ByVal r As Rock, xLocation As Integer) As Boolean
        Return (r.X = xLocation)
    End Function

    Private Sub moveRocks()
        Dim random As New Random
        Dim numberOfRocksInARow = random.Next(4, 8)
        Dim currentRandomXLocation As Integer
        Dim listOfUsedRockXLocations As New List(Of Integer)
        For i As Integer = 0 To numberOfRocksInARow
            currentRandomXLocation = random.Next(0, 10) * 50
            While CBool(listOfUsedRockXLocations.Find(Function(value As Integer) value = currentRandomXLocation))
                'Debug.Write("Found duplicate: Current Random X Location is " & currentRandomXLocation)
                currentRandomXLocation = random.Next(0, 10) * 50
            End While
            listOfUsedRockXLocations.Add(currentRandomXLocation)
            Dim rockFound As Rock = rockArray.Find(Function(r) r.X = currentRandomXLocation)
            moveOneRock(rockFound)
        Next
        'For Each rock As Rock In rockArray
        'currentRandomXLocation = random.Next(0, 10)
        'moveOneRock(rock)
        '  gr.DrawImage(RockPic, firstRock.X, firstRock.Y, Square_Size, Square_Size)
        '  Next

    End Sub

    Private Sub RedrawBoard(birdXPosition As Integer, birdYPosition As Integer)

        GameBox.Width = Board_Width
        GameBox.Height = Board_Height
        gr = GameBox.CreateGraphics

        gr.Clear(Color.Aqua)
        For intX = 0 To Board_Width - 1 Step Square_Size
            For intY = 0 To Board_Height - 1 Step Square_Size
                'gr.DrawRectangle(Pens.Red, intX, intY, Square_Size, Square_Size)
                'Cannons
                If intY = 450 Then
                    Call gr.DrawImage(CannonPic, intX, intY, Square_Size, Square_Size)
                End If
            Next
        Next

        Call gr.DrawImage(BirdPic, birdXPosition, birdYPosition, Square_Size, Square_Size)

    End Sub

    'On Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Panel1.Font = New Font("Comic Sans MS", 12, FontStyle.Bold Or FontStyle.Underline)
        LevelValue.Font = New Font("Comic Sans MS", 12, FontStyle.Bold)
        HighScoreValue.Font = New Font("Comic Sans MS", 12, FontStyle.Bold)
        TimeValue.Font = New Font("Comic Sans MS", 12, FontStyle.Bold)
        EndGame.Hide()
    End Sub


    Private Sub StartTimer()
        SetTimer()

        Console.WriteLine("{0}Press the Enter key to exit the application...{0}",
                        vbCrLf)
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}",
                        DateTime.Now)
        Console.ReadLine()

        levelTimer.Start()
        'secondsSinceGameStart.Start()
        secondTimer.Start()
        'TimeValue.Text = CStr(count)
    End Sub



    Private Sub SetTimer()
        ' Create a timer with a one second interval.
        levelTimer = New System.Timers.Timer(gameSpeed)
        ' Hook up the Elapsed event for the timer. 
        AddHandler levelTimer.Elapsed, AddressOf OnTimedEvent
        levelTimer.AutoReset = True
        levelTimer.Enabled = True
        secondTimer.Enabled = True

    End Sub

    Sub updateLevelText()
        currentLevel += 1
        Debug.WriteLine("CURRENT LEVEL IS " & currentLevel)
        LevelValue.Text = CStr(currentLevel)
    End Sub
    ' The event handler for the Timer.Elapsed event. (Whenever the timer ticks, this is called)
    'This timer event is for the speed of the game. 
    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        'count = count + 1

        'We have to use BeginInvoke because we need to update Label1 from another thread. 
        'Me.BeginInvoke(Sub() Me.TimeValue.Text = CStr(count))

        'Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
        'e.SignalTime)
        'Console.WriteLine(e.SignalTime.ToString("yyyy-MM-dd HH:mm:ss"))

        'If the different between currentLevel minimum and current time is 15 seconds, then we start new level
        If count - currentLevelTime = 15 Then
            currentLevelTime = count
            gameSpeed = gameSpeed - 50
            levelTimer.Interval = gameSpeed
            Me.Invoke(Sub() updateLevelText())

        End If
        moveRocks()
    End Sub

    'This timer is for the game clock 
    Private Sub secondTimer_Tick(sender As Object, e As EventArgs) Handles secondTimer.Tick
        count = count + 1
        TimeValue.Text = CStr(count)
    End Sub

    'This function will end the game if the current bird position is at a rock position
    Sub checkIfBirdCollidedWithRock()
        For Each rock In rockArray
            If currentBirdXPosition = rock.X AndAlso currentBirdYPosition = rock.Y Then
                Debug.Print("StopGame Called via Bird movement")
                gr.DrawImage(ExplosionPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Me.Invoke(Sub() StopGame())
            End If
        Next
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        If GameIsActive = False Then
            Return Nothing
        End If
        GameBox.Width = Board_Width
        GameBox.Height = Board_Height

        birdMovegr = GameBox.CreateGraphics
        'Create Rectangle where position would be at current location of bird
        Dim birdLocation As New Rectangle()
        birdLocation.Size = New Size(Square_Size, Square_Size)
        birdLocation.Location = New Point(currentBirdXPosition, currentBirdYPosition)
        'Fill Location of the Bird
        Dim aquaBrush As New SolidBrush(Color.Aqua)
        birdMovegr.FillRectangle(aquaBrush, birdLocation)
        'Insert blank square into old location 
        'birdMovegr.DrawRectangle(Pens.Red, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)

        Select Case keyData
            Case Keys.Up
                'Change current position of the bird
                currentBirdYPosition -= 50
                'Test to make sure that bird isn't outside of game board
                If currentBirdYPosition < 0 Then
                    currentBirdYPosition = 0
                End If
                checkIfBirdCollidedWithRock()
                Debug.Print("Up")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call birdMovegr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Right
                'Change current position of the bird
                currentBirdXPosition += 50
                'Test to make sure that bird isn't outside of game board
                If currentBirdXPosition > 450 Then
                    currentBirdXPosition = 450
                End If
                checkIfBirdCollidedWithRock()
                Debug.Print("Right")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call birdMovegr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Down
                'Change current position of the bird
                currentBirdYPosition += 50
                'Test to make sure that bird isn't outside of game board
                If currentBirdYPosition > 400 Then
                    currentBirdYPosition = 400
                End If
                checkIfBirdCollidedWithRock()
                Debug.Print("Down")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call birdMovegr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Left
                currentBirdXPosition -= 50

                'Test to make sure that bird isn't outside of game board
                If currentBirdXPosition < 0 Then
                    currentBirdXPosition = 0
                End If
                checkIfBirdCollidedWithRock()
                Debug.Print("Left")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call birdMovegr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function




End Class


