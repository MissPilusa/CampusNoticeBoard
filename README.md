# Campus Notice Board Web App

A dynamic **ASP.NET Core MVC** web application for managing announcements, events, and public notices in a campus or educational environment. The project leverages **custom data structures** to efficiently organize and display content.

---

## **Features**

### **Announcements (Stack)**
- Managed using a **stack** (LIFO: latest announcements appear first).  
- Add new announcements with message, author, and timestamp.  
- Remove the latest announcement easily.

### **Public Notices (Queue)**
- Managed using a **queue** (FIFO: first-in, first-out).  
- Add notices and view them in the order they were posted.  
- Remove the next notice in line.

### **Events (Priority Queue)**
- Managed using a **priority queue** (most urgent events appear first).  
- Add events with title, details, priority (1 = most urgent, 5 = least urgent), and date.  
- Automatically displays top-priority events first.  

### **Other Features**
- Responsive design with **Bootstrap 5**  
- **Gradient background** across all pages for modern look  
- **Cards, tables, forms, and carousel** for user-friendly navigation  
- Full MVC architecture with separation of concerns (Controllers, Models, Views)

---

## **Technologies Used**
- **ASP.NET Core MVC**  
- **C#**  
- **Razor Views**  
- **Bootstrap 5**  
- **Custom Data Structures:** Stack, Queue, Priority Queue
- 
---

## **Installation & Running Locally**

### **Prerequisites**
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (with ASP.NET and web development workload)  
- .NET 7 SDK or later  

### **Steps**
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/campus-notice-board.git](https://github.com/MissPilusa/CampusNoticeBoard.git)

2. Open the project in Visual Studio.

3. Restore dependencies (Visual Studio usually does this automatically).

4. Run the application (F5 or click the Run button).

5. Navigate to https://localhost:5001 (or the port Visual Studio assigns).
