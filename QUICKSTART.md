# 🚀 Quick Start Guide - COCÔTTE Restaurant Website

## 📋 Yêu Cầu Hệ Thống

- **.NET SDK 8.0** hoặc cao hơn
- **Visual Studio 2022** / **VS Code** / **Rider**
- **Git** (để clone repository)
- Trình duyệt web hiện đại (Chrome, Firefox, Edge)

## 💻 Cài Đặt .NET SDK

### Windows:
1. Tải từ: https://dotnet.microsoft.com/download/dotnet/8.0
2. Chạy installer và làm theo hướng dẫn
3. Kiểm tra: Mở Command Prompt và gõ `dotnet --version`

### macOS:
```bash
# Sử dụng Homebrew
brew install dotnet-sdk
```

### Linux (Ubuntu/Debian):
```bash
wget https://dot.net/v1/dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --channel 8.0
```

## 📥 Bước 1: Clone Repository

```bash
# Clone repository
git clone https://github.com/Dopi111/Quan-Ly-Nha-Hang-MVC.git

# Di chuyển vào thư mục project
cd Quan-Ly-Nha-Hang-MVC

# Checkout branch wireframe
git checkout claude/restaurant-website-wireframe-011CUmuXnqZDnywPx1eaKq1C
```

## ⚙️ Bước 2: Restore & Build

```bash
# Khôi phục dependencies
dotnet restore

# Build project
dotnet build
```

## ▶️ Bước 3: Chạy Ứng Dụng

### Option A: Sử dụng Command Line
```bash
# Chạy project
dotnet run

# Hoặc chạy với hot reload
dotnet watch run
```

### Option B: Sử dụng Visual Studio
1. Mở file `WebNhaHang.sln`
2. Nhấn `F5` (Start Debugging) hoặc `Ctrl+F5` (Start Without Debugging)

### Option C: Sử dụng VS Code
1. Mở thư mục project: `code .`
2. Cài extension: **C# Dev Kit**
3. Nhấn `F5` để run

## 🌐 Bước 4: Mở Trình Duyệt

Sau khi chạy, truy cập:
- **HTTP**: http://localhost:5000
- **HTTPS**: https://localhost:5001

## 🎯 Các Trang Chính Để Test

### Trang Khách Hàng:
```
🏠 Trang chủ:          http://localhost:5000
📖 Giới thiệu:         http://localhost:5000/OurStory
🍽️  Thực đơn:          http://localhost:5000/Menu
📍 Chi nhánh:          http://localhost:5000/Locations
📅 Đặt bàn:            http://localhost:5000/Reservation
🛒 Giỏ hàng:           http://localhost:5000/Cart
🎉 Sự kiện:            http://localhost:5000/Events
📝 Blog:               http://localhost:5000/Blog
📞 Liên hệ:            http://localhost:5000/Contact
👤 Đăng nhập:          http://localhost:5000/Account/Login
✍️  Đăng ký:            http://localhost:5000/Account/Register
```

### Trang Admin:
```
🔐 Admin Login:        http://localhost:5000/Admin/Login
📊 Dashboard:          http://localhost:5000/Admin/Dashboard
🍴 Quản lý Menu:       http://localhost:5000/Admin/ManageMenu
📦 Quản lý Orders:     http://localhost:5000/Admin/ManageOrders
📅 Quản lý Đặt bàn:    http://localhost:5000/Admin/ManageReservations
📰 Quản lý Blog:       http://localhost:5000/Admin/ManageBlogs
🎊 Quản lý Events:     http://localhost:5000/Admin/ManageEvents
```

## 🔑 Thông Tin Đăng Nhập

### Admin Account (Demo):
- **Email**: `admin@cocotte.vn`
- **Password**: `admin123`
- **URL**: http://localhost:5000/Admin/Login

### Customer Account:
- Đăng ký tài khoản mới tại: `/Account/Register`
- Hoặc đăng nhập với bất kỳ email/password nào (demo mode)

## 🎨 Features Đã Implement

✅ **Navigation**: Header với tất cả links, mobile menu
✅ **19 Wireframe Pages**: Tất cả trang đã được tạo
✅ **Admin Dashboard**: Login, statistics, management pages
✅ **Session Auth**: Login/logout với session
✅ **Forms**: Reservation, checkout, contact, registration
✅ **Responsive**: Mobile-friendly với Tailwind CSS
✅ **404 Page**: Custom error page

## ⚠️ Lưu Ý (Demo Mode)

Đây là **wireframe/prototype**, do đó:
- ❌ Không có database (data là hardcoded)
- ❌ Forms không lưu vào database
- ❌ Login chấp nhận bất kỳ credentials nào
- ❌ Cart chỉ hiển thị sample data
- ❌ Không gửi email thật

## 🛠️ Troubleshooting

### Port đã được sử dụng
```bash
# Thay đổi port trong launchSettings.json
# Hoặc kill process đang dùng port 5000/5001
```

### Lỗi restore packages
```bash
# Clear cache và restore lại
dotnet nuget locals all --clear
dotnet restore
```

### Lỗi build
```bash
# Clean và rebuild
dotnet clean
dotnet build
```

### Không thấy Tailwind CSS
- Tailwind được load từ CDN trong `_Layout.cshtml`
- Cần kết nối internet để xem styling

## 📚 Tài Liệu Bổ Sung

- **Testing Guide**: Xem file `README_TESTING.md`
- **Project Structure**: Xem thư mục Controllers, Models, Views
- **Wireframe List**: Tất cả 19 trang trong task description

## 🚀 Next Steps

1. ✅ Test tất cả các trang
2. ⏭️ Thêm Entity Framework Core (nếu cần)
3. ⏭️ Tạo database và migrations
4. ⏭️ Implement real authentication
5. ⏭️ Add CRUD operations

## 💡 Tips

- Sử dụng `dotnet watch run` để auto-reload khi code thay đổi
- Mở Developer Tools (F12) để debug
- Kiểm tra responsive bằng cách resize browser
- Test mobile menu bằng cách thu nhỏ cửa sổ

---

**Happy Coding! 🎉**

Need help? Contact: info@cocotte.vn
