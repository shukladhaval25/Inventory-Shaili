Imports System.Data
Module ModMain
    Public show_error As Boolean = True
    Public conn As System.Data.OleDb.OleDbConnection
    Public intcompid As Integer = 1
    Public strgridid As String
    Public stractivetable As String
    Public strUserLevel As String
    Public StrAppName As String = "Shaili Traders"
    Public myLogin As frmLogin
    Public myMain As FrmMain
    Public dsMain As New DataSet
    Public cmd As OleDb.OleDbCommand
    Public strConnString As String
    Public strModule As String
    Public adp As OleDb.OleDbDataAdapter
    Public frmMsG As DevExpress.XtraEditors.XtraMessageBox
    Public dr As OleDb.OleDbDataReader
    Public strGVUserID As String
    Public blnNo As Boolean
    Public dsSub As DataSet
    Public strCY As String
    Sub Main()
        Try
            DbConn()
            myLogin = New frmLogin
            myLogin.ShowDialog()
        Catch ex As Exception
            If show_error = True Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub DbConn()
        Try
            'strConnString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=" & Application.StartupPath & "\Inventory Shaili.mdb ;Jet OLEDB:Engine Type=5;Provider=" & "Microsoft.Jet.OLEDB.4.0" & ";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
            strConnString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "\Inventory Shaili.mdb; Persist Security Info =False"
            ' = New OleDb.OleDbConnection("Provider=MSDASQL.1;Persist Security Info=False;Data Source=MS Access Database;uid=;pwd=;Initial Catalog=" & Application.StartupPath & "\Inventory Shaili.mdb")
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = strConnString
            conn.Open()
        Catch ex As Exception
            If show_error = True Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Function GetMaxNo(ByRef fld As String, ByRef tb As String, ByRef PFix As String, ByVal IntIdLength As Int16, Optional ByVal CurrentYear As String = "") As String
        Dim RtnStr As String
        'Function for getting the max value of the passed field name
        'Parameters : fld= FieldName & tb = TableName, PFix = prefix to be attached to the number.
        '''''openconnection(True)
        Dim CmdMaxNo As OleDb.OleDbCommand
        If stractivetable = "Invoice" Then
            CmdMaxNo = New OleDb.OleDbCommand("select max(" & fld & ") from " & tb & " Where " & fld & " not like  'E%' and CY ='" & CurrentYear.Trim & "'", conn)
        Else
            If CurrentYear.Trim = "" Then
                CmdMaxNo = New OleDb.OleDbCommand("select max(" & fld & ") from " & tb, conn)
            Else
                CmdMaxNo = New OleDb.OleDbCommand("select max(" & fld & ") from " & tb & " where CY = '" & CurrentYear.Trim & "'", conn)
            End If
        End If
        Try
            'If conn.State = ConnectionState.Closed Then conn.Open()
            RtnStr = IIf(IsDBNull(CmdMaxNo.ExecuteScalar), "", CmdMaxNo.ExecuteScalar)
            If RtnStr <> "" Then          'Here it will check for if the value is in the rtnstr or not.
                If stractivetable = "Invoice" AndAlso PFix = "" Then
                    If IsNumeric(RtnStr) = True Then
                        RtnStr = CStr(Val(Right(RtnStr, (Len(RtnStr) - PFix.Length)) + 1))
                    Else
                        If RtnStr.StartsWith("E-") Or RtnStr.StartsWith("e-") Then
                            RtnStr = RtnStr.Substring(0, 2) & Val(RtnStr.Substring(2)) + 1
                        ElseIf RtnStr.StartsWith("E") Or RtnStr.StartsWith("e") Then
                            RtnStr = RtnStr.Substring(0, 1) & Val(RtnStr.Substring(1)) + 1
                        ElseIf RtnStr.StartsWith("U") Or RtnStr.StartsWith("u") Then
                            RtnStr = RtnStr.Substring(0, 1) & Val(RtnStr.Substring(1)) + 1
                        Else
                            RtnStr = CStr(Right(RtnStr.Substring(0, 6), (Len(6) - PFix.Length)) + 1)
                        End If
                    End If
                Else
                    If stractivetable = "FG_Ret" Or stractivetable = "Purchase" Then
                        RtnStr = CStr(Right(RtnStr.Substring(0, IntIdLength), (Len(IntIdLength) - PFix.Length)) + 1)
                    Else
                        RtnStr = CStr(Val(Right(RtnStr, (Len(RtnStr) - PFix.Length)) + 1))
                    End If

                End If
            Else
                RtnStr = "1"
            End If

            RtnStr = RtnStr.PadLeft(IntIdLength - (PFix.Length), "0") 'Right((strPad & RtnStr), IntIdLength - PFix)
            If stractivetable = "Invoice" Then
                GetMaxNo = PFix & RtnStr & "/" & strCY
            Else
                GetMaxNo = PFix & RtnStr
            End If


        Catch ex As Exception
            If show_error = True Then
                MsgBox(ex.ToString())
            End If
        End Try
    End Function
    Public Sub CheckNumber(ByRef keyascii As Integer)
        If (keyascii >= 48 And keyascii <= 57) Or keyascii = 8 Then
        Else
            keyascii = 0
        End If
    End Sub
    Public Function IsPhoneNumber(ByVal chKey As Char) As Boolean
        If (Asc(chKey) >= 48 And Asc(chKey) <= 57) OrElse Asc(chKey) = Asc("(") OrElse Asc(chKey) = Asc(")") OrElse Asc(chKey) = Asc("-") OrElse Asc(chKey) = 8 OrElse Asc(chKey) = 32 Then
            IsPhoneNumber = False
        Else
            IsPhoneNumber = True
        End If
    End Function
    Public Function IsNumber(ByVal chKey As Char) As Boolean
        If (Asc(chKey) >= 48 And Asc(chKey) <= 57) OrElse Asc(chKey) = 8 OrElse Asc(chKey) = 32 Then
            IsNumber = False
        Else
            IsNumber = True
        End If

    End Function


    Public Sub FillCombox(ByVal strtable As String, ByVal strfield As String, ByRef cboname As DevExpress.XtraEditors.ComboBoxEdit)
        Try

            cboname.Properties.Items.Clear()
            Dim cmd1 As OleDb.OleDbCommand
            cmd1 = New OleDb.OleDbCommand
            cmd1.Connection = conn
            cmd1.CommandText = "select " & strfield & "  from " & strtable
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = cmd1.ExecuteReader
            Do While dr1.Read()
                cboname.Properties.Items.Add(dr1(0).ToString)
            Loop
            dr1.Close()
            cmd1.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally

        End Try
    End Sub

    Public Function Fillcmb(ByVal Strquery As String, ByVal strtable As String, ByVal strID As String, ByVal strName As String, ByRef cmbName As ComboBox, Optional ByVal strSql As String = "")
        Dim dsCmb As New DataSet
        'Dim adp As OleDb.OleDbDataAdapter
        Try
            'adp = New OleDb.OleDbDataAdapter(Strquery, conn)
            'adp = New OleDb.OleDbDataAdapter("select " & strID & "," & strName & " from " & strtable, conn)
            adp = New OleDb.OleDbDataAdapter
            adp.SelectCommand = New OleDb.OleDbCommand
            adp.SelectCommand.Connection = conn
            adp.SelectCommand.CommandText = Strquery
            adp.Fill(dsCmb, strtable)

            If strSql <> "" Then
                adp.SelectCommand.CommandText = strSql
                adp.Fill(dsCmb, strtable)
            End If

            cmbName.DisplayMember = strName
            cmbName.ValueMember = strID
            cmbName.DataSource = dsCmb.Tables(strtable)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString())
            End If
        Finally

        End Try
    End Function
    Public Sub FillLookup(ByVal Strquery As String, ByVal strtable As String, ByVal strID As String, ByVal strName As String, ByRef lkupObj As DevExpress.XtraEditors.LookUpEdit, Optional ByVal strFld As String = "", Optional ByVal strsql As String = "")
        Try
            Dim ds As New DataSet
            'Dim adp As New OleDb.OleDbDataAdapter(Strquery, conn.ConnectionString)
            'adp.Fill(ds, strtable)
            adp = New OleDb.OleDbDataAdapter
            adp.SelectCommand = New OleDb.OleDbCommand
            adp.SelectCommand.Connection = conn
            adp.SelectCommand.CommandText = Strquery
            adp.Fill(ds, strtable)


            If strsql <> "" Then
                adp.SelectCommand.CommandText = strsql
                adp.Fill(ds, strtable)
            End If

            lkupObj.Properties.Columns.Clear()

            lkupObj.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(ds.Tables(0).Columns(0).ToString))
            lkupObj.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(ds.Tables(0).Columns(1).ToString))
            If strFld <> "" Then
                lkupObj.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(ds.Tables(0).Columns(1).ToString))
            End If

            lkupObj.Properties.DataSource = ds.Tables(0)
            lkupObj.Properties.DisplayMember = ds.Tables(0).Columns(0).ToString
            If strFld = "" Then
                lkupObj.Properties.ValueMember = ds.Tables(0).Columns(1).ToString
            Else
                lkupObj.Properties.ValueMember = ds.Tables(0).Columns(2).ToString
            End If
            lkupObj.Properties.Columns(0).Caption = strID
            lkupObj.Properties.Columns(1).Caption = strName
            lkupObj.Properties.Columns(ds.Tables(0).Columns(1).ToString).Visible = False
            lkupObj.Properties.GetDataSourceRowByDisplayValue(lkupObj.EditValue)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub FillList(ByVal Strquery As String, ByVal strtable As String, ByVal strID As String, ByVal strName As String, ByRef lstobj As ListView, Optional ByVal strFld As String = "", Optional ByVal strsql As String = "")
        Dim adp As OleDb.OleDbDataAdapter
        Try
            Dim ds As New DataSet
            adp = New OleDb.OleDbDataAdapter
            adp.SelectCommand = New OleDb.OleDbCommand
            adp.SelectCommand.Connection = conn
            adp.SelectCommand.CommandText = Strquery
            '(Strquery, conn.ConnectionString)
            adp.Fill(ds, strtable)

            If strsql <> "" Then
                adp.SelectCommand.CommandText = strsql
                adp.Fill(ds, strtable)
            End If
            lstobj.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                lstobj.Items.Add(ds.Tables(0).Rows(i).Item(0))
                lstobj.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item(1))
            Next

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Function FillGrid(ByVal StrQuery As String, ByVal tlbName As String, Optional ByVal Arrhide As ArrayList = Nothing) As DataSet
        Dim ds As New DataSet
        Try
            dsMain.Clear()
            adp = New OleDb.OleDbDataAdapter
            adp.SelectCommand = New OleDb.OleDbCommand
            adp.SelectCommand.Connection = conn
            adp.SelectCommand.CommandText = StrQuery
            adp.Fill(ds, tlbName)
            Return ds
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString())
            End If
        Finally
            ds.Dispose()
        End Try
    End Function
    Public Function IsDuplicate(ByVal strSQL As String) As Boolean
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = strSQL

            If cmd.ExecuteScalar >= 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Function



    Public Function IsDecimalNumber(ByVal chKey As Char) As Boolean
        If (Asc(chKey) >= 48 And Asc(chKey) <= 57) OrElse Asc(chKey) = 46 OrElse Asc(chKey) = 8 Then
            IsDecimalNumber = False
        Else
            IsDecimalNumber = True
        End If

    End Function

    Public Function IsOnlyNumber(ByVal chKey As Char) As Boolean
        If (Asc(chKey) >= 48 And Asc(chKey) <= 57) OrElse Asc(chKey) = 8 Then
            IsOnlyNumber = False
        Else
            IsOnlyNumber = True
        End If

    End Function
End Module
