using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestAvaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void ListaAlunos_Click(object sender, RoutedEventArgs e)
        {
            PainelPrincipal.Navigate(new Uri("Views/GerirListaAlunosView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void FotoPerfil_Click(object sender, RoutedEventArgs e)
        {
            PainelPrincipal.Navigate(new Uri("Views/GerirPerfilView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}