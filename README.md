# Vitality HealthOS (MediBaseHub)

Vitality HealthOS is a modern, distributed Occupational Health system designed for performance, aesthetics, and ease of use. It provides a comprehensive suite for Electronic Health Records (EHR) and clinical workflow management.

## Technology Stack

The project leverages the latest .NET ecosystem and modern UI frameworks:

*   **Frontend**: [Avalonia UI 11+](https://avaloniaui.net/) (.NET 9) - Cross-platform XAML with fluid, modern animations and glassmorphism.
*   **Backend**: ASP.NET Core Web API (.NET 9).
*   **Database**: PostgreSQL.
*   **Orchestration**: [.NET Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/get-started/aspire-overview) - Orchestrating the API, App, and Database services.
*   **MVVM**: CommunityToolkit.Mvvm for clean, high-performance view logic.

## Project Structure

The solution is divided into several focused projects:

*   **MediHub.AppHost**: The entry point for local development, orchestrating all services.
*   **MediHub.App**: The Avalonia UI desktop application frontend.
*   **MediHub.API**: The ASP.NET Core RESTful API.
*   **MediHub.Shared**: Shared models and DTOs used across frontend and backend.
*   **MediHub.ServiceDefaults**: Shared configuration behavior for Aspire integration.
*   **MediHub.Database**: Database context and migration management.

## Getting Started

### Prerequisites

*   .NET 9 SDK
*   Docker Desktop (for Aspire orchestration of PostgreSQL)

### Running the Application

To launch the entire distributed environment (API, Database, and App):

```bash
dotnet run --project MediHub.AppHost
```

This will start the Aspire dashboard, where you can monitor service logs and endpoints.

## Features (Current Progress)

### Phase 1: Foundation & Aesthetics (Completed)
*   **Design System**: Custom theme with glassmorphism, fluid transitions, and modern typography (Inter).
*   **App Shell**: Sidebar navigation and high-performance view swapping.
*   **Dashboard**: Overview of key metrics, upcoming appointments, and quick actions.
*   **Patient List**: Grid view of patients with discovery-style cards.

### Phase 2: Core EHR (In Progress)
*   **Patient Profile**: Detailed clinical view with Vitals, Active Problems, and Document management.
*   **Navigation**: Loose-coupled communication via Message Bus.

## Architecture

MediBaseHub uses a distributed architecture where the desktop application communicates with a centralized API. Modern MVVM patterns ensure a clean separation between UI and business logic, while the shared model layer ensures type safety across the entire stack.
