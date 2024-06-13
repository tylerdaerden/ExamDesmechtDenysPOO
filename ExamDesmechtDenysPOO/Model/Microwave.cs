using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDesmechtDenysPOO.Model
{
    public class MicroWave : Electro
    {
        #region Attributs

        private bool _encastred;

        #endregion

        #region Constructeurs

        public MicroWave(string builderreference, int elecpower, double pricevac, bool encastred) : base(builderreference, elecpower, pricevac)
        {
            Encastred = encastred ;
        }

        #endregion


        #region Props

        public bool Encastred 
        { 
            get => _encastred; 
            set
            {
                _encastred = value;
                OnPropertyChanged(nameof(Encastred));
            }
        }


        #endregion


    }
}
