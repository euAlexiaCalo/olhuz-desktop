namespace olhuz_desktop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Navigation.AppShell();
        }

        /*protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }*/
    }
}