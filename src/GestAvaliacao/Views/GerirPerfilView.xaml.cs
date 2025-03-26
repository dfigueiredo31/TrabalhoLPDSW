using GestAvaliacao.ViewModels;
using System.Windows.Controls;


namespace GestAvaliacao.Views
{
    /// <summary>
    /// Interaction logic for GerirPerfilView.xaml
    /// </summary>
    public partial class GerirPerfilView : Page
    {
        public GerirPerfilView()
        {
            InitializeComponent();
            PerfilViewModel viewModel = new PerfilViewModel();
            DataContext = viewModel;
        }

    }
}
