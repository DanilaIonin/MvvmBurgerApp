using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmBurgerApp.View;

namespace MvvmBurgerApp.ViewModels
{
    public class BurgerListViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<BurgerViewModel> Burgers { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand CreateBurgerCommand { get; set; }
        public ICommand SaveBurgerCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        public INavigation Navigation { get; set; }
        
        public BurgerListViewModel()
        {
            Burgers = new ObservableCollection<BurgerViewModel>();
            CreateBurgerCommand = new Command(CreateBurger);
            SaveBurgerCommand = new Command(SaveBurger);
            BackCommand = new Command(Back);
        }

        private void CreateBurger()
        {
            Navigation.PushAsync(new OrderPage(new BurgerViewModel() { ListViewModel = this }));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveBurger(object burgerObject)
        {
            BurgerViewModel burger = burgerObject as BurgerViewModel;
            if (burger != null && !Burgers.Contains(burger))
            {
                Burgers.Add(burger);
            }
            Back();
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
