using LoveChat_v2.ViewModels;

namespace LoveChat_v2.Views;

public partial class ChatsPage : ContentPage
{
	public ChatsPage()
	{
		InitializeComponent();

        BindingContext = new ChatsViewModel(); //Search properties Inside of ChatsViewModel
    }

    private async void OnOpenChatClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ChatPage));
    }
}