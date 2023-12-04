Public Class D02F3040
	Dim report As D99C2003

    Dim dtACodeID As DataTable
    'Dim stam As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub D02F3040_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If
    End Sub

    Private Sub D02F3040_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	LoadInfoGeneral()
        Loadlanguage()

        c1dateFrom.Value = Date.Today
        c1dateTo.Value = Date.Today
        Hidden_optNgay()
        SetBackColorObligatory()
        InputbyUnicode(Me, gbUnicode)
        LoadTDBCombo()
        LoadDefault()
        SetResolutionForm(Me)
    End Sub
    'Them ngay 3/8/2012 theo incident 50294 cua PHUONGTHAO boi VANVINH
    Private Sub Hidden_optNgay()
        Dim IsChangeOBByDate As Integer = 0
        Dim sSQL As String = "select IsChangeOBByDate from D02T0000 WITH (NOLOCK) "
        Dim dt_isDate As DataTable = ReturnDataTable(sSQL)
        If dt_isDate.Rows.Count > 0 Then
            IsChangeOBByDate = L3Int(dt_isDate.Rows(0).Item("IsChangeOBByDate").ToString)
        End If
        If IsChangeOBByDate = 0 Then
            optDate.Visible = False
            c1dateFrom.Visible = False
            c1dateTo.Visible = False
            Label1.Visible = False
            optPeriod.Visible = False
            lblFromPeriodID.Visible = True
        Else
            optDate.Visible = True
            c1dateFrom.Visible = True
            c1dateTo.Visible = True
            Label1.Visible = True
            optPeriod.Visible = True
            lblFromPeriodID.Visible = False
        End If
    End Sub

    Dim bLoadtdbcAssetID As Boolean = False
    Private Sub LoadDefault()
        tdbcFromPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        bLoadtdbcAssetID = True
        tdbcGroupTypeID.SelectedIndex = 0
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_TSCD_di_chuyen_noi_bo_-__D02F3040") & UnicodeCaption(gbUnicode) 'BÀo cÀo TSC˜ di chuyÓn nèi bè -  D02F3040
        '================================================================ 
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù

        lblGroupTypeID.Text = rl3("Phan_loai") 'Phân loại
        lblFromPeriodID.Text = rl3("Ky") 'Kỳ
        lblFromAssetID.Text = rl3("Tai_san") 'Tài sản
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnFilter.Text = rl3("_Loc") '&Lọc
        '================================================================ 
        GroupBox1.Text = "1. " & rl3("Dang_bao_cao") 'Dạng báo cáo
        GroupBox2.Text = "2. " & rl3("Dieu_kien_loc") 'Điều kiện lọc
        GroupBox3.Text = "3. " & rl3("Thoi_gian") 'Thời gian
        optPeriod.Text = rl3("Ky") 'Kỳ
        optDate.Text = rl3("Ngay")
        '================================================================ 
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên

        tdbcReportTypeID.Columns("ReportTypeID").Caption = rl3("Ma") 'Mã 
        tdbcReportTypeID.Columns("ReportTypeName").Caption = rl3("Ten") 'Tên
        tdbcToAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcToAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcFromAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFromAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên

        tdbcACodeID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACodeID.Columns("Description").Caption = rl3("Ten") 'Tên

        tdbcGroupTypeID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupTypeID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACodeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQl As String = ""
        Dim sUnicode As String = UnicodeJoin(gbUnicode)
        'Load tdbcReportTypeID
        sSQl = "Select ReportID As ReportTypeID, " & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl &= "Description   As " & vbCrLf
        'Else
        '    sSQl &= "Description01   As " & vbCrLf
        'End If
        sSQl &= "Description" & IIf(geLanguage = EnumLanguage.English, "01", "").ToString & sUnicode & " As ReportTypeName, StrSQL, ReportType " & vbCrLf
        sSQl &= "From D02V5555 " & vbCrLf
        sSQl &= "Where ReportType = 'D02F3040'" & vbCrLf
        sSQl &= "Order By ReportTypeID" & vbCrLf
        LoadDataSource(tdbcReportTypeID, sSQl, gbUnicode)

        'Load tdbcReportID
        sSQl = "Select A.ReportID, A.Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & sUnicode & " as ReportTypeName " & vbCrLf
        sSQl &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQL &= "Where A.ModuleID = '02' And (A.ReportTypeID = 'D02F3040A'" & vbCrLf
        sSQL &= "Or A.ReportTypeID = 'D02F3040B')" & vbCrLf
        sSQL &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQL &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQL &= "Order By	A.ReportTypeID" & vbCrLf
        LoadDataSource(tdbcReportID, sSQl, gbUnicode)

        'Load ACodeID
        Dim sSQl1 As String = ""
        sSQl1 = "	Select 	0 as DisplayOrder,'%' As ACodeID, " & AllName & " as Description,'%' As TypeCodeID" & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQl1 &= "'<Taát caû>' as Description," & vbCrLf
        'Else
        '    sSQl1 &= "'<All>'  as Description," & vbCrLf
        'End If
        sSQl1 &= "Union All" & vbCrLf
        sSQl1 &= "Select 1 as DisplayOrder,ACodeID, Description" & sUnicode & " as Description, TypeCodeID As GroupTypeID" & vbCrLf
        sSQl1 &= "From D02V4444  " & vbCrLf
        sSQl1 &= "Order By DisplayOrder, ACodeID" & vbCrLf
        dtACodeID = ReturnDataTable(sSQl1)
        LoadDataSource(tdbcACodeID, dtACodeID, gbUnicode)

        'Load tdbcGroupTypeID
        sSQl = "Select GroupTypeID, "
        If gsLanguage = "84" Then
            sSQl &= "VieTypeCaption"
        Else
            sSQl &= " EngTypeCaption"
        End If
        sSQl &= sUnicode & "  As GroupCaption,TableName, WhereClause "
        sSQL &= "From D02V3333 "
        sSQl &= "Order By GroupTypeID "
        LoadDataSource(tdbcGroupTypeID, sSQl, gbUnicode)

        'Load PeriodID
        LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, D02)
    End Sub

    Private Sub LoadTDBCAssetID()
        If Not bLoadtdbcAssetID Then Exit Sub
        Dim sSQL As String = ""

        'Cập nhật ngày 3/8/2012 theo incident 50294 của PHUONGTHAO boi VANVINH
        sSQL = "SELECT 0 AS DisplayOrder,'%' AS AssetID,  " & AllName & " AS AssetName "
        sSQL &= "UNION ALL SELECT	1 AS DisplayOrder, AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName FROM D02T0001  WITH (NOLOCK) "
        sSQL &= " WHERE	 Disabled = 0  AND IsCompleted = 1 AND DivisionID = " & SQLString(gsDivisionID)
        Select Case tdbcGroupTypeID.Text
            Case "A01", "A02", "A03", "A04", "A05", "A06", "A07", "A08", "A09", "A10"
                sSQL &= "And ACode" & Strings.Right(tdbcGroupTypeID.Text, 2) & "ID like " & SQLString(tdbcACodeID.Text) & vbCrLf
            Case Else
                If tdbcACodeID.Text = "" Then
                    sSQL &= "And " & SQLString(tdbcGroupTypeID.Text) & "like '%' " & vbCrLf
                Else
                    sSQL &= "And " & SQLString(tdbcGroupTypeID.Text) & "like " & SQLString(tdbcACodeID.Text) & vbCrLf
                End If
        End Select
        sSQL &= " ORDER BY 	DisplayOrder,AssetID"

        Dim dtAssetID As DataTable = ReturnDataTable(sSQL)
        LoadDataSource(tdbcFromAssetID, dtAssetID, gbUnicode)
        LoadDataSource(tdbcToAssetID, dtAssetID.DefaultView.ToTable, gbUnicode)
    End Sub

    Private Sub tdbcFromPeriodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromPeriodID.SelectedValueChanged
        tdbcToPeriodID.Text = tdbcFromPeriodID.Text

        LoadTDBCAssetID()

    End Sub

    Private Sub tdbcToPeriodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.SelectedValueChanged
        LoadTDBCAssetID()
    End Sub



    Private Sub LoadtdbcACodeID(ByVal ID As String)
        If ID = "%" Then
            LoadDataSource(tdbcACodeID, dtACodeID.DefaultView.ToTable, gbUnicode)
        Else
            LoadDataSource(tdbcACodeID, ReturnTableFilter(dtACodeID, "TypeCodeID = " & SQLString(ID) & " Or TypeCodeID = '%'"), gbUnicode) '
        End If
        tdbcACodeID.SelectedIndex = 0
    End Sub

#Region "Events tdbcReportTypeID with txtReportTypeName"

    Private Sub tdbcReportTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.Close
        If tdbcReportTypeID.FindStringExact(tdbcReportTypeID.Text) = -1 Then
            tdbcReportTypeID.Text = ""
            txtReportTypeName.Text = ""
        End If
    End Sub

    Private Sub tdbcReportTypeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.SelectedValueChanged
        txtReportTypeName.Text = tdbcReportTypeID.Columns(1).Value.ToString
    End Sub

    Private Sub tdbcReportTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportTypeID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcReportTypeID.Text = ""
            txtReportTypeName.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcReportID with txtTitle"

    'Private Sub tdbcReportID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.Close
    '    If tdbcReportID.FindStringExact(tdbcReportID.Text) = -1 Then
    '        tdbcReportID.Text = ""
    '        txtTitle.Text = ""
    '    End If
    'End Sub

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

#Region "Events tdbcGroupTypeID"

    Private Sub tdbcGroupTypeID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.LostFocus
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then
            tdbcGroupTypeID.Text = ""
            LoadtdbcACodeID("-1")
            Exit Sub
        End If
    End Sub

    Private Sub tdbcGroupTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.SelectedValueChanged
        LoadtdbcACodeID(tdbcGroupTypeID.Text)
    End Sub

    Private Sub tdbcGroupTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcGroupTypeID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcGroupTypeID.Text = ""
    End Sub

#End Region

#Region "Events tdbcACodeID with txtDescription"

    Private Sub tdbcACodeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.Close
        If tdbcACodeID.FindStringExact(tdbcACodeID.Text) = -1 Then
            tdbcACodeID.Text = ""
            txtDescription.Text = ""
        End If
    End Sub

    Private Sub tdbcACodeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.SelectedValueChanged
        txtDescription.Text = tdbcACodeID.Columns(1).Value.ToString
        LoadTDBCAssetID()
        'Dim sSQl As String = ""
        'sSQl &= "Select 0 as DisplayOrder,'%' As AssetID, " & AllName & "  As AssetName" & vbCrLf
        ''If gsLanguage = "84" Then
        ''    sSQl &= "'<Taát caû>' As AssetName" & vbCrLf
        ''Else
        ''    sSQl &= "'<All>' As AssetName" & vbCrLf
        ''End If
        'sSQl &= "Union All  " & vbCrLf
        'sSQl &= "Select 1 as DisplayOrder, AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        'sSQl &= "From D02T0001 " & vbCrLf
        'sSQl &= "Where Disabled = 0  " & vbCrLf
        'sSQl &= "And IsCompleted = 1 " & vbCrLf
        'sSQl &= "And DivisionID = " & SQLString(gsDivisionID) & vbCrLf
        'If tdbcACodeID.Text <> "%" Then
        '    If tdbcGroupTypeID.Text = "A01" Or tdbcGroupTypeID.Text = "A02" Or tdbcGroupTypeID.Text = "A03" Or tdbcGroupTypeID.Text = "A04" Or tdbcGroupTypeID.Text = "A05" Or tdbcGroupTypeID.Text = "A06" Or tdbcGroupTypeID.Text = "A07" Or tdbcGroupTypeID.Text = "A08" Or tdbcGroupTypeID.Text = "A09" Or tdbcGroupTypeID.Text = "A10" Then
        '        Dim s As String
        '        s = tdbcGroupTypeID.Text
        '        stam = s.Substring(1, 2)
        '        sSQl &= "And ACode" & stam & "ID like " & SQLString(tdbcACodeID.Text) & vbCrLf
        '    Else
        '        If tdbcACodeID.Text = "" Then
        '            sSQl &= "And " & SQLString(tdbcGroupTypeID.Text) & "like '%' " & vbCrLf
        '        Else
        '            sSQl &= "And " & SQLString(tdbcGroupTypeID.Text) & "like " & SQLString(tdbcACodeID.Text) & vbCrLf
        '        End If

        '    End If
        'End If
        'sSQl &= "And TranMonth + TranYear*100 >= " & SQLString(tdbcFromPeriodID.Columns("TranMonth").Text) & "+" & SQLString(tdbcFromPeriodID.Columns("TranYear").Text) & "*100 " & vbCrLf
        'sSQl &= "And TranMonth + TranYear*100 <= " & SQLString(tdbcToPeriodID.Columns("TranMonth").Text) & "+" & SQLString(tdbcToPeriodID.Columns("TranYear").Text) & "*100  " & vbCrLf
        'sSQl &= "Order By DisplayOrder,AssetID"
        'Dim dtTemp As DataTable = ReturnDataTable(sSQl)
        'LoadDataSource(tdbcFromAssetID, dtTemp, gbUnicode)
        'LoadDataSource(tdbcToAssetID, dtTemp.DefaultView.ToTable, gbUnicode)
    End Sub

    Private Sub tdbcACodeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcACodeID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcACodeID.Text = ""
            txtDescription.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcFromPeriodID"

    Private Sub tdbcFromPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromPeriodID.Close
        If tdbcFromPeriodID.FindStringExact(tdbcFromPeriodID.Text) = -1 Then tdbcFromPeriodID.Text = ""
    End Sub

    Private Sub tdbcFromPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromPeriodID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromPeriodID.Text = ""
    End Sub

#End Region

#Region "Events tdbcToPeriodID"

    Private Sub tdbcToPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.Close
        If tdbcToPeriodID.FindStringExact(tdbcToPeriodID.Text) = -1 Then tdbcToPeriodID.Text = ""
    End Sub

    'Private Sub tdbcToPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToPeriodID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToPeriodID.Text = ""
    'End Sub

#End Region

#Region "Events tdbcFromAssetID"

    Private Sub tdbcFromAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.Close
        If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then tdbcFromAssetID.Text = ""
    End Sub

    Private Sub tdbcFromAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromAssetID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromAssetID.Text = ""
    End Sub

#End Region

#Region "Events tdbcToAssetID"

    Private Sub tdbcToAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToAssetID.Close
        If tdbcToAssetID.FindStringExact(tdbcToAssetID.Text) = -1 Then tdbcToAssetID.Text = ""
    End Sub

    Private Sub tdbcToAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToAssetID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToAssetID.Text = ""
    End Sub
#End Region

    Private Sub tdbcFromAssetID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.SelectedValueChanged
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Enabled = False
        Else
            tdbcToAssetID.Enabled = True

        End If
    End Sub

    Private Function AllowPrint() As Boolean
        If tdbcReportTypeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Mau_chuan"))
            tdbcReportTypeID.Focus()
            Return False
        End If
        If tdbcGroupTypeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcGroupTypeID.Focus()
            Return False
        End If
        If tdbcACodeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
            tdbcACodeID.Focus()
            Return False
        End If
        If tdbcFromAssetID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tai_san"))
            tdbcFromAssetID.Focus()
            Return False
        End If
        If tdbcToAssetID.Enabled = True Then
            If tdbcToAssetID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Tai_san"))
                tdbcToAssetID.Focus()
                Return False
            End If

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
        If tdbcFromPeriodID.Text <> "" And tdbcToPeriodID.Text <> "" Then
            If CInt(tdbcFromPeriodID.Columns("TranYear").Text) > CInt(tdbcToPeriodID.Columns("TranYear").Text) Then
                D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
                tdbcFromPeriodID.Focus()
                Return False
            ElseIf CInt(tdbcFromPeriodID.Columns("TranYear").Text) = CInt(tdbcToPeriodID.Columns("TranYear").Text) Then
                If CInt(tdbcFromPeriodID.Columns("TranMonth").Text) > CInt(tdbcToPeriodID.Columns("TranMonth").Text) Then
                    D99C0008.MsgL3(rl3("Ban_phai_chon_tu_ky_nho_hon_den_ky"))
                    tdbcFromPeriodID.Focus()
                    Return False
                End If
            End If
        End If

        If optDate.Checked = True Then
            If c1dateFrom.Value.ToString = "" Then
                D99C0008.MsgNotYetEnter(rl3("Ngay"))
                c1dateFrom.Focus()
                Return False
            End If
            If c1dateTo.Value.ToString = "" Then
                D99C0008.MsgNotYetEnter(rl3("Ngay"))
                c1dateTo.Focus()
                Return False
            End If
        Else
            If c1dateFrom.Value.ToString = "" Then
                c1dateFrom.Value = Date.Today
            End If
            If c1dateTo.Value.ToString = "" Then
                c1dateTo.Value = Date.Today
            End If
        End If
        Return True
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If Not AllowPrint() Then Exit Sub
        If optDate.Checked = True Then If Not CheckValidDateFromTo(c1dateFrom, c1dateTo) Then Exit Sub
        PrintData()
        'If giAppMode = 0 Then ' In truc tiếp

        '    PrintData()
        'Else ' in Online
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
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""
        'Update ngay 30/8/2012 theo incident 50685 cua HOANGTUAN boi VANVINH
        'Thay doi cau do nguon cho SubReport
        sSQLSub = "SELECT * FROM D91V0016 WHERE DivisionID = " & SQLString(gsDivisionID)
        UnicodeSubReport(sSubReportName, sSQLSub, gsDivisionID, gbUnicode)
        Dim sUnicode As String = UnicodeJoin(gbUnicode)
        If tdbcReportID.Text = "" Then
            'Them ngay 3/8/2012 theo incident 50294 cua PHUONGTHAO boi VANVINH
            If tdbcReportTypeID.Text = "D02R4011" Then
                sSubReportName = "D91R0000"


                sSQL = SQLStoreD02P4011()
            Else
                If tdbcReportTypeID.Text = "D02R4010" Then
                    sSQL = SQLStoreD02P4010()
                Else
                    sSQL = "SELECT ASSETID,OBJECTTYPEID,OBJECTID,TRANMONTH,TRANYEAR,DIVISIONID,CONVERTEDAMOUNT,AMOUNTDEPRECIATION,REMAINAMOUNT,ASSETACCOUNTID"
                    sSQL &= " DEPACCOUNTID,ASSETTAG,MOVINGMONTH,ASSETNAME" & sUnicode & " as ASSETNAME,OBJECTNAME" & sUnicode & " as OBJECTNAME " & vbCrLf
                    '  sSQL = "SELECT * " & vbCrLf
                    sSQL &= "FROM D02V2000 " & vbCrLf
                    'sSQL &= "WHERE (TranMonth + TranYear * 100 >= " & SQLString(tdbcFromPeriodID.Columns("Period").Text) & ") " & vbCrLf
                    'sSQL &= "AND  (TranMonth + TranYear * 100 <= " & SQLString(tdbcToPeriodID.Columns("Period").Text) & ") " & vbCrLf
                    sSQL &= "WHERE (TranMonth + TranYear * 100 >= " & CInt(tdbcFromPeriodID.Columns("TranMonth").Value.ToString) + CInt(tdbcFromPeriodID.Columns("TranYear").Value.ToString) * 100 & ") " & vbCrLf
                    sSQL &= "AND  (TranMonth + TranYear * 100 <= " & CInt(tdbcToPeriodID.Columns("TranMonth").Value.ToString) + CInt(tdbcToPeriodID.Columns("TranYear").Value.ToString) * 100 & ") " & vbCrLf
                    sSQL &= "AND DivisionID = " & SQLString(gsDivisionID) & vbCrLf
                    If tdbcFromAssetID.Text <> "%" And tdbcToAssetID.Text <> "%" Then
                        sSQL &= " AND ( AssetID >= " & SQLString(tdbcFromAssetID.Text) & " AND AssetID <= " & SQLString(tdbcToAssetID.Text) & " )" & vbCrLf
                    End If

                    If sFind <> "" Then sSQL &= sFind & vbCrLf
                    sSQL &= "ORDER BY AssetID ASC" & vbCrLf
                End If
            End If

            sReportName = tdbcReportTypeID.Text
            sReportCaption = rl3("Bao_cao_TSCD_di_chuyen_noi_bo") & " - " & sReportName
            'If D02Options.ReportLanguage = 0 Then
            '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 1 Then
            '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 2 Then
            '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
            'End If
            sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, "") & sReportName & ".rpt"
            With report
                .OpenConnection(conn)
                .AddSub(sSQLSub, sSubReportName & ".rpt")
                .AddMain(sSQL)
                .PrintReport(sPathReport, sReportCaption)
            End With
        Else
            If tdbcReportID.Columns("ReportTypeID").Text = "D02F3040B" Then
                sSQL = SQLStoreD02P4010()
            ElseIf tdbcReportID.Columns("ReportTypeID").Text = "D02F3040A" Then
                'sSQL = "SELECT AssetID , MOVINGMONTH,  AssetName , ObjectName " & vbCrLf
                sSQL = "SELECT ASSETID,OBJECTTYPEID,OBJECTID,TRANMONTH,TRANYEAR,DIVISIONID,CONVERTEDAMOUNT,AMOUNTDEPRECIATION,REMAINAMOUNT,ASSETACCOUNTID"
                sSQL &= " DEPACCOUNTID,ASSETTAG,MOVINGMONTH,ASSETNAME" & sUnicode & " as ASSETNAME,OBJECTNAME" & sUnicode & " as OBJECTNAME " & vbCrLf
                '  sSQL = "SELECT * " & vbCrLf
                sSQL &= "FROM D02V2000 " & vbCrLf
                'sSQL &= "WHERE (TranMonth + TranYear * 100 >= " & SQLString(tdbcFromPeriodID.Columns("Period").Text) & ") " & vbCrLf
                'sSQL &= "AND  (TranMonth + TranYear * 100 <= " & SQLString(tdbcToPeriodID.Columns("Period").Text) & ") " & vbCrLf
                sSQL &= "WHERE (TranMonth + TranYear * 100 >= " & CInt(tdbcFromPeriodID.Columns("TranMonth").Value.ToString) + CInt(tdbcFromPeriodID.Columns("TranYear").Value.ToString) * 100 & ") " & vbCrLf
                sSQL &= "AND  (TranMonth + TranYear * 100 <= " & CInt(tdbcToPeriodID.Columns("TranMonth").Value.ToString) + CInt(tdbcToPeriodID.Columns("TranYear").Value.ToString) * 100 & ") " & vbCrLf
                sSQL &= "AND DivisionID = " & SQLString(gsDivisionID) & vbCrLf
                If tdbcFromAssetID.Text <> "%" And tdbcToAssetID.Text <> "%" Then
                    sSQL &= " AND ( AssetID >= " & SQLString(tdbcFromAssetID.Text) & " AND AssetID <= " & SQLString(tdbcToAssetID.Text) & " )" & vbCrLf
                End If
                If sFind <> "" Then sSQL &= sFind & vbCrLf
                sSQL &= "ORDER BY AssetID ASC" & vbCrLf
            End If

            sReportName = tdbcReportID.Text
            sReportCaption = rl3("Bao_cao_TSCD_di_chuyen_noi_bo") & " - " & sReportName
            sPathReport = gsApplicationSetup & "\Xcustom\" & sReportName & ".rpt"
            With report
                .OpenConnection(conn)
                .AddSub(sSQLSub, sSubReportName & ".rpt")
                .AddMain(sSQL)
                .PrintReport(sPathReport, sReportCaption)
            End With
        End If

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

    '    sSQLSub = "SELECT Top 1 * FROM D91T0025 WITH (NOLOCK) "

    '    If tdbcReportID.Text = "" Then
    '        'Them ngay 3/8/2012 theo incident 50294 cua PHUONGTHAO boi VANVINH
    '        If tdbcReportTypeID.Text = "D02R4011" Then
    '            sSubReportName = "D91R0000"
    '            sSQLSub = "SELECT * FROM D91V0016 WHERE DivisionID = " & SQLString(gsDivisionID)
    '            sSQL = SQLStoreD02P4011()
    '        Else
    '            If tdbcReportTypeID.Text = "D02R4010" Then
    '                sSQL = SQLStoreD02P4010()
    '            Else
    '                sSQL = "SELECT AssetID , MOVINGMONTH,  AssetName , ObjectName " & vbCrLf
    '                sSQL &= "FROM D02V2000 " & vbCrLf
    '                sSQL &= "WHERE (TranMonth + TranYear * 100 >= " & SQLString(tdbcFromPeriodID.Columns("Period").Text) & ") " & vbCrLf
    '                sSQL &= "AND  (TranMonth + TranYear * 100 <= " & SQLString(tdbcToPeriodID.Columns("Period").Text) & ") " & vbCrLf
    '                sSQL &= "AND DivisionID = " & SQLString(gsDivisionID) & vbCrLf
    '                If tdbcFromAssetID.Text <> "%" And tdbcToAssetID.Text <> "%" Then
    '                    sSQL &= " AND ( AssetID >= " & SQLString(tdbcFromAssetID.Text) & " AND AssetID <= " & SQLString(tdbcToAssetID.Text) & " )" & vbCrLf
    '                End If
    '                If sFind <> "" Then sSQL &= sFind & vbCrLf
    '                sSQL &= "ORDER BY AssetID ASC" & vbCrLf
    '            End If
    '        End If

    '        sReportName = tdbcReportTypeID.Text
    '        sReportCaption = rl3("Bao_cao_TSCD_di_chuyen_noi_bo") & " - " & sReportName
    '        With reportWS
    '            .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '            .AddSub(sSQLSub, sSubReportName & ".rpt")
    '            .AddMain(sSQL)
    '            .PrintReport(sReportName & ".rpt", sReportCaption)
    '        End With
    '    Else
    '        If tdbcReportID.Columns("ReportTypeID").Text = "D02F3040B" Then
    '            sSQL = SQLStoreD02P4010()
    '        ElseIf tdbcReportID.Columns("ReportTypeID").Text = "D02F3040A" Then
    '            sSQL = "SELECT AssetID , MOVINGMONTH,  AssetName , ObjectName " & vbCrLf
    '            sSQL &= "FROM D02V2000 " & vbCrLf
    '            sSQL &= "WHERE (TranMonth + TranYear * 100 >= " & SQLString(tdbcFromPeriodID.Columns("Period").Text) & ") " & vbCrLf
    '            sSQL &= "AND  (TranMonth + TranYear * 100 <= " & SQLString(tdbcToPeriodID.Columns("Period").Text) & ") " & vbCrLf
    '            sSQL &= "AND DivisionID = " & SQLString(gsDivisionID) & vbCrLf
    '            If tdbcFromAssetID.Text <> "%" And tdbcToAssetID.Text <> "%" Then
    '                sSQL &= " AND ( AssetID >= " & SQLString(tdbcFromAssetID.Text) & " AND AssetID <= " & SQLString(tdbcToAssetID.Text) & " )" & vbCrLf
    '            End If
    '            If sFind <> "" Then sSQL &= sFind & vbCrLf
    '            sSQL &= "ORDER BY AssetID ASC" & vbCrLf
    '        End If
    '        sReportName = tdbcReportID.Text
    '        sReportCaption = rl3("Bao_cao_TSCD_di_chuyen_noi_bo") & " - " & sReportName
    '        With reportWS
    '            .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '            .AddSub(sSQLSub, sSubReportName & ".rpt")
    '            .AddMain(sSQL)
    '            .PrintReport(sReportName & ".rpt", sReportCaption)
    '        End With
    '    End If

    '        Me.Cursor = Cursors.Default
    '        btnPrint.Enabled = True
    'End Sub

#Region "Active Find - List All "
    Private WithEvents Finder As New D99C1001
	Dim gbEnabledUseFind As Boolean = False
    'Cần sửa Tìm kiếm như sau:
	'Bỏ sự kiện Finder_FindClick.
	'Sửa tham số Me.Name -> Me
	'Phải tạo biến properties có tên chính xác strNewFind và strNewServer
	'Sửa gdtCaptionExcel thành dtCaptionCols: biến toàn cục trong form
	'Nếu có F12 dùng D09U1111 thì Sửa dtCaptionCols thành ResetTableByGrid(usrOption, dtCaptionCols.DefaultView.ToTable)
    Private sFind As String = ""
	Public WriteOnly Property strNewFind() As String
		Set(ByVal Value As String)
			sFind = Value
            btnPrint_Click(Nothing, Nothing)
            sFind = ""
		End Set
	End Property


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        If Not AllowPrint() Then Exit Sub
        Dim sSQL As String = ""
        gbEnabledUseFind = True
        sSQL = "Select * From D02V1234 "
        sSQL &= "Where FormID = " & SQLString(Me.Name) & "And Language = " & SQLString(gsLanguage)
        ShowFindDialog(Finder, sSQL, Me, gbUnicode)
        If sFind <> "" Then sFind = " AND " & sFind
        '    If giAppMode = 0 Then
        '        PrintData()
        '    Else
        '        PrintDataWS()
        '    End If

        'End If
        
    End Sub

    'Private Sub Finder_FindClick(ByVal ResultWhereClause As Object) Handles Finder.FindClick
    '    If ResultWhereClause Is Nothing Then Exit Sub
    '    sFind = ResultWhereClause.ToString()

    'End Sub

#End Region

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P4010
    '# Created User: Mỹ Vân
    '# Created Date: 14/02/2008 08:08:30
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P4010() As String
        Dim sSQL As String = ""
        sSQL &= ("-- Bao cao di chuyen tai san " & vbCrLf)
        sSQL &= "Exec D02P4010 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranMonth").Text) & COMMA 'FromMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranYear").Text) & COMMA 'FromYear, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranMonth").Text) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranYear").Text) & COMMA 'ToYear, int, NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(gbUnicode) & COMMA
        'Them ngay 31/8/2012 theo incident 50685 cua HOANGTUAN boi VANVINH
        sSQL &= SQLString(sFind)  'Truyền biến của Button Lọc vào biến @strFind trong Sp D02P4010 
        Return sSQL
    End Function

#Region "Thêm ngày 3/8/2012 theo incident 50294 của PHUONGTHAO bởi VANVINH"
    Private Sub optDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDate.Click
        If optDate.Checked Then
            c1dateFrom.Enabled = True
            c1dateTo.Enabled = True

            tdbcFromPeriodID.Enabled = False
            tdbcToPeriodID.Enabled = False
        Else
            c1dateFrom.Enabled = False
            c1dateTo.Enabled = False

            tdbcFromPeriodID.Enabled = True
            tdbcToPeriodID.Enabled = True
        End If
    End Sub

    Private Sub optPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPeriod.Click
        If optPeriod.Checked Then
            tdbcFromPeriodID.Enabled = True
            tdbcToPeriodID.Enabled = True

            c1dateFrom.Enabled = False
            c1dateTo.Enabled = False
        Else
            tdbcFromPeriodID.Enabled = False
            tdbcToPeriodID.Enabled = False

            c1dateFrom.Enabled = True
            c1dateTo.Enabled = True
        End If
    End Sub
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P4011
    '# Created User: Phạm Văn Vinh
    '# Created Date: 03/08/2012 08:08:14
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P4011() As String
        Dim sSQL As String = ""
        sSQL &= ("-- Bao cao di chuyen tai san theo ngay - ky, theo doi BPQL truoc - D02R4011 " & vbCrLf)
        sSQL &= "Exec D02P4011 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(optDate.Checked) & COMMA 'IsTime, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranMonth").Value) & COMMA 'FromMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromPeriodID.Columns("TranYear").Value) & COMMA 'FromYear, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranMonth").Value) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns("TranYear").Value) & COMMA 'ToYear, int, NOT NULL
        sSQL &= SQLDateSave(c1dateFrom.Text) & COMMA 'FromDate, datetime, NOT NULL
        sSQL &= SQLDateSave(c1dateTo.Text) & COMMA 'ToDate, datetime, NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, tinyint, NOT NULL
        'Them ngay 29/8/2012 theo incident 50685 cua HOANGTUAN boi VANVINH
        sSQL &= SQLString(sFind)  'Truyền biến của Button Lọc vào biến @strFind trong Sp D02P4011 
        Return sSQL
    End Function


#End Region

 
End Class