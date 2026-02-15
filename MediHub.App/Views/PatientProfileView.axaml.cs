using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MediHub.App.ViewModels;

namespace MediHub.App.Views;

public partial class PatientProfileView : UserControl
{
    public PatientProfileView()
    {
        InitializeComponent();
        DataContext = new PatientProfileViewModel();
    }
}
