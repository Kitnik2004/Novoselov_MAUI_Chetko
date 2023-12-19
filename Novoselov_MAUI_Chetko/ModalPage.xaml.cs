using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Novoselov_MAUI_Chetko
{
    public partial class ModalPage:ContentPage
    {

        //Код почти полностью скопирован с сайта METANIT,
        //поскольку думал что в моём изначальном коде ничего
        //не должно было работать
        User Person { get; set; }
        public ModalPage(User? person)
        {
            InitializeComponent();
            if (person is null)
            {
                Person = new User();
            }
            else
            {
                Person = person;
            }
            BindingContext = Person;
        }
            async void GoToMainPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            if (Application.Current?.MainPage is NavigationPage navPage)
                {
                IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
                int pageCount = navPage.Navigation.NavigationStack.Count;
                if (navStack[pageCount - 1] is MainPage mainPage)
                {
            mainPage.AddPerson(Person);
            }
        }
     }

     }

 }
    