' Schusswaffenberechnung dient der Berechnung der des arithmetischen Mittel der Distanzen der einzelnen Schüsse vom Gruppenmittelpunkt bei Schusswaffenversuchen.
' Die Formel für die Berechnung wurde entnommen aus "Studien zum Schusswaffeneinsatz: Schießen", Herausgegeben von Clemens Lorei, erschienen im Verlag für Polizeiwissenschaften.
'    Copyright(C) 2016 Michael Pütz, E-Mail: software@mpuetzonline.de

'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.

'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.

'    You should have received a copy Of the GNU General Public License
'    along with this program.  If Not, see < http: //www.gnu.org/licenses/>.

'____________________________________________________________________________

Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading
Imports System.Resources

Public Class Form1
    Private x As Double
    Private y As Double
    Private mwx As Double
    Private mwy As Double
    Private cs As Object
    Private c As Integer
    Private xxx As Integer = "0"
    Private message As String
    Private result As Double
    Private xpart As Double
    Private ypart As Double
    Private sqrtxy As Double
    Private mb As Object
    Private jump As Boolean
    Private showonly As Boolean = False
    Private LocRM As New ResourceManager("Schussberechnung.Resources", GetType(Form1).Assembly)
    ' When the Form loads it asks for all relevant informations to do the first calculation
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' xxx is a variable which is used to keep the loop going until the desired information was entered
        While xxx = "0"
Line1:
            ' creates an InputBox which asks for the count of shots
            cs = InputBox(LocRM.GetString("strEnterShots"), LocRM.GetString("strTitleShots")).ToString
            ' checks, whether the InputBox was Canceled or left blank
            If cs = "" Or cs = "0" Then
                ' if the InputBox was left blank or canceled, it calls a method to check whether the user wants to try again,
                'go to the main menu or exit the program
                go_on()
                ' jump is used to determine, whether the user wants to skip the input. Showonly is used to determine,
                ' whether the user wants to see the main menu.
                If jump = True And showonly = False Then
                    xxx = "1"
                    Me.Close()
                    GoTo LastLine
                ElseIf jump = False And showonly = False Then
                    GoTo Line1
                ElseIf jump = True And showonly = True Then
                    CheckBox1.Checked = False
                    GoTo LastLine
                Else
                    MsgBox("Wow, you got three options and answered with a fourth... How did you do that???", MsgBoxStyle.Exclamation)
                End If
            Else
                ' checks whether there are alphanumeric symbols inserted. If so, it displays a message, else it accepts the inserted value as c (count of shots)
                If Not IsNumeric(cs.ToString) Then
                    MsgBox(LocRM.GetString("NumericInputOnly"), MsgBoxStyle.Exclamation, LocRM.GetString("NumericInputOnlyTitle"))
                Else
                    c = cs.ToString
                    xxx = "1"
                End If
            End If
        End While
        ' If the count of shots was entered correctly, it starts the calculating function
        rechnen()
LastLine:
    End Sub

    Private Sub rechnen()
        x = x
        y = 0
        mwx = 0
        mwy = 0
        xxx = 0
        result = 0
        xpart = 0
        ypart = 0
        sqrtxy = 0
        message = ""
        ' checks whether the File "Berechnung.txt" exists in the main folder.This file is used to store the variables, so the program is more flexible
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Berechnung.txt") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Berechnung.txt")
        ' starts a loop to determine the x-values to each shot. If the user clicks "Cancel" the main menu will show and all values will be deleted.
        For i = 1 To c
Line1:
            message = LocRM.GetString("strEnterXPart1") & i & LocRM.GetString("strEnterXPart2")
            cs = InputBox(message, LocRM.GetString("strTitleX") & i).ToString
            If cs = "" Then
                go_on()
                If jump = True Then
                    GoTo LastLine
                Else
                    GoTo Line1
                End If
            Else
                If Not IsNumeric(cs.ToString) Then
                    MsgBox(LocRM.GetString("NumericInputOnly"), MsgBoxStyle.Exclamation, LocRM.GetString("NumericInputOnlyTitle"))
                Else
                    CSettings.Save("x" & i, cs, Application.StartupPath & "\Berechnung.txt")
                End If
            End If
        Next

        '  starts a loop to determine the y-values to each shot. If the user clicks "Cancel" the main menu will show and all values will be deleted.
        For i = 1 To c
Line2:
            message = LocRM.GetString("strEnterYPart1") & i & LocRM.GetString("strEnterYPart2")
            cs = InputBox(message, LocRM.GetString("strTitleY") & i).ToString
            If cs = "" Then
                go_on()
                If jump = True Then
                    GoTo LastLine
                Else
                    GoTo Line2
                End If
            Else
                If Not IsNumeric(cs.ToString) Then
                    MsgBox(LocRM.GetString("NumericInputOnly"), MsgBoxStyle.Exclamation, LocRM.GetString("NumericInputOnlyTitle"))
                Else
                    CSettings.Save("y" & i, cs, Application.StartupPath & "\Berechnung.txt")
                End If
            End If
        Next

        ' starts a loop to add each x-value to mwx and divide it by the count of shots
        For count As Integer = 1 To c
            x = CSettings.Load("x" & count, Application.StartupPath & "\Berechnung.txt")
            mwx = mwx + x
        Next
        mwx = mwx / c

        ' starts a loop to add each y-value to mwy and divide it by the count of shots
        For count As Integer = 1 To c
            y = CSettings.Load("y" & count, Application.StartupPath & "\Berechnung.txt")
            mwy = mwy + y
        Next
        mwy = mwy / c

        ' starts a loop which substracts the average values form x and y, squares them, adds the result for x and y
        ' and builds the squareroot of this result. Now the results are added.
        For i = 1 To c
            x = CSettings.Load("x" & i, Application.StartupPath & "\Berechnung.txt")
            y = CSettings.Load("y" & i, Application.StartupPath & "\Berechnung.txt")
            xpart = (x - mwx)
            xpart = xpart * xpart
            ypart = (y - mwy)
            ypart = ypart * ypart
            sqrtxy = Math.Sqrt(xpart + ypart)
            result = result + sqrtxy
        Next
        ' the results are divided by the count of shots and the result is shown in the TextBox.
        result = result / c
        TBErg.Text = result
LastLine:
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' resets the program. If the checkbox to keep the count of shots is checked, it will move straight forward to the
        ' calculating function. Else it asks for the count of shots like it does when the Form is loaded.
        If CheckBox1.Checked = True Then
        Else
            cs = 0
            c = 0
Line3:
            While xxx = "0"
                cs = InputBox(LocRM.GetString("strEnterShots"), LocRM.GetString("strTitleShots")).ToString
                If cs = "" Or cs = "0" Then
                    go_on()
                    If jump = True Then
                        GoTo LastLine
                    Else
                        GoTo Line3
                    End If
                Else
                    If Not IsNumeric(cs.ToString) Then
                        MsgBox(LocRM.GetString("NumericInputOnly"), MsgBoxStyle.Exclamation, LocRM.GetString("NumericInputOnlyTitle"))
                    Else
                        c = cs.ToString
                        xxx = "1"
                    End If
                End If
            End While
        End If
        rechnen()
LastLine:
    End Sub

    Private Sub go_on()
        ' Asks the user when he has canceled the InputBox, whether he wants to Close the program (yes),
        ' see the InputBox again (No) or just wants to see the Main Menu (Cancel). When Cancel is pressed,
        ' all values will be resetted.
        mb = MsgBox(LocRM.GetString("strNotValid"), MsgBoxStyle.YesNoCancel, LocRM.GetString("strTitleNotValid")).ToString
        If mb = "Yes" Then
            jump = True
            Me.Close()
        ElseIf mb = "No" Then
            jump = False
        ElseIf mb = "Cancel" Then
            x = x
            y = 0
            mwx = 0
            mwy = 0
            xxx = 0
            result = 0
            xpart = 0
            ypart = 0
            sqrtxy = 0
            message = ""
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Berechnung.txt") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Berechnung.txt")
            jump = True
            showonly = True
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Berechnung.txt") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Berechnung.txt")
    End Sub

    Private Sub ReportABugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportABugToolStripMenuItem.Click
        ' Shows a window, which desplays a website containing the bug-report-program.
        BugReport.ShowDialog()
    End Sub

    Private Sub ÜberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜberToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Shows a window, which desplays a website containing the wiki-entry.
        Help.ShowDialog()
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        ' Shows a window, which desplays a website containing the bug-report-program, showing the changelogs.
        Changelog.ShowDialog()
    End Sub

    Private Sub ForumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForumToolStripMenuItem.Click
        Forum.ShowDialog()
    End Sub

    Private Sub NewsletterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewsletterToolStripMenuItem.Click
        Newsletter.ShowDialog()
    End Sub
End Class
