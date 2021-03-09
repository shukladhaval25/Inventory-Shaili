Public Class frmpop
    Inherits System.Windows.Forms.Form
    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Public strsuppid As String


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
    Friend WithEvents lblunit As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbounit As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents cmbRMItem As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents cmbsuppid As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblquono As System.Windows.Forms.Label
    Friend WithEvents lblsuppname As System.Windows.Forms.Label
    Friend WithEvents lblpopno As System.Windows.Forms.Label
    Friend WithEvents txtorderno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtqtnno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblquodate As System.Windows.Forms.Label
    Friend WithEvents lblpopdate As System.Windows.Forms.Label
    Friend WithEvents lbldeldate As System.Windows.Forms.Label
    Friend WithEvents dtpop As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtqtn As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtprice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents gvpop As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdpopdetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtdeldate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblunitid As System.Windows.Forms.Label
    Friend WithEvents txtsuppid As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.gvpop = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gdpopdetail = New DevExpress.XtraGrid.GridControl
        Me.lblunit = New DevExpress.XtraEditors.GroupControl
        Me.dtqtn = New DevExpress.XtraEditors.DateEdit
        Me.dtpop = New DevExpress.XtraEditors.DateEdit
        Me.lblpopdate = New System.Windows.Forms.Label
        Me.txtqtnno = New DevExpress.XtraEditors.TextEdit
        Me.lblquodate = New System.Windows.Forms.Label
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdclose = New DevExpress.XtraEditors.SimpleButton
        Me.cmbsuppid = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtprice = New DevExpress.XtraEditors.TextEdit
        Me.lblprice = New System.Windows.Forms.Label
        Me.dtdeldate = New DevExpress.XtraEditors.DateEdit
        Me.cbounit = New System.Windows.Forms.ComboBox
        Me.lblunitid = New System.Windows.Forms.Label
        Me.txtqty = New DevExpress.XtraEditors.TextEdit
        Me.lblqty = New System.Windows.Forms.Label
        Me.cmbRMItem = New System.Windows.Forms.ComboBox
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.lblRaw = New System.Windows.Forms.Label
        Me.lbldeldate = New System.Windows.Forms.Label
        Me.lblquono = New System.Windows.Forms.Label
        Me.lblsuppname = New System.Windows.Forms.Label
        Me.lblpopno = New System.Windows.Forms.Label
        Me.txtorderno = New DevExpress.XtraEditors.TextEdit
        Me.txtsuppid = New DevExpress.XtraEditors.TextEdit
        CType(Me.gvpop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdpopdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblunit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblunit.SuspendLayout()
        CType(Me.dtqtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqtnno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbsuppid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtprice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdeldate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtorderno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsuppid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'gdpopdetail.EmbeddedNavigator
        '
        Me.gdpopdetail.EmbeddedNavigator.Name = ""
        GridLevelNode1.RelationName = "Level1"
        Me.gdpopdetail.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gdpopdetail.Location = New System.Drawing.Point(16, 104)
        Me.gdpopdetail.MainView = Me.gvpop
        Me.gdpopdetail.Name = "gdpopdetail"
        Me.gdpopdetail.Size = New System.Drawing.Size(504, 148)
        Me.gdpopdetail.TabIndex = 12
        Me.gdpopdetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvpop})
        '
        'lblunit
        '
        Me.lblunit.Controls.Add(Me.dtqtn)
        Me.lblunit.Controls.Add(Me.dtpop)
        Me.lblunit.Controls.Add(Me.lblpopdate)
        Me.lblunit.Controls.Add(Me.txtqtnno)
        Me.lblunit.Controls.Add(Me.lblquodate)
        Me.lblunit.Controls.Add(Me.cmdsave)
        Me.lblunit.Controls.Add(Me.cmdclose)
        Me.lblunit.Controls.Add(Me.cmbsuppid)
        Me.lblunit.Controls.Add(Me.PanelControl1)
        Me.lblunit.Controls.Add(Me.lblquono)
        Me.lblunit.Controls.Add(Me.lblsuppname)
        Me.lblunit.Controls.Add(Me.lblpopno)
        Me.lblunit.Controls.Add(Me.txtorderno)
        Me.lblunit.Controls.Add(Me.txtsuppid)
        Me.lblunit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblunit.Location = New System.Drawing.Point(0, 0)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(552, 526)
        Me.lblunit.TabIndex = 15
        Me.lblunit.Text = "Purchase Order Master and Detail"
        '
        'dtqtn
        '
        Me.dtqtn.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.dtqtn.Location = New System.Drawing.Point(152, 160)
        Me.dtqtn.Name = "dtqtn"
        '
        'dtqtn.Properties
        '
        Me.dtqtn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtqtn.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtqtn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtqtn.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtqtn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtqtn.Properties.Mask.EditMask = "dd/mm/yyyy"
        Me.dtqtn.Size = New System.Drawing.Size(160, 20)
        Me.dtqtn.TabIndex = 5
        '
        'dtpop
        '
        Me.dtpop.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.dtpop.Location = New System.Drawing.Point(152, 96)
        Me.dtpop.Name = "dtpop"
        '
        'dtpop.Properties
        '
        Me.dtpop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpop.Properties.Mask.EditMask = "dd/mm/yyyy"
        Me.dtpop.Size = New System.Drawing.Size(160, 20)
        Me.dtpop.TabIndex = 3
        '
        'lblpopdate
        '
        Me.lblpopdate.AutoSize = True
        Me.lblpopdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpopdate.Location = New System.Drawing.Point(16, 96)
        Me.lblpopdate.Name = "lblpopdate"
        Me.lblpopdate.Size = New System.Drawing.Size(37, 19)
        Me.lblpopdate.TabIndex = 30
        Me.lblpopdate.Text = "Date:"
        '
        'txtqtnno
        '
        Me.txtqtnno.EditValue = ""
        Me.txtqtnno.Location = New System.Drawing.Point(152, 128)
        Me.txtqtnno.Name = "txtqtnno"
        '
        'txtqtnno.Properties
        '
        Me.txtqtnno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtnno.Properties.Appearance.Options.UseFont = True
        Me.txtqtnno.Size = New System.Drawing.Size(160, 22)
        Me.txtqtnno.TabIndex = 4
        '
        'lblquodate
        '
        Me.lblquodate.AutoSize = True
        Me.lblquodate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquodate.Location = New System.Drawing.Point(16, 160)
        Me.lblquodate.Name = "lblquodate"
        Me.lblquodate.Size = New System.Drawing.Size(37, 19)
        Me.lblquodate.TabIndex = 28
        Me.lblquodate.Text = "Date:"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(384, 480)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 25)
        Me.cmdsave.TabIndex = 12
        Me.cmdsave.Text = "&Save"
        '
        'cmdclose
        '
        Me.cmdclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdclose.Location = New System.Drawing.Point(464, 480)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 25)
        Me.cmdclose.TabIndex = 14
        Me.cmdclose.Text = "&Close"
        '
        'cmbsuppid
        '
        Me.cmbsuppid.EditValue = ""
        Me.cmbsuppid.Location = New System.Drawing.Point(152, 32)
        Me.cmbsuppid.Name = "cmbsuppid"
        '
        'cmbsuppid.Properties
        '
        Me.cmbsuppid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbsuppid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbsuppid.Size = New System.Drawing.Size(160, 20)
        Me.cmbsuppid.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtprice)
        Me.PanelControl1.Controls.Add(Me.lblprice)
        Me.PanelControl1.Controls.Add(Me.dtdeldate)
        Me.PanelControl1.Controls.Add(Me.cbounit)
        Me.PanelControl1.Controls.Add(Me.lblunitid)
        Me.PanelControl1.Controls.Add(Me.txtqty)
        Me.PanelControl1.Controls.Add(Me.lblqty)
        Me.PanelControl1.Controls.Add(Me.gdpopdetail)
        Me.PanelControl1.Controls.Add(Me.cmbRMItem)
        Me.PanelControl1.Controls.Add(Me.cmdAdd)
        Me.PanelControl1.Controls.Add(Me.cmdDelete)
        Me.PanelControl1.Controls.Add(Me.lblRaw)
        Me.PanelControl1.Controls.Add(Me.lbldeldate)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 200)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(528, 264)
        Me.PanelControl1.TabIndex = 24
        Me.PanelControl1.Text = "PanelControl1"
        '
        'txtprice
        '
        Me.txtprice.EditValue = ""
        Me.txtprice.Location = New System.Drawing.Point(240, 56)
        Me.txtprice.Name = "txtprice"
        '
        'txtprice.Properties
        '
        Me.txtprice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Properties.Appearance.Options.UseFont = True
        Me.txtprice.Size = New System.Drawing.Size(72, 22)
        Me.txtprice.TabIndex = 10
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(136, 56)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(61, 19)
        Me.lblprice.TabIndex = 34
        Me.lblprice.Text = "Unit Price"
        '
        'dtdeldate
        '
        Me.dtdeldate.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.dtdeldate.Location = New System.Drawing.Point(240, 16)
        Me.dtdeldate.Name = "dtdeldate"
        '
        'dtdeldate.Properties
        '
        Me.dtdeldate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtdeldate.Size = New System.Drawing.Size(80, 20)
        Me.dtdeldate.TabIndex = 7
        '
        'cbounit
        '
        Me.cbounit.Location = New System.Drawing.Point(48, 56)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.Size = New System.Drawing.Size(80, 21)
        Me.cbounit.TabIndex = 9
        '
        'lblunitid
        '
        Me.lblunitid.AutoSize = True
        Me.lblunitid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitid.Location = New System.Drawing.Point(8, 56)
        Me.lblunitid.Name = "lblunitid"
        Me.lblunitid.Size = New System.Drawing.Size(33, 19)
        Me.lblunitid.TabIndex = 26
        Me.lblunitid.Text = "Unit:"
        '
        'txtqty
        '
        Me.txtqty.EditValue = ""
        Me.txtqty.Location = New System.Drawing.Point(368, 16)
        Me.txtqty.Name = "txtqty"
        '
        'txtqty.Properties
        '
        Me.txtqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Properties.Appearance.Options.UseFont = True
        Me.txtqty.Size = New System.Drawing.Size(40, 22)
        Me.txtqty.TabIndex = 8
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(328, 16)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(30, 19)
        Me.lblqty.TabIndex = 24
        Me.lblqty.Text = "Qty:"
        '
        'cmbRMItem
        '
        Me.cmbRMItem.Location = New System.Drawing.Point(48, 16)
        Me.cmbRMItem.Name = "cmbRMItem"
        Me.cmbRMItem.Size = New System.Drawing.Size(80, 21)
        Me.cmbRMItem.TabIndex = 6
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(424, 16)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(40, 25)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(472, 16)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(48, 25)
        Me.cmdDelete.TabIndex = 13
        Me.cmdDelete.Text = "&Delete"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(8, 16)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(37, 19)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Item:"
        '
        'lbldeldate
        '
        Me.lbldeldate.AutoSize = True
        Me.lbldeldate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeldate.Location = New System.Drawing.Point(144, 24)
        Me.lbldeldate.Name = "lbldeldate"
        Me.lbldeldate.Size = New System.Drawing.Size(89, 19)
        Me.lbldeldate.TabIndex = 32
        Me.lbldeldate.Text = "Delivery Date:"
        '
        'lblquono
        '
        Me.lblquono.AutoSize = True
        Me.lblquono.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquono.Location = New System.Drawing.Point(16, 128)
        Me.lblquono.Name = "lblquono"
        Me.lblquono.Size = New System.Drawing.Size(92, 19)
        Me.lblquono.TabIndex = 4
        Me.lblquono.Text = "Quotation No.:"
        '
        'lblsuppname
        '
        Me.lblsuppname.AutoSize = True
        Me.lblsuppname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppname.Location = New System.Drawing.Point(16, 32)
        Me.lblsuppname.Name = "lblsuppname"
        Me.lblsuppname.Size = New System.Drawing.Size(96, 19)
        Me.lblsuppname.TabIndex = 2
        Me.lblsuppname.Text = "Supplier Name:"
        '
        'lblpopno
        '
        Me.lblpopno.AutoSize = True
        Me.lblpopno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpopno.Location = New System.Drawing.Point(16, 64)
        Me.lblpopno.Name = "lblpopno"
        Me.lblpopno.Size = New System.Drawing.Size(125, 19)
        Me.lblpopno.TabIndex = 1
        Me.lblpopno.Text = "Purchase Order No.:"
        '
        'txtorderno
        '
        Me.txtorderno.EditValue = ""
        Me.txtorderno.Location = New System.Drawing.Point(152, 64)
        Me.txtorderno.Name = "txtorderno"
        '
        'txtorderno.Properties
        '
        Me.txtorderno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorderno.Properties.Appearance.Options.UseFont = True
        Me.txtorderno.Size = New System.Drawing.Size(160, 22)
        Me.txtorderno.TabIndex = 2
        '
        'txtsuppid
        '
        Me.txtsuppid.EditValue = ""
        Me.txtsuppid.Location = New System.Drawing.Point(152, 32)
        Me.txtsuppid.Name = "txtsuppid"
        '
        'txtsuppid.Properties
        '
        Me.txtsuppid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuppid.Properties.Appearance.Options.UseFont = True
        Me.txtsuppid.Size = New System.Drawing.Size(160, 22)
        Me.txtsuppid.TabIndex = 31
        '
        'frmpop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 526)
        Me.Controls.Add(Me.lblunit)
        Me.Name = "frmpop"
        Me.Text = "Purchase Order"
        CType(Me.gvpop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdpopdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblunit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblunit.ResumeLayout(False)
        CType(Me.dtqtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqtnno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbsuppid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtprice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdeldate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtorderno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsuppid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmpop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If strcheck = "Add" Then
            
            txtorderno.Text = GetMaxNo("PO_No", "Purchase_Master", "PO", 10)
        End If

        If strcheck = "Edit" Then


            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Select * from Purchase_Master where PO_No = '" & ModMain.strgridid & "'"

            dr = cmd.ExecuteReader
            dr.Read()
            bind_data()
            cmd.Dispose()
            dr.Close()


        End If
    End Sub

    Private Sub cmbsuppid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbsuppid.GotFocus
        Try
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select Suppname from SupplierMaster"
            dr = cmd.ExecuteReader
            Do While dr.Read()
                cmbsuppid.Properties.Items.Add(dr.Item(0))
            Loop
            dr.Close()
            cmd.Dispose()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbsuppid_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbsuppid.Validating
        If cmbsuppid.Text <> "" Then
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            cmd.CommandText = "select suppid from suppliermaster where suppname = '" & cmbsuppid.Text & "'"
            strsuppid = cmd.ExecuteScalar
            MsgBox(strsuppid)

        End If
    End Sub

    Private Sub bind_data()
        Try
            If IsDBNull(dr("PO_No")) = True Then
                txtorderno.Text = ""
            Else
                txtorderno.Text = dr("PO_No").ToString
            End If

            'Purchase Order Date

            If IsDBNull(dr("PO_date").ToString) = True Then
                dtpop.EditValue = ""
            Else
                dtpop.EditValue = dr("PO_date").ToString
            End If

            'Quotation Number
            If IsDBNull(dr("Qtn_No").ToString) = True Then
                txtorderno.Text = ""
            Else
                txtorderno.Text = dr("Qtn_No").ToString
            End If

            'qtn_date

            If IsDBNull(dr("qtn_Date").ToString) = True Then
                dtqtn.EditValue = ""
            Else
                dtqtn.EditValue = dr("qtn_date").ToString
            End If
            Dim strsuppid1 As String
            strsuppid1 = dr("suppid").ToString
            dr.Close()
            If strsuppid1 <> "" Then
                ' dr.Close()
                Dim cmdtemp As New OleDb.OleDbCommand
                cmdtemp.CommandType = CommandType.Text
                cmdtemp.Connection = conn
                cmdtemp.CommandText = "select suppname from suppliermaster where suppid = '" & strsuppid1 & "'"
                'MsgBox("select suppname from suppliermaster where suppid = '" & ModMain.strgridid & "'")

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

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
End Class
