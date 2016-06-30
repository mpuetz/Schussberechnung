'All credits go to Frozen, Function is provided at http://www.vbforums.com/showthread.php?384344-VB-Save-Load-settings-to-from-file
' CSettings is used to save and load variables to or from a file.
Public Class CSettings
    Public Shared Function Load(ByVal lpKey As String, ByVal lpPath As String)
        Dim Reader() As String = IO.File.ReadAllLines(lpPath)

        For i As Integer = 0 To Reader.Length - 1
            If Reader(i).StartsWith(";") Or Reader(i).StartsWith("#") Or Reader(i).StartsWith("//") Then Continue For
            If Reader(i).StartsWith(lpKey) Then
                Dim Splitter() As Object
                Splitter = Split(Reader(i), "=")
                Return Splitter(1).ToString
            End If
        Next
        Return 0
    End Function

    Public Shared Function Save(ByVal lpKey As String, ByVal lpValue As String, ByVal lpPath As String)
        If IO.File.Exists(lpPath) = False Then
            Dim FileSys As System.IO.FileStream
            FileSys = System.IO.File.Create(lpPath)
            FileSys.Close()
        End If

        Dim Reader() As String = IO.File.ReadAllLines(lpPath)
        Dim Writer As New System.IO.StreamWriter(lpPath)
        Const vbSpace As String = "="
        Dim KeyFound As Boolean

        If Reader.Length = 0 Then
            KeyFound = False
        End If

        For i As Integer = 0 To Reader.Length - 1
            If Reader(i).StartsWith(lpKey) Then
                KeyFound = True
                Exit For
            End If
        Next

        If KeyFound = False Then
            For i As Integer = 0 To Reader.Length - 1
                Writer.WriteLine(Reader(i))
            Next
            Writer.WriteLine(lpKey & vbSpace & lpValue)
        Else
            For i As Integer = 0 To Reader.Length - 1
                If Reader(i).StartsWith(lpKey) Then
                    Writer.WriteLine(lpKey & vbSpace & lpValue)
                End If
            Next
        End If
        Writer.Dispose()
        Writer.Close()
        Return 0
    End Function

    Public Shared Function Remove(ByVal lpKey As String, ByVal lpPath As String)
        Dim Reader() As String = System.IO.File.ReadAllLines(lpPath)
        Dim Writer As New System.IO.StreamWriter(lpPath)

        For i As Integer = 0 To Reader.Length - 1
            If Reader(i).StartsWith(lpKey) = False Then
                Writer.WriteLine(Reader(i))
            End If
        Next
        Writer.Dispose()
        Writer.Close()
        Return 0
    End Function
End Class