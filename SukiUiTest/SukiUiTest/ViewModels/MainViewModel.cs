using LiteDB;

namespace SukiUiTest.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        
        public MainViewModel()
        {
            var db = new LiteDatabase("MyData.db");
        }
    }
}