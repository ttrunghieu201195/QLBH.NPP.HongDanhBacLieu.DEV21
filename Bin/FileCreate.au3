; Sets a shortcut with ctrl+alt+t hotkey
FileCreateShortcut(@WorkingDir & "\Perfect.INVENTORY.exe",@DesktopDir & "\Phần Mềm Quản Lý Kho.lnk")

DirCreate(@StartMenuDir & "\Programs\Hoàn Hảo Software\Phần Mềm Quản Lý Kho");

FileCreateShortcut(@WorkingDir & "\Perfect.INVENTORY.exe",@StartMenuDir & "\Programs\Hoàn Hảo Software\Phần Mềm Quản Lý Kho" & "\Phần Mềm Quản Lý Kho.lnk")
FileCreateShortcut(@WorkingDir & "\Perfect.Update.exe",@StartMenuDir & "\Programs\Hoàn Hảo Software\Phần Mềm Quản Lý Kho" & "\Cập Nhật Trực Tuyến.lnk")
FileCreateShortcut(@WorkingDir & "\Userguide.pdf",@StartMenuDir & "\Programs\Hoàn Hảo Software\Phần Mềm Quản Lý Kho" & "\Hướng Dẫn Sử Dụng.lnk",@WorkingDir,"",@WorkingDir,@WorkingDir & "\HLP.ico")
FileCreateShortcut(@WorkingDir & "\Perfect.Data.exe",@StartMenuDir & "\Programs\Hoàn Hảo Software\Phần Mềm Quản Lý Kho" & "\Quản Lý Cơ Sở Dữ Liệu.lnk")
FileCreateShortcut("mailto:sale@perfect.com.vn",@StartMenuDir & "\Programs\Hoàn Hảo Software\Phần Mềm Quản Lý Kho" & "\Liên Hệ.lnk","","","",@WorkingDir & "\EML.ico")
FileCreateShortcut("http://www.perfect.com.vn",@StartMenuDir & "\Programs\Hoàn Hảo Software\Phần Mềm Quản Lý Kho" & "\Trang Chủ.lnk","","","",@WorkingDir & "\IE.ico")