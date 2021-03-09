Public Class frmDispose_Staus
    Inherits DevExpress.XtraEditors.XtraForm
    Dim strItem As String
    Public strcheck As String
    Dim strID As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim strVINO As String

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
    Friend WithEvents grpDisItem As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RDGItem As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lkupName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbReason As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents txtDisposedby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDisposed As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtMethod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMethod As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents dtDispose As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSrNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDisQty As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton
        Me.grpDispose = New DevExpress.XtraEditors.GroupControl
        Me.grpDisItem = New DevExpress.XtraEditors.GroupControl
        Me.RDGItem = New DevExpress.XtraEditors.RadioGroup
        Me.grpControl = New DevExpress.XtraEditors.GroupControl
        Me.txtDisQty = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.lkupName = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbReason = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblReason = New System.Windows.Forms.Label
        Me.txtDisposedby = New DevExpress.XtraEditors.TextEdit
        Me.lblDisposed = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.txtMethod = New DevExpress.XtraEditors.TextEdit
        Me.lblMethod = New System.Windows.Forms.Label
        Me.lblProduct = New System.Windows.Forms.Label
        Me.dtDispose = New DevExpress.XtraEditors.DateEdit
        Me.txtSrNo = New DevExpress.XtraEditors.TextEdit
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpDispose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDispose.SuspendLayout()
        CType(Me.grpDisItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisItem.SuspendLayout()
        CType(Me.RDGItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.txtDisQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisposedby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDispose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(560, 136)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 9
        Me.cmdcancel.Text = "&Cancel"
        '
        'grpDispose
        '
        Me.grpDispose.Controls.Add(Me.grpDisItem)
        Me.grpDispose.Controls.Add(Me.grpControl)
        Me.grpDispose.Controls.Add(Me.cmdcancel)
        Me.grpDispose.Controls.Add(Me.cmdsave)
        Me.grpDispose.Location = New System.Drawing.Point(8, 0)
        Me.grpDispose.Name = "grpDispose"
        Me.grpDispose.Size = New System.Drawing.Size(640, 168)
        Me.grpDispose.TabIndex = 0
        '
        'grpDisItem
        '
        Me.grpDisItem.Controls.Add(Me.RDGItem)
        Me.grpDisItem.Location = New System.Drawing.Point(8, 16)
        Me.grpDisItem.Name = "grpDisItem"
        Me.grpDisItem.Size = New System.Drawing.Size(104, 112)
        Me.grpDisItem.TabIndex = 1
        Me.grpDisItem.Text = "Disposed Item"
        '
        'RDGItem
        '
        Me.RDGItem.Location = New System.Drawing.Point(8, 24)
        Me.RDGItem.Name = "RDGItem"
        '
        'RDGItem.Properties
        '
        Me.RDGItem.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Raw Material"), New DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Finish Good")})
        Me.RDGItem.Size = New System.Drawing.Size(88, 72)
        Me.RDGItem.TabIndex = 2
        '
        'grpControl
        '
        Me.grpControl.Controls.Add(Me.txtDisQty)
        Me.grpControl.Controls.Add(Me.Label1)
        Me.grpControl.Controls.Add(Me.lkupName)
        Me.grpControl.Controls.Add(Me.cmbReason)
        Me.grpControl.Controls.Add(Me.lblReason)
        Me.grpControl.Controls.Add(Me.txtDisposedby)
        Me.grpControl.Controls.Add(Me.lblDisposed)
        Me.grpControl.Controls.Add(Me.lblDate)
        Me.grpControl.Controls.Add(Me.txtMethod)
        Me.grpControl.Controls.Add(Me.lblMethod)
        Me.grpControl.Controls.Add(Me.lblProduct)
        Me.grpControl.Controls.Add(Me.dtDispose)
        Me.grpControl.Controls.Add(Me.txtSrNo)
        Me.grpControl.Location = New System.Drawing.Point(120, 16)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Size = New System.Drawing.Size(512, 112)
        Me.grpControl.TabIndex = 10
        Me.grpControl.Text = "Disposition Details"
        '
        'txtDisQty
        '
        Me.txtDisQty.EditValue = ""
        Me.txtDisQty.Location = New System.Drawing.Point(88, 45)
        Me.txtDisQty.Name = "txtDisQty"
        '
        'txtDisQty.Properties
        '
        Me.txtDisQty.Properties.MaxLength = 25
        Me.txtDisQty.Size = New System.Drawing.Size(168, 20)
        Me.txtDisQty.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Disposed Qty.:"
        '
        'lkupName
        '
        Me.lkupName.EditValue = ""
        Me.lkupName.Location = New System.Drawing.Point(88, 16)
        Me.lkupName.Name = "lkupName"
        '
        'lkupName.Properties
        '
        Me.lkupName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupName.Properties.NullText = ""
        Me.lkupName.Size = New System.Drawing.Size(168, 20)
        Me.lkupName.TabIndex = 57
        '
        'cmbReason
        '
        Me.cmbReason.EditValue = ""
        Me.cmbReason.Location = New System.Drawing.Point(88, 80)
        Me.cmbReason.Name = "cmbReason"
        '
        'cmbReason.Properties
        '
        Me.cmbReason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbReason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbReason.Size = New System.Drawing.Size(168, 20)
        Me.cmbReason.TabIndex = 58
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.Location = New System.Drawing.Point(8, 80)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(53, 19)
        Me.lblReason.TabIndex = 59
        Me.lblReason.Text = "Reason:"
        '
        'txtDisposedby
        '
        Me.txtDisposedby.EditValue = ""
        Me.txtDisposedby.Location = New System.Drawing.Point(344, 48)
        Me.txtDisposedby.Name = "txtDisposedby"
        '
        'txtDisposedby.Properties
        '
        Me.txtDisposedby.Properties.MaxLength = 25
        Me.txtDisposedby.Size = New System.Drawing.Size(160, 20)
        Me.txtDisposedby.TabIndex = 62
        '
        'lblDisposed
        '
        Me.lblDisposed.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblDisposed.Location = New System.Drawing.Point(272, 48)
        Me.lblDisposed.Name = "lblDisposed"
        Me.lblDisposed.Size = New System.Drawing.Size(80, 23)
        Me.lblDisposed.TabIndex = 66
        Me.lblDisposed.Text = "Disposed By:"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblDate.Location = New System.Drawing.Point(272, 80)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 16)
        Me.lblDate.TabIndex = 64
        Me.lblDate.Text = "Date:"
        '
        'txtMethod
        '
        Me.txtMethod.EditValue = ""
        Me.txtMethod.Location = New System.Drawing.Point(344, 16)
        Me.txtMethod.Name = "txtMethod"
        '
        'txtMethod.Properties
        '
        Me.txtMethod.Properties.MaxLength = 255
        Me.txtMethod.Size = New System.Drawing.Size(160, 20)
        Me.txtMethod.TabIndex = 61
        '
        'lblMethod
        '
        Me.lblMethod.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblMethod.Location = New System.Drawing.Point(272, 16)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(56, 16)
        Me.lblMethod.TabIndex = 56
        Me.lblMethod.Text = "Method:"
        '
        'lblProduct
        '
        Me.lblProduct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblProduct.Location = New System.Drawing.Point(8, 16)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(88, 23)
        Me.lblProduct.TabIndex = 55
        Me.lblProduct.Text = "Product Name:"
        '
        'dtDispose
        '
        Me.dtDispose.EditValue = New Date(2007, 1, 17, 0, 0, 0, 0)
        Me.dtDispose.Location = New System.Drawing.Point(344, 80)
        Me.dtDispose.Name = "dtDispose"
        '
        'dtDispose.Properties
        '
        Me.dtDispose.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDispose.Size = New System.Drawing.Size(160, 20)
        Me.dtDispose.TabIndex = 63
        '
        'txtSrNo
        '
        Me.txtSrNo.EditValue = ""
        Me.txtSrNo.Location = New System.Drawing.Point(88, 16)
        Me.txtSrNo.Name = "txtSrNo"
        '
        'txtSrNo.Properties
        '
        Me.txtSrNo.Properties.MaxLength = 25
        Me.txtSrNo.Properties.ReadOnly = True
        Me.txtSrNo.Size = New System.Drawing.Size(8, 20)
        Me.txtSrNo.TabIndex = 67
        Me.txtSrNo.Visible = False
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(480, 136)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 68
        Me.cmdsave.Text = "&Save"
        '
        'frmDispose_Staus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(658, 176)
        Me.Controls.Add(Me.grpDispose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDispose_Staus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Disposition  Status"
        CType(Me.grpDispose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDispose.ResumeLayout(False)
        CType(Me.grpDisItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisItem.ResumeLayout(False)
        CType(Me.RDGItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.txtDisQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisposedby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDispose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDGItem.SelectedIndexChanged
        Try
            
            grpControl.Enabled = True

            If RDGItem.SelectedIndex = 0 Then
                FillLookup("select RMItemName,RID,RID from RMItemMaster", "ItemMaster", "Item Name", "RID", lkupName)
                'NEW
                
                'FillLookup("SELECT RMItemMaster.RMItemName, QCDetail.RID, QCDetail.RMVI_NO " _
                '& " FROM RMItemMaster INNER JOIN QCDetail ON RMItemMaster.Rid = QCDetail.RID", "RMItem", "Raw Materail", "RID", lkupName)

                strItem = "R"

            ElseIf RDGItem.SelectedIndex = 1 Then
                FillLookup("select FGName, FID,FID from FGMaster", "FGMaster", "Product Name", "FID", lkupName)
                'NEW

                'FillLookup("SELECT FGMaster.FGName, FinishGoods_QCDetail.FID, FinishGoods_QCDetail.FGVI_No " _
                '& " FROM FinishGoods_QCDetail INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID", "FGQCDetail", "Product Name", "FID", lkupName)

                strItem = "F"
            End If

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If

        End Try

    End Sub

    

    Private Sub frmDispose_Staus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        grpControl.Enabled = False
        FillCombox("Reason", "Reason", cmbReason)
        Try
            If strcheck = "Add" Then
                txtSrNo.Text = GetMaxNo("Sr_No", "Disposition_status", "SR", 10)
                dtDispose.EditValue = Now
            ElseIf strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Select * from disposition_status where sr_no = '" & ModMain.strgridid & "'"
                dr = cmd.ExecuteReader
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

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub bind_data()
        Try
            If IsDBNull(dr("sr_no")) = True Then
                txtSrNo.Text = ""
            Else
                txtSrNo.Text = dr("Sr_No").ToString

            End If


            If IsDBNull(dr("Category")) = True Then
            Else
                If dr("Category").ToString = "R" Then
                    RDGItem.SelectedIndex = 0
                    'FillLookup("select RMItemName,RID,DrawNo from RMItemMaster", "ItemMaster", "Item Name", "RID", lkupName)
                    ' FillLookup("SELECT RMItemMaster.RMItemName, QCDetail.RID, QCDetail.RMVI_NO " _
                    '              & " FROM RMItemMaster INNER JOIN QCDetail ON RMItemMaster.Rid = QCDetail.RID", "RMItem", "Raw Materail", "RID", lkupName)


                ElseIf dr("Category").ToString = "F" Then
                    RDGItem.SelectedIndex = 1
                    'FillLookup("select FGName, FID,draw_No from FGMaster", "FGMaster", "Product Name", "FID", lkupName)
                    'FillLookup("SELECT FGMaster.FGName, FinishGoods_QCDetail.FID, FinishGoods_QCDetail.FGVI_No " _
                    '             & " FROM FinishGoods_QCDetail INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID", "FGQCDetail", "Product Name", "FID", lkupName)
                End If
            End If

            If IsDBNull(dr("ItemID")) = True Then
                lkupName.EditValue = ""
            Else
                lkupName.EditValue = dr("ItemID").ToString
            End If


            If IsDBNull(dr("Disposed_Qty")) = True Then
                txtDisQty.Text = ""
            Else
                txtDisQty.Text = dr("Disposed_Qty").ToString
            End If

            If IsDBNull(dr("Reason")) = True Then
                cmbReason.Text = ""
            Else
                cmbReason.Text = dr("Reason").ToString

            End If

            If IsDBNull(dr("Method")) = True Then
                txtMethod.Text = ""
            Else
                txtMethod.Text = dr("Method").ToString

            End If

            If IsDBNull(dr("Disposed_By")) = True Then
                txtDisposedby.Text = ""
            Else
                txtDisposedby.Text = dr("Disposed_By").ToString

            End If

            If IsDBNull(dr("Dispose_Date")) = True Then
                dtDispose.EditValue = " "
            Else
                dtDispose.EditValue = dr("Dispose_Date").ToString

            End If

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If

        End Try
    End Sub
    Public Function Checkblank() As Boolean
        If lkupName.EditValue = "" = True Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Product Name", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lkupName.Select()
            Return False
            Exit Function
        End If

        If txtDisQty.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Disposed Qutantiy", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDisQty.Select()
            Return False
        End If


        If cmbReason.EditValue = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Reason for Disposition", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbReason.Select()
            Return False
            Exit Function
        End If

        If txtMethod.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Method of Disposition", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMethod.Select()
            Return False
            Exit Function
        End If

        If txtDisposedby.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Disposed by", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDisposedby.Select()
            Return False
        End If
        If dtDispose.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Date of Disposition of Material", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtDispose.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            If Checkblank() = False Then
                Exit Sub
            End If
            cmd.Transaction = conn.BeginTransaction
            If strcheck = "Add" Then
                cmd.CommandText = "insert into Disposition_Status values ('" & txtSrNo.Text & "','" & strID & "'," & txtDisQty.Text & ",'" & cmbReason.Text & "','" & Replace(txtMethod.Text.Trim, "'", "''") & "','" & Replace(txtDisposedby.Text.Trim, "'", "''") & "','" & dtDispose.Text & "','" & strItem & "')"

                cmd.ExecuteNonQuery()
            ElseIf strcheck = "Edit" Then
                cmd.CommandText = "Update Disposition_Status set ItemID = '" & strID & "', VINO = '" & strVINO & "',Disposed_Qty = " & txtDisQty.Text & ", Reason = '" & cmbReason.Text & "', method = '" & txtMethod.Text & "', disposed_by = '" & txtDisposedby.Text & "', Dispose_Date= #" & dtDispose.Text & "#, category = '" & strItem & "' where sr_no = '" & ModMain.strgridid & "'"
                cmd.ExecuteNonQuery()
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdsave.Enabled = False
            cmd.Transaction.Commit()
            Me.Close()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        Finally
            'cmd.Dispose()
        End Try
    End Sub

   
    Private Sub lkupName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupName.EditValueChanged
        Try
            If lkupName.EditValue <> "" Then
                Dim row As DataRowView = lkupName.Properties.GetDataSourceRowByKeyValue(lkupName.EditValue)
                strID = row(1).ToString
                strVINO = row(2).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If

        End Try
    End Sub

End Class
