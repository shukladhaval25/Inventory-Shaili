Public Class FrmUnit
    Inherits DevExpress.XtraEditors.XtraForm
    Public strCheck As String
    Dim strUid As String
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
    Friend WithEvents grpUnit As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUnitDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnitName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpUnit = New DevExpress.XtraEditors.GroupControl
        Me.lblDesc = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtUnitDesc = New DevExpress.XtraEditors.TextEdit
        Me.txtUnitName = New DevExpress.XtraEditors.TextEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUnit.SuspendLayout()
        CType(Me.txtUnitDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUnit
        '
        Me.grpUnit.Controls.Add(Me.lblDesc)
        Me.grpUnit.Controls.Add(Me.lblName)
        Me.grpUnit.Controls.Add(Me.txtUnitDesc)
        Me.grpUnit.Controls.Add(Me.txtUnitName)
        Me.grpUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUnit.Location = New System.Drawing.Point(7, 7)
        Me.grpUnit.Name = "grpUnit"
        Me.grpUnit.Size = New System.Drawing.Size(306, 102)
        Me.grpUnit.TabIndex = 0
        Me.grpUnit.Text = "Unit Master"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(14, 66)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(56, 16)
        Me.lblDesc.TabIndex = 3
        Me.lblDesc.Text = "Unit Desc:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(14, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Unit Name:"
        '
        'txtUnitDesc
        '
        Me.txtUnitDesc.EditValue = ""
        Me.txtUnitDesc.Location = New System.Drawing.Point(80, 64)
        Me.txtUnitDesc.Name = "txtUnitDesc"
        Me.txtUnitDesc.Size = New System.Drawing.Size(208, 20)
        Me.txtUnitDesc.TabIndex = 1
        '
        'txtUnitName
        '
        Me.txtUnitName.EditValue = ""
        Me.txtUnitName.Location = New System.Drawing.Point(80, 32)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(208, 20)
        Me.txtUnitName.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(160, 116)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 21
        Me.cmdSave.Text = "&Save"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(240, 116)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 25)
        Me.cmdClose.TabIndex = 22
        Me.cmdClose.Text = "&Cancel"
        '
        'FrmUnit
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(320, 149)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grpUnit)
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 7
        Me.DockPadding.Right = 7
        Me.DockPadding.Top = 7
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unit Master"
        CType(Me.grpUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUnit.ResumeLayout(False)
        CType(Me.txtUnitDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub FrmUnit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' sopan
        Try
            If strCheck = "Add" Then
                txtUnitName.Tag = GetMaxNo("Unitid", "UnitMaster", "UT", 6)
            ElseIf strCheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from UnitMaster where Unitid='" & ModMain.strgridid & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                LoadUnit()
                dr.Close()
                cmd.Dispose()
                strUid = txtUnitName.Tag
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub LoadUnit()
        ' sopan
        Try
            ' Unit Id
            If IsDBNull(dr("Unitid").ToString) = True Then
                txtUnitName.Tag = ""
            Else
                txtUnitName.Tag = dr("Unitid").ToString
            End If

            'Unit Name 
            If IsDBNull(dr("UnitName").ToString) = True Then
                txtUnitName.Text = ""
            Else
                txtUnitName.Text = dr("UnitName").ToString
            End If

            'Unit Description
            If IsDBNull(dr("UnitDesc").ToString) = True Then
                txtUnitDesc.Text = ""
            Else
                txtUnitDesc.Text = dr("UnitDesc").ToString
            End If

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        ' sopan
        If ValidateUnit() = False Then
            Exit Sub
        End If
        Try
            If strCheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "insert into UnitMaster(Unitid,UnitName,UnitDesc) values('" & txtUnitName.Tag & _
                "','" & Replace(txtUnitName.Text.Trim, "'", "''") & "','" & Replace(txtUnitDesc.Text.Trim, "'", "''") & "')"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            Else
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "Update UnitMaster set UnitName='" & Replace(txtUnitName.Text.Trim, "'", "''") & _
                "',UnitDesc='" & Replace(txtUnitDesc.Text.Trim, "'", "''") & "' where Unitid='" & txtUnitName.Tag & "'"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End If

            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub
    Private Function ValidateUnit() As Boolean
        Dim id As String
        Try
            If txtUnitName.Text.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Unit Name", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUnitName.Select()
                ValidateUnit = False
                Exit Function
            End If

            cmd = New OleDb.OleDbCommand
            If strCheck = "Add" Then
                cmd.CommandText = "select Unitid from UnitMaster where UnitName='" & txtUnitName.Text & "'"
            ElseIf strCheck = "Edit" Then
                cmd.CommandText = "select Unitid from UnitMaster where UnitName='" & txtUnitName.Text.Trim & "' and Unitid <> '" & txtUnitName.Tag & "'"
            End If

            cmd.Connection = conn
            id = cmd.ExecuteScalar
            If id <> "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Unit Name Already Exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUnitName.Select()
                ValidateUnit = False
                Exit Function
            End If
            ValidateUnit = True
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If

        End Try
    End Function
End Class

