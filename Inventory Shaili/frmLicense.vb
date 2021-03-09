Public Class frmLicense 

    Dim license As New License
    Dim cryptography As CryptographyService
    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Dim key As String = TextEdit1.Text + "-" + TextEdit2.Text + "-" + TextEdit3.Text + "-" + TextEdit4.Text
        Dim licenseCount As Integer
        If (license.ValidateLicenseKey(key) = False) Then
            MessageBox.Show("Invalid license key. Please enter valid license key.", "License", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            licenseCount = license.GetLicense()
            cryptography = New CryptographyService()
            Dim strencryptedText As String = cryptography.Encrypt(key)
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Select count(*) from License"
            If cmd.ExecuteScalar() = 0 Then
                cmd.CommandText = "insert into License (InstallationDate,LicenseKey) values ('" + Date.Now.Date + "','" + strencryptedText + "')"
            Else
                cmd.CommandText = "Update license set LicenseKey ='" & strencryptedText & "',InstallationDate = '" + Date.Now.Date + "'"
            End If
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            licenseCount = licenseCount
            IsTempLicense = False
            MessageBox.Show("License apply successfully", "License", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class