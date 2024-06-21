Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ApiClient
    Private ReadOnly httpClient As HttpClient

    Public Sub New()
        httpClient = New HttpClient()
        httpClient.BaseAddress = New Uri("http://localhost:3000/")
    End Sub

    Public Async Function SubmitSubmission(submission As Submission) As Task
        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")
        Await httpClient.PostAsync("submit", content)
    End Function

    Public Async Function GetSubmission(index As Integer) As Task(Of Submission)
        Dim response = Await httpClient.GetAsync($"read?index={index}")
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of Submission)(json)
    End Function

    Public Async Function GetAllSubmissions() As Task(Of List(Of Submission))
        Dim response = Await httpClient.GetAsync("read")
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of List(Of Submission))(json)
    End Function
End Class
