Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class Female_employee
    'Inheritance
    Inherits Worker

    'Attributes
    Private _num_past_job As Integer
    Private _employeegrading As Integer

    'Constructor
    Public Sub New(employeename As String, employeegender As String, workexp As Integer,
                   numpastjobs As Integer, grading As Integer)

        MyBase.New(employeename, employeegender, workexp)
        _num_past_job = numpastjobs
        _employeegrading = grading
    End Sub

    'Function that evaluates employee grading
    Public Function determineEmployeeGradings() As String
        Dim Gradingtype As String
        If _employeegrading = 1 Then
            Gradingtype = “Surpasses expectations”
        Else
            If _employeegrading = 2 Then
                Gradingtype = “Meets expectations”
            Else
                Gradingtype = “Needs improvement”
            End If
        End If
        Return Gradingtype
    End Function

    'Function that determines the employee's salary
    Public Function Salary_earning() As Integer
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

    'Function that determines if the employee requires training
    Public Overrides Function determine_if_training_is_needed() As String
        Dim Result As Integer
        Dim Training As String = "N/A"
        Result = _employeegrading + _WorkExperience
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

    'Display
    Public Overrides Function Displayemployeeform() As String
        Dim text As String

        text = MyBase.Displayemployeeform()
        text &= "Number of past jobs: " & CStr(_num_past_job) & Environment.NewLine
        text &= "Employee grading: " & determineEmployeeGradings() & Environment.NewLine
        text &= "Training: " & determine_if_training_is_needed() & Environment.NewLine
        text &= "Salary: " & CStr(Salary_earning()) & Environment.NewLine & Environment.NewLine

        Return text
    End Function

End Class
