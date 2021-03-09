Public Class frmExpiredProduct
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdExpired As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvExpired As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grdExpired = New DevExpress.XtraGrid.GridControl()
        Me.gvExpired = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grdExpired)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(921, 362)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "List of Prouct Expired"
        '
        'grdExpired
        '
        Me.grdExpired.Location = New System.Drawing.Point(8, 25)
        Me.grdExpired.MainView = Me.gvExpired
        Me.grdExpired.Name = "grdExpired"
        Me.grdExpired.Size = New System.Drawing.Size(908, 332)
        Me.grdExpired.TabIndex = 3
        Me.grdExpired.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvExpired})
        '
        'gvExpired
        '
        Me.gvExpired.GridControl = Me.grdExpired
        Me.gvExpired.Name = "gvExpired"
        Me.gvExpired.OptionsCustomization.AllowGroup = False
        Me.gvExpired.OptionsCustomization.AllowSort = False
        Me.gvExpired.OptionsView.ShowGroupPanel = False
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(873, 380)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(56, 25)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(8, 380)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(56, 25)
        Me.cmdReport.TabIndex = 6
        Me.cmdReport.Text = "&Report"
        '
        'frmExpiredProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(941, 417)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExpiredProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expired Product"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvExpired, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public strCheck As String
    Dim dt As New DataTable

    Private Sub frmJWReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
   
    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim reportManager As New ReportManager
            stractivetable = "Expired"
            Dim report As IReport = reportManager.GetReportInstance(stractivetable)
            Dim reportService As New ReportService(report)
            reportService.ShowReportParameters()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class

