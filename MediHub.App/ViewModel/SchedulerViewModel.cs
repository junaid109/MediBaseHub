using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MediHub.Shared.Models;

namespace MediHub.App.ViewModels
{
    public partial class SchedulerViewModel : ObservableObject
    {
        [ObservableProperty]
        private DateTime _selectedDate = DateTime.Today;

        public ObservableCollection<Appointment> Appointments { get; } = new();

        public SchedulerViewModel()
        {
            LoadDummyAppointments();
        }

        private void LoadDummyAppointments()
        {
            Appointments.Add(new Appointment 
            { 
                PatientName = "Sarah Johnson", 
                Reason = "Post-Op Consultation", 
                Time = DateTime.Today.AddHours(9), 
                Type = "Surgery Follow-up" 
            });
            Appointments.Add(new Appointment 
            { 
                PatientName = "Michael Chen", 
                Reason = "Diabetes Management", 
                Time = DateTime.Today.AddHours(10).AddMinutes(30), 
                Type = "Chronic Care" 
            });
            Appointments.Add(new Appointment 
            { 
                PatientName = "Emma Wilson", 
                Reason = "New Patient Intake", 
                Time = DateTime.Today.AddHours(14), 
                Type = "Initial Assessment" 
            });
             Appointments.Add(new Appointment 
            { 
                PatientName = "Robert Brown", 
                Reason = "Routine Blood Work", 
                Time = DateTime.Today.AddHours(15).AddMinutes(30), 
                Type = "Lab Work",
                Status = "Pending"
            });
        }

        [RelayCommand]
        private void AddAppointment()
        {
            // Placeholder for implementation logic
        }
    }
}
