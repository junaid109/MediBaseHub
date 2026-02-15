using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using MediHub.Shared.Models;
using System;

namespace MediHub.App.ViewModels;

public partial class PatientProfileViewModel : ViewModelBase
{
    [ObservableProperty]
    private Patient _selectedPatient;

    public ObservableCollection<Vital> Vitals { get; } = new();
    public ObservableCollection<Problem> Problems { get; } = new();
    public ObservableCollection<Document> Documents { get; } = new();

    public PatientProfileViewModel()
    {
        // Dummy data for design phase
        SelectedPatient = new Patient 
        { 
            FirstName = "Sarah", 
            LastName = "Johnson", 
            DateOfBirth = new DateTime(1985, 4, 12), 
            Gender = "Female",
            Email = "sarah.j@example.com",
            PhoneNumber = "+1 (555) 0123-4567"
        };
        
        LoadDummyData();
    }

    public PatientProfileViewModel(Patient patient)
    {
        SelectedPatient = patient;
        LoadDummyData();
    }

    private void LoadDummyData()
    {
        // Vitals
        Vitals.Add(new Vital { Name = "BP", Value = "120/80", Unit = "mmHg", TakenAt = DateTime.Now });
        Vitals.Add(new Vital { Name = "Heart Rate", Value = "72", Unit = "bpm", TakenAt = DateTime.Now });
        Vitals.Add(new Vital { Name = "Temp", Value = "98.6", Unit = "°F", TakenAt = DateTime.Now });
        Vitals.Add(new Vital { Name = "Weight", Value = "68", Unit = "kg", TakenAt = DateTime.Now });

        // Problems
        Problems.Add(new Problem { Description = "Hypertension", DiagnosedDate = new DateTime(2023, 1, 15), Severity = "Moderate" });
        Problems.Add(new Problem { Description = "Type 2 Diabetes", DiagnosedDate = new DateTime(2021, 3, 10), Severity = "Severe" });

        // Documents
        Documents.Add(new Document { FileName = "BloodTest_Results.pdf", UploadedAt = DateTime.Now.AddDays(-1), Category = "Lab" });
        Documents.Add(new Document { FileName = "XRay_Report.pdf", UploadedAt = new DateTime(2024, 1, 15), Category = "Imaging" });
    }
}
