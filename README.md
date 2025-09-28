# baitap1
lap_trinh_web_BT1
TẠO SOLUTION GỒM CÁC PROJECT SAU:

DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
BÀI LÀM
Giới thiệu đề tài
Trong thực tế, việc thực hiện các phép tính số học cơ bản như cộng, trừ, nhân, chia là nhu cầu thiết yếu trong học tập, công việc và đời sống. Để hỗ trợ người dùng tính toán nhanh chóng và chính xác, nhóm đã xây dựng một phần mềm Máy tính đơn giản chạy trên nền tảng Windows Forms (.NET Framework 4.7.2).
Ứng dụng cho phép:
Nhập vào hai số cần tính toán.
Chọn phép toán: cộng (+), trừ (−), nhân (×), chia (÷).
Nhấn nút “Tính” để hiển thị kết quả ngay trên giao diện.
Phần mềm có giao diện thân thiện, dễ sử dụng, phù hợp cho sinh viên làm quen với lập trình giao diện trên C#, đồng thời là nền tảng để mở rộng thành các ứng dụng tính toán phức tạp hơn trong tương lai.

bài làm: 
1. Thư viện DLL (Class Library – .NET Framework 2.0)
   Tạo project Class Library trong Visual Studio với .NET Framework 2.0.

Xây dựng lớp Calculator với các phương thức:

Add(double a, double b) – cộng hai số.

Subtract(double a, double b) – trừ hai số.

Multiply(double a, double b) – nhân hai số.

Divide(double a, double b) – chia hai số (có xử lý ngoại lệ chia cho 0).

Sau khi biên dịch, project sẽ sinh ra file Calculator.dll.

 <img width="1852" height="948" alt="image" src="https://github.com/user-attachments/assets/83c8be75-f297-4312-b222-e69a5e248308" />

2. Ứng dụng Console (.NET Framework 2.0)
 Khi chạy chương trình, màn hình console sẽ hiển thị hướng dẫn cho người dùng:

Nhập số thứ nhất.

Nhập số thứ hai.

Chọn phép toán (+, -, *, /).

Chương trình sẽ thực hiện phép tính và in kết quả trực tiếp ra màn hình console.

Có xử lý ngoại lệ (ví dụ: chia cho 0, nhập ký tự không hợp lệ).

   <img width="1858" height="952" alt="image" src="https://github.com/user-attachments/assets/375af7d1-2d55-454f-a7be-a8c7beeece38" />
3. Ứng dụng Windows Forms (.NET Framework 2.0)
Giao diện gồm các thành phần chính:

TextBox: nhập vào hai số cần tính toán.

ComboBox: chọn phép toán (cộng, trừ, nhân, chia).

Button: nút “Tính” để thực hiện phép toán.

Label: hiển thị kết quả cho người dùng.

Khi người dùng nhập dữ liệu và chọn phép toán, sự kiện Click của nút tính toán sẽ gọi hàm xử lý, thực hiện phép tính và trả kết quả ra màn hình.
   <img width="1862" height="972" alt="image" src="https://github.com/user-attachments/assets/117aaa6c-2c53-472d-ae34-1042393d8b80" />

   <img width="853" height="624" alt="image" src="https://github.com/user-attachments/assets/05c1a94c-c4ed-4735-9d98-ee3f0d2552a6" />

4. Ứng dụng Web (ASP.NET 2.0 + IIS)
   Trong đề tài “Máy tính đơn giản”, ngoài phiên bản ứng dụng chạy trên Windows Forms, em còn xây dựng một phiên bản chạy trên nền tảng Web bằng ASP.NET 2.0 kết hợp với IIS để triển khai.

ASP.NET 2.0: được sử dụng để phát triển giao diện web, cho phép người dùng nhập hai số, chọn phép toán (cộng, trừ, nhân, chia) và nhận kết quả trực tiếp trên trình duyệt.

IIS (Internet Information Services): đóng vai trò là máy chủ web, chịu trách nhiệm tiếp nhận yêu cầu từ trình duyệt, chuyển yêu cầu cho ứng dụng ASP.NET xử lý và trả lại kết quả dưới dạng trang web HTML.

   <img width="1770" height="927" alt="image" src="https://github.com/user-attachments/assets/666fba33-89bd-46f3-bd49-97a97e8ffc7b" />

   <img width="1870" height="958" alt="image" src="https://github.com/user-attachments/assets/57fe9e09-07c4-4345-9bc1-c0743eae151b" />

<img width="616" height="324" alt="image" src="https://github.com/user-attachments/assets/1e93a3f0-3825-45e1-b7d8-80f70dda1754" />

