using CommunityToolkit.Mvvm.Messaging.Messages;
using MediHub.Shared.Models;

namespace MediHub.App.Messages;

public class NavigationMessage : ValueChangedMessage<object>
{
    public NavigationMessage(object view) : base(view)
    {
    }
}
