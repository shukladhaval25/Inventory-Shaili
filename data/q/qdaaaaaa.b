Public Class FrmUser
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblPin As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents grpUser As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtUserId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbldesg As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents txtUserAdd As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtUserMobile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserPin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserDesg As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserDept As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFormsRights As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpUser = New DevExpress.XtraEditors.GroupControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPass = New DevExpress.XtraEditors.TextEdit
        Me.lblPass = New System.Windows.Forms.Label
        Me.txtUserDesg = New DevExpress.XtraEditors.TextEdit
        Me.txtUserDept = New DevExpress.XtraEditors.TextEdit
        Me.lbldesg = New System.Windows.Forms.Label
        Me.lblDept = New System.Windows.Forms.Label
        Me.txtUserAdd = New DevExpress.XtraEditors.MemoEdit
        Me.txtUserMobile = New DevExpress.XtraEditors.TextEdit
        Me.txtUserPhone = New DevExpress.XtraEditors.TextEdit
        Me.txtUserPin = New DevExpress.XtraEditors.TextEdit
        Me.txtUserCity = New DevExpress.XtraEditors.TextEdit
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit
        Me.lblMobile = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblPin = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblAdd = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.txtUserId = New DevExpress.XtraEditors.TextEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.chkFormsRights = New System.Windows.Forms.CheckedListBox
        CType(Me.grpUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUser.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserDesg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserMobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserPin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUser
        '
        Me.grpUser.Controls.Add(Me.GroupBox1)
        Me.grpUser.Controls.Add(Me.txtPass)
        Me.grpUser.Controls.Add(Me.lblPass)
        Me.grpUser.Controls.Add(Me.txtUserDesg)
        Me.grpUser.Controls.Add(Me.txtUserDept)
        Me.grpUser.Controls.Add(Me.lbldesg)
        Me.grpUser.Controls.Add(Me.lblDept)
        Me.grpUser.Controls.Add(Me.txtUserAdd)
        Me.grpUser.Controls.Add(Me.txtUserMobile)
        Me.grpUser.Controls.Add(Me.txtUserPhone)
        Me.grpUser.Controls.Add(Me.txtUserPin)
        Me.grpUser.Controls.Add(Me.txtUserCity)
        Me.grpUser.Controls.Add(Me.txtUserName)
        Me.grpUser.Controls.Add(Me.lblMobile)
        Me.grpUser.Controls.Add(Me.lblPhone)
        Me.grpUser.Controls.Add(Me.lblPin)
        Me.grpUser.Controls.Add(Me.lblCity)
        Me.grpUser.Controls.Add(Me.lblAdd)
        Me.grpUser.Controls.Add(Me.lblUserName)
        Me.grpUser.Controls.Add(Me.lblUserID)
        Me.grpUser.Controls.Add(Me.txtUserId)
        Me.grpUser.Location = New System.Drawing.Point(8, 8)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(512, 463)
        Me.grpUser.TabIndex = 2
        Me.grpUser.Text = "User Master"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFormsRights)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 212)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Access Rights"
        '
        'txtPass
        '
        Me.txtPass.EditValue = ""
        Me.txtPass.Location = New System.Drawing.Point(328, 29)
        Me.txtPass.Name = "txtPass"
        '
        '
        '
        Me.txtPass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Properties.Appearance.Options.UseFont = True
        Me.txtPass.Properties.MaxLength = 20
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(168, 22)
        Me.txtPass.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(255, 31)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(68, 16)
        Me.lblPass.TabIndex = 14
        Me.lblPass.Text = "Password:"
        '
        'txtUserDesg
        '
        Me.txtUserDesg.EditValue = ""
        Me.txtUserDesg.Location = New System.Drawing.Point(330, 154)
        Me.txtUserDesg.Name = "txtUserDesg"
        '
        '
        '
        Me.txtUserDesg.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserDesg.Properties.Appearance.Options.UseFont = True
        Me.txtUserDesg.Properties.MaxLength = 50
        Me.txtUserDesg.Size = New System.Drawing.Size(168, 22)
        Me.txtUserDesg.TabIndex = 5
        '
        'txtUserDept
        '
        Me.txtUserDept.EditValue = ""
        Me.txtUserDept.Location = New System.Drawing.Point(88, 154)
        Me.txtUserDept.Name = "txtUserDept"
        '
        '
        '
        Me.txtUserDept.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserDept.Properties.Appearance.Options.UseFont = True
        Me.txtUserDept.Properties.MaxLength = 50
        Me.txtUserDept.Size = New System.Drawing.Size(160, 22)
        Me.txtUserDept.TabIndex = 4
        '
        'lbldesg
        '
        Me.lbldesg.AutoSize = True
        Me.lbldesg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesg.Location = New System.Drawing.Point(254, 154)
        Me.lbldesg.Name = "lbldesg"
        Me.lbldesg.Size = New System.Drawing.Size(79, 16)
        Me.lbldesg.TabIndex = 12
        Me.lbldesg.Text = "Designation:"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(11, 154)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(80, 16)
        Me.lblDept.TabIndex = 10
        Me.lblDept.Text = "Department:"
        '
        'txtUserAdd
        '
        Me.txtUserAdd.EditValue = ""
        Me.txtUserAdd.Location = New System.Drawing.Point(88, 89)
        Me.txtUserAdd.Name = "txtUserAdd"
        '
        '
        '
        Me.txtUserAdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAdd.Properties.Appearance.Options.UseFont = True
        Me.txtUserAdd.Size = New System.Drawing.Size(408, 57)
        Me.txtUserAdd.TabIndex = 3
        '
        'txtUserMobile
        '
        Me.txtUserMobile.EditValue = ""
        Me.txtUserMobile.Location = New System.Drawing.Point(330, 216)
        Me.txtUserMobile.Name = "txtUserMobile"
        '
        '
        '
        Me.txtUserMobile.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserMobile.Properties.Appearance.Options.UseFont = True
        Me.txtUserMobile.Properties.MaxLength = 15
        Me.txtUserMobile.Size = New System.Drawing.Size(168, 22)
        Me.txtUserMobile.TabIndex = 9
        '
        'txtUserPhone
        '
        Me.txtUserPhone.EditValue = ""
        Me.txtUserPhone.Location = New System.Drawing.Point(88, 216)
        Me.txtUserPhone.Name = "txtUserPhone"
        '
        '
        '
        Me.txtUserPhone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPhone.Properties.Appearance.Options.UseFont = True
        Me.txtUserPhone.Properties.MaxLength = 15
        Me.txtUserPhone.Size = New System.Drawing.Size(160, 22)
        Me.txtUserPhone.TabIndex = 8
        '
        'txtUserPin
        '
        Me.txtUserPin.EditValue = ""
        Me.txtUserPin.Location = New System.Drawing.Point(330, 184)
        Me.txtUserPin.Name = "txtUserPin"
        '
        '
        '
        Me.txtUserPin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPin.Properties.Appearance.Options.UseFont = True
        Me.txtUserPin.Properties.MaxLength = 10
        Me.txtUserPin.Size = New System.Drawing.Size(168, 22)
        Me.txtUserPin.TabIndex = 7
        '
        'txtUserCity
        '
        Me.txtUserCity.EditValue = ""
        Me.txtUserCity.Location = New System.Drawing.Point(88, 184)
        Me.txtUserCity.Name = "txtUserCity"
        '
        '
        '
        Me.txtUserCity.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserCity.Properties.Appearance.Options.UseFont = True
        Me.txtUserCity.Properties.MaxLength = 50
        Me.txtUserCity.Size = New System.Drawing.Size(160, 22)
        Me.txtUserCity.TabIndex = 6
        '
        'txtUserName
        '
        Me.txtUserName.EditValue = ""
        Me.txtUserName.Location = New System.Drawing.Point(88, 58)
        Me.txtUserName.Name = "txtUserName"
        '
        '
        '
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Properties.MaxLength = 100
        Me.txtUserName.Size = New System.Drawing.Size(408, 22)
        Me.txtUserName.TabIndex = 2
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(254, 216)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(50, 16)
        Me.lblMobile.TabIndex = 8
        Me.lblMobile.Text = "Mobile:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(12, 216)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(48, 16)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone:"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPin.Location = New System.Drawing.Point(254, 184)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(30, 16)
        Me.lblPin.TabIndex = 6
        Me.lblPin.Text = "Pin:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(12, 184)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(34, 16)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City:"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(12, 108)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(62, 16)
        Me.lblAdd.TabIndex = 3
        Me.lblAdd.Text = "Address:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(12, 60)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(46, 16)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "Name:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(11, 31)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(55, 16)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "User ID:"
        '
        'txtUserId
        '
        Me.txtUserId.EditValue = ""
        Me.txtUserId.Location = New System.Drawing.Point(88, 29)
        Me.txtUserId.Name = "txtUserId"
        '
        '
        '
        Me.txtUserId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Properties.Appearance.Options.UseFont = True
        Me.txtUserId.Properties.MaxLength = 15
        Me.txtUserId.Size = New System.Drawing.Size(112, 22)
        Me.txtUserId.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(348, 477)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "&Save"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(429, 477)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 25)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Cancel"
        '
        'chkFormsRights
        '
        Me.chkFormsRights.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chkFormsRights.FormattingEnabled = True
        Me.chkFormsRights.Location = New System.Drawing.Point(6, 20)
        Me.chkFormsRights.Name = "chkFormsRights"
        Me.chkFormsRights.Size = New System.Drawing.Size(485, 191)
        Me.chkFormsRights.TabIndex = 20
        '
        'FrmUser
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(528, 510)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grpUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUser"
        Me.Padding = New System.Windows.Forms.Padding(8, 8, 8, 35)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Master"
        CType(Me.grpUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserDesg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserMobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserPin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public strcheck As String
    Dim strUid As String
    Dim cmbTemp As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

    Private Sub FrmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If strcheck = "Add" Then
                txtUserId.Tag = GetMaxNo("Uid", "Usermaster", "UR", 10)
                SETFORMSRIGHTS()
            ElseIf strcheck = "Edit" Then
                txtUserId.Tag = ModMain.strgridid
                If strGVUserID.ToString <> "UR00000001" Then
                    lblPass.Visible = False
                    txtPass.Visible = False
                End If
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from usermaster where Uid='" & ModMain.strgridid & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                LoadUser()
                dr.Close()
                cmd.Dispose()
                strUid = txtUserId.Text
                SETFORMSRIGHTS()
                CHECKRIGHTS()
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub CHECKRIGHTS()
        Try
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Select formname from user_rights where uid ='" & txtUserId.Tag.Trim & "'"
            dr = cmd.ExecuteReader()
            Do While dr.Read
                For i As Integer = 0 To chkFormsRights.Items.Count - 1
                    If chkFormsRights.Items(i).ToString = dr.Item(0).ToString Then
                        chkFormsRights.SetItemChecked(i, True)
                    End If
                Next
            Loop
            chkFormsRights.Update()
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub SETFORMSRIGHTS()
        Try
            'cmd = New OleDb.OleDbCommand
            Dim ds As New DataSet
            Dim da As New OleDb.OleDbDataAdapter("Select FORMNAME as [Form Name] FROM forms_info order by formname", conn)
            da.Fill(ds)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                chkFormsRights.Items.Add(ds.Tables(0).Rows(i).Item(0).ToString)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If ValidateUser() = False Then
            Exit Sub
        End If
        Try
            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                Try
                    cmd.CommandText = "Select count(*) from usermaster"
                    cmd.Connection = conn
                    If cmd.ExecuteScalar() >= LicenseCount Then
                        MessageBox.Show("You can not save more user because you have only " + LicenseCount + " user license. Please buy more user license if you want.", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    ElseIf IsTempLicense Then
                        MessageBox.Show("You have trail version. In trail version you can not create new users", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    cmd.Transaction = conn.BeginTransaction
                    cmd.CommandText = "insert into usermaster(uid,userid,username,userdepartment,userdesignation,userAdd,usercity,userPin,userphone,usermobile,Pass)" & _
                    "values('" & txtUserId.Tag & "','" & Replace(txtUserId.Text.Trim, "'", "''") & "','" & Replace(txtUserName.Text.Trim, "'", "''") & "','" & Replace(txtUserDept.Text.Trim, "'", "''") & _
                    "','" & Replace(txtUserDesg.Text.Trim, "'", "''") & "','" & Replace(txtUserAdd.Text.Trim, "'", "''") & "','" & _
                    Replace(txtUserCity.Text.Trim, "'", "''") & "'," & Replace(txtUserPin.Text.Trim, "'", "''") & ",'" & _
                    Replace(txtUserPhone.Text.Trim, "'", "''") & "','" & Replace(txtUserMobile.Text.Trim, "'", "''") & "','" & txtPass.Text.Trim & "')"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()
                    For i As Integer = 0 To chkFormsRights.CheckedItems.Count - 1
                        cmd.CommandText = "Insert into user_rights values('" & txtUserId.Tag & "','" & chkFormsRights.CheckedItems.Item(i).ToString & "')"
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.Transaction.Commit()

                    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch
                    cmd.Transaction.Rollback()
                End Try
            ElseIf strcheck = "Edit" Then
                'If strGVUserID = ModMain.strgridid.ToString Or strGVUserID = "UR00000001" Then
                cmd = New OleDb.OleDbCommand
                cmd.Transaction = conn.BeginTransaction
                Try
                    cmd.CommandText = "update usermaster set userid='" & Replace(txtUserId.Text.Trim, "'", "''") & _
                    "',pass ='" & Replace(txtPass.Text.Trim, "'", "''") & "',username='" & Replace(txtUserName.Text.Trim, "'", "''") & "',userdepartment='" & Replace(txtUserDept.Text.Trim, "'", "''") & _
                    "',userdesignation='" & Replace(txtUserDesg.Text.Trim, "'", "''") & "',userAdd='" & Replace(txtUserAdd.Text.Trim, "'", "''") & _
                    "',usercity='" & Replace(txtUserCity.Text.Trim, "'", "''") & "',userPin=" & Replace(txtUserPin.Text.Trim, "'", "''") & _
                    ",userphone='" & Replace(txtUserPhone.Text.Trim, "'", "''") & "',usermobile='" & Replace(txtUserMobile.Text.Trim, "'", "''") & _
                    "' where uid='" & txtUserId.Tag & "'"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "Delete from user_rights where uid ='" & txtUserId.Tag & "'"
                    cmd.ExecuteNonQuery()

                    For i As Integer = 0 To chkFormsRights.CheckedItems.Count - 1
                        cmd.CommandText = "Insert into user_rights values('" & txtUserId.Tag & "','" & chkFormsRights.CheckedItems.Item(i).ToString & "')"
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.Transaction.Commit()

                    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch
                    cmd.Transaction.Rollback()
                End Try
                'Else
                '    DevExpress.XtraEditors.XtraMessageBox.Show("You do not have permission to change other user's data. Please contect to your Administrator.")
                'End If
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub LoadUser()

        Try
            ' System Userid
            If IsDBNull(dr("Uid").ToString) = True Then
                txtUserId.Tag = ""
            Else
                txtUserId.Tag = dr("Uid").ToString
            End If

            'User Id 
            If IsDBNull(dr("Userid").ToString) = True Then
                txtUserId.Text = ""
            Else
                txtUserId.Text = dr("userid").ToString
            End If

            'User Name
            If IsDBNull(dr("Username").ToString) = True Then
                txtUserName.Text = ""
            Else
                txtUserName.Text = dr("Username")
            End If

            'Password
            If IsDBNull(dr("PASS").ToString) = True Then
                txtPass.Text = ""
            Else
                txtPass.Text = dr("PASS").ToString
            End If

            'User Address
            If IsDBNull(dr("UserAdd").ToString) = True Then
                txtUserAdd.Text = ""
            Else
                txtUserAdd.Text = dr("UserAdd").ToString
            End If

            'User Department
            If IsDBNull(dr("UserDepartment").ToString) = True Then
                txtUserDept.Text = ""
            Else
                txtUserDept.Text = dr("UserDepartment").ToString
            End If

            'User Designation
            If IsDBNull(dr("UserDesignation").ToString) = True Then
                txtUserDesg.Text = ""
            Else
                txtUserDesg.Text = dr("UserDesignation").ToString
            End If

            'User City
            If IsDBNull(dr("UserCity").ToString) = True Then
                txtUserCity.Text = ""
            Else
                txtUserCity.Text = dr("UserCity").ToString
            End If

            ' User pin
            If IsDBNull(dr("UserPin").ToString) = True Then
                txtUserPin.Text = ""
            Else
                txtUserPin.Text = dr("UserPin").ToString
            End If

            ' User phone
            If IsDBNull(dr("UserPhone").ToString) = True Then
                txtUserPhone.Text = ""
            Else
                txtUserPhone.Text = dr("UserPhone").ToString
            End If

            ' User Mobile
            If IsDBNull(dr("UserMobile").ToString) = True Then
                txtUserMobile.Text = ""
            Else
                txtUserMobile.Text = dr("UserMobile").ToString
            End If

            dr.Close()

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Function ValidateUser() As Boolean
        Dim id As String
        Try
            If txtUserPin.Text.Trim = "" Then
                txtUserPin.Text = "0"
            End If

            'User Id 
            If txtUserId.Text.Trim = "" = True Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter User Id", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUserId.Select()
                ValidateUser = False
                Exit Function
            End If
            cmd = New OleDb.OleDbCommand
            If strcheck = "Add" Then
                cmd.CommandText = "select Uid from Usermaster where Userid='" & txtUserId.Text.Trim & "'"
            ElseIf strcheck = "Edit" Then
                cmd.CommandText = "select Uid from Usermaster where Userid='" & txtUserId.Text.Trim & "' and Userid <> '" & strUid & "'"
            End If

            cmd.Connection = conn
            id = cmd.ExecuteScalar
            If id <> "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "User Id Already Exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUserName.Select()
                ValidateUser = False
                Exit Function
            End If

            'User Name
            If txtUserName.Text.Trim = "" = True Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter User Name", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ValidateUser = False
                txtUserName.Select()
                Exit Function
            End If
            cmd = New OleDb.OleDbCommand
            If strcheck = "Add" Then
                cmd.CommandText = "select Uid from UserMaster where UserName='" & txtUserName.Text & "'"
            ElseIf strcheck = "Edit" Then
                cmd.CommandText = "select Uid from UserMaster where UserName='" & txtUserName.Text.Trim & "' and Uid <> '" & txtUserId.Tag & "'"
            End If

            cmd.Connection = conn
            id = cmd.ExecuteScalar
            If id <> "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "User Name Already Exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUserName.Select()
                ValidateUser = False
                Exit Function
            End If

            ValidateUser = True
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If

        End Try
    End Function
    Private Sub txtUserMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserMobile.KeyPress
        e.Handled = IsPhoneNumber(e.KeyChar)
    End Sub

    Private Sub txtUserPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserPhone.KeyPress
        e.Handled = IsPhoneNumber(e.KeyChar)
    End Sub

    Private Sub txtUserPin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserPin.KeyPress
        e.Handled = IsNumber(e.KeyChar)
    End Sub


End Class

