# 🧪 Hướng Dẫn Test Website Nhà Hàng COCÔTTE

## 📋 Danh Sách Các Trang Cần Test

### ✅ Trang Khách Hàng (Customer Pages)

1. **Trang Chủ (Home)**
   - URL: `/` hoặc `/Home/Index`
   - Test: Xem featured dishes, locations, hero section

2. **Giới Thiệu (About Us)**
   - URL: `/OurStory/Index`
   - Test: Story, values, team section

3. **Thực Đơn (Menu)**
   - URL: `/Menu/Index`
   - Test: Danh sách món ăn

4. **Chi Tiết Món Ăn (Menu Detail)**
   - URL: `/Menu/Detail/1`
   - Test: Thông tin chi tiết món

5. **Chi Nhánh (Locations)**
   - URL: `/Locations/Index`
   - Test: Danh sách 3 chi nhánh (Sila, Ben Thanh, DaKao)

6. **Chi Tiết Chi Nhánh (Location Detail)**
   - URL: `/Locations/Detail/1`
   - Test: Thông tin chi nhánh, map, amenities

7. **Đặt Bàn (Reservation)**
   - URL: `/Reservation/Index`
   - Test:
     - Điền form (tên, email, phone, số người, ngày, giờ, chi nhánh)
     - Submit form
     - Xem trang confirmation

8. **Sự Kiện (Events)**
   - URL: `/Events/Index`
   - Test: Danh sách events

9. **Chi Tiết Sự Kiện (Event Detail)**
   - URL: `/Events/Detail/1`
   - Test: Thông tin event, registration

10. **Blog**
    - URL: `/Blog/Index`
    - Test: Danh sách bài viết

11. **Chi Tiết Blog (Blog Detail)**
    - URL: `/Blog/Detail/1`
    - Test: Nội dung bài viết

12. **Liên Hệ (Contact)**
    - URL: `/Contact/Index`
    - Test: Contact form

13. **Giỏ Hàng (Cart)**
    - URL: `/Cart/Index`
    - Test: Xem giỏ hàng (hiện tại là sample data)

14. **Thanh Toán (Checkout)**
    - URL: `/Cart/Checkout`
    - Test:
      - Điền thông tin giao hàng
      - Chọn phương thức thanh toán
      - Submit order
      - Xem order confirmation

15. **Đăng Ký (Register)**
    - URL: `/Account/Register`
    - Test:
      - Điền form đăng ký
      - Submit (chưa lưu database, chỉ redirect)

16. **Đăng Nhập (Login)**
    - URL: `/Account/Login`
    - Test:
      - Nhập email & password bất kỳ
      - Login thành công → redirect to Profile

17. **Hồ Sơ (Profile)**
    - URL: `/Account/Profile`
    - Test:
      - Phải login trước
      - Xem thông tin user
      - Xem orders, reservations

18. **404 Error Page**
    - URL: `/NonExistentPage` (bất kỳ URL không tồn tại)
    - Test: Hiển thị trang 404 đẹp

### ✅ Trang Admin (Admin Pages)

19. **Admin Login**
    - URL: `/Admin/Login`
    - Test:
      - Email: `admin@cocotte.vn`
      - Password: `admin123`
      - Login → redirect to Dashboard

20. **Admin Dashboard**
    - URL: `/Admin/Dashboard`
    - Test:
      - Xem statistics (orders, reservations, revenue)
      - Xem quick actions
      - Xem recent activity

21. **Quản Lý Thực Đơn (Manage Menu)**
    - URL: `/Admin/ManageMenu`
    - Test: Xem danh sách món ăn trong bảng

22. **Quản Lý Đơn Hàng (Manage Orders)**
    - URL: `/Admin/ManageOrders`
    - Test: Xem danh sách đơn hàng

23. **Quản Lý Đặt Bàn (Manage Reservations)**
    - URL: `/Admin/ManageReservations`
    - Test: Xem danh sách đặt bàn

24. **Quản Lý Blog (Manage Blogs)**
    - URL: `/Admin/ManageBlogs`
    - Test: Xem danh sách blog posts

25. **Quản Lý Sự Kiện (Manage Events)**
    - URL: `/Admin/ManageEvents`
    - Test: Xem danh sách events

## 🔄 Test Flow Scenarios

### Scenario 1: Customer Journey - Đặt Bàn
1. Vào trang chủ → Click "Đặt Bàn" trong header
2. Điền form đặt bàn
3. Submit và xem confirmation page
4. Check email (trong production sẽ gửi email)

### Scenario 2: Customer Journey - Đặt Hàng
1. Vào Menu → Xem món ăn
2. Click "Thêm vào giỏ" (hiện chưa implement, dùng sample data)
3. Vào Cart → Xem giỏ hàng
4. Click "Thanh Toán"
5. Điền thông tin giao hàng
6. Submit order và xem confirmation

### Scenario 3: Admin Workflow
1. Vào `/Admin/Login`
2. Login với admin credentials
3. Xem Dashboard statistics
4. Click vào "Quản Lý Đơn Hàng"
5. Xem danh sách orders
6. Click vào các menu khác (Menu, Reservations, Blog, Events)

### Scenario 4: User Account
1. Vào `/Account/Register` → Đăng ký
2. Redirect to Login
3. Login với thông tin vừa đăng ký
4. Vào Profile xem thông tin
5. Logout

## 🎨 UI/UX Elements to Check

- ✅ Header sticky (cuộn xuống header vẫn ở trên)
- ✅ Mobile responsive menu (thu nhỏ màn hình)
- ✅ Cart badge hiển thị số lượng
- ✅ User dropdown menu khi login
- ✅ Admin link chỉ hiện với admin users
- ✅ Hover effects trên buttons và links
- ✅ Form validation
- ✅ Success/Error messages
- ✅ 404 page với quick links

## 📱 Responsive Testing

Test trên các kích thước màn hình:
- Desktop: 1920x1080
- Laptop: 1366x768
- Tablet: 768x1024
- Mobile: 375x667 (iPhone)

## ⚠️ Known Limitations (Demo Mode)

Vì đây là wireframe/prototype:
- ❌ Không có database → Data là hardcoded samples
- ❌ Không có password hashing → Accept any login
- ❌ Không lưu orders/reservations → Chỉ hiển thị confirmation
- ❌ Không có image uploads → Placeholder images
- ❌ Không có email sending → Chỉ hiển thị messages
- ❌ Cart chỉ có sample data → Chưa implement add to cart

## ✅ What Works

- ✅ All page routing and navigation
- ✅ Session-based auth (login/logout)
- ✅ Form submissions (không lưu DB)
- ✅ Admin access control
- ✅ Responsive design
- ✅ UI components và styling
- ✅ Error handling (404)

## 🚀 Next Steps for Full Implementation

1. Add Entity Framework Core
2. Create database and migrations
3. Implement CRUD operations
4. Add real authentication (Identity)
5. Implement cart functionality
6. Add image upload
7. Email notifications
8. Payment integration
9. Search and filters
10. Admin CRUD operations

---

**Enjoy testing! 🎉**
