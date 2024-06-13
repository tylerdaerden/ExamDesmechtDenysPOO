using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDesmechtDenysPOO.Model
{
    public class WashingMachine : Electro
    {

        #region Attributs

        //Constantes pour faciliter Calcul
        private const double AWASHCLASS = 250.0;
        private const double BWASHCLASS = 300.0;

        private double _kgCapacity;

        #endregion



        #region Constructeur
        public WashingMachine(string builderreference, int elecpower, double pricevac, double kgcapacity) : base(builderreference, elecpower, pricevac)
        {
            KgCapacity = kgcapacity;
            EnergyClassCalcul();
        }

        #endregion


        #region Props

        public double KgCapacity 
        { 
            get => _kgCapacity;
            set 
            {
                _kgCapacity = value;
                OnPropertyChanged(nameof(KgCapacity));
            } 
        }

        #endregion


        #region Methodes

        public override void EnergyClassCalcul()
        {


            if((ElecPower/ _kgCapacity) < AWASHCLASS)
            {
                EnergyClass = "A";
            }
            else if ((ElecPower / _kgCapacity) >= AWASHCLASS && (ElecPower / KgCapacity) < BWASHCLASS)
            {
                EnergyClass = "B";
            }
            else if (ElecPower / _kgCapacity >= BWASHCLASS )
            {
                EnergyClass = "C";
            }
        }

        #endregion





    }

}
