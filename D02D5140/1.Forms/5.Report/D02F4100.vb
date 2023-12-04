Public Class D02F4100
	Dim report As D99C2003

    Dim dt As DataTable
    Dim dtPeriod As DataTable

    Private Sub D02F4100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	LoadInfoGeneral()
        Me.Cursor = Cursors.WaitCursor
        Loadlanguage()
        InputbyUnicode(Me, gbUnicode)
        LoadTDBCombo()
        SetBackColorObligatory()
        LoadDefault()
        SetResolutionForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcDivisionID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACodeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcAssetIDFrom.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcAssetIDTo.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcPeriodFrom.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcPeriodTo.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub


    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_nhap_xuat_ton_TSCD_-_D02F4100") & UnicodeCaption(gbUnicode) 'BÀo cÀo nhËp xuÊt tän TSC˜ - D02F4100
        '================================================================ 
        lblGroupTime.Text = "4. " & rl3("Thong_tin_thoi_gian") '4. Thông tin thời gian
        lblGroupFilter.Text = "3. " & rl3("Tieu_thuc_loc") '3. Tiêu thức lọc
        lblGroupTypeID.Text = rl3("Phan_loai") 'Phân loại
        lblAssetID.Text = rl3("Tai_san") 'Tài sản
        lblGroupReport.Text = "2. " & rl3("Bao_cao") '2. Báo cáo
        lblReportID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblCustomizeReport.Text = rl3("Dac_thu") 'Đặc thù
        lblGroupDivisionID.Text = "1. " & rl3("Don_vi") '1. Đơn vị
        lblDivisionID.Text = rl3("Don_vi") 'Đơn vị
        lblPeriod.Text = rl3("Ky") 'Kỳ
        '================================================================ 
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnPrint.Text = rl3("_In") '&In
        '================================================================ 
        tdbcAssetIDTo.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcAssetIDTo.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcAssetIDFrom.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcAssetIDFrom.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcACodeID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACodeID.Columns("Description").Caption = rl3("Ten") 'Tên
        tdbcGroupTypeID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupTypeID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
        tdbcCustomizeReportID.Columns("CustomizedReportID").Caption = rl3("Ma") 'Mã
        tdbcCustomizeReportID.Columns("CustomizedReportName").Caption = rl3("Ten") 'Tên
        tdbcDivisionID.Columns("DivisionID").Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns("DivisionName").Caption = rl3("Ten") 'Tên
    End Sub

    Private Sub LoadDefault()
        tdbcDivisionID.Text = gsDivisionID
        txtReportID.Text = "D02R4100"
        If gbUnicode Then
            txtReportName.Text = rl3("Bao_cao_nhap_xuat_ton_TSCD")
        Else
            txtReportName.Text = rl3("Bao_cao_nhap_xuat_ton_TSCDV")
        End If

        ReadOnlyControl(txtReportID)
        ReadOnlyControl(txtReportName)
        tdbcPeriodFrom.Text = giTranMonth.ToString("00") & "/" & giTranYear.ToString
        tdbcPeriodTo.Text = giTranMonth.ToString("00") & "/" & giTranYear.ToString
        tdbcGroupTypeID.SelectedValue = "%"
        tdbcACodeID.SelectedValue = "%"
        tdbcAssetIDFrom.SelectedValue = "%"
        tdbcAssetIDTo.SelectedValue = "%"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub D02F4100_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
        End If
    End Sub
    Private Sub LoadTDBCombo()
        Dim sSQL As String = ""

        'Load tdbcCustomizeReportID
        sSQL = "SELECT 	ReportID AS CustomizedReportID, "
        If (geLanguage = EnumLanguage.Vietnamese) Then
            sSQL &= " Title" & UnicodeJoin(gbUnicode) & " AS CustomizedReportName, ReportTypeID"
        Else
            sSQL &= " Title01" & UnicodeJoin(gbUnicode) & " AS CustomizedReportName, ReportTypeID"
        End If
        sSQL &= " FROM D89T1000 WITH (NOLOCK) "
        sSQL &= " WHERE ModuleID = '02' And ReportTypeID = 'D02F4100'"
        sSQL &= " AND (DAGroupID = '' OR"
        sSQL &= " DAGroupID IN"
        sSQL &= " (SELECT DAGroupID"
        sSQL &= " From LEMONSYS.DBO.D00V0080"
        sSQL &= " WHERE UserID = " & SQLString(gsUserID)
        sSQL &= ") OR 'LEMONADMIN' = " & SQLString(gsUserID) & ")"

        LoadDataSource(tdbcCustomizeReportID, sSQL, gbUnicode)

        'Load DataTable cho kỳ kế toán
        dtPeriod = LoadTablePeriodReport(D02)

        'Load tdbcGroupTypeID
        sSQL = "Select GroupTypeID,  " & vbCrLf
        If gsLanguage = "84" Then
            sSQL &= "VieTypeCaption" & UnicodeJoin(gbUnicode) & " As GroupCaption," & vbCrLf
        Else
            sSQL &= "EngTypeCaption" & UnicodeJoin(gbUnicode) & " As GroupCaption," & vbCrLf
        End If
        sSQL &= "TableName" & vbCrLf
        sSQL &= "From D02V3333 " & vbCrLf
        sSQL &= "Order By GroupTypeID "
        LoadDataSource(tdbcGroupTypeID, sSQL, gbUnicode)

        'Load tdbcDivisionID
        LoadCboDivisionIDReport(tdbcDivisionID, D02, , gbUnicode)

        'Load tdbcACodeID
        sSQL = "SELECT	0 as DisplayOrder,'%' as ACodeID, " & AllName & " as Description, '%' as GroupTypeID"
        sSQL &= " UNION ALL"
        sSQL &= " SELECT 	1 as DisplayOrder,	ACodeID, Description" & UnicodeJoin(gbUnicode) & " as Description, TypeCodeID As GroupTypeID "
        sSQL &= " FROM D02V4444 "
        sSQL &= " ORDER BY	DisplayOrder,ACodeID"
        dt = ReturnDataTable(sSQL)
        LoadDataSource(tdbcACodeID, dt.Copy, gbUnicode)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not AllowPrint() Then Exit Sub
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

        If tdbcCustomizeReportID.Text = "" Then
            sReportName = "D02R4100"
            '    If D02Options.ReportLanguage = 0 Then
            '        sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
            '    ElseIf D02Options.ReportLanguage = 1 Then
            '        sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
            '    ElseIf D02Options.ReportLanguage = 2 Then
            '        sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
            '    End If
        Else
            sReportName = tdbcCustomizeReportID.Text.Trim
            '    sReportCaption = sReportCaption & " - " & sReportName
            '    sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"
        End If
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcCustomizeReportID.Text) & sReportName & ".rpt"
        sReportCaption = rl3("Bao_cao_nhap_xuat_ton_TSCD_F") & " - " & sReportName

        sSQL = SQLStoreD02P4100()
        sSQLSub = "SELECT * FROM D91V0016  WHERE DivisionID = " & SQLString(tdbcDivisionID.Text)
        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(sSQL)
            .PrintReport(sPathReport, sReportCaption)
        End With
        Me.Cursor = Cursors.Default
    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P4100
    '# Created User: le son long
    '# Created Date: 20/10/2010 02:41:24
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P4100() As String
        Dim sSQL As String = ""
        sSQL = "Exec D02P4100 "
        sSQL &= SQLString(tdbcDivisionID.Text) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcPeriodFrom.Columns("TranMonth").Text) & COMMA 'MonthFrom, int, NOT NULL
        sSQL &= SQLNumber(tdbcPeriodFrom.Columns("TranYear").Text) & COMMA 'YearFrom, int, NOT NULL
        sSQL &= SQLNumber(tdbcPeriodTo.Columns("TranMonth").Text) & COMMA 'MonthTo, int, NOT NULL
        sSQL &= SQLNumber(tdbcPeriodTo.Columns("TranYear").Text) & COMMA 'YearTo, int, NOT NULL
        sSQL &= SQLString(tdbcGroupTypeID.Text) & COMMA 'GroupTypeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcACodeID.Text) & COMMA 'ACodeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcAssetIDFrom.Text) & COMMA 'AssetIDFrom, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcAssetIDTo.Text) & COMMA 'AssetIDTo, varchar[20], NOT NULL
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        If tdbcCustomizeReportID.Text.Trim = "" Then
            sSQL &= SQLString(txtReportID.Text) & COMMA 'ReportID , varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcCustomizeReportID.Text) & COMMA 'ReportID, varchar[20], NOT NULL
        End If
        sSQL &= SQLNumber(gbUnicode) 'CodeTable, int
        Return sSQL
    End Function

    Private Function AllowPrint() As Boolean
        If tdbcDivisionID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Don_vi"))
            tdbcDivisionID.Focus()
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
        If tdbcAssetIDFrom.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tai_san"))
            tdbcAssetIDFrom.Focus()
            Return False
        End If
        If tdbcAssetIDTo.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tai_san"))
            tdbcAssetIDTo.Focus()
            Return False
        End If
        If tdbcPeriodFrom.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Ky"))
            tdbcPeriodFrom.Focus()
            Return False
        End If
        If tdbcPeriodTo.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Ky"))
            tdbcPeriodTo.Focus()
            Return False
        End If
        If Not CheckValidPeriodFromTo(tdbcPeriodFrom, tdbcPeriodTo) Then Return False
        'If tdbcPeriodFrom.Columns("TranYear").Text > tdbcPeriodTo.Columns("TranYear").Text Then
        '    D99C0008.MsgL3(rl3("MSG000014"))
        '    tdbcPeriodFrom.Focus()
        '    Return False
        'ElseIf tdbcPeriodFrom.Columns("TranYear").Text = tdbcPeriodTo.Columns("TranYear").Text Then
        '    If tdbcPeriodFrom.Columns("TranMonth").Text > tdbcPeriodTo.Columns("TranMonth").Text Then
        '        D99C0008.MsgL3(rl3("MSG000014"))
        '        tdbcPeriodFrom.Focus()
        '        Return False
        '    End If
        'End If
        Return True
    End Function


#Region "Events tdbcDivisionID with txtDivisionName"

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        If tdbcDivisionID.SelectedValue Is Nothing Then
            txtDivisionName.Text = ""
        Else
            txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
            LoadCboPeriodReport(tdbcPeriodFrom, tdbcPeriodTo, dtPeriod, tdbcDivisionID.Text)
            tdbcPeriodFrom.Text = tdbcPeriodFrom.Columns("Period").Text
            tdbcPeriodTo.Text = tdbcPeriodTo.Columns("Period").Text
        End If
        LoadTDBCAssetID()
    End Sub

    Private Sub tdbcDivisionID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.LostFocus
        If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 Then
            tdbcDivisionID.Text = ""
        End If
    End Sub
#End Region
#Region "Events tdbcCustomizeReportID with txtCustomizeReportName"

    Private Sub tdbcCustomizeReportID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcCustomizeReportID.SelectedValueChanged
        If tdbcCustomizeReportID.SelectedValue Is Nothing Then
            txtCustomizeReportName.Text = ""
        Else
            txtCustomizeReportName.Text = tdbcCustomizeReportID.Columns(1).Value.ToString
        End If
    End Sub

#End Region

#Region "Events tdbcGroupTypeID load tdbcACodeID with txtDescription"

    Private Sub tdbcGroupTypeID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.GotFocus
        'Dùng phím Enter
        tdbcGroupTypeID.Tag = tdbcGroupTypeID.Text
    End Sub

    Private Sub tdbcGroupTypeID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.LostFocus
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then tdbcGroupTypeID.Text = ""
    End Sub

    Private Sub tdbcGroupTypeID_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbcGroupTypeID.MouseDown
        'Di chuyển chuột
        tdbcGroupTypeID.Tag = tdbcGroupTypeID.Text
    End Sub



    Private Sub tdbcGroupTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.SelectedValueChanged
        LoadDataSource(tdbcACodeID, ReturnTableFilter(dt, "  GroupTypeID = " & SQLString(tdbcGroupTypeID.Text) & " OR GroupTypeID = '%'"), gbUnicode) '
        '  txtDescription.Text = ""
        'tdbcACodeID.Text = ""
        tdbcACodeID.AutoSelect = True
    End Sub
    Private Sub LoadTDBCAssetID()
        'LoadTDBCAssetID()
        Dim stam As String = "" 'Biến tạm
        Dim s As String = "" 'Biến tạm
        Dim sSQL As String = ""

        sSQL &= "Select 0 as DisplayOrder,'%' As AssetID,  " & AllName & " as AssetName " & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQL &= "'<Taát caû>' As AssetName" & vbCrLf
        'Else
        '    sSQL &= "'<All>' As AssetName" & vbCrLf
        'End If
        sSQL &= "Union All  " & vbCrLf
        sSQL &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        sSQL &= "From D02T0001  WITH (NOLOCK) " & vbCrLf
        sSQL &= "Where Disabled = 0  " & vbCrLf
        sSQL &= "And IsCompleted = 1 " & vbCrLf
        sSQL &= "And DivisionID LIKE " & SQLString(tdbcDivisionID.Text) & vbCrLf
        If tdbcACodeID.Text <> "%" And tdbcACodeID.Text.Trim <> "" Then
            If tdbcGroupTypeID.Text = "A01" Or tdbcGroupTypeID.Text = "A02" Or tdbcGroupTypeID.Text = "A03" Or tdbcGroupTypeID.Text = "A04" Or tdbcGroupTypeID.Text = "A05" Or tdbcGroupTypeID.Text = "A06" Or tdbcGroupTypeID.Text = "A07" Or tdbcGroupTypeID.Text = "A08" Or tdbcGroupTypeID.Text = "A09" Or tdbcGroupTypeID.Text = "A10" Then
                s = tdbcGroupTypeID.Text
                stam = s.Substring(1, 2)
                sSQL &= "And ACode" & stam & "ID =" & SQLString(tdbcACodeID.Text) & vbCrLf
            ElseIf tdbcGroupTypeID.Text = "AssetS1ID" Or tdbcGroupTypeID.Text = "AssetS2ID" Or tdbcGroupTypeID.Text = "AssetS3ID" Then
                sSQL &= "And " & tdbcACodeID.Columns("GroupTypeID").Value.ToString & " = " & SQLString(tdbcACodeID.SelectedValue.ToString) & vbCrLf
            Else
                sSQL &= "And ObjectTypeID = " & SQLString(tdbcGroupTypeID.Text) & vbCrLf
                sSQL &= "And ObjectID  = " & SQLString(tdbcACodeID.Text) & vbCrLf
            End If
        End If
        sSQL &= "Order By DisplayOrder, AssetID"

        Dim dtAsset As DataTable = ReturnDataTable(sSQL)
        LoadDataSource(tdbcAssetIDFrom, dtAsset.Copy, gbUnicode)
        LoadDataSource(tdbcAssetIDTo, dtAsset, gbUnicode)
        tdbcAssetIDFrom.AutoSelect = True
        tdbcAssetIDTo.AutoSelect = True
    End Sub
    Private Sub tdbcACodeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcACodeID.SelectedValueChanged
        If tdbcACodeID.SelectedValue Is Nothing Then
            txtDescription.Text = ""
        Else
            txtDescription.Text = tdbcACodeID.Columns(1).Text.ToString
        End If

        LoadTDBCAssetID()
        'Dim stam As String = "" 'Biến tạm
        'Dim s As String = "" 'Biến tạm
        'Dim sSQL As String = ""

        'sSQL &= "Select 0 as DisplayOrder,'%' As AssetID,  " & AllName & " as AssetName " & vbCrLf
        ''If gsLanguage = "84" Then
        ''    sSQL &= "'<Taát caû>' As AssetName" & vbCrLf
        ''Else
        ''    sSQL &= "'<All>' As AssetName" & vbCrLf
        ''End If
        'sSQL &= "Union All  " & vbCrLf
        'sSQL &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        'sSQL &= "From D02T0001  WITH (NOLOCK) " & vbCrLf
        'sSQL &= "Where Disabled = 0  " & vbCrLf
        'sSQL &= "And IsCompleted = 1 " & vbCrLf
        'sSQL &= "And DivisionID LIKE " & SQLString(tdbcDivisionID.Text) & vbCrLf
        'If tdbcACodeID.Text <> "%" And tdbcACodeID.Text.Trim <> "" Then
        '    If tdbcGroupTypeID.Text = "A01" Or tdbcGroupTypeID.Text = "A02" Or tdbcGroupTypeID.Text = "A03" Or tdbcGroupTypeID.Text = "A04" Or tdbcGroupTypeID.Text = "A05" Or tdbcGroupTypeID.Text = "A06" Or tdbcGroupTypeID.Text = "A07" Or tdbcGroupTypeID.Text = "A08" Or tdbcGroupTypeID.Text = "A09" Or tdbcGroupTypeID.Text = "A10" Then
        '        s = tdbcGroupTypeID.Text
        '        stam = s.Substring(1, 2)
        '        sSQL &= "And ACode" & stam & "ID =" & SQLString(tdbcACodeID.Text) & vbCrLf
        '    ElseIf tdbcGroupTypeID.Text = "AssetS1ID" Or tdbcGroupTypeID.Text = "AssetS2ID" Or tdbcGroupTypeID.Text = "AssetS3ID" Then
        '        sSQL &= "And " & tdbcACodeID.Columns("GroupTypeID").Value.ToString & " = " & SQLString(tdbcACodeID.SelectedValue.ToString) & vbCrLf
        '    Else
        '        sSQL &= "And ObjectTypeID = " & SQLString(tdbcGroupTypeID.Text) & vbCrLf
        '        sSQL &= "And ObjectID  = " & SQLString(tdbcACodeID.Text) & vbCrLf
        '    End If
        'End If
        'sSQL &= "Order By DisplayOrder, AssetID"

        'Dim dtAsset As DataTable = ReturnDataTable(sSQL)
        'LoadDataSource(tdbcAssetIDFrom, dtAsset.Copy, gbUnicode)
        'LoadDataSource(tdbcAssetIDTo, dtAsset, gbUnicode)
        'tdbcAssetIDFrom.AutoSelect = True
        'tdbcAssetIDTo.AutoSelect = True
    End Sub

    Private Sub tdbcACodeID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcACodeID.LostFocus
        If tdbcACodeID.FindStringExact(tdbcACodeID.Text) = -1 Then tdbcACodeID.Text = ""
    End Sub

#End Region

#Region "Events tdbcAssetIDFrom"

    Private Sub tdbcAssetIDFrom_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAssetIDFrom.LostFocus
        If tdbcAssetIDFrom.FindStringExact(tdbcAssetIDFrom.Text) = -1 Then tdbcAssetIDFrom.Text = ""
        SetValueTo(tdbcAssetIDFrom, tdbcAssetIDTo)
    End Sub

    Private Sub tdbcAssetIDFrom_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcAssetIDFrom.SelectedValueChanged
        If tdbcAssetIDFrom.Text = "%" Then
            tdbcAssetIDTo.SelectedValue = "%"
            ReadOnlyControl(tdbcAssetIDTo)
        Else
            UnReadOnlyControl(tdbcAssetIDTo, True)
        End If
    End Sub
#End Region
#Region "Events tdbcAssetIDTo"

    Private Sub tdbcAssetIDTo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcAssetIDTo.LostFocus
        If tdbcAssetIDTo.FindStringExact(tdbcAssetIDTo.Text) = -1 Then tdbcAssetIDTo.Text = ""
    End Sub
#End Region
#Region "Events tdbcPeriodFrom"
    Private Sub tdbcPeriodFrom_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcPeriodFrom.LostFocus
        If tdbcPeriodFrom.FindStringExact(tdbcPeriodFrom.Text) = -1 Then tdbcPeriodFrom.Text = ""
    End Sub
#End Region
#Region "Events tdbcPeriodTo"
    Private Sub tdbcPeriodTo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcPeriodTo.LostFocus
        If tdbcPeriodTo.FindStringExact(tdbcPeriodTo.Text) = -1 Then tdbcPeriodTo.Text = ""
    End Sub
#End Region
End Class