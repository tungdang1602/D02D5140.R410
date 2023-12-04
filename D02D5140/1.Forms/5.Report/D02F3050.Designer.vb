<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3050
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3050))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tdbcReportID = New C1.Win.C1List.C1Combo()
        Me.tdbcReportTypeID = New C1.Win.C1List.C1Combo()
        Me.lblReportTypeID = New System.Windows.Forms.Label()
        Me.txtReportTypeName = New System.Windows.Forms.TextBox()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tdbcToAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcObjectID = New C1.Win.C1List.C1Combo()
        Me.tdbcObjectTypeID = New C1.Win.C1List.C1Combo()
        Me.tdbcACodeID = New C1.Win.C1List.C1Combo()
        Me.tdbcGroupTypeID = New C1.Win.C1List.C1Combo()
        Me.lblGroupTypeID = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblObjectTypeID = New System.Windows.Forms.Label()
        Me.txtObjectName = New System.Windows.Forms.TextBox()
        Me.lblFromAssetID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcObjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcObjectTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tdbcReportID)
        Me.GroupBox1.Controls.Add(Me.tdbcReportTypeID)
        Me.GroupBox1.Controls.Add(Me.lblReportTypeID)
        Me.GroupBox1.Controls.Add(Me.txtReportTypeName)
        Me.GroupBox1.Controls.Add(Me.lblReportID)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 81)
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
        Me.tdbcReportID.Location = New System.Drawing.Point(114, 48)
        Me.tdbcReportID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportID.MaxLength = 20
        Me.tdbcReportID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportID.Name = "tdbcReportID"
        Me.tdbcReportID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcReportID.TabIndex = 5
        Me.tdbcReportID.ValueMember = "ReportID"
        Me.tdbcReportID.PropBag = resources.GetString("tdbcReportID.PropBag")
        '
        'tdbcReportTypeID
        '
        Me.tdbcReportTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportTypeID.AllowColMove = False
        Me.tdbcReportTypeID.AllowSort = False
        Me.tdbcReportTypeID.AlternatingRows = True
        Me.tdbcReportTypeID.AutoCompletion = True
        Me.tdbcReportTypeID.AutoDropDown = True
        Me.tdbcReportTypeID.AutoSelect = True
        Me.tdbcReportTypeID.Caption = ""
        Me.tdbcReportTypeID.CaptionHeight = 17
        Me.tdbcReportTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportTypeID.ColumnCaptionHeight = 17
        Me.tdbcReportTypeID.ColumnFooterHeight = 17
        Me.tdbcReportTypeID.ColumnWidth = 100
        Me.tdbcReportTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportTypeID.DisplayMember = "ReportTypeID"
        Me.tdbcReportTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportTypeID.DropDownWidth = 350
        Me.tdbcReportTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportTypeID.EmptyRows = True
        Me.tdbcReportTypeID.ExtendRightColumn = True
        Me.tdbcReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportTypeID.Images.Add(CType(resources.GetObject("tdbcReportTypeID.Images"), System.Drawing.Image))
        Me.tdbcReportTypeID.ItemHeight = 15
        Me.tdbcReportTypeID.Location = New System.Drawing.Point(114, 19)
        Me.tdbcReportTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportTypeID.MaxLength = 20
        Me.tdbcReportTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportTypeID.Name = "tdbcReportTypeID"
        Me.tdbcReportTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportTypeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcReportTypeID.TabIndex = 1
        Me.tdbcReportTypeID.ValueMember = "ReportTypeID"
        Me.tdbcReportTypeID.PropBag = resources.GetString("tdbcReportTypeID.PropBag")
        '
        'lblReportTypeID
        '
        Me.lblReportTypeID.AutoSize = True
        Me.lblReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTypeID.Location = New System.Drawing.Point(9, 24)
        Me.lblReportTypeID.Name = "lblReportTypeID"
        Me.lblReportTypeID.Size = New System.Drawing.Size(61, 13)
        Me.lblReportTypeID.TabIndex = 0
        Me.lblReportTypeID.Text = "Mẫu chuẩn"
        Me.lblReportTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReportTypeName
        '
        Me.txtReportTypeName.Enabled = False
        Me.txtReportTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtReportTypeName.Location = New System.Drawing.Point(247, 19)
        Me.txtReportTypeName.MaxLength = 250
        Me.txtReportTypeName.Name = "txtReportTypeName"
        Me.txtReportTypeName.ReadOnly = True
        Me.txtReportTypeName.Size = New System.Drawing.Size(310, 22)
        Me.txtReportTypeName.TabIndex = 2
        Me.txtReportTypeName.TabStop = False
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID.Location = New System.Drawing.Point(9, 53)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(45, 13)
        Me.lblReportID.TabIndex = 4
        Me.lblReportID.Text = "Đặc thù"
        Me.lblReportID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTitle.Location = New System.Drawing.Point(247, 48)
        Me.txtTitle.MaxLength = 250
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(310, 22)
        Me.txtTitle.TabIndex = 6
        Me.txtTitle.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tdbcToAssetID)
        Me.GroupBox2.Controls.Add(Me.tdbcFromAssetID)
        Me.GroupBox2.Controls.Add(Me.tdbcObjectID)
        Me.GroupBox2.Controls.Add(Me.tdbcObjectTypeID)
        Me.GroupBox2.Controls.Add(Me.tdbcACodeID)
        Me.GroupBox2.Controls.Add(Me.tdbcGroupTypeID)
        Me.GroupBox2.Controls.Add(Me.lblGroupTypeID)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.lblObjectTypeID)
        Me.GroupBox2.Controls.Add(Me.txtObjectName)
        Me.GroupBox2.Controls.Add(Me.lblFromAssetID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 113)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Điều kiện lọc"
        '
        'tdbcToAssetID
        '
        Me.tdbcToAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToAssetID.AllowColMove = False
        Me.tdbcToAssetID.AllowSort = False
        Me.tdbcToAssetID.AlternatingRows = True
        Me.tdbcToAssetID.AutoCompletion = True
        Me.tdbcToAssetID.AutoDropDown = True
        Me.tdbcToAssetID.Caption = ""
        Me.tdbcToAssetID.CaptionHeight = 17
        Me.tdbcToAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToAssetID.ColumnCaptionHeight = 17
        Me.tdbcToAssetID.ColumnFooterHeight = 17
        Me.tdbcToAssetID.ColumnWidth = 100
        Me.tdbcToAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToAssetID.DisplayMember = "AssetID"
        Me.tdbcToAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToAssetID.DropDownWidth = 300
        Me.tdbcToAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToAssetID.EmptyRows = True
        Me.tdbcToAssetID.ExtendRightColumn = True
        Me.tdbcToAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.Images.Add(CType(resources.GetObject("tdbcToAssetID.Images"), System.Drawing.Image))
        Me.tdbcToAssetID.ItemHeight = 15
        Me.tdbcToAssetID.Location = New System.Drawing.Point(248, 77)
        Me.tdbcToAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToAssetID.MaxLength = 20
        Me.tdbcToAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToAssetID.Name = "tdbcToAssetID"
        Me.tdbcToAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToAssetID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcToAssetID.TabIndex = 11
        Me.tdbcToAssetID.ValueMember = "AssetID"
        Me.tdbcToAssetID.PropBag = resources.GetString("tdbcToAssetID.PropBag")
        '
        'tdbcFromAssetID
        '
        Me.tdbcFromAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromAssetID.AllowColMove = False
        Me.tdbcFromAssetID.AllowSort = False
        Me.tdbcFromAssetID.AlternatingRows = True
        Me.tdbcFromAssetID.AutoCompletion = True
        Me.tdbcFromAssetID.AutoDropDown = True
        Me.tdbcFromAssetID.Caption = ""
        Me.tdbcFromAssetID.CaptionHeight = 17
        Me.tdbcFromAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromAssetID.ColumnCaptionHeight = 17
        Me.tdbcFromAssetID.ColumnFooterHeight = 17
        Me.tdbcFromAssetID.ColumnWidth = 100
        Me.tdbcFromAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromAssetID.DisplayMember = "AssetID"
        Me.tdbcFromAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromAssetID.DropDownWidth = 300
        Me.tdbcFromAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromAssetID.EmptyRows = True
        Me.tdbcFromAssetID.ExtendRightColumn = True
        Me.tdbcFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.Images.Add(CType(resources.GetObject("tdbcFromAssetID.Images"), System.Drawing.Image))
        Me.tdbcFromAssetID.ItemHeight = 15
        Me.tdbcFromAssetID.Location = New System.Drawing.Point(114, 77)
        Me.tdbcFromAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromAssetID.MaxLength = 20
        Me.tdbcFromAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromAssetID.Name = "tdbcFromAssetID"
        Me.tdbcFromAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromAssetID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcFromAssetID.TabIndex = 9
        Me.tdbcFromAssetID.ValueMember = "AssetID"
        Me.tdbcFromAssetID.PropBag = resources.GetString("tdbcFromAssetID.PropBag")
        '
        'tdbcObjectID
        '
        Me.tdbcObjectID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcObjectID.AllowColMove = False
        Me.tdbcObjectID.AllowSort = False
        Me.tdbcObjectID.AlternatingRows = True
        Me.tdbcObjectID.AutoCompletion = True
        Me.tdbcObjectID.AutoDropDown = True
        Me.tdbcObjectID.Caption = ""
        Me.tdbcObjectID.CaptionHeight = 17
        Me.tdbcObjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcObjectID.ColumnCaptionHeight = 17
        Me.tdbcObjectID.ColumnFooterHeight = 17
        Me.tdbcObjectID.ColumnWidth = 100
        Me.tdbcObjectID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcObjectID.DisplayMember = "ObjectID"
        Me.tdbcObjectID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcObjectID.DropDownWidth = 300
        Me.tdbcObjectID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcObjectID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcObjectID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcObjectID.EmptyRows = True
        Me.tdbcObjectID.ExtendRightColumn = True
        Me.tdbcObjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcObjectID.Images.Add(CType(resources.GetObject("tdbcObjectID.Images"), System.Drawing.Image))
        Me.tdbcObjectID.ItemHeight = 15
        Me.tdbcObjectID.Location = New System.Drawing.Point(247, 48)
        Me.tdbcObjectID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcObjectID.MaxDropDownItems = CType(8, Short)
        Me.tdbcObjectID.MaxLength = 20
        Me.tdbcObjectID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcObjectID.Name = "tdbcObjectID"
        Me.tdbcObjectID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcObjectID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcObjectID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcObjectID.TabIndex = 6
        Me.tdbcObjectID.ValueMember = "ObjectID"
        Me.tdbcObjectID.PropBag = resources.GetString("tdbcObjectID.PropBag")
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
        Me.tdbcObjectTypeID.Location = New System.Drawing.Point(114, 48)
        Me.tdbcObjectTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcObjectTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcObjectTypeID.MaxLength = 20
        Me.tdbcObjectTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcObjectTypeID.Name = "tdbcObjectTypeID"
        Me.tdbcObjectTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcObjectTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcObjectTypeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcObjectTypeID.TabIndex = 5
        Me.tdbcObjectTypeID.ValueMember = "ObjectTypeID"
        Me.tdbcObjectTypeID.PropBag = resources.GetString("tdbcObjectTypeID.PropBag")
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
        Me.tdbcACodeID.Location = New System.Drawing.Point(247, 19)
        Me.tdbcACodeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcACodeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcACodeID.MaxLength = 20
        Me.tdbcACodeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcACodeID.Name = "tdbcACodeID"
        Me.tdbcACodeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcACodeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcACodeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcACodeID.TabIndex = 2
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
        Me.tdbcGroupTypeID.Location = New System.Drawing.Point(114, 19)
        Me.tdbcGroupTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupTypeID.MaxLength = 20
        Me.tdbcGroupTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupTypeID.Name = "tdbcGroupTypeID"
        Me.tdbcGroupTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupTypeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcGroupTypeID.TabIndex = 1
        Me.tdbcGroupTypeID.ValueMember = "GroupTypeID"
        Me.tdbcGroupTypeID.PropBag = resources.GetString("tdbcGroupTypeID.PropBag")
        '
        'lblGroupTypeID
        '
        Me.lblGroupTypeID.AutoSize = True
        Me.lblGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupTypeID.Location = New System.Drawing.Point(9, 24)
        Me.lblGroupTypeID.Name = "lblGroupTypeID"
        Me.lblGroupTypeID.Size = New System.Drawing.Size(51, 13)
        Me.lblGroupTypeID.TabIndex = 0
        Me.lblGroupTypeID.Text = "Phân loại"
        Me.lblGroupTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(381, 19)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(176, 22)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.TabStop = False
        '
        'lblObjectTypeID
        '
        Me.lblObjectTypeID.AutoSize = True
        Me.lblObjectTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectTypeID.Location = New System.Drawing.Point(9, 53)
        Me.lblObjectTypeID.Name = "lblObjectTypeID"
        Me.lblObjectTypeID.Size = New System.Drawing.Size(84, 13)
        Me.lblObjectTypeID.TabIndex = 4
        Me.lblObjectTypeID.Text = "Bộ phận quản lý"
        Me.lblObjectTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObjectName
        '
        Me.txtObjectName.Enabled = False
        Me.txtObjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtObjectName.Location = New System.Drawing.Point(381, 48)
        Me.txtObjectName.MaxLength = 250
        Me.txtObjectName.Name = "txtObjectName"
        Me.txtObjectName.ReadOnly = True
        Me.txtObjectName.Size = New System.Drawing.Size(176, 22)
        Me.txtObjectName.TabIndex = 7
        Me.txtObjectName.TabStop = False
        '
        'lblFromAssetID
        '
        Me.lblFromAssetID.AutoSize = True
        Me.lblFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromAssetID.Location = New System.Drawing.Point(9, 82)
        Me.lblFromAssetID.Name = "lblFromAssetID"
        Me.lblFromAssetID.Size = New System.Drawing.Size(42, 13)
        Me.lblFromAssetID.TabIndex = 8
        Me.lblFromAssetID.Text = "Tài sản"
        Me.lblFromAssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(424, 208)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 22)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(502, 208)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 22)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'D02F3050
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 239)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3050"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÀo cÀo thiÕt bÜ ¢Ûnh kÌm tªi s¶n - D02F3050"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcObjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcObjectTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcACodeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcReportID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcReportTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportTypeID As System.Windows.Forms.Label
    Private WithEvents txtReportTypeName As System.Windows.Forms.TextBox
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcObjectID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcObjectTypeID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcACodeID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcGroupTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupTypeID As System.Windows.Forms.Label
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents lblObjectTypeID As System.Windows.Forms.Label
    Private WithEvents txtObjectName As System.Windows.Forms.TextBox
    Private WithEvents tdbcToAssetID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromAssetID As C1.Win.C1List.C1Combo
    Private WithEvents lblFromAssetID As System.Windows.Forms.Label
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
End Class