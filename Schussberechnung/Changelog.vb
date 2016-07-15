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

Imports System.Resources

Public Class Changelog
    Private LocRM As New ResourceManager("Schussberechnung.Resources", GetType(Changelog).Assembly)

    Private Sub Changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WebBrowser1.Navigate("http://bugs.mpts3.selfhost.eu/changelog_page.php?project=schussberechnung&version=" & My.Application.Info.Version.ToString)
        MsgBox(LocRM.GetString("strChangelog"), MsgBoxStyle.Information, "Hinweis")
    End Sub

End Class