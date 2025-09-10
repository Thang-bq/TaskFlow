TaskFlow
TaskFlow - Hệ thống Quản lý Công việc

https://img.shields.io/badge/ASP.NET_Core-6.0-purple?style=flat-square
https://img.shields.io/badge/Entity_Framework_Core-7.0-green?style=flat-square
https://img.shields.io/badge/Bootstrap-5.0-blueviolet?style=flat-square
https://img.shields.io/badge/License-MIT-yellow?style=flat-square

📋 Giới thiệu
TaskFlow là ứng dụng web quản lý công việc cá nhân được xây dựng bằng ASP.NET Core MVC. Ứng dụng cho phép người dùng tạo, theo dõi và quản lý các công việc hàng ngày với đầy đủ tính năng CRUD, phân loại theo mức độ ưu tiên và trạng thái.

✨ Tính năng
✅ Quản lý công việc - Thêm, sửa, xóa và xem chi tiết công việc

✅ Phân loại công việc - Theo độ ưu tiên (Cao, Trung bình, Thấp) và trạng thái (Chưa bắt đầu, Đang thực hiện, Hoàn thành)

✅ Xác thực người dùng - Đăng ký, đăng nhập và phân quyền truy cập

✅ Giao diện responsive - Tương thích với nhiều thiết bị nhờ Bootstrap 5

✅ API hỗ trợ - API controllers cho khả năng tương thích mobile

✅ Tìm kiếm & Lọc - Lọc công việc theo trạng thái và độ ưu tiên

🛠 Công nghệ sử dụng
Backend: ASP.NET Core 6.0, Entity Framework Core 7.0

Frontend: Bootstrap 5.3, jQuery, Razor Pages

Database: SQL Server (có thể dùng SQLite cho môi trường development)

Authentication: ASP.NET Core Identity

Deployment: Azure App Service, Docker (tùy chọn)

📦 Cài đặt và Chạy ứng dụng
Yêu cầu hệ thống
.NET 6.0 SDK hoặc mới hơn

SQL Server 2012+ hoặc SQLite

Visual Studio 2022+ hoặc VS Code

Các bước cài đặt
Clone repository

bash
git clone https://github.com/Thang-bq/TaskFlow.git
cd TaskFlow
Cài đặt dependencies

bash
dotnet restore
Thiết lập database

bash
dotnet ef database update
Chạy ứng dụng

bash
dotnet run
Truy cập ứng dụng
Mở trình duyệt và truy cập: https://localhost:7000

📁 Cấu trúc dự án
text
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
🎮 Sử dụng ứng dụng
Đăng ký tài khoản - Tạo tài khoản người dùng mới

Đăng nhập - Truy cập vào hệ thống

Tạo công việc - Thêm công việc mới với các thông tin chi tiết

Theo dõi tiến độ - Cập nhật trạng thái công việc

Lọc và tìm kiếm - Sử dụng bộ lọc để quản lý công việc hiệu quả

🌟 Điểm nổi bật
Thiết kế theo mô hình MVC chuẩn

Sử dụng Entity Framework Core ORM

Xác thực người dùng với ASP.NET Core Identity

Giao diện thân thiện, responsive

Code được tổ chức rõ ràng, dễ bảo trì

Triển khai được trên nhiều nền tảng cloud

📄 License
Dự án được phân phối theo giấy phép MIT. Xem file LICENSE để biết thêm chi tiết.

🤝 Đóng góp
Đóng góp và đề xuất tính năng mới luôn được chào đón! Vui lòng:

Fork repository

Tạo branch cho tính năng mới (git checkout -b feature/AmazingFeature)

Commit các thay đổi (git commit -m 'Add some AmazingFeature')

Push to branch (git push origin feature/AmazingFeature)

Mở một Pull Request

📞 Liên hệ
Bùi Quang Thắng - QuangThang.Contact@gmail.com

Link dự án: https://github.com/Thang-bq/TaskFlow

⭐️ Hãy đánh giá sao cho repository nếu bạn thấy dự án này hữu ích!
