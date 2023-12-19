using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Novoselov_MAUI_Chetko
{
    //Код почти полностью скопирован с сайта METANIT,
    //поскольку думал что в моём изначальном коде ничего
    //не должно было работать

    public class User : INotifyPropertyChanged
    {
        string name = "";
        string surname = "";
        string number = "";
        string id = "";
        

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string SurName
        {
            get => surname;
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged();
                }
            }
        }public string Number
        {
            get => number;
            set
            {
                if (number != value)
                {
                    number = value;
                    OnPropertyChanged();
                }
            }
        }public string ID
        {
            get => id;
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
