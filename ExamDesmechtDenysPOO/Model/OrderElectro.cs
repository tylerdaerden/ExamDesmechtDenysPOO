
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamDesmechtDenysPOO.Model
{
    public class OrderElectro : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        #region Attributs

        private Electro _electro;
        private int _quantity;
        private double _price;


        #endregion


        #region Constructeur


        public OrderElectro(Electro elec , int quantity)
        {
            Electro = elec;
            Quantity = quantity;
            ComputePrice();

        }
        #endregion


        #region Props
        public Electro Electro
        {
            get => _electro;
            set
            {
                _electro = value;
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public double Price 
        { 
            get => _price; 
            set
            {
                _price = value;
                ComputePrice();
                //OnPropertyChanged(nameof(Price));
            }
        }


        #endregion




        #region Methodes

        private void ComputePrice()
        {
            Price = Quantity * Electro.PriceVac ;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


    }
}
