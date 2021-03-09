Public Class frmfgmaster
    Inherits DevExpress.XtraEditors.XtraForm
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Public strcheck As String
    Dim strgroupid As String
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtExpPeriod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblExpPeriod As System.Windows.Forms.Label
    Dim strunitid As String


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
    Friend WithEvents cmdcancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbounit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbgrname As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblgroupname As System.Windows.Forms.Label
    Friend WithEvents txtMin_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDrawNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModelNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAddGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddUnit As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdAddUnit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.txtModelNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDrawNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMin_Qty = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbgrname = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblgroupname = New System.Windows.Forms.Label()
        Me.cbounit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtno = New DevExpress.XtraEditors.TextEdit()
        Me.txtname = New DevExpress.XtraEditors.TextEdit()
        Me.txtid = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtExpPeriod = New DevExpress.XtraEditors.TextEdit()
        Me.lblExpPeriod = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtModelNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDrawNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMin_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbgrname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbounit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(432, 186)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 10
        Me.cmdcancel.Text = "&Cancel"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.txtExpPeriod)
        Me.GroupControl1.Controls.Add(Me.lblExpPeriod)
        Me.GroupControl1.Controls.Add(Me.cmdAddUnit)
        Me.GroupControl1.Controls.Add(Me.cmdAddGroup)
        Me.GroupControl1.Controls.Add(Me.txtModelNo)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txtDrawNo)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txtMin_Qty)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.cmbgrname)
        Me.GroupControl1.Controls.Add(Me.lblgroupname)
        Me.GroupControl1.Controls.Add(Me.cbounit)
        Me.GroupControl1.Controls.Add(Me.txtno)
        Me.GroupControl1.Controls.Add(Me.txtname)
        Me.GroupControl1.Controls.Add(Me.txtid)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(7, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(497, 172)
        Me.GroupControl1.TabIndex = 0
        '
        'cmdAddUnit
        '
        Me.cmdAddUnit.Location = New System.Drawing.Point(200, 72)
        Me.cmdAddUnit.Name = "cmdAddUnit"
        Me.cmdAddUnit.Size = New System.Drawing.Size(40, 21)
        Me.cmdAddUnit.TabIndex = 19
        Me.cmdAddUnit.Text = "&Add..."
        '
        'cmdAddGroup
        '
        Me.cmdAddGroup.Location = New System.Drawing.Point(200, 96)
        Me.cmdAddGroup.Name = "cmdAddGroup"
        Me.cmdAddGroup.Size = New System.Drawing.Size(40, 21)
        Me.cmdAddGroup.TabIndex = 18
        Me.cmdAddGroup.Text = "&Add..."
        '
        'txtModelNo
        '
        Me.txtModelNo.EditValue = ""
        Me.txtModelNo.Location = New System.Drawing.Point(344, 72)
        Me.txtModelNo.Name = "txtModelNo"
        Me.txtModelNo.Properties.MaxLength = 25
        Me.txtModelNo.Size = New System.Drawing.Size(144, 20)
        Me.txtModelNo.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(264, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Model No."
        '
        'txtDrawNo
        '
        Me.txtDrawNo.EditValue = ""
        Me.txtDrawNo.Location = New System.Drawing.Point(344, 48)
        Me.txtDrawNo.Name = "txtDrawNo"
        Me.txtDrawNo.Properties.MaxLength = 25
        Me.txtDrawNo.Size = New System.Drawing.Size(144, 20)
        Me.txtDrawNo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(264, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Drawing No."
        '
        'txtMin_Qty
        '
        Me.txtMin_Qty.EditValue = "0"
        Me.txtMin_Qty.Location = New System.Drawing.Point(344, 96)
        Me.txtMin_Qty.Name = "txtMin_Qty"
        Me.txtMin_Qty.Properties.MaxLength = 8
        Me.txtMin_Qty.Size = New System.Drawing.Size(144, 20)
        Me.txtMin_Qty.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(264, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Min. Qty"
        '
        'cmbgrname
        '
        Me.cmbgrname.EditValue = ""
        Me.cmbgrname.Location = New System.Drawing.Point(88, 96)
        Me.cmbgrname.Name = "cmbgrname"
        Me.cmbgrname.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbgrname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbgrname.Size = New System.Drawing.Size(104, 20)
        Me.cmbgrname.TabIndex = 4
        '
        'lblgroupname
        '
        Me.lblgroupname.Location = New System.Drawing.Point(16, 96)
        Me.lblgroupname.Name = "lblgroupname"
        Me.lblgroupname.Size = New System.Drawing.Size(72, 16)
        Me.lblgroupname.TabIndex = 11
        Me.lblgroupname.Text = "Group Name"
        '
        'cbounit
        '
        Me.cbounit.EditValue = ""
        Me.cbounit.Location = New System.Drawing.Point(88, 72)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbounit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbounit.Size = New System.Drawing.Size(104, 20)
        Me.cbounit.TabIndex = 3
        '
        'txtno
        '
        Me.txtno.EditValue = ""
        Me.txtno.Location = New System.Drawing.Point(88, 120)
        Me.txtno.Name = "txtno"
        Me.txtno.Properties.MaxLength = 150
        Me.txtno.Size = New System.Drawing.Size(400, 20)
        Me.txtno.TabIndex = 8
        '
        'txtname
        '
        Me.txtname.EditValue = ""
        Me.txtname.Location = New System.Drawing.Point(88, 48)
        Me.txtname.Name = "txtname"
        Me.txtname.Properties.MaxLength = 50
        Me.txtname.Size = New System.Drawing.Size(152, 20)
        Me.txtname.TabIndex = 2
        '
        'txtid
        '
        Me.txtid.EditValue = ""
        Me.txtid.Location = New System.Drawing.Point(88, 24)
        Me.txtid.Name = "txtid"
        Me.txtid.Properties.MaxLength = 15
        Me.txtid.Size = New System.Drawing.Size(152, 20)
        Me.txtid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FGID"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Notes"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FG Name"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(352, 186)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 9
        Me.cmdsave.Text = "&Save"
        '
        'txtExpPeriod
        '
        Me.txtExpPeriod.EditValue = ""
        Me.txtExpPeriod.Location = New System.Drawing.Point(88, 143)
        Me.txtExpPeriod.Name = "txtExpPeriod"
        Me.txtExpPeriod.Properties.MaxLength = 50
        Me.txtExpPeriod.Size = New System.Drawing.Size(104, 20)
        Me.txtExpPeriod.TabIndex = 21
        '
        'lblExpPeriod
        '
        Me.lblExpPeriod.Location = New System.Drawing.Point(16, 146)
        Me.lblExpPeriod.Name = "lblExpPeriod"
        Me.lblExpPeriod.Size = New System.Drawing.Size(66, 23)
        Me.lblExpPeriod.TabIndex = 20
        Me.lblExpPeriod.Text = "Exp. Period"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(197, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 23)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "(In Months)"
        '
        'frmfgmaster
        '
        Me.AcceptButton = Me.cmdsave
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdcancel
        Me.ClientSize = New System.Drawing.Size(514, 214)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cmdsave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmfgmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finish Goods"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtModelNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDrawNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMin_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbgrname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbounit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmfgmaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            If strcheck = "Add" Then
                txtid.Tag = GetMaxNo("Fid", "fgmaster", "FG", 10)
            End If
            If strcheck = "Edit" Then
                txtid.Tag = ModMain.strgridid
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from fgmaster where fid='" & ModMain.strgridid & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub bind_data()
        If IsDBNull(dr(1).ToString) = True Then
            txtid.Text = ""
        Else
            txtid.Text = dr(1).ToString
        End If

        If IsDBNull(dr(2).ToString) = True Then
            txtname.Text = ""
        Else
            txtname.Text = dr(2).ToString
        End If

        If IsDBNull(dr("Notes").ToString) = True Then
            txtno.Text = ""
        Else
            txtno.Text = dr("Notes").ToString
        End If

        If IsDBNull(dr("Draw_No").ToString) = True Then
            txtDrawNo.Text = ""
        Else
            txtDrawNo.Text = dr("Draw_No").ToString
        End If

        If IsDBNull(dr("Model_No").ToString) = True Then
            txtModelNo.Text = ""
        Else
            txtModelNo.Text = dr("Model_No").ToString
        End If

        If IsDBNull(dr("Min_Qty").ToString) = True Then
            txtMin_Qty.Text = ""
        Else
            txtMin_Qty.Text = dr("Min_Qty").ToString
        End If

        If IsDBNull(dr("ExpirationPeriod").ToString) = True Then
            txtExpPeriod.Text = ""
        Else
            txtExpPeriod.Text = dr("ExpirationPeriod").ToString
        End If

        strgroupid = dr("groupid").ToString
        strunitid = dr("UnitID").ToString

        dr.Close()

        'groupname
        If strgroupid <> "" Then
            ' dr.Close()
            Dim cmdtemp As New OleDb.OleDbCommand
            cmdtemp.CommandType = CommandType.Text
            cmdtemp.Connection = conn
            cmdtemp.CommandText = "select groupname from groupmaster where groupid = '" & strgroupid & "'"
            Dim strUName As String
            strUName = cmdtemp.ExecuteScalar()
            If strUName Is Nothing Then
                cmbgrname.Text = ""
            Else
                cmbgrname.Text = strUName
            End If
            cmdtemp.Dispose()
        Else
            cmbgrname.Text = ""
        End If


        'unitid()
        If strunitid <> "" Then

            Dim cmdtemp As New OleDb.OleDbCommand
            cmdtemp.CommandType = CommandType.Text
            cmdtemp.Connection = conn
            cmdtemp.CommandText = "select unitname from unitmaster where unitid = '" & strunitid & "'"
            Dim strUName1 As String
            strUName1 = cmdtemp.ExecuteScalar()
            If strUName1 Is Nothing Then
                cbounit.Text = ""
            Else
                cbounit.Text = strUName1
            End If
            cmdtemp.Dispose()
        Else
            cbounit.Text = ""
        End If

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If txtMin_Qty.Text = "" Then
                txtMin_Qty.Text = 0
            End If
            If CheckValiDate() = True Then
                If strcheck = "Add" Then
                    cmd = New OleDb.OleDbCommand("insert into fgmaster values ( '" & txtid.Tag & "','" & Replace(txtid.Text.Trim, "'", "''") & "', '" & Replace(txtname.Text, "'", "''") & "' , '" & strgroupid.Trim & "','" & strunitid & "'," _
                        & "'" & Replace(txtDrawNo.Text.Trim, "'", "''") & "','" & Replace(txtModelNo.Text.Trim, "'", "''") & "'," & txtMin_Qty.Text & ",'" & txtno.Text & "'," & txtExpPeriod.Text & ")", conn)
                    cmd.ExecuteNonQuery()
                ElseIf strcheck = "Edit" Then
                    cmd = New OleDb.OleDbCommand("update fgmaster set fgid= '" & Replace(txtid.Text.Trim, "'", "''") & "', fgname = '" & Replace(txtname.Text.Trim, "'", "''") & "', " _
                        & " groupid = '" & strgroupid.Trim & "', unitid = '" & strunitid & "', notes = '" & Replace(txtno.Text.Trim, "'", "''") & "', " _
                        & " Draw_No ='" & Replace(txtDrawNo.Text.Trim, "'", "''") & "', Model_No ='" & Replace(txtModelNo.Text.Trim, "'", "''") & "'," _
                        & " Min_Qty =" & txtMin_Qty.Text & ",ExpirationPeriod =" & txtExpPeriod.Text & " where Fid= '" & txtid.Tag & "'", conn)
                    cmd.ExecuteNonQuery()
                End If
                cmdsave.Enabled = False

            Else
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Check either Finish_Good ID or Finish_Good_Name or Group_Name or Unit is not left blank", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub cbounit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbounit.GotFocus
        Try
            FillCombox("UnitMaster", "UnitName", cbounit)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub cbounit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbounit.Validating
        Try
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select unitid from unitmaster where unitname= '" & cbounit.Text & "'"
            strunitid = cmd.ExecuteScalar
            cmd.Dispose()
        Catch EX As Exception
            If show_error Then
                MsgBox(EX.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
    Private Sub cmbgrname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgrname.GotFocus
        Try
            cmbgrname.Properties.Items.Clear()
            Dim dr As OleDb.OleDbDataReader
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Select GroupName from GroupMaster where GroupType ='F'"
            dr = cmd.ExecuteReader
            Do While dr.Read()
                cmbgrname.Properties.Items.Add(dr.Item(0))
            Loop
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmbgrname_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbgrname.Validating
        If cmbgrname.Text <> "" Then
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select groupid from groupmaster where groupname= '" & cmbgrname.Text & "'"
            strgroupid = cmd.ExecuteScalar
            cmd.Dispose()
        End If
    End Sub

    Private Sub txtMin_Qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMin_Qty.KeyPress
        Try
            e.Handled = IsNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cmdAddUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddUnit.Click
        Dim frmUnit As New FrmUnit
        frmUnit.strCheck = "Add"
        frmUnit.ShowDialog()
    End Sub

    Private Sub cmdAddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddGroup.Click
        Dim frmgroupobj As New frmGroup
        frmgroupobj.strcheck = "Add"
        frmgroupobj.ShowDialog()
    End Sub

    Private Function CheckValiDate() As Boolean

        'NEW
        Try
            If txtid.Text = "" Or txtname.Text = "" Or cbounit.Text = "" Or _
               cmbgrname.Text = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Function

    Private Sub txtExpPeriod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExpPeriod.KeyPress
        Try
            e.Handled = IsNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
End Class

