using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using CommunityToolkit.Mvvm.Messaging;
using MediHub.App.Messages;

namespace MediHub.App.Views;

public partial class MainLayoutView : UserControl
{
    public MainLayoutView()
    {
        InitializeComponent();
        
        // Default to Dashboard
        var content = this.FindControl<ContentControl>("PageContent");
        if (content != null)
        {
             content.Content = new DashboardView();
        }

        // Register for Navigation
        WeakReferenceMessenger.Default.Register<NavigationMessage>(this, (r, m) =>
        {
            if (content != null && m.Value is Control view)
            {
                content.Content = view;
            }
        });
    }

    private void OnNavigationChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is ListBox listBox && listBox.SelectedItem is ListBoxItem item)
        {
             var contentControl = this.FindControl<ContentControl>("PageContent");
             if (contentControl == null) return;

             var pageName = item.Content?.ToString();
             
             switch(pageName)
             {
                 case "Dashboard":
                    contentControl.Content = new DashboardView();
                    break;
                  case "Schedule":
                     contentControl.Content = new SchedulerView();
                     break;
                 case "Patients":
                    contentControl.Content = new PatientListView();
                    break;
                 default:
                    contentControl.Content = new TextBlock 
                    { 
                        Text = $"{pageName} View Coming Soon", 
                        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center, 
                        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                        FontSize = 24,
                        Foreground = Avalonia.Media.Brushes.Gray
                    };
                    break;
             }
        }
    }
}
