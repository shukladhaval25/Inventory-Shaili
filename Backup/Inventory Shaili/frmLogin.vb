Public Class frmLogin
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtUserId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicLogin As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PicLogin = New DevExpress.XtraEditors.PictureEdit
        Me.txtPass = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.txtUserId = New DevExpress.XtraEditors.TextEdit
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PicLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PicLogin)
        Me.GroupControl1.Controls.Add(Me.txtPass)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lblUserID)
        Me.GroupControl1.Controls.Add(Me.txtUserId)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(336, 109)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "User Login"
        '
        'PicLogin
        '
        Me.PicLogin.EditValue = CType(resources.GetObject("PicLogin.EditValue"), Object)
        Me.PicLogin.Location = New System.Drawing.Point(8, 24)
        Me.PicLogin.Name = "PicLogin"
        '
        'PicLogin.Properties
        '
        Me.PicLogin.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PicLogin.Properties.Appearance.Options.UseBackColor = True
        Me.PicLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PicLogin.Properties.ShowMenu = False
        Me.PicLogin.Size = New System.Drawing.Size(80, 80)
        Me.PicLogin.TabIndex = 17
        '
        'txtPass
        '
        Me.txtPass.EditValue = ""
        Me.txtPass.Location = New System.Drawing.Point(160, 72)
        Me.txtPass.Name = "txtPass"
        '
        'txtPass.Properties
        '
        Me.txtPass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Properties.Appearance.Options.UseFont = True
        Me.txtPass.Properties.MaxLength = 20
        Me.txtPass.Properties.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(168, 22)
        Me.txtPass.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Password:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(96, 40)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(54, 19)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "User ID:"
        '
        'txtUserId
        '
        Me.txtUserId.EditValue = ""
        Me.txtUserId.Location = New System.Drawing.Point(160, 40)
        Me.txtUserId.Name = "txtUserId"
        '
        'txtUserId.Properties
        '
        Me.txtUserId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Properties.Appearance.Options.UseFont = True
        Me.txtUserId.Properties.MaxLength = 15
        Me.txtUserId.Size = New System.Drawing.Size(168, 22)
        Me.txtUserId.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(168, 120)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "&Login"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(248, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(354, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PicLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            If CheckLogin() = True Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Select CurrentYear from CY"
                strCY = cmd.ExecuteScalar
                cmd.Dispose()
                myMain = New FrmMain
                myLogin.Close()
                myLogin.Dispose()
                myMain.ShowDialog()
            Else

            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Function CheckLogin() As Boolean
        Try
            If txtUserId.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Enter user name and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Dim blnFlg As Boolean = False
            Dim DRead As OleDb.OleDbDataReader
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT Count(UserMaster.Uid) AS CountOfUid, UserMaster.Uid " _
                    & " FROM(UserMaster) WHERE " _
                    & " (((UserMaster.UserID) = '" & txtUserId.Text.Trim & "') And ((UserMaster.Pass) ='" & txtPass.Text.Trim & "')) " _
                    & " GROUP BY UserMaster.Uid,UserMaster.UserLevel; "

            DRead = cmd.ExecuteReader
            Do While DRead.Read()
                blnFlg = True
                If DRead.Item(0) > 0 Then
                    strGVUserID = DRead.Item(1)
                    'strUserLevel = DRead.Item(2)
                End If
            Loop
            If blnFlg = True Then
                DRead.Close()
                cmd.Dispose()
                Return True
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid user name or password.Try again", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                DRead.Close()
                cmd.Dispose()
                Return False
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
            Return False
        Finally

        End Try
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class

