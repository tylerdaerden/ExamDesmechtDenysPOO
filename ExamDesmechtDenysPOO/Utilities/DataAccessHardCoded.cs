
using ExamDesmechtDenysPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDesmechtDenysPOO.Utilities
{
    public class DataAccessHardCoded 
    {

        public ElectrosCollection GetElectros() 
        {

            WashingMachine laveLingeBosch = new WashingMachine("WAN2428", 2400, 400.0, 8.0);
            WashingMachine laveLingeMiele = new WashingMachine("WEA025", 1900, 950.0, 10.5);
            WashingMachine laveLingeLG = new WashingMachine("F94R", 2100, 650.0, 9.0);
            WashingMachine laveLingeValberg = new WashingMachine("G", 2500, 320.0, 9.0);

            MicroWave microOndesSamsung = new MicroWave("MS23K", 800, 94.5, false);
            MicroWave microOndesWhirlpool = new MicroWave("MBNA900", 1100, 300.0, true);

            ElectrosCollection elCol = new ElectrosCollection();

            elCol.Add(laveLingeBosch);
            elCol.Add(laveLingeMiele);
            elCol.Add(laveLingeLG);
            elCol.Add(laveLingeValberg);

            elCol.Add(microOndesSamsung);
            elCol.Add(microOndesWhirlpool);

            return elCol;
                 
        }
    }
}
