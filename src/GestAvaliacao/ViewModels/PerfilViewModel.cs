using GestAvaliacao.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GestAvaliacao.ViewModels
{
    public class PerfilViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Perfil> Perfis {  get; set; }
        public PerfilViewModel()
        {
            Perfis = new ObservableCollection<Perfil>();
            Perfis.Add(new Perfil() { Nome = "David Figueiredo", Email="dfigueiredo@utad.pt"});
        }

        private Perfil _perfil;

        public Perfil Perfil
        {
            get { return _perfil; }
            set
            {
                _perfil = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
