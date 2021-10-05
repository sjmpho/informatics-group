Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class Male_employee
    Inherits Worker

    Private _workquality As Integer
    Private _workattitude As String

    Public Sub New(employeename As String, employeegender As String, workexp As Integer, Workquality As Integer _
                   , workattitude As String)
        MyBase.New(employeename, employeegender, workexp)

        _workquality = Workquality
        _workattitude = workattitude
    End Sub

    Public Overrides Function determine_if_training_is_needed() As String
        Dim Result As Integer
        Dim Training As String = "N/A"
        Result = _workquality + _WorkExperience
        Select Case Result
            Case 1 To 2
                Training = “Not needed”
            Case 3 To 4
                Training = “Short term training needed”
            Case 5 To 6
                Training = “long term training needed”
        End Select
        Return Training
    End Function

    Public Function salary_earning() As Integer
        Dim salary As Integer = 12000
        Select Case determine_if_training_is_needed()
            Case “Not needed”
                salary += 0
            Case “Short term training needed”
                salary -= 1000
            Case “long term training needed”
                salary -= 2000

        End Select
        Return salary
    End Function

    Private Function determineworkquality() As String

        Select Case _workquality
            Case = 1
                Return "outstanding"
            Case = 2
                Return "average"
            Case Else
                Return "needs improvement"
        End Select
    End Function

    Public Overrides Function Displayemployeeform() As String
        Dim text As String

        text = MyBase.Displayemployeeform
        text &= "Work attitude: " & _workattitude & Environment.NewLine
        text &= "workqualitytype: " & determineworkquality() & Environment.NewLine
        text &= "training status: " & determine_if_training_is_needed() & Environment.NewLine
        text &= "salary: " & salary_earning() & Environment.NewLine

        Return text
    End Function


End Class
