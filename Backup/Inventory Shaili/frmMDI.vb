Imports System.Data.OleDb
Public Class frmMDI
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
    Private WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents Bar1 As DevExpress.XtraBars.Bar
    Private WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents gddata As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvdata As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmddel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdedit As DevExpress.XtraEditors.SimpleButton
    Private WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarToolbarsListItem1 As DevExpress.XtraBars.BarToolbarsListItem
    Private WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDI))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarToolbarsListItem1 = New DevExpress.XtraBars.BarToolbarsListItem
        Me.gddata = New DevExpress.XtraGrid.GridControl
        Me.gvdata = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdadd = New DevExpress.XtraEditors.SimpleButton
        Me.cmddel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdedit = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gddata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImageList1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarToolbarsListItem1, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.Bar1.Text = "Custom 1"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "fgmaster"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BarButtonItem6.Caption = "Item Master"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.OwnFont = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.BarButtonItem6.UseOwnFont = True
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Border = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BarButtonItem7.Caption = "Finish Goods"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.Name = "BarButtonItem7"
        Me.BarButtonItem7.OwnFont = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.BarButtonItem7.UseOwnFont = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Item"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Finish_Good"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Experiment"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Item Master"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarToolbarsListItem1
        '
        Me.BarToolbarsListItem1.Caption = "fgmaster"
        Me.BarToolbarsListItem1.Id = 4
        Me.BarToolbarsListItem1.Name = "BarToolbarsListItem1"
        '
        'gddata
        '
        Me.gddata.EmbeddedNavigator.Name = ""
        Me.gddata.Location = New System.Drawing.Point(0, 48)
        Me.gddata.MainView = Me.gvdata
        Me.gddata.Name = "gddata"
        Me.gddata.Size = New System.Drawing.Size(608, 8)
        Me.gddata.TabIndex = 5
        Me.gddata.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvdata})
        '
        'gvdata
        '
        Me.gvdata.GridControl = Me.gddata
        Me.gvdata.Name = "gvdata"
        '
        'cmdadd
        '
        Me.cmdadd.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdadd.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmdadd.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.cmdadd.Appearance.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.Appearance.Options.UseBackColor = True
        Me.cmdadd.Appearance.Options.UseBorderColor = True
        Me.cmdadd.Appearance.Options.UseFont = True
        Me.cmdadd.Location = New System.Drawing.Point(168, 256)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(80, 32)
        Me.cmdadd.TabIndex = 6
        Me.cmdadd.Text = "&ADD"
        '
        'cmddel
        '
        Me.cmddel.Appearance.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddel.Appearance.Options.UseFont = True
        Me.cmddel.Enabled = False
        Me.cmddel.Location = New System.Drawing.Point(352, 256)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(80, 32)
        Me.cmddel.TabIndex = 8
        Me.cmddel.Text = "&DELETE"
        '
        'cmdedit
        '
        Me.cmdedit.Appearance.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdedit.Appearance.Options.UseFont = True
        Me.cmdedit.Enabled = False
        Me.cmdedit.Location = New System.Drawing.Point(256, 256)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(80, 32)
        Me.cmdedit.TabIndex = 7
        Me.cmdedit.Text = "&EDIT"
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 48)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(576, 168)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'frmMDI
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(600, 318)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cmddel)
        Me.Controls.Add(Me.cmdedit)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.gddata)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "frmMDI"
        Me.Text = "frmMDI"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gddata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            'Dim rsfinishgoods As New ADODB.Recordset
            'rsfinishgoods.Open("SELECT FGMaster.FGID, FGMaster.FGName, Unit.UnitName, FGMaster.Notes, FGMaster.CompID FROM FGMaster INNER JOIN Unit ON FGMaster.UnitID = Unit.UnitID WHERE (((FGMaster.CompID)=1))", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            'AxMSHFlexGrid1.DataSource = rsfinishgoods.DataSource
            'rsfinishgoods.Close()
            'stractivetable = "Finish_goods"
            griddata("fgmaster", GridControl1)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub

    'Private Sub AxMSHFlexGrid1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If AxMSHFlexGrid1.get_TextMatrix(AxMSHFlexGrid1.Row, 1) <> "" Then
    '        cmdedit.Enabled = True
    '        cmddel.Enabled = True
    '        ModMain.strgridid = AxMSHFlexGrid1.get_TextMatrix(AxMSHFlexGrid1.Row, 1)

    '    Else
    '        cmdedit.Enabled = False
    '        cmddel.Enabled = False
    '    End If

    'End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        Select Case stractivetable
            Case "Item"
                'Dim frmitemobj As New frmitem
                'ModMain.strgridid = AxMSHFlexGrid1.get_TextMatrix(AxMSHFlexGrid1.Row, 1)
                MsgBox(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, 1))
                ModMain.strgridid = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, 1)
                'frmitemobj.strcheck = "Edit"
                'frmitemobj.Show()
            Case "Finish_goods"
                Dim frmgoods As New frmfgmaster
                'ModMain.strgridid = AxMSHFlexGrid1.get_TextMatrix(AxMSHFlexGrid1.Row, 1)
                frmgoods.strcheck = "Edit"
                frmgoods.Show()
        End Select


    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        Select Case stractivetable
            Case "Item"
                MsgBox(stractivetable)
                Dim frmitemobj As New frmitem
                frmitemobj.strcheck = "Add"
                frmitemobj.Show()
            Case "Finish_goods"
                Dim frmgoods As New frmfgmaster
                frmgoods.strcheck = "Add"
                frmgoods.Show()
        End Select
    End Sub



    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim frmexpobj As New frmExperiment
        frmexpobj.Show()
    End Sub


    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click


        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, 1) <> "" Then
            MsgBox("done")
            'If GridView1.IsEmpty = False Then
            cmdedit.Enabled = True
            cmddel.Enabled = True
        Else
            MsgBox("not done")
            cmdedit.Enabled = False
            cmddel.Enabled = False
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'MsgBox(GridView1.GetRowCellValue(GridView1.FocusedValue, 1))
    End Sub



    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Try

            stractivetable = "Item"
            griddata("RMItemMaster", GridControl1)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub cmdadd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdadd.MouseEnter
        backcolour(cmdadd)
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Try
            stractivetable = "Finish_goods"
            griddata("FGmaster", GridControl1)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        Select Case stractivetable
            Case "Item"
                'conn.Execute("delete * from rmitemmaster where rmitemid = " & CInt(ModMain.strgridid) & " and compid = 1", conn,
            Case "Finish_goods"

        End Select

    End Sub

    Private Sub cmdedit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdedit.MouseEnter
        backcolour(cmdedit)
    End Sub

    Private Sub cmddel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmddel.MouseEnter
        backcolour(cmddel)
    End Sub

    Private Sub frmMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class

