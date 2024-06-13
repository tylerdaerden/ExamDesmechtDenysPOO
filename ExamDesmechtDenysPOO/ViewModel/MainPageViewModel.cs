using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamDesmechtDenysPOO.Model;
using ExamDesmechtDenysPOO.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDesmechtDenysPOO.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {


        public MainPageViewModel(DataAccessHardCoded dataAccessService) 
        {
            dataAccess = dataAccessService;
            ElectrosToSell = dataAccess.GetElectros();
            //OrderElectroChoice = dataAccess.
        }


        private DataAccessHardCoded dataAccess; 

        public ElectrosCollection ElectrosToSell { get; set; }

        [ObservableProperty]
        private Electro electroUserSelection;

        //début de exercice sur electro en commande(pas eu le temps de finir)

        [ObservableProperty]
        private OrderElectro orderElectroSelection;

        [RelayCommand()]
        private void OrderElectro()
        {



        }


    }
}
