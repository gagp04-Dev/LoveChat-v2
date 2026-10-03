namespace LoveChat_v2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(
                nameof(Views.ChatPage), 
                typeof(Views.ChatPage));
        }
    }
}
