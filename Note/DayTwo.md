# ✅ Tổng kết ngày 2 - TodoApp WPF  

## 1️⃣ Đã hoàn thành  
- ✔ **Thêm và xóa công việc** (Add & Remove Task).  
- ✔ **Cập nhật `RelayCommand` để hỗ trợ `null` parameter** trong `CanExecute`.  
- ✔ **Cập nhật `TodoAppViewModel`** với:  
  - `NewTask` để nhập công việc.  
  - `AddTaskCommand` để thêm công việc.  
  - `RemoveTaskCommand` để xóa công việc.  
- ✔ **Cập nhật `TodoApp.xaml`** với:  
  - `TextBox` nhập công việc mới (binding `NewTask`).  
  - `Button "Add"` (binding `AddTaskCommand`).  
  - `Button "Remove"` (binding `RemoveTaskCommand`, xóa task đã chọn).  
- ✔ **Sử dụng `CommandParameter` trong XAML** để truyền `SelectedItem` từ `ListBox` vào `RemoveTaskCommand`.  

---

## 2️⃣ Câu hỏi & giải thích  

### ❓ Tại sao `CanExecute` có thể `null`?  
✅ Vì trong `RelayCommand`, `canExecute` là một tham số **tùy chọn** (`Predicate<object?>? canExecute = null`).  
- Nếu `canExecute` là `null`, mặc định `CanExecute()` luôn trả về `true`, tức là command luôn có thể thực thi.  
- Điều này giúp viết command dễ dàng hơn mà không cần luôn luôn kiểm tra điều kiện thực thi.  

---

### ❓ Khi nào giao diện cần cập nhật trạng thái của Command?  
✅ Các trường hợp sau khiến giao diện gọi lại `CanExecute()`:  
- Khi WPF tự động gọi `CommandManager.RequerySuggested`.  
- Khi một thuộc tính trong `ViewModel` thay đổi (ví dụ: `NewTask` thay đổi, ảnh hưởng đến `CanExecute` của `AddTaskCommand`).  
- Khi control được tải hoặc mất focus.  
- Khi `CommandManager.InvalidateRequerySuggested()` được gọi thủ công.  

---

### ❓ Lifecycle của một Command trong WPF?  
✅ Các bước hoạt động của Command:  
1️⃣ **Khởi tạo**: `RelayCommand` được tạo và gán vào `Button.Command`.  
2️⃣ **Đánh giá trạng thái**: `CanExecute()` quyết định `Button` có được enable không.  
3️⃣ **Thực thi**: Khi `Button` được nhấn, `Execute()` của command được gọi.  
4️⃣ **Cập nhật giao diện**: Nếu cần, `CanExecuteChanged` được kích hoạt để cập nhật trạng thái `Button`.  
5️⃣ **Vòng đời kết thúc**: Khi `ViewModel` bị hủy hoặc `Window` đóng.  

---

## 3️⃣ Ghi chú quan trọng  
- `CommandParameter="{Binding SelectedItem, ElementName=TaskList}"` giúp truyền task cần xóa vào `RemoveTaskCommand`.  
- `ObservableCollection<string>` tự động cập nhật giao diện khi thay đổi dữ liệu.  
- `UpdateSourceTrigger=PropertyChanged` giúp cập nhật `NewTask` ngay khi người dùng nhập liệu.  
