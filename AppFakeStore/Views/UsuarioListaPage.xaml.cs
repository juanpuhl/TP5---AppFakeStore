using AppFakeStore.ViewModels;

namespace AppFakeStore.Views
{
    public partial class UsuarioListaPage : ContentPage
    {
        public UsuarioListaPage()
        {
        }

        public UsuarioListaPage(UsuarioListaViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
