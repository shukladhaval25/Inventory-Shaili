Imports DevExpress.XtraEditors.Repository
Public Class frmChallan
    Inherits DevExpress.XtraEditors.XtraForm
    Dim cmd As OleDb.OleDbCommand
    Dim dr1 As OleDb.OleDbDataReader
    Dim dt As New DataTable
    Dim cmbTemp As RepositoryItemComboBox
    Dim lkupRep As RepositoryItemLookUpEdit
    Public strCheck As String

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
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChallanNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbChallanNo As System.Windows.Forms.Label
    Friend WithEvents gvChallan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdChallan As DevExpress.XtraGrid.GridControl
    Friend WithEvents lblDesMode As System.Windows.Forms.Label
    Friend WithEvents lblChallanDate As System.Windows.Forms.Label
    Friend WithEvents dtChallanDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblDesDate As System.Windows.Forms.Label
    Friend WithEvents DtDespatchDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblOrderDate As System.Windows.Forms.Label
    Friend WithEvents dtOrderDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grchallanDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents txtCustName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbDesMode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lkupOrderno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkupItem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gvChallan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gdChallan = New DevExpress.XtraGrid.GridControl
        Me.lblunit = New DevExpress.XtraEditors.GroupControl
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.txtrate = New DevExpress.XtraEditors.TextEdit
        Me.lblOrderDate = New System.Windows.Forms.Label
        Me.dtOrderDate = New DevExpress.XtraEditors.DateEdit
        Me.lblDesDate = New System.Windows.Forms.Label
        Me.DtDespatchDate = New DevExpress.XtraEditors.DateEdit
        Me.lblChallanDate = New System.Windows.Forms.Label
        Me.dtChallanDate = New DevExpress.XtraEditors.DateEdit
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdclose = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblProduct = New System.Windows.Forms.Label
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.lkupItem = New DevExpress.XtraEditors.LookUpEdit
        Me.grchallanDetails = New DevExpress.XtraEditors.GroupControl
        Me.cmbDesMode = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblCustName = New System.Windows.Forms.Label
        Me.txtCustName = New DevExpress.XtraEditors.TextEdit
        Me.txtOrderNo = New DevExpress.XtraEditors.TextEdit
        Me.lkupOrderno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtChallanNo = New DevExpress.XtraEditors.TextEdit
        Me.lbChallanNo = New System.Windows.Forms.Label
        Me.lblOrderNo = New System.Windows.Forms.Label
        Me.lblDesMode = New System.Windows.Forms.Label
        CType(Me.gvChallan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdChallan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblunit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblunit.SuspendLayout()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDespatchDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtChallanDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lkupItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grchallanDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grchallanDetails.SuspendLayout()
        CType(Me.cmbDesMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupOrderno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChallanNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvChallan
        '
        Me.gvChallan.GridControl = Me.gdChallan
        Me.gvChallan.Name = "gvChallan"
        Me.gvChallan.OptionsCustomization.AllowColumnMoving = False
        Me.gvChallan.OptionsCustomization.AllowGroup = False
        Me.gvChallan.OptionsMenu.EnableFooterMenu = False
        Me.gvChallan.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvChallan.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvChallan.OptionsView.ShowGroupPanel = False
        '
        'gdChallan
        '
        Me.gdChallan.EmbeddedNavigator.Name = ""
        Me.gdChallan.Location = New System.Drawing.Point(8, 8)
        Me.gdChallan.MainView = Me.gvChallan
        Me.gdChallan.Name = "gdChallan"
        Me.gdChallan.Size = New System.Drawing.Size(491, 216)
        Me.gdChallan.TabIndex = 9
        Me.gdChallan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChallan})
        '
        'lblunit
        '
        Me.lblunit.Controls.Add(Me.cmdReport)
        Me.lblunit.Controls.Add(Me.cmdAdd)
        Me.lblunit.Controls.Add(Me.txtrate)
        Me.lblunit.Controls.Add(Me.lblOrderDate)
        Me.lblunit.Controls.Add(Me.lblChallanDate)
        Me.lblunit.Controls.Add(Me.dtChallanDate)
        Me.lblunit.Controls.Add(Me.cmdsave)
        Me.lblunit.Controls.Add(Me.cmdclose)
        Me.lblunit.Controls.Add(Me.PanelControl1)
        Me.lblunit.Controls.Add(Me.grchallanDetails)
        Me.lblunit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblunit.Location = New System.Drawing.Point(0, 0)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(515, 511)
        Me.lblunit.TabIndex = 15
        Me.lblunit.Text = "Challan Details"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(1, 478)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(84, 25)
        Me.cmdReport.TabIndex = 51
        Me.cmdReport.Text = "&Report"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(236, 481)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(57, 25)
        Me.cmdAdd.TabIndex = 50
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.Visible = False
        '
        'txtrate
        '
        Me.txtrate.EditValue = ""
        Me.txtrate.Location = New System.Drawing.Point(300, 481)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Properties.Appearance.Options.UseFont = True
        Me.txtrate.Size = New System.Drawing.Size(33, 22)
        Me.txtrate.TabIndex = 49
        Me.txtrate.Visible = False
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderDate.Location = New System.Drawing.Point(312, 52)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(39, 16)
        Me.lblOrderDate.TabIndex = 47
        Me.lblOrderDate.Text = "Date:"
        Me.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtOrderDate
        '
        Me.dtOrderDate.EditValue = New Date(CType(0, Long))
        Me.dtOrderDate.Location = New System.Drawing.Point(356, 24)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.dtOrderDate.Properties.Appearance.Options.UseForeColor = True
        Me.dtOrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtOrderDate.Size = New System.Drawing.Size(136, 20)
        Me.dtOrderDate.TabIndex = 2
        '
        'lblDesDate
        '
        Me.lblDesDate.AutoSize = True
        Me.lblDesDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesDate.Location = New System.Drawing.Point(308, 112)
        Me.lblDesDate.Name = "lblDesDate"
        Me.lblDesDate.Size = New System.Drawing.Size(39, 16)
        Me.lblDesDate.TabIndex = 45
        Me.lblDesDate.Text = "Date:"
        Me.lblDesDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtDespatchDate
        '
        Me.DtDespatchDate.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.DtDespatchDate.Location = New System.Drawing.Point(356, 112)
        Me.DtDespatchDate.Name = "DtDespatchDate"
        Me.DtDespatchDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtDespatchDate.Size = New System.Drawing.Size(136, 20)
        Me.DtDespatchDate.TabIndex = 7
        '
        'lblChallanDate
        '
        Me.lblChallanDate.AutoSize = True
        Me.lblChallanDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChallanDate.Location = New System.Drawing.Point(312, 106)
        Me.lblChallanDate.Name = "lblChallanDate"
        Me.lblChallanDate.Size = New System.Drawing.Size(39, 16)
        Me.lblChallanDate.TabIndex = 43
        Me.lblChallanDate.Text = "Date:"
        Me.lblChallanDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtChallanDate
        '
        Me.dtChallanDate.EditValue = New Date(2007, 1, 2, 0, 0, 0, 0)
        Me.dtChallanDate.Location = New System.Drawing.Point(360, 106)
        Me.dtChallanDate.Name = "dtChallanDate"
        Me.dtChallanDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtChallanDate.Size = New System.Drawing.Size(136, 20)
        Me.dtChallanDate.TabIndex = 5
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(340, 481)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(76, 25)
        Me.cmdsave.TabIndex = 8
        Me.cmdsave.Text = "&Save"
        '
        'cmdclose
        '
        Me.cmdclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdclose.Location = New System.Drawing.Point(420, 481)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(76, 25)
        Me.cmdclose.TabIndex = 9
        Me.cmdclose.Text = "&Close"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.lblProduct)
        Me.PanelControl1.Controls.Add(Me.btnDelete)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.lkupItem)
        Me.PanelControl1.Controls.Add(Me.gdChallan)
        Me.PanelControl1.Location = New System.Drawing.Point(4, 171)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(505, 296)
        Me.PanelControl1.TabIndex = 24
        Me.PanelControl1.Text = "PanelControl1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "To add extra item or item with other batch no use bellow option."
        '
        'lblProduct
        '
        Me.lblProduct.Location = New System.Drawing.Point(8, 264)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(40, 24)
        Me.lblProduct.TabIndex = 13
        Me.lblProduct.Text = "Item:"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(416, 264)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 24)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(336, 264)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 24)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Add"
        '
        'lkupItem
        '
        Me.lkupItem.Location = New System.Drawing.Point(48, 264)
        Me.lkupItem.Name = "lkupItem"
        Me.lkupItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupItem.Properties.NullText = ""
        Me.lkupItem.Size = New System.Drawing.Size(280, 20)
        Me.lkupItem.TabIndex = 10
        '
        'grchallanDetails
        '
        Me.grchallanDetails.Controls.Add(Me.cmbDesMode)
        Me.grchallanDetails.Controls.Add(Me.lblCustName)
        Me.grchallanDetails.Controls.Add(Me.txtCustName)
        Me.grchallanDetails.Controls.Add(Me.txtOrderNo)
        Me.grchallanDetails.Controls.Add(Me.dtOrderDate)
        Me.grchallanDetails.Controls.Add(Me.lkupOrderno)
        Me.grchallanDetails.Controls.Add(Me.DtDespatchDate)
        Me.grchallanDetails.Controls.Add(Me.lblDesDate)
        Me.grchallanDetails.Controls.Add(Me.txtChallanNo)
        Me.grchallanDetails.Controls.Add(Me.lbChallanNo)
        Me.grchallanDetails.Controls.Add(Me.lblOrderNo)
        Me.grchallanDetails.Controls.Add(Me.lblDesMode)
        Me.grchallanDetails.Location = New System.Drawing.Point(4, 23)
        Me.grchallanDetails.Name = "grchallanDetails"
        Me.grchallanDetails.Size = New System.Drawing.Size(505, 142)
        Me.grchallanDetails.TabIndex = 48
        Me.grchallanDetails.Text = "DESPATCH DETAILS"
        '
        'cmbDesMode
        '
        Me.cmbDesMode.EditValue = ""
        Me.cmbDesMode.Location = New System.Drawing.Point(120, 108)
        Me.cmbDesMode.Name = "cmbDesMode"
        Me.cmbDesMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDesMode.Size = New System.Drawing.Size(168, 20)
        Me.cmbDesMode.TabIndex = 29
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(8, 52)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(105, 16)
        Me.lblCustName.TabIndex = 28
        Me.lblCustName.Text = "Customer Name:"
        '
        'txtCustName
        '
        Me.txtCustName.EditValue = ""
        Me.txtCustName.Location = New System.Drawing.Point(120, 52)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Properties.Appearance.Options.UseFont = True
        Me.txtCustName.Properties.MaxLength = 15
        Me.txtCustName.Size = New System.Drawing.Size(372, 22)
        Me.txtCustName.TabIndex = 3
        '
        'txtOrderNo
        '
        Me.txtOrderNo.EditValue = ""
        Me.txtOrderNo.Location = New System.Drawing.Point(120, 52)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.Properties.Appearance.Options.UseFont = True
        Me.txtOrderNo.Properties.MaxLength = 15
        Me.txtOrderNo.Size = New System.Drawing.Size(168, 22)
        Me.txtOrderNo.TabIndex = 1
        '
        'lkupOrderno
        '
        Me.lkupOrderno.EditValue = ""
        Me.lkupOrderno.Location = New System.Drawing.Point(120, 24)
        Me.lkupOrderno.Name = "lkupOrderno"
        Me.lkupOrderno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupOrderno.Size = New System.Drawing.Size(168, 20)
        Me.lkupOrderno.TabIndex = 30
        '
        'txtChallanNo
        '
        Me.txtChallanNo.EditValue = ""
        Me.txtChallanNo.Location = New System.Drawing.Point(120, 80)
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChallanNo.Properties.Appearance.Options.UseFont = True
        Me.txtChallanNo.Properties.MaxLength = 25
        Me.txtChallanNo.Size = New System.Drawing.Size(168, 22)
        Me.txtChallanNo.TabIndex = 4
        '
        'lbChallanNo
        '
        Me.lbChallanNo.AutoSize = True
        Me.lbChallanNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChallanNo.Location = New System.Drawing.Point(12, 80)
        Me.lbChallanNo.Name = "lbChallanNo"
        Me.lbChallanNo.Size = New System.Drawing.Size(78, 16)
        Me.lbChallanNo.TabIndex = 34
        Me.lbChallanNo.Text = "Challan No.:"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.Location = New System.Drawing.Point(12, 25)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(69, 16)
        Me.lblOrderNo.TabIndex = 26
        Me.lblOrderNo.Text = "Order No.:"
        '
        'lblDesMode
        '
        Me.lblDesMode.AutoSize = True
        Me.lblDesMode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesMode.Location = New System.Drawing.Point(12, 109)
        Me.lblDesMode.Name = "lblDesMode"
        Me.lblDesMode.Size = New System.Drawing.Size(100, 16)
        Me.lblDesMode.TabIndex = 39
        Me.lblDesMode.Text = "Despatch Mode:"
        '
        'frmChallan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(515, 511)
        Me.Controls.Add(Me.lblunit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChallan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Challan"
        CType(Me.gvChallan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdChallan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblunit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblunit.ResumeLayout(False)
        Me.lblunit.PerformLayout()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDespatchDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtChallanDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.lkupItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grchallanDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grchallanDetails.ResumeLayout(False)
        Me.grchallanDetails.PerformLayout()
        CType(Me.cmbDesMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupOrderno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChallanNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If isValidate() = True Then
                If strCheck.Trim = "Add" Then
                    cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "insert into ChallanMaster values ('" & lkupOrderno.Text.Trim & "','" & dtOrderDate.Text & "','" & txtCustName.Tag & "','" & txtChallanNo.Text & "','" & dtChallanDate.Text & "','" & cmbDesMode.Text & "','" & DtDespatchDate.Text & "','" & strCY.Trim & "')"
                    cmd.Connection = conn

                    cmd.Transaction = conn.BeginTransaction
                    cmd.ExecuteNonQuery()

                    Dim i As Int16
                    For i = 0 To gvChallan.RowCount - 1
                        cmd.CommandText = "Insert into ChallanDetail values ('" & txtChallanNo.Text & "','" & lkupOrderno.Text.Trim & "','" & gvChallan.GetRowCellValue(i, "FID") & "','" & gvChallan.GetRowCellValue(i, "Batch No") & "'," & gvChallan.GetRowCellValue(i, "Dispatch Qty") & "," & IIf(gvChallan.GetRowCellValue(i, "Rate").ToString = "", 0, gvChallan.GetRowCellValue(i, "Rate")) & ",'" & gvChallan.GetRowCellValue(i, "Remarks") & "','" & strCY.Trim & "')"
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "Update InvoiceMaster set Challan_No ='" & txtChallanNo.Text & "' where Order_No ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "Select count(Batch_No) from FinishGoods_QCDetail where Batch_No ='" & gvChallan.GetRowCellValue(i, "Batch No") & "' and FID ='" & gvChallan.GetRowCellValue(i, "FID") & "'"   ' and CY ='" & strCY.Trim & "'"
                        If cmd.ExecuteScalar > 0 Then
                            cmd.CommandText = "update FGStock set Balance_Qty = (Balance_Qty - " & gvChallan.GetRowCellValue(i, "Dispatch Qty") & "), Issue_Qty = Issue_Qty + " & gvChallan.GetRowCellValue(i, "Dispatch Qty") _
                                & " where FID = '" & gvChallan.GetRowCellValue(i, "FID") & "' and Batch_No = (Select Batch_No from FinishGoods_QCDetail where Batch_No ='" & gvChallan.GetRowCellValue(i, "Batch No") & "' and FID ='" & gvChallan.GetRowCellValue(i, "FID") & "')" ' and CY ='" & strCY.Trim & "') and CY ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()
                        Else
                            cmd.CommandText = "Update FGStock set Balance_Qty = (Balance_Qty - " & gvChallan.GetRowCellValue(i, "Dispatch Qty") & "),Issue_Qty = (Issue_Qty + " & gvChallan.GetRowCellValue(i, "Dispatch Qty") _
                                & ") Where FID ='" & gvChallan.GetRowCellValue(i, "FID") & "' and Batch_No = '" & gvChallan.GetRowCellValue(i, "Batch No") & "'" ' and CY ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    cmd.Transaction.Commit()

                    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                ElseIf strCheck.Trim = "Edit" Then
                    cmd = New OleDb.OleDbCommand
                    cmd.Connection = conn

                    cmd.CommandText = "Update ChallanMaster set Challan_No ='" & txtChallanNo.Text & "',Challan_dt ='" & dtChallanDate.Text & "',M_of_Des='" & cmbDesMode.Text.Trim & "',Des_Date ='" & DtDespatchDate.Text & "'" _
                        & " where Order_No ='" & txtOrderNo.Text & "'" ' and CY ='" & strCY.Trim & "'"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "Update InvoiceMaster set Challan_No ='" & txtChallanNo.Text & "' where Order_No ='" & txtOrderNo.Text.Trim & "'"  ' and CY ='" & strCY.Trim & "'"
                    cmd.ExecuteNonQuery()

                    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
            cmd.Transaction.Rollback()
        Finally
        End Try
    End Sub
    Private Function isValidate() As Boolean
        Try
            If strCheck.Trim = "Add" Then
                If lkupOrderno.Text.Trim = "" Or txtChallanNo.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please enter order no and challan no")
                    Return False
                Else
                    Return True
                End If
            ElseIf strCheck.Trim = "Edit" Then
                If txtOrderNo.Text.Trim = "" Or txtChallanNo.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please enter order no and challan no")
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Function
    Private Sub frmChallan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dt.Columns.Add("FID", System.Type.GetType("System.String"))
            dt.Columns.Add("Finish Good Name", System.Type.GetType("System.String"))
            dt.Columns.Add("Order Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("Batch No", System.Type.GetType("System.String"))
            dt.Columns.Add("Dispatch Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("Rate", System.Type.GetType("System.Double"))
            dt.Columns.Add("Remarks", System.Type.GetType("System.String"))
            dt.Columns.Add("Challan No", System.Type.GetType("System.String"))
            dt.Columns.Add("Order No", System.Type.GetType("System.String"))


            If strCheck.Trim = "Add" Then
                'FillLookup("SELECT InvoiceMaster.Order_No, InvoiceMaster.Order_Date, CustomerMaster.CustName " _
                '    & " FROM InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID ", "OrderNo", "Order_No", "Order Date", lkupOrderno)
                FillCombox("InvoiceMaster", "Order_No", lkupOrderno)
                lkupOrderno.Visible = True
                txtOrderNo.Visible = False
                dtChallanDate.EditValue = Now
                DtDespatchDate.EditValue = Now
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                lkupItem.Enabled = False

            ElseIf strCheck.Trim = "Edit" Then
                'FillLookup("SELECT ChallanMaster.Order_No, ChallanMaster.Order_Date " _
                '    & " FROM ChallanMaster ", "OrderNo", "Order_No", "Order Date", lkupOrderno)
            End If
            'lkupOrderno.Properties.Columns(1).Visible = True
            If strCheck.Trim = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT ChallanMaster.Order_No, ChallanMaster.Order_Date, CustomerMaster.CustName, ChallanMaster.CID, ChallanMaster.Challan_No, ChallanMaster.Challan_dt, ChallanMaster.M_Of_Des, ChallanMaster.Des_Date" _
                    & " FROM ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID" _
                    & " WHERE (((ChallanMaster.Challan_No)='" & ModMain.strgridid.Trim & "'))" 'AND CY ='" & strCY.Trim & "'

                dr1 = cmd.ExecuteReader
                dr1.Read()
                bind_data()
                lkupOrderno.Visible = False
                txtOrderNo.Visible = True
                txtOrderNo.Properties.ReadOnly = True
                txtCustName.Properties.ReadOnly = True
                dtOrderDate.Properties.ReadOnly = True
                'gvChallan.OptionsBehavior.Editable = False
                cmd.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtOrderNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOrderNo.LostFocus
        Try
            If lkupOrderno.Text.Trim <> "" And strCheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn

                cmd.CommandText = "Select count(*) from ChallanMaster where order_No ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"
                If cmd.ExecuteScalar > 0 Then
                    'cmd.CommandText = "Select count(*) from ChallanDetail where order_no ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"
                    'If cmd.ExecuteScalar = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate Order No", "Duplicate!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                    'End If
                End If

                cmd.CommandText = "Select count(*) from InvoiceMaster where Order_No ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"
                If cmd.ExecuteScalar = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Order No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                cmd.CommandText = "SELECT InvoiceMaster.Order_No, InvoiceMaster.Order_Date, InvoiceMaster.Challan_No, InvoiceMaster.CID, CustomerMaster.CustName, InvoiceMaster.Order_No " _
                        & " FROM InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID " _
                        & " WHERE (((InvoiceMaster.Order_No)='" & lkupOrderno.Text.Trim & "')) and InvoiceMaster.CY ='" & strCY.Trim & "'"

                dr1 = cmd.ExecuteReader
                dr1.Read()
                bind_data()
                cmd.Dispose()

            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        Finally
        End Try
    End Sub

    Private Sub gvChallan_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvChallan.CustomRowCellEdit

        Try
            'If gvChallan.GetRowCellValue(e.RowHandle, gvChallan.Columns(2)) = "Qty" Then
            If e.Column.FieldName = "Dispatch Qty" Or e.Column.FieldName = "Rate" Then
                gvChallan.Columns("Dispatch Qty").OptionsColumn.AllowEdit = True
            ElseIf e.Column.FieldName = "Batch No" And strCheck.Trim = "Add" Then
                cmbTemp = New RepositoryItemComboBox
                lkupRep = New RepositoryItemLookUpEdit
                'cmbTemp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
                lkupRep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

                Dim ds As New DataSet
                Dim strSql As String

                strSql = "SELECT FinishGoods_QCDetail.Batch_NO, Sum(FGStock.Balance_Qty) AS Qty " _
                    & " FROM FGStock INNER JOIN FinishGoods_QCDetail ON (FGStock.Batch_No = FinishGoods_QCDetail.Batch_NO) AND (FGStock.FID = FinishGoods_QCDetail.FID) " _
                    & " WHERE (((FGStock.FID)='" & gvChallan.GetRowCellValue(e.RowHandle, gvChallan.Columns(0)) & "'))" _
                    & " GROUP BY FinishGoods_QCDetail.Batch_NO " _
                    & " HAVING (((Sum(FGStock.Balance_Qty))>0)); "


                Dim Adpt As New OleDb.OleDbDataAdapter
                Adpt.SelectCommand = New OleDb.OleDbCommand
                Adpt.SelectCommand.Connection = conn
                Adpt.SelectCommand.CommandText = strSql
                Adpt.Fill(ds, "Challan")

                strSql = "SELECT FGStock.Batch_No, FGStock.Balance_Qty as Qty, FGStock.Batch_No " _
                    & " FROM FGStock INNER JOIN FG_Opening_Stock ON (FG_Opening_Stock.FGVI_NO = FGStock.Batch_No) AND (FGStock.FID = FG_Opening_Stock.FID) " _
                    & " WHERE (((FGStock.Balance_Qty)>0) AND ((FGStock.FID)='" & gvChallan.GetRowCellValue(e.RowHandle, gvChallan.Columns(0)) & "'))"
                Adpt.SelectCommand.CommandText = strSql
                Adpt.Fill(ds, "Challan")


                strSql = "SELECT FGStock.Batch_No, Sum(FGStock.Balance_Qty) AS Qty,FGStock.Batch_No " _
                    & " FROM (TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) INNER JOIN FGStock ON (TI_Rec_Det.FID = FGStock.FID) AND (TI_Rec_Det.Batch_No = FGStock.Batch_No) " _
                    & " GROUP BY FGStock.Batch_No, FGStock.Date,FGStock.FID " _
                    & " HAVING (Sum(FGStock.Balance_Qty)>0 AND FGStock.FID='" & gvChallan.GetRowCellValue(e.RowHandle, gvChallan.Columns(0)) & "')"

                Adpt.SelectCommand.CommandText = strSql
                Adpt.Fill(ds, "Challan")

                'Previous Year Return Qty Display
                strSql = "SELECT FGStock.Batch_No, Sum(FGStock.Balance_Qty) AS Qty " _
                    & " FROM FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
                    & " GROUP BY FGStock.Batch_No, FGStock.Balance_Qty, FGStock.Type, FGStock.FID " _
                    & " HAVING (((Sum(FGStock.Balance_Qty))>0) AND ((FGStock.Type)='Return') AND ((FGStock.FID)='" & gvChallan.GetRowCellValue(e.RowHandle, gvChallan.Columns(0)) & "'));"
                Adpt.SelectCommand.CommandText = strSql
                Adpt.Fill(ds, "Challan")

                lkupRep.Columns.Clear()
                lkupRep.NullText = ""

                lkupRep.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(ds.Tables(0).Columns(0).ToString))
                lkupRep.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(ds.Tables(0).Columns(1).ToString))

                lkupRep.DataSource = ds.Tables(0)
                lkupRep.DisplayMember = ds.Tables(0).Columns(0).ToString
                lkupRep.ValueMember = ds.Tables(0).Columns(0).ToString

                lkupRep.Columns(0).Caption = "Batch No"
                lkupRep.Columns(1).Caption = "Balance Qty"

                'lkupRep.Columns(ds.Tables(0).Columns(1).ToString).Visible = False
                lkupRep.GetDataSourceRowByDisplayValue(lkupRep.EditValueChangedFiringMode) ' EditValueChangedFiringDelay)
                e.RepositoryItem = lkupRep

            ElseIf e.Column.FieldName = "Remarks" Then
                gvChallan.Columns("Remarks").OptionsColumn.AllowEdit = True
            Else
                gvChallan.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = False
            End If

        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub bind_data()
        Try
            If IsDBNull(dr1("Order_Date")) = True Then
                dtOrderDate.EditValue = ""
            Else
                dtOrderDate.EditValue = dr1("Order_Date").ToString
            End If

            'If IsDBNull(dr1("Order_No")) = True Then
            '    lkupOrderno.EditValue = ""
            'Else
            '    lkupOrderno.EditValue = dr1("Order_No")
            'End If
            If strCheck.Trim = "Edit" Then
                If IsDBNull(dr1("Order_No")) = False Then
                    txtOrderNo.Text = dr1("Order_No")
                Else
                    txtOrderNo.Text = ""
                End If
            End If

            If IsDBNull(dr1("CustName")) = True Then
                txtCustName.Text = ""
            Else
                txtCustName.Text = dr1("CustName").ToString
                txtCustName.Tag = dr1("CID").ToString
            End If

            If IsDBNull(dr1("Challan_No")) = True Then
                txtChallanNo.Text = ""
            Else
                txtChallanNo.Text = dr1("Challan_No").ToString
            End If

            If strCheck.Trim = "Edit" Then
                If IsDBNull(dr1("M_of_Des")) = True Then
                    cmbDesMode.Text = ""
                Else
                    cmbDesMode.Text = dr1("M_Of_Des")
                End If
                If IsDBNull(dr1("Des_Date")) = True Then
                    DtDespatchDate.EditValue = ""
                Else
                    DtDespatchDate.EditValue = dr1("Des_Date").ToString
                End If
            End If

            dr1.Close()
            Dim strSql As String = ""
            Dim ds As New DataSet

            If strCheck.Trim = "Add" Then

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conn

                cmd.CommandText = "Select count(*) from ChallanMaster where order_No ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"

                If cmd.ExecuteScalar = 0 Then
                    strSql = "SELECT   InvoiceDetail.FID,FGMaster.FGName as [Finish Good Name], InvoiceDetail.Qty as [Order Qty], InvoiceDetail.Remarks, InvoiceDetail.Order_No as [Order No]" _
                                            & " FROM InvoiceDetail INNER JOIN FGMaster ON InvoiceDetail.FID = FGMaster.FID " _
                                            & " WHERE (((InvoiceDetail.Order_No)= '" & lkupOrderno.Text.Trim & "')) AND InvoiceDetail.CY ='" & strCY.Trim & "'"
                Else
                    strSql = "SELECT InvoiceDetail.FID,FGMaster.FGName as [Finish Good Name],([InvoiceDetail].[Qty]-Sum([ChallanDetail].[Qty])) AS [Order Qty], InvoiceDetail.Remarks, InvoiceDetail.Order_No as [Order No] " _
                                           & " FROM (FGMaster INNER JOIN ((InvoiceMaster INNER JOIN ChallanDetail ON InvoiceMaster.Order_No = ChallanDetail.Order_No) INNER JOIN InvoiceDetail ON (InvoiceMaster.Order_No = InvoiceDetail.Order_No) AND (ChallanDetail.FID = InvoiceDetail.FID)) ON (FGMaster.FID = InvoiceDetail.FID) AND (FGMaster.FID = ChallanDetail.FID)) INNER JOIN ChallanMaster ON (ChallanMaster.Challan_No = ChallanDetail.Challan_No) AND (InvoiceMaster.Order_No = ChallanMaster.Order_No) " _
                                           & " WHERE (((ChallanMaster.CY)='" & strCY.Trim & "') AND ((ChallanMaster.Order_No)='" & lkupOrderno.Text & "')) " _
                                           & " GROUP BY FGMaster.FGName, InvoiceDetail.FID, InvoiceDetail.Remarks, InvoiceDetail.Order_No, InvoiceDetail.Qty " _
                                           & " HAVING (((([InvoiceDetail].[Qty]-Sum([ChallanDetail].[Qty])))>0));"
                End If
            ElseIf strCheck.Trim = "Edit" Then
                strSql = "SELECT  ChallanDetail.FID, FGMaster.FGName as [Finish Good Name], ChallanDetail.BatchID AS [Batch No], ChallanDetail.Qty as [Dispatch Qty], ChallanDetail.Order_No as [Order No]," _
                        & " ChallanDetail.Rate, ChallanDetail.Remarks,InvoiceDetail.Qty as [Order Qty]  " _
                        & " FROM (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) INNER JOIN InvoiceDetail ON (ChallanDetail.FID = InvoiceDetail.FID) AND (ChallanDetail.Order_No = InvoiceDetail.Order_No) AND (FGMaster.FID = InvoiceDetail.FID)" _
                        & " WHERE (((ChallanDetail.Challan_No)='" & ModMain.strgridid.Trim & "'))" ' and ChallanDetail.CY ='" & strCY.Trim & "'"
            End If
            dt.Rows.Clear()
            adp = New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(dt)
            gdChallan.DataSource = dt
            gvChallan.Columns("FID").VisibleIndex = -1
            gvChallan.Columns("Order No").VisibleIndex = -1
            gvChallan.Columns("Challan No").VisibleIndex = -1

        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub
    Private Sub lkupOrderno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupOrderno.SelectedIndexChanged
        Try
            If lkupOrderno.Text <> "" And strCheck = "Add" Then
                Dim strType As String
                Dim strChallanNo As String
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn

                cmd.CommandText = "Select count(*) from ChallanMaster where order_No ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"

                If cmd.ExecuteScalar > 0 Then
                    cmd.CommandText = "SELECT count(InvoiceDetail.Order_No) FROM ((InvoiceMaster INNER JOIN ChallanDetail ON InvoiceMaster.Order_No = ChallanDetail.Order_No) INNER JOIN InvoiceDetail ON (InvoiceMaster.Order_No = InvoiceDetail.Order_No) AND (ChallanDetail.FID = InvoiceDetail.FID)) INNER JOIN ChallanMaster ON (ChallanMaster.Challan_No = ChallanDetail.Challan_No) AND (InvoiceMaster.Order_No = ChallanMaster.Order_No)" _
                        & " WHERE(((ChallanMaster.Order_No) = '" & lkupOrderno.Text.Trim & "') And ((ChallanMaster.CY) = '" & strCY & "')) " _
                        & " GROUP BY InvoiceDetail.Order_No, InvoiceDetail.Qty, ChallanDetail.FID " _
                        & " HAVING ((((InvoiceDetail.Qty-Sum(ChallanDetail.Qty)))>0));"
                    If cmd.ExecuteScalar = 0 Then
                        'cmd.CommandText = "Select count(*) from ChallanDetail where order_No ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"
                        'If cmd.ExecuteScalar = 0 Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate Order No", "Duplicate!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                cmd.CommandText = "Select count(*) from InvoiceMaster where Order_No ='" & lkupOrderno.Text.Trim & "' and CY ='" & strCY.Trim & "'"
                If cmd.ExecuteScalar = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Order No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                cmd.CommandText = "SELECT InvoiceMaster.Order_No, InvoiceMaster.Order_Date, InvoiceMaster.Challan_No, InvoiceMaster.CID, CustomerMaster.CustName, InvoiceMaster.Order_No, " _
                        & " InvoiceMaster.Type " _
                        & " FROM InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID " _
                        & " WHERE (((InvoiceMaster.Order_No)='" & lkupOrderno.Text.Trim & "')) and InvoiceMaster.CY ='" & strCY.Trim & "'"

                dr1 = cmd.ExecuteReader
                dr1.Read()
                If IsDBNull(dr1.Item("Type")) = True Then
                    strType = ""
                Else
                    strType = dr1.Item("Type")
                End If
                bind_data()
                If strType = "" Or strType.ToUpper = "REGULAR" Then
                    cmd.CommandText = "select  max(clng(Left(challan_No,5)))  from challanMaster where CY ='" & strCY.Trim & "' and  (Challan_No not like 'D%' and challan_No not like 'R%' and Challan_No not like 'E%' and Challan_No not like 'U%')"
                    cmd.Connection = conn
                    txtChallanNo.Text = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar) + 1
                    'txtChallanNo.Text = txtChallanNo.Text.PadLeft(6 - txtChallanNo.Text.Length, "0") & "/" & strCY.Trim
                    txtChallanNo.Text = txtChallanNo.Text.PadLeft(5, "0")
                ElseIf strType.ToUpper = "DEMO" Then
                    'cmd.CommandText = "select max(challan_No) from challanMaster where (Challan_No like 'D%')"
                    cmd.CommandText = "SELECT Max(CLng(Mid([ChallanMaster]![Challan_No],2,4))) AS Expr1 FROM challanMaster where CY ='" & strCY.Trim & "' and  (Challan_No like 'D%')"
                    cmd.Connection = conn
                    strChallanNo = IIf(IsDBNull(cmd.ExecuteScalar), "0", cmd.ExecuteScalar)
                    strChallanNo = Val(strChallanNo.Trim + 1)
                    txtChallanNo.Text = "D" & strChallanNo.PadLeft(4, "0")
                ElseIf strType.ToUpper = "REPAIR" Then
                    cmd.CommandText = "select Max(CLng(Mid([ChallanMaster]![Challan_No],2,4))) AS Expr1  from challanMaster where CY ='" & strCY.Trim & "' and  (Challan_No like 'R%')"
                    cmd.Connection = conn
                    strChallanNo = IIf(IsDBNull(cmd.ExecuteScalar), "0", cmd.ExecuteScalar)
                    strChallanNo = Val(strChallanNo.Trim + 1)
                    txtChallanNo.Text = "R" & strChallanNo.PadLeft(4, "0")
                ElseIf strType.ToUpper = "EXPORT" Then
                    cmd.CommandText = "select Max(CLng(Mid([ChallanMaster]![Challan_No],2,4))) AS Expr1  from challanMaster where CY ='" & strCY.Trim & "' and  (Challan_No like 'R%')"
                    cmd.Connection = conn
                    strChallanNo = IIf(IsDBNull(cmd.ExecuteScalar), "0", cmd.ExecuteScalar)
                    strChallanNo = Val(strChallanNo.Trim + 1)
                    txtChallanNo.Text = "E" & strChallanNo.PadLeft(4, "0")
                    'txtChallanNo.Text = "E" & Val(strChallanNo.Trim.Substring(1) + 1)
                Else
                    cmd.CommandText = "select  max(clng(Left(challan_No,5)))  from challanMaster where  CY ='" & strCY.Trim & "' and (Challan_No not like 'D%' and challan_No not like 'R%' and Challan_No not like 'E%' and Challan_No not like 'U%')"
                    cmd.Connection = conn
                    txtChallanNo.Text = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar) + 1
                    'txtChallanNo.Text = txtChallanNo.Text.PadLeft(6 - txtChallanNo.Text.Length, "0") & "/" & strCY.Trim
                    txtChallanNo.Text = txtChallanNo.Text.PadLeft(5, "0")
                End If
                txtChallanNo.Text = txtChallanNo.Text & "/" & strCY.Trim
                cmd.Dispose()

                lkupItem.Enabled = True
                lkupItem.Properties.Columns.Clear()
                FillLookup("SELECT FGMaster.FGName, InvoiceDetail.FID " _
                    & " FROM FGMaster INNER JOIN InvoiceDetail ON FGMaster.FID = InvoiceDetail.FID " _
                    & " WHERE (((InvoiceDetail.Order_No)='" & lkupOrderno.Text.Trim & "'))", "Invoice", "Item Name", "ID", lkupItem)
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        Finally
        End Try
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim mypara As New frmPara
            mypara.ShowChallan(ModMain.strgridid.Trim & "'")
            mypara.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub dtChallanDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtChallanDate.Validating
        Try
            'If dtChallanDate.EditValue < dtOrderDate.EditValue Then
            '    DevExpress.XtraEditors.XtraMessageBox.Show("Challan date can not be less then order date", "Date", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    e.Cancel = True
            'End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupItem.EditValueChanged
        Try
            If lkupItem.EditValue = Nothing Then Exit Sub
            If lkupItem.EditValue <> "" Then
                Dim row As DataRowView = lkupItem.Properties.GetDataSourceRowByKeyValue(lkupItem.EditValue)
                lkupItem.Tag = row(1).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If lkupItem.Text <> "" And lkupItem.Tag <> "" Then
                Dim dblReg As Double
                For i As Integer = 0 To gvChallan.RowCount - 1
                    If gvChallan.GetRowCellValue(i, "FID") = lkupItem.Tag Then
                        If IsDBNull(gvChallan.GetRowCellValue(i, "Dispatch Qty")) = False Then
                            dblReg = gvChallan.GetRowCellValue(i, "Order Qty") - gvChallan.GetRowCellValue(i, "Dispatch Qty")
                        End If
                    End If
                Next
                If dblReg > 0 Then
                    Dim dr As DataRow
                    dr = dt.NewRow
                    dr.Item(0) = lkupItem.Tag
                    dr.Item(1) = lkupItem.Text
                    dr.Item(2) = dblReg
                    dt.Rows.Add(dr)
                    lkupItem.EditValue = ""
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("You can not add item. Check batch no and despatch qty first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("First select item", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lkupItem.Focus()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If gvChallan.GetSelectedRows.Length > 0 Then
                If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvChallan.DeleteRow(gvChallan.FocusedRowHandle)
                    gvChallan.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class
