Public Class frmGroup
    Inherits System.Windows.Forms.Form
    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim strflag As Boolean
    Dim strgrouptype As String
    Public selecti As Int16

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
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtgrname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtgrid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblgroupname As System.Windows.Forms.Label
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.txtgrname = New DevExpress.XtraEditors.TextEdit
        Me.txtgrid = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Me.lblgroupname = New System.Windows.Forms.Label
        CType(Me.txtgrname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(280, 200)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 6
        Me.cmdcancel.Text = "&Cancel"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(200, 200)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 5
        Me.cmdsave.Text = "&Save"
        '
        'txtgrname
        '
        Me.txtgrname.EditValue = ""
        Me.txtgrname.Location = New System.Drawing.Point(112, 64)
        Me.txtgrname.Name = "txtgrname"
        Me.txtgrname.Size = New System.Drawing.Size(216, 20)
        Me.txtgrname.TabIndex = 2
        '
        'txtgrid
        '
        Me.txtgrid.EditValue = ""
        Me.txtgrid.Location = New System.Drawing.Point(112, 40)
        Me.txtgrid.Name = "txtgrid"
        Me.txtgrid.Size = New System.Drawing.Size(216, 20)
        Me.txtgrid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Group ID"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Group Name"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.RadioGroup1)
        Me.GroupControl1.Controls.Add(Me.lblgroupname)
        Me.GroupControl1.Controls.Add(Me.txtgrname)
        Me.GroupControl1.Controls.Add(Me.txtgrid)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(344, 184)
        Me.GroupControl1.TabIndex = 0
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(112, 88)
        Me.RadioGroup1.Name = "RadioGroup1"
        '
        'RadioGroup1.Properties
        '
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Raw Material"), New DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Finish Good"), New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Customer"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Supplier")})
        Me.RadioGroup1.Size = New System.Drawing.Size(216, 88)
        Me.RadioGroup1.TabIndex = 3
        '
        'lblgroupname
        '
        Me.lblgroupname.Location = New System.Drawing.Point(24, 96)
        Me.lblgroupname.Name = "lblgroupname"
        Me.lblgroupname.Size = New System.Drawing.Size(80, 23)
        Me.lblgroupname.TabIndex = 2
        Me.lblgroupname.Text = "Group Type"
        '
        'frmGroup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(362, 232)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cmdsave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Master"
        CType(Me.txtgrname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtgrid.Properties.ReadOnly = True
        If strcheck = "Add" Then
            Select Case stractivetable

                Case "Item"
                    RadioGroup1.SelectedIndex = 0
                    RadioGroup1.Enabled = False
                    strgrouptype = "R"
                    selecti = 0
                Case "Finish_goods"
                    RadioGroup1.SelectedIndex = 1
                    RadioGroup1.Enabled = False
                    strgrouptype = "F"
                    selecti = 1
                Case "Customer"
                    RadioGroup1.SelectedIndex = 2
                    RadioGroup1.Enabled = False
                    strgrouptype = "C"
                    selecti = 2

                Case "Supplier"
                    RadioGroup1.SelectedIndex = 3
                    RadioGroup1.Enabled = False
                    strgrouptype = "S"
                    selecti = 3
            End Select

            txtgrid.Text = GetMaxNo("groupid", "groupmaster", "GR", 10)
        End If
        If strcheck = "Edit" Then
            cmd = New OleDb.OleDbCommand
            cmd.CommandText = "select * from groupmaster where groupid ='" & ModMain.strgridid & "'"
            cmd.Connection = conn
            dr = cmd.ExecuteReader()
            dr.Read()
            bind_data()
            dr.Close()
            cmd.Dispose()
            RadioGroup1.Enabled = False
        End If
    End Sub
    Public Sub bind_data()
        If IsDBNull(dr(0).ToString) = True Then
            txtgrid.Text = ""
        Else
            txtgrid.Text = dr(0).ToString
        End If

        If IsDBNull(dr(1).ToString) = True Then
            txtgrname.Text = ""
        Else
            txtgrname.Text = dr(1).ToString
        End If

        If dr(2).ToString = "R" Then
            RadioGroup1.SelectedIndex = 0
        ElseIf dr(2).ToString = "F" Then
            RadioGroup1.SelectedIndex = 1
        ElseIf dr(2).ToString = "C" Then
            RadioGroup1.SelectedIndex = 2
        ElseIf dr(2).ToString = "S" Then
            RadioGroup1.SelectedIndex = 3
        End If
    End Sub


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If ValideGroup() = False Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                If strcheck = "Add" Then
                    cmd.CommandText = "insert into groupmaster values ('" & Replace(txtgrid.Text.Trim, "'", "''") & "','" & Replace(txtgrname.Text.Trim, "'", "''") & "', '" & strgrouptype & "')"
                    cmd.ExecuteNonQuery()
                ElseIf strcheck = "Edit" Then
                    cmd.CommandText = "update groupmaster set groupname = '" & Replace(txtgrname.Text.Trim, "'", "''") & "', grouptype = '" & strgrouptype & "' where groupid= '" & txtgrid.Text & "'"
                    cmd.ExecuteNonQuery()
                End If
                cmdsave.Enabled = False
                cmd.Dispose()
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Exit Sub
            End If
            Me.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged

        'MsgBox(RadioGroup1.SelectedIndex)
        If RadioGroup1.SelectedIndex = 0 Then
            strgrouptype = "R"
            selecti = 0
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            strgrouptype = "F"
            selecti = 1
        ElseIf RadioGroup1.SelectedIndex = 2 Then
            strgrouptype = "C"
            selecti = 2
        ElseIf RadioGroup1.SelectedIndex = 3 Then
            strgrouptype = "S"
            selecti = 3
        End If
    End Sub


    Private Sub RadioGroup1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RadioGroup1.Validating
        'Dim strtype As String
        'If strcheck = "Add" Then
        '    strtype = RadioGroup1.Properties.Items(selecti).Value()
        '    Dim strGroupName As String

        '    strGroupName = IsDuplicate("Select count(GroupName) from GroupMaster where groupname= '" & txtgrname.Text & "' and GroupType = '" & strtype & "'")

        '    If strGroupName = True Then
        '        e.Cancel = True
        '        MessageBox.Show("This Group Name with the selected Group Type is  already exist", "Duplicate Value Error", MessageBoxButtons.OK)
        '    End If
        'End If
    End Sub
    Public Function ValideGroup() As Boolean
        'NEW
        If txtgrname.Text = "" Or RadioGroup1.SelectedIndex = -1 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Check either Group Name or Group Type is left blank", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
            Exit Function
        End If

        Dim strtype As String
        strtype = RadioGroup1.Properties.Items(selecti).Value()
        Dim strGroupName As String

        If strcheck = "Add" Then

            strGroupName = IsDuplicate("Select count(GroupName) from GroupMaster where groupname= '" & txtgrname.Text & "' and GroupType = '" & strtype & "'")
        ElseIf strcheck = "Edit" Then
            strGroupName = IsDuplicate("Select count(GroupName) from GroupMaster where groupname= '" & txtgrname.Text & "' and GroupType = '" & strtype & "'")
        End If

        If strGroupName = True And strcheck = "Add" Then
            MessageBox.Show("This Group Name with the selected Group Type is  already exist", "Duplicate Value Error", MessageBoxButtons.OK)
            Return True

            Exit Function
        End If
        Return False

    End Function
End Class
