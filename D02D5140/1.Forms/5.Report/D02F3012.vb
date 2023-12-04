Imports System.Collections
Public Class D02F3012
	Dim report As D99C2003

    Private dtObjectID As DataTable
    Dim dtPeriod As DataTable
    Dim oFilterCheck As Lemon3.Controls.FilterCheckCombo

    Private Sub D02F3012_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If
    End Sub
    
    Private Sub D02F3012_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	LoadInfoGeneral()
        Me.Cursor = Cursors.WaitCursor
        Loadlanguage()
        InputbyUnicode(Me, gbUnicode)
        SetBackColorObligatory()
        'ID 79323 10/9/2015
        oFilterCheck = New Lemon3.Controls.FilterCheckCombo
        'oFilterCheck.Separator= ";" 'Mặc định hiển thị trên combo là ;. Chỉ truyền biến này khi phân cách các giá trị là ký tự khác ; trên combo
        oFilterCheck.UseFilterCheckCombo(tdbcDivisionID)
        LoadTDBCombo()
        LoadDefault()
        SetResolutionForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadDefault()
        txtReportTypeID.Text = "D02R3012"
        If gbUnicode Then
            txtReportTypeName.Text = rl3("A4_L_Bao_cao_tang_giam_TSCDU")
        Else
            txtReportTypeName.Text = rl3("A4_L_Bao_cao_tang_giam_TSCD")
        End If


        'tdbcDivisionID.Text = gsDivisionID
        'ID 79323 10/9/2015
        oFilterCheck.SetValue(tdbcDivisionID, gsDivisionID) 'Không dùng tdbcxxx.SelectedValue=.Item("xxxx").ToString

        If tdbcDivisionID.Text <> "" Then
            LoadCboPeriodReportForDivisions(dtPeriod, oFilterCheck.GetValueServer(tdbcDivisionID), tdbcFromPeriodID, tdbcToPeriodID)
        Else
            'tdbcObjectTypeID.Text = "%"
            tdbcFromPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
            tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        End If

        tdbcObjectTypeID.Text = "%"
        'tdbcFromPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        'tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_tang_giam_TSCD_-_D02F3012") & UnicodeCaption(gbUnicode) 'BÀo cÀo tŸng gi¶m TSC˜ - D02F3012
        '================================================================ 
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù

        lblDivisionID.Text = rl3("Don_vi") 'Đơn vị
        lblObjectTypeID.Text = rl3("Loai_doi_tuong") 'Loại đối tượng
        lblFromObjectID.Text = rl3("Doi_tuong") 'Đối tượng
        lblFromPeriodID.Text = rl3("Ky") 'Kỳ
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnDefineData.Text = rl3("Dinh_nghia__du_lieu") 'Định nghĩa &dữ liệu
        '================================================================ 
        GroupBox1.Text = rl3("Dang_bao_cao") 'Dạng báo cáo
        GroupBox2.Text = rl3("Dieu_kien_loc") 'Điều kiện lọc
        '================================================================ 
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcToPeriodID.Columns("Period").Caption = rl3("Ky") 'Kỳ

        tdbcFromPeriodID.Columns("Period").Caption = rl3("Ky") 'Kỳ

        tdbcToObjectID.Columns("ObjectID").Caption = rl3("Ma") 'Mã 
        tdbcToObjectID.Columns("ObjectName").Caption = rl3("Ten") 'Tên 

        tdbcFromObjectID.Columns("ObjectID").Caption = rl3("Ma") 'Mã 
        tdbcFromObjectID.Columns("ObjectName").Caption = rl3("Ten") 'Tên 

        tdbcObjectTypeID.Columns("ObjectTypeID").Caption = rl3("Ma") 'Mã
        tdbcObjectTypeID.Columns("ObjectTypeName").Caption = rl3("Ten") 'Tên

        tdbcDivisionID.Columns("DivisionID").Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns("DivisionName").Caption = rl3("Ten") 'Tên


    End Sub

    Private Sub SetBackColorObligatory()
        txtReportTypeID.BackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcDivisionID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcObjectTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromObjectID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToObjectID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQL As String = ""
        'Load tdbcReportID
        sSQL = "Select A.ReportID, A.Title" & UnicodeJoin(gbUnicode) & " as Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & UnicodeJoin(gbUnicode) & " as ReportTypeName " & vbCrLf
        sSQL &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQL &= "Where A.ModuleID = '02' And A.ReportTypeID = 'D02F3012'" & vbCrLf
        sSQL &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQL &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQL &= "Order By	A.ReportTypeID" & vbCrLf
        LoadDataSource(tdbcReportID, sSQL, gbUnicode)

        'Load tdbcPeriod
        dtPeriod = LoadTablePeriodReport(D02)

        'Load tdbcDivisionID
        LoadCboDivisionIDReport(tdbcDivisionID, D02, , gbUnicode)

        'Load tdbcObjectTypeID
        Dim sSQl2 As String = ""
        sSQl2 = "Select 0 as DisplayOrder, '%' ObjectTypeID ," & AllName & " as ObjectTypeName  " & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl2 &= "'<Taát caû>' As ObjectTypeName" & vbCrLf
        'Else
        '    sSQl2 &= "'<All>' As ObjectTypeName" & vbCrLf
        'End If
        sSQl2 &= "Union" & vbCrLf
        sSQl2 &= "Select 1 as DisplayOrder, ObjectTypeID, " & vbCrLf

        If gsLanguage = "84" Then
            sSQl2 &= "ObjectTypeName" & UnicodeJoin(gbUnicode) & "  As ObjectTypeName" & vbCrLf
        Else
            sSQl2 &= "ObjectTypeName01" & UnicodeJoin(gbUnicode) & " As ObjectTypeName" & vbCrLf
        End If
        sSQl2 &= "From D91T0005   WITH (NOLOCK) " & vbCrLf
        sSQl2 &= "Order By DisplayOrder, ObjectTypeID" & vbCrLf
        LoadDataSource(tdbcObjectTypeID, sSQl2, gbUnicode)

        'Load tdbcFromObjectID
        Dim sSQl3 As String = "'"
        sSQl3 = "Select 0 as DisplayOrder,'%' As ObjectID," & AllName & " as ObjectName,  " & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl3 &= " '<Taát caû>' As ObjectName," & vbCrLf
        'Else
        '    sSQl3 &= " '<All>' As ObjectName," & vbCrLf
        'End If
        sSQl3 &= "'%' As ObjectTypeID " & vbCrLf
        sSQl3 &= "Union" & vbCrLf
        sSQl3 &= "Select 1 as DisplayOrder, ObjectID,  ObjectName" & UnicodeJoin(gbUnicode) & ", ObjectTypeID " & vbCrLf
        sSQl3 &= "	From Object  WITH (NOLOCK)  WHERE ObjectTypeID like '%' " & vbCrLf
        sSQl3 &= "Order By DisplayOrder,ObjectID" & vbCrLf
        dtObjectID = ReturnDataTable(sSQl3)
    End Sub

    Private Sub LoadtdbcObjectID(ByVal ID As String)
        LoadDataSource(tdbcFromObjectID, ReturnTableFilter(dtObjectID, "  ObjectTypeID like " & SQLString(ID) & " Or ObjectTypeID = '%'", True), gbUnicode) '
        LoadDataSource(tdbcToObjectID, ReturnTableFilter(dtObjectID, "  ObjectTypeID like " & SQLString(ID) & " Or ObjectTypeID = '%'", True), gbUnicode) '
        tdbcFromObjectID.AutoSelect = True
        tdbcToObjectID.AutoSelect = True
    End Sub

#Region "Events tdbcReportID with txtTitle"

    Private Sub tdbcReportID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.Close
        If tdbcReportID.FindStringExact(tdbcReportID.Text) = -1 Then
            tdbcReportID.Text = ""
            txtTitle.Text = ""
        End If
    End Sub

    Private Sub tdbcReportID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.SelectedValueChanged
        txtTitle.Text = tdbcReportID.Columns(1).Value.ToString
    End Sub

    'Private Sub tdbcReportID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcReportID.Text = ""
    '        txtTitle.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcDivisionID with txtDivisionName"

    Private Sub tdbcDivisionID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.Close
        'If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 Then
        '    tdbcDivisionID.Text = ""
        '    txtDivisionName.Text = ""
        'End If
    End Sub

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        'txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
        'LoadCboPeriodReportForDivisions(tdbcFromPeriodID, tdbcToPeriodID, dtPeriod, oFilterCheck.GetValueServer(tdbcDivisionID))


    End Sub

    'Private Sub tdbcDivisionID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcDivisionID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcDivisionID.Text = ""
    '        txtDivisionName.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcObjectTypeID with txtObjectTypeName"

    Private Sub tdbcObjectTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcObjectTypeID.Close
        If tdbcObjectTypeID.FindStringExact(tdbcObjectTypeID.Text) = -1 Then
            tdbcObjectTypeID.Text = ""
            txtObjectTypeName.Text = ""
        End If
    End Sub

    Private Sub tdbcObjectTypeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcObjectTypeID.SelectedValueChanged
        txtObjectTypeName.Text = tdbcObjectTypeID.Columns(1).Value.ToString
        LoadtdbcObjectID(tdbcObjectTypeID.Text)
    End Sub

    'Private Sub tdbcObjectTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcObjectTypeID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcObjectTypeID.Text = ""
    '        txtObjectTypeName.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcFromObjectID"

 

    Private Sub tdbcFromObjectID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromObjectID.Close
        If tdbcFromObjectID.FindStringExact(tdbcFromObjectID.Text) = -1 Then tdbcFromObjectID.Text = ""
    End Sub

    'Private Sub tdbcFromObjectID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromObjectID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromObjectID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcToObjectID"

    Private Sub tdbcToObjectID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToObjectID.Close
        If tdbcToObjectID.FindStringExact(tdbcToObjectID.Text) = -1 Then tdbcToObjectID.Text = ""
    End Sub

    'Private Sub tdbcToObjectID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToObjectID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToObjectID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcFromPeriodID"

    Private Sub tdbcFromPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromPeriodID.Close
        If tdbcFromPeriodID.FindStringExact(tdbcFromPeriodID.Text) = -1 Then tdbcFromPeriodID.Text = ""
    End Sub

    'Private Sub tdbcFromPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromPeriodID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromPeriodID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcToPeriodID"

    Private Sub tdbcToPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.Close
        If tdbcToPeriodID.FindStringExact(tdbcToPeriodID.Text) = -1 Then tdbcToPeriodID.Text = ""
    End Sub

    'Private Sub tdbcToPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToPeriodID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToPeriodID.Text = ""
    'End Sub

#End Region

    Private Sub tdbcFromObjectID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromObjectID.LostFocus
        If tdbcFromObjectID.Text = "%" Then
            tdbcToObjectID.Enabled = False
        Else
            tdbcToObjectID.Enabled = True
            SetValueTo(tdbcFromObjectID, tdbcToObjectID)
        End If
    End Sub

    Private Sub tdbcFromObjectID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromObjectID.SelectedValueChanged
        If tdbcFromObjectID.Text = "%" Then
            tdbcToObjectID.Enabled = False
        Else
            tdbcToObjectID.Enabled = True

        End If
    End Sub

    Private Function AllowPrint() As Boolean
        If txtReportTypeID.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rl3("Mau_chuan"))
            txtReportTypeID.Focus()
            Return False
        End If
        If tdbcDivisionID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Don_vi"))
            tdbcDivisionID.Focus()
            Return False
        End If
        If tdbcObjectTypeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Loai_doi_tuong"))
            tdbcObjectTypeID.Focus()
            Return False
        End If
        If tdbcFromObjectID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Doi_tuong"))
            tdbcFromObjectID.Focus()
            Return False
        End If
        If tdbcToObjectID.Text.Trim = "" And tdbcFromObjectID.Text.Trim <> "%" Then
            D99C0008.MsgNotYetChoose(rl3("Doi_tuong"))
            tdbcToObjectID.Focus()
            Return False
        End If
        If tdbcFromPeriodID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Ky"))
            tdbcFromPeriodID.Focus()
            Return False
        End If
        If tdbcToPeriodID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Ky"))
            tdbcToPeriodID.Focus()
            Return False
        End If
        If Not CheckValidPeriodFromTo(tdbcFromPeriodID, tdbcToPeriodID) Then Return False
        'If CInt(tdbcFromPeriodID.Columns("TranYear").Value.ToString) > CInt(tdbcToPeriodID.Columns("TranYear").Value.ToString) Then
        '    D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
        '    tdbcFromPeriodID.Focus()
        '    Return False
        'ElseIf CInt(tdbcFromPeriodID.Columns("TranYear").Value.ToString) = CInt(tdbcToPeriodID.Columns("TranYear").Value.ToString) Then
        '    If CInt(tdbcFromPeriodID.Columns("TranMonth").Value.ToString) > CInt(tdbcToPeriodID.Columns("TranMonth").Value.ToString) Then
        '        D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
        '        tdbcFromPeriodID.Focus()
        '        Return False
        '    End If

        'End If
        Return True
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3012
    '# Created User: Mỹ Vân
    '# Created Date: 12/02/2008 03:17:25
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3012() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P3012 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(oFilterCheck.GetValueServer(tdbcDivisionID)) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranMonth").Text) & COMMA 'FromMonth, int, NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranYear").Text) & COMMA 'FromYear, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranMonth").Text) & COMMA 'ToMonth, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranYear").Text) & COMMA 'ToYear, int, NOT NULL

        sSQL &= SQLNumber(gsLanguage) & COMMA 'Language, tinyint, NOT NULL
        sSQL &= SQLString(tdbcObjectTypeID.Text) & COMMA 'ObjectTypeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcFromObjectID.Text) & COMMA 'FromObjectID, varchar[20], NOT NULL
        If tdbcToObjectID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'ToObjectID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcToObjectID.Text) & COMMA  'ToObjectID, varchar[20], NOT NULL
        End If
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, tinyint, NOT NULL
        If tdbcReportID.Text <> "" Then
            sSQL &= SQLString(txtReportTypeID.Text)
        Else
            sSQL &= SQLString(txtReportTypeID.Text)
        End If
        Return sSQL
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not AllowPrint() Then Exit Sub
        PrintData()
        'If giAppMode = 0 Then
        '    PrintData()
        'Else
        '    PrintDataWS()
        'End If
    End Sub

    Private Sub PrintData()
        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'Dim report As New D99C1003
        'Đưa vể đầu tiên hàm In trước khi gọi AllowPrint()
		If Not AllowNewD99C2003(report, Me) Then Exit Sub
		'************************************
        Dim conn As New SqlConnection(gsConnectionString)
        Dim sReportName As String = ""
        Dim sSubReportName As String = "D91R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""

        sSQL = "Select * from D02T3012  WITH (NOLOCK) where UserID=" & SQLString(gsUserID)
        ExecuteSQL(SQLStoreD02P3012)
        If tdbcReportID.Text <> "" Then
            sReportName = ReturnValueC1Combo(tdbcReportID)
        Else
            sReportName = txtReportTypeID.Text
        End If

        'If D02Options.ReportLanguage = 0 Then
        '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
        'ElseIf D02Options.ReportLanguage = 1 Then
        '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
        'ElseIf D02Options.ReportLanguage = 2 Then
        '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
        'End If
        sReportCaption = rl3("Bao_cao_tang_giam_TSCDf") & " - " & sReportName
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, ReturnValueC1Combo(tdbcReportID)) & sReportName & ".rpt"
        'sSQLSub = "Select *" & vbCrLf
        'sSQLSub &= " FROM D91V0016 " & vbCrLf
        'sSQLSub &= " WHERE   DivisionID = " & SQLString(oFilterCheck.GetValueTDBCDivision(tdbcDivisionID))

        'Gán giá trị cho sSubReportName và sSQLSub
        UnicodeSubReport(sSubReportName, sSQLSub, oFilterCheck.GetValueTDBCDivision(tdbcDivisionID), gbUnicode)

        With report
            .OpenConnection(conn)
            '.AddParameter("?????", "?????")
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(sSQL)
            .PrintReport(sPathReport, sReportCaption)
        End With
        '   Else
        'sReportName = tdbcReportID.Text
        'sReportCaption = rl3("Bao_cao_tang_giam_TSCDf") & " - " & sReportName
        'sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"
        'With report
        '    .OpenConnection(conn)
        '    '.AddParameter("?????", "?????")
        '    .AddSub(sSQLSub, sSubReportName & ".rpt")
        '    .AddMain(sSQL)
        '    .PrintReport(sPathReport, sReportCaption)
        ' End With
        ' End If
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
    End Sub

    'Private Sub PrintDataWS()
    '    btnPrint.Enabled = False
    '    Me.Cursor = Cursors.WaitCursor
    '    bPrintUnicode = gbUnicode And Not chkIsPrintVNI.Checked
    '    Dim reportWS As New D99C0009
    '    CallWebService.Url = gsAppServer & "D91W0000.asmx"
    '    CallWebService.Timeout = nWSTimeOut


    '    Dim sReportName As String = ""
    '    Dim sSubReportName As String = "D02R0000"
    '    Dim sReportCaption As String = ""
    '    Dim sPathReport As String = ""
    '    Dim sSQL As String = ""
    '    Dim sSQLSub As String = ""

    '    sSQL = "Select * from D02T3012  WITH (NOLOCK) where UserID=" & SQLString(gsUserID)
    '    sSQLSub = "Select *" & vbCrLf
    '    sSQLSub &= " FROM D91V0016 " & vbCrLf
    '    sSQLSub &= " WHERE   DivisionID = " & SQLString(IIf(gsDivisionID = "", "%", gsDivisionID).ToString)
    '    ExecuteSQL(SQLStoreD02P3012)

    '    If tdbcReportID.Text <> "" Then
    '        sReportName = txtReportTypeID.Text
    '    Else
    '        sReportName = txtReportTypeID.Text
    '    End If

    '    'If D02Options.ReportLanguage = 0 Then
    '    '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
    '    'ElseIf D02Options.ReportLanguage = 1 Then
    '    '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
    '    'ElseIf D02Options.ReportLanguage = 2 Then
    '    '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
    '    'End If
    '    sReportCaption = rL3("Bao_cao_tang_giam_TSCDf") & " - " & sReportName & UnicodeCaption(gbUnicode)
    '    sPathReport = UnicodeGetReportPath(bPrintUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
    '    'UnicodeSubReport(sSubReportName, sSQLSub, IIf(gsDivisionID = "", "%", gsDivisionID).ToString, gbUnicode)

    '    'If tdbcReportID.Text = "" Then
    '    '    sReportName = txtReportTypeID.Text
    '    '    sReportCaption = rl3("Bao_cao_tang_giam_TSCDf") & " - " & sReportName
    '    '    With reportWS
    '    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '    '        .AddMain(sSQL)
    '    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    '    End With
    '    'Else
    '    ' sReportName = tdbcReportID.Text
    '    'sReportCaption = rl3("Bao_cao_tang_giam_TSCDf") & " - " & sReportName
    '    With reportWS
    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '        .AddMain(sSQL)
    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    End With
    '    ' End If

    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

    'Private Sub tdbcFromPeriodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromPeriodID.SelectedValueChanged
    '    tdbcToPeriodID.Text = tdbcFromPeriodID.Text
    'End Sub
    Private Sub tdbcDivisionID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.Validated, tdbcObjectTypeID.Validated, tdbcFromObjectID.Validated, tdbcToObjectID.Validated
        'Dim tdbc As C1.Win.C1List.C1Combo = CType(sender, C1.Win.C1List.C1Combo)
        'tdbc.Text = tdbc.WillChangeToText

        'ID 79323 10/9/2015
        oFilterCheck.FilterCheckCombo(tdbcDivisionID, e)
        LoadCboPeriodReportForDivisions(dtPeriod, oFilterCheck.GetValueServer(tdbcDivisionID), tdbcFromPeriodID, tdbcToPeriodID)
    End Sub

    Private Sub btnDifidentData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefineData.Click
        'Dim frm As New D89F9300
        'With frm
        '    .FormName = "D89F9300"
        '    .FormStatus = EnumFormState.FormEdit
        '    .FormPermission = "D02F3012" 'Màn hình phân quyền
        '    .Key01ID = "D02F3012" 'Tên Form cha
        '    .Key02ID = txtReportTypeID.Text 'Mã báo cáo
        '    .Key03ID = txtReportTypeName.Text 'Tiêu đề báo cáo
        '    .Key04ID = "02"
        '    .Key05ID = ""
        '    .ShowDialog()
        '    .Dispose()
        'End With

        Dim arrPro() As StructureProperties = Nothing
        SetProperties(arrPro, "FormIDPermission", "D02F3012")
        SetProperties(arrPro, "LoadStatus", EnumFormState.FormEdit)
        SetProperties(arrPro, "FormID", "D02F3012")
        SetProperties(arrPro, "ReportID", txtReportTypeID.Text)
        SetProperties(arrPro, "Title", txtReportTypeName.Text)
        SetProperties(arrPro, "Mode", "02")
        CallFormShow(Me, "D89D0240", "D89F9300", arrPro)
    End Sub



End Class