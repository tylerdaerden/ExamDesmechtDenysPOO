using ExamDesmechtDenysPOO.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDesmechtDenysPOO.ViewModel
{
    public partial class MainPageViewModel
    {


        public MainPageViewModel(DataAccess dataAccessService) 
        {

            dataAccess = dataAccessService;

        }


        private DataAccess dataAccess; 


    }
}
