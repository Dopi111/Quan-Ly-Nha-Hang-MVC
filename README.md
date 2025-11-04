# 🍽️ COCÔTTE - Restaurant Management System

<div align="center">

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind_CSS-38B2AC?style=for-the-badge&logo=tailwind-css&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)

**Hệ thống quản lý nhà hàng hiện đại với giao diện thân thiện và đầy đủ tính năng**

[🚀 Demo](#-demo) • [📖 Tài Liệu](#-tài-liệu) • [💻 Cài Đặt](#-cài-đặt) • [🎯 Tính Năng](#-tính-năng)

</div>

---

## 📋 Mục Lục

- [Giới Thiệu](#-giới-thiệu)
- [Tính Năng](#-tính-năng)
- [Công Nghệ](#-công-nghệ-sử-dụng)
- [Yêu Cầu Hệ Thống](#-yêu-cầu-hệ-thống)
- [Cài Đặt](#-cài-đặt)
- [Chạy Dự Án](#-chạy-dự-án)
- [Cấu Trúc Dự Án](#-cấu-trúc-dự-án)
- [Tài Khoản Demo](#-tài-khoản-demo)
- [Screenshots](#-screenshots)
- [API Endpoints](#-api-endpoints)
- [Roadmap](#-roadmap)
- [Đóng Góp](#-đóng-góp)
- [License](#-license)

---

## 🎯 Giới Thiệu

**COCÔTTE** là một hệ thống quản lý nhà hàng toàn diện được xây dựng trên nền tảng **ASP.NET Core MVC 8.0**. Dự án cung cấp giải pháp quản lý hoàn chỉnh cho nhà hàng với giao diện người dùng hiện đại, responsive và dễ sử dụng.

### 🌟 Điểm Nổi Bật

- ✨ **Giao diện hiện đại** với Tailwind CSS và Bootstrap 5
- 📱 **Responsive Design** - Hoạt động mượt mà trên mọi thiết bị
- 🎨 **UI/UX tối ưu** - Trải nghiệm người dùng tuyệt vời
- 🔐 **Hệ thống phân quyền** - Admin và Customer
- 🛒 **Đặt món trực tuyến** - Giỏ hàng và thanh toán
- 📅 **Đặt bàn online** - Quản lý reservation hiệu quả
- 📊 **Admin Dashboard** - Thống kê và quản lý toàn diện

---

## 🎯 Tính Năng

### 👥 Dành Cho Khách Hàng

#### 🏠 Trang Công Khai
- **Trang chủ** - Giới thiệu nhà hàng, món ăn nổi bật, địa điểm
- **Giới thiệu** - Câu chuyện, giá trị, đội ngũ nhà hàng
- **Thực đơn** - Danh sách món ăn với hình ảnh và giá cả
- **Chi tiết món ăn** - Thông tin chi tiết, thành phần, reviews
- **Chi nhánh** - Danh sách và thông tin các chi nhánh
- **Blog** - Tin tức, công thức, tips nấu ăn
- **Sự kiện** - Events, workshops, catering services
- **Liên hệ** - Form liên hệ, bản đồ, thông tin

#### 🛒 Tính Năng Mua Hàng
- **Giỏ hàng** - Thêm/xóa món, cập nhật số lượng
- **Thanh toán** - Multiple payment methods (COD, Bank, Card, MoMo)
- **Theo dõi đơn hàng** - Xem lịch sử và trạng thái đơn hàng
- **Đặt bàn** - Reservation system với xác nhận tự động

#### 👤 Tài Khoản
- **Đăng ký/Đăng nhập** - Authentication system
- **Hồ sơ cá nhân** - Quản lý thông tin tài khoản
- **Lịch sử đơn hàng** - Xem orders đã đặt
- **Lịch sử đặt bàn** - Quản lý reservations

### 🔧 Dành Cho Admin

#### 📊 Dashboard
- **Thống kê tổng quan** - Orders, Revenue, Reservations
- **Biểu đồ** - Doanh thu theo thời gian
- **Hoạt động gần đây** - Recent orders & reservations
- **Quick Actions** - Truy cập nhanh các chức năng

#### 🍽️ Quản Lý
- **Quản lý thực đơn** - CRUD dishes, categories, pricing
- **Quản lý đơn hàng** - Xem, xử lý, cập nhật trạng thái orders
- **Quản lý đặt bàn** - Confirm, cancel reservations
- **Quản lý blog** - Tạo, sửa, xóa blog posts
- **Quản lý sự kiện** - Event management
- **Quản lý chi nhánh** - Location management
- **Quản lý khách hàng** - Customer database

---

## 💻 Công Nghệ Sử Dụng

### Backend
- **Framework**: ASP.NET Core MVC 8.0
- **Language**: C# 12
- **Architecture**: MVC Pattern
- **Session**: In-Memory Session Storage

### Frontend
- **CSS Frameworks**:
  - Tailwind CSS 3.x (via CDN)
  - Bootstrap 5.3
- **JavaScript**:
  - jQuery 3.6+
  - Vanilla JS
- **Icons**: SVG Icons, Bootstrap Icons

### Development Tools
- **IDE**: Visual Studio 2022 / VS Code / Rider
- **Version Control**: Git & GitHub
- **Package Manager**: NuGet

### Future Integration (Planned)
- **Database**: Entity Framework Core + SQL Server
- **Authentication**: ASP.NET Core Identity
- **API**: RESTful API with Swagger
- **Payment**: Stripe, MoMo, VNPay
- **Email**: SendGrid / SMTP
- **Image Storage**: Azure Blob / Cloudinary

---

## 📋 Yêu Cầu Hệ Thống

### Bắt Buộc
- **.NET SDK 8.0 or later** ([Download](https://dotnet.microsoft.com/download/dotnet/8.0))
- **Git** ([Download](https://git-scm.com/downloads))
- **Visual Studio 2022** / **VS Code** / **Rider**
- **Trình duyệt web** (Chrome, Firefox, Edge)

### Khuyến Nghị
- **RAM**: 8GB trở lên
- **Ổ cứng**: 500MB free space
- **Internet**: Để tải packages và Tailwind CSS từ CDN

---

## 🚀 Cài Đặt

### Bước 1: Clone Repository

```bash
# Clone từ GitHub
git clone https://github.com/Dopi111/Quan-Ly-Nha-Hang-MVC.git

# Di chuyển vào thư mục project
cd Quan-Ly-Nha-Hang-MVC

# Checkout branch wireframe
git checkout claude/restaurant-website-wireframe-011CUmuXnqZDnywPx1eaKq1C
```

### Bước 2: Restore Dependencies

```bash
# Restore NuGet packages
dotnet restore
```

### Bước 3: Build Project

```bash
# Build project
dotnet build

# Hoặc build với configuration Release
dotnet build --configuration Release
```

---

## ▶️ Chạy Dự Án

### Option 1: Command Line (Khuyến nghị)

```bash
# Chạy project
dotnet run

# Hoặc chạy với hot reload (auto-refresh khi code thay đổi)
dotnet watch run
```

### Option 2: Visual Studio

1. Mở file `WebNhaHang.sln`
2. Nhấn **F5** (Start Debugging)
3. Hoặc **Ctrl+F5** (Start Without Debugging)

### Option 3: Visual Studio Code

```bash
# Mở VS Code
code .

# Install C# Dev Kit extension
# Nhấn F5 để run
```

### Truy Cập Ứng Dụng

Sau khi chạy thành công, mở trình duyệt và truy cập:

- **HTTP**: http://localhost:5000
- **HTTPS**: https://localhost:5001

---

## 📁 Cấu Trúc Dự Án

```
Quan-Ly-Nha-Hang-MVC/
│
├── Controllers/                 # MVC Controllers
│   ├── HomeController.cs       # Trang chủ, error pages
│   ├── MenuController.cs       # Thực đơn
│   ├── LocationsController.cs  # Chi nhánh
│   ├── ReservationController.cs # Đặt bàn
│   ├── CartController.cs       # Giỏ hàng & checkout
│   ├── AccountController.cs    # Authentication
│   ├── AdminController.cs      # Admin dashboard
│   ├── BlogController.cs       # Blog
│   ├── EventsController.cs     # Events
│   └── ContactController.cs    # Liên hệ
│
├── Models/                     # Data Models
│   ├── Dish.cs                # Món ăn
│   ├── Location.cs            # Chi nhánh
│   ├── Reservation.cs         # Đặt bàn
│   ├── Order.cs               # Đơn hàng
│   ├── CartItem.cs            # Giỏ hàng
│   ├── ApplicationUser.cs     # User
│   ├── BlogPost.cs            # Blog
│   ├── Event.cs               # Sự kiện
│   └── ErrorViewModel.cs      # Error handling
│
├── Views/                      # Razor Views
│   ├── Home/                  # Trang chủ
│   ├── Menu/                  # Thực đơn
│   ├── Locations/             # Chi nhánh
│   ├── Reservation/           # Đặt bàn
│   ├── Cart/                  # Giỏ hàng
│   ├── Account/               # Đăng nhập/ký
│   ├── Admin/                 # Admin pages
│   ├── Blog/                  # Blog
│   ├── Events/                # Sự kiện
│   ├── Contact/               # Liên hệ
│   └── Shared/                # Shared components
│       ├── _Layout.cshtml     # Main layout
│       ├── _Header.cshtml     # Navigation
│       ├── _Footer.cshtml     # Footer
│       ├── _Hero.cshtml       # Hero section
│       └── NotFound.cshtml    # 404 page
│
├── wwwroot/                    # Static files
│   ├── css/                   # Stylesheets
│   ├── js/                    # JavaScript
│   ├── lib/                   # Third-party libraries
│   └── images/                # Images
│
├── Program.cs                  # Application entry point
├── appsettings.json           # Configuration
├── WebNhaHang.csproj          # Project file
├── README.md                  # Bạn đang ở đây!
├── QUICKSTART.md              # Quick start guide
└── README_TESTING.md          # Testing guide
```

---

## 🔑 Tài Khoản Demo

### 👨‍💼 Admin Account
```
URL: http://localhost:5000/Admin/Login
Email: admin@cocotte.vn
Password: admin123
```

**Quyền hạn:**
- Truy cập Admin Dashboard
- Quản lý Menu, Orders, Reservations
- Quản lý Blog, Events
- Xem thống kê và báo cáo

### 👤 Customer Account
```
URL: http://localhost:5000/Account/Register
```
- Đăng ký tài khoản mới
- Hoặc đăng nhập với bất kỳ email/password nào (demo mode)

---

## 📸 Screenshots

### 🏠 Customer Pages

**Trang Chủ**
- Hero section với featured dishes
- Popular locations
- Testimonials

**Thực Đơn**
- Grid layout với hình ảnh món ăn
- Categories filter
- Price display

**Đặt Bàn**
- Form đặt bàn với date/time picker
- Location selection
- Confirmation page

**Giỏ Hàng & Thanh Toán**
- Cart items với quantity controls
- Order summary
- Multiple payment methods

### 👨‍💼 Admin Pages

**Dashboard**
- Statistics cards (Orders, Revenue, Reservations)
- Quick action buttons
- Recent activity feed

**Management Pages**
- Data tables với pagination
- Search & filters
- CRUD operations

---

## 🌐 API Endpoints

### Customer Endpoints

```
GET  /                          # Home page
GET  /Menu                      # Menu listing
GET  /Menu/Detail/{id}          # Dish details
GET  /Locations                 # All locations
GET  /Locations/Detail/{id}     # Location details
GET  /Reservation               # Reservation form
POST /Reservation/Create        # Create reservation
GET  /Cart                      # View cart
POST /Cart/Add                  # Add to cart
GET  /Cart/Checkout             # Checkout page
POST /Cart/ProcessCheckout      # Process order
GET  /Account/Login             # Login page
POST /Account/Login             # Login action
GET  /Account/Register          # Register page
POST /Account/Register          # Register action
GET  /Account/Profile           # User profile
```

### Admin Endpoints

```
GET  /Admin/Login               # Admin login
POST /Admin/Login               # Admin login action
GET  /Admin/Dashboard           # Admin dashboard
GET  /Admin/ManageMenu          # Menu management
GET  /Admin/ManageOrders        # Order management
GET  /Admin/ManageReservations  # Reservation management
GET  /Admin/ManageBlogs         # Blog management
GET  /Admin/ManageEvents        # Event management
```

---

## 🎯 Tính Năng Hiện Tại vs Tương Lai

### ✅ Đã Implement (Wireframe/Prototype)
- [x] 19+ pages với responsive design
- [x] Navigation system đầy đủ
- [x] Session-based authentication
- [x] Admin dashboard với statistics
- [x] Form submissions (không lưu database)
- [x] 404 error handling
- [x] Mobile responsive menu

### 🔜 Đang Phát Triển
- [ ] Entity Framework Core integration
- [ ] Database (SQL Server)
- [ ] Real authentication với Identity
- [ ] CRUD operations cho tất cả entities
- [ ] Image upload functionality
- [ ] Email notifications
- [ ] Search & advanced filters
- [ ] Pagination
- [ ] Cart persistence (database)

### 🎯 Roadmap
- [ ] Payment gateway integration (MoMo, VNPay)
- [ ] Real-time notifications (SignalR)
- [ ] Reviews & ratings system
- [ ] Loyalty program
- [ ] Mobile app (React Native)
- [ ] Analytics dashboard
- [ ] Multi-language support
- [ ] API documentation (Swagger)
- [ ] Unit & Integration tests
- [ ] Docker containerization
- [ ] CI/CD pipeline

---

## ⚠️ Lưu Ý Quan Trọng

### 🚧 Demo Mode

Đây là phiên bản **WIREFRAME/PROTOTYPE**, do đó:

❌ **Không có:**
- Database persistence (data là hardcoded)
- Real authentication (chấp nhận mọi credentials)
- Image uploads
- Email sending
- Payment processing
- Data validation nghiêm ngặt

✅ **Có:**
- UI/UX hoàn chỉnh cho tất cả pages
- Navigation flow logic
- Form submissions (hiển thị confirmation)
- Session management cơ bản
- Admin access control
- Responsive design

---

## 🐛 Troubleshooting

### Port đã được sử dụng

```bash
# Windows
netstat -ano | findstr :5000
taskkill /PID <PID> /F

# Mac/Linux
lsof -ti:5000 | xargs kill -9
```

### Lỗi restore packages

```bash
dotnet nuget locals all --clear
dotnet restore
```

### Không thấy Tailwind CSS styling

- Kiểm tra kết nối internet (Tailwind load từ CDN)
- Hard refresh: Ctrl+F5
- Xóa cache trình duyệt

### Build errors

```bash
dotnet clean
dotnet build --no-incremental
```

---

## 🤝 Đóng Góp

Contributions are welcome! Nếu bạn muốn đóng góp:

1. Fork repository
2. Tạo branch mới (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Mở Pull Request

### Coding Standards

- Tuân thủ C# coding conventions
- Comment code khi cần thiết
- Test thoroughly trước khi commit
- Write meaningful commit messages

---

## 📚 Tài Liệu Tham Khảo

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Tailwind CSS Docs](https://tailwindcss.com/docs)
- [Bootstrap 5 Docs](https://getbootstrap.com/docs/5.3/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

### Tài Liệu Dự Án

- **QUICKSTART.md** - Hướng dẫn bắt đầu nhanh
- **README_TESTING.md** - Hướng dẫn test chi tiết

---

## 📞 Liên Hệ

**COCÔTTE Restaurant**

- 🌐 Website: http://localhost:5000
- 📧 Email: info@cocotte.vn
- 📱 Phone: (028) 3825 1234
- 📍 Locations: Sài Gòn, Việt Nam

### Developers

- **GitHub**: [Dopi111](https://github.com/Dopi111)
- **Repository**: [Quan-Ly-Nha-Hang-MVC](https://github.com/Dopi111/Quan-Ly-Nha-Hang-MVC)

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

```
MIT License

Copyright (c) 2024 COCÔTTE Restaurant

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files...
```

---

## 🙏 Acknowledgments

- ASP.NET Core Team
- Tailwind CSS
- Bootstrap
- Font Awesome / Bootstrap Icons
- All contributors and testers

---

<div align="center">

**⭐ Nếu project hữu ích, hãy cho một star! ⭐**

Made with ❤️ by COCÔTTE Team

</div>
