Imports System.Data
Public Class frmFindSupplier
    Inherits DevExpress.XtraEditors.XtraForm
    Dim dt As New DataTable
    Dim strRID As String

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
    Friend WithEvents lkupFG As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdSupplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvsupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblRM As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblRM = New System.Windows.Forms.Label
        Me.lkupFG = New DevExpress.XtraEditors.LookUpEdit
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.gdSupplier = New DevExpress.XtraGrid.GridControl
        Me.gvsupplier = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvsupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRM
        '
        Me.lblRM.Location = New System.Drawing.Point(8, 16)
        Me.lblRM.Name = "lblRM"
        Me.lblRM.Size = New System.Drawing.Size(104, 24)
        Me.lblRM.TabIndex = 0
        Me.lblRM.Text = "Raw Material:"
        '
        'lkupFG
        '
        Me.lkupFG.Location = New System.Drawing.Point(88, 16)
        Me.lkupFG.Name = "lkupFG"
        '
        'lkupFG.Properties
        '
        Me.lkupFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFG.Properties.NullText = ""
        Me.lkupFG.Size = New System.Drawing.Size(280, 20)
        Me.lkupFG.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(376, 16)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(72, 24)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "&Find"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(376, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'gdSupplier
        '
        '
        'gdSupplier.EmbeddedNavigator
        '
        Me.gdSupplier.EmbeddedNavigator.Name = ""
        Me.gdSupplier.Location = New System.Drawing.Point(8, 48)
        Me.gdSupplier.MainView = Me.gvsupplier
        Me.gdSupplier.Name = "gdSupplier"
        Me.gdSupplier.Size = New System.Drawing.Size(440, 144)
        Me.gdSupplier.TabIndex = 10
        Me.gdSupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvsupplier})
        '
        'gvsupplier
        '
        Me.gvsupplier.GridControl = Me.gdSupplier
        Me.gvsupplier.Name = "gvsupplier"
        Me.gvsupplier.OptionsBehavior.Editable = False
        Me.gvsupplier.OptionsCustomization.AllowColumnMoving = False
        Me.gvsupplier.OptionsCustomization.AllowGroup = False
        Me.gvsupplier.OptionsMenu.EnableFooterMenu = False
        Me.gvsupplier.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvsupplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvsupplier.OptionsView.ShowGroupPanel = False
        '
        'frmFindSupplier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(456, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.gdSupplier)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lkupFG)
        Me.Controls.Add(Me.lblRM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFindSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Supplier"
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvsupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            If strRID = "" Or lkupFG.Text = "" Then Exit Sub
            Dim adp As New OleDb.OleDbDataAdapter("SELECT SupplierMaster.SuppID, SupplierMaster.SuppName " _
                & " FROM SupplierMaster INNER JOIN SuppItemMaster ON SupplierMaster.SID = SuppItemMaster.SuppID " _
                & " WHERE (((SuppItemMaster.RID)='" & strRID & "'))", conn)

            dt.Clear()
            adp.Fill(dt)
            gdSupplier.DataSource = dt
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub frmFindSupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FillLookup("Select RMItemName,RID from RMItemMaster ", "RMItem", "Item Name", "Item ID", lkupFG)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupFG_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupFG.EditValueChanged
        Try
            If lkupFG.EditValue <> "" Then
                Dim row As DataRowView = lkupFG.Properties.GetDataSourceRowByKeyValue(lkupFG.EditValue)
                strRID = row(1).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class

