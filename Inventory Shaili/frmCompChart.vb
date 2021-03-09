Public Class frmCompChart
    Inherits DevExpress.XtraEditors.XtraForm
    Dim dt As New DataTable
    Dim ds As New DataSet
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
    Friend WithEvents lstItem As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAddFirst As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddSecond As DevExpress.XtraEditors.SimpleButton
    'Friend WithEvents AxMSChart1 As AxMSChart20Lib.AxMSChart
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCompChart))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnAddSecond = New DevExpress.XtraEditors.SimpleButton
        Me.btnAddFirst = New DevExpress.XtraEditors.SimpleButton
        Me.txtSItem = New DevExpress.XtraEditors.TextEdit
        Me.txtFItem = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstItem = New DevExpress.XtraEditors.ListBoxControl
        'Me.AxMSChart1 = New AxMSChart20Lib.AxMSChart
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtSItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstItem, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.AxMSChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.btnAddSecond)
        Me.GroupControl1.Controls.Add(Me.btnAddFirst)
        Me.GroupControl1.Controls.Add(Me.txtSItem)
        Me.GroupControl1.Controls.Add(Me.txtFItem)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lstItem)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(296, 320)
        Me.GroupControl1.TabIndex = 0
        '
        'btnAddSecond
        '
        Me.btnAddSecond.Location = New System.Drawing.Point(152, 232)
        Me.btnAddSecond.Name = "btnAddSecond"
        Me.btnAddSecond.Size = New System.Drawing.Size(136, 24)
        Me.btnAddSecond.TabIndex = 6
        Me.btnAddSecond.Text = "Add To Selection"
        '
        'btnAddFirst
        '
        Me.btnAddFirst.Location = New System.Drawing.Point(8, 232)
        Me.btnAddFirst.Name = "btnAddFirst"
        Me.btnAddFirst.Size = New System.Drawing.Size(136, 24)
        Me.btnAddFirst.TabIndex = 5
        Me.btnAddFirst.Text = "Add To Selection"
        '
        'txtSItem
        '
        Me.txtSItem.EditValue = ""
        Me.txtSItem.Location = New System.Drawing.Point(152, 288)
        Me.txtSItem.Name = "txtSItem"
        Me.txtSItem.Size = New System.Drawing.Size(136, 20)
        Me.txtSItem.TabIndex = 4
        '
        'txtFItem
        '
        Me.txtFItem.EditValue = ""
        Me.txtFItem.Location = New System.Drawing.Point(8, 288)
        Me.txtFItem.Name = "txtFItem"
        Me.txtFItem.Size = New System.Drawing.Size(136, 20)
        Me.txtFItem.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Second Item"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Item"
        '
        'lstItem
        '
        Me.lstItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lstItem.ItemHeight = 16
        Me.lstItem.Location = New System.Drawing.Point(8, 16)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(280, 208)
        Me.lstItem.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.lstItem.TabIndex = 0
        '
        'AxMSChart1
        '
        'Me.AxMSChart1.DataSource = Nothing
        'Me.AxMSChart1.Location = New System.Drawing.Point(8, 328)
        'Me.AxMSChart1.Name = "AxMSChart1"
        'Me.AxMSChart1.OcxState = CType(resources.GetObject("AxMSChart1.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.AxMSChart1.Size = New System.Drawing.Size(296, 184)
        'Me.AxMSChart1.TabIndex = 1
        ''
        ''GridControl1
        '
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(312, 8)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(360, 272)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(132, Byte), CType(171, Byte), CType(228, Byte))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(251, Byte), CType(255, Byte))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(154, Byte), CType(190, Byte), CType(243, Byte))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(251, Byte), CType(255, Byte))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(231, Byte), CType(242, Byte), CType(254, Byte))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(132, Byte), CType(171, Byte), CType(228, Byte))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(62, Byte), CType(109, Byte), CType(185, Byte))
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(49, Byte), CType(106, Byte), CType(197, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(132, Byte), CType(171, Byte), CType(228, Byte))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(216, Byte), CType(247, Byte))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(216, Byte), CType(247, Byte))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(216, Byte), CType(247, Byte))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(216, Byte), CType(247, Byte))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(62, Byte), CType(109, Byte), CType(185, Byte))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(216, Byte), CType(247, Byte))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(216, Byte), CType(247, Byte))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(132, Byte), CType(171, Byte), CType(228, Byte))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(106, Byte), CType(153, Byte), CType(228, Byte))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(208, Byte), CType(224, Byte), CType(251, Byte))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(99, Byte), CType(127, Byte), CType(196, Byte))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(252, Byte), CType(255, Byte))
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(88, Byte), CType(129, Byte), CType(185, Byte))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(69, Byte), CType(126, Byte), CType(217, Byte))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(99, Byte), CType(127, Byte), CType(196, Byte))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GridView1.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.GridView1.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'frmCompChart
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(680, 518)
        Me.Controls.Add(Me.GridControl1)
        'Me.Controls.Add(Me.AxMSChart1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmCompChart"
        Me.Text = "frmCompChart"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtSItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstItem, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.AxMSChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCompChart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            dt.Columns.Add("Type", System.Type.GetType("System.String"))
            dt.Columns.Add(IIf(txtFItem.Text <> "", txtFItem.Text.Trim, ""), System.Type.GetType("System.String"))
            dt.Columns.Add(IIf(txtSItem.Text <> "", txtSItem.Text.Trim, ""), System.Type.GetType("System.String"))

            Dim DR As OleDb.OleDbDataReader
            cmd = New OleDb.OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select FGName,FID from FGMaster order by FGName"
            cmd.Connection = conn
            DR = cmd.ExecuteReader
            Do While DR.Read
                lstItem.Items.Add(DR.Item(0))
            Loop
            DR.Close()
            cmd.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnAddFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFirst.Click
        Try
            If lstItem.SelectedItem <> "" Then
                txtFItem.Text = lstItem.SelectedItem
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Select FID from FGMaster where FGName = '" & lstItem.SelectedItem & "'"
                txtFItem.Tag = cmd.ExecuteScalar
                cmd.Dispose()
                GetChartData(txtFItem.Tag, 1)
                GetGridData(txtFItem.Tag, 1)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GetGridData(ByVal strID As String, ByVal intItem As Integer)
        Try

            dt.Columns(0).Caption = ""
            dt.Columns(1).Caption = txtFItem.Text
            dt.Columns(2).Caption = txtSItem.Text

            Dim str As String
            str = "SELECT Draw_No,Min_Qty from FGMaster where FID='" & strID & "'"
            Dim adp As New OleDb.OleDbDataAdapter(str, conn)
            adp.Fill(ds, "Master")
            Dim dr As DataRow

            If dt.Rows.Count >= 3 Then
               
                If intItem = 1 Then
                    dt.Rows(0).Item(1) = ds.Tables("Master").Rows(0).Item(0)
                    dt.Rows(1).Item(1) = ds.Tables("Master").Rows(0).Item(1)
                    dt.Rows(2).Item(1) = ds.Tables("Sales1").Rows(0).Item(0)
                Else
                    dt.Rows(0).Item(2) = ds.Tables("Master").Rows(0).Item(0)
                    dt.Rows(1).Item(2) = ds.Tables("Master").Rows(0).Item(1)
                    dt.Rows(2).Item(2) = ds.Tables("Sales2").Rows(0).Item(0)
                End If
            Else
                    dr = dt.NewRow
                    dr.Item(0) = "Drawing No"
                    If intItem = 1 Then
                        dr.Item(1) = ds.Tables("Master").Rows(0).Item(0)
                    Else
                        dr.Item(2) = ds.Tables("Master").Rows(0).Item(0)
                    End If
                    dt.Rows.Add(dr)

                    dr = dt.NewRow
                    dr.Item(0) = "Minimum Qty"
                    If intItem = 1 Then
                        dr.Item(1) = ds.Tables("Master").Rows(0).Item(1)
                    Else
                        dr.Item(2) = ds.Tables("Master").Rows(0).Item(1)
                    End If
                    dt.Rows.Add(dr)

                    dr = dt.NewRow
                    dr.Item(0) = "Total Sales"
                    If intItem = 1 Then
                        dr.Item(1) = ds.Tables("Sales1").Rows(0).Item(0)
                    Else
                        dr.Item(2) = ds.Tables("Sales2").Rows(0).Item(0)
                    End If
                    dt.Rows.Add(dr)

                End If

                GridControl1.DataSource = dt
                GridControl1.Visible = True
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub GetChartData(ByVal strID As String, ByVal intItem As Integer)
        Try
            Dim str As String
            str = "SELECT Sum(ChallanDetail.Qty) AS SumOfQty " _
                    & " FROM(ChallanDetail) " _
                    & " WHERE (((ChallanDetail.FID)='" & strID & "'));"
            Dim adp As New OleDb.OleDbDataAdapter(str, conn)
            If intItem = 1 Then
                'ds.Tables("Sales1").Rows.Clear()
                adp.Fill(ds, "Sales1")
            Else
                'ds.Tables("Sales2").Rows.Clear()
                adp.Fill(ds, "Sales2")
            End If
            'AxMSChart1.chartType = MSChart20Lib.VtChChartType.VtChChartType2dLine
            'AxMSChart1.RowLabel = txtFItem.Text
            'AxMSChart1.ColumnLabel = "Sales"

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnAddSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSecond.Click
        Try
            If lstItem.SelectedItem <> "" Then
                txtSItem.Text = lstItem.SelectedItem
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Select FID from FGMaster where FGName = '" & lstItem.SelectedItem & "'"
                txtSItem.Tag = cmd.ExecuteScalar
                cmd.Dispose()
                GetChartData(txtSItem.Tag, 2)
                GetGridData(txtSItem.Tag, 2)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class

