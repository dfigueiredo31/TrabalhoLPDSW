using GestAvaliacao.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GestAvaliacao.ViewModels
{
    public class ListaAlunosViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Aluno> ListaAlunos { get; set; }

        public ListaAlunosViewModel() 
        { 
            ListaAlunos = new ObservableCollection<Aluno>();

            ListaAlunos.Add(new Aluno() { Id=1, Nome="Zé", Email="zebone@sapo.pt"});
            ListaAlunos.Add(new Aluno() { Id=2, Nome="Ritinha", Email="ritz@gmail.com"});
            ListaAlunos.Add(new Aluno() { Id=3, Nome="Tó", Email="tomane@hotmail.com"});
            ListaAlunos.Add(new Aluno() { Id=4, Nome="Lena", Email="leninha@live.pt"});
        }

        private Aluno _aluno;

        public Aluno Aluno
        {
            get { return _aluno; }
            set
            {
                _aluno = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
