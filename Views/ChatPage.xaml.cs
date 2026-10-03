using LoveChat_v2.ViewModels;

namespace LoveChat_v2.Views;

[QueryProperty(nameof(Name), "name")]
public partial class ChatPage : ContentPage
{
    public string Name
    {
        set
        {
            Title = value;
        }
    }

    public ChatPage()
    {
        InitializeComponent();

        BindingContext = new ChatViewModel();
    }
}