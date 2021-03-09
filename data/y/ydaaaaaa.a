Imports System.Data.OleDb

Module Module1
    'Public show_error As Boolean = True
    'Public conn As OleDb.OleDbConnection
    'Public intcompid As Integer = 1
    'Public strgridid As String
    'Public stractivetable As String



    Public Sub dbconn()
        'Try
        '    conn = New ADODB.Connection
        '    conn.Open("Provider=MSDASQL.1;Persist Security Info=False;Data Source=MS Access Database;uid=;pwd=;Initial Catalog=" & Application.StartupPath & "\Inventory.mdb")
        'Catch ex As Exception
        '    If show_error = True Then
        '        MsgBox(ex.ToString)
        '    End If
        'End Try
    End Sub
    'Public Function Getmaxno(ByVal strtablename As String, ByVal strfieldname As String) As Int16
    '    Try
    '        Dim rstemp As New ADODB.Recordset
    '        rstemp.Open("select max(" & strfieldname & ") from " & strtablename, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
    '        If rstemp.Fields(0).Value > 0 Then
    '            Return rstemp.Fields(0).Value + 1
    '        Else
    '            Return 1
    '        End If
    '        rstemp.Close()
    '    Catch ex As Exception
    '        If show_error = True Then
    '            MsgBox(ex.ToString())

    '        End If
    '    End Try

    'End Function
    'Sub main()
    '    Try
    '        dbconn()
    '        Dim mdiobj As New frmMDI
    '        mdiobj.ShowDialog()

    '    Catch ex As Exception
    '        If show_error = True Then
    '            MsgBox(ex.ToString)
    '        End If
    '    End Try
    'End Sub
    

    'Public Sub fillcombox(ByVal strtable As String, ByVal strfield As String, ByRef cboname As DevExpress.XtraEditors.ComboBoxEdit)
    '    Try
    '        Dim rsfill As New ADODB.Recordset
    '        cboname.Properties.Items.Clear()
    '        rsfill.Open("select (" & strfield & " ) from " & strtable, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
    '        Do While rsfill.EOF <> True
    '            cboname.Properties.Items.Add(rsfill.Fields(0).Value)
    '            rsfill.MoveNext()
    '        Loop
    '        rsfill.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '    End Try
    'End Sub
    Public Sub griddata(ByVal tablename As String, ByRef gridname As DevExpress.XtraGrid.GridControl)
        Dim dv As New DataView
        Dim ds As DataSet = New DataSet
        Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "\INVENTORY.mdb")
        If DBFileName <> "" Then
            Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName
          
            Dim oleDBAdapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM " & tablename, con)
            'MsgBox("SELECT * FROM " & tablename)
            ds.Clear()
            oleDBAdapter1.Fill(ds, tablename)

            Dim dvManager As DataViewManager = New DataViewManager(ds)

            'MsgBox("dv")
            dv = dvManager.CreateDataView(ds.Tables(tablename))
            'MsgBox(tablename)
            gridname.DataSource = dv
            gridname.Refresh()
        End If
    End Sub
    Public Sub backcolour(ByRef buttonname As DevExpress.XtraEditors.SimpleButton)
        buttonname.BackColor = Color.Yellow
    End Sub
   
End Module
