Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private apiClient As New ApiClient()
    Private stopwatchTimer As New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        AddHandler stopwatchTimer.Tick, AddressOf UpdateStopwatchLabel
        stopwatchTimer.Interval = 1000 ' Update every second
        stopwatchTimer.Start()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Sub UpdateStopwatchLabel(sender As Object, e As EventArgs)
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub ClearForm()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithubLink.Text = ""
        lblStopwatch.Text = "00:00:00" ' Reset stopwatch label
        stopwatch.Reset() ' Reset the stopwatch
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }
        Await apiClient.SubmitSubmission(submission)
        MessageBox.Show("Submission saved successfully!")
        ClearForm()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If txtPhone.Text.Length > 10 Then
            txtPhone.Text = txtPhone.Text.Substring(0, 10)
            txtPhone.SelectionStart = txtPhone.Text.Length ' Keep cursor at the end
        End If
    End Sub
End Class
