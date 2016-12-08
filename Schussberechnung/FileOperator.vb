Imports System.IO
Public Class FileOperator
    Public Shared Function Load(ByVal filePath As String, ByVal searchString As String)
        Try
            Dim strR As StreamReader = New StreamReader(filePath)
            Dim line As String
            searchString = searchString & "="
            Dim length As Integer = searchString.Length
            Dim id As String

            If File.Exists(filePath) = False Then
                Exit Function
            End If

            Do
                line = strR.ReadLine
                id = Mid(line, 1, length)
                If id = searchString Then
                    Dim result As String = Mid(line, length + 1, line.Length)
                    strR.Dispose()
                    strR.Close()
                    Return result
                    Exit Function
                End If
            Loop Until line = Nothing
            strR.Dispose()
            strR.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
            Exit Function
        End Try
    End Function

    Public Shared Function Delete(ByVal filePath As String, ByVal searchString As String, Optional ByVal FileExists As Boolean = False)
        Try
            Dim deleteline As String
            Dim deleteID As String
            Dim lst As New List(Of String)
            searchString = searchString & "="
            Dim deletelength As Integer = searchString.Length
            Dim keyfound As Boolean

            If File.Exists(filePath) = False Then
                Exit Function
            End If

            If FileExists = False Then

                Try
                Dim strR As StreamReader = New StreamReader(filePath)

                Do
                    deleteline = strR.ReadLine
                    deleteID = Mid(deleteline, 1, deletelength)
                    If deleteID = searchString Then
                        keyfound = True
                        Exit Do
                    End If
                Loop Until deleteline = Nothing

                strR.Dispose()
                strR.Close()

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
                Exit Function

            End Try

            End If

            If keyfound = True Or FileExists = True Then
                Dim strR As StreamReader = New StreamReader(filePath)

                Do
                    deleteline = strR.ReadLine
                    deleteID = Mid(deleteline, 1, deletelength)

                    If deleteID = searchString Then
                    Else
                        lst.Add(deleteline)
                    End If

                Loop Until deleteline = Nothing
                strR.Dispose()
                strR.Close()

                Dim arr2 As String() = lst.ToArray()
                Using sw As StreamWriter = New StreamWriter(filePath)
                    sw.Write(Join(arr2, vbCrLf))
                End Using

            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
            Return 1
        End Try

    End Function

    Public Shared Function Save(ByVal filePath As String, ByVal id As String, ByVal StoreString As String)
        Dim storeID = id & "="
        StoreString = storeID & StoreString
        Dim line As String
        Dim length As Integer = storeID.Length
        Dim compID As String
        Dim keyfound As Boolean

        If File.Exists(filePath) = False Then
            Dim fs As FileStream = File.Create(filePath)
            fs.Close()
        End If

        Try
            Dim strR As StreamReader = New StreamReader(filePath)

            Do
                line = strR.ReadLine
                compID = Mid(line, 1, length)
                If compID = storeID Then
                    keyfound = True
                    Exit Do
                End If
            Loop Until line = Nothing

            strR.Dispose()
            strR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
            Exit Function

        End Try

        If keyfound = False Then
            Dim strw As StreamWriter
            strw = File.AppendText(filePath)
            strw.WriteLine(StoreString)
            strw.Dispose()
            strw.Close()
        Else
            FileOperator.Delete(filePath, id, True)
            Dim strw As StreamWriter
            strw = File.AppendText(filePath)
            strw.WriteLine(StoreString)
            strw.Dispose()
            strw.Close()
        End If
    End Function
End Class
