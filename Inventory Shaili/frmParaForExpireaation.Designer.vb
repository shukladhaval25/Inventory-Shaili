<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParaForExpireaation
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.spnDays = New DevExpress.XtraEditors.SpinEdit()
        Me.lblDays = New DevExpress.XtraEditors.LabelControl()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.spnDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Location = New System.Drawing.Point(13, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(151, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Finish Good gets expire in "
        '
        'spnDays
        '
        Me.spnDays.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnDays.Location = New System.Drawing.Point(171, 23)
        Me.spnDays.Name = "spnDays"
        Me.spnDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnDays.Size = New System.Drawing.Size(58, 20)
        Me.spnDays.TabIndex = 1
        '
        'lblDays
        '
        Me.lblDays.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Appearance.Options.UseFont = True
        Me.lblDays.Location = New System.Drawing.Point(235, 23)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(37, 16)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "(Days)"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(284, 20)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        '
        'frmParaForExpireaation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 62)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.spnDays)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParaForExpireaation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expiration Parameter"
        CType(Me.spnDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spnDays As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblDays As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
End Class
