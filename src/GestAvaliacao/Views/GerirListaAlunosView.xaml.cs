using GestAvaliacao.ViewModels;
using System.Windows.Controls;

namespace GestAvaliacao.Views
{
    /// <summary>
    /// Interaction logic for GerirListaAlunosView.xaml
    /// </summary>
    public partial class GerirListaAlunosView : Page
    {
        public GerirListaAlunosView()
        {
            InitializeComponent();
            ListaAlunosViewModel viewModel = new ListaAlunosViewModel();
            DataContext = viewModel;
        }
    }
}
