Public Class frmUnitConversion
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
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents grpUnit As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpUnitConv As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDefUnit As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDefQty As System.Windows.Forms.Label
    Friend WithEvents lkupItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupConvUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDefUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gdUnitConv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUnitConv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDefQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConvQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItemName As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpUnit = New DevExpress.XtraEditors.GroupControl
        Me.lkupItemName = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.lblGroup = New System.Windows.Forms.Label
        Me.grpUnitConv = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtConvQty = New DevExpress.XtraEditors.TextEdit
        Me.lkupConvUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDefUnit = New DevExpress.XtraEditors.TextEdit
        Me.txtDefQty = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDefUnit = New System.Windows.Forms.Label
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.lblDefQty = New System.Windows.Forms.Label
        Me.gdUnitConv = New DevExpress.XtraGrid.GridControl
        Me.gvUnitConv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtItemName = New DevExpress.XtraEditors.TextEdit
        CType(Me.grpUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUnit.SuspendLayout()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUnitConv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUnitConv.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtConvQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupConvUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDefUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDefQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdUnitConv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUnitConv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUnit
        '
        Me.grpUnit.Controls.Add(Me.lkupItemName)
        Me.grpUnit.Controls.Add(Me.cmdSave)
        Me.grpUnit.Controls.Add(Me.cmdClose)
        Me.grpUnit.Controls.Add(Me.lblGroup)
        Me.grpUnit.Controls.Add(Me.grpUnitConv)
        Me.grpUnit.Controls.Add(Me.txtItemName)
        Me.grpUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUnit.Location = New System.Drawing.Point(0, 0)
        Me.grpUnit.Name = "grpUnit"
        Me.grpUnit.Size = New System.Drawing.Size(426, 320)
        Me.grpUnit.TabIndex = 1
        Me.grpUnit.Text = "Unit Conversion"
        '
        'lkupItemName
        '
        Me.lkupItemName.EditValue = ""
        Me.lkupItemName.Location = New System.Drawing.Point(96, 32)
        Me.lkupItemName.Name = "lkupItemName"
        '
        'lkupItemName.Properties
        '
        Me.lkupItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupItemName.Properties.NullText = ""
        Me.lkupItemName.Size = New System.Drawing.Size(320, 20)
        Me.lkupItemName.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(264, 288)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "&Save"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(344, 288)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 25)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "&Cancel"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.Location = New System.Drawing.Point(16, 32)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(76, 19)
        Me.lblGroup.TabIndex = 35
        Me.lblGroup.Text = "Item Name:"
        '
        'grpUnitConv
        '
        Me.grpUnitConv.Controls.Add(Me.PanelControl1)
        Me.grpUnitConv.Controls.Add(Me.gdUnitConv)
        Me.grpUnitConv.Location = New System.Drawing.Point(16, 64)
        Me.grpUnitConv.Name = "grpUnitConv"
        Me.grpUnitConv.Size = New System.Drawing.Size(400, 216)
        Me.grpUnitConv.TabIndex = 2
        Me.grpUnitConv.Text = "PanelControl1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtConvQty)
        Me.PanelControl1.Controls.Add(Me.lkupConvUnit)
        Me.PanelControl1.Controls.Add(Me.txtDefUnit)
        Me.PanelControl1.Controls.Add(Me.txtDefQty)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.lblDefUnit)
        Me.PanelControl1.Controls.Add(Me.cmdAdd)
        Me.PanelControl1.Controls.Add(Me.cmdDelete)
        Me.PanelControl1.Controls.Add(Me.lblDefQty)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 8)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(384, 72)
        Me.PanelControl1.TabIndex = 44
        Me.PanelControl1.Text = "PanelControl1"
        '
        'txtConvQty
        '
        Me.txtConvQty.EditValue = ""
        Me.txtConvQty.Location = New System.Drawing.Point(166, 32)
        Me.txtConvQty.Name = "txtConvQty"
        '
        'txtConvQty.Properties
        '
        Me.txtConvQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvQty.Properties.Appearance.Options.UseFont = True
        Me.txtConvQty.Properties.MaxLength = 25
        Me.txtConvQty.Size = New System.Drawing.Size(64, 22)
        Me.txtConvQty.TabIndex = 4
        '
        'lkupConvUnit
        '
        Me.lkupConvUnit.EditValue = ""
        Me.lkupConvUnit.Location = New System.Drawing.Point(240, 32)
        Me.lkupConvUnit.Name = "lkupConvUnit"
        '
        'lkupConvUnit.Properties
        '
        Me.lkupConvUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupConvUnit.Properties.NullText = ""
        Me.lkupConvUnit.Size = New System.Drawing.Size(64, 20)
        Me.lkupConvUnit.TabIndex = 5
        '
        'txtDefUnit
        '
        Me.txtDefUnit.EditValue = ""
        Me.txtDefUnit.Location = New System.Drawing.Point(72, 32)
        Me.txtDefUnit.Name = "txtDefUnit"
        '
        'txtDefUnit.Properties
        '
        Me.txtDefUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefUnit.Properties.Appearance.Options.UseFont = True
        Me.txtDefUnit.Properties.MaxLength = 25
        Me.txtDefUnit.Properties.ReadOnly = True
        Me.txtDefUnit.Size = New System.Drawing.Size(64, 22)
        Me.txtDefUnit.TabIndex = 3
        Me.txtDefUnit.TabStop = False
        '
        'txtDefQty
        '
        Me.txtDefQty.EditValue = ""
        Me.txtDefQty.Location = New System.Drawing.Point(8, 32)
        Me.txtDefQty.Name = "txtDefQty"
        '
        'txtDefQty.Properties
        '
        Me.txtDefQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefQty.Properties.Appearance.Options.UseFont = True
        Me.txtDefQty.Properties.MaxLength = 25
        Me.txtDefQty.Size = New System.Drawing.Size(56, 22)
        Me.txtDefQty.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Conv. Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Conv. Qty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "="
        '
        'lblDefUnit
        '
        Me.lblDefUnit.AutoSize = True
        Me.lblDefUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefUnit.Location = New System.Drawing.Point(72, 8)
        Me.lblDefUnit.Name = "lblDefUnit"
        Me.lblDefUnit.Size = New System.Drawing.Size(75, 19)
        Me.lblDefUnit.TabIndex = 47
        Me.lblDefUnit.Text = "Default Unit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(320, 8)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 25)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(320, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(56, 25)
        Me.cmdDelete.TabIndex = 7
        Me.cmdDelete.Text = "&Delete"
        '
        'lblDefQty
        '
        Me.lblDefQty.AutoSize = True
        Me.lblDefQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefQty.Location = New System.Drawing.Point(16, 8)
        Me.lblDefQty.Name = "lblDefQty"
        Me.lblDefQty.Size = New System.Drawing.Size(25, 19)
        Me.lblDefQty.TabIndex = 46
        Me.lblDefQty.Text = "Qty"
        '
        'gdUnitConv
        '
        '
        'gdUnitConv.EmbeddedNavigator
        '
        Me.gdUnitConv.EmbeddedNavigator.Name = ""
        Me.gdUnitConv.Location = New System.Drawing.Point(8, 88)
        Me.gdUnitConv.MainView = Me.gvUnitConv
        Me.gdUnitConv.Name = "gdUnitConv"
        Me.gdUnitConv.Size = New System.Drawing.Size(384, 120)
        Me.gdUnitConv.TabIndex = 8
        Me.gdUnitConv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUnitConv})
        '
        'gvUnitConv
        '
        Me.gvUnitConv.GridControl = Me.gdUnitConv
        Me.gvUnitConv.Name = "gvUnitConv"
        Me.gvUnitConv.OptionsBehavior.Editable = False
        Me.gvUnitConv.OptionsCustomization.AllowColumnMoving = False
        Me.gvUnitConv.OptionsCustomization.AllowGroup = False
        Me.gvUnitConv.OptionsMenu.EnableFooterMenu = False
        Me.gvUnitConv.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvUnitConv.OptionsNavigation.UseTabKey = False
        Me.gvUnitConv.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvUnitConv.OptionsView.ShowGroupPanel = False
        '
        'txtItemName
        '
        Me.txtItemName.EditValue = ""
        Me.txtItemName.Location = New System.Drawing.Point(96, 32)
        Me.txtItemName.Name = "txtItemName"
        '
        'txtItemName.Properties
        '
        Me.txtItemName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Properties.Appearance.Options.UseFont = True
        Me.txtItemName.Properties.MaxLength = 25
        Me.txtItemName.Properties.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(320, 22)
        Me.txtItemName.TabIndex = 36
        Me.txtItemName.TabStop = False
        Me.txtItemName.Visible = False
        '
        'frmUnitConversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(426, 320)
        Me.Controls.Add(Me.grpUnit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnitConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit Conversion"
        CType(Me.grpUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUnit.ResumeLayout(False)
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUnitConv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUnitConv.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtConvQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupConvUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDefUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDefQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdUnitConv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUnitConv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim strItemID As String
    Dim strUnitID As String
    Dim strUnit As String
    Dim dtUnitConv As New DataTable
    Public strCheck As String = "Add"

    Private Sub frmUnitConversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            dtUnitConv.Columns.Add("Qty", System.Type.GetType("System.Double"))
            dtUnitConv.Columns.Add("Default Unit", System.Type.GetType("System.String"))
            dtUnitConv.Columns.Add("Default UnitID", System.Type.GetType("System.String"))
            dtUnitConv.Columns.Add("Conv. Qty", System.Type.GetType("System.Double"))
            dtUnitConv.Columns.Add("Conv. Unit", System.Type.GetType("System.String"))
            dtUnitConv.Columns.Add("Conv. UnitID", System.Type.GetType("System.String"))

            FillLookup("Select UnitName,UnitID from UnitMaster", "UnitMaster", "UNITID", "UnitName", lkupConvUnit)

            If strCheck = "Add" Then
                FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.Rid, UnitMaster.UnitName, RMItemMaster.UnitId " _
                   & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID", "RMItemMaster", "RID", "RMItemName", lkupItemName)

            ElseIf strCheck = "Edit" Then
                txtItemName.Visible = True
                txtItemName.BringToFront()
                lkupItemName.Visible = False

                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn

                cmd.CommandText = "SELECT RMItemMaster.Rid, RMItemMaster.RMItemName, UnitConMaster.FirstUnitID, UnitMaster.UnitName, UnitConMaster.FirstQty, UnitConMaster.SecUnitID, UnitMaster_1.UnitName, UnitConMaster.SecQty " _
                    & " FROM ((UnitConMaster INNER JOIN UnitMaster AS UnitMaster_1 ON UnitConMaster.SecUnitID = UnitMaster_1.UnitID) INNER JOIN UnitMaster ON UnitConMaster.FirstUnitID = UnitMaster.UnitID) INNER JOIN RMItemMaster ON (UnitConMaster.RMID = RMItemMaster.Rid) AND (UnitMaster.UnitID = RMItemMaster.UnitId) " _
                    & " WHERE (((RMItemMaster.Rid)='" & ModMain.strgridid.Trim & "'))"


                dr = cmd.ExecuteReader()
                bind_data()
                dr.Close()
                cmd.Dispose()
            End If

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub bind_data()
        Try
            Dim dRow As DataRow
            Do While dr.Read
                strItemID = dr.Item("RID").ToString()
                If IsDBNull(dr.Item("RMItemName")) = False Then
                    txtItemName.Text = dr.Item("RMItemName")
                Else
                    txtItemName.Text = ""
                End If

                dRow = dtUnitConv.NewRow
                dRow.Item(0) = dr.Item("FirstQty").ToString
                dRow.Item(1) = dr.Item("UnitMaster.UnitName").ToString
                txtDefUnit.Text = dr.Item("UnitMaster.UnitName").ToString
                txtDefUnit.Tag = dr.Item("FirstUnitID").ToString
                dRow.Item(2) = dr.Item("FirstUnitID")
                dRow.Item(3) = dr.Item("SecQty")
                dRow.Item(4) = dr.Item("UnitMaster_1.UnitName")
                dRow.Item(5) = dr.Item("SecUnitID")
                dtUnitConv.Rows.Add(dRow)
                gdUnitConv.DataSource = dtUnitConv
                gvUnitConv.Columns(2).Visible = False
                gvUnitConv.Columns(5).Visible = False
            Loop

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupItemName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupItemName.EditValueChanged
        Try
            If lkupItemName.EditValue = Nothing Then Exit Sub
            If lkupItemName.EditValue <> "" Then
                Dim row As DataRowView = lkupItemName.Properties.GetDataSourceRowByKeyValue(lkupItemName.EditValue)
                strItemID = row(1).ToString
                txtDefUnit.Text = row(2).ToString
                txtDefUnit.Tag = row(3).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupConvUnit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupConvUnit.EditValueChanged
        Try
            If lkupConvUnit.EditValue <> "" Then
                Dim row As DataRowView = lkupConvUnit.Properties.GetDataSourceRowByKeyValue(lkupConvUnit.EditValue)
                If row(0).ToString = txtDefUnit.Text Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("You can't create conversion for same conversion type", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lkupConvUnit.Focus()
                    Exit Sub
                End If
                strUnitID = row(1).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim dRow As DataRow
        Try
            If txtDefQty.Text = "" Or txtDefUnit.Text = "" Or txtConvQty.Text = "" Or lkupConvUnit.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Eneter all required data", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                For i As Int16 = 0 To gvUnitConv.RowCount - 1
                    If strUnitID = gvUnitConv.GetRowCellValue(i, gvUnitConv.Columns("Conv. UnitID")) Then
                        DevExpress.XtraEditors.XtraMessageBox.Show(Me, "This conversion unit is all ready exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Next
                dRow = dtUnitConv.NewRow
                dRow.Item(0) = txtDefQty.Text
                dRow.Item(1) = txtDefUnit.Text
                dRow.Item(2) = txtDefUnit.Tag
                dRow.Item(3) = txtConvQty.Text
                dRow.Item(4) = lkupConvUnit.Text
                dRow.Item(5) = strUnitID

                dtUnitConv.Rows.Add(dRow)
                gdUnitConv.DataSource = dtUnitConv
                gvUnitConv.Columns(2).Visible = False
                gvUnitConv.Columns(5).Visible = False
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtDefQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDefQty.KeyPress
        Try
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtConvQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConvQty.KeyPress
        Try
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvUnitConv.GetSelectedRows.Length > 0 Then
                If MessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvUnitConv.DeleteRow(gvUnitConv.FocusedRowHandle)
                    gvUnitConv.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If strCheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                'cmd.Transaction = conn.BeginTransaction
                For i As Int16 = 0 To gvUnitConv.RowCount - 1
                    Dim strMaxID As String = GetMaxNo("UCID", "UnitConMaster", "UC", 10)
                    cmd.CommandText = "Insert into UnitConMaster values ('" & strMaxID & "','" & strItemID & "','" & gvUnitConv.GetRowCellValue(i, "Default UnitID") & "'," & gvUnitConv.GetRowCellValue(i, "Qty") & ",'" & gvUnitConv.GetRowCellValue(i, "Conv. UnitID") & "'," & gvUnitConv.GetRowCellValue(i, "Conv. Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                'cmd.Transaction.Rollback()
                cmd.Dispose()
            ElseIf strCheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                'cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "Delete from UnitConMaster where RMID ='" & ModMain.strgridid & "'"
                cmd.ExecuteNonQuery()
                For i As Int16 = 0 To gvUnitConv.RowCount - 1
                    Dim strMaxID As String = GetMaxNo("UCID", "UnitConMaster", "UC", 10)
                    cmd.CommandText = "Insert into UnitConMaster values ('" & strMaxID & "','" & strItemID & "','" & gvUnitConv.GetRowCellValue(i, "Default UnitID") & "'," & gvUnitConv.GetRowCellValue(i, "Qty") & ",'" & gvUnitConv.GetRowCellValue(i, "Conv. UnitID") & "'," & gvUnitConv.GetRowCellValue(i, "Conv. Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                'cmd.Transaction.Commit()
                cmd.Dispose()
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            'cmd.Transaction.Rollback()
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class

