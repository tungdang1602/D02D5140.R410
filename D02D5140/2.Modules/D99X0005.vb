'#######################################################################################
'#                                     CHÚ Ý
'#--------------------------------------------------------------------------------------
'# Không được thay đổi bất cứ dòng code này trong module này, nếu muốn thay đổi bạn phải
'# liên lạc với Trưởng nhóm để được giải quyết.
'# Ngày cập nhật cuối cùng: 04/03/2013
'# Người cập nhật cuối cùng: Hoàng Nhân
'# Diễn giải: Thêm hàm SetShortcutPopupMenu chỉ cho ContextMenuStrip
'# Bổ sung icon và phím nóng cho các menu trên ToolStrip
'# Bổ sung menu Xuất Excel trực tiếp. mnsExportOut
'# Bổ sung menu Xuất dữ liệu, tsmExportDataScript
'#######################################################################################

''' <summary>
''' Module quản lý các vấn đề về Shortcut và Image của Popupmenu
''' </summary>
''' <remarks>Chỉ gắn vào exe nào có sử dụng popupmenu</remarks>
Module D99X0005

#Region "Set Image và Shortcut của Popupmenu"
    ''' <summary>
    ''' Set Image và Shortcut của Popupmenu
    ''' </summary>
    ''' <param name="C1CmdHolder">C1CommandHolder của popupmenu</param>
    ''' <remarks>Gọi hàm SetShortcutPopupMenu(C1CommandHolder)tại form_load</remarks>
    <DebuggerStepThrough()> _
    Public Sub SetShortcutPopupMenu(ByVal C1CmdHolder As C1.Win.C1Command.C1CommandHolder)
        On Error Resume Next

        With C1CmdHolder
            .SmoothImages = False
            '************************************************
            'Image và Shortcut chuẩn
            'Thêm
            .Commands("mnuAdd").Image = My.Resources.add
            .Commands("mnuAdd").Shortcut = Shortcut.CtrlN
            'Kế thừa
            .Commands("mnuInherit").Image = My.Resources.copy
            .Commands("mnuInherit").Shortcut = Shortcut.CtrlY
            'Xem
            .Commands("mnuView").Image = My.Resources.view
            .Commands("mnuView").Shortcut = Shortcut.CtrlW
            'Sửa
            .Commands("mnuEdit").Image = My.Resources.edit
            .Commands("mnuEdit").Shortcut = Shortcut.CtrlE
            'Xóa
            .Commands("mnuDelete").Image = My.Resources.delete
            .Commands("mnuDelete").Shortcut = Shortcut.CtrlD
            'Tìm kiếm
            .Commands("mnuFind").Image = My.Resources.find
            .Commands("mnuFind").Shortcut = Shortcut.CtrlF
            'Liệt kê tất cả
            .Commands("mnuListAll").Image = My.Resources.ListAll
            .Commands("mnuListAll").Shortcut = Shortcut.CtrlA
            'Thông tin hệ thống
            .Commands("mnuSysInfo").Image = My.Resources.SysInfo
            .Commands("mnuSysInfo").Shortcut = Shortcut.CtrlI
            'In
            .Commands("mnuPrint").Image = My.Resources.PrintReport
            .Commands("mnuPrint").Shortcut = Shortcut.CtrlP
            
            'Xuất Excel
            .Commands("mnuExportToExcel").Image = My.Resources.ExportToExcel
            .Commands("mnuExportToExcel").Shortcut = Shortcut.CtrlX
            'Sửa khác
            .Commands("mnuEditOther").Image = My.Resources.EditOther
            .Commands("mnuEditOther").Shortcut = Shortcut.CtrlO
            'Sửa số phiếu
            .Commands("mnuEditVoucher").Image = My.Resources.EditVoucher
            .Commands("mnuEditVoucher").Shortcut = Shortcut.CtrlU
            'Xuất kho
            .Commands("mnuIssueStock").Image = My.Resources.IssueStock
            .Commands("mnuIssueStock").Shortcut = Shortcut.CtrlK
            'Khóa phiếu
            .Commands("mnuLockVoucher").Image = My.Resources.LockVoucher
            .Commands("mnuLockVoucher").Shortcut = Shortcut.CtrlL
            'Hiển thị chi tiết
            .Commands("mnuShowDetail").Image = My.Resources.ShowDetail
            .Commands("mnuShowDetail").Shortcut = Shortcut.CtrlS
            'Duyệt
            .Commands("mnuApprove").Image = My.Resources.approve
            .Commands("mnuApprove").Shortcut = Shortcut.CtrlR

            'Update 12/11/2010
            'Hủy phiếu
            .Commands("mnuCancelVoucher").Image = My.Resources.CancelVoucher
            .Commands("mnuCancelVoucher").Shortcut = Shortcut.CtrlH
            'Import dữ liệu
            .Commands("mnuImportData").Image = My.Resources.ImportData
            .Commands("mnuImportData").Shortcut = Shortcut.CtrlM

            'Update  28/02/2013
            .Commands("mnuExportOut").Image = My.Resources.ExportToExcelOut
            'Update  1/3/2013
            .Commands("mnuExportDataScript").Image = My.Resources.ExportDataScript
            '************************************************
            'Image và Shortcut đặt thù của mỗi module
            .Commands("C1CommandMenu1").Image = My.Resources.PrintReport
            '************************************************
        End With
    End Sub
#End Region

#Region "Set Image và Shortcut của ToolStrip"

    ''' <summary>
    ''' Set Image và Shortcut của ContextMenuStrip
    ''' </summary>
    ''' <param name="bTransactionHistory">Nếu = True thì menu tsbSysInfo có tên là Lịch sử tác động</param>
    ''' <param name="ContextMenuStrip"></param>
    ''' <remarks>Gọi hàm  SetShortcutPopupMenu(ContextMenuStrip1) tại form_load</remarks>
    Public Sub SetShortcutPopupMenu(ByVal ContextMenuStrip As System.Windows.Forms.ContextMenuStrip, Optional ByVal bTransactionHistory As Boolean = False)
        On Error Resume Next

        'Update 19/07/2011: Set ShortCut cho ContextMenuStrip (Áp dụng cho một số đối tượng có sử dụng đến Menu ngắn: Lưới, treeview...)
        If ContextMenuStrip IsNot Nothing Then
            With ContextMenuStrip
                'mnuAdd
                .Items("mnsAdd").Image = My.Resources.add
                .Items("mnsAdd").Text = r("_Them") '&Thêm
                CType(.Items("mnsAdd"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)

                'mnuInherit
                .Items("mnsInherit").Image = My.Resources.copy
                .Items("mnsInherit").Text = r("Ke_thu_a") 'Kế thừ&a
                CType(.Items("mnsInherit"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)

                'mnuView
                .Items("mnsView").Image = My.Resources.view
                .Items("mnsView").Text = r("Xe_m") 'Xe&m
                CType(.Items("mnsView"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)

                'mnuEdit
                .Items("mnsEdit").Image = My.Resources.edit
                .Items("mnsEdit").Text = r("_Sua") '&Sửa
                CType(.Items("mnsEdit"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)

                'mnuDelete
                .Items("mnsDelete").Image = My.Resources.delete
                .Items("mnsDelete").Text = r("_Xoa") '&Xóa
                CType(.Items("mnsDelete"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)

                'mnuFind
                .Items("mnsFind").Image = My.Resources.find
                .Items("mnsFind").Text = r("Tim__kiem") 'Tìm &kiếm
                CType(.Items("mnsFind"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)

                'mnuListAll
                .Items("mnsListAll").Image = My.Resources.ListAll
                .Items("mnsListAll").Text = r("_Liet_ke_tat_ca") '&Liệt kế tất cả
                CType(.Items("mnsListAll"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)

                'mnuSysInfo
                .Items("mnsSysInfo").Image = My.Resources.SysInfo
              
               If bTransactionHistory Then
                    .Items("mnuSysInfo").Text = r("Lich_su_tac_dong") 'Lịch sử tác động
                Else
                    .Items("mnsSysInfo").Text = r("Thong_tin__he_thong") 'Thông tin &hệ thống
                End If
                CType(.Items("mnsSysInfo"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)

                'mnuPrint
                .Items("mnsPrint").Image = My.Resources.PrintReport
                .Items("mnsPrint").Text = r("_In") '&In
                CType(.Items("mnsPrint"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)

                'mnuExportToExcel
                .Items("mnsExportToExcel").Image = My.Resources.ExportToExcel
                .Items("mnsExportToExcel").Text = r("Xuat__Excel") 'Xuất &Excel
                CType(.Items("mnsExportToExcel"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)

                'mnuEditOther
                .Items("mnsEditOther").Image = My.Resources.EditOther
                .Items("mnsEditOther").Text = r("Sua_khac_(_O)") 'Sửa khác (&O)
                CType(.Items("mnsEditOther"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)

                'mnuEditVoucher
                .Items("mnsEditVoucher").Image = My.Resources.EditVoucher
                .Items("mnsEditVoucher").Text = r("Sua_so_phie_u") 'Sửa số phiế&u
                CType(.Items("mnsEditVoucher"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)

                'mnuIssueStock
                .Items("mnsIssueStock").Image = My.Resources.IssueStock
                .Items("mnsIssueStock").Text = r("Xuat_kho") 'Xuất kho
                CType(.Items("mnsIssueStock"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)

                'mnuLockVoucher
                .Items("mnsLockVoucher").Image = My.Resources.LockVoucher
                .Items("mnsLockVoucher").Text = r("Khoa__phieu") 'Khóa &phiếu
                CType(.Items("mnsLockVoucher"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)

                'mnuShowDetail
                .Items("mnsShowDetail").Image = My.Resources.ShowDetail
                .Items("mnsShowDetail").Text = r("Hien_thi__chi_tiet") 'Hiển thị &chi tiết
                CType(.Items("mnsShowDetail"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)

                'mnuApprove
                .Items("mnsApprove").Image = My.Resources.approve
                .Items("mnsApprove").Text = r("_Duyet") '&Duyệt
                CType(.Items("mnsApprove"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)

                'mnuCancelVoucher
                .Items("mnsCancelVoucher").Image = My.Resources.CancelVoucher
                .Items("mnsCancelVoucher").Text = r("Huy_phieu") '&Hủy phiếu
                CType(.Items("mnsCancelVoucher"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)

                'mnuImportData
                .Items("mnsImportData").Image = My.Resources.ImportData
                .Items("mnsImportData").Text = r("Import__du_lieu") 'Import &dữ liệu 
                CType(.Items("mnsImportData"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)

                'mnuExportOut
                .Items("mnsExportOut").Image = My.Resources.ExportToExcelOut
                .Items("mnsExportOut").Text = r("X_uat_Excel_truc_tiep") 'Import &dữ liệu 

                'Update  1/3/2013
                .Items("mnsExportDataScript").Image = My.Resources.ExportDataScript
                .Items("mnsExportDataScript").Text = r("MSG000051") 'Import &dữ liệu 
            End With
        End If

        'Các phím chung của sự kiện Form_Keydown
        'AddHandler Form.KeyDown, AddressOf Form_KeyDown
    End Sub

        ''' <summary>
    ''' Set Image và Shortcut của ToolStripButton
    ''' </summary>
    ''' <param name="Form">Me</param>
    ''' <param name="TableToolStrip">System.Windows.Forms.ToolStri</param>
    ''' <param name="bTransactionHistory">Nếu = True thì menu tsbSysInfo có tên là Lịch sử tác động</param>
    ''' <param name="ContextMenuStrip"></param>
    ''' <remarks>Gọi hàm  SetShortcutPopupMenu(Me, TableToolStrip, ContextMenuStrip1) tại form_load</remarks>
    Public Sub SetShortcutPopupMenu(ByVal Form As Form, ByVal TableToolStrip As System.Windows.Forms.ToolStrip, ByVal ContextMenuStrip As System.Windows.Forms.ContextMenuStrip, Optional ByVal bTransactionHistory As Boolean = False)
        On Error Resume Next
        If TableToolStrip IsNot Nothing Then
            ' Set ShortCut cho TableToolStrip
            With TableToolStrip
                .BackColor = System.Drawing.SystemColors.ActiveBorder

                '************************************************
                'Image và Shortcut chuẩn
                'Thêm
                .Items("tsbAdd").DisplayStyle = ToolStripItemDisplayStyle.Image 'ImageAndText
                .Items("tsbAdd").Image = My.Resources.add
                .Items("tsbAdd").Text = r("_Them") '&Thêm
                .Items("tsbAdd").ToolTipText = .Items("tsbAdd").Text.Replace("&", "") & " (Ctrl+N)"
                'Kế thừa
                .Items("tsbInherit").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbInherit").Image = My.Resources.copy
                .Items("tsbInherit").Text = r("Ke_thu_a") 'Kế thừ&a
                .Items("tsbInherit").ToolTipText = .Items("tsbInherit").Text.Replace("&", "") & " (Ctrl+Y)"
                'Xem
                .Items("tsbView").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbView").Image = My.Resources.view
                .Items("tsbView").Text = r("Xe_m") 'Xe&m
                .Items("tsbView").ToolTipText = .Items("tsbView").Text.Replace("&", "") & " (Ctrl+W)"
                'Sửa
                .Items("tsbEdit").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbEdit").Image = My.Resources.edit
                .Items("tsbEdit").Text = r("_Sua") '&Sửa
                .Items("tsbEdit").ToolTipText = .Items("tsbEdit").Text.Replace("&", "") & " (Ctrl+E)"
                'Xóa
                .Items("tsbDelete").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbDelete").Image = My.Resources.delete
                .Items("tsbDelete").Text = r("_Xoa") '&Xóa
                .Items("tsbDelete").ToolTipText = .Items("tsbDelete").Text.Replace("&", "") & " (Ctrl+D)"
                'Tìm kiếm
                .Items("tsbFind").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbFind").Image = My.Resources.find
                .Items("tsbFind").Text = r("Tim__kiem") 'Tìm &kiếm
                .Items("tsbFind").ToolTipText = .Items("tsbFind").Text.Replace("&", "") & " (Ctrl+F)"
                'Liệt kê tất cả
                .Items("tsbListAll").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbListAll").Image = My.Resources.ListAll
                .Items("tsbListAll").Text = r("_Liet_ke_tat_ca") '&Liệt kế tất cả
                .Items("tsbListAll").ToolTipText = .Items("tsbListAll").Text.Replace("&", "") & " (Ctrl+A)"
                'Thông tin hệ thống
                .Items("tsbSysInfo").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbSysInfo").Image = My.Resources.SysInfo
                If bTransactionHistory Then
                    .Items("tsbSysInfo").Text = r("Lich_su_tac_dong") 'Lịch sử tác động
                Else
                    .Items("tsbSysInfo").Text = r("Thong_tin__he_thong") 'Thông tin &hệ thống
                End If
                .Items("tsbSysInfo").ToolTipText = .Items("tsbSysInfo").Text.Replace("&", "") & " (Ctrl+I)"
                'In
                .Items("tsbPrint").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbPrint").Image = My.Resources.PrintReport
                .Items("tsbPrint").Text = r("_In") '&In
                .Items("tsbPrint").ToolTipText = .Items("tsbPrint").Text.Replace("&", "") & " (Ctrl+P)"
                'Xuất Excel
                .Items("tsbExportToExcel").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbExportToExcel").Image = My.Resources.ExportToExcel
                .Items("tsbExportToExcel").Text = r("Xuat__Excel") 'Xuất &Excel
                .Items("tsbExportToExcel").ToolTipText = .Items("tsbExportToExcel").Text.Replace("&", "") & " (Ctrl+X)"
                'Sửa khác
                .Items("tsbEditOther").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbEditOther").Image = My.Resources.EditOther
                .Items("tsbEditOther").Text = r("Sua_khac_(_O)") 'Sửa khác (&O)
                .Items("tsbEditOther").ToolTipText = .Items("tsbEditOther").Text.Replace("&", "") & " (Ctrl+O)"
                'Sửa số phiếu
                .Items("tsbEditVoucher").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbEditVoucher").Image = My.Resources.EditVoucher
                .Items("tsbEditVoucher").Text = r("Sua_so_phie_u") 'Sửa số phiế&u
                .Items("tsbEditVoucher").ToolTipText = .Items("tsbEditVoucher").Text.Replace("&", "") & " (Ctrl+U)"
                'Xuất kho
                .Items("tsbIssueStock").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbIssueStock").Image = My.Resources.IssueStock
                .Items("tsbIssueStock").Text = r("Xuat_kho") 'Xuất kho
                .Items("tsbIssueStock").ToolTipText = .Items("tsbIssueStock").Text.Replace("&", "") & " (Ctrl+K)"
                'Khóa phiếu
                .Items("tsbLocked").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbLocked").Image = My.Resources.LockVoucher
                .Items("tsbLocked").Text = r("Khoa__phieu") 'Khóa &phiếu
                .Items("tsbLocked").ToolTipText = .Items("tsbLocked").Text.Replace("&", "") & " (Ctrl+L)"

                .Items("tsbLockVoucher").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbLockVoucher").Image = My.Resources.LockVoucher
                .Items("tsbLockVoucher").Text = r("Khoa__phieu") 'Khóa &phiếu
                .Items("tsbLockVoucher").ToolTipText = .Items("tsbLockVoucher").Text.Replace("&", "") & " (Ctrl+L)"
                'Hiển thị chi tiết
                .Items("tsbShowDetail").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbShowDetail").Image = My.Resources.ShowDetail
                .Items("tsbShowDetail").Text = r("Hien_thi__chi_tiet") 'Hiển thị &chi tiết
                .Items("tsbShowDetail").ToolTipText = .Items("tsbShowDetail").Text.Replace("&", "") & " (Ctrl+S)"
                'Duyệt
                .Items("tsbApprove").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbApprove").Image = My.Resources.approve
                .Items("tsbApprove").Text = r("_Duyet") '&Duyệt
                .Items("tsbApprove").ToolTipText = .Items("tsbApprove").Text.Replace("&", "") & " (Ctrl+R)"
                'Hủy phiếu
                .Items("tsbCancelVoucher").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbCancelVoucher").Image = My.Resources.CancelVoucher
                .Items("tsbCancelVoucher").Text = r("Huy_phieu") '&Hủy phiếu
                .Items("tsbCancelVoucher").ToolTipText = .Items("tsbCancelVoucher").Text.Replace("&", "") & " (Ctrl+H)"
                'Import dữ liệu
                .Items("tsbImportData").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbImportData").Image = My.Resources.ImportData
                .Items("tsbImportData").Text = r("Import__du_lieu") 'Import &dữ liệu 
                .Items("tsbImportData").ToolTipText = .Items("tsbImportData").Text.Replace("&", "") & " (Ctrl+M)"

                'Đóng
                .Items("tsbClose").DisplayStyle = ToolStripItemDisplayStyle.Image
                .Items("tsbClose").Image = My.Resources.CloseForm
                .Items("tsbClose").Text = r("Do_ng") 'Đó&ng
                .Items("tsbClose").ToolTipText = .Items("tsbClose").Text.Replace("&", "") & " (Ctrl+Q)"

                'Thực hiện
                .Items("tsdActive").DisplayStyle = ToolStripItemDisplayStyle.Text
                .Items("tsdActive").Text = r("_Thuc_hien_") '&Thực hiện...

                'Nghiệp vụ
                .Items("tsdTranstion").DisplayStyle = ToolStripItemDisplayStyle.Text
                .Items("tsdTranstion").Text = r("_Nghiep_vu") '&Nghiệp vụ

            End With

            Dim tsdActive As ToolStripDropDownButton = CType(TableToolStrip.Items("tsdActive"), ToolStripDropDownButton)
            '        tsdActive.Alignment = ToolStripItemAlignment.Right
            '        tsdActive.DropDownDirection = ToolStripDropDownDirection.BelowLeft

            Dim tsdTranstion As ToolStripDropDownButton = CType(TableToolStrip.Items("tsdTranstion"), ToolStripDropDownButton)
            If tsdActive IsNot Nothing Then 'Tồn tại
                Dim mnu As ToolStripMenuItem
                With tsdActive.DropDownItems
                    mnu = CType(.Item("tsmAdd"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.add
                    mnu.Text = r("_Them") '&Thêm

                    mnu = CType(.Item("tsmEdit"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.edit
                    mnu.Text = r("_Sua") '&Sửa

                    mnu = CType(.Item("tsmInherit"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.copy
                    mnu.Text = r("Ke_thu_a") 'Kế thừ&a

                    mnu = CType(.Item("tsmView"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.view
                    mnu.Text = r("Xe_m") 'Xe&m

                    mnu = CType(.Item("tsmDelete"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.delete
                    mnu.Text = r("_Xoa") '&Xóa

                    mnu = CType(.Item("tsmFind"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.find
                    mnu.Text = r("Tim__kiem") 'Tìm &kiếm

                    mnu = CType(.Item("tsmListAll"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.ListAll
                    mnu.Text = r("_Liet_ke_tat_ca") '&Liệt kế tất cả

                    mnu = CType(.Item("tsmSysInfo"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.SysInfo
                    If bTransactionHistory Then
                        mnu.Text = r("Lich_su_tac_dong") 'Lịch sử tác động
                    Else
                        mnu.Text = r("Thong_tin__he_thong") 'Thông tin &hệ thống
                    End If


                    mnu = CType(.Item("tsmPrint"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.PrintReport
                    mnu.Text = r("_In") '&In

                    mnu = CType(.Item("tsmExportToExcel"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.ExportToExcel
                    mnu.Text = r("Xuat__Excel") 'Xuất &Excel

                    mnu = CType(.Item("tsmImportData"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.ImportData
                    mnu.Text = r("Import__du_lieu") 'Import &dữ liệu 

                    mnu = CType(.Item("tsmEditOther"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.EditOther
                    mnu.Text = r("Sua_khac_(_O)") 'Sửa khác (&O)

                    mnu = CType(.Item("tsmEditVoucher"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.EditVoucher
                    mnu.Text = r("Sua_so_phie_u") 'Sửa số phiế&u

                    mnu = CType(.Item("tsmIssueStock"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.IssueStock
                    mnu.Text = r("Xuat_kho") 'Xuất kho

                    mnu = CType(.Item("tsmLocked"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.LockVoucher
                    mnu.Text = r("Khoa__phieu") 'Khóa &phiếu

                    mnu = CType(.Item("tsmLockVoucher"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.LockVoucher
                    mnu.Text = r("Khoa__phieu") 'Khóa &phiếu

                    mnu = CType(.Item("tsmShowDetail"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.ShowDetail
                    mnu.Text = r("Hien_thi__chi_tiet") 'Hiển thị &chi tiết

                    mnu = CType(.Item("tsmApprove"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.approve
                    mnu.Text = r("_Duyet") '&Duyệt

                    mnu = CType(.Item("tsmCancelVoucher"), ToolStripMenuItem)
                    mnu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
                    mnu.Image = My.Resources.CancelVoucher
                    mnu.Text = r("Huy_phieu") '&Hủy phiếu

                    mnu = CType(.Item("tsmExportOut"), ToolStripMenuItem)
                    mnu.Image = My.Resources.ExportToExcelOut
                    mnu.Text = r("X_uat_Excel_truc_tiep") '&Hủy phiếu

                    'Update  1/3/2013
                    mnu = CType(.Item("tsmExportDataScript"), ToolStripMenuItem)
                    mnu.Image = My.Resources.ExportDataScript
                    mnu.Text = r("MSG000051") 'X&uất dữ liệu
                End With
            End If
        End If
        'Update 19/07/2011: Set ShortCut cho ContextMenuStrip (Áp dụng cho một số đối tượng có sử dụng đến Menu nóng: Lưới, treeview...)
        If ContextMenuStrip IsNot Nothing Then
            With ContextMenuStrip
                'mnuAdd
                .Items("mnsAdd").Image = My.Resources.add
                .Items("mnsAdd").Text = r("_Them") '&Thêm
                CType(.Items("mnsAdd"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)

                'mnuInherit
                .Items("mnsInherit").Image = My.Resources.copy
                .Items("mnsInherit").Text = r("Ke_thu_a") 'Kế thừ&a
                CType(.Items("mnsInherit"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)

                'mnuView
                .Items("mnsView").Image = My.Resources.view
                .Items("mnsView").Text = r("Xe_m") 'Xe&m
                CType(.Items("mnsView"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)

                'mnuEdit
                .Items("mnsEdit").Image = My.Resources.edit
                .Items("mnsEdit").Text = r("_Sua") '&Sửa
                CType(.Items("mnsEdit"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)

                'mnuDelete
                .Items("mnsDelete").Image = My.Resources.delete
                .Items("mnsDelete").Text = r("_Xoa") '&Xóa
                CType(.Items("mnsDelete"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)

                'mnuFind
                .Items("mnsFind").Image = My.Resources.find
                .Items("mnsFind").Text = r("Tim__kiem") 'Tìm &kiếm
                CType(.Items("mnsFind"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)

                'mnuListAll
                .Items("mnsListAll").Image = My.Resources.ListAll
                .Items("mnsListAll").Text = r("_Liet_ke_tat_ca") '&Liệt kế tất cả
                CType(.Items("mnsListAll"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)

                'mnuSysInfo
                .Items("mnsSysInfo").Image = My.Resources.SysInfo
                If bTransactionHistory Then
                    .Items("mnsSysInfo").Text = r("Lich_su_tac_dong") 'Lịch sử tác động
                Else
                    .Items("mnsSysInfo").Text = r("Thong_tin__he_thong") 'Thông tin &hệ thống
                End If
                CType(.Items("mnsSysInfo"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)

                'mnuPrint
                .Items("mnsPrint").Image = My.Resources.PrintReport
                .Items("mnsPrint").Text = r("_In") '&In
                CType(.Items("mnsPrint"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)

                'mnuExportToExcel
                .Items("mnsExportToExcel").Image = My.Resources.ExportToExcel
                .Items("mnsExportToExcel").Text = r("Xuat__Excel") 'Xuất &Excel
                CType(.Items("mnsExportToExcel"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)

                'mnuEditOther
                .Items("mnsEditOther").Image = My.Resources.EditOther
                .Items("mnsEditOther").Text = r("Sua_khac_(_O)") 'Sửa khác (&O)
                CType(.Items("mnsEditOther"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)

                'mnuEditVoucher
                .Items("mnsEditVoucher").Image = My.Resources.EditVoucher
                .Items("mnsEditVoucher").Text = r("Sua_so_phie_u") 'Sửa số phiế&u
                CType(.Items("mnsEditVoucher"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)

                'mnuIssueStock
                .Items("mnsIssueStock").Image = My.Resources.IssueStock
                .Items("mnsIssueStock").Text = r("Xuat_kho") 'Xuất kho
                CType(.Items("mnsIssueStock"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)

                'mnuLockVoucher
                .Items("mnsLocked").Image = My.Resources.LockVoucher
                .Items("mnsLocked").Text = r("Khoa__phieu") 'Khóa &phiếu
                CType(.Items("mnsLocked"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)

                .Items("mnsLockVoucher").Image = My.Resources.LockVoucher
                .Items("mnsLockVoucher").Text = r("Khoa__phieu") 'Khóa &phiếu
                CType(.Items("mnsLockVoucher"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)

                'mnuShowDetail
                .Items("mnsShowDetail").Image = My.Resources.ShowDetail
                .Items("mnsShowDetail").Text = r("Hien_thi__chi_tiet") 'Hiển thị &chi tiết
                CType(.Items("mnsShowDetail"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)

                'mnuApprove
                .Items("mnsApprove").Image = My.Resources.approve
                .Items("mnsApprove").Text = r("_Duyet") '&Duyệt
                CType(.Items("mnsApprove"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)

                'mnuCancelVoucher
                .Items("mnsCancelVoucher").Image = My.Resources.CancelVoucher
                .Items("mnsCancelVoucher").Text = r("Huy_phieu") '&Hủy phiếu
                CType(.Items("mnsCancelVoucher"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)

                'mnuImportData
                .Items("mnsImportData").Image = My.Resources.ImportData
                .Items("mnsImportData").Text = r("Import__du_lieu") 'Import &dữ liệu 
                CType(.Items("mnsImportData"), System.Windows.Forms.ToolStripMenuItem).ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)

                'mnuExportOut
                .Items("mnsExportOut").Image = My.Resources.ExportToExcelOut
                .Items("mnsExportOut").Text = r("X_uat_Excel_truc_tiep") 'Import &dữ liệu 

                'mnuExportDataScript
                .Items("mnsExportDataScript").Image = My.Resources.ExportDataScript
                .Items("mnsExportDataScript").Text = r("MSG000051") 'X&uất dữ liệu 
            End With
        End If

        'Các phím chung của sự kiện Form_Keydown
        AddHandler Form.KeyDown, AddressOf Form_KeyDown
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.Control Then
            Dim MainControl As Form
            MainControl = CType(sender, Form)
            Select Case e.KeyCode
                'Case Keys.N 'Thêm mới
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbAdd")
                '            Exit Sub
                '        End If
                '    Next
                'Case Keys.E 'Sửa
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbEdit")
                '            Exit Sub
                '        End If
                '    Next
                'Case Keys.D 'Xóa
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbDelete")
                '            Exit Sub
                '        End If
                '    Next
                'Case Keys.F 'Tìm kiếm
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbFind")
                '            Exit Sub
                '        End If
                '    Next
                'Case Keys.A 'Liệt kê tất cả
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbListAll")
                '            Exit Sub
                '        End If
                '    Next
                'Case Keys.P 'In
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbPrint")
                '            Exit Sub
                '        End If
                '    Next
                'Case Keys.X 'Xuất Excel
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbExportToExcel")
                '            Exit Sub
                '        End If
                '    Next
                'Case Keys.M 'Import Excel
                '    For Each ctrl As Control In MainControl.Controls
                '        If ctrl.GetType.Name = "ToolStrip" Then
                '            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbImportData")
                '            Exit Sub
                '        End If
                '    Next
                Case Keys.Q 'Đóng form
                    For Each ctrl As Control In MainControl.Controls
                        If ctrl.GetType.Name = "ToolStrip" Then
                            CallClick_ToolStripButton(CType(ctrl, ToolStrip), "tsbClose")
                            Exit Sub
                        End If
                    Next
            End Select
        End If

    End Sub

    Private Sub CallClick_ToolStripButton(ByVal ctrl As ToolStrip, ByVal ItemName As String)
        Dim tsbButton As ToolStripButton = CType(ctrl.Items(ItemName), ToolStripButton)
        If tsbButton IsNot Nothing AndAlso tsbButton.Enabled AndAlso tsbButton.Visible Then
            ctrl.Items(ItemName).PerformClick()
        End If
    End Sub

#End Region

#Region "Chỉ cho gõ phím tắt trên lưới"
    ''' <summary>
    ''' Chặn phím tắt của popup menu
    ''' </summary>
    ''' <param name="tdbg"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    ''' <remarks>Tại sự kiện của các menu kiểm tra: If CallMenuFromGrid(tdbg, e) = False Then Exit Sub</remarks>
    <DebuggerStepThrough()> _
    Public Function CallMenuFromGrid(ByVal tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal e As C1.Win.C1Command.ClickEventArgs) As Boolean
        If e Is Nothing Then
            Return True
        End If

        Select Case e.ClickSource
            Case C1.Win.C1Command.ClickSourceEnum.External
                Return False
            Case C1.Win.C1Command.ClickSourceEnum.Shortcut
                If tdbg.Focused = False Then
                    Return False
                End If
            Case C1.Win.C1Command.ClickSourceEnum.None
                Return False
        End Select
        Return True
    End Function

    Public Function CallMenuFromGrid(ByVal sender As Object, ByVal tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid) As Boolean
        If sender IsNot Nothing Then
            Select Case sender.GetType.Name
                Case "ToolStripMenuItem"
                    Dim ctrl As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
                    If ctrl.Enabled = False Then Return False
                    'Khi không có dữ liệu và đang ở Filter Bar vẫn cho Thêm mới
                    If tdbg.Focused And (ctrl.Name.Contains("Add") OrElse ctrl.Name.Contains("Find") OrElse ctrl.Name.Contains("ListAll")) Then Return True
                Case "ToolStripButton"
                    Dim ctrl As ToolStripButton = CType(sender, ToolStripButton)
                    If tdbg.Focused And (ctrl.Name.Contains("Add") OrElse ctrl.Name.Contains("Find") OrElse ctrl.Name.Contains("ListAll")) Then Return True
            End Select
        End If
        If tdbg.RowCount <= 0 OrElse tdbg.FilterActive OrElse tdbg.Focused = False Then Return False
        Return True
    End Function

#End Region

End Module
