﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRejectionComponent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlRejectionComponent = New DevExpress.XtraEditors.PanelControl()
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton()
        Me.grpRejectionDetails = New DevExpress.XtraEditors.GroupControl()
        Me.grdMatIssue = New DevExpress.XtraGrid.GridControl()
        Me.gvMatIssue = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grpRejectionMaster = New DevExpress.XtraEditors.GroupControl()
        Me.txtWorkOrderVal = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQtyVal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMIS = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtpRejectionDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFGVal = New System.Windows.Forms.Label()
        Me.lblFG = New System.Windows.Forms.Label()
        Me.lblMISDateVal = New System.Windows.Forms.Label()
        Me.lblMISDate = New System.Windows.Forms.Label()
        Me.lblMISNo = New System.Windows.Forms.Label()
        CType(Me.pnlRejectionComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRejectionComponent.SuspendLayout()
        CType(Me.grpRejectionDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRejectionDetails.SuspendLayout()
        CType(Me.grdMatIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMatIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRejectionMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRejectionMaster.SuspendLayout()
        CType(Me.txtWorkOrderVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRejectionDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRejectionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRejectionComponent
        '
        Me.pnlRejectionComponent.Controls.Add(Me.cmdReport)
        Me.pnlRejectionComponent.Controls.Add(Me.cmdcancel)
        Me.pnlRejectionComponent.Controls.Add(Me.cmdsave)
        Me.pnlRejectionComponent.Controls.Add(Me.grpRejectionDetails)
        Me.pnlRejectionComponent.Controls.Add(Me.grpRejectionMaster)
        Me.pnlRejectionComponent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRejectionComponent.Location = New System.Drawing.Point(0, 0)
        Me.pnlRejectionComponent.Name = "pnlRejectionComponent"
        Me.pnlRejectionComponent.Size = New System.Drawing.Size(1050, 472)
        Me.pnlRejectionComponent.TabIndex = 0
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(13, 438)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(64, 25)
        Me.cmdReport.TabIndex = 18
        Me.cmdReport.Text = "&Report"
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(974, 438)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(64, 25)
        Me.cmdcancel.TabIndex = 17
        Me.cmdcancel.Text = "&Cancel"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(902, 438)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(64, 25)
        Me.cmdsave.TabIndex = 16
        Me.cmdsave.Text = "&Save"
        '
        'grpRejectionDetails
        '
        Me.grpRejectionDetails.Controls.Add(Me.grdMatIssue)
        Me.grpRejectionDetails.Location = New System.Drawing.Point(13, 88)
        Me.grpRejectionDetails.Name = "grpRejectionDetails"
        Me.grpRejectionDetails.Size = New System.Drawing.Size(1025, 342)
        Me.grpRejectionDetails.TabIndex = 1
        Me.grpRejectionDetails.Text = "Material Issue Slip Details"
        '
        'grdMatIssue
        '
        Me.grdMatIssue.Location = New System.Drawing.Point(5, 25)
        Me.grdMatIssue.MainView = Me.gvMatIssue
        Me.grdMatIssue.Name = "grdMatIssue"
        Me.grdMatIssue.Size = New System.Drawing.Size(1015, 312)
        Me.grdMatIssue.TabIndex = 11
        Me.grdMatIssue.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMatIssue})
        '
        'gvMatIssue
        '
        Me.gvMatIssue.GridControl = Me.grdMatIssue
        Me.gvMatIssue.Name = "gvMatIssue"
        Me.gvMatIssue.OptionsCustomization.AllowColumnMoving = False
        Me.gvMatIssue.OptionsCustomization.AllowFilter = False
        Me.gvMatIssue.OptionsCustomization.AllowGroup = False
        Me.gvMatIssue.OptionsCustomization.AllowRowSizing = True
        Me.gvMatIssue.OptionsCustomization.AllowSort = False
        Me.gvMatIssue.OptionsView.ShowGroupPanel = False
        '
        'grpRejectionMaster
        '
        Me.grpRejectionMaster.Controls.Add(Me.txtWorkOrderVal)
        Me.grpRejectionMaster.Controls.Add(Me.Label4)
        Me.grpRejectionMaster.Controls.Add(Me.lblQtyVal)
        Me.grpRejectionMaster.Controls.Add(Me.Label2)
        Me.grpRejectionMaster.Controls.Add(Me.cmbMIS)
        Me.grpRejectionMaster.Controls.Add(Me.dtpRejectionDate)
        Me.grpRejectionMaster.Controls.Add(Me.Label1)
        Me.grpRejectionMaster.Controls.Add(Me.lblFGVal)
        Me.grpRejectionMaster.Controls.Add(Me.lblFG)
        Me.grpRejectionMaster.Controls.Add(Me.lblMISDateVal)
        Me.grpRejectionMaster.Controls.Add(Me.lblMISDate)
        Me.grpRejectionMaster.Controls.Add(Me.lblMISNo)
        Me.grpRejectionMaster.Location = New System.Drawing.Point(13, 13)
        Me.grpRejectionMaster.Name = "grpRejectionMaster"
        Me.grpRejectionMaster.ShowCaption = False
        Me.grpRejectionMaster.Size = New System.Drawing.Size(1025, 69)
        Me.grpRejectionMaster.TabIndex = 0
        '
        'txtWorkOrderVal
        '
        Me.txtWorkOrderVal.Enabled = False
        Me.txtWorkOrderVal.Location = New System.Drawing.Point(690, 37)
        Me.txtWorkOrderVal.Name = "txtWorkOrderVal"
        Me.txtWorkOrderVal.Properties.ReadOnly = True
        Me.txtWorkOrderVal.Size = New System.Drawing.Size(108, 20)
        Me.txtWorkOrderVal.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(602, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Work Order :"
        '
        'lblQtyVal
        '
        Me.lblQtyVal.Location = New System.Drawing.Point(529, 40)
        Me.lblQtyVal.Name = "lblQtyVal"
        Me.lblQtyVal.Size = New System.Drawing.Size(32, 16)
        Me.lblQtyVal.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(500, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Qty:"
        '
        'cmbMIS
        '
        Me.cmbMIS.Location = New System.Drawing.Point(76, 10)
        Me.cmbMIS.Name = "cmbMIS"
        Me.cmbMIS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMIS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbMIS.Size = New System.Drawing.Size(161, 20)
        Me.cmbMIS.TabIndex = 27
        '
        'dtpRejectionDate
        '
        Me.dtpRejectionDate.EditValue = New Date(2007, 2, 18, 0, 0, 0, 0)
        Me.dtpRejectionDate.Location = New System.Drawing.Point(344, 36)
        Me.dtpRejectionDate.Name = "dtpRejectionDate"
        Me.dtpRejectionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpRejectionDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpRejectionDate.Size = New System.Drawing.Size(136, 20)
        Me.dtpRejectionDate.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(255, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Rejection Date:"
        '
        'lblFGVal
        '
        Me.lblFGVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFGVal.ForeColor = System.Drawing.Color.Maroon
        Me.lblFGVal.Location = New System.Drawing.Point(324, 13)
        Me.lblFGVal.Name = "lblFGVal"
        Me.lblFGVal.Size = New System.Drawing.Size(369, 16)
        Me.lblFGVal.TabIndex = 24
        Me.lblFGVal.Text = "FG"
        '
        'lblFG
        '
        Me.lblFG.Location = New System.Drawing.Point(255, 13)
        Me.lblFG.Name = "lblFG"
        Me.lblFG.Size = New System.Drawing.Size(74, 16)
        Me.lblFG.TabIndex = 23
        Me.lblFG.Text = "Finish Good:"
        '
        'lblMISDateVal
        '
        Me.lblMISDateVal.Location = New System.Drawing.Point(73, 40)
        Me.lblMISDateVal.Name = "lblMISDateVal"
        Me.lblMISDateVal.Size = New System.Drawing.Size(164, 16)
        Me.lblMISDateVal.TabIndex = 21
        Me.lblMISDateVal.Text = "Date"
        '
        'lblMISDate
        '
        Me.lblMISDate.Location = New System.Drawing.Point(5, 40)
        Me.lblMISDate.Name = "lblMISDate"
        Me.lblMISDate.Size = New System.Drawing.Size(83, 16)
        Me.lblMISDate.TabIndex = 20
        Me.lblMISDate.Text = "MIS Date:"
        '
        'lblMISNo
        '
        Me.lblMISNo.Location = New System.Drawing.Point(5, 13)
        Me.lblMISNo.Name = "lblMISNo"
        Me.lblMISNo.Size = New System.Drawing.Size(65, 16)
        Me.lblMISNo.TabIndex = 19
        Me.lblMISNo.Text = "MIS No:"
        '
        'frmRejectionComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 472)
        Me.Controls.Add(Me.pnlRejectionComponent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRejectionComponent"
        Me.Text = "Rejection Component (MIS)"
        CType(Me.pnlRejectionComponent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRejectionComponent.ResumeLayout(False)
        CType(Me.grpRejectionDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRejectionDetails.ResumeLayout(False)
        CType(Me.grdMatIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMatIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRejectionMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRejectionMaster.ResumeLayout(False)
        CType(Me.txtWorkOrderVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRejectionDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRejectionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRejectionComponent As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpRejectionDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpRejectionMaster As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblMISNo As System.Windows.Forms.Label
    Friend WithEvents lblMISDate As System.Windows.Forms.Label
    Friend WithEvents lblMISDateVal As System.Windows.Forms.Label
    Friend WithEvents lblFGVal As System.Windows.Forms.Label
    Friend WithEvents lblFG As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpRejectionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grdMatIssue As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMatIssue As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbMIS As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblQtyVal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWorkOrderVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
