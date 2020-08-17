Imports System.Runtime.InteropServices
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
'Imports System.IO

Public Class Form1
    Dim u As String = System.Environment.UserName
    Dim dirS As String = "C:\Users\" + u + "\Documents\MyPic-ks\Screen\"
    Dim dirW As String = "C:\Users\" + u + "\Documents\MyPic-ks\Web Cam\"
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = "Version " & Application.ProductVersion

        Dim x As Integer = (Size.Width / 2)
        Dim y As Integer = (Size.Height / 2) + 5
        x = x - lblVersion.Width / 2
        'lblVersion.Location = New Point(x, y)

        If (Not System.IO.Directory.Exists(dirS)) Or (Not System.IO.Directory.Exists(dirW)) Then
            System.IO.Directory.CreateDirectory(dirS)
            System.IO.Directory.CreateDirectory(dirW)
        End If
    End Sub


    Private Sub btnSShot_Click(sender As Object, e As EventArgs) Handles btnSShot.Click
        WindowState = FormWindowState.Minimized
        Try
            If (Not System.IO.Directory.Exists(dirS)) Then
                System.IO.Directory.CreateDirectory(dirS)
            End If

            Dim bounds As Rectangle
            Dim screenshot As System.Drawing.Bitmap
            Dim graph As Graphics
            bounds = Screen.PrimaryScreen.Bounds
            screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)

            Dim num = 0
            Dim fN As String = "Pic-k S.png"
            Dim filePath As String = dirS + fN
            If IO.File.Exists(filePath) Then
                Dim extension = "png"
                Dim fileNumber = 0
                Do
                    fileNumber += 1
                    filePath = IO.Path.Combine(dirS, String.Format("{0} ({1}){2}", "Pic-k S", fileNumber, "." + extension))
                Loop While IO.File.Exists(filePath)
            End If

            screenshot.Save(filePath, System.Drawing.Imaging.ImageFormat.Png)
            lblVersion.Text = "Screenshot saved!"
            ' lblVersion.Location = New Point(76, 63)
            delay.Start()
            lblVersion.ForeColor = Color.YellowGreen
            WindowState = FormWindowState.Normal
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnWCam_Click(sender As Object, e As EventArgs) Handles btnWCam.Click
        If btnWCam.Text = "   Webcam " Then
            TopMost = False
            Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()

            If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TopMost = True
                Opacity = 100%
                CAMERA = cameras.VideoDevice
                AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                CAMERA.Start()

                If (Not System.IO.Directory.Exists(dirW)) Then
                    System.IO.Directory.CreateDirectory(dirW)
                End If

                If Height = 108 Then
                    Height = 299
                Else Height = 108
                End If
                btnWCam.Text = "   Cancel "
            Else
                MsgBox("Web camera is required for this operation. Please select one to use the feature.")
            End If
        ElseIf btnWCam.Text = "   Cancel " Then
            CAMERA.Stop()
            Height = 108
            btnWCam.Text = "   Webcam "
            Opacity = 90%
        End If
    End Sub
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picDisplay.Image = DirectCast(eventArgs.Frame.Clone, Bitmap)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        Process.Start("explorer.exe", "C:\Users\" + u + "\Documents\MyPic-ks\")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If btnWCam.Text = "   Cancel " Then
            MsgBox("Click CANCEL to close the webcam before exiting.")
        Else Application.Exit()
        End If
    End Sub

    Private Sub Delay_Tick(sender As Object, e As EventArgs) Handles delay.Tick
        lblVersion.Text = "Version 1.0.0.0"
        lblVersion.ForeColor = Color.LightGray
        'lblVersion.Location = New Point(85, 63)
        delay.Stop()
    End Sub

    Private Sub btnSnap_Click(sender As Object, e As EventArgs) Handles btnSnap.Click
        picTaken.Image = picDisplay.Image

        Dim num = 0
        Dim fN As String = "Pic-k W.jpg"
        Dim filePath As String = dirW + fN
        If IO.File.Exists(filePath) Then
            Dim extension = "jpg"
            Dim fileNumber = 0
            Do
                fileNumber += 1
                filePath = IO.Path.Combine(dirW, String.Format("{0} ({1}){2}", "Pic-k W", fileNumber, "." + extension))
            Loop While IO.File.Exists(filePath)
        End If
        picTaken.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg)
        lblVersion.Text = "Camshot saved!"
        'lblVersion.Location = New Point(77, Me.Height + 30)
        delay.Start()
        lblVersion.ForeColor = Color.YellowGreen
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
