using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace olhuz_desktop.Core.Base
{
    // Interface que permite avisar a View quando uma propriedade do ViewModel foi alterada
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;
        private string _title = string.Empty;

        // ============================================================
        // PROPRIEDADE IsBusy
        // ============================================================
        // Propriedade para controlar estados de carregamento
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        // ============================================================
        // PROPRIEDADE Title
        // ============================================================
        // Propriedade para representar o título da página
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        // ============================================================
        // EVENTO PropertyChanged
        // ============================================================
        // Implementação explícita do INotifyPropertyChanged
        // Evento disparado quando uma propriedade muda de valor
        public event PropertyChangedEventHandler? PropertyChanged;

        // ============================================================
        // MÉTODO OnPropertyChanged
        // ============================================================
        // Método responsável por avisar que uma propriedade mudou
        // [CallerMemberName] faz o compilador descobrir automaticamente o nome do método/propriedade que chamou
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            // Informa qual propriedade foi alterada
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // ============================================================
        // MÉTODO SetProperty
        // ============================================================
        // Método genérico usado para alterar propriedades
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action? onChanged = null)
        {
            // Confere se os valores são iguais
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            // Atualiza o campo privado com o novo valor
            backingStore = value;
            // Executa a ação opcional, caso alguma tenha sido fornecida
            onChanged?.Invoke();
            // Avisa que a propriedade foi alterada
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
