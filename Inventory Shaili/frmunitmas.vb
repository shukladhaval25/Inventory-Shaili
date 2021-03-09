Public Class frmunitmas
    Inherits System.Windows.Forms.Form
    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

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
    Friend WithEvents cmdcancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtuname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtuid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdesc As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtdesc = New DevExpress.XtraEditors.TextEdit
        Me.txtuname = New DevExpress.XtraEditors.TextEdit
        Me.txtuid = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(400, 184)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 4
        Me.cmdcancel.Text = "&Cancel"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtdesc)
        Me.GroupControl1.Controls.Add(Me.txtuname)
        Me.GroupControl1.Controls.Add(Me.txtuid)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(481, 152)
        Me.GroupControl1.TabIndex = 0
        '
        'txtdesc
        '
        Me.txtdesc.EditValue = ""
        Me.txtdesc.Location = New System.Drawing.Point(120, 104)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(144, 20)
        Me.txtdesc.TabIndex = 2
        '
        'txtuname
        '
        Me.txtuname.EditValue = ""
        Me.txtuname.Location = New System.Drawing.Point(120, 72)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(144, 20)
        Me.txtuname.TabIndex = 1
        '
        'txtuid
        '
        Me.txtuid.EditValue = ""
        Me.txtuid.Location = New System.Drawing.Point(120, 40)
        Me.txtuid.Name = "txtuid"
        Me.txtuid.Size = New System.Drawing.Size(144, 20)
        Me.txtuid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unit ID"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit Description"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unit Name"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(320, 184)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(72, 24)
        Me.cmdsave.TabIndex = 3
        Me.cmdsave.Text = "&Save"
        '
        'frmunitmas
        '
        Me.AcceptButton = Me.cmdsave
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdcancel
        Me.ClientSize = New System.Drawing.Size(544, 230)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cmdsave)
        Me.Name = "frmunitmas"
        Me.Text = "Unit"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmunitmas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox(stractivetable)
        Try
            If strcheck = "Add" Then
                txtuid.Text = GetMaxNo("UnitID", "UnitMaster", "UT", 10)
            End If
            If strcheck = "Edit" Then

                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from unitmaster where unitid = '" & CInt(ModMain.strgridid) & "'"
                MsgBox("select * from unitmaster where unitid = " & CInt(ModMain.strgridid))
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub bind_data()
        MsgBox("in bind data")
        'unitid

        If IsDBNull(dr("UnitID").ToString) = True Then
            txtuid.Text = ""

        Else
            txtuid.Text = dr("UnitID").ToString

        End If

        'unit name
        If IsDBNull(dr("UnitName").ToString) = True Then
            txtuname.Text = ""
        Else
            txtuname.Text = dr("UnitName").ToString
        End If

        'unit desc
        If IsDBNull(dr("UnitDesc").ToString) = True Then
            txtdesc.Text = ""
        Else
            txtdesc.Text = dr("UnitDesc").ToString
        End If
        MsgBox("end binddata")

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand("insert into unitmaster values ( " & txtuid.Text & ", '" & txtuname.Text & "', '" & txtdesc.Text & "')")
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            ElseIf strcheck = "Edit" Then

                cmd = New OleDb.OleDbCommand("update unitmaster set unitname = '" & txtuname.Text & "', unitdesc = '" & txtdesc.Text & "'")
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End If
        cmdsave.Enabled = False
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub
End Class
