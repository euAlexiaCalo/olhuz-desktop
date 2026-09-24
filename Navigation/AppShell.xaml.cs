using olhuz_desktop.Features.Reading.Views;
using olhuz_desktop.Features.Profile.Views;

namespace olhuz_desktop.Navigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // NNavegações que não tem botão próprio no menu lateral

            // Rotas da feature de Leituras
            //Routing.RegisterRoute(nameof(ReadingDetailPage), typeof(ReadingDetailPage));

            // Rotas da feature de Perfil
            //Routing.RegisterRoute(nameof(EditProfilePage), typeof(EditProfilePage));
            //Routing.RegisterRoute(nameof(ChangePasswordPage), typeof(ChangePasswordPage));
        }
    }
}
