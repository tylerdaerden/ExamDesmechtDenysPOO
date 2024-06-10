using ExamDesmechtDenysPOO.ViewModel;

namespace ExamDesmechtDenysPOO
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel mainPageVM)
        {
            mainPageViewModel = mainPageVM;
            BindingContext = mainPageVM;
            InitializeComponent();
        }

        private MainPageViewModel mainPageViewModel;




    }



}
