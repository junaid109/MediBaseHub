using MediHub.Shared.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MediHub.App.ViewModels
{
    public class PatientListViewModel : ViewModelBase
    {
        public ObservableCollection<Patient> Patients { get; set; } = new();

        public async Task LoadPatientsAsync()
        {
            using var http = new HttpClient();
            var results = await http.GetFromJsonAsync<List<Patient>>("http://localhost:5000/api/patients");
            if (results != null)
                foreach (var p in results) Patients.Add(p);
        }
    }
}