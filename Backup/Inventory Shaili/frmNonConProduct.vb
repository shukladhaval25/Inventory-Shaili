Public Class frmNonConProduct
    Inherits DevExpress.XtraEditors.XtraForm
    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim strRID As String
    Dim strCustID As String
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
    Friend WithEvents grpDispose As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents lblCompNo As System.Windows.Forms.Label
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblMake As System.Windows.Forms.Label
    Friend WithEvents lblItemSrNo As System.Windows.Forms.Label
    Friend WithEvents txtCompNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMake As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItemSrNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSrNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbReason As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lkupSuppName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents dtComplain As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton
        Me.grpDispose = New DevExpress.XtraEditors.GroupControl
        Me.dtComplain = New DevExpress.XtraEditors.DateEdit
        Me.txtRemark = New DevExpress.XtraEditors.TextEdit
        Me.lblRemark = New System.Windows.Forms.Label
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.lblQty = New System.Windows.Forms.Label
        Me.cmbReason = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lkupSuppName = New DevExpress.XtraEditors.LookUpEdit
        Me.txtItemSrNo = New DevExpress.XtraEditors.TextEdit
        Me.lblItemSrNo = New System.Windows.Forms.Label
        Me.txtMake = New DevExpress.XtraEditors.TextEdit
        Me.lblMake = New System.Windows.Forms.Label
        Me.lkupItemName = New DevExpress.XtraEditors.LookUpEdit
        Me.lblItemName = New System.Windows.Forms.Label
        Me.lblReason = New System.Windows.Forms.Label
        Me.txtCompNo = New DevExpress.XtraEditors.TextEdit
        Me.lblCompNo = New System.Windows.Forms.Label
        Me.txtAction = New DevExpress.XtraEditors.TextEdit
        Me.lblAction = New System.Windows.Forms.Label
        Me.lblCustName = New System.Windows.Forms.Label
        Me.lblProduct = New System.Windows.Forms.Label
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.txtSrNo = New DevExpress.XtraEditors.TextEdit
        CType(Me.grpDispose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDispose.SuspendLayout()
        CType(Me.dtComplain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupSuppName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemSrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMake.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(480, 184)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 26)
        Me.cmdcancel.TabIndex = 12
        Me.cmdcancel.Text = "&Cancel"
        '
        'grpDispose
        '
        Me.grpDispose.Controls.Add(Me.dtComplain)
        Me.grpDispose.Controls.Add(Me.txtRemark)
        Me.grpDispose.Controls.Add(Me.lblRemark)
        Me.grpDispose.Controls.Add(Me.txtQty)
        Me.grpDispose.Controls.Add(Me.lblQty)
        Me.grpDispose.Controls.Add(Me.cmbReason)
        Me.grpDispose.Controls.Add(Me.lkupSuppName)
        Me.grpDispose.Controls.Add(Me.txtItemSrNo)
        Me.grpDispose.Controls.Add(Me.lblItemSrNo)
        Me.grpDispose.Controls.Add(Me.txtMake)
        Me.grpDispose.Controls.Add(Me.lblMake)
        Me.grpDispose.Controls.Add(Me.lkupItemName)
        Me.grpDispose.Controls.Add(Me.lblItemName)
        Me.grpDispose.Controls.Add(Me.lblReason)
        Me.grpDispose.Controls.Add(Me.txtCompNo)
        Me.grpDispose.Controls.Add(Me.lblCompNo)
        Me.grpDispose.Controls.Add(Me.txtAction)
        Me.grpDispose.Controls.Add(Me.lblAction)
        Me.grpDispose.Controls.Add(Me.lblCustName)
        Me.grpDispose.Controls.Add(Me.lblProduct)
        Me.grpDispose.Location = New System.Drawing.Point(8, 8)
        Me.grpDispose.Name = "grpDispose"
        Me.grpDispose.Size = New System.Drawing.Size(544, 168)
        Me.grpDispose.TabIndex = 0
        '
        'dtComplain
        '
        Me.dtComplain.EditValue = New Date(2007, 2, 10, 0, 0, 0, 0)
        Me.dtComplain.Location = New System.Drawing.Point(88, 24)
        Me.dtComplain.Name = "dtComplain"
        '
        'dtComplain.Properties
        '
        Me.dtComplain.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtComplain.Size = New System.Drawing.Size(168, 20)
        Me.dtComplain.TabIndex = 1
        '
        'txtRemark
        '
        Me.txtRemark.EditValue = ""
        Me.txtRemark.Location = New System.Drawing.Point(368, 136)
        Me.txtRemark.Name = "txtRemark"
        '
        'txtRemark.Properties
        '
        Me.txtRemark.Properties.MaxLength = 75
        Me.txtRemark.Size = New System.Drawing.Size(168, 20)
        Me.txtRemark.TabIndex = 10
        '
        'lblRemark
        '
        Me.lblRemark.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblRemark.Location = New System.Drawing.Point(272, 136)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(72, 16)
        Me.lblRemark.TabIndex = 63
        Me.lblRemark.Text = "Remarks"
        '
        'txtQty
        '
        Me.txtQty.EditValue = ""
        Me.txtQty.Location = New System.Drawing.Point(88, 104)
        Me.txtQty.Name = "txtQty"
        '
        'txtQty.Properties
        '
        Me.txtQty.Properties.MaxLength = 20
        Me.txtQty.Size = New System.Drawing.Size(168, 20)
        Me.txtQty.TabIndex = 4
        '
        'lblQty
        '
        Me.lblQty.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblQty.Location = New System.Drawing.Point(16, 104)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(56, 24)
        Me.lblQty.TabIndex = 61
        Me.lblQty.Text = "Quantity"
        '
        'cmbReason
        '
        Me.cmbReason.EditValue = ""
        Me.cmbReason.Location = New System.Drawing.Point(368, 75)
        Me.cmbReason.Name = "cmbReason"
        '
        'cmbReason.Properties
        '
        Me.cmbReason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbReason.Size = New System.Drawing.Size(168, 20)
        Me.cmbReason.TabIndex = 8
        '
        'lkupSuppName
        '
        Me.lkupSuppName.EditValue = ""
        Me.lkupSuppName.Location = New System.Drawing.Point(368, 50)
        Me.lkupSuppName.Name = "lkupSuppName"
        '
        'lkupSuppName.Properties
        '
        Me.lkupSuppName.Properties.NullText = ""
        Me.lkupSuppName.Size = New System.Drawing.Size(168, 20)
        Me.lkupSuppName.TabIndex = 7
        '
        'txtItemSrNo
        '
        Me.txtItemSrNo.EditValue = ""
        Me.txtItemSrNo.Location = New System.Drawing.Point(368, 24)
        Me.txtItemSrNo.Name = "txtItemSrNo"
        '
        'txtItemSrNo.Properties
        '
        Me.txtItemSrNo.Properties.MaxLength = 20
        Me.txtItemSrNo.Size = New System.Drawing.Size(168, 20)
        Me.txtItemSrNo.TabIndex = 6
        '
        'lblItemSrNo
        '
        Me.lblItemSrNo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblItemSrNo.Location = New System.Drawing.Point(272, 24)
        Me.lblItemSrNo.Name = "lblItemSrNo"
        Me.lblItemSrNo.Size = New System.Drawing.Size(72, 25)
        Me.lblItemSrNo.TabIndex = 55
        Me.lblItemSrNo.Text = "Item Sr. No.:"
        '
        'txtMake
        '
        Me.txtMake.EditValue = ""
        Me.txtMake.Location = New System.Drawing.Point(88, 136)
        Me.txtMake.Name = "txtMake"
        '
        'txtMake.Properties
        '
        Me.txtMake.Properties.MaxLength = 25
        Me.txtMake.Size = New System.Drawing.Size(168, 20)
        Me.txtMake.TabIndex = 5
        '
        'lblMake
        '
        Me.lblMake.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblMake.Location = New System.Drawing.Point(16, 136)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(48, 24)
        Me.lblMake.TabIndex = 53
        Me.lblMake.Text = "Make:"
        '
        'lkupItemName
        '
        Me.lkupItemName.EditValue = ""
        Me.lkupItemName.Location = New System.Drawing.Point(88, 75)
        Me.lkupItemName.Name = "lkupItemName"
        '
        'lkupItemName.Properties
        '
        Me.lkupItemName.Properties.NullText = ""
        Me.lkupItemName.Size = New System.Drawing.Size(168, 20)
        Me.lkupItemName.TabIndex = 3
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(16, 74)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(71, 19)
        Me.lblItemName.TabIndex = 49
        Me.lblItemName.Text = "Item Name"
        '
        'lblReason
        '
        Me.lblReason.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblReason.Location = New System.Drawing.Point(272, 72)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(96, 25)
        Me.lblReason.TabIndex = 17
        Me.lblReason.Text = "Reason of Defect:"
        '
        'txtCompNo
        '
        Me.txtCompNo.EditValue = ""
        Me.txtCompNo.Location = New System.Drawing.Point(88, 50)
        Me.txtCompNo.Name = "txtCompNo"
        '
        'txtCompNo.Properties
        '
        Me.txtCompNo.Properties.MaxLength = 20
        Me.txtCompNo.Size = New System.Drawing.Size(168, 20)
        Me.txtCompNo.TabIndex = 2
        '
        'lblCompNo
        '
        Me.lblCompNo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblCompNo.Location = New System.Drawing.Point(16, 46)
        Me.lblCompNo.Name = "lblCompNo"
        Me.lblCompNo.Size = New System.Drawing.Size(80, 24)
        Me.lblCompNo.TabIndex = 15
        Me.lblCompNo.Text = "Complain No.:"
        '
        'txtAction
        '
        Me.txtAction.EditValue = ""
        Me.txtAction.Location = New System.Drawing.Point(368, 104)
        Me.txtAction.Name = "txtAction"
        '
        'txtAction.Properties
        '
        Me.txtAction.Properties.MaxLength = 75
        Me.txtAction.Size = New System.Drawing.Size(168, 20)
        Me.txtAction.TabIndex = 9
        '
        'lblAction
        '
        Me.lblAction.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblAction.Location = New System.Drawing.Point(272, 104)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(72, 16)
        Me.lblAction.TabIndex = 13
        Me.lblAction.Text = "Action Taken:"
        '
        'lblCustName
        '
        Me.lblCustName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblCustName.Location = New System.Drawing.Point(272, 46)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(88, 17)
        Me.lblCustName.TabIndex = 3
        Me.lblCustName.Text = "Supplier Name"
        '
        'lblProduct
        '
        Me.lblProduct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblProduct.Location = New System.Drawing.Point(16, 24)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(56, 16)
        Me.lblProduct.TabIndex = 1
        Me.lblProduct.Text = "Date:"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(400, 184)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 26)
        Me.cmdsave.TabIndex = 11
        Me.cmdsave.Text = "&Save"
        '
        'txtSrNo
        '
        Me.txtSrNo.EditValue = ""
        Me.txtSrNo.Location = New System.Drawing.Point(32, 184)
        Me.txtSrNo.Name = "txtSrNo"
        Me.txtSrNo.Size = New System.Drawing.Size(16, 20)
        Me.txtSrNo.TabIndex = 17
        Me.txtSrNo.Visible = False
        '
        'frmNonConProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(562, 216)
        Me.Controls.Add(Me.txtSrNo)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.grpDispose)
        Me.Controls.Add(Me.cmdsave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNonConProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Non Conforming Product Register"
        CType(Me.grpDispose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDispose.ResumeLayout(False)
        CType(Me.dtComplain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupSuppName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemSrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMake.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmNonConProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillLookup("select RMItemName,Rid from RMItemMaster", "Item", "Raw Material Name", "RID", lkupItemName)

            FillLookup("select SuppName,Sid from Suppliermaster", "Supplier", "Supplier Name", "SID", lkupSuppName)
            FillCombox("Reason", "Reason", cmbReason)


            If strcheck = "Add" Then
                txtSrNo.Text = GetMaxNo("Sr_No", "Non_Con_Product", "SR", 10)
            ElseIf strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from  Non_Con_Product where sr_No = '" & ModMain.strgridid & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub




    Private Sub bind_data()
        Try
            If IsDBNull(dr("Sr_No")) = True Then
                txtSrNo.Text = ""
            Else
                txtSrNo.Text = dr("Sr_No").ToString

            End If

            If IsDBNull(dr("Complain_Date")) = True Then
                dtComplain.EditValue = ""
            Else
                dtComplain.EditValue = dr("Complain_Date").ToString

            End If

            If IsDBNull(dr("ComPlain_No")) = True Then
                txtCompNo.Text = ""
            Else
                txtCompNo.Text = dr("ComPlain_No").ToString

            End If

            If IsDBNull(dr("RID")) = True Then
                lkupItemName.EditValue = ""
            Else
                lkupItemName.EditValue = dr("RID").ToString


            End If

            If IsDBNull(dr("Qty")) = True Then
                txtQty.Text = ""
            Else
                txtQty.Text = dr("Qty").ToString
            End If

            If IsDBNull(dr("Make")) = True Then
                txtMake.Text = ""
            Else
                txtMake.Text = dr("Make").ToString

            End If

            If IsDBNull(dr("Item_Sr_No")) = True Then
                txtItemSrNo.Text = ""
            Else
                txtItemSrNo.Text = dr("Item_Sr_No").ToString

            End If

            If IsDBNull(dr("SID")) = True Then
                lkupSuppName.EditValue = ""
            Else
                lkupSuppName.EditValue = dr("SID").ToString

            End If

            If IsDBNull(dr("Reason_Defect")) = True Then
                cmbReason.Text = ""
            Else
                cmbReason.Text = dr("Reason_Defect").ToString

            End If

            If IsDBNull(dr("Action_Taken")) = True Then
                txtAction.Text = ""
            Else
                txtAction.Text = dr("Action_Taken").ToString

            End If

            If IsDBNull(dr("Remark")) = True Then
                txtRemark.Text = ""
            Else
                txtRemark.Text = dr("Remark").ToString

            End If


        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

        Try
            If CheckItems() = False Then
                Exit Sub
            End If
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            If strcheck = "Add" Then

                cmd.CommandText = "insert into Non_Con_Product values ('" & txtSrNo.Text & "','" & dtComplain.Text & "','" & Replace(txtCompNo.Text, "'", "''") & "','" & strRID & "', " & txtQty.Text & ",'" & Replace(txtMake.Text, "'", "''") & "','" & Replace(txtItemSrNo.Text, "'", "''") & "','" & strCustID & "','" & Replace(cmbReason.Text, "'", "''") & "','" & Replace(txtAction.Text, "'", "''") & "','" & Replace(txtRemark.Text.Trim, "'", "''") & "')"
                cmd.ExecuteNonQuery()

            ElseIf strcheck = "Edit" Then

                cmd.CommandText = "update Non_Con_Product set Complain_Date ='" & dtComplain.Text & "', ComPlain_No ='" & txtCompNo.Text & "', RID ='" & strRID & "', Qty = " & txtQty.Text & " , make ='" & Replace(txtMake.Text.Trim, "'", "''") & "', Item_Sr_No ='" & txtItemSrNo.Text & "', SID = '" & strCustID & "', Reason_Defect ='" & Replace(cmbReason.Text.Trim, "'", "''") & "', Action_Taken ='" & Replace(txtAction.Text.Trim, "'", "''") & "', Remark = '" & Replace(txtRemark.Text.Trim, "'", "''") & "' where Sr_No ='" & ModMain.strgridid & "'"

                cmd.ExecuteNonQuery()
            End If

            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmdsave.Enabled = False
            Me.Close()

        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Public Function CheckItems() As Boolean
        Try
            If dtComplain.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Enter the Complain Date", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                dtComplain.Select()
                Return False
                Exit Function
            End If

            If txtCompNo.Text.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Enter the Complain Numbere", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                txtCompNo.Select()
                Return False
                Exit Function
            End If


            If lkupItemName.EditValue = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Enter the Item Name", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lkupItemName.Select()
                Return False
                Exit Function
            End If

            If txtQty.Text.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Enter Quantity of Non Conformed Product", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtQty.Select()
                Return False
            End If

            If lkupSuppName.EditValue = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Enter the Supplier Name", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lkupSuppName.Select()
                Return False
                Exit Function
            End If

            If cmbReason.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Enter the Reason of Defect", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                cmbReason.Select()
                Return False
                Exit Function
            End If

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub lkupItemName_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupItemName.EditValueChanged
        Try
            If lkupItemName.EditValue <> "" Then
                Dim row As DataRowView = lkupItemName.Properties.GetDataSourceRowByKeyValue(lkupItemName.EditValue)
                strRID = row(1).ToString
            End If

        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupSuppName_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupSuppName.EditValueChanged
        Try
            If lkupSuppName.EditValue <> "" Then
                Dim row As DataRowView = lkupSuppName.Properties.GetDataSourceRowByKeyValue(lkupSuppName.EditValue)
                strCustID = row(1).ToString
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
End Class
