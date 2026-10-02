-----------------BaiKiemTra01-----------------------------.
Họ và tên: Nguyễn Đức Hùng
Msv: 24810310423

I. PHẦN LÝ THUYẾT & CÂU HỎI NGẮN
Câu 1: Trình bày sự khác nhau giữa Value Types và Reference Types trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).

Trả lời:

Trong C#, kiểu dữ liệu được chia thành Value Types (kiểu giá trị) và Reference Types (kiểu tham chiếu).

*Value Types:

Gồm: int, double, bool, char, struct, enum...
Biến chứa trực tiếp giá trị dữ liệu.
Biến cục bộ được lưu trên Stack. Nếu là field của một class thì giá trị nằm bên trong đối tượng đó, tức là trên Heap.
Khi gán b = a thì giá trị được sao chép, hai biến độc lập nhau.
Không thể nhận null (trừ khi dùng kiểu Nullable như int?).
Được giải phóng tự động khi ra khỏi phạm vi (scope).

*Reference Types:

Gồm: class, interface, delegate, array, string, object...
Biến chỉ chứa địa chỉ (tham chiếu) trỏ đến đối tượng.
Biến tham chiếu nằm trên Stack, còn đối tượng thật sự nằm trên Heap.
Khi gán b = a thì chỉ sao chép địa chỉ, hai biến cùng trỏ một đối tượng, sửa qua biến này thì biến kia cũng thay đổi.
Có thể nhận null.
Được Garbage Collector (GC) dọn dẹp khi không còn tham chiếu nào.

*Tóm lại: Value Type lưu giá trị thật (thường trên Stack), Reference Type lưu địa chỉ trên Stack còn đối tượng nằm trên Heap.

*Ví dụ:

csharp
int a = 5;
int b = a;      // b là bản sao
b = 10;         // a vẫn = 5

Kết quả: a = 5, b = 10 vì b chỉ nhận một bản sao giá trị của a.

Person p1 = new Person { Name = "An" };
Person p2 = p1;     // p2 cùng trỏ đến đối tượng của p1
p2.Name = "Binh";   // p1.Name cũng thành "Binh"

p1 và p2 cùng tham chiếu đến một đối tượng trên Heap nên thay đổi qua biến nào cũng ảnh hưởng đến biến còn lại.

Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế.

*Trả lời:

init là accessor được giới thiệu từ C# 9, cho phép gán giá trị cho thuộc tính chỉ trong lúc khởi tạo đối tượng (constructor, object initializer, biểu thức with).
Sau khi khởi tạo xong, thuộc tính trở thành chỉ đọc.

Khác biệt với set:

Gán lúc khởi tạo: cả set và init đều được.
Gán lại sau khi khởi tạo: set được, còn init thì không (lỗi biên dịch).
Tính bất biến (immutable): set không đảm bảo, init đảm bảo.

*Ví dụ:

public class SinhVien
{
    public string MaSV { get; init; }
    public string HoTen { get; set; }
}

var sv = new SinhVien { MaSV = "SV01", HoTen = "An" }; // OK
sv.HoTen = "Binh";  // OK, vì là set
sv.MaSV = "SV02";   // LỖI, vì là init

Trường hợp sử dụng thực tế:

Đối tượng không được thay đổi sau khi tạo: mã sinh viên, ID đơn hàng, ngày tạo.
Các lớp DTO, Model, cấu hình (Configuration) cần an toàn dữ liệu.
Dùng với record để tạo đối tượng bất biến, tránh lỗi do vô tình sửa dữ liệu (đặc biệt khi đa luồng).
Cho phép dùng object initializer gọn gàng mà vẫn bảo vệ dữ liệu.
Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).

Trả lời:

virtual và override là hai từ khóa phối hợp với nhau để thực hiện tính đa hình trong C#.

virtual (ở lớp cha):

Đánh dấu phương thức cho phép lớp con viết lại.
Có cài đặt mặc định ở lớp cha.
Lớp con có thể viết lại hoặc không.

override (ở lớp con):

Dùng để ghi đè phương thức virtual/abstract của lớp cha.
Phải trùng tên, kiểu trả về và tham số với phương thức ở lớp cha.
Cung cấp hành vi riêng cho lớp con.

Phân biệt:

Vị trí: virtual ở lớp cha, override ở lớp con.
Vai trò: virtual cho phép được ghi đè, override thực hiện việc ghi đè.
Tính bắt buộc: virtual không bắt buộc lớp con ghi đè. override chỉ dùng được khi lớp cha có virtual/abstract.

Ví dụ:

public class DongVat
{
    public virtual void Keu() => Console.WriteLine("Dong vat keu");
}

public class Cho : DongVat
{
    public override void Keu() => Console.WriteLine("Gau gau");
}

public class Meo : DongVat
{
    public override void Keu() => Console.WriteLine("Meo meo");
}

Khi gọi:

DongVat dv = new Cho();
dv.Keu();   // In ra "Gau gau"
dv = new Meo();
dv.Keu();   // In ra "Meo meo"

Điều này thể hiện đa hình: biến dv có kiểu DongVat, nhưng chương trình xác định phương thức cần chạy dựa trên kiểu thực của đối tượng lúc chạy (liên kết động, runtime binding).

Tóm lại:

virtual → khai báo ở lớp cha, cho phép lớp con ghi đè.
override → khai báo ở lớp con, ghi đè phương thức của lớp cha.
Câu 4: Tại sao một thành phần được khai báo là static trong Class lại không thể truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử new?

Trả lời:

Bản chất của static:

Thành phần static thuộc về bản thân lớp (Class), không thuộc về từng đối tượng.
Chỉ có một bản duy nhất, dùng chung cho toàn bộ chương trình, tồn tại ngay cả khi chưa tạo đối tượng nào.

Thành phần instance:

Mỗi đối tượng tạo bằng new có vùng nhớ riêng chứa các field instance của nó.
Đối tượng chỉ quản lý các thành phần instance, không chứa thành phần static.

Lý do không truy xuất qua object:

Thành phần static không nằm trong đối tượng, nên không có "địa chỉ" nào trong object để truy cập.
Nếu cho phép obj.TenStatic sẽ gây hiểu nhầm là thuộc tính riêng của obj, trong khi thực tế mọi đối tượng cùng dùng chung một giá trị.
C# cấm điều này để mã rõ ràng, tránh nhầm lẫn. Trình biên dịch báo lỗi CS0176

Ví dụ:

public class SinhVien
{
    public static int SoLuong = 0;   // thuộc về lớp
    public string HoTen;             // thuộc về từng đối tượng
}

Truy cập đúng:

SinhVien.SoLuong = 5;      // ĐÚNG, truy cập qua tên lớp

Truy cập sai:

csharp
SinhVien sv = new SinhVien();
sv.SoLuong = 5;            // LỖI CS0176

Tóm lại:

Thành phần static → thuộc về Class → truy cập bằng TênLớp.TênThànhPhần.
Thành phần không static → thuộc về Object → truy cập thông qua đối tượng được tạo bằng new.
