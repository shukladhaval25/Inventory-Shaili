Public Class frmCompany
    Inherits DevExpress.XtraEditors.XtraForm
    Public strCheck As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCompName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAdd1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtState As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCountry As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtemail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdcancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtGST As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCST As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtFax = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtemail = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCountry = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPin = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtState = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCity = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAdd2 = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAdd1 = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCompName = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.txtCST = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtGST = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtGST)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.txtCST)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txtFax)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txtPhone)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txtemail)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.txtCountry)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txtPin)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txtState)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txtCity)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txtAdd2)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txtAdd1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtCompName)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(400, 229)
        Me.GroupControl1.TabIndex = 0
        '
        'txtFax
        '
        Me.txtFax.EditValue = ""
        Me.txtFax.Location = New System.Drawing.Point(272, 176)
        Me.txtFax.Name = "txtFax"
        '
        '
        '
        Me.txtFax.Properties.MaxLength = 15
        Me.txtFax.Size = New System.Drawing.Size(120, 20)
        Me.txtFax.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(224, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Fax:"
        '
        'txtPhone
        '
        Me.txtPhone.EditValue = ""
        Me.txtPhone.Location = New System.Drawing.Point(96, 176)
        Me.txtPhone.Name = "txtPhone"
        '
        '
        '
        Me.txtPhone.Properties.MaxLength = 15
        Me.txtPhone.Size = New System.Drawing.Size(120, 20)
        Me.txtPhone.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Phone:"
        '
        'txtemail
        '
        Me.txtemail.EditValue = ""
        Me.txtemail.Location = New System.Drawing.Point(96, 152)
        Me.txtemail.Name = "txtemail"
        '
        '
        '
        Me.txtemail.Properties.MaxLength = 50
        Me.txtemail.Size = New System.Drawing.Size(296, 20)
        Me.txtemail.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email:"
        '
        'txtCountry
        '
        Me.txtCountry.EditValue = ""
        Me.txtCountry.Location = New System.Drawing.Point(272, 128)
        Me.txtCountry.Name = "txtCountry"
        '
        '
        '
        Me.txtCountry.Properties.MaxLength = 15
        Me.txtCountry.Size = New System.Drawing.Size(120, 20)
        Me.txtCountry.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(224, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Country:"
        '
        'txtPin
        '
        Me.txtPin.EditValue = ""
        Me.txtPin.Location = New System.Drawing.Point(96, 128)
        Me.txtPin.Name = "txtPin"
        '
        '
        '
        Me.txtPin.Properties.MaxLength = 15
        Me.txtPin.Size = New System.Drawing.Size(120, 20)
        Me.txtPin.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pincode:"
        '
        'txtState
        '
        Me.txtState.EditValue = ""
        Me.txtState.Location = New System.Drawing.Point(272, 104)
        Me.txtState.Name = "txtState"
        '
        '
        '
        Me.txtState.Properties.MaxLength = 15
        Me.txtState.Size = New System.Drawing.Size(120, 20)
        Me.txtState.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(224, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "State:"
        '
        'txtCity
        '
        Me.txtCity.EditValue = ""
        Me.txtCity.Location = New System.Drawing.Point(96, 104)
        Me.txtCity.Name = "txtCity"
        '
        '
        '
        Me.txtCity.Properties.MaxLength = 15
        Me.txtCity.Size = New System.Drawing.Size(120, 20)
        Me.txtCity.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "City:"
        '
        'txtAdd2
        '
        Me.txtAdd2.EditValue = ""
        Me.txtAdd2.Location = New System.Drawing.Point(96, 80)
        Me.txtAdd2.Name = "txtAdd2"
        '
        '
        '
        Me.txtAdd2.Properties.MaxLength = 50
        Me.txtAdd2.Size = New System.Drawing.Size(296, 20)
        Me.txtAdd2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Address 2:"
        '
        'txtAdd1
        '
        Me.txtAdd1.EditValue = ""
        Me.txtAdd1.Location = New System.Drawing.Point(96, 56)
        Me.txtAdd1.Name = "txtAdd1"
        '
        '
        '
        Me.txtAdd1.Properties.MaxLength = 50
        Me.txtAdd1.Size = New System.Drawing.Size(296, 20)
        Me.txtAdd1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Address 1:"
        '
        'txtCompName
        '
        Me.txtCompName.EditValue = ""
        Me.txtCompName.Location = New System.Drawing.Point(96, 32)
        Me.txtCompName.Name = "txtCompName"
        '
        '
        '
        Me.txtCompName.Properties.MaxLength = 50
        Me.txtCompName.Size = New System.Drawing.Size(296, 20)
        Me.txtCompName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Company Name:"
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(336, 235)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 14
        Me.cmdcancel.Text = "&Cancel"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(256, 235)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 13
        Me.cmdsave.Text = "&Save"
        '
        'txtCST
        '
        Me.txtCST.EditValue = ""
        Me.txtCST.Location = New System.Drawing.Point(96, 200)
        Me.txtCST.Name = "txtCST"
        '
        '
        '
        Me.txtCST.Properties.MaxLength = 15
        Me.txtCST.Size = New System.Drawing.Size(120, 20)
        Me.txtCST.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "CST No:"
        '
        'txtGST
        '
        Me.txtGST.EditValue = ""
        Me.txtGST.Location = New System.Drawing.Point(272, 200)
        Me.txtGST.Name = "txtGST"
        '
        '
        '
        Me.txtGST.Properties.MaxLength = 15
        Me.txtGST.Size = New System.Drawing.Size(120, 20)
        Me.txtGST.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(222, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "GST No:"
        '
        'frmCompany
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(418, 265)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company Master"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If strCheck.Trim = "Add" Then
                txtCompName.Tag = GetMaxNo("CompanyID", "CompanyMaster", "", 3)
            ElseIf strCheck.Trim = "Edit" Then
                txtCompName.Tag = ModMain.strgridid
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from CompanyMaster where CompanyId ='" & ModMain.strgridid & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub bind_data()
        Try
            If IsDBNull(dr.Item("CompanyID")) = False Then
                txtCompName.Tag = dr.Item("CompanyID")
            End If

            If IsDBNull(dr.Item("CompanyName")) = True Then
                txtCompName.Text = ""
            Else
                txtCompName.Text = dr.Item("CompanyName")
            End If

            If IsDBNull(dr.Item("Add1")) = True Then
                txtAdd1.Text = ""
            Else
                txtAdd1.Text = dr.Item("Add1")
            End If

            If IsDBNull(dr.Item("Add2")) = True Then
                txtAdd2.Text = ""
            Else
                txtAdd2.Text = dr.Item("Add2")
            End If

            If IsDBNull(dr.Item("City")) = True Then
                txtCity.Text = ""
            Else
                txtCity.Text = dr.Item("City")
            End If

            If IsDBNull(dr.Item("State")) = True Then
                txtState.Text = ""
            Else
                txtState.Text = dr.Item("State")
            End If

            If IsDBNull(dr.Item("Pincode")) = True Then
                txtPin.Text = ""
            Else
                txtPin.Text = dr.Item("Pincode")
            End If

            If IsDBNull(dr.Item("Country")) = True Then
                txtCountry.Text = ""
            Else
                txtCountry.Text = dr.Item("Country")
            End If

            If IsDBNull(dr.Item("Email")) = True Then
                txtemail.Text = ""
            Else
                txtemail.Text = dr.Item("Email")
            End If

            If IsDBNull(dr.Item("Phone")) = True Then
                txtPhone.Text = ""
            Else
                txtPhone.Text = dr.Item("Phone")
            End If

            If IsDBNull(dr.Item("Fax")) = True Then
                txtFax.Text = ""
            Else
                txtFax.Text = dr.Item("Fax")
            End If
            If IsDBNull(dr.Item("CST")) = True Then
                txtCST.Text = ""
            Else
                txtCST.Text = dr.Item("CST")
            End If

            If IsDBNull(dr.Item("GST")) = True Then
                txtGST.Text = ""
            Else
                txtGST.Text = dr.Item("GST")
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If strCheck.Trim = "Add" Then
                cmd = New OleDb.OleDbCommand("insert into CompanyMaster values ( '1','" & Replace(txtCompName.Text.Trim, "'", "''") & "', '" _
                        & Replace(txtAdd1.Text, "'", "''") & "','" & Replace(txtAdd2.Text, "'", "''") & "','" & Replace(txtCity.Text, "'", "''") & "','" _
                        & Replace(txtState.Text, "'", "''") & "','" & txtPin.Text.Trim & "','" & txtCountry.Text.Trim & "','" & txtemail.Text.Trim & "','" _
                        & txtPhone.Text & "','" & txtFax.Text & "','" & txtCST.Text.Trim & "','" & txtGST.Text.Trim & "')")
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            ElseIf strCheck.Trim = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "Update CompanyMaster set " _
                    & " CompanyName ='" & Replace(txtCompName.Text, "'", "''") & "',Add1 ='" & Replace(txtAdd1.Text, "'", "''") & "'," _
                    & " Add2 ='" & Replace(txtAdd2.Text, "'", "''") & "',City ='" & txtCity.Text & "'," _
                    & " State ='" & txtState.Text & "', Pincode ='" & txtPin.Text.Trim & "', Country ='" & txtCountry.Text & "'," _
                    & " Email ='" & txtemail.Text & "', Phone ='" & txtPhone.Text & "',Fax ='" & txtFax.Text & "',CST ='" & txtCST.Text.Trim & "',GST ='" & txtGST.Text.Trim & "' where CompanyId ='" & txtCompName.Tag & "'"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            If Err.Number = 5 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("You can not add more then one company name.", "Company Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Err.Clear()
            End If
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class

