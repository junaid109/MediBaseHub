using CommunityToolkit.Mvvm.ComponentModel;
using MediHub.Shared.Models;
using System;

namespace MediHub.App.ViewModels;

public partial class PatientProfileViewModel : ViewModelBase
{
    [ObservableProperty]
    private Patient _selectedPatient;

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
    }

    public PatientProfileViewModel(Patient patient)
    {
        SelectedPatient = patient;
    }
}
