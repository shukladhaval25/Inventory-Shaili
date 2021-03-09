Public Class frmExperiment
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkupUnit As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lkupUnit = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Example of Combo box"
        '
        'GridControl1
        '
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(16, 96)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(520, 248)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'lkupUnit
        '
        Me.lkupUnit.Location = New System.Drawing.Point(136, 16)
        Me.lkupUnit.Name = "lkupUnit"
        '
        'lkupUnit.Properties
        '
        Me.lkupUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupUnit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name1"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2")})
        Me.lkupUnit.Size = New System.Drawing.Size(400, 20)
        Me.lkupUnit.TabIndex = 3
        '
        'frmExperiment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(544, 406)
        Me.Controls.Add(Me.lkupUnit)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExperiment"
        Me.Text = "frmExperiment"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

   
    Private Sub LookUpEdit1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupUnit.GotFocus
        ''Dim dsOwner As DataSet
        ''Dim CmdSet As New ADODB.Command


        '    ''To fill  LookUpEditBox
        '    'lkupUnit.Properties.DataSource = dsOwner.Tables(0)
        '    'lkupUnit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(dsOwner.Tables(0).Columns(0).ToString))
        '    'lkupUnit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(dsOwner.Tables(0).Columns(1).ToString))
        '    'lkupUnit.Properties.DisplayMember = dsOwner.Tables(0).Columns(0).ToString
        '    'lkupUnit.Properties.ValueMember = dsOwner.Tables(0).Columns(1).ToString
        '    'lkupUnit.Properties.Columns(0).Caption = "User Name"
        '    'lkupUnit.Properties.Columns(1).Caption = "User ID"
        '    'lkupUnit.Properties.Columns(dsOwner.Tables(0).Columns(1).ToString).Visible = False
        '    '
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub frmExperiment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim rsTemp As New ADODB.Recordset
        Try
            'rsTemp.Open("select unitname ,unitid from unit", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            'lkupUnit.Properties.DataSource = rsTemp.DataSource
            ''Do While rsTemp.EOF <> True

            'lkupUnit.Properties.Columns.Add((New DevExpress.XtraEditors.Controls.LookUpColumnInfo(rsTemp.Fields(0).Value)))
            'lkupUnit.Properties.Columns.Add((New DevExpress.XtraEditors.Controls.LookUpColumnInfo(rsTemp.Fields(1).Value)))
            'lkupUnit.Properties.DisplayMember = rsTemp.Fields(0).Value
            'lkupUnit.Properties.ValueMember = rsTemp.Fields(0).Value
            'lkupUnit.Properties.GetDataSourceRowByDisplayValue(lkupUnit.EditValue)
            ''rsTemp.MoveNext()
            ''Loop
            FillLookUp()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub lkupUnit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupUnit.EditValueChanged

    End Sub

    Private Sub FillLookUp()
        Try
            'Dim dvMain As DataView
            'Dim dvUnit As DataView
            'Dim ds As DataSet = New DataSet

            'Dim dbAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [Order Details]", conn)
            'dbAdapter.Fill(ds, "Order Details")
            'Dim dbAdapter As System.Data.OleDb.OleDbDataAdapter
            'dbAdapter = New System.Data.OleDb.OleDbDataAdapter("select unitname ,unitid from unit", conn.ConnectionString)
            'dbAdapter.Fill(ds, "Unit")
            'Dim dvm As DataViewManager = New DataViewManager(ds)
            ''dvMain = dvm.CreateDataView(ds.Tables("Order Details"))
            'dvUnit = dvm.CreateDataView(ds.Tables("Unit"))
            'lkupUnit.DataBindings.Add("EditValue", dvUnit, "UnitID")


            Dim dvProducts As DataView
            Dim dvMain As DataView
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "\Inventory.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName
                Dim dbAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM unit", con)
                dbAdapter.Fill(ds, "Order Details")
                dbAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM unit", con)
                dbAdapter.Fill(ds, "Products")
                Dim dvm As DataViewManager = New DataViewManager(ds)
                dvMain = dvm.CreateDataView(ds.Tables("Order Details"))
                dvProducts = dvm.CreateDataView(ds.Tables("Products"))
            End If

            lkupUnit.Properties.DataSource = dvProducts
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class

