Public Class D02F3050
    Dim report As D99C2003

    Dim dtObjectID As DataTable
    Dim dtACodeID As DataTable

    Private Sub D02F3050_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If
    End Sub

    Private Sub D02F3050_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInfoGeneral()
        SetBackColorObligatory()
        Loadlanguage()
        InputbyUnicode(Me, gbUnicode)
        LoadTDBCombo()
        LoadDefault()
        SetResolutionForm(Me)
    End Sub

    Private Sub LoadDefault()
        tdbcGroupTypeID.SelectedValue = "%"
        tdbcObjectTypeID.SelectedValue = "%"
        tdbcFromAssetID.SelectedValue = "%"
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_thiet_bi_dinh_kem_tai_san_-_D02F3050") & UnicodeCaption(gbUnicode) 'BÀo cÀo thiÕt bÜ ¢Ûnh kÌm tªi s¶n - D02F3050
        '================================================================ 
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù
        lblGroupTypeID.Text = rl3("Phan_loai") 'Phân loại
        lblObjectTypeID.Text = rl3("Bo_phan_quan_ly") 'Bộ phận quản lý
        lblFromAssetID.Text = rl3("Tai_san") 'Tài sản
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        '================================================================ 
        GroupBox1.Text = rl3("Dang_bao_cao") 'Dạng báo cáo
        GroupBox2.Text = rl3("Dieu_kien_loc") 'Điều kiện lọc
        '================================================================ 
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcReportTypeID.Columns("ReportTypeID").Caption = rl3("Ma") 'Mã 
        tdbcReportTypeID.Columns("ReportTypeName").Caption = rl3("Ten") 'Tên
        tdbcToAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcToAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcFromAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFromAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcObjectID.Columns("ObjectID").Caption = rl3("Ma") 'Mã 
        tdbcObjectID.Columns("ObjectName").Caption = rl3("Ten") 'Tên 

        tdbcObjectTypeID.Columns("ObjectTypeID").Caption = rl3("Ma") 'Mã
        tdbcObjectTypeID.Columns("ObjectTypeName").Caption = rl3("Ten") 'Tên
        tdbcACodeID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACodeID.Columns("Description").Caption = rl3("Ten") 'Tên

        tdbcGroupTypeID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupTypeID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACodeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcObjectTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcObjectID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQL As String = ""
        Dim sUnicode As String = UnicodeJoin(gbUnicode)
        'Load tdbcReportTypeID
        sSQl = "Select ReportID As ReportTypeID, " & vbCrLf
        If gsLanguage = "84" Then
            sSQL &= "Description"
        Else
            sSQL &= "Description01"
        End If
        sSQL &= sUnicode & " As ReportTypeName, StrSQL, ReportType " & vbCrLf
        sSQl &= "From D02V5555 " & vbCrLf
        sSQl &= "Where ReportType = 'D02F3050'" & vbCrLf
        sSQl &= "Order By ReportTypeID" & vbCrLf
        LoadDataSource(tdbcReportTypeID, sSQL, gbUnicode)

        'Load tdbcReportID
        sSQL = "Select A.ReportID, A.Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & sUnicode & " as ReportTypeName " & vbCrLf
        sSQL &= "From D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID " & vbCrLf
        sSQL &= "Where A.ModuleID = '02' And A.ReportTypeID = 'D02F3050'" & vbCrLf
        sSQL &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQL &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQL &= "Order By	A.ReportTypeID" & vbCrLf
        LoadDataSource(tdbcReportID, sSQL, gbUnicode)

        'Load tdbcGroupTypeID
        sSQL = "Select GroupTypeID, " & vbCrLf
        If gsLanguage = "84" Then
            sSQL &= "VieTypeCaption"
        Else
            sSQL &= " EngTypeCaption"
        End If
        sSQL &= sUnicode & " As GroupCaption, TableName, WhereClause " & vbCrLf
        sSQL &= "From D02V3333 " & vbCrLf
        sSQL &= "Order By GroupTypeID " & vbCrLf
        LoadDataSource(tdbcGroupTypeID, sSQL, gbUnicode)

        'Load ACodeID
        sSQL = "	Select 	0 as DisplayOrder,'%' As ACodeID,  " & AllName & " as Description,'%' As TypeCodeID" & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQL &= "'<Taát caû>'" & vbCrLf
        'Else
        '    sSQL &= "'<All>'  as Description," & vbCrLf
        'End If
        sSQL &= "Union All" & vbCrLf
        sSQL &= "Select 1 as DisplayOrder, ACodeID, Description" & sUnicode & " as Description, TypeCodeID As GroupTypeID" & vbCrLf
        sSQL &= "From D02V4444  " & vbCrLf
        sSQL &= "Order By DisplayOrder,ACodeID" & vbCrLf
        dtACodeID = ReturnDataTable(sSQL)
        LoadDataSource(tdbcACodeID, dtACodeID, gbUnicode)

        'LoadObjectID
        sSQL = "Select 0 as DisplayOrder,'%' As ObjectID, " & AllName & " as ObjectName, '%' As ObjectTypeID" & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQL &= "'<Taát caû>'  As ," & vbCrLf
        'Else
        '    sSQL &= "'<All>' As ObjectName," & vbCrLf

        'End If
        'sSQL &= "  " & vbCrLf
        sSQL &= "Union" & vbCrLf
        sSQL &= "Select 1 as DisplayOrder, ObjectID,ObjectName" & sUnicode & " as ObjectName, ObjectTypeID " & vbCrLf
        sSQL &= "From Object  WITH (NOLOCK)  WHERE ObjectTypeID like '%' " & vbCrLf
        sSQL &= "Order By DisplayOrder,ObjectID" & vbCrLf
        dtObjectID = ReturnDataTable(sSQL)
        LoadDataSource(tdbcObjectID, dtObjectID, gbUnicode)

        'Load ObjectTypeID
        sSQL = "Select 0 as DisplayOrder, '%' ObjectTypeID ,  " & AllName & " As ObjectTypeName" & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQL &= "'<Taát caû>' As ObjectTypeName" & vbCrLf
        'Else
        '    sSQL &= " '<All>' As ObjectTypeName" & vbCrLf
        'End If
        sSQL &= "Union " & vbCrLf
        sSQL &= "Select 1 as DisplayOrder, ObjectTypeID, " & vbCrLf
        If gsLanguage = "84" Then
            sSQL &= "ObjectTypeName"
        Else
            sSQL &= "ObjectTypeName01"
        End If
        sSQL &= sUnicode & "  As ObjectTypeName From D91T0005  WITH (NOLOCK)  " & vbCrLf
        sSQL &= "Order By DisplayOrder, ObjectTypeID" & vbCrLf
        LoadDataSource(tdbcObjectTypeID, sSQL, gbUnicode)
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

    Private Sub tdbcGroupTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.Close
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then tdbcGroupTypeID.Text = ""
    End Sub

    Private Sub tdbcGroupTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.SelectedValueChanged
        LoadDataSource(tdbcACodeID, ReturnTableFilter(dtACodeID, "  TypeCodeID like " & SQLString(ReturnValueC1Combo(tdbcGroupTypeID)) & " Or TypeCodeID = '%'"), gbUnicode) '
        tdbcACodeID.SelectedIndex = 0
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

        Dim sSQL As String = ""
        Dim dt1 As DataTable
        sSQL = ReturnSQLAsset()
        dt1 = ReturnDataTable(sSQL)
        LoadDataSource(tdbcFromAssetID, dt1.DefaultView.ToTable, gbUnicode)
        LoadDataSource(tdbcToAssetID, dt1.DefaultView.ToTable, gbUnicode)
        tdbcFromAssetID.SelectedIndex = 0
        tdbcToAssetID.SelectedIndex = 0
    End Sub

    Private Sub tdbcACodeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcACodeID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
        '    tdbcACodeID.Text = ""
        '    txtDescription.Text = ""
        'End If
    End Sub

#End Region

#Region "Events tdbcObjectTypeID"

    Private Sub tdbcObjectTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcObjectTypeID.Close
        If tdbcObjectTypeID.FindStringExact(tdbcObjectTypeID.Text) = -1 Then tdbcObjectTypeID.Text = ""
    End Sub

    Private Sub tdbcObjectTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcObjectTypeID.SelectedValueChanged
        LoadDataSource(tdbcObjectID, ReturnTableFilter(dtObjectID, "  ObjectTypeID like " & SQLString(tdbcObjectTypeID.Text) & " Or ObjectTypeID = '%'"), gbUnicode) '
        tdbcObjectID.SelectedIndex = 0
    End Sub

    Private Sub tdbcObjectTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcObjectTypeID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcObjectTypeID.Text = ""
    End Sub

#End Region

#Region "Events tdbcObjectID with txtObjectName"

    Private Sub tdbcObjectID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcObjectID.Close
        If tdbcObjectID.FindStringExact(tdbcObjectID.Text) = -1 Then
            tdbcObjectID.Text = ""
            txtObjectName.Text = ""
        End If
    End Sub

    Private Sub tdbcObjectID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcObjectID.SelectedValueChanged
        txtObjectName.Text = tdbcObjectID.Columns(1).Value.ToString
        'Load ACodeID
        Dim sSQL As String = ""
        Dim dt1 As DataTable
        sSQL = ReturnSQLAsset()


        dt1 = ReturnDataTable(sSQL)
        LoadDataSource(tdbcFromAssetID, dt1.DefaultView.ToTable, gbUnicode)
        LoadDataSource(tdbcToAssetID, dt1.DefaultView.ToTable, gbUnicode)

        tdbcFromAssetID.SelectedIndex = 0
        tdbcToAssetID.SelectedIndex = 0
    End Sub

    Private Sub tdbcObjectID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcObjectID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcObjectID.Text = ""
            txtObjectName.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcFromAssetID"

    Private Sub tdbcFromAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.Close
        If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then tdbcFromAssetID.Text = ""
    End Sub

    Private Sub tdbcFromAssetID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.SelectedValueChanged
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Enabled = False
        Else
            tdbcToAssetID.Enabled = True
        End If
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
        If tdbcObjectTypeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Bo_phan_quan_ly"))
            tdbcObjectTypeID.Focus()
            Return False
        End If
        If tdbcObjectID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Bo_phan_quan_ly"))
            tdbcObjectID.Focus()
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

        Return True
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
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""

        Dim sUnicode As String = UnicodeJoin(gbUnicode)
        sSQL = "Select AssetName" & sUnicode & " as AssetName, ObjectName" & sUnicode & " as ObjectName, Notes" & sUnicode & " as Notes, EObjectName" & sUnicode & " as EObjectName,  EquipmentName" & sUnicode & " as EquipmentName, "
        sSQL &= "DivisionID, Group01,Group02,D90_ConvertedDecimals,ExchangeRateDecimals,D07_ConvertedDecimals,"
        sSQL &= "D07_QuantityDecimals,D07_UnitCostDecimals,D08_ConvertedDecimals,D08_QuantityDecimals,D08_UnitCostDecimals,"
        sSQL &= "DecimalSeparator,ThousandSeparator,ExchangeRateDecimails,D08_RatioDecimals,D08_BOMDecimals,AssetID,"
        sSQL &= "ObjectTypeID, ObjectID, Disabled, Acode01ID, Acode02ID, Acode03ID, Acode04ID, Acode05ID,"
        sSQL &= "Acode06ID,Acode07ID,Acode08ID,Acode09ID,Acode10ID,"
        sSQL &= "EquipmentID,Notes,EquipmentQuantity,EquipmentValue,EObjectTypeID,EObjectID,"
        sSQL &= "AssetS1ID, AssetS2ID, AssetS3ID, UsePeriod, TranMonth, TranYear" & vbCrLf
        sSQL &= "From D02V3050" & vbCrLf
        sSQL &= "Where Disabled = 0" & vbCrLf
        sSQL &= "And     DivisionID = " & SQLString(gsDivisionID) & vbCrLf
        If tdbcACodeID.Text <> "%" Then
            sSQL &= "And Case When" & SQLString(tdbcGroupTypeID.Text) & "= 'A01' Then Acode01ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & " = 'A02' Then Acode02ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A03' Then Acode03ID" & vbCrLf
            sSQL &= "When" & SQLString(tdbcGroupTypeID.Text) & "= 'A04' Then Acode04ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A05' Then Acode05ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A06' Then Acode06ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A07' Then Acode07ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A08' Then Acode08ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A09' Then Acode09ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A10' Then Acode10ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS1ID' Then AssetS1ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS2ID' Then AssetS2ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS3ID' Then AssetS3ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & " = '' Or" & SQLString(tdbcGroupTypeID.Text) & " = '%' Then  " & SQLString(tdbcACodeID.Text) & vbCrLf
            sSQL &= "Else " & SQLString(tdbcACodeID.Text) & vbCrLf
            sSQL &= "End =" & SQLString(tdbcACodeID.Text) & vbCrLf
        End If
        sSQL &= "And TranMonth + TranYear * 100 <= " & SQLString(giTranMonth + giTranYear * 100) & vbCrLf
        sSQL &= "And Case    When " & SQLString(tdbcObjectTypeID.Text) & "= '' Or " & SQLString(tdbcObjectTypeID.Text) & " = '%' Then " & SQLString(tdbcObjectTypeID.Text) & vbCrLf
        sSQL &= "Else ObjectTypeID" & vbCrLf
        sSQL &= "End = " & SQLString(tdbcObjectTypeID.Text) & vbCrLf
        sSQL &= "And Case    When " & SQLString(tdbcObjectID.Text) & "= '' Or " & SQLString(tdbcObjectID.Text) & " = '%' Then " & SQLString(tdbcObjectID.Text) & vbCrLf
        sSQL &= "Else ObjectID" & vbCrLf
        sSQL &= "End = " & SQLString(tdbcObjectID.Text) & vbCrLf
        sSQL &= "And Case    When " & SQLString(tdbcFromAssetID.Text) & "= '' Or " & SQLString(tdbcFromAssetID.Text) & " = '%' Then " & SQLString(tdbcFromAssetID.Text) & vbCrLf
        sSQL &= "Else AssetID" & vbCrLf
        sSQL &= "End >= " & SQLString(tdbcFromAssetID.Text) & vbCrLf
        sSQL &= "And Case    When " & SQLString(tdbcToAssetID.Text) & " = '' Or " & SQLString(tdbcToAssetID.Text) & " = '%' Then " & SQLString(tdbcToAssetID.Text) & vbCrLf
        sSQL &= "Else AssetID" & vbCrLf
        If tdbcToAssetID.Text = "" Then
            sSQL &= "End <= '%'" & vbCrLf
        Else
            sSQL &= "End <= " & SQLString(tdbcToAssetID.Text) & vbCrLf
        End If

        sSQL &= "Order By    ObjectTypeID, ObjectID, AssetID, EquipmentID" & vbCrLf

        sSQLSub = "Select Top 1 * from D91T0025  WITH (NOLOCK) "
        UnicodeSubReport(sSubReportName, sSQLSub, gsDivisionID, gbUnicode)

        If tdbcReportID.Text = "" Then
            sReportName = tdbcReportTypeID.Text
            sReportCaption = rl3("Bao_cao_thiet_bi_dinh_kem_tai_san") & " - " & sReportName
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
            sReportName = tdbcReportID.Text
            sReportCaption = rl3("Bao_cao_thiet_bi_dinh_kem_tai_san") & " - " & sReportName
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


    '    sSQL = "Select  * " & vbCrLf
    '    sSQL &= "From D02V3050" & vbCrLf
    '    sSQL &= "Where Disabled = 0" & vbCrLf
    '    sSQL &= "And     DivisionID = " & SQLString(gsDivisionID) & vbCrLf
    '    sSQL &= "And Case When" & SQLString(tdbcGroupTypeID.Text) & "= 'A01' Then Acode01ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & " = 'A02' Then Acode02ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A03' Then Acode03ID" & vbCrLf
    '    sSQL &= "When" & SQLString(tdbcGroupTypeID.Text) & "= 'A04' Then Acode04ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A05' Then Acode05ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A06' Then Acode06ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A07' Then Acode07ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A08' Then Acode08ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A09' Then Acode09ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A10' Then Acode10ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS1ID' Then AssetS1ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS2ID' Then AssetS2ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS3ID' Then AssetS3ID" & vbCrLf
    '    sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & " = '' Or" & SQLString(tdbcGroupTypeID.Text) & " = '%' Then  " & SQLString(tdbcACodeID.Text) & vbCrLf
    '    sSQL &= "Else " & SQLString(tdbcACodeID.Text) & vbCrLf
    '    sSQL &= "End =" & SQLString(tdbcACodeID.Text) & vbCrLf
    '    sSQL &= "And Case    When " & SQLString(tdbcObjectTypeID.Text) & "= '' Or " & SQLString(tdbcObjectTypeID.Text) & " = '%' Then " & SQLString(tdbcObjectTypeID.Text) & vbCrLf
    '    sSQL &= "Else ObjectTypeID" & vbCrLf
    '    sSQL &= "End = " & SQLString(tdbcObjectTypeID.Text) & vbCrLf
    '    sSQL &= "And Case    When " & SQLString(tdbcObjectID.Text) & "= '' Or " & SQLString(tdbcObjectID.Text) & " = '%' Then " & SQLString(tdbcObjectID.Text) & vbCrLf
    '    sSQL &= "Else ObjectID" & vbCrLf
    '    sSQL &= "End = " & SQLString(tdbcObjectID.Text) & vbCrLf
    '    sSQL &= "And Case    When " & SQLString(tdbcFromAssetID.Text) & "= '' Or " & SQLString(tdbcFromAssetID.Text) & " = '%' Then " & SQLString(tdbcFromAssetID.Text) & vbCrLf
    '    sSQL &= "Else AssetID" & vbCrLf
    '    sSQL &= "End >= " & SQLString(tdbcFromAssetID.Text) & vbCrLf
    '    sSQL &= "And Case    When " & SQLString(tdbcToAssetID.Text) & " = '' Or " & SQLString(tdbcToAssetID.Text) & " = '%' Then " & SQLString(tdbcToAssetID.Text) & vbCrLf
    '    sSQL &= "Else AssetID" & vbCrLf
    '    If tdbcToAssetID.Text = "" Then
    '        sSQL &= "End <= '%'" & vbCrLf
    '    Else
    '        sSQL &= "End <= " & SQLString(tdbcToAssetID.Text) & vbCrLf
    '    End If

    '    sSQL &= "Order By    ObjectTypeID, ObjectID, AssetID, EquipmentID" & vbCrLf

    '    sSQLSub = "Select Top 1 * from D91T0025  WITH (NOLOCK) "
    '    If tdbcReportID.Text = "" Then
    '        sReportName = tdbcReportTypeID.Text
    '        sReportCaption = rl3("Bao_cao_thiet_bi_dinh_kem_tai_san") & " - " & sReportName

    '        With reportWS
    '            .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '            .AddSub(sSQLSub, sSubReportName & ".rpt")
    '            .AddMain(sSQL)
    '            .PrintReport(sReportName & ".rpt", sReportCaption)
    '        End With
    '    Else
    '        sReportName = tdbcReportID.Text
    '        sReportCaption = rl3("Bao_cao_thiet_bi_dinh_kem_tai_san") & " - " & sReportName
    '        With reportWS
    '            .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '            .AddSub(sSQLSub, sSubReportName & ".rpt")
    '            .AddMain(sSQL)
    '            .PrintReport(sReportName & ".rpt", sReportCaption)
    '        End With
    '    End If
    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

    Private Function ReturnSQLAsset() As String
        Dim sSQL As String = ""
        sSQL = "Select  0 as DisplayOrder,'%' AssetID," & AllName & "  As AssetName" & vbCrLf
        'If gsLanguage = "84" Then
        '    sSQL &= " 'Taát caû'  As AssetName" & vbCrLf
        'Else
        '    sSQL &= " 'All'  As AssetName" & vbCrLf
        'End If
        sSQL &= "Union" & vbCrLf
        sSQL &= "Select  1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        sSQL &= "From    D02N0019(" & SQLString(giTranMonth) & "," & SQLString(giTranYear) & ")" & vbCrLf
        sSQL &= "Where Disabled = 0" & vbCrLf
        sSQL &= "And     DivisionID = " & SQLString(gsDivisionID) & vbCrLf
        If tdbcACodeID.Text <> "%" Then
            sSQL &= "And   Case    	When" & SQLString(tdbcGroupTypeID.Text) & "= 'A01' Then Acode01ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & " = 'A02' Then Acode02ID" & vbCrLf
            sSQL &= "When" & SQLString(tdbcGroupTypeID.Text) & "= 'A03' Then Acode03ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A04' Then Acode04ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A05' Then Acode05ID" & vbCrLf
            sSQL &= "When" & SQLString(tdbcGroupTypeID.Text) & "= 'A06' Then Acode06ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A07' Then Acode07ID" & vbCrLf
            sSQL &= "When" & SQLString(tdbcGroupTypeID.Text) & "= 'A08' Then Acode08ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'A09' Then Acode09ID" & vbCrLf
            sSQL &= "When" & SQLString(tdbcGroupTypeID.Text) & "= 'A10' Then Acode10ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS1ID' Then AssetS1ID" & vbCrLf
            sSQL &= "When" & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS2ID' Then AssetS2ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & "= 'AssetS3ID' Then AssetS3ID" & vbCrLf
            sSQL &= "When " & SQLString(tdbcGroupTypeID.Text) & " = '' Or " & SQLString(tdbcGroupTypeID.Text) & " = '%'	Then " & SQLString(tdbcACodeID.Text) & vbCrLf
            sSQL &= "Else    " & SQLString(tdbcACodeID.Text) & vbCrLf
            sSQL &= " End = " & SQLString(tdbcACodeID.Text) & vbCrLf
        End If
        sSQL &= "And   Case When" & SQLString(tdbcObjectTypeID.Text) & " = '' Or " & SQLString(tdbcObjectTypeID.Text) & " = '%' Then " & SQLString(tdbcObjectTypeID.Text) & vbCrLf

        sSQL &= " Else ObjectTypeID" & vbCrLf
        sSQL &= " End = " & SQLString(tdbcObjectTypeID.Text) & vbCrLf
        sSQL &= "And   Case When" & SQLString(tdbcObjectID.Text) & " = '' Or " & SQLString(tdbcObjectID.Text) & " = '%' Then " & SQLString(tdbcObjectID.Text) & vbCrLf
        sSQL &= " Else ObjectID" & vbCrLf
        sSQL &= " End = " & SQLString(tdbcObjectID.Text) & vbCrLf
        sSQL &= "Order By DisplayOrder,AssetID" & vbCrLf
        ReturnSQLAsset = sSQL
    End Function

End Class