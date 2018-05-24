using BatterySqLite_Xamarin.Core;
using BatterySqLite_Xamarin.Models;
using BatterySqLite_Xamarin.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BatterySqLite_Xamarin.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IBatteryRepository _batteryRepository = DependencyService.Get<IBatteryRepository>();
        private readonly IBatteryChargeProvider _batterychargeprovider = DependencyService.Get<IBatteryChargeProvider>();

        private float _batteryCharge;

        public float BatteryCharge
        {
            get
            {
                return _batteryCharge;
            }
            set
            {
                _batteryCharge = value;
                OnPropertyChanged();
            }
        }

        private ICommand _saveSQLiteCommand;
        public ICommand SaveSQLiteCommand
        {
            get
            {
                _saveSQLiteCommand = _saveSQLiteCommand ?? new Command(() => this.SaveToRepository());
                return _saveSQLiteCommand;
            }
        }

        private ObservableCollection<Battery> _batteryList;

        public ObservableCollection<Battery> BatteryList
        {
            get
            {
                return _batteryList;
            }
            set
            {
                _batteryList = value;
                OnPropertyChanged();
            }
        }

        private void SaveToRepository()
        {
            //demostración de rellenado de datos
            _batteryRepository.RemoveAll();
            Battery b1 = new Battery();

            b1.Charge = _batterychargeprovider.GetbatteryCharge();
            BatteryCharge = b1.Charge;

            _batteryRepository.Insert(b1);
        }

        public void Navigate()
        {
            //InitRepository es sólo para rellenar datos en la demo
            this.SaveToRepository();
            //LoadData demuestra una carga de datos mediante repositorio.
            //Recuerda que los repositorios no deben utilizarse directamente. Se utilizarán desde servicios de negocio.
            this.LoadData();
            //Abriendo la UI y bindando al viewmodel.
            this.OpenView();
        }

        private void OpenView()
        {
            MainPage mainPage = new MainPage();
            mainPage.BindingContext = this;
            App.Current.MainPage = mainPage;
        }

        public void LoadData()
        {
            IEnumerable<Battery> batteryList = _batteryRepository.GetAll();
            BatteryList = new ObservableCollection<Battery>(batteryList);
        }
    }
}
