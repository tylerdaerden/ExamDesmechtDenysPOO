using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamDesmechtDenysPOO.Model
{
    public class Electro : INotifyPropertyChanged
    {
        //implémentation de INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        #region Attributs

        //constantes pour simplfier le calcul des classes energie.
        private const double APOWER = 1000.0;
        private const double BPOWER = 1500.0;
        private const int MINLENGTH = 2;

        private string _builderReference;
        private int _elecPower;
        private double _priceVAC;
        private string _energyClass;

        #endregion

        #region Constructeur

        public Electro(string builderreference, int elecpower , double pricevac)
        {
            BuilderReference = builderreference;
            ElecPower = elecpower;
            PriceVac = pricevac;
            EnergyClassCalcul();


        }

        #endregion



        #region Props

        public string BuilderReference 
        { 
            get => _builderReference ;
            set
            {
                if (value.Length > MINLENGTH)
                {
                    _builderReference = value;
                    OnPropertyChanged(nameof(BuilderReference));
                }
                else 
                {
                    _builderReference = "BAD_REF";
                }
            }
        }

        public int ElecPower
        { 
            get => _elecPower ;
            set 
            {
               _elecPower = value; 
                OnPropertyChanged(nameof(ElecPower));
            } 
        }

        public double PriceVac 
        { 
            get=> _priceVAC;
            set
            {
               _priceVAC = value ; 
                OnPropertyChanged(nameof(PriceVac));
            } 
        }


        public string EnergyClass 
        { 
            get=> _energyClass ;
            set 
            {
                _energyClass = value ;
                OnPropertyChanged(nameof(EnergyClass));
            } 
        }


        #endregion

        #region Methodes

        public virtual void EnergyClassCalcul()
        {

            if(ElecPower <= APOWER)
            {
                EnergyClass = "A";
            }
            else if (ElecPower > APOWER && ElecPower < BPOWER) 
            {
                EnergyClass = "B";
            }
            else 
            {
                EnergyClass = "C";
            }

        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 



        #endregion

    }
}
