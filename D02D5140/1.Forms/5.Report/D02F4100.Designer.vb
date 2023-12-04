<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F4100
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F4100))
        Me.tdbcPeriodTo = New C1.Win.C1List.C1Combo()
        Me.lblGroupTime = New System.Windows.Forms.Label()
        Me.grp4 = New System.Windows.Forms.GroupBox()
        Me.tdbcPeriodFrom = New C1.Win.C1List.C1Combo()
        Me.grp3 = New System.Windows.Forms.GroupBox()
        Me.lblGroupFilter = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.tdbcAssetIDTo = New C1.Win.C1List.C1Combo()
        Me.tdbcAssetIDFrom = New C1.Win.C1List.C1Combo()
        Me.tdbcACodeID = New C1.Win.C1List.C1Combo()
        Me.tdbcGroupTypeID = New C1.Win.C1List.C1Combo()
        Me.lblGroupTypeID = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblAssetID = New System.Windows.Forms.Label()
        Me.grp2 = New System.Windows.Forms.GroupBox()
        Me.tdbcCustomizeReportID = New C1.Win.C1List.C1Combo()
        Me.txtReportName = New System.Windows.Forms.TextBox()
        Me.lblGroupReport = New System.Windows.Forms.Label()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.lblCustomizeReport = New System.Windows.Forms.Label()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomizeReportName = New System.Windows.Forms.TextBox()
        Me.lblGroupDivisionID = New System.Windows.Forms.Label()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.lblDivisionID = New System.Windows.Forms.Label()
        Me.txtDivisionName = New System.Windows.Forms.TextBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtReportID = New System.Windows.Forms.TextBox()
        CType(Me.tdbcPeriodTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcPeriodFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcAssetIDTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcAssetIDFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcCustomizeReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdbcPeriodTo
        '
        Me.tdbcPeriodTo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcPeriodTo.AllowColMove = False
        Me.tdbcPeriodTo.AllowSort = False
        Me.tdbcPeriodTo.AlternatingRows = True
        Me.tdbcPeriodTo.AutoCompletion = True
        Me.tdbcPeriodTo.AutoDropDown = True
        Me.tdbcPeriodTo.Caption = ""
        Me.tdbcPeriodTo.CaptionHeight = 17
        Me.tdbcPeriodTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcPeriodTo.ColumnCaptionHeight = 17
        Me.tdbcPeriodTo.ColumnFooterHeight = 17
        Me.tdbcPeriodTo.ColumnHeaders = False
        Me.tdbcPeriodTo.ColumnWidth = 100
        Me.tdbcPeriodTo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcPeriodTo.DisplayMember = "Period"
        Me.tdbcPeriodTo.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcPeriodTo.DropDownWidth = 128
        Me.tdbcPeriodTo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcPeriodTo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodTo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcPeriodTo.EmptyRows = True
        Me.tdbcPeriodTo.ExtendRightColumn = True
        Me.tdbcPeriodTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodTo.Images.Add(CType(resources.GetObject("tdbcPeriodTo.Images"), System.Drawing.Image))
        Me.tdbcPeriodTo.ItemHeight = 15
        Me.tdbcPeriodTo.Location = New System.Drawing.Point(274, 279)
        Me.tdbcPeriodTo.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcPeriodTo.MaxDropDownItems = CType(8, Short)
        Me.tdbcPeriodTo.MaxLength = 32767
        Me.tdbcPeriodTo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcPeriodTo.Name = "tdbcPeriodTo"
        Me.tdbcPeriodTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcPeriodTo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcPeriodTo.Size = New System.Drawing.Size(135, 23)
        Me.tdbcPeriodTo.TabIndex = 28
        Me.tdbcPeriodTo.ValueMember = "Period"
        Me.tdbcPeriodTo.PropBag = resources.GetString("tdbcPeriodTo.PropBag")
        '
        'lblGroupTime
        '
        Me.lblGroupTime.AutoSize = True
        Me.lblGroupTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupTime.Location = New System.Drawing.Point(11, 250)
        Me.lblGroupTime.Name = "lblGroupTime"
        Me.lblGroupTime.Size = New System.Drawing.Size(129, 13)
        Me.lblGroupTime.TabIndex = 24
        Me.lblGroupTime.Text = "4. Thông tin thời gian"
        Me.lblGroupTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grp4
        '
        Me.grp4.Location = New System.Drawing.Point(148, 260)
        Me.grp4.Name = "grp4"
        Me.grp4.Size = New System.Drawing.Size(453, 3)
        Me.grp4.TabIndex = 25
        Me.grp4.TabStop = False
        '
        'tdbcPeriodFrom
        '
        Me.tdbcPeriodFrom.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcPeriodFrom.AllowColMove = False
        Me.tdbcPeriodFrom.AllowSort = False
        Me.tdbcPeriodFrom.AlternatingRows = True
        Me.tdbcPeriodFrom.AutoCompletion = True
        Me.tdbcPeriodFrom.AutoDropDown = True
        Me.tdbcPeriodFrom.Caption = ""
        Me.tdbcPeriodFrom.CaptionHeight = 17
        Me.tdbcPeriodFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcPeriodFrom.ColumnCaptionHeight = 17
        Me.tdbcPeriodFrom.ColumnFooterHeight = 17
        Me.tdbcPeriodFrom.ColumnHeaders = False
        Me.tdbcPeriodFrom.ColumnWidth = 100
        Me.tdbcPeriodFrom.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcPeriodFrom.DisplayMember = "Period"
        Me.tdbcPeriodFrom.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcPeriodFrom.DropDownWidth = 128
        Me.tdbcPeriodFrom.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcPeriodFrom.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodFrom.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcPeriodFrom.EmptyRows = True
        Me.tdbcPeriodFrom.ExtendRightColumn = True
        Me.tdbcPeriodFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodFrom.Images.Add(CType(resources.GetObject("tdbcPeriodFrom.Images"), System.Drawing.Image))
        Me.tdbcPeriodFrom.ItemHeight = 15
        Me.tdbcPeriodFrom.Location = New System.Drawing.Point(134, 279)
        Me.tdbcPeriodFrom.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcPeriodFrom.MaxDropDownItems = CType(8, Short)
        Me.tdbcPeriodFrom.MaxLength = 32767
        Me.tdbcPeriodFrom.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcPeriodFrom.Name = "tdbcPeriodFrom"
        Me.tdbcPeriodFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcPeriodFrom.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcPeriodFrom.Size = New System.Drawing.Size(135, 23)
        Me.tdbcPeriodFrom.TabIndex = 27
        Me.tdbcPeriodFrom.ValueMember = "Period"
        Me.tdbcPeriodFrom.PropBag = resources.GetString("tdbcPeriodFrom.PropBag")
        '
        'grp3
        '
        Me.grp3.Location = New System.Drawing.Point(118, 169)
        Me.grp3.Name = "grp3"
        Me.grp3.Size = New System.Drawing.Size(483, 3)
        Me.grp3.TabIndex = 15
        Me.grp3.TabStop = False
        '
        'lblGroupFilter
        '
        Me.lblGroupFilter.AutoSize = True
        Me.lblGroupFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupFilter.Location = New System.Drawing.Point(11, 159)
        Me.lblGroupFilter.Name = "lblGroupFilter"
        Me.lblGroupFilter.Size = New System.Drawing.Size(97, 13)
        Me.lblGroupFilter.TabIndex = 14
        Me.lblGroupFilter.Text = "3. Tiêu thức lọc"
        Me.lblGroupFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(362, 223)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(16, 13)
        Me.lblLine.TabIndex = 22
        Me.lblLine.Text = "---"
        Me.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcAssetIDTo
        '
        Me.tdbcAssetIDTo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcAssetIDTo.AllowColMove = False
        Me.tdbcAssetIDTo.AllowSort = False
        Me.tdbcAssetIDTo.AlternatingRows = True
        Me.tdbcAssetIDTo.AutoCompletion = True
        Me.tdbcAssetIDTo.AutoDropDown = True
        Me.tdbcAssetIDTo.Caption = ""
        Me.tdbcAssetIDTo.CaptionHeight = 17
        Me.tdbcAssetIDTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcAssetIDTo.ColumnCaptionHeight = 17
        Me.tdbcAssetIDTo.ColumnFooterHeight = 17
        Me.tdbcAssetIDTo.ColumnWidth = 100
        Me.tdbcAssetIDTo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcAssetIDTo.DisplayMember = "AssetID"
        Me.tdbcAssetIDTo.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcAssetIDTo.DropDownWidth = 300
        Me.tdbcAssetIDTo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcAssetIDTo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetIDTo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcAssetIDTo.EmptyRows = True
        Me.tdbcAssetIDTo.ExtendRightColumn = True
        Me.tdbcAssetIDTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetIDTo.Images.Add(CType(resources.GetObject("tdbcAssetIDTo.Images"), System.Drawing.Image))
        Me.tdbcAssetIDTo.ItemHeight = 15
        Me.tdbcAssetIDTo.Location = New System.Drawing.Point(414, 218)
        Me.tdbcAssetIDTo.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcAssetIDTo.MaxDropDownItems = CType(8, Short)
        Me.tdbcAssetIDTo.MaxLength = 20
        Me.tdbcAssetIDTo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcAssetIDTo.Name = "tdbcAssetIDTo"
        Me.tdbcAssetIDTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcAssetIDTo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcAssetIDTo.Size = New System.Drawing.Size(188, 23)
        Me.tdbcAssetIDTo.TabIndex = 23
        Me.tdbcAssetIDTo.ValueMember = "AssetID"
        Me.tdbcAssetIDTo.PropBag = resources.GetString("tdbcAssetIDTo.PropBag")
        '
        'tdbcAssetIDFrom
        '
        Me.tdbcAssetIDFrom.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcAssetIDFrom.AllowColMove = False
        Me.tdbcAssetIDFrom.AllowSort = False
        Me.tdbcAssetIDFrom.AlternatingRows = True
        Me.tdbcAssetIDFrom.AutoCompletion = True
        Me.tdbcAssetIDFrom.AutoDropDown = True
        Me.tdbcAssetIDFrom.Caption = ""
        Me.tdbcAssetIDFrom.CaptionHeight = 17
        Me.tdbcAssetIDFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcAssetIDFrom.ColumnCaptionHeight = 17
        Me.tdbcAssetIDFrom.ColumnFooterHeight = 17
        Me.tdbcAssetIDFrom.ColumnWidth = 100
        Me.tdbcAssetIDFrom.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcAssetIDFrom.DisplayMember = "AssetID"
        Me.tdbcAssetIDFrom.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcAssetIDFrom.DropDownWidth = 300
        Me.tdbcAssetIDFrom.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcAssetIDFrom.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetIDFrom.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcAssetIDFrom.EmptyRows = True
        Me.tdbcAssetIDFrom.ExtendRightColumn = True
        Me.tdbcAssetIDFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcAssetIDFrom.Images.Add(CType(resources.GetObject("tdbcAssetIDFrom.Images"), System.Drawing.Image))
        Me.tdbcAssetIDFrom.ItemHeight = 15
        Me.tdbcAssetIDFrom.Location = New System.Drawing.Point(134, 218)
        Me.tdbcAssetIDFrom.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcAssetIDFrom.MaxDropDownItems = CType(8, Short)
        Me.tdbcAssetIDFrom.MaxLength = 20
        Me.tdbcAssetIDFrom.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcAssetIDFrom.Name = "tdbcAssetIDFrom"
        Me.tdbcAssetIDFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcAssetIDFrom.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcAssetIDFrom.Size = New System.Drawing.Size(188, 23)
        Me.tdbcAssetIDFrom.TabIndex = 21
        Me.tdbcAssetIDFrom.ValueMember = "AssetID"
        Me.tdbcAssetIDFrom.PropBag = resources.GetString("tdbcAssetIDFrom.PropBag")
        '
        'tdbcACodeID
        '
        Me.tdbcACodeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcACodeID.AllowColMove = False
        Me.tdbcACodeID.AllowSort = False
        Me.tdbcACodeID.AlternatingRows = True
        Me.tdbcACodeID.AutoCompletion = True
        Me.tdbcACodeID.AutoDropDown = True
        Me.tdbcACodeID.Caption = ""
        Me.tdbcACodeID.CaptionHeight = 17
        Me.tdbcACodeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcACodeID.ColumnCaptionHeight = 17
        Me.tdbcACodeID.ColumnFooterHeight = 17
        Me.tdbcACodeID.ColumnWidth = 100
        Me.tdbcACodeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcACodeID.DisplayMember = "ACodeID"
        Me.tdbcACodeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcACodeID.DropDownWidth = 300
        Me.tdbcACodeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcACodeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACodeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcACodeID.EmptyRows = True
        Me.tdbcACodeID.ExtendRightColumn = True
        Me.tdbcACodeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcACodeID.Images.Add(CType(resources.GetObject("tdbcACodeID.Images"), System.Drawing.Image))
        Me.tdbcACodeID.ItemHeight = 15
        Me.tdbcACodeID.Location = New System.Drawing.Point(274, 189)
        Me.tdbcACodeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcACodeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcACodeID.MaxLength = 20
        Me.tdbcACodeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcACodeID.Name = "tdbcACodeID"
        Me.tdbcACodeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcACodeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcACodeID.Size = New System.Drawing.Size(135, 23)
        Me.tdbcACodeID.TabIndex = 18
        Me.tdbcACodeID.ValueMember = "ACodeID"
        Me.tdbcACodeID.PropBag = resources.GetString("tdbcACodeID.PropBag")
        '
        'tdbcGroupTypeID
        '
        Me.tdbcGroupTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcGroupTypeID.AllowColMove = False
        Me.tdbcGroupTypeID.AllowSort = False
        Me.tdbcGroupTypeID.AlternatingRows = True
        Me.tdbcGroupTypeID.AutoCompletion = True
        Me.tdbcGroupTypeID.AutoDropDown = True
        Me.tdbcGroupTypeID.Caption = ""
        Me.tdbcGroupTypeID.CaptionHeight = 17
        Me.tdbcGroupTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcGroupTypeID.ColumnCaptionHeight = 17
        Me.tdbcGroupTypeID.ColumnFooterHeight = 17
        Me.tdbcGroupTypeID.ColumnWidth = 100
        Me.tdbcGroupTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcGroupTypeID.DisplayMember = "GroupTypeID"
        Me.tdbcGroupTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcGroupTypeID.DropDownWidth = 300
        Me.tdbcGroupTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcGroupTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcGroupTypeID.EmptyRows = True
        Me.tdbcGroupTypeID.ExtendRightColumn = True
        Me.tdbcGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupTypeID.Images.Add(CType(resources.GetObject("tdbcGroupTypeID.Images"), System.Drawing.Image))
        Me.tdbcGroupTypeID.ItemHeight = 15
        Me.tdbcGroupTypeID.Location = New System.Drawing.Point(134, 189)
        Me.tdbcGroupTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupTypeID.MaxLength = 20
        Me.tdbcGroupTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupTypeID.Name = "tdbcGroupTypeID"
        Me.tdbcGroupTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupTypeID.Size = New System.Drawing.Size(135, 23)
        Me.tdbcGroupTypeID.TabIndex = 17
        Me.tdbcGroupTypeID.ValueMember = "GroupTypeID"
        Me.tdbcGroupTypeID.PropBag = resources.GetString("tdbcGroupTypeID.PropBag")
        '
        'lblGroupTypeID
        '
        Me.lblGroupTypeID.AutoSize = True
        Me.lblGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupTypeID.Location = New System.Drawing.Point(22, 193)
        Me.lblGroupTypeID.Name = "lblGroupTypeID"
        Me.lblGroupTypeID.Size = New System.Drawing.Size(51, 13)
        Me.lblGroupTypeID.TabIndex = 16
        Me.lblGroupTypeID.Text = "Phân loại"
        Me.lblGroupTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(414, 189)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(188, 22)
        Me.txtDescription.TabIndex = 19
        Me.txtDescription.TabStop = False
        '
        'lblAssetID
        '
        Me.lblAssetID.AutoSize = True
        Me.lblAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssetID.Location = New System.Drawing.Point(22, 222)
        Me.lblAssetID.Name = "lblAssetID"
        Me.lblAssetID.Size = New System.Drawing.Size(42, 13)
        Me.lblAssetID.TabIndex = 20
        Me.lblAssetID.Text = "Tài sản"
        Me.lblAssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grp2
        '
        Me.grp2.Location = New System.Drawing.Point(90, 81)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(510, 3)
        Me.grp2.TabIndex = 6
        Me.grp2.TabStop = False
        '
        'tdbcCustomizeReportID
        '
        Me.tdbcCustomizeReportID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCustomizeReportID.AllowColMove = False
        Me.tdbcCustomizeReportID.AllowSort = False
        Me.tdbcCustomizeReportID.AlternatingRows = True
        Me.tdbcCustomizeReportID.AutoCompletion = True
        Me.tdbcCustomizeReportID.AutoDropDown = True
        Me.tdbcCustomizeReportID.Caption = ""
        Me.tdbcCustomizeReportID.CaptionHeight = 17
        Me.tdbcCustomizeReportID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCustomizeReportID.ColumnCaptionHeight = 17
        Me.tdbcCustomizeReportID.ColumnFooterHeight = 17
        Me.tdbcCustomizeReportID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCustomizeReportID.DisplayMember = "CustomizedReportID"
        Me.tdbcCustomizeReportID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCustomizeReportID.DropDownWidth = 350
        Me.tdbcCustomizeReportID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCustomizeReportID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCustomizeReportID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCustomizeReportID.EmptyRows = True
        Me.tdbcCustomizeReportID.ExtendRightColumn = True
        Me.tdbcCustomizeReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCustomizeReportID.Images.Add(CType(resources.GetObject("tdbcCustomizeReportID.Images"), System.Drawing.Image))
        Me.tdbcCustomizeReportID.ItemHeight = 15
        Me.tdbcCustomizeReportID.Location = New System.Drawing.Point(134, 129)
        Me.tdbcCustomizeReportID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCustomizeReportID.MaxDropDownItems = CType(8, Short)
        Me.tdbcCustomizeReportID.MaxLength = 32767
        Me.tdbcCustomizeReportID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCustomizeReportID.Name = "tdbcCustomizeReportID"
        Me.tdbcCustomizeReportID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCustomizeReportID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCustomizeReportID.Size = New System.Drawing.Size(135, 23)
        Me.tdbcCustomizeReportID.TabIndex = 12
        Me.tdbcCustomizeReportID.ValueMember = "CustomizedReportID"
        Me.tdbcCustomizeReportID.PropBag = resources.GetString("tdbcCustomizeReportID.PropBag")
        '
        'txtReportName
        '
        Me.txtReportName.BackColor = System.Drawing.SystemColors.Control
        Me.txtReportName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportName.Location = New System.Drawing.Point(275, 101)
        Me.txtReportName.MaxLength = 250
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.ReadOnly = True
        Me.txtReportName.Size = New System.Drawing.Size(327, 22)
        Me.txtReportName.TabIndex = 9
        '
        'lblGroupReport
        '
        Me.lblGroupReport.AutoSize = True
        Me.lblGroupReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupReport.Location = New System.Drawing.Point(11, 72)
        Me.lblGroupReport.Name = "lblGroupReport"
        Me.lblGroupReport.Size = New System.Drawing.Size(69, 13)
        Me.lblGroupReport.TabIndex = 5
        Me.lblGroupReport.Text = "2. Báo cáo"
        Me.lblGroupReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID.Location = New System.Drawing.Point(22, 104)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(61, 13)
        Me.lblReportID.TabIndex = 7
        Me.lblReportID.Text = "Mẫu chuẩn"
        Me.lblReportID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomizeReport
        '
        Me.lblCustomizeReport.AutoSize = True
        Me.lblCustomizeReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomizeReport.Location = New System.Drawing.Point(22, 133)
        Me.lblCustomizeReport.Name = "lblCustomizeReport"
        Me.lblCustomizeReport.Size = New System.Drawing.Size(45, 13)
        Me.lblCustomizeReport.TabIndex = 11
        Me.lblCustomizeReport.Text = "Đặc thù"
        Me.lblCustomizeReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grp1
        '
        Me.grp1.Location = New System.Drawing.Point(122, 22)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(477, 3)
        Me.grp1.TabIndex = 1
        Me.grp1.TabStop = False
        '
        'txtCustomizeReportName
        '
        Me.txtCustomizeReportName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustomizeReportName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCustomizeReportName.Location = New System.Drawing.Point(275, 129)
        Me.txtCustomizeReportName.Name = "txtCustomizeReportName"
        Me.txtCustomizeReportName.ReadOnly = True
        Me.txtCustomizeReportName.Size = New System.Drawing.Size(327, 22)
        Me.txtCustomizeReportName.TabIndex = 13
        Me.txtCustomizeReportName.TabStop = False
        '
        'lblGroupDivisionID
        '
        Me.lblGroupDivisionID.AutoSize = True
        Me.lblGroupDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupDivisionID.Location = New System.Drawing.Point(11, 13)
        Me.lblGroupDivisionID.Name = "lblGroupDivisionID"
        Me.lblGroupDivisionID.Size = New System.Drawing.Size(59, 13)
        Me.lblGroupDivisionID.TabIndex = 0
        Me.lblGroupDivisionID.Text = "1. Đơn vị"
        Me.lblGroupDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tdbcDivisionID.DisplayMember = "DivisionID"
        Me.tdbcDivisionID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDivisionID.DropDownWidth = 350
        Me.tdbcDivisionID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDivisionID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDivisionID.EmptyRows = True
        Me.tdbcDivisionID.ExtendRightColumn = True
        Me.tdbcDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.Images.Add(CType(resources.GetObject("tdbcDivisionID.Images"), System.Drawing.Image))
        Me.tdbcDivisionID.ItemHeight = 15
        Me.tdbcDivisionID.Location = New System.Drawing.Point(134, 41)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 32767
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(135, 23)
        Me.tdbcDivisionID.TabIndex = 3
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'lblDivisionID
        '
        Me.lblDivisionID.AutoSize = True
        Me.lblDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionID.Location = New System.Drawing.Point(22, 45)
        Me.lblDivisionID.Name = "lblDivisionID"
        Me.lblDivisionID.Size = New System.Drawing.Size(38, 13)
        Me.lblDivisionID.TabIndex = 2
        Me.lblDivisionID.Text = "Đơn vị"
        Me.lblDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDivisionName.Location = New System.Drawing.Point(275, 42)
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.ReadOnly = True
        Me.txtDivisionName.Size = New System.Drawing.Size(327, 22)
        Me.txtDivisionName.TabIndex = 4
        Me.txtDivisionName.TabStop = False
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(22, 283)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(19, 13)
        Me.lblPeriod.TabIndex = 26
        Me.lblPeriod.Text = "Kỳ"
        Me.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(528, 307)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 22)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(450, 307)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 22)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtReportID
        '
        Me.txtReportID.BackColor = System.Drawing.SystemColors.Control
        Me.txtReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtReportID.Location = New System.Drawing.Point(134, 101)
        Me.txtReportID.MaxLength = 250
        Me.txtReportID.Name = "txtReportID"
        Me.txtReportID.ReadOnly = True
        Me.txtReportID.Size = New System.Drawing.Size(135, 22)
        Me.txtReportID.TabIndex = 8
        '
        'D02F4100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 341)
        Me.Controls.Add(Me.txtReportID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.grp2)
        Me.Controls.Add(Me.tdbcCustomizeReportID)
        Me.Controls.Add(Me.txtReportName)
        Me.Controls.Add(Me.lblGroupReport)
        Me.Controls.Add(Me.lblReportID)
        Me.Controls.Add(Me.lblCustomizeReport)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.txtCustomizeReportName)
        Me.Controls.Add(Me.lblGroupDivisionID)
        Me.Controls.Add(Me.tdbcDivisionID)
        Me.Controls.Add(Me.lblDivisionID)
        Me.Controls.Add(Me.txtDivisionName)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.tdbcAssetIDTo)
        Me.Controls.Add(Me.tdbcAssetIDFrom)
        Me.Controls.Add(Me.tdbcACodeID)
        Me.Controls.Add(Me.tdbcGroupTypeID)
        Me.Controls.Add(Me.lblGroupTypeID)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblAssetID)
        Me.Controls.Add(Me.grp3)
        Me.Controls.Add(Me.lblGroupFilter)
        Me.Controls.Add(Me.tdbcPeriodTo)
        Me.Controls.Add(Me.lblGroupTime)
        Me.Controls.Add(Me.grp4)
        Me.Controls.Add(Me.tdbcPeriodFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F4100"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÀo cÀo nhËp xuÊt tän TSC˜ - D02F4100"
        CType(Me.tdbcPeriodTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcPeriodFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcAssetIDTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcAssetIDFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcCustomizeReportID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tdbcPeriodTo As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupTime As System.Windows.Forms.Label
    Private WithEvents grp4 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcPeriodFrom As C1.Win.C1List.C1Combo
    Private WithEvents grp3 As System.Windows.Forms.GroupBox
    Private WithEvents lblGroupFilter As System.Windows.Forms.Label
    Private WithEvents lblLine As System.Windows.Forms.Label
    Private WithEvents tdbcAssetIDTo As C1.Win.C1List.C1Combo
    Private WithEvents tdbcAssetIDFrom As C1.Win.C1List.C1Combo
    Private WithEvents tdbcACodeID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcGroupTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupTypeID As System.Windows.Forms.Label
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents lblAssetID As System.Windows.Forms.Label
    Private WithEvents grp2 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcCustomizeReportID As C1.Win.C1List.C1Combo
    Private WithEvents txtReportName As System.Windows.Forms.TextBox
    Private WithEvents lblGroupReport As System.Windows.Forms.Label
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents lblCustomizeReport As System.Windows.Forms.Label
    Private WithEvents grp1 As System.Windows.Forms.GroupBox
    Private WithEvents txtCustomizeReportName As System.Windows.Forms.TextBox
    Private WithEvents lblGroupDivisionID As System.Windows.Forms.Label
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents lblDivisionID As System.Windows.Forms.Label
    Private WithEvents txtDivisionName As System.Windows.Forms.TextBox
    Private WithEvents lblPeriod As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents txtReportID As System.Windows.Forms.TextBox
End Class