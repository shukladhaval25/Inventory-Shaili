Public Class frmRM_Opening_Stock
    Inherits DevExpress.XtraEditors.XtraForm
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim strRID As String
    Dim strUID As String
    Public strcheck As String
    Dim strRMVINO As String

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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkupName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblInQty As System.Windows.Forms.Label
    Friend WithEvents lblVINO As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblProdName As System.Windows.Forms.Label
    Friend WithEvents txtRMVINO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRMUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtRMUnit = New DevExpress.XtraEditors.TextEdit
        Me.lkupName = New DevExpress.XtraEditors.LookUpEdit
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.lblInQty = New System.Windows.Forms.Label
        Me.txtRMVINO = New DevExpress.XtraEditors.TextEdit
        Me.lblVINO = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.dtpdate = New DevExpress.XtraEditors.DateEdit
        Me.lblUnit = New System.Windows.Forms.Label
        Me.lblProdName = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtRMUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRMVINO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(288, 184)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 25)
        Me.cmdcancel.TabIndex = 7
        Me.cmdcancel.Text = "&Cancel"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(208, 184)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 25)
        Me.cmdsave.TabIndex = 6
        Me.cmdsave.Text = "&Save"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtID)
        Me.GroupControl1.Controls.Add(Me.txtRMUnit)
        Me.GroupControl1.Controls.Add(Me.lkupName)
        Me.GroupControl1.Controls.Add(Me.txtQty)
        Me.GroupControl1.Controls.Add(Me.lblInQty)
        Me.GroupControl1.Controls.Add(Me.txtRMVINO)
        Me.GroupControl1.Controls.Add(Me.lblVINO)
        Me.GroupControl1.Controls.Add(Me.lblDate)
        Me.GroupControl1.Controls.Add(Me.dtpdate)
        Me.GroupControl1.Controls.Add(Me.lblUnit)
        Me.GroupControl1.Controls.Add(Me.lblProdName)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(360, 167)
        Me.GroupControl1.TabIndex = 0
        '
        'txtRMUnit
        '
        Me.txtRMUnit.EditValue = ""
        Me.txtRMUnit.Location = New System.Drawing.Point(120, 48)
        Me.txtRMUnit.Name = "txtRMUnit"
        '
        'txtRMUnit.Properties
        '
        Me.txtRMUnit.Properties.MaxLength = 50
        Me.txtRMUnit.Properties.ReadOnly = True
        Me.txtRMUnit.Size = New System.Drawing.Size(216, 20)
        Me.txtRMUnit.TabIndex = 2
        '
        'lkupName
        '
        Me.lkupName.EditValue = ""
        Me.lkupName.Location = New System.Drawing.Point(120, 17)
        Me.lkupName.Name = "lkupName"
        '
        'lkupName.Properties
        '
        Me.lkupName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupName.Properties.NullText = ""
        Me.lkupName.Size = New System.Drawing.Size(216, 20)
        Me.lkupName.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.EditValue = ""
        Me.txtQty.Location = New System.Drawing.Point(120, 75)
        Me.txtQty.Name = "txtQty"
        '
        'txtQty.Properties
        '
        Me.txtQty.Properties.MaxLength = 50
        Me.txtQty.Size = New System.Drawing.Size(216, 20)
        Me.txtQty.TabIndex = 3
        '
        'lblInQty
        '
        Me.lblInQty.Location = New System.Drawing.Point(16, 75)
        Me.lblInQty.Name = "lblInQty"
        Me.lblInQty.Size = New System.Drawing.Size(104, 25)
        Me.lblInQty.TabIndex = 24
        Me.lblInQty.Text = "Incoming Quantity"
        '
        'txtRMVINO
        '
        Me.txtRMVINO.EditValue = ""
        Me.txtRMVINO.Location = New System.Drawing.Point(120, 104)
        Me.txtRMVINO.Name = "txtRMVINO"
        '
        'txtRMVINO.Properties
        '
        Me.txtRMVINO.Properties.MaxLength = 50
        Me.txtRMVINO.Size = New System.Drawing.Size(216, 20)
        Me.txtRMVINO.TabIndex = 4
        '
        'lblVINO
        '
        Me.lblVINO.Location = New System.Drawing.Point(16, 104)
        Me.lblVINO.Name = "lblVINO"
        Me.lblVINO.Size = New System.Drawing.Size(112, 24)
        Me.lblVINO.TabIndex = 22
        Me.lblVINO.Text = "Visual Insepction No."
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(16, 128)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 26)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "Date "
        '
        'dtpdate
        '
        Me.dtpdate.EditValue = New Date(2007, 1, 19, 0, 0, 0, 0)
        Me.dtpdate.Location = New System.Drawing.Point(120, 136)
        Me.dtpdate.Name = "dtpdate"
        '
        'dtpdate.Properties
        '
        Me.dtpdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdate.Size = New System.Drawing.Size(216, 20)
        Me.dtpdate.TabIndex = 5
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(16, 45)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(80, 25)
        Me.lblUnit.TabIndex = 2
        Me.lblUnit.Text = "Unit"
        '
        'lblProdName
        '
        Me.lblProdName.Location = New System.Drawing.Point(16, 17)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(80, 25)
        Me.lblProdName.TabIndex = 1
        Me.lblProdName.Text = "Raw Materail"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(24, 20)
        Me.txtID.TabIndex = 25
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'frmRM_Opening_Stock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(378, 216)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRM_Opening_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opening Stock Of Raw Material"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtRMUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRMVINO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmRM_Opening_Stock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.RId, UnitMaster.UnitName, UnitMaster.UnitID " _
                & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID", "Item", "Item Name", "RID", lkupName)
            If strcheck = "Add" Then
                dtpdate.EditValue = Today
            End If
            If strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "select * from RM_Opening_Stock where id = " & ModMain.strgridid
                dr = cmd.ExecuteReader
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
                txtQty.Properties.ReadOnly = True
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Try
            If InStr(txtQty.Text, ".") <> 0 And Asc(e.KeyChar) = 46 Then
                e.Handled = True
                Exit Sub
            End If
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If Check() = False Then
                Exit Sub
            End If
            If strcheck = "Add" Then
                Dim intID As Integer
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction

                cmd.CommandText = "Select max(ID) from RM_Opening_Stock"
                intID = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
                intID = intID + 1

                cmd.CommandText = "insert into RM_Opening_Stock values (" & intID & ",'" & strRID & "','" & strUID & "','" & Replace(txtRMVINO.Text, "'", "''") & "'," & txtQty.Text & ",'" & dtpdate.Text & "')"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Insert into RMStock values ('" & strRID & "','" & dtpdate.Text & "','" & Replace(txtRMVINO.Text, "'", "''") & "','Opening'," & txtQty.Text & ",0," & txtQty.Text & ")"
                cmd.ExecuteNonQuery()
                cmd.Transaction.Commit()
            ElseIf strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction

                cmd.CommandText = "Update RM_Opening_Stock set RMVI_NO ='" & Replace(txtRMVINO.Text.Trim, "'", "''") & "', Opening_Qty = " & txtQty.Text & ", Register_Date ='" & dtpdate.Text & "' where id = " & txtID.Text.Trim
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Update RMStock set RMVI_NO ='" & txtRMVINO.Text & "' where RID ='" & strRID & "' and RMVI_NO ='" & strRMVINO.Trim & "'"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Update Material_Issue_Detail set RMVI_NO='" & txtRMVINO.Text & "' where RID ='" & strRID & "' and RMVI_NO ='" & strRMVINO.Trim & "'"
                cmd.ExecuteNonQuery()

                cmd.Transaction.Commit()
            End If

            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdsave.Enabled = False
            Me.Close()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try


    End Sub

    Private Sub lkupName_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupName.EditValueChanged
        Try
            If lkupName.EditValue = "" Then Exit Sub
            If lkupName.EditValue <> "<Null>" Or Not lkupName.EditValue = Nothing Then
                Dim row As DataRowView = lkupName.Properties.GetDataSourceRowByKeyValue(lkupName.EditValue)
                strRID = row(1).ToString
                txtRMUnit.Text = row(2).ToString
                strUID = row(3).ToString
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Public Function Check() As Boolean
        If lkupName.EditValue = Nothing Then

            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter the Raw Material", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lkupName.Select()
            Return False
            Exit Function

        End If
        'If txtRMVINO.Text.Trim = "" Then
        '    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Visual Insepction Number of the Raw Material", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtRMVINO.Select()
        '    Return False
        '    Exit Function
        'End If
        If txtQty.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter the Quantity ", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQty.Select()
            Return False
            Exit Function
        End If

        If dtpdate.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter the Date", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpdate.Select()
            Return False
            Exit Function
        End If

        Return True



    End Function
    Private Sub bind_data()
        Try

            txtID.Text = dr("ID").ToString

            'FID
            If IsDBNull(dr("RID").ToString) = True Then
                lkupName.EditValue = ""
            Else
                lkupName.EditValue = dr("RID").ToString
            End If



            'RMVI_NO
            If IsDBNull(dr("RMVI_NO").ToString) = True Then
                txtRMVINO.Text = ""
            Else
                txtRMVINO.Text = dr("RMVI_NO").ToString
                strRMVINO = txtRMVINO.Text
            End If

            'Opening_Qty
            If IsDBNull(dr("Opening_Qty").ToString) = True Then
                txtQty.Text = ""
            Else
                txtQty.Text = dr("Opening_Qty").ToString
            End If

            'Register_Date
            If IsDBNull(dr("Register_Date").ToString) = True Then
                dtpdate.EditValue = ""
            Else
                dtpdate.EditValue = dr("Register_Date").ToString
            End If

            Dim strunitid As String
            strunitid = dr("UnitID").ToString
            dr.Close()
            If strunitid <> "" Then

                Dim cmdtemp As New OleDb.OleDbCommand
                cmdtemp.CommandType = CommandType.Text
                cmdtemp.Connection = conn
                cmdtemp.CommandText = "select unitname from unitmaster where unitid = '" & strunitid & "'"
                Dim strUName1 As String
                strUName1 = cmdtemp.ExecuteScalar()
                If strUName1 Is Nothing Then
                    txtRMUnit.Text = ""
                Else
                    txtRMUnit.Text = strUName1
                End If
                cmdtemp.Dispose()
            Else
                txtRMUnit.Text = ""
            End If


        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtQty_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.EditValueChanged

    End Sub
End Class
