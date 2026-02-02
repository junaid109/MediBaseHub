using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Threading.Tasks;

namespace MediHub.App.Views
{
    public partial class PatientListView : UserControl
    {
        public PatientListView()
        {
            InitializeComponent();
        }

        private async void LoadPatients_Click(object? sender, RoutedEventArgs e)
        {
            if (DataContext is ViewModels.PatientListViewModel vm)
                await vm.LoadPatientsAsync();
        }
    }
}
