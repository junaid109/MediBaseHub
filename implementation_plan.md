# Vitality HealthOS - Implementation Plan

## 1. Project Identity & Vision
**Objective**: Build a production-level, high-end Occupational Health system cloning "Meddbase" functionality but with a unique, premium identity.
**New Name**: **Vitality HealthOS** (Internal Code Name: `MediHub`).
**Aesthetics**: Glassmorphism, modern typography (Inter/Outfit), fluid animations, dark/light mode support. "Netflix-style" discovery and interaction.

## 2. Technology Stack
- **Frontend**: Avalonia UI 11+ (.NET 9)
  - *Platforms*: Desktop (Windows/macOS/Linux), Web (WASM).
  - *Styling*: Fluent Theme + Custom Styles (Glass, Vibrant Colors).
  - *MVVM*: CommunityToolkit.Mvvm.
- **Backend**: ASP.NET Core Web API (.NET 9)
  - *Auth*: JWT + Role Claims.
  - *Docs*: Swagger/OpenAPI.
- **Database**: PostgreSQL (Entity Framework Core).
- **Shared**: .NET 9 Class Library (DTOs, Validators, Enums).
- **AI**: OpenAI/Azure OpenAI Integration (Future Phase).

## 3. Architecture Overview
```
MediBaseHub/
├── MediHub.Shared/       # Shared Models, DTOs, Validators
├── MediHub.API/          # ASP.NET Core Web API (PostgreSQL)
├── MediHub.Database/     # EF Core Migrations & Context
├── MediHub.App/          # Avalonia Client (Desktop/Web)
│   ├── Assets/           # Images, Fonts
│   ├── Styles/           # Global Styles (Colors, Controls)
│   ├── ViewModels/       # MVVM Logic
│   ├── Views/            # UI Components
│   └── Services/         # API Clients
└── MediHub.sln
```

## 4. Phase 1: Foundation & Aesthetics (Current Priority)
**Goal**: Establish the "Premium" look and feel and basic connectivity.
- [x] **Design System**: Define Color Palette (Primary: Teal/Emerald, Secondary: Slate), Typography (Inter), and Control Styles (Cards, Buttons, Inputs).
- [x] **App Shell**: Create a Main Layout with Navigation Sidebar (Collapsible), Top Bar (User Profile), and Content Area.
- [x] **Dashboard**: Create a "Home" dashboard with dummy widgets (Appointments Today, Active Cases).
- [x] **Patient List**: Enhance the existing `PatientListView` with a DataGrid or Card View, Search, and Filtering.

## 5. Phase 2: Core EHR (Electronic Health Records)
**Goal**: Comprehensive Patient Management.
- [ ] **Patient Profile**: Detailed view (Demographics, History, Documents).
- [ ] **Clinical Forms**: Dynamic form builder for health assessments.
- [ ] **Documents**: Drag-and-drop document upload (stored in DB/Blob).

## 6. Phase 3: Scheduling & API Integration
**Goal**: Real-time Booking System.
- [ ] **Calendar**: Custom Calendar Control (Day/Week/Month views).
- [ ] **Appointment Booking**: Wizard flow for booking (Select Patient -> Service -> Time -> Confirm).
- [ ] **API Connection**: Connect Avalonia Client to `MediHub.API` for real-time data.

## 7. Phase 4: Security, Reporting & AI
- [ ] **Authentication**: Login Screen with JWT handshakes.
- [ ] **Reporting**: ChartJS/LiveCharts integration for health trends.
- [ ] **AI Assistant**: "Vitality AI" side panel for summarization and coding suggestions.

## Immediate Next Steps
1.  **Style Setup**: Create `App.axaml.cs` ResourceDictionary for Colors and Fonts.
2.  **Main Layout**: Build a `MainLayoutView` with a modern Sidebar.
3.  **Dashboard**: Implement the landing page widget grid.
