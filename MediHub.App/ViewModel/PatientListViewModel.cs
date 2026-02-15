using System;
using MediHub.Shared.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MediHub.App.Messages;
using MediHub.App.Views;

namespace MediHub.App.ViewModels
{
    public partial class PatientListViewModel : ViewModelBase
    {
        public ObservableCollection<Patient> Patients { get; set; } = new();

        public async Task LoadPatientsAsync()
        {
            using var http = new HttpClient();
            try {
                var results = await http.GetFromJsonAsync<List<Patient>>("http://localhost:5000/api/patients");
                if (results != null)
                {
                    Patients.Clear();
                    foreach (var p in results) Patients.Add(p);
                }
            } catch (Exception) { /* API might be down, ignore for design review */ }
            
            // Add dummy data if empty (for dev/presentation)
            if (Patients.Count == 0)
            {
                Patients.Add(new Patient { FirstName = "Sarah", LastName = "Johnson", DateOfBirth = new DateTime(1985, 4, 12), Gender = "Female", Email = "sarah.j@example.com" });
                Patients.Add(new Patient { FirstName = "Michael", LastName = "Chen", DateOfBirth = new DateTime(1978, 8, 23), Gender = "Male", Email = "m.chen@example.com" });
                Patients.Add(new Patient { FirstName = "Emma", LastName = "Wilson", DateOfBirth = new DateTime(1992, 11, 30), Gender = "Female", Email = "emma.w@example.com" });
            }
        }

        [RelayCommand]
        public void ViewPatient(Patient patient)
        {
            var profileVm = new PatientProfileViewModel(patient);
            var view = new PatientProfileView { DataContext = profileVm };
            WeakReferenceMessenger.Default.Send(new NavigationMessage(view));
        }
    }
}