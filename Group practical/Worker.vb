Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public MustInherit Class Worker
    'Attibutes 
    Private _Employee_Name As String
    Private _employee_gender As String
    Protected _WorkExperience As Integer
    Private Shared _employeenum As Integer = 2021000

    'Constructor
    Public Sub New(employeename As String, employeegender As String, workexp As Integer)
        _Employee_Name = employeename
        _employee_gender = employeegender
        _WorkExperience = workexp
        _employeenum += 21
    End Sub

    'methods
    Public MustOverride Function determine_if_training_is_needed() As String

    Public Function determine_work_experience() As String
        Dim workexptype As String

        If _WorkExperience = 1 Then
            workexptype = "Paid internships"
        ElseIf _WorkExperience = 2 Then
            workexptype = "Apprenticeships"
        Else
            workexptype = "Freelancing"
        End If

        Return workexptype
    End Function

    Public Overridable Function Displayemployeeform() As String

        Dim text As String = ""

        text &= “Employee form” & Environment.NewLine
        text &= “Employee Name:” & _Employee_Name & Environment.NewLine
        text &= “Employee gender: “ & _employee_gender & Environment.NewLine
        text &= “Work Experience: “ & determine_work_experience() & Environment.NewLine
        text &= “employee number:” & CStr(_employeenum) & Environment.NewLine
        Return text
    End Function

End Class
