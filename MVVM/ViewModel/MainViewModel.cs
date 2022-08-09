using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.core;

namespace WpfApp3.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand CadastroViewCommand { get; set; }
        public RelayCommand VenderViewCommand { get; set; }

        public VenderViewModel VenderVm { get; set; }
        public ProdutoViewModel CadastroProdutoVm { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            CadastroProdutoVm = new ProdutoViewModel();
            VenderVm = new VenderViewModel();
            CurrentView = VenderVm;

            CadastroViewCommand = new RelayCommand(a =>
            {
                CurrentView = CadastroProdutoVm;
            });

            VenderViewCommand = new RelayCommand(o =>
            {
                CurrentView = VenderVm;
            });
        }
    }
}
