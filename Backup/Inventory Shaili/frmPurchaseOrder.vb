

Public Class FrmPurchaseOrder


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
    Friend WithEvents gvpop As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtqtn As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpop As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblpopdate As System.Windows.Forms.Label
    Friend WithEvents txtqtnno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblquodate As System.Windows.Forms.Label
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbsuppid As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtdeldate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblunitid As System.Windows.Forms.Label
    Friend WithEvents txtqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents gdpopdetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents lbldeldate As System.Windows.Forms.Label
    Friend WithEvents lblquono As System.Windows.Forms.Label
    Friend WithEvents lblsuppname As System.Windows.Forms.Label
    Friend WithEvents lblpopno As System.Windows.Forms.Label
    Friend WithEvents lblterms As System.Windows.Forms.Label
    Friend WithEvents txtterms As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents txtunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grppurchase As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdAddSupp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkupItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddFG As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFindSupp As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.gvpop = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gdpopdetail = New DevExpress.XtraGrid.GridControl
        Me.grppurchase = New DevExpress.XtraEditors.GroupControl
        Me.btnFindSupp = New DevExpress.XtraEditors.SimpleButton
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAddSupp = New DevExpress.XtraEditors.SimpleButton
        Me.lblterms = New System.Windows.Forms.Label
        Me.txtterms = New DevExpress.XtraEditors.TextEdit
        Me.dtqtn = New DevExpress.XtraEditors.DateEdit
        Me.dtpop = New DevExpress.XtraEditors.DateEdit
        Me.lblpopdate = New System.Windows.Forms.Label
        Me.txtqtnno = New DevExpress.XtraEditors.TextEdit
        Me.lblquodate = New System.Windows.Forms.Label
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdclose = New DevExpress.XtraEditors.SimpleButton
        Me.cmbsuppid = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtunit = New DevExpress.XtraEditors.TextEdit
        Me.txtrate = New DevExpress.XtraEditors.TextEdit
        Me.lblrate = New System.Windows.Forms.Label
        Me.lblunitid = New System.Windows.Forms.Label
        Me.txtqty = New DevExpress.XtraEditors.TextEdit
        Me.lblqty = New System.Windows.Forms.Label
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.lblRaw = New System.Windows.Forms.Label
        Me.lbldeldate = New System.Windows.Forms.Label
        Me.dtdeldate = New DevExpress.XtraEditors.DateEdit
        Me.lkupItemName = New DevExpress.XtraEditors.LookUpEdit
        Me.lblquono = New System.Windows.Forms.Label
        Me.lblsuppname = New System.Windows.Forms.Label
        Me.lblpopno = New System.Windows.Forms.Label
        Me.txtPono = New DevExpress.XtraEditors.TextEdit
        Me.cmdAddFG = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gvpop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdpopdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grppurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grppurchase.SuspendLayout()
        CType(Me.txtterms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtqtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqtnno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbsuppid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdeldate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvpop
        '
        Me.gvpop.GridControl = Me.gdpopdetail
        Me.gvpop.Name = "gvpop"
        Me.gvpop.OptionsBehavior.Editable = False
        Me.gvpop.OptionsCustomization.AllowColumnMoving = False
        Me.gvpop.OptionsCustomization.AllowGroup = False
        Me.gvpop.OptionsMenu.EnableFooterMenu = False
        Me.gvpop.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvpop.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvpop.OptionsView.ShowGroupPanel = False
        '
        'gdpopdetail
        '
        '
        '
        '
        Me.gdpopdetail.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.gdpopdetail.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gdpopdetail.Location = New System.Drawing.Point(8, 72)
        Me.gdpopdetail.MainView = Me.gvpop
        Me.gdpopdetail.Name = "gdpopdetail"
        Me.gdpopdetail.Size = New System.Drawing.Size(512, 176)
        Me.gdpopdetail.TabIndex = 17
        Me.gdpopdetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvpop})
        '
        'grppurchase
        '
        Me.grppurchase.Controls.Add(Me.btnFindSupp)
        Me.grppurchase.Controls.Add(Me.btnReport)
        Me.grppurchase.Controls.Add(Me.cmdAddSupp)
        Me.grppurchase.Controls.Add(Me.lblterms)
        Me.grppurchase.Controls.Add(Me.txtterms)
        Me.grppurchase.Controls.Add(Me.dtqtn)
        Me.grppurchase.Controls.Add(Me.dtpop)
        Me.grppurchase.Controls.Add(Me.lblpopdate)
        Me.grppurchase.Controls.Add(Me.txtqtnno)
        Me.grppurchase.Controls.Add(Me.lblquodate)
        Me.grppurchase.Controls.Add(Me.cmdsave)
        Me.grppurchase.Controls.Add(Me.cmdclose)
        Me.grppurchase.Controls.Add(Me.cmbsuppid)
        Me.grppurchase.Controls.Add(Me.PanelControl1)
        Me.grppurchase.Controls.Add(Me.lblquono)
        Me.grppurchase.Controls.Add(Me.lblsuppname)
        Me.grppurchase.Controls.Add(Me.lblpopno)
        Me.grppurchase.Controls.Add(Me.txtPono)
        Me.grppurchase.Location = New System.Drawing.Point(8, 8)
        Me.grppurchase.Name = "grppurchase"
        Me.grppurchase.Size = New System.Drawing.Size(546, 416)
        Me.grppurchase.TabIndex = 1
        Me.grppurchase.Text = "Purchase Order Master and Detail"
        '
        'btnFindSupp
        '
        Me.btnFindSupp.Location = New System.Drawing.Point(72, 384)
        Me.btnFindSupp.Name = "btnFindSupp"
        Me.btnFindSupp.Size = New System.Drawing.Size(80, 25)
        Me.btnFindSupp.TabIndex = 36
        Me.btnFindSupp.Text = "&Find Supplier"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(8, 384)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(56, 25)
        Me.btnReport.TabIndex = 34
        Me.btnReport.Text = "&Report"
        '
        'cmdAddSupp
        '
        Me.cmdAddSupp.Location = New System.Drawing.Point(264, 52)
        Me.cmdAddSupp.Name = "cmdAddSupp"
        Me.cmdAddSupp.Size = New System.Drawing.Size(40, 21)
        Me.cmdAddSupp.TabIndex = 33
        Me.cmdAddSupp.Text = "&Add..."
        '
        'lblterms
        '
        Me.lblterms.AutoSize = True
        Me.lblterms.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterms.Location = New System.Drawing.Point(8, 80)
        Me.lblterms.Name = "lblterms"
        Me.lblterms.Size = New System.Drawing.Size(45, 16)
        Me.lblterms.TabIndex = 32
        Me.lblterms.Text = "Terms"
        Me.lblterms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtterms
        '
        Me.txtterms.EditValue = ""
        Me.txtterms.Location = New System.Drawing.Point(112, 80)
        Me.txtterms.Name = "txtterms"
        '
        '
        '
        Me.txtterms.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtterms.Properties.Appearance.Options.UseFont = True
        Me.txtterms.Size = New System.Drawing.Size(192, 22)
        Me.txtterms.TabIndex = 6
        '
        'dtqtn
        '
        Me.dtqtn.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.dtqtn.Location = New System.Drawing.Point(408, 80)
        Me.dtqtn.Name = "dtqtn"
        '
        '
        '
        Me.dtqtn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtqtn.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtqtn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtqtn.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtqtn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtqtn.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtqtn.Size = New System.Drawing.Size(128, 20)
        Me.dtqtn.TabIndex = 5
        '
        'dtpop
        '
        Me.dtpop.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.dtpop.Location = New System.Drawing.Point(408, 24)
        Me.dtpop.Name = "dtpop"
        Me.dtpop.Size = New System.Drawing.Size(128, 20)
        Me.dtpop.TabIndex = 35
        '
        'lblpopdate
        '
        Me.lblpopdate.AutoSize = True
        Me.lblpopdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpopdate.Location = New System.Drawing.Point(320, 24)
        Me.lblpopdate.Name = "lblpopdate"
        Me.lblpopdate.Size = New System.Drawing.Size(39, 16)
        Me.lblpopdate.TabIndex = 30
        Me.lblpopdate.Text = "Date:"
        '
        'txtqtnno
        '
        Me.txtqtnno.EditValue = ""
        Me.txtqtnno.Location = New System.Drawing.Point(408, 52)
        Me.txtqtnno.Name = "txtqtnno"
        '
        '
        '
        Me.txtqtnno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtnno.Properties.Appearance.Options.UseFont = True
        Me.txtqtnno.Size = New System.Drawing.Size(128, 22)
        Me.txtqtnno.TabIndex = 4
        '
        'lblquodate
        '
        Me.lblquodate.AutoSize = True
        Me.lblquodate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquodate.Location = New System.Drawing.Point(320, 80)
        Me.lblquodate.Name = "lblquodate"
        Me.lblquodate.Size = New System.Drawing.Size(39, 16)
        Me.lblquodate.TabIndex = 28
        Me.lblquodate.Text = "Date:"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(408, 384)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(56, 25)
        Me.cmdsave.TabIndex = 14
        Me.cmdsave.Text = "&Save"
        '
        'cmdclose
        '
        Me.cmdclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdclose.Location = New System.Drawing.Point(472, 384)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(56, 25)
        Me.cmdclose.TabIndex = 15
        Me.cmdclose.Text = "&Close"
        '
        'cmbsuppid
        '
        Me.cmbsuppid.EditValue = ""
        Me.cmbsuppid.Location = New System.Drawing.Point(112, 52)
        Me.cmbsuppid.Name = "cmbsuppid"
        '
        '
        '
        Me.cmbsuppid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbsuppid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbsuppid.Size = New System.Drawing.Size(144, 20)
        Me.cmbsuppid.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAddFG)
        Me.PanelControl1.Controls.Add(Me.txtunit)
        Me.PanelControl1.Controls.Add(Me.txtrate)
        Me.PanelControl1.Controls.Add(Me.lblrate)
        Me.PanelControl1.Controls.Add(Me.lblunitid)
        Me.PanelControl1.Controls.Add(Me.txtqty)
        Me.PanelControl1.Controls.Add(Me.lblqty)
        Me.PanelControl1.Controls.Add(Me.gdpopdetail)
        Me.PanelControl1.Controls.Add(Me.cmdAdd)
        Me.PanelControl1.Controls.Add(Me.cmdDelete)
        Me.PanelControl1.Controls.Add(Me.lblRaw)
        Me.PanelControl1.Controls.Add(Me.lbldeldate)
        Me.PanelControl1.Controls.Add(Me.dtdeldate)
        Me.PanelControl1.Controls.Add(Me.lkupItemName)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 120)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(528, 256)
        Me.PanelControl1.TabIndex = 7
        Me.PanelControl1.Text = "PanelControl1"
        '
        'txtunit
        '
        Me.txtunit.EditValue = ""
        Me.txtunit.Location = New System.Drawing.Point(48, 40)
        Me.txtunit.Name = "txtunit"
        '
        '
        '
        Me.txtunit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.Properties.Appearance.Options.UseFont = True
        Me.txtunit.Properties.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(48, 22)
        Me.txtunit.TabIndex = 8
        Me.txtunit.TabStop = False
        '
        'txtrate
        '
        Me.txtrate.EditValue = ""
        Me.txtrate.Location = New System.Drawing.Point(240, 40)
        Me.txtrate.Name = "txtrate"
        '
        '
        '
        Me.txtrate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Properties.Appearance.Options.UseFont = True
        Me.txtrate.Size = New System.Drawing.Size(48, 22)
        Me.txtrate.TabIndex = 10
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(200, 40)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(39, 16)
        Me.lblrate.TabIndex = 34
        Me.lblrate.Text = "Rate:"
        '
        'lblunitid
        '
        Me.lblunitid.AutoSize = True
        Me.lblunitid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitid.Location = New System.Drawing.Point(8, 40)
        Me.lblunitid.Name = "lblunitid"
        Me.lblunitid.Size = New System.Drawing.Size(35, 16)
        Me.lblunitid.TabIndex = 26
        Me.lblunitid.Text = "Unit:"
        '
        'txtqty
        '
        Me.txtqty.EditValue = ""
        Me.txtqty.Location = New System.Drawing.Point(144, 40)
        Me.txtqty.Name = "txtqty"
        '
        '
        '
        Me.txtqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Properties.Appearance.Options.UseFont = True
        Me.txtqty.Size = New System.Drawing.Size(48, 22)
        Me.txtqty.TabIndex = 9
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(112, 40)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(32, 16)
        Me.lblqty.TabIndex = 24
        Me.lblqty.Text = "Qty:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(406, 40)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 25)
        Me.cmdAdd.TabIndex = 13
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(464, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(56, 25)
        Me.cmdDelete.TabIndex = 16
        Me.cmdDelete.Text = "&Delete"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(8, 8)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(39, 16)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Item:"
        '
        'lbldeldate
        '
        Me.lbldeldate.AutoSize = True
        Me.lbldeldate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeldate.Location = New System.Drawing.Point(304, 8)
        Me.lbldeldate.Name = "lbldeldate"
        Me.lbldeldate.Size = New System.Drawing.Size(88, 16)
        Me.lbldeldate.TabIndex = 32
        Me.lbldeldate.Text = "Delivery Date:"
        Me.lbldeldate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtdeldate
        '
        Me.dtdeldate.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.dtdeldate.Location = New System.Drawing.Point(400, 8)
        Me.dtdeldate.Name = "dtdeldate"
        '
        '
        '
        Me.dtdeldate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtdeldate.Size = New System.Drawing.Size(120, 20)
        Me.dtdeldate.TabIndex = 11
        '
        'lkupItemName
        '
        Me.lkupItemName.EditValue = ""
        Me.lkupItemName.Location = New System.Drawing.Point(48, 8)
        Me.lkupItemName.Name = "lkupItemName"
        '
        '
        '
        Me.lkupItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupItemName.Properties.NullText = ""
        Me.lkupItemName.Size = New System.Drawing.Size(240, 20)
        Me.lkupItemName.TabIndex = 7
        '
        'lblquono
        '
        Me.lblquono.AutoSize = True
        Me.lblquono.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquono.Location = New System.Drawing.Point(320, 52)
        Me.lblquono.Name = "lblquono"
        Me.lblquono.Size = New System.Drawing.Size(91, 16)
        Me.lblquono.TabIndex = 4
        Me.lblquono.Text = "Quotation No.:"
        '
        'lblsuppname
        '
        Me.lblsuppname.AutoSize = True
        Me.lblsuppname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppname.Location = New System.Drawing.Point(8, 52)
        Me.lblsuppname.Name = "lblsuppname"
        Me.lblsuppname.Size = New System.Drawing.Size(97, 16)
        Me.lblsuppname.TabIndex = 2
        Me.lblsuppname.Text = "Supplier Name:"
        Me.lblsuppname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblpopno
        '
        Me.lblpopno.AutoSize = True
        Me.lblpopno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpopno.Location = New System.Drawing.Point(8, 24)
        Me.lblpopno.Name = "lblpopno"
        Me.lblpopno.Size = New System.Drawing.Size(52, 16)
        Me.lblpopno.TabIndex = 1
        Me.lblpopno.Text = "P.O.No:"
        Me.lblpopno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPono
        '
        Me.txtPono.EditValue = ""
        Me.txtPono.Location = New System.Drawing.Point(112, 24)
        Me.txtPono.Name = "txtPono"
        '
        '
        '
        Me.txtPono.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPono.Properties.Appearance.Options.UseFont = True
        Me.txtPono.Size = New System.Drawing.Size(192, 22)
        Me.txtPono.TabIndex = 1
        '
        'cmdAddFG
        '
        Me.cmdAddFG.Location = New System.Drawing.Point(303, 40)
        Me.cmdAddFG.Name = "cmdAddFG"
        Me.cmdAddFG.Size = New System.Drawing.Size(97, 25)
        Me.cmdAddFG.TabIndex = 35
        Me.cmdAddFG.Text = "&Add New Item"
        '
        'FrmPurchaseOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(562, 432)
        Me.Controls.Add(Me.grppurchase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPurchaseOrder"
        Me.Padding = New System.Windows.Forms.Padding(8, 8, 8, 35)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        CType(Me.gvpop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdpopdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grppurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grppurchase.ResumeLayout(False)
        Me.grppurchase.PerformLayout()
        CType(Me.txtterms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtqtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqtnno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbsuppid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdeldate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim dr1 As OleDb.OleDbDataReader
    Public strsid As String
    Dim dt As New DataTable
    Dim strItemID As String
    Dim strItemName As String

    Private Sub frmpop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtunit.Properties.ReadOnly = True

            dt.Columns.Add("ItemID", System.Type.GetType("System.String"))
            dt.Columns.Add("ItemName", System.Type.GetType("System.String"))
            dt.Columns.Add("Delivery_Date", System.Type.GetType("System.String"))
            dt.Columns.Add("UnitID", System.Type.GetType("System.String"))
            dt.Columns.Add("UnitName", System.Type.GetType("System.String"))
            dt.Columns.Add("Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("Rate", System.Type.GetType("System.String"))
            dt.Columns.Add("Amount", System.Type.GetType("System.String"))

            If strcheck = "Add" Then
                txtPono.Text = GetMaxNo("PO_No", "Purchase_Master", "", 6, strCY) & "/" & strCY.Trim
                dtpop.DateTime = Today
                dtdeldate.DateTime = Today
                dtqtn.EditValue = ""
            End If
            If strcheck = "Edit" Then

                txtPono.Properties.ReadOnly = True
                dtpop.Properties.ReadOnly = True
                cmbsuppid.Properties.ReadOnly = True
                cmdAddSupp.Enabled = False

                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Select * from Purchase_Master where PO_No = '" & ModMain.strgridid & "'" ' and CY ='" & strCY & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                bind_data()
                cmd.Dispose()
                dr.Close()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmbsuppid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbsuppid.GotFocus
        Try
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select Suppname from SupplierMaster"
            dr = cmd.ExecuteReader
            cmbsuppid.Properties.Items.Clear()
            Do While dr.Read()
                cmbsuppid.Properties.Items.Add(dr.Item(0))
            Loop
            dr.Close()
            cmd.Dispose()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbsuppid_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbsuppid.Validating

        supplieridlookup()

    End Sub

    Private Sub bind_data()
        Try
            If IsDBNull(dr("PO_No")) = True Then
                txtPono.Text = ""
            Else
                txtPono.Text = dr("PO_No").ToString
            End If

            'Purchase Order Date

            If IsDBNull(dr("PO_date")) = True Then
                dtpop.EditValue = ""
            Else
                dtpop.EditValue = dr("PO_date").ToString
            End If

            'Quotation Number
            If IsDBNull(dr("Qtn_No")) = True Then
                txtqtnno.Text = ""
            Else
                txtqtnno.Text = dr("Qtn_No").ToString
            End If

            'qtn_date

            If IsDBNull(dr("qtn_Date")) = True Then
                dtqtn.EditValue = ""
            Else
                dtqtn.EditValue = dr("qtn_date").ToString
            End If

            'terms

            If IsDBNull(dr("terms")) = True Then
                txtterms.Text = ""
            Else
                txtterms.Text = dr("terms").ToString
            End If

            Dim strsuppid1 As String
            strsuppid1 = dr("suppid").ToString
            dr.Close()
            If strsuppid1 <> "" Then

                Dim cmdtemp As New OleDb.OleDbCommand
                cmdtemp.CommandType = CommandType.Text
                cmdtemp.Connection = conn
                cmdtemp.CommandText = "select suppname from suppliermaster where sid = '" & strsuppid1 & "'"


                Dim strUName As String
                strUName = cmdtemp.ExecuteScalar()
                If strUName Is Nothing Then
                    cmbsuppid.Text = ""
                Else
                    cmbsuppid.Text = strUName
                End If
                cmdtemp.Dispose()
            Else
                cmbsuppid.Text = ""
            End If

            cmd.Dispose()

            dr.Close()


            adp = New OleDb.OleDbDataAdapter("SELECT RMItemMaster.Rid as ItemID,RMItemMaster.RMItemName as ItemName,Purchase_Detail.Delivery_Date,Purchase_Detail.Qty as Qty, Purchase_Detail.UnitID as UnitID,UnitMaster.UnitName as UnitName, Purchase_Detail.Rate as Rate," _
            & " Purchase_Detail.Amount as Amount " _
            & " FROM (Purchase_Detail INNER JOIN UnitMaster ON Purchase_Detail.UnitID = UnitMaster.UnitID) INNER JOIN RMItemMaster ON (Purchase_Detail.UnitID = RMItemMaster.UnitId) AND (UnitMaster.UnitID = RMItemMaster.UnitId) AND (Purchase_Detail.RMItemID = RMItemMaster.RId) " _
            & " WHERE (((Purchase_Detail.PO_No)= '" & ModMain.strgridid & "')) and CY ='" & strCY & "'", conn)

            adp.Fill(dt)

            gdpopdetail.DataSource = dt
            gvpop.Columns("ItemID").VisibleIndex = -1
            gvpop.Columns("UnitID").VisibleIndex = -1


        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Function isValidate() As Boolean
        Try
            If txtPono.Text = "" Or dtpop.Text = "" Or cmbsuppid.Text = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Function
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If strcheck = "Add" Then
                If isValidate() = True Then
                    Dim strSql As String
                    strSql = "Select count(PO_No) from purchase_Master where PO_No='" & txtPono.Text & "'"
                    If IsDuplicate(strSql) = True Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate Entery for " & txtPono.Text, "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If dtqtn.Text <> "" Then
                        cmd = New OleDb.OleDbCommand("insert into purchase_master values ( '" & strsid & "','" & txtPono.Text & "', '" & dtpop.Text & "', '" & txtqtnno.Text & "', '" & dtqtn.Text & "','" & txtterms.Text & "','" & strCY & "')")
                    Else
                        cmd = New OleDb.OleDbCommand("insert into purchase_master values ( '" & strsid & "','" & txtPono.Text & "', '" & dtpop.Text & "', '" & txtqtnno.Text & "', null,'" & txtterms.Text & "','" & strCY & "')")
                    End If
                    cmd.Connection = conn
                    cmd.Transaction = conn.BeginTransaction
                    cmd.ExecuteNonQuery()
                    Dim i As Int16
                    For i = 0 To gvpop.RowCount - 1
                        cmd.CommandText = "insert into Purchase_Detail(PO_No,RmItemId,Delivery_Date,qty,Unitid,Rate,Amount,cy)" & _
                         "values('" & txtPono.Text & "','" & gvpop.GetRowCellValue(i, "ItemID") & "','" & gvpop.GetRowCellValue(i, "Delivery_Date") & "'," & gvpop.GetRowCellValue(i, "Qty") & ",'" & gvpop.GetRowCellValue(i, "UnitID") & "'," & gvpop.GetRowCellValue(i, "Rate") & "," & gvpop.GetRowCellValue(i, "Amount") & ",'" & strCY.Trim & "')"
                        cmd.Connection = conn
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.Transaction.Commit()
                    cmd.Dispose()
                End If
            ElseIf strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                If dtqtn.Text <> "" Then
                    cmd.CommandText = "Update Purchase_master set qtn_no = '" & txtqtnno.Text & "', qtn_date = '" & dtqtn.Text & "', terms = '" & txtterms.Text & "' where po_no = '" & ModMain.strgridid & "' and CY ='" & strCY & "'"
                Else
                    cmd.CommandText = "Update Purchase_master set qtn_no = '" & txtqtnno.Text & "', qtn_date = Null, terms = '" & txtterms.Text & "' where po_no = '" & ModMain.strgridid & "' and CY ='" & strCY & "'"
                End If
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Delete from Purchase_Detail where PO_No = '" & txtPono.Text & "' and CY ='" & strCY & "'"

                cmd.ExecuteNonQuery()

                Dim i As Int16
                For i = 0 To gvpop.RowCount - 1
                    cmd.CommandText = "insert into Purchase_Detail(PO_No,RmItemId,Delivery_date,qty,Unitid,Rate,Amount,CY)" & _
                        "values('" & txtPono.Text & "','" & gvpop.GetRowCellValue(i, "ItemID") & "','" & gvpop.GetRowCellValue(i, "Delivery_Date") & "'," & gvpop.GetRowCellValue(i, "Qty") & ",'" & gvpop.GetRowCellValue(i, "UnitID") & "', " & gvpop.GetRowCellValue(i, "Rate") & "," & gvpop.GetRowCellValue(i, "Amount") & ",'" & strCY.Trim & "')"
                    cmd.ExecuteNonQuery()
                Next
                cmd.Transaction.Commit()
                cmd.Dispose()
            End If
            cmd.Dispose()

            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
            cmd.Transaction.Rollback()
        End Try
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim dr As DataRow
        Try
            gvpop.RefreshData()
            Dim blnDup As Boolean = False
            For i As Int16 = 0 To gvpop.RowCount - 1
                If gvpop.GetRowCellValue(i, gvpop.Columns(1)).ToString = lkupItemName.Text Then
                    blnDup = True
                    Exit For
                End If
            Next
            If blnDup = False Then
                If lkupItemName.Text = "" Or txtqty.Text = "" Or txtrate.Text = "" Or dtdeldate.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Check either ItemName or Qty or Rate or delivery date is left blank", "Blank Field Error", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                dr = dt.NewRow
                dr.Item(0) = strItemID
                dr.Item(1) = lkupItemName.Text
                dr.Item(2) = dtdeldate.Text
                dr.Item(3) = txtunit.Tag
                dr.Item(4) = txtunit.Text

                dr.Item(5) = txtqty.Text
                dr.Item(6) = txtrate.Text
                dr.Item(7) = Val(txtqty.Text) * Val(txtrate.Text)

                dt.Rows.Add(dr)
                gdpopdetail.DataSource = dt
                gvpop.Columns(0).Visible = False
                gvpop.Columns(3).Visible = False

                'lkupItemName.Text = ""
                lkupItemName.EditValue = ""
                txtunit.Text = ""
                txtqty.Text = ""
                txtrate.Text = ""
                dtdeldate.EditValue = ""
                gvpop.RefreshData()
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("This item is all ready added", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvpop.GetSelectedRows.Length > 0 Then
                If MessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvpop.DeleteRow(gvpop.FocusedRowHandle)
                    gvpop.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        Try
            If txtunit.Text.ToUpper = "NOS" Then
                e.Handled = IsOnlyNumber(e.KeyChar)
            Else
                e.Handled = IsDecimalNumber(e.KeyChar)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        Try
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub




    Private Sub cmdAddSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSupp.Click
        Dim frmsupplier As New FrmSupplier
        frmsupplier.strcheck = "Add"
        frmsupplier.ShowDialog()
    End Sub



    Private Sub supplieridlookup()
        Try
            If cmbsuppid.Text <> "" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn

                cmd.CommandText = "select sid from suppliermaster where suppname = '" & cmbsuppid.Text & "'"
                strsid = cmd.ExecuteScalar
                cmd.Dispose()
                lkupItemName.Refresh()

                'FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.Rid, SuppItemMaster.SuppID " _
                '     & " FROM RMItemMaster INNER JOIN SuppItemMaster ON RMItemMaster.Rid = SuppItemMaster.RID " _
                '     & " WHERE (((SuppItemMaster.SuppID)='" & strsid & "'))", "RMItemMaster", "Item Name", "RID", lkupItemName)


                Dim strSql As String
                strSql = "SELECT RMItemMaster.RMItemName, SuppItemMaster.RID, UnitMaster.UnitName, UnitMaster.UnitID " _
                    & " FROM (RMItemMaster INNER JOIN SuppItemMaster ON RMItemMaster.Rid = SuppItemMaster.RID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                    & " WHERE (((SuppItemMaster.SuppID)='" & strsid & "'))"

                FillLookup(strSql, "PO", "Item Name", "ItemID", lkupItemName)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
        End Try

    End Sub

    Private Sub lkupItemName_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupItemName.EditValueChanged
        Try
            If lkupItemName.EditValue <> "" Then
                '    If lkupItemName.EditValue <> "Null" Or Not lkupItemName.EditValue = Nothing Then
                Dim row As DataRowView = lkupItemName.Properties.GetDataSourceRowByKeyValue(lkupItemName.EditValue)
                strItemID = row(1).ToString
                txtunit.Text = row(2).ToString
                txtunit.Tag = row(3).ToString
                'MsgBox(strItemID)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupItemName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lkupItemName.Validating
        Try
            'change
            If lkupItemName.Tag <> "" Then
                Dim cmd1 As OleDb.OleDbCommand
                cmd1 = New OleDb.OleDbCommand
                cmd1.Connection = conn
                cmd1.CommandText = "SELECT RMItemMaster.RMItemName, RMItemMaster.UnitId, UnitMaster.UnitName " _
                     & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                     & "WHERE RMItemMaster.RMItemName = '" & lkupItemName.Text & "'"

                dr1 = cmd1.ExecuteReader
                dr1.Read()
                txtunit.Text = dr1(2).ToString
                txtunit.Tag = dr1(1).ToString
                dr1.Close()
                cmd1.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        Finally
        End Try
    End Sub

    Private Sub lkupItemName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupItemName.GotFocus
        supplieridlookup()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            Dim myobj As New frmPara
            myobj.ShowPOReport(txtPono.Text & "'")
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub btnFindSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindSupp.Click
        Try
            Dim myobj As New frmFindSupplier
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAddFG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddFG.Click
        Try
            Dim myFrm As New frmitem
            myFrm.ShowDialog()
            myFrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
End Class

