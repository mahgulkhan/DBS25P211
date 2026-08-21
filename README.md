# Faculty Management System

A comprehensive desktop application for university faculty management, designed to streamline course assignments, resource allocation, and workload distribution.

## Features

### Faculty Member Functions
- View assigned courses
- Submit resource requests (board markers, stationery, etc.)
- Track request status
- View assigned administrative duties
- Check workload distribution
- View project supervision assignments

### Department Head Functions
- Assign courses to faculty members
- Review and approve/decline resource requests
- Manage room allocations
- Assign administrative duties
- Generate reports
- Manage faculty profiles

### Admin Functions
- Add/update/delete user profiles
- Manage course offerings
- Manage room inventory
- Generate business reports

## Tech Stack

- **Frontend**: Windows Forms / Desktop Application
- **Database**: SQL Server / MySQL
- **Language**: C# / .NET Framework

## Project Structure

```
Faculty-Management-System/
├── src/
│   ├── Forms/
│   │   ├── Login.cs
│   │   ├── RoleSelector.cs
│   │   ├── AdminDashboard.cs
│   │   ├── FacultyDashboard.cs
│   │   └── DepartmentHeadDashboard.cs
│   ├── Models/
│   │   ├── User.cs
│   │   ├── Faculty.cs
│   │   ├── Course.cs
│   │   ├── Room.cs
│   │   ├── Project.cs
│   │   └── Request.cs
│   ├── Data/
│   │   └── DatabaseContext.cs
│   └── Utils/
│       └── Helpers.cs
├── database/
│   └── schema.sql
└── README.md
```

## Database Schema

### Core Tables

| Table | Description |
|-------|-------------|
| `users` | User authentication and role management |
| `faculty` | Faculty member details |
| `courses` | Course information |
| `faculty_courses` | Course assignments to faculty |
| `faculty_course_schedule` | Timetable and room allocation |
| `rooms` | Room inventory |
| `projects` | Project information |
| `faculty_projects` | Project supervision assignments |
| `faculty_requests` | Resource requests |
| `faculty_admin_roles` | Administrative duty assignments |

### Key Relationships

```
users (1) ---- (1) faculty
faculty (M) ---- (M) courses (via faculty_courses)
faculty (M) ---- (M) rooms (via faculty_course_schedule)
faculty (M) ---- (M) projects (via faculty_projects)
faculty (1) ---- (M) faculty_requests
faculty (M) ---- (M) admin_roles (via faculty_admin_roles)
```

## Key User Interfaces

### Login & Authentication
- Role-based login (Admin, Faculty, Department Head)
- Password recovery with email verification
- Session management

### Admin Module
- **User Management**: Add/update/delete user profiles
- **Room Management**: CRUD operations for rooms
- **Course Management**: Add/update/delete courses
- **Faculty Profile Management**: Manage faculty details

### Faculty Module
- View assigned courses with schedules
- Submit resource requests
- View request status
- Check workload distribution
- View assigned projects and administrative duties

### Department Head Module
- **Resource Allocation**: Approve/decline faculty requests
- **Course Assignment**: Assign courses to faculty
- **Room Allocation**: Manage room assignments
- **Duty Assignment**: Assign administrative duties
- **Report Generation**: Generate business reports

## Business Reports

The system supports multiple report types:

| Report | Description |
|--------|-------------|
| Faculty Workload Details | Course schedules with room allocations |
| Faculty Users Details | User credentials and faculty information |
| Faculty Requests Details | Resource request history |
| Courses Assigned to Faculty | Course assignment overview |

### Sample Report Queries

**Workload Details**:
```sql
SELECT 
    faculty_course_schedule.schedule_id,
    faculty.faculty_id,
    faculty.name AS faculty_name,
    courses.course_name,
    faculty_course_schedule.room_id,
    rooms.room_name,
    faculty_course_schedule.day_of_week,
    faculty_course_schedule.start_time,
    faculty_course_schedule.end_time
FROM faculty_course_schedule
JOIN faculty_courses ON faculty_course_schedule.faculty_course_id = faculty_courses.faculty_course_id
JOIN faculty ON faculty_courses.faculty_id = faculty.faculty_id
JOIN courses ON faculty_courses.course_id = courses.course_id
JOIN rooms ON faculty_course_schedule.room_id = rooms.room_id;
```

**User Details**:
```sql
SELECT 
    users.username,
    users.password_hash AS password,
    users.email,
    users.role_id,
    faculty.contact,
    faculty.research_area,
    faculty.total_teaching_hours,
    faculty.designation_id,
    users.user_id,
    faculty.faculty_id
FROM faculty
JOIN users ON faculty.user_id = users.user_id;
```

## Installation

### Prerequisites
- Windows OS
- .NET Framework 4.5 or higher
- SQL Server or MySQL

### Setup

```bash
# Clone repository
git clone https://github.com/mahgulkhan/Faculty-Management-System.git

# Open solution in Visual Studio
# Update connection string in app.config

# Run database migrations
# Build and run the application
```

## Key Features Overview

### Request Management Flow
1. Faculty submits resource request
2. Request marked as "Pending"
3. Department Head reviews request
4. Approved → Status updated to "Fulfilled"
5. Declined → Reason recorded

### Workload Management
- Tracks teaching assignments
- Monitors research supervision
- Manages administrative responsibilities
- Prevents overburdening faculty members
- Ensures even workload distribution
