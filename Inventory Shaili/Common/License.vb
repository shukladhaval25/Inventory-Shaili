Public Class License
    Private _key As String
    Private _licenseIssue As Integer
    Dim comparelicenseKey() As String = {"S", "X", "R", "I"}
    Public Function ValidateLicenseKey(ByVal key As String) As Boolean
        _key = key
        Return validateLicenseKey()
    End Function

    Private Function validateLicenseKey() As Boolean
        Dim keys() As String = _key.Split("-")
        Const charval As String = "X"

        Dim lstKeysCompare As New List(Of String)(comparelicenseKey)
        Dim compareCount As Integer = 0
        For Each key As String In keys
            For Each individualkey As String In lstKeysCompare
                If (key.Contains(individualkey)) Then
                    If (individualkey = charval) Then
                        _licenseIssue = Convert.ToInt32(key.Substring(key.IndexOf(charval) + 1))
                    End If
                    compareCount = compareCount + 1
                    lstKeysCompare.Remove(individualkey)
                    Exit For
                End If
            Next
        Next
        If (_licenseIssue > 0 AndAlso compareCount = comparelicenseKey.Length) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetLicense() As Integer
        Return _licenseIssue
    End Function

End Class

