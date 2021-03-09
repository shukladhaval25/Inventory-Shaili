Public Class FrmSupplier
    Inherits DevExpress.XtraEditors.XtraForm
    Dim dt As New DataTable
    Dim strSuid As String
    Public strcheck As String
    Dim strGroupID As String


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
    Friend WithEvents grpSupplier As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSuppID As System.Windows.Forms.Label
    Friend WithEvents lblSuppName As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblPin As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbRMItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtSuppAdd As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtSuppCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSuppName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSuppId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSuppPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSuppPin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gdSupplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlItem As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents txtSuppCST As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblcst As System.Windows.Forms.Label
    Friend WithEvents txtSuppGST As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGst As System.Windows.Forms.Label
    Friend WithEvents txtSuppMobile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblExcise As System.Windows.Forms.Label
    Friend WithEvents txtSuppExcise As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAddGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkupSuppGroup As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpSupplier = New DevExpress.XtraEditors.GroupControl
        Me.lkupSuppGroup = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdAddGroup = New DevExpress.XtraEditors.SimpleButton
        Me.lblGroup = New System.Windows.Forms.Label
        Me.lblExcise = New System.Windows.Forms.Label
        Me.txtSuppExcise = New DevExpress.XtraEditors.TextEdit
        Me.txtSuppCST = New DevExpress.XtraEditors.TextEdit
        Me.lblcst = New System.Windows.Forms.Label
        Me.txtSuppGST = New DevExpress.XtraEditors.TextEdit
        Me.lblGst = New System.Windows.Forms.Label
        Me.pnlItem = New DevExpress.XtraEditors.PanelControl
        Me.gdSupplier = New DevExpress.XtraGrid.GridControl
        Me.gvSupplier = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmbRMItem = New System.Windows.Forms.ComboBox
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.lblRaw = New System.Windows.Forms.Label
        Me.txtSuppAdd = New DevExpress.XtraEditors.MemoEdit
        Me.txtSuppMobile = New DevExpress.XtraEditors.TextEdit
        Me.txtSuppPhone = New DevExpress.XtraEditors.TextEdit
        Me.txtSuppPin = New DevExpress.XtraEditors.TextEdit
        Me.txtSuppCity = New DevExpress.XtraEditors.TextEdit
        Me.txtSuppName = New DevExpress.XtraEditors.TextEdit
        Me.lblMobile = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblPin = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblAdd = New System.Windows.Forms.Label
        Me.lblSuppName = New System.Windows.Forms.Label
        Me.lblSuppID = New System.Windows.Forms.Label
        Me.txtSuppId = New DevExpress.XtraEditors.TextEdit
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSupplier.SuspendLayout()
        CType(Me.lkupSuppGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppExcise.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppGST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItem.SuspendLayout()
        CType(Me.gdSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppMobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppPin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSupplier
        '
        Me.grpSupplier.Controls.Add(Me.lkupSuppGroup)
        Me.grpSupplier.Controls.Add(Me.cmdAddGroup)
        Me.grpSupplier.Controls.Add(Me.lblGroup)
        Me.grpSupplier.Controls.Add(Me.lblExcise)
        Me.grpSupplier.Controls.Add(Me.txtSuppExcise)
        Me.grpSupplier.Controls.Add(Me.txtSuppCST)
        Me.grpSupplier.Controls.Add(Me.lblcst)
        Me.grpSupplier.Controls.Add(Me.txtSuppGST)
        Me.grpSupplier.Controls.Add(Me.lblGst)
        Me.grpSupplier.Controls.Add(Me.pnlItem)
        Me.grpSupplier.Controls.Add(Me.txtSuppAdd)
        Me.grpSupplier.Controls.Add(Me.txtSuppMobile)
        Me.grpSupplier.Controls.Add(Me.txtSuppPhone)
        Me.grpSupplier.Controls.Add(Me.txtSuppPin)
        Me.grpSupplier.Controls.Add(Me.txtSuppCity)
        Me.grpSupplier.Controls.Add(Me.txtSuppName)
        Me.grpSupplier.Controls.Add(Me.lblMobile)
        Me.grpSupplier.Controls.Add(Me.lblPhone)
        Me.grpSupplier.Controls.Add(Me.lblPin)
        Me.grpSupplier.Controls.Add(Me.lblCity)
        Me.grpSupplier.Controls.Add(Me.lblAdd)
        Me.grpSupplier.Controls.Add(Me.lblSuppName)
        Me.grpSupplier.Controls.Add(Me.lblSuppID)
        Me.grpSupplier.Controls.Add(Me.txtSuppId)
        Me.grpSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSupplier.Location = New System.Drawing.Point(5, 5)
        Me.grpSupplier.Name = "grpSupplier"
        Me.grpSupplier.Size = New System.Drawing.Size(624, 315)
        Me.grpSupplier.TabIndex = 0
        Me.grpSupplier.Text = "Suppiler Master"
        '
        'lkupSuppGroup
        '
        Me.lkupSuppGroup.EditValue = ""
        Me.lkupSuppGroup.Location = New System.Drawing.Point(68, 280)
        Me.lkupSuppGroup.Name = "lkupSuppGroup"
        '
        'lkupSuppGroup.Properties
        '
        Me.lkupSuppGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupSuppGroup.Properties.NullText = ""
        Me.lkupSuppGroup.Size = New System.Drawing.Size(132, 20)
        Me.lkupSuppGroup.TabIndex = 8
        '
        'cmdAddGroup
        '
        Me.cmdAddGroup.Location = New System.Drawing.Point(208, 280)
        Me.cmdAddGroup.Name = "cmdAddGroup"
        Me.cmdAddGroup.Size = New System.Drawing.Size(40, 21)
        Me.cmdAddGroup.TabIndex = 9
        Me.cmdAddGroup.Text = "&Add..."
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.Location = New System.Drawing.Point(8, 280)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(45, 19)
        Me.lblGroup.TabIndex = 35
        Me.lblGroup.Text = "Group:"
        '
        'lblExcise
        '
        Me.lblExcise.AutoSize = True
        Me.lblExcise.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcise.Location = New System.Drawing.Point(256, 96)
        Me.lblExcise.Name = "lblExcise"
        Me.lblExcise.Size = New System.Drawing.Size(46, 19)
        Me.lblExcise.TabIndex = 38
        Me.lblExcise.Text = "Excise:"
        '
        'txtSuppExcise
        '
        Me.txtSuppExcise.EditValue = ""
        Me.txtSuppExcise.Location = New System.Drawing.Point(312, 96)
        Me.txtSuppExcise.Name = "txtSuppExcise"
        '
        'txtSuppExcise.Properties
        '
        Me.txtSuppExcise.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppExcise.Properties.Appearance.Options.UseFont = True
        Me.txtSuppExcise.Properties.MaxLength = 25
        Me.txtSuppExcise.Size = New System.Drawing.Size(152, 22)
        Me.txtSuppExcise.TabIndex = 12
        '
        'txtSuppCST
        '
        Me.txtSuppCST.EditValue = ""
        Me.txtSuppCST.Location = New System.Drawing.Point(312, 64)
        Me.txtSuppCST.Name = "txtSuppCST"
        '
        'txtSuppCST.Properties
        '
        Me.txtSuppCST.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppCST.Properties.Appearance.Options.UseFont = True
        Me.txtSuppCST.Properties.MaxLength = 25
        Me.txtSuppCST.Size = New System.Drawing.Size(152, 22)
        Me.txtSuppCST.TabIndex = 11
        '
        'lblcst
        '
        Me.lblcst.AutoSize = True
        Me.lblcst.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcst.Location = New System.Drawing.Point(256, 64)
        Me.lblcst.Name = "lblcst"
        Me.lblcst.Size = New System.Drawing.Size(33, 19)
        Me.lblcst.TabIndex = 32
        Me.lblcst.Text = "CST:"
        '
        'txtSuppGST
        '
        Me.txtSuppGST.EditValue = ""
        Me.txtSuppGST.Location = New System.Drawing.Point(312, 32)
        Me.txtSuppGST.Name = "txtSuppGST"
        '
        'txtSuppGST.Properties
        '
        Me.txtSuppGST.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppGST.Properties.Appearance.Options.UseFont = True
        Me.txtSuppGST.Properties.MaxLength = 25
        Me.txtSuppGST.Size = New System.Drawing.Size(152, 22)
        Me.txtSuppGST.TabIndex = 10
        '
        'lblGst
        '
        Me.lblGst.AutoSize = True
        Me.lblGst.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGst.Location = New System.Drawing.Point(256, 32)
        Me.lblGst.Name = "lblGst"
        Me.lblGst.Size = New System.Drawing.Size(34, 19)
        Me.lblGst.TabIndex = 30
        Me.lblGst.Text = "GST:"
        '
        'pnlItem
        '
        Me.pnlItem.Controls.Add(Me.gdSupplier)
        Me.pnlItem.Controls.Add(Me.cmbRMItem)
        Me.pnlItem.Controls.Add(Me.cmdAdd)
        Me.pnlItem.Controls.Add(Me.cmdDelete)
        Me.pnlItem.Controls.Add(Me.lblRaw)
        Me.pnlItem.Location = New System.Drawing.Point(256, 127)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(360, 184)
        Me.pnlItem.TabIndex = 12
        Me.pnlItem.Text = "PanelControl1"
        '
        'gdSupplier
        '
        '
        'gdSupplier.EmbeddedNavigator
        '
        Me.gdSupplier.EmbeddedNavigator.Name = ""
        Me.gdSupplier.Location = New System.Drawing.Point(8, 40)
        Me.gdSupplier.MainView = Me.gvSupplier
        Me.gdSupplier.Name = "gdSupplier"
        Me.gdSupplier.Size = New System.Drawing.Size(344, 136)
        Me.gdSupplier.TabIndex = 16
        Me.gdSupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSupplier})
        '
        'gvSupplier
        '
        Me.gvSupplier.GridControl = Me.gdSupplier
        Me.gvSupplier.Name = "gvSupplier"
        Me.gvSupplier.OptionsBehavior.Editable = False
        Me.gvSupplier.OptionsCustomization.AllowColumnMoving = False
        Me.gvSupplier.OptionsCustomization.AllowGroup = False
        Me.gvSupplier.OptionsMenu.EnableFooterMenu = False
        Me.gvSupplier.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvSupplier.OptionsNavigation.UseTabKey = False
        Me.gvSupplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSupplier.OptionsView.ShowGroupPanel = False
        '
        'cmbRMItem
        '
        Me.cmbRMItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRMItem.Location = New System.Drawing.Point(46, 10)
        Me.cmbRMItem.Name = "cmbRMItem"
        Me.cmbRMItem.Size = New System.Drawing.Size(186, 21)
        Me.cmbRMItem.TabIndex = 13
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(238, 8)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 25)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(296, 8)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(56, 25)
        Me.cmdDelete.TabIndex = 15
        Me.cmdDelete.Text = "&Delete"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(7, 10)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(37, 19)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Item:"
        '
        'txtSuppAdd
        '
        Me.txtSuppAdd.EditValue = ""
        Me.txtSuppAdd.Location = New System.Drawing.Point(68, 84)
        Me.txtSuppAdd.Name = "txtSuppAdd"
        '
        'txtSuppAdd.Properties
        '
        Me.txtSuppAdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppAdd.Properties.Appearance.Options.UseFont = True
        Me.txtSuppAdd.Size = New System.Drawing.Size(180, 64)
        Me.txtSuppAdd.TabIndex = 3
        '
        'txtSuppMobile
        '
        Me.txtSuppMobile.EditValue = ""
        Me.txtSuppMobile.Location = New System.Drawing.Point(68, 248)
        Me.txtSuppMobile.Name = "txtSuppMobile"
        '
        'txtSuppMobile.Properties
        '
        Me.txtSuppMobile.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppMobile.Properties.Appearance.Options.UseFont = True
        Me.txtSuppMobile.Properties.MaxLength = 15
        Me.txtSuppMobile.Size = New System.Drawing.Size(180, 22)
        Me.txtSuppMobile.TabIndex = 7
        '
        'txtSuppPhone
        '
        Me.txtSuppPhone.EditValue = ""
        Me.txtSuppPhone.Location = New System.Drawing.Point(68, 216)
        Me.txtSuppPhone.Name = "txtSuppPhone"
        '
        'txtSuppPhone.Properties
        '
        Me.txtSuppPhone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppPhone.Properties.Appearance.Options.UseFont = True
        Me.txtSuppPhone.Properties.MaxLength = 15
        Me.txtSuppPhone.Size = New System.Drawing.Size(180, 22)
        Me.txtSuppPhone.TabIndex = 6
        '
        'txtSuppPin
        '
        Me.txtSuppPin.EditValue = ""
        Me.txtSuppPin.Location = New System.Drawing.Point(68, 184)
        Me.txtSuppPin.Name = "txtSuppPin"
        '
        'txtSuppPin.Properties
        '
        Me.txtSuppPin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppPin.Properties.Appearance.Options.UseFont = True
        Me.txtSuppPin.Properties.MaxLength = 10
        Me.txtSuppPin.Size = New System.Drawing.Size(180, 22)
        Me.txtSuppPin.TabIndex = 5
        '
        'txtSuppCity
        '
        Me.txtSuppCity.EditValue = ""
        Me.txtSuppCity.Location = New System.Drawing.Point(68, 154)
        Me.txtSuppCity.Name = "txtSuppCity"
        '
        'txtSuppCity.Properties
        '
        Me.txtSuppCity.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppCity.Properties.Appearance.Options.UseFont = True
        Me.txtSuppCity.Properties.MaxLength = 50
        Me.txtSuppCity.Size = New System.Drawing.Size(180, 22)
        Me.txtSuppCity.TabIndex = 4
        '
        'txtSuppName
        '
        Me.txtSuppName.EditValue = ""
        Me.txtSuppName.Location = New System.Drawing.Point(68, 56)
        Me.txtSuppName.Name = "txtSuppName"
        '
        'txtSuppName.Properties
        '
        Me.txtSuppName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppName.Properties.Appearance.Options.UseFont = True
        Me.txtSuppName.Properties.MaxLength = 100
        Me.txtSuppName.Size = New System.Drawing.Size(180, 22)
        Me.txtSuppName.TabIndex = 2
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(10, 248)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(48, 19)
        Me.lblMobile.TabIndex = 8
        Me.lblMobile.Text = "Mobile:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(10, 216)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(46, 19)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone:"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPin.Location = New System.Drawing.Point(10, 184)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(27, 19)
        Me.lblPin.TabIndex = 6
        Me.lblPin.Text = "Pin:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(10, 152)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(32, 19)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City:"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(10, 104)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(32, 18)
        Me.lblAdd.TabIndex = 3
        Me.lblAdd.Text = "Add:"
        '
        'lblSuppName
        '
        Me.lblSuppName.AutoSize = True
        Me.lblSuppName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppName.Location = New System.Drawing.Point(10, 56)
        Me.lblSuppName.Name = "lblSuppName"
        Me.lblSuppName.Size = New System.Drawing.Size(44, 19)
        Me.lblSuppName.TabIndex = 2
        Me.lblSuppName.Text = "Name:"
        '
        'lblSuppID
        '
        Me.lblSuppID.AutoSize = True
        Me.lblSuppID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppID.Location = New System.Drawing.Point(10, 30)
        Me.lblSuppID.Name = "lblSuppID"
        Me.lblSuppID.Size = New System.Drawing.Size(24, 19)
        Me.lblSuppID.TabIndex = 1
        Me.lblSuppID.Text = "ID:"
        '
        'txtSuppId
        '
        Me.txtSuppId.EditValue = ""
        Me.txtSuppId.Location = New System.Drawing.Point(68, 28)
        Me.txtSuppId.Name = "txtSuppId"
        '
        'txtSuppId.Properties
        '
        Me.txtSuppId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppId.Properties.Appearance.Options.UseFont = True
        Me.txtSuppId.Properties.MaxLength = 15
        Me.txtSuppId.Size = New System.Drawing.Size(180, 22)
        Me.txtSuppId.TabIndex = 1
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(552, 328)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 25)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "&Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(472, 328)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "&Save"
        '
        'FrmSupplier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(634, 360)
        Me.Controls.Add(Me.grpSupplier)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 5
        Me.DockPadding.Right = 5
        Me.DockPadding.Top = 5
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Master"
        CType(Me.grpSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSupplier.ResumeLayout(False)
        CType(Me.lkupSuppGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppExcise.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppGST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItem.ResumeLayout(False)
        CType(Me.gdSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppMobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppPin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
           
            Fillcmb("Select RID,RMItemName From RMItemMaster Order by RMItemName", "RMItemMaster", "RID", "RMItemName", cmbRMItem, "Select FID as RID, FGName as RMItemName from FGMaster")
            'Fillcmb("Select Groupid,GroupName from GroupMaster where GRoupType='S'", "GroupMaster", "GroupID", "GroupName", cmbSuppGroup)
            FillLookup("Select GroupName,Groupid from GroupMaster where GRoupType='S'", "GroupMaster", "GroupName", "GroupID", lkupSuppGroup)

            If strcheck = "Add" Then
                dt.Columns.Add("ItemID", System.Type.GetType("System.String"))
                dt.Columns.Add("ItemName", System.Type.GetType("System.String"))
                txtSuppId.Tag = GetMaxNo("sid", "suppliermaster", "SP", 10)
            ElseIf strcheck = "Edit" Then

                txtSuppId.Tag = strgridid
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from suppliermaster where sid='" & ModMain.strgridid & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                LoadSupplier()
                dr.Close()
                cmd.Dispose()
                strSuid = txtSuppId.Text.Trim
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If

        End Try
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Dim dr As DataRow
        Dim i As Int16
        Try

            For i = 0 To gvSupplier.RowCount - 1
                If cmbRMItem.SelectedValue = gvSupplier.GetRowCellValue(i, "ItemID") Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Item Already Exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
            dr = dt.NewRow
            dr.Item(0) = cmbRMItem.SelectedValue
            dr.Item(1) = cmbRMItem.Text
            dt.Rows.Add(dr)
            gdSupplier.DataSource = dt
            gvSupplier.Columns(0).Visible = False
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        ' sopan
        Dim i As Int16
        If ValidateSupplier() = False Then
            Exit Sub
        End If

        Try
            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "insert into suppliermaster(Sid,Suppid,Suppname,SuppAdd,SuppGSTno,SuppCSTno,suppEXno,Suppcity,SuppPin,Suppphone,Suppmobile,SuppGRno)" & _
                "values('" & txtSuppId.Tag & "','" & Replace(txtSuppId.Text.Trim, "'", "''") & "','" & Replace(txtSuppName.Text.Trim, "'", "''") & _
                "','" & Replace(txtSuppAdd.Text.Trim, "'", "''") & "','" & Replace(txtSuppGST.Text.Trim, "'", "''") & _
                "','" & Replace(txtSuppCST.Text.Trim, "'", "''") & "','" & Replace(txtSuppExcise.Text.Trim, "'", "''") & _
                "','" & Replace(txtSuppCity.Text.Trim, "'", "''") & "'," & Replace(txtSuppPin.Text.Trim, "'", "''") & _
                ",'" & Replace(txtSuppPhone.Text.Trim, "'", "''") & "','" & Replace(txtSuppMobile.Text.Trim, "'", "''") & _
                "','" & Replace(strGroupID.Trim, "'", "''") & "')"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
                For i = 0 To gvSupplier.RowCount - 1
                    cmd.CommandText = "insert into suppItemmaster(suppid,Rid)" & _
                    "values('" & txtSuppId.Tag & "','" & gvSupplier.GetRowCellValue(i, "ItemID") & "')"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()
                Next
                cmd.Transaction.Commit()
            Else
                'conn.BeginTransaction.Begin(IsolationLevel.ReadUncommitted)
                cmd = New OleDb.OleDbCommand
                cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "update suppliermaster set suppid='" & Replace(txtSuppId.Text.Trim, "'", "''") & _
                "',suppname='" & Replace(txtSuppName.Text.Trim, "'", "''") & "', suppAdd='" & Replace(txtSuppAdd.Text.Trim, "'", "''") & _
                "',suppGSTno='" & Replace(txtSuppGST.Text.Trim, "'", "''") & "',SuppCSTno='" & Replace(txtSuppCST.Text.Trim, "'", "''") & _
                "',suppEXno='" & Replace(txtSuppExcise.Text.Trim, "'", "''") & "',suppcity='" & Replace(txtSuppCity.Text.Trim, "'", "''") & _
                "',suppPin=" & Replace(txtSuppPin.Text.Trim, "'", "''") & ",suppphone='" & Replace(txtSuppPhone.Text.Trim, "'", "''") & _
                "',suppmobile='" & Replace(txtSuppMobile.Text.Trim, "'", "''") & "',suppGRno='" & Replace(strGroupID.Trim, "'", "''") & _
                "' where sid='" & txtSuppId.Tag & "'"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()


                cmd.CommandText = "delete from suppItemMaster where suppid='" & txtSuppId.Tag & "'"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                For i = 0 To gvSupplier.RowCount - 1
                    cmd.CommandText = "insert into suppItemmaster(suppid,Rid)" & _
                    "values('" & txtSuppId.Tag & "','" & gvSupplier.GetRowCellValue(i, "ItemID") & "')"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()
                Next
                'conn.BeginTransaction.Commit()
                cmd.Transaction.Commit()
            End If

            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub LoadSupplier()

        Try
            ' System supplier id
            If IsDBNull(dr("Sid").ToString) = True Then
                txtSuppId.Tag = ""
            Else
                txtSuppId.Tag = dr("Sid")
            End If

            'Supplier Id 
            If IsDBNull(dr("Suppid").ToString) = True Then
                txtSuppId.Text = ""
            Else
                txtSuppId.Text = dr("Suppid")
            End If

            'supplier Name
            If IsDBNull(dr(2).ToString) = True Then
                txtSuppName.Text = ""
            Else
                txtSuppName.Text = dr("Suppname")
            End If

            'supp Address
            If IsDBNull(dr("SuppAdd").ToString) = True Then
                txtSuppAdd.Text = ""
            Else
                txtSuppAdd.Text = dr("SuppAdd").ToString
            End If

            'supp GST NO
            If IsDBNull(dr("SuppGSTno").ToString) = True Then
                txtSuppGST.Text = ""
            Else
                txtSuppGST.Text = dr("SuppGSTno").ToString
            End If

            'supp CST No
            If IsDBNull(dr("SuppCSTno").ToString) = True Then
                txtSuppCST.Text = ""
            Else
                txtSuppCST.Text = dr("SuppCSTno").ToString
            End If

            'Supp Exceisec
            If IsDBNull(dr("SuppEXno").ToString) = True Then
                txtSuppExcise.Text = ""
            Else
                txtSuppExcise.Text = dr("SuppEXno").ToString
            End If

            ' supp Group no

            If IsDBNull(dr("SuppGRno")) = True Then
                lkupSuppGroup.EditValue = ""
            Else
                lkupSuppGroup.EditValue = dr("SuppGRno").ToString
                'cmbSuppGroup.Text = 
            End If


            'supp City
            If IsDBNull(dr("SuppCity").ToString) = True Then
                txtSuppCity.Text = ""
            Else
                txtSuppCity.Text = dr("SuppCity").ToString
            End If

            ' supp pin
            If IsDBNull(dr("SuppPin").ToString) = True Then
                txtSuppPin.Text = ""
            Else
                txtSuppPin.Text = dr("SuppPin").ToString
            End If

            ' supp phone
            If IsDBNull(dr("SuppPhone").ToString) = True Then
                txtSuppPhone.Text = ""
            Else
                txtSuppPhone.Text = dr("SuppPhone").ToString
            End If

            ' supp Mobile
            If IsDBNull(dr("SuppMobile").ToString) = True Then
                txtSuppMobile.Text = ""
            Else
                txtSuppMobile.Text = dr("SuppMobile").ToString
            End If
            dr.Close()
            Dim ds As New DataSet

            'adp = New OleDb.OleDbDataAdapter("select Rid as ItemID,RmItemName as ItemName from suppItemmaster where suppid='" & txtSuppId.Tag & "'", conn)
            adp = New OleDb.OleDbDataAdapter("SELECT SuppItemMaster.RID AS ItemID, RMItemMaster.RMItemName " _
                & " FROM SuppItemMaster INNER JOIN RMItemMaster ON SuppItemMaster.RID = RMItemMaster.Rid " _
                & " WHERE (((SuppItemMaster.SuppID)='" & txtSuppId.Tag & "'))", conn)
            adp.Fill(dt)

            adp.SelectCommand.CommandText = "SELECT SuppItemMaster.RID AS ItemID, FGMaster.FGName as RMItemName " _
                & " FROM SuppItemMaster INNER JOIN FGMaster ON SuppItemMaster.RID = FGMaster.fid " _
                & " WHERE (((SuppItemMaster.SuppID)='" & txtSuppId.Tag & "'))"
            adp.Fill(dt)

            gdSupplier.DataSource = dt

            gvSupplier.Columns("ItemID").VisibleIndex = -1


        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Function ValidateSupplier() As Boolean
        Dim id As String
        Try
            If txtSuppPin.Text.Trim = "" Then
                txtSuppPin.Text = "0"
            End If

            'Supplier Id 
            If txtSuppId.Text.Trim = "" = True Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Supplier Id", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSuppId.Select()
                ValidateSupplier = False
                Exit Function
            End If
            cmd = New OleDb.OleDbCommand
            If strcheck = "Add" Then
                cmd.CommandText = "select sid from suppliermaster where suppid='" & txtSuppId.Text.Trim & "'"
            ElseIf strcheck = "Edit" Then
                cmd.CommandText = "select sid from suppliermaster where suppid='" & txtSuppId.Text.Trim & "' and suppid <> '" & strSuid & "'"
            End If

            cmd.Connection = conn
            id = cmd.ExecuteScalar
            If id <> "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Supplier Id Already Exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSuppName.Select()
                ValidateSupplier = False
                Exit Function
            End If

            'supplier Name
            If txtSuppName.Text.Trim = "" = True Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Supplier Name", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ValidateSupplier = False
                txtSuppName.Select()
                Exit Function
            End If

            'Group -Dhaval
            If lkupSuppGroup.EditValue = Nothing Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Please Enter Group", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ValidateSupplier = False
                lkupSuppGroup.Select()
                Exit Function
            End If

            ValidateSupplier = True
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If

        End Try
    End Function
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvSupplier.GetSelectedRows.Length > 0 Then
                If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvSupplier.DeleteRow(gvSupplier.FocusedRowHandle)
                    gvSupplier.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub txtSuppPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuppPhone.KeyPress
        e.Handled = IsPhoneNumber(e.KeyChar)
    End Sub

    Private Sub txtSuppMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuppMobile.KeyPress
        e.Handled = IsPhoneNumber(e.KeyChar)
    End Sub

    Private Sub txtSuppPin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuppPin.KeyPress
        e.Handled = IsNumber(e.KeyChar)
    End Sub


    Private Sub cmdAddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddGroup.Click
        Dim frmgroupobj As New frmGroup
        frmgroupobj.strcheck = "Add"
        frmgroupobj.ShowDialog()
    End Sub


    Private Sub lkupSuppGroup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupSuppGroup.EditValueChanged
        Try
            If lkupSuppGroup.EditValue <> "" Then
                '    If lkupItemName.EditValue <> "Null" Or Not lkupItemName.EditValue = Nothing Then
                Dim row As DataRowView = lkupSuppGroup.Properties.GetDataSourceRowByKeyValue(lkupSuppGroup.EditValue)
                strGroupID = row(1).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    
    Private Sub lkupSuppGroup_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupSuppGroup.GotFocus
        Try
            FillLookup("Select GroupName,Groupid from GroupMaster where GRoupType='S'", "GroupMaster", "GroupName", "GroupID", lkupSuppGroup)
        Catch EX As Exception
            If show_error Then
                MsgBox(EX.ToString)
            End If
        End Try
    End Sub
End Class

