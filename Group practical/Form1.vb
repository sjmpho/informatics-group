Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmEquality
    'Variables
    Private jobname As String
    Private nfemaleemployees As Integer
    Private nmaleemployees As Integer
    Private genderofferedjob As String
    Private workertype() As Worker
    Private Const employeeinfofile As String = "Employeefile.work"
    Private FileStream As FileStream
    Private BinaryFormatter As BinaryFormatter
    Private count As Integer = 0

    Private Sub btnJobPosition_Click(sender As Object, e As EventArgs) Handles btnJobPosition.Click
        jobname = InputBox("Enter the name of the job position.")
        nfemaleemployees = CInt(InputBox("Enter the number of female employees in the company"))
        nmaleemployees = CInt(InputBox("Enter the number of male employees in the company"))

        'compares the number of male and female employees
        If nfemaleemployees > nmaleemployees Then
            txtjoboffering.Text = "Select the best candidate from the male gender to offer them the job position"
            genderofferedjob = "Male"
        ElseIf nmaleemployees > nfemaleemployees Then
            txtjoboffering.Text = "Select the best candidate from the female gender to offer them the job position"
            genderofferedjob = "Female"
        End If
    End Sub

    Private Sub btnChosenCandidate_Click(sender As Object, e As EventArgs) Handles btnChosenCandidate.Click
        Dim employeename As String
        Dim workexp As Integer
        count += 1
        ReDim Preserve workertype(count)
        employeename = InputBox("Enter the name of the chosen candidate")
        workexp = CInt(InputBox("Please select the work experience that the chosen candidate has " &
                                Environment.NewLine & "1- Paid internship" & Environment.NewLine &
                                "2- Apprenticeships" & Environment.NewLine & "3- Freelancing"))

        'entering the best candidate's information into the program
        Select Case genderofferedjob
            Case "Male"
                'input information if males were given the job opportunity
                Dim workattitude As String
                Dim workquality As Integer

                workattitude = InputBox("please describe the work attitude of the male candidate")
                workquality = CInt(InputBox("Please select the work quality that the chosen male candidate has " &
                                Environment.NewLine & "1- Outstanding" & Environment.NewLine &
                                "2- Average" & Environment.NewLine & "3- Needs improvement"))

                Dim maleemployee As Male_employee = New Male_employee(employeename, genderofferedjob, workexp, workquality, workattitude)
                workertype(count) = maleemployee

            Case "Female"
                'input information if males were given the job opportunity
                Dim num_past_jobs, employeegrading As Integer

                num_past_jobs = CInt(InputBox("please enter the number of past jobs that the chossen female candidate had"))
                employeegrading = CInt(InputBox("Please select the employee grading that the chosen female candidate has " &
                                Environment.NewLine & "1- Surpasses expectations" & Environment.NewLine &
                                "2- Meets expectations" & Environment.NewLine & "3- Needs improvement"))

                Dim femaleemployee As Female_employee = New Female_employee(employeename, genderofferedjob, workexp, num_past_jobs, employeegrading)
                workertype(count) = femaleemployee
        End Select
    End Sub

    Private Sub btnEmployeeForm_Click(sender As Object, e As EventArgs) Handles btnEmployeeForm.Click


        Dim maleemployee As Male_employee
        Dim femaleemployee As Female_employee
        Select Case genderofferedjob
            Case "male"

                maleemployee = TryCast(workertype(count), Male_employee)
                If Not (maleemployee Is Nothing) Then
                    txtEmployeeform.Text = maleemployee.Displayemployeeform

                End If

            Case "female"

                femaleemployee = TryCast(workertype(count), Female_employee)
                If Not (femaleemployee Is Nothing) Then
                    txtEmployeeform.Text = femaleemployee.Displayemployeeform
                End If
        End Select



    End Sub

    Private Sub btnFileSave_Click(sender As Object, e As EventArgs) Handles btnFileSave.Click
        'saving the best candidatesinfo into files

        FileStream = New FileStream(employeeinfofile, FileMode.Create, FileAccess.Write)
        BinaryFormatter = New BinaryFormatter()

        For employee As Integer = 1 To 2
            'incase there is nothing in the workertype array, an if not(worktype(e) is nothing) statement is used
            'we
            If Not (workertype(employee) Is Nothing) Then
                BinaryFormatter.Serialize(FileStream, workertype(employee))
            End If
        Next employee
        FileStream.Close()
        MsgBox("The employee's form has been saved to the company files")

    End Sub

    Private Sub btnemployeenumbers_Click(sender As Object, e As EventArgs) Handles btnemployeenumbers.Click
        ' increasing the number of the gender given the job opportunity 
        txtjoboffering.Clear()
        txtEmployeeform.Clear()
        If genderofferedjob = "Male" Then
            nmaleemployees += 1
        ElseIf genderofferedjob = "Female" Then

            nfemaleemployees += 1

        End If

        txtemployeenumbers.Text = "Current numbers of male and female employees" & Environment.NewLine
            txtemployeenumbers.Text &= "Males count: " & CStr(nmaleemployees) & Environment.NewLine
        txtemployeenumbers.Text &= "Females count: " & CStr(nfemaleemployees)

    End Sub
End Class
