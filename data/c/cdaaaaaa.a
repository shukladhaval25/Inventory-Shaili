Public Class frmrejection
    Inherits DevExpress.XtraEditors.XtraForm
    Public strCheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    'Dim strOldReason As String

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
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents txtDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReason As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpUnit = New DevExpress.XtraEditors.GroupControl
        Me.lblDesc = New System.Windows.Forms.Label
        Me.lblReason = New System.Windows.Forms.Label
        Me.txtDesc = New DevExpress.XtraEditors.TextEdit
        Me.txtReason = New DevExpress.XtraEditors.TextEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUnit.SuspendLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUnit
        '
        Me.grpUnit.Controls.Add(Me.lblDesc)
        Me.grpUnit.Controls.Add(Me.lblReason)
        Me.grpUnit.Controls.Add(Me.txtDesc)
        Me.grpUnit.Controls.Add(Me.txtReason)
        Me.grpUnit.Location = New System.Drawing.Point(8, 9)
        Me.grpUnit.Name = "grpUnit"
        Me.grpUnit.Size = New System.Drawing.Size(306, 103)
        Me.grpUnit.TabIndex = 1
        Me.grpUnit.Text = "Reason"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(14, 64)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(64, 16)
        Me.lblDesc.TabIndex = 3
        Me.lblDesc.Text = "Description:"
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Location = New System.Drawing.Point(14, 37)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(45, 16)
        Me.lblReason.TabIndex = 2
        Me.lblReason.Text = "Reason:"
        '
        'txtDesc
        '
        Me.txtDesc.EditValue = ""
        Me.txtDesc.Location = New System.Drawing.Point(80, 64)
        Me.txtDesc.Name = "txtDesc"
        '
        'txtDesc.Properties
        '
        Me.txtDesc.Properties.MaxLength = 100
        Me.txtDesc.Size = New System.Drawing.Size(208, 20)
        Me.txtDesc.TabIndex = 3
        '
        'txtReason
        '
        Me.txtReason.EditValue = ""
        Me.txtReason.Location = New System.Drawing.Point(80, 34)
        Me.txtReason.Name = "txtReason"
        '
        'txtReason.Properties
        '
        Me.txtReason.Properties.MaxLength = 50
        Me.txtReason.Size = New System.Drawing.Size(208, 20)
        Me.txtReason.TabIndex = 2
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(160, 120)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 27)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "&Save"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(239, 120)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 27)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Cancel"
        '
        'frmrejection
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(328, 152)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grpUnit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrejection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reason For Rejection"
        CType(Me.grpUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUnit.ResumeLayout(False)
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmrejection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            
            If strCheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from Reason where Reason ='" & ModMain.strgridid & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub bind_data()
        Try

            If IsDBNull(dr("Reason")) = True Then
                txtReason.Text = ""
            Else
                txtReason.Text = dr("Reason").ToString
            End If
            'strOldReason = txtReason.Text
            If IsDBNull(dr("Description")) = True Then
                txtDesc.Text = ""
            Else
                txtDesc.Text = dr("Description").ToString
            End If

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtReason.Text.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Enter the required field", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If strCheck = "Add" Then

                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "insert into Reason values ('" & Replace(txtReason.Text.Trim, "'", "''") & "','" & Replace(txtDesc.Text.Trim, "'", "''") & "')"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            ElseIf strCheck = "Edit" Then
                txtReason.Properties.ReadOnly = True
                cmd.CommandText = "update reason set reason = '" & Replace(txtReason.Text, "'", "''") & "', Description = '" & Replace(txtDesc.Text, "'", "''") & "' where reason = '" & ModMain.strgridid & "'"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End If
            cmd.Dispose()
            cmdSave.Enabled = False
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class
