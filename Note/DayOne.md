### **Tóm tắt nội dung đã học và trả lời trong ngày 1**  

📌 **1. MVVM là gì?**  
- MVVM (Model-View-ViewModel) là kiến trúc phổ biến trong WPF giúp tách biệt giao diện (**View**) và logic xử lý (**ViewModel**).  
- **View**: XAML, giao diện người dùng.  
- **ViewModel**: Chứa logic xử lý dữ liệu và các command.  
- **Model**: Dữ liệu của ứng dụng.  

📌 **2. XAML là gì?**  
- XAML (eXtensible Application Markup Language) là ngôn ngữ thiết kế UI trong WPF, giúp tạo giao diện bằng cách khai báo trực tiếp trong file `.xaml`.  

📌 **3. App.xaml là gì?**  
- Là file cấu hình chính của ứng dụng WPF, chứa **Resources chung**, **Styles**, và điểm khởi chạy của ứng dụng.  

📌 **4. Data Binding và các kiểu Binding**  
- **Data Binding** giúp kết nối dữ liệu giữa UI và ViewModel.  
- **Các kiểu Binding chính:**  
  - `OneWay`: UI cập nhật khi dữ liệu thay đổi.  
  - `TwoWay`: UI và dữ liệu cập nhật lẫn nhau.  
  - `OneTime`: UI chỉ nhận giá trị 1 lần.  
  - `OneWayToSource`: Cập nhật từ UI về ViewModel.  

📌 **5. ListBox và DataTemplate**  
- **ListBox** hiển thị danh sách dữ liệu.  
- **DataTemplate** giúp tùy chỉnh giao diện của từng item trong ListBox.  

📌 **6. Command trong MVVM**  
- **Command thay thế event trong Code-Behind**, giúp giữ cho View và ViewModel độc lập.  
- **RelayCommand** (hoặc `DelegateCommand`) là cách triển khai `ICommand` phổ biến.  

📌 **7. Event trong WPF (Bubbling & Tunneling Event)**  
- **Bubbling Event**: Sự kiện truyền từ **con → cha** (VD: `MouseDown`).  
- **Tunneling Event**: Sự kiện truyền từ **cha → con**, thường có tiền tố `Preview` (VD: `PreviewMouseDown`).  
- **Direct Event**: Chỉ xảy ra trên chính control được kích hoạt.  
  