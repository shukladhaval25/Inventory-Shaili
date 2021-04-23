Public Class frmFG_OpeningStock1
    Inherits DevExpress.XtraEditors.XtraForm
    Dim strFID As String
    Dim strUID As String
    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim strFGVINO As String
       
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
    Friend WithEvents cmdcancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFGVINO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblInQty As System.Windows.Forms.Label
    Friend WithEvents lblVINO As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblProdName As System.Windows.Forms.Label
    Friend WithEvents lkupName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtFGunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtFGunit = New DevExpress.XtraEditors.TextEdit
        Me.lkupName = New DevExpress.XtraEditors.LookUpEdit
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.lblInQty = New System.Windows.Forms.Label
        Me.txtFGVINO = New DevExpress.XtraEditors.TextEdit
        Me.lblVINO = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.dtpdate = New DevExpress.XtraEditors.DateEdit
        Me.lblUnit = New System.Windows.Forms.Label
        Me.lblProdName = New System.Windows.Forms.Label
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFGunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFGVINO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtID)
        Me.GroupControl1.Controls.Add(Me.txtFGunit)
        Me.GroupControl1.Controls.Add(Me.lkupName)
        Me.GroupControl1.Controls.Add(Me.txtQty)
        Me.GroupControl1.Controls.Add(Me.lblInQty)
        Me.GroupControl1.Controls.Add(Me.txtFGVINO)
        Me.GroupControl1.Controls.Add(Me.lblVINO)
        Me.GroupControl1.Controls.Add(Me.lblDate)
        Me.GroupControl1.Controls.Add(Me.dtpdate)
        Me.GroupControl1.Controls.Add(Me.lblUnit)
        Me.GroupControl1.Controls.Add(Me.lblProdName)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(360, 167)
        Me.GroupControl1.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(32, 20)
        Me.txtID.TabIndex = 25
        Me.txtID.Visible = False
        '
        'txtFGunit
        '
        Me.txtFGunit.EditValue = ""
        Me.txtFGunit.Location = New System.Drawing.Point(136, 43)
        Me.txtFGunit.Name = "txtFGunit"
        '
        '
        '
        Me.txtFGunit.Properties.MaxLength = 50
        Me.txtFGunit.Properties.ReadOnly = True
        Me.txtFGunit.Size = New System.Drawing.Size(216, 20)
        Me.txtFGunit.TabIndex = 2
        '
        'lkupName
        '
        Me.lkupName.EditValue = ""
        Me.lkupName.Location = New System.Drawing.Point(136, 16)
        Me.lkupName.Name = "lkupName"
        '
        '
        '
        Me.lkupName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupName.Properties.NullText = ""
        Me.lkupName.Size = New System.Drawing.Size(216, 20)
        Me.lkupName.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.EditValue = ""
        Me.txtQty.Location = New System.Drawing.Point(136, 70)
        Me.txtQty.Name = "txtQty"
        '
        '
        '
        Me.txtQty.Properties.MaxLength = 50
        Me.txtQty.Size = New System.Drawing.Size(216, 20)
        Me.txtQty.TabIndex = 3
        '
        'lblInQty
        '
        Me.lblInQty.Location = New System.Drawing.Point(16, 70)
        Me.lblInQty.Name = "lblInQty"
        Me.lblInQty.Size = New System.Drawing.Size(104, 23)
        Me.lblInQty.TabIndex = 24
        Me.lblInQty.Text = "Quantity"
        '
        'txtFGVINO
        '
        Me.txtFGVINO.EditValue = ""
        Me.txtFGVINO.Location = New System.Drawing.Point(136, 98)
        Me.txtFGVINO.Name = "txtFGVINO"
        '
        '
        '
        Me.txtFGVINO.Properties.MaxLength = 50
        Me.txtFGVINO.Size = New System.Drawing.Size(216, 20)
        Me.txtFGVINO.TabIndex = 4
        '
        'lblVINO
        '
        Me.lblVINO.Location = New System.Drawing.Point(16, 98)
        Me.lblVINO.Name = "lblVINO"
        Me.lblVINO.Size = New System.Drawing.Size(112, 23)
        Me.lblVINO.TabIndex = 22
        Me.lblVINO.Text = "Batch No:"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(16, 126)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 24)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "Date "
        '
        'dtpdate
        '
        Me.dtpdate.EditValue = New Date(2007, 1, 19, 0, 0, 0, 0)
        Me.dtpdate.Location = New System.Drawing.Point(136, 126)
        Me.dtpdate.Name = "dtpdate"
        '
        '
        '
        Me.dtpdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdate.Size = New System.Drawing.Size(216, 20)
        Me.dtpdate.TabIndex = 5
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(16, 42)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(80, 23)
        Me.lblUnit.TabIndex = 2
        Me.lblUnit.Text = "Unit"
        '
        'lblProdName
        '
        Me.lblProdName.Location = New System.Drawing.Point(16, 16)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(80, 23)
        Me.lblProdName.TabIndex = 1
        Me.lblProdName.Text = "Product Name"
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(288, 184)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 7
        Me.cmdcancel.Text = "&Cancel"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(208, 184)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 6
        Me.cmdsave.Text = "&Save"
        '
        'frmFG_OpeningStock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(378, 216)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFG_OpeningStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opening Stock Of Final Product"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFGunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFGVINO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub frmFG_OpeningStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillLookup("SELECT FGMaster.FGName, FGMaster.FID, UnitMaster.UnitName, UnitMaster.UnitID " _
            & " FROM FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID", "FGMaster", "Product Name", "FID", lkupName)

            If strcheck = "Add" Then
                dtpdate.EditValue = Now
            End If
            If strcheck = "Edit" Then
                lkupName.Properties.ReadOnly = True
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from FG_Opening_Stock where Id = " & ModMain.strgridid
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
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

    Private Sub lkupName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupName.EditValueChanged
        Try
            If lkupName.EditValue <> "" Then
                Dim row As DataRowView = lkupName.Properties.GetDataSourceRowByKeyValue(lkupName.EditValue)
                strFID = row(1).ToString

                txtFGunit.Text = row(2).ToString
                strUID = row(3).ToString
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If CheckData() = False Then
                Exit Sub
            End If
            If strcheck = "Add" Then
                Dim intID As Int16
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "Select max(ID) from FG_Opening_Stock"
                intID = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
                intID = intID + 1
                'strFID = "FG00000090"
                'strUID = "UT0001"
                cmd.CommandText = "insert into FG_Opening_Stock values (" & intID & ",'" & strFID & "','" & strUID & "','" & Replace(txtFGVINO.Text, "'", "''") & "'," & txtQty.Text & ",'" & dtpdate.Text & "','" & strCY.Trim & "')"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Insert into FGStock values ('" & strFID & "','" & dtpdate.Text & "','" & Replace(txtFGVINO.Text, "'", "''") & "','Opening'," & txtQty.Text & ",0,0," & txtQty.Text & ",'" & strCY.Trim & "')"
                cmd.ExecuteNonQuery()
                cmd.Transaction.Commit()
            ElseIf strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction

                cmd.CommandText = "Update FG_Opening_Stock  set FGVI_NO = '" & Replace(txtFGVINO.Text.Trim, "'", "''") & "', Opening_Qty = " & txtQty.Text & ", Register_Date ='" & dtpdate.Text & "' where ID =" & txtID.Text & " and CY ='" & strCY.Trim & "'"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Update FGstock set Batch_No='" & txtFGVINO.Text & "' where FID ='" & strFID & "' and Batch_No ='" & strFGVINO & "' and CY ='" & strCY.Trim & "'"
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

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
    Public Function CheckData() As Boolean
        Try
            If lkupName.EditValue = Nothing Then

                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter the Raw Material", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lkupName.Select()
                Return False
                Exit Function
            End If
            'If txtFGVINO.Text.Trim = "" Then
            '    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Visual Insepction Number of the Finish Good", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txtFGVINO.Select()
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

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT Count(FG_Opening_Stock.FGVI_NO) AS CountOfFGVI_NO, FG_Opening_Stock.FID, FG_Opening_Stock.FGVI_NO" _
                & " FROM FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID " _
                & " GROUP BY FG_Opening_Stock.FID, FG_Opening_Stock.FGVI_NO " _
                & " HAVING (((FG_Opening_Stock.FID)='" & strFID & "') AND ((FG_Opening_Stock.FGVI_NO)= '" & txtFGVINO.Text.Trim & "'));"
            If cmd.ExecuteScalar > 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Duplicate batch no for this product.", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpdate.Select()
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Function
    Private Sub bind_data()
        Try

            txtID.Text = dr("ID").ToString
            'RID
            If IsDBNull(dr("Fid").ToString) = True Then
                lkupName.EditValue = ""
            Else
                lkupName.EditValue = dr("Fid").ToString
            End If

            'FGVI_NO
            If IsDBNull(dr("FGVI_NO").ToString) = True Then
                txtFGVINO.Text = ""
            Else
                txtFGVINO.Text = dr("FGVI_NO").ToString
                strFGVINO = txtFGVINO.Text
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
                dtpdate.EditValue = Format(dr("Register_Date"), "dd/MM/yyyy")
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
                    txtFGunit.Text = ""
                Else
                    txtFGunit.Text = strUName1
                End If
                cmdtemp.Dispose()
            Else
                txtFGunit.Text = ""
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lkupName.Validating
        Try
            'If strcheck = "Add" Then
            '    Dim strFID As String
            '    strFID = IsDuplicate("SELECT Count(FG_Opening_Stock.FID) AS CountOfFID " _
            '        & " FROM FG_Opening_Stock INNER JOIN FGMaster ON FG_Opening_Stock.FID = FGMaster.FID " _
            '        & " WHERE FGMaster.FGName='" & lkupName.Text & "'")
            '    If strFID = True Then
            '        e.Cancel = True
            '        DevExpress.XtraEditors.XtraMessageBox.Show(Me, "This Finish Good Already Exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    End If
            'End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

End Class
