# 🚀 TaskFlow - Giải Pháp Quản Lý Công Việc

![.NET Core](https://img.shields.io/badge/ASP.NET_Core-8.0-purple)
![Entity Framework](https://img.shields.io/badge/Entity_Framework_Core-7.0-green)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.0-blueviolet)
![License](https://img.shields.io/badge/License-MIT-yellow)

## 📋 Giới thiệu

TaskFlow là ứng dụng quản lý công việc hiện đại được xây dựng bằng ASP.NET Core MVC, giúp bạn tổ chức và quản lý công việc hàng ngày một cách hiệu quả.

## ✨ Tính năng chính

- **Quản lý công việc** - Tạo, xem, sửa, xóa công việc
- **Hệ thống ưu tiên** - 4 mức độ ưu tiên
- **Theo dõi trạng thái** - Todo, Đang thực hiện, Hoàn thành
- **Theo dõi deadline** - Thiết lập và nhắc nhở hạn hoàn thành
- **Xác thực người dùng** - Bảo mật với ASP.NET Core Identity
- **Thiết kế responsive** - Hoạt động trên mọi thiết bị

## 🛠️ Công nghệ sử dụng

- **Backend**: ASP.NET Core 8.0 MVC
- **Frontend**: Bootstrap 5, jQuery, Font Awesome
- **Database**: SQL Server + Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **Deployment**: Có thể deploy trên IIS, Docker, Azure

## 🚀 Cài đặt và chạy ứng dụng

### Yêu cầu hệ thống
- .NET 8.0 SDK
- SQL Server (LocalDB hoặc SQL Express)
- Visual Studio 2022 hoặc VS Code

### Các bước cài đặt

1. **Clone repository**
```bash
git clone https://github.com/Thang-bq/TaskFlow.git
cd TaskFlow
```

2. **Khôi phục packages**
```bash
dotnet restore
```

3. **Áp dụng migrations**
```bash
dotnet ef database update
```

4. **Chạy ứng dụng**
```bash
dotnet run
```

5. **Truy cập ứng dụng**
Mở trình duyệt và truy cập: `https://localhost:7000`

## 📁 Cấu trúc dự án

```
TaskFlow/
├── Controllers/
│   └── TaskController.cs
├── Models/
│   └── Entities/
│       ├── TaskItem.cs
│       └── Category.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   └── Task/
│       ├── Index.cshtml
│       └── Create.cshtml
├── Data/
│   └── ApplicationDbContext.cs
├── wwwroot/
│   └── css/
│       └── site.css
└── appsettings.json
```

## 🎮 Hướng dẫn sử dụng

### Đăng ký tài khoản
1. Truy cập trang đăng ký
2. Điền thông tin email và mật khẩu
3. Xác nhận email (nếu có cấu hình email)

### Tạo công việc mới
1. Đăng nhập vào hệ thống
2. Nhấn "Tạo công việc mới"
3. Điền thông tin:
   - Tiêu đề công việc
   - Mô tả chi tiết
   - Mức độ ưu tiên
   - Deadline (nếu có)
4. Nhấn "Lưu"

### Quản lý công việc
- **Xem tất cả**: Trang dashboard hiển thị tất cả công việc
- **Cập nhật trạng thái**: Nhấn "Hoàn thành" để đánh dấu
- **Xóa công việc**: Xóa những công việc không cần thiết
- **Lọc theo ưu tiên**: Hiển thị theo màu sắc chỉ định

## 🌟 Tính năng tương lai

- [ ] Quản lý danh mục công việc
- [ ] Gửi email nhắc nhở
- [ ] Báo cáo và thống kê
- [ ] API cho mobile app
- [ ] Tính năng teamwork
- [ ] Lịch biểu trực quan

## 🐛 Xử lý lỗi thường gặp

### Lỗi database
```bash
# Xóa migration cũ và tạo lại
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Lỗi build
```bash
# Dọn sạch solution
dotnet clean
dotnet restore
dotnet build
```

### Lỗi runtime
- Kiểm tra connection string trong `appsettings.json`
- Đảm bảo SQL Server đang chạy

## 🤝 Đóng góp

Chúng tôi hoan nghênh mọi đóng góp từ cộng đồng! Để đóng góp:

1. Fork repository
2. Tạo branch mới: `git checkout -b feature/tinh-nang-moi`
3. Commit changes: `git commit -m 'Thêm tính năng mới'`
4. Push lên branch: `git push origin feature/tinh-nang-moi`
5. Tạo Pull Request

## 📄 Giấy phép

Dự án được phân phối dưới giấy phép MIT. Xem file LICENSE để biết thêm chi tiết.

## 👨‍💻 Thông tin developer

- **Tên**: Bùi Quang Thắng
- **Email**: QuangThang.Contact@gmail.com
- **GitHub**: [Thang-bq](https://github.com/Thang-bq)
- **Dự án**: [TaskFlow](https://github.com/Thang-bq/TaskFlow)

## 🙏 Ghi nhận

- Đội ngũ phát triển ASP.NET Core
- Bootstrap team cho framework frontend
- Font Awesome cho icons
- Tất cả contributors và users của TaskFlow

---

⭐ **Hãy star repository nếu bạn thấy hữu ích!**

*Được xây dựng với ❤️ bằng ASP.NET Core*

---

*Để biết thêm thông tin, câu hỏi hoặc góp ý, vui lòng liên hệ [QuangThang.Contact@gmail.com](mailto:QuangThang.Contact@gmail.com)*
