Public Class frmRecallReg
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gvqc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkupBatch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents txtBatchNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMIS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdMIS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpBatch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdBatch As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdChallan As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtBatchNo = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.lkupBatch = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton
        Me.grdBatch = New DevExpress.XtraGrid.GridControl
        Me.gvqc = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.grdChallan = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.txtMIS = New DevExpress.XtraEditors.TextEdit
        Me.grdMIS = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grpBatch = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtBatchNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupBatch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdChallan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBatch.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtBatchNo)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.lkupBatch)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(296, 128)
        Me.GroupControl1.TabIndex = 0
        '
        'txtBatchNo
        '
        Me.txtBatchNo.EditValue = ""
        Me.txtBatchNo.Location = New System.Drawing.Point(8, 96)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Properties.ReadOnly = True
        Me.txtBatchNo.Size = New System.Drawing.Size(280, 20)
        Me.txtBatchNo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Batch No:"
        '
        'lkupBatch
        '
        Me.lkupBatch.Location = New System.Drawing.Point(8, 40)
        Me.lkupBatch.Name = "lkupBatch"
        Me.lkupBatch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupBatch.Properties.NullText = ""
        Me.lkupBatch.Size = New System.Drawing.Size(280, 20)
        Me.lkupBatch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Product:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item issued through MIS no :"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(8, 519)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(64, 24)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "&Report"
        '
        'grdBatch
        '
        Me.grdBatch.EmbeddedNavigator.Name = ""
        Me.grdBatch.Font = New System.Drawing.Font("Tahoma", 8.25!)
        GridLevelNode1.RelationName = "Level1"
        Me.grdBatch.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdBatch.Location = New System.Drawing.Point(8, 24)
        Me.grdBatch.MainView = Me.gvqc
        Me.grdBatch.Name = "grdBatch"
        Me.grdBatch.Size = New System.Drawing.Size(640, 244)
        Me.grdBatch.TabIndex = 16
        Me.grdBatch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvqc})
        '
        'gvqc
        '
        Me.gvqc.GridControl = Me.grdBatch
        Me.gvqc.Name = "gvqc"
        Me.gvqc.OptionsBehavior.Editable = False
        Me.gvqc.OptionsView.ShowGroupPanel = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(312, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 538)
        Me.Label3.TabIndex = 17
        '
        'grdChallan
        '
        Me.grdChallan.EmbeddedNavigator.Name = ""
        Me.grdChallan.Font = New System.Drawing.Font("Tahoma", 8.25!)
        GridLevelNode2.RelationName = "Level1"
        Me.grdChallan.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.grdChallan.Location = New System.Drawing.Point(8, 24)
        Me.grdChallan.MainView = Me.GridView1
        Me.grdChallan.Name = "grdChallan"
        Me.grdChallan.Size = New System.Drawing.Size(640, 220)
        Me.grdChallan.TabIndex = 18
        Me.grdChallan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdChallan
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtMIS
        '
        Me.txtMIS.EditValue = ""
        Me.txtMIS.Location = New System.Drawing.Point(152, 161)
        Me.txtMIS.Name = "txtMIS"
        Me.txtMIS.Properties.ReadOnly = True
        Me.txtMIS.Size = New System.Drawing.Size(144, 20)
        Me.txtMIS.TabIndex = 19
        '
        'grdMIS
        '
        Me.grdMIS.EmbeddedNavigator.Name = ""
        Me.grdMIS.Font = New System.Drawing.Font("Tahoma", 8.25!)
        GridLevelNode3.RelationName = "Level1"
        Me.grdMIS.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3})
        Me.grdMIS.Location = New System.Drawing.Point(8, 270)
        Me.grdMIS.MainView = Me.GridView2
        Me.grdMIS.Name = "grdMIS"
        Me.grdMIS.Size = New System.Drawing.Size(296, 243)
        Me.grdMIS.TabIndex = 20
        Me.grdMIS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdMIS
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'grpBatch
        '
        Me.grpBatch.Controls.Add(Me.grdBatch)
        Me.grpBatch.Location = New System.Drawing.Point(321, 270)
        Me.grpBatch.Name = "grpBatch"
        Me.grpBatch.Size = New System.Drawing.Size(653, 273)
        Me.grpBatch.TabIndex = 21
        Me.grpBatch.Text = "Batch Creation Details"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grdChallan)
        Me.GroupControl3.Location = New System.Drawing.Point(321, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(653, 249)
        Me.GroupControl3.TabIndex = 22
        Me.GroupControl3.Text = "Product Sales Details"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(8, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(973, 2)
        Me.Label5.TabIndex = 23
        '
        'frmRecallReg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(986, 555)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.grpBatch)
        Me.Controls.Add(Me.grdMIS)
        Me.Controls.Add(Me.txtMIS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecallReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recall Register"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtBatchNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupBatch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdBatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdChallan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBatch.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dsChallan As New DataSet
    Private Sub frmRecallReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'FillLookup("select fgname,fid from fgmaster", "FGmaster", "Product Name", "FID", lkupFGName)
            FillLookup("SELECT FGMaster.FGName, FinishGoods_QCDetail.Batch_NO,FGMaster.FGName + FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.MIS_NO " _
                & " FROM FGMaster INNER JOIN FinishGoods_QCDetail ON FGMaster.FID = FinishGoods_QCDetail.FID ", "Batch", "Product Name", "Batch No", lkupBatch, "B", " SELECT FGMaster.FGName, TI_Rec_Det.Batch_No,FGMaster.FGName + TI_Rec_Det.Batch_No  " _
                & " FROM (TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) INNER JOIN FGMaster ON TI_Rec_Det.FID = FGMaster.FID;")

            lkupBatch.Properties.Columns(1).Visible = True
            lkupBatch.Properties.Columns(2).Visible = False
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupBatch_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupBatch.EditValueChanged
        Try
            If lkupBatch.EditValue <> "" Then
                Dim row As DataRowView = lkupBatch.Properties.GetDataSourceRowByKeyValue(lkupBatch.EditValue)
                gvqc.Columns.Clear()
                'lkupBatch.Tag = row(1).ToString
                txtBatchNo.Text = row(1).ToString
                txtBatchNo.Tag = row(3).ToString
                txtMIS.Text = row(3).ToString
                If txtBatchNo.Tag <> "" Then
                    GridView2.Columns.Clear()
                    GridView1.Columns.Clear()
                    ShowMISDetails()
                Else
                    GridView2.Columns.Clear()
                    GridView1.Columns.Clear()
                    showPurchaseDet()
                End If
                ShowChallanDetails()
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub showPurchaseDet()
        Try
            Dim dsMIS As New DataSet
            dsMIS.Tables.Clear()
            Dim strSql As String
            strSql = "SELECT SupplierMaster.SuppName,SupplierMaster.SuppName, TI_Rec_Master.RecDate, Sum(TI_Rec_Det.QTY) AS QTY " _
                & " FROM ((TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) INNER JOIN SupplierMaster ON TI_Rec_Master.SID = SupplierMaster.SID) INNER JOIN FGMaster ON TI_Rec_Det.FID = FGMaster.FID " _
                & " GROUP BY SupplierMaster.SuppName, TI_Rec_Master.RecDate, TI_Rec_Det.Batch_No, FGMaster.FGName " _
                & " HAVING (((TI_Rec_Det.Batch_No)='" & txtBatchNo.Text & "') AND ((FGMaster.FGName)='" & lkupBatch.Text.Trim & "')); "

            Dim apt As New OleDb.OleDbDataAdapter(strSql, conn)
            apt.Fill(dsMIS, "Purchase")
            grdMIS.DataSource = dsMIS.Tables(0)
            GridView2.Columns(0).Visible = False
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub ShowMISDetails()
        Try
            Dim dsMIS As New DataSet
            dsMIS.Tables.Clear()
            Dim strSql As String
            strSql = "SELECT RMItemMaster.rid, RMItemMaster.RMItemName as [Item Name], Material_Issue_Detail.RMVI_NO as RMVINO " _
                & " FROM Material_Issue_Detail INNER JOIN RMItemMaster ON Material_Issue_Detail.RID = RMItemMaster.Rid " _
                & " WHERE (((Material_Issue_Detail.MIS_NO)='" & txtBatchNo.Tag & "'))"

            Dim apt As New OleDb.OleDbDataAdapter(strSql, conn)
            apt.Fill(dsMIS, "MIS")
            grdMIS.DataSource = dsMIS.Tables(0)
            GridView2.Columns(0).Visible = False
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub ShowChallanDetails()
        Try
            Dim strsql As String


            strsql = "SELECT CustomerMaster.CustName, ChallanMaster.Challan_No, ChallanMaster.Challan_dt " _
                & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID " _
                & " WHERE (((ChallanDetail.BatchID)='" & txtBatchNo.Text & "'))"

            Dim apt As New OleDb.OleDbDataAdapter(strsql, conn)
            dsChallan.Tables.Clear()
            apt.Fill(dsChallan, "Challan")
            grdChallan.DataSource = dsChallan.Tables(0)
            apt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Try
            Dim strSql As String
            Dim dsBatch As New DataSet
            strSql = "SELECT FinishGoods_QCDetail.Batch_NO, FGMaster.FGName, FinishGoods_QCMaster.VI_Date as [Batch Date], Material_Issue_Detail.RMVI_NO as RMVINO " _
                & " FROM (FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID) INNER JOIN Material_Issue_Detail ON FinishGoods_QCDetail.MIS_NO = Material_Issue_Detail.MIS_NO " _
                & " WHERE (((Material_Issue_Detail.RMVI_NO)='" & GridView2.GetFocusedRowCellValue("RMVINO") & "')) and Material_Issue_Detail.RID ='" & GridView2.GetFocusedRowCellValue("rid") & "'"

            dsBatch.Tables.Clear()
            Dim apt As New OleDb.OleDbDataAdapter(strSql, conn)
            apt.Fill(dsBatch, "Batch")
            grdBatch.DataSource = dsBatch.Tables(0)


            ShowChallanDetails()
            For i As Integer = 0 To dsBatch.Tables(0).Rows.Count - 1
                strSql = "SELECT CustomerMaster.CustName, ChallanMaster.Challan_No, ChallanMaster.Challan_dt " _
                    & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID " _
                    & " WHERE (((ChallanDetail.BatchID)='" & dsBatch.Tables(0).Rows(i).Item(0) & "'))"
                apt.SelectCommand.CommandText = strSql
                apt.SelectCommand.Connection = conn
                apt.Fill(dsChallan, "Challan")
            Next
            grdChallan.DataSource = dsChallan.Tables(0)
            apt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub subMISReport()
        Try
            Dim strSql As String
            strSql = "SELECT RMItemMaster.rid, RMItemMaster.RMItemName , Material_Issue_Detail.RMVI_NO as RMVINO " _
                          & " FROM Material_Issue_Detail INNER JOIN RMItemMaster ON Material_Issue_Detail.RID = RMItemMaster.Rid " _
                          & " WHERE (((Material_Issue_Detail.MIS_NO)='" & txtBatchNo.Tag & "'))"

            Dim apt As New OleDb.OleDbDataAdapter(strSql, conn)
            apt.Fill(dsSub, "MIS")
            apt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub subChallanReport()
        Try

            Dim strSql As String
            strSql = "SELECT CustomerMaster.CustName, ChallanMaster.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as CDate " _
                 & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID " _
                 & " WHERE (((ChallanDetail.BatchID)='" & txtBatchNo.Text & "'))"
            Dim apt As New OleDb.OleDbDataAdapter(strSql, conn)
            apt.Fill(dsSub, "Challan")

            apt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub subBatchReport()
        Try
            Dim strSql As String
            If txtBatchNo.Tag <> "" Then
                strSql = "SELECT FinishGoods_QCDetail.Batch_NO, FGMaster.FGName, format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, Material_Issue_Detail.RMVI_NO as RMVINO " _
                    & " FROM (FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID) INNER JOIN Material_Issue_Detail ON FinishGoods_QCDetail.MIS_NO = Material_Issue_Detail.MIS_NO " _
                    & " WHERE (((Material_Issue_Detail.RMVI_NO)='" & GridView2.GetFocusedRowCellValue("RMVINO") & "'));"
            Else
                strSql = "SELECT TI_Rec_Master.RecNo as Batch_No,SupplierMaster.SuppName as FGName,SupplierMaster.SuppName,format(TI_Rec_Master.RecDate,'DD/MM/YYYY') AS VDate , Sum(TI_Rec_Det.QTY) AS QTY " _
                    & " FROM ((TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) INNER JOIN SupplierMaster ON TI_Rec_Master.SID = SupplierMaster.SID) INNER JOIN FGMaster ON TI_Rec_Det.FID = FGMaster.FID " _
                    & " GROUP BY SupplierMaster.SuppName, TI_Rec_Master.RecDate, TI_Rec_Master.RecNo, TI_Rec_Det.Batch_No, FGMaster.FGName " _
                    & " HAVING (((TI_Rec_Det.Batch_No)='" & txtBatchNo.Text & "') AND ((FGMaster.FGName)='" & lkupBatch.Text.Trim & "')); "
            End If

            Dim apt As New OleDb.OleDbDataAdapter(strSql, conn)
            apt.Fill(dsSub, "Batch")
            For i As Integer = 0 To dsSub.Tables("Batch").Rows.Count - 1
                strSql = "SELECT CustomerMaster.CustName, ChallanMaster.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as CDate " _
                                 & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID " _
                                 & " WHERE (((ChallanDetail.BatchID)='" & dsSub.Tables("Batch").Rows(i).Item(0) & "'))"
                apt.SelectCommand.CommandText = strSql
                apt.SelectCommand.Connection = conn
                apt.Fill(dsSub, "Challan")
            Next
            apt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            Dim myrpt As New rptRecallReg
            Dim rptBRcall As New rptBatchRecall
            Dim ds As New DataSet
            

            Dim strSql As String
            dsSub = New DataSet

            If txtBatchNo.Tag <> "" Then
                subMISReport()
            End If

            subChallanReport()

            subBatchReport()

            strSql = "Select CompanyName from companyMaster"
            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "Company")
            If txtBatchNo.Tag = "" Then

                rptBRcall.XrLabel2.Text = "Trading Purchase Details"

                rptBRcall.XrLabel9.Text = "Date"
                rptBRcall.XrLabel10.Text = "Trading No"
                rptBRcall.XrLabel11.Text = "Supplier Name"

                myrpt.Subreport2.ReportSource = rptBRcall
            End If

            myrpt.DataSource = ds
            myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")

            myrpt.ShowPreview()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class
