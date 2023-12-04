<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3012
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3012))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tdbcReportID = New C1.Win.C1List.C1Combo()
        Me.txtReportTypeName = New System.Windows.Forms.TextBox()
        Me.txtReportTypeID = New System.Windows.Forms.TextBox()
        Me.lblReportTypeID = New System.Windows.Forms.Label()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.tdbcToPeriodID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromPeriodID = New C1.Win.C1List.C1Combo()
        Me.tdbcToObjectID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromObjectID = New C1.Win.C1List.C1Combo()
        Me.tdbcObjectTypeID = New C1.Win.C1List.C1Combo()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.lblDivisionID = New System.Windows.Forms.Label()
        Me.lblObjectTypeID = New System.Windows.Forms.Label()
        Me.txtObjectTypeName = New System.Windows.Forms.TextBox()
        Me.lblFromObjectID = New System.Windows.Forms.Label()
        Me.lblFromPeriodID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDefineData = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcToObjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromObjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcObjectTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tdbcReportID)
        Me.GroupBox1.Controls.Add(Me.txtReportTypeName)
        Me.GroupBox1.Controls.Add(Me.txtReportTypeID)
        Me.GroupBox1.Controls.Add(Me.lblReportTypeID)
        Me.GroupBox1.Controls.Add(Me.lblReportID)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dạng báo cáo"
        '
        'tdbcReportID
        '
        Me.tdbcReportID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportID.AllowColMove = False
        Me.tdbcReportID.AllowSort = False
        Me.tdbcReportID.AlternatingRows = True
        Me.tdbcReportID.AutoCompletion = True
        Me.tdbcReportID.AutoDropDown = True
        Me.tdbcReportID.Caption = ""
        Me.tdbcReportID.CaptionHeight = 17
        Me.tdbcReportID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportID.ColumnCaptionHeight = 17
        Me.tdbcReportID.ColumnFooterHeight = 17
        Me.tdbcReportID.ColumnWidth = 100
        Me.tdbcReportID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportID.DisplayMember = "ReportID"
        Me.tdbcReportID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportID.DropDownWidth = 300
        Me.tdbcReportID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportID.EmptyRows = True
        Me.tdbcReportID.ExtendRightColumn = True
        Me.tdbcReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.Images.Add(CType(resources.GetObject("tdbcReportID.Images"), System.Drawing.Image))
        Me.tdbcReportID.ItemHeight = 15
        Me.tdbcReportID.Location = New System.Drawing.Point(94, 47)
        Me.tdbcReportID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportID.MaxLength = 20
        Me.tdbcReportID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportID.Name = "tdbcReportID"
        Me.tdbcReportID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportID.Size = New System.Drawing.Size(101, 23)
        Me.tdbcReportID.TabIndex = 5
        Me.tdbcReportID.ValueMember = "ReportID"
        Me.tdbcReportID.PropBag = resources.GetString("tdbcReportID.PropBag")
        '
        'txtReportTypeName
        '
        Me.txtReportTypeName.Enabled = False
        Me.txtReportTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportTypeName.Location = New System.Drawing.Point(200, 19)
        Me.txtReportTypeName.MaxLength = 250
        Me.txtReportTypeName.Name = "txtReportTypeName"
        Me.txtReportTypeName.Size = New System.Drawing.Size(314, 22)
        Me.txtReportTypeName.TabIndex = 2
        '
        'txtReportTypeID
        '
        Me.txtReportTypeID.Enabled = False
        Me.txtReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtReportTypeID.Location = New System.Drawing.Point(94, 19)
        Me.txtReportTypeID.MaxLength = 20
        Me.txtReportTypeID.Name = "txtReportTypeID"
        Me.txtReportTypeID.Size = New System.Drawing.Size(101, 22)
        Me.txtReportTypeID.TabIndex = 0
        '
        'lblReportTypeID
        '
        Me.lblReportTypeID.AutoSize = True
        Me.lblReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTypeID.Location = New System.Drawing.Point(6, 24)
        Me.lblReportTypeID.Name = "lblReportTypeID"
        Me.lblReportTypeID.Size = New System.Drawing.Size(61, 13)
        Me.lblReportTypeID.TabIndex = 1
        Me.lblReportTypeID.Text = "Mẫu chuẩn"
        Me.lblReportTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID.Location = New System.Drawing.Point(6, 52)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(45, 13)
        Me.lblReportID.TabIndex = 4
        Me.lblReportID.Text = "Đặc thù"
        Me.lblReportID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTitle.Location = New System.Drawing.Point(200, 47)
        Me.txtTitle.MaxLength = 250
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(314, 22)
        Me.txtTitle.TabIndex = 6
        Me.txtTitle.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLabel2)
        Me.GroupBox2.Controls.Add(Me.lblLabel1)
        Me.GroupBox2.Controls.Add(Me.tdbcToPeriodID)
        Me.GroupBox2.Controls.Add(Me.tdbcFromPeriodID)
        Me.GroupBox2.Controls.Add(Me.tdbcToObjectID)
        Me.GroupBox2.Controls.Add(Me.tdbcFromObjectID)
        Me.GroupBox2.Controls.Add(Me.tdbcObjectTypeID)
        Me.GroupBox2.Controls.Add(Me.tdbcDivisionID)
        Me.GroupBox2.Controls.Add(Me.lblDivisionID)
        Me.GroupBox2.Controls.Add(Me.lblObjectTypeID)
        Me.GroupBox2.Controls.Add(Me.txtObjectTypeName)
        Me.GroupBox2.Controls.Add(Me.lblFromObjectID)
        Me.GroupBox2.Controls.Add(Me.lblFromPeriodID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 142)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Điều kiện lọc"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(263, 112)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel2.TabIndex = 13
        Me.lblLabel2.Text = "---"
        Me.lblLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(263, 82)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel1.TabIndex = 12
        Me.lblLabel1.Text = "---"
        Me.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcToPeriodID
        '
        Me.tdbcToPeriodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToPeriodID.AllowColMove = False
        Me.tdbcToPeriodID.AllowSort = False
        Me.tdbcToPeriodID.AlternatingRows = True
        Me.tdbcToPeriodID.AutoCompletion = True
        Me.tdbcToPeriodID.AutoDropDown = True
        Me.tdbcToPeriodID.AutoSelect = True
        Me.tdbcToPeriodID.Caption = ""
        Me.tdbcToPeriodID.CaptionHeight = 17
        Me.tdbcToPeriodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToPeriodID.ColumnCaptionHeight = 17
        Me.tdbcToPeriodID.ColumnFooterHeight = 17
        Me.tdbcToPeriodID.ColumnHeaders = False
        Me.tdbcToPeriodID.ColumnWidth = 100
        Me.tdbcToPeriodID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToPeriodID.DisplayMember = "Period"
        Me.tdbcToPeriodID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToPeriodID.DropDownWidth = 128
        Me.tdbcToPeriodID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToPeriodID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToPeriodID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToPeriodID.EmptyRows = True
        Me.tdbcToPeriodID.ExtendRightColumn = True
        Me.tdbcToPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToPeriodID.Images.Add(CType(resources.GetObject("tdbcToPeriodID.Images"), System.Drawing.Image))
        Me.tdbcToPeriodID.ItemHeight = 15
        Me.tdbcToPeriodID.Location = New System.Drawing.Point(314, 106)
        Me.tdbcToPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToPeriodID.MaxLength = 20
        Me.tdbcToPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToPeriodID.Name = "tdbcToPeriodID"
        Me.tdbcToPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToPeriodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcToPeriodID.TabIndex = 11
        Me.tdbcToPeriodID.ValueMember = "Period"
        Me.tdbcToPeriodID.PropBag = resources.GetString("tdbcToPeriodID.PropBag")
        '
        'tdbcFromPeriodID
        '
        Me.tdbcFromPeriodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromPeriodID.AllowColMove = False
        Me.tdbcFromPeriodID.AllowSort = False
        Me.tdbcFromPeriodID.AlternatingRows = True
        Me.tdbcFromPeriodID.AutoCompletion = True
        Me.tdbcFromPeriodID.AutoDropDown = True
        Me.tdbcFromPeriodID.AutoSelect = True
        Me.tdbcFromPeriodID.Caption = ""
        Me.tdbcFromPeriodID.CaptionHeight = 17
        Me.tdbcFromPeriodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromPeriodID.ColumnCaptionHeight = 17
        Me.tdbcFromPeriodID.ColumnFooterHeight = 17
        Me.tdbcFromPeriodID.ColumnHeaders = False
        Me.tdbcFromPeriodID.ColumnWidth = 100
        Me.tdbcFromPeriodID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromPeriodID.DisplayMember = "Period"
        Me.tdbcFromPeriodID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromPeriodID.DropDownWidth = 128
        Me.tdbcFromPeriodID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromPeriodID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromPeriodID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromPeriodID.EmptyRows = True
        Me.tdbcFromPeriodID.ExtendRightColumn = True
        Me.tdbcFromPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromPeriodID.Images.Add(CType(resources.GetObject("tdbcFromPeriodID.Images"), System.Drawing.Image))
        Me.tdbcFromPeriodID.ItemHeight = 15
        Me.tdbcFromPeriodID.Location = New System.Drawing.Point(94, 106)
        Me.tdbcFromPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromPeriodID.MaxLength = 20
        Me.tdbcFromPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromPeriodID.Name = "tdbcFromPeriodID"
        Me.tdbcFromPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromPeriodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcFromPeriodID.TabIndex = 9
        Me.tdbcFromPeriodID.ValueMember = "Period"
        Me.tdbcFromPeriodID.PropBag = resources.GetString("tdbcFromPeriodID.PropBag")
        '
        'tdbcToObjectID
        '
        Me.tdbcToObjectID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToObjectID.AllowColMove = False
        Me.tdbcToObjectID.AllowSort = False
        Me.tdbcToObjectID.AlternatingRows = True
        Me.tdbcToObjectID.AutoCompletion = True
        Me.tdbcToObjectID.AutoDropDown = True
        Me.tdbcToObjectID.Caption = ""
        Me.tdbcToObjectID.CaptionHeight = 17
        Me.tdbcToObjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToObjectID.ColumnCaptionHeight = 17
        Me.tdbcToObjectID.ColumnFooterHeight = 17
        Me.tdbcToObjectID.ColumnWidth = 100
        Me.tdbcToObjectID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToObjectID.DisplayMember = "ObjectID"
        Me.tdbcToObjectID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToObjectID.DropDownWidth = 300
        Me.tdbcToObjectID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToObjectID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToObjectID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToObjectID.EmptyRows = True
        Me.tdbcToObjectID.ExtendRightColumn = True
        Me.tdbcToObjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToObjectID.Images.Add(CType(resources.GetObject("tdbcToObjectID.Images"), System.Drawing.Image))
        Me.tdbcToObjectID.ItemHeight = 15
        Me.tdbcToObjectID.Location = New System.Drawing.Point(314, 77)
        Me.tdbcToObjectID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToObjectID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToObjectID.MaxLength = 20
        Me.tdbcToObjectID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToObjectID.Name = "tdbcToObjectID"
        Me.tdbcToObjectID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToObjectID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToObjectID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcToObjectID.TabIndex = 8
        Me.tdbcToObjectID.ValueMember = "ObjectID"
        Me.tdbcToObjectID.PropBag = resources.GetString("tdbcToObjectID.PropBag")
        '
        'tdbcFromObjectID
        '
        Me.tdbcFromObjectID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromObjectID.AllowColMove = False
        Me.tdbcFromObjectID.AllowSort = False
        Me.tdbcFromObjectID.AlternatingRows = True
        Me.tdbcFromObjectID.AutoCompletion = True
        Me.tdbcFromObjectID.AutoDropDown = True
        Me.tdbcFromObjectID.Caption = ""
        Me.tdbcFromObjectID.CaptionHeight = 17
        Me.tdbcFromObjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromObjectID.ColumnCaptionHeight = 17
        Me.tdbcFromObjectID.ColumnFooterHeight = 17
        Me.tdbcFromObjectID.ColumnWidth = 100
        Me.tdbcFromObjectID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromObjectID.DisplayMember = "ObjectID"
        Me.tdbcFromObjectID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromObjectID.DropDownWidth = 300
        Me.tdbcFromObjectID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromObjectID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromObjectID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromObjectID.EmptyRows = True
        Me.tdbcFromObjectID.ExtendRightColumn = True
        Me.tdbcFromObjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromObjectID.Images.Add(CType(resources.GetObject("tdbcFromObjectID.Images"), System.Drawing.Image))
        Me.tdbcFromObjectID.ItemHeight = 15
        Me.tdbcFromObjectID.Location = New System.Drawing.Point(94, 77)
        Me.tdbcFromObjectID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromObjectID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromObjectID.MaxLength = 20
        Me.tdbcFromObjectID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromObjectID.Name = "tdbcFromObjectID"
        Me.tdbcFromObjectID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromObjectID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromObjectID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcFromObjectID.TabIndex = 6
        Me.tdbcFromObjectID.ValueMember = "ObjectID"
        Me.tdbcFromObjectID.PropBag = resources.GetString("tdbcFromObjectID.PropBag")
        '
        'tdbcObjectTypeID
        '
        Me.tdbcObjectTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcObjectTypeID.AllowColMove = False
        Me.tdbcObjectTypeID.AllowSort = False
        Me.tdbcObjectTypeID.AlternatingRows = True
        Me.tdbcObjectTypeID.AutoCompletion = True
        Me.tdbcObjectTypeID.AutoDropDown = True
        Me.tdbcObjectTypeID.Caption = ""
        Me.tdbcObjectTypeID.CaptionHeight = 17
        Me.tdbcObjectTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcObjectTypeID.ColumnCaptionHeight = 17
        Me.tdbcObjectTypeID.ColumnFooterHeight = 17
        Me.tdbcObjectTypeID.ColumnWidth = 100
        Me.tdbcObjectTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcObjectTypeID.DisplayMember = "ObjectTypeID"
        Me.tdbcObjectTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcObjectTypeID.DropDownWidth = 300
        Me.tdbcObjectTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcObjectTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcObjectTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcObjectTypeID.EmptyRows = True
        Me.tdbcObjectTypeID.ExtendRightColumn = True
        Me.tdbcObjectTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcObjectTypeID.Images.Add(CType(resources.GetObject("tdbcObjectTypeID.Images"), System.Drawing.Image))
        Me.tdbcObjectTypeID.ItemHeight = 15
        Me.tdbcObjectTypeID.Location = New System.Drawing.Point(94, 48)
        Me.tdbcObjectTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcObjectTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcObjectTypeID.MaxLength = 20
        Me.tdbcObjectTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcObjectTypeID.Name = "tdbcObjectTypeID"
        Me.tdbcObjectTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcObjectTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcObjectTypeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcObjectTypeID.TabIndex = 3
        Me.tdbcObjectTypeID.ValueMember = "ObjectTypeID"
        Me.tdbcObjectTypeID.PropBag = resources.GetString("tdbcObjectTypeID.PropBag")
        '
        'tdbcDivisionID
        '
        Me.tdbcDivisionID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDivisionID.AllowColMove = False
        Me.tdbcDivisionID.AllowSort = False
        Me.tdbcDivisionID.AlternatingRows = True
        Me.tdbcDivisionID.AutoCompletion = True
        Me.tdbcDivisionID.AutoDropDown = True
        Me.tdbcDivisionID.Caption = ""
        Me.tdbcDivisionID.CaptionHeight = 17
        Me.tdbcDivisionID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDivisionID.ColumnCaptionHeight = 17
        Me.tdbcDivisionID.ColumnFooterHeight = 17
        Me.tdbcDivisionID.ColumnWidth = 100
        Me.tdbcDivisionID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDivisionID.DisplayMember = "DivisionName"
        Me.tdbcDivisionID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDivisionID.DropDownWidth = 300
        Me.tdbcDivisionID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDivisionID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDivisionID.EmptyRows = True
        Me.tdbcDivisionID.ExtendRightColumn = True
        Me.tdbcDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.Images.Add(CType(resources.GetObject("tdbcDivisionID.Images"), System.Drawing.Image))
        Me.tdbcDivisionID.ItemHeight = 15
        Me.tdbcDivisionID.Location = New System.Drawing.Point(94, 19)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 20
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcDivisionID.TabIndex = 0
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'lblDivisionID
        '
        Me.lblDivisionID.AutoSize = True
        Me.lblDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionID.Location = New System.Drawing.Point(6, 24)
        Me.lblDivisionID.Name = "lblDivisionID"
        Me.lblDivisionID.Size = New System.Drawing.Size(38, 13)
        Me.lblDivisionID.TabIndex = 1
        Me.lblDivisionID.Text = "Đơn vị"
        Me.lblDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObjectTypeID
        '
        Me.lblObjectTypeID.AutoSize = True
        Me.lblObjectTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectTypeID.Location = New System.Drawing.Point(6, 53)
        Me.lblObjectTypeID.Name = "lblObjectTypeID"
        Me.lblObjectTypeID.Size = New System.Drawing.Size(75, 13)
        Me.lblObjectTypeID.TabIndex = 4
        Me.lblObjectTypeID.Text = "Loại đối tượng"
        Me.lblObjectTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObjectTypeName
        '
        Me.txtObjectTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtObjectTypeName.Location = New System.Drawing.Point(228, 48)
        Me.txtObjectTypeName.MaxLength = 250
        Me.txtObjectTypeName.Name = "txtObjectTypeName"
        Me.txtObjectTypeName.ReadOnly = True
        Me.txtObjectTypeName.Size = New System.Drawing.Size(286, 22)
        Me.txtObjectTypeName.TabIndex = 5
        Me.txtObjectTypeName.TabStop = False
        '
        'lblFromObjectID
        '
        Me.lblFromObjectID.AutoSize = True
        Me.lblFromObjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromObjectID.Location = New System.Drawing.Point(6, 82)
        Me.lblFromObjectID.Name = "lblFromObjectID"
        Me.lblFromObjectID.Size = New System.Drawing.Size(53, 13)
        Me.lblFromObjectID.TabIndex = 7
        Me.lblFromObjectID.Text = "Đối tượng"
        Me.lblFromObjectID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFromPeriodID
        '
        Me.lblFromPeriodID.AutoSize = True
        Me.lblFromPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromPeriodID.Location = New System.Drawing.Point(6, 111)
        Me.lblFromPeriodID.Name = "lblFromPeriodID"
        Me.lblFromPeriodID.Size = New System.Drawing.Size(19, 13)
        Me.lblFromPeriodID.TabIndex = 10
        Me.lblFromPeriodID.Text = "Kỳ"
        Me.lblFromPeriodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(378, 239)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 22)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(456, 239)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 22)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDefineData
        '
        Me.btnDefineData.Location = New System.Drawing.Point(10, 239)
        Me.btnDefineData.Name = "btnDefineData"
        Me.btnDefineData.Size = New System.Drawing.Size(145, 22)
        Me.btnDefineData.TabIndex = 4
        Me.btnDefineData.Text = "&Định nghĩa dữ liệu"
        Me.btnDefineData.UseVisualStyleBackColor = True
        '
        'D02F3012
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 267)
        Me.Controls.Add(Me.btnDefineData)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3012"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÀo cÀo tŸng gi¶m TSC˜ - D02F3012"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcToObjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromObjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcObjectTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtReportTypeName As System.Windows.Forms.TextBox
    Private WithEvents txtReportTypeID As System.Windows.Forms.TextBox
    Private WithEvents lblReportTypeID As System.Windows.Forms.Label
    Private WithEvents tdbcReportID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents lblDivisionID As System.Windows.Forms.Label
    Private WithEvents tdbcObjectTypeID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcToObjectID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromObjectID As C1.Win.C1List.C1Combo
    Private WithEvents lblObjectTypeID As System.Windows.Forms.Label
    Private WithEvents txtObjectTypeName As System.Windows.Forms.TextBox
    Private WithEvents lblFromObjectID As System.Windows.Forms.Label
    Private WithEvents lblFromPeriodID As System.Windows.Forms.Label
    Private WithEvents tdbcToPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents lblLabel2 As System.Windows.Forms.Label
    Private WithEvents lblLabel1 As System.Windows.Forms.Label
    Private WithEvents btnDefineData As System.Windows.Forms.Button
End Class