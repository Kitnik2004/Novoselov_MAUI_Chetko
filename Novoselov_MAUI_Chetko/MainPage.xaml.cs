using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace Novoselov_MAUI_Chetko
{

    public partial class MainPage : ContentPage
    {
        //Объявление переменных 
        ObservableCollection<User> _ListView { get; set; }
        public User temp;

        //Метод для создания нового юзера
        protected internal void AddPerson(User Person)
        {
            _ListView.Add(Person);
        }
        //Основная программа
        public MainPage()
        {
            InitializeComponent();

            //Создание нового списка с двумя пробными пользователями
            _ListView = new ObservableCollection<User> 
            {
                new User{ Name = "Nikita", SurName = "ashid", Number = "734287623470", ID = "0"},
                new User{ Name = "Nikita", SurName = "ashid", Number = "73428762347", ID = "0"}
            };
            userDelete.IsEnabled = false; //Отключение кнопки удаления
            usersListView.BindingContext = _ListView; //Задать ItemsSource
        }

        //Кнопка удаления персонажа
        private void DeleteThisUser(object sender, EventArgs e) 
        {
            _ListView.Remove(temp); //Удаление из списка
            usersListView.SelectedItem = null; //Отмена выбора
            userDelete.IsEnabled = false; //Отключение кнопки
        }

        //Кнопка создания персонажа
        private async void NewUserInList(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new ModalPage(null));//Переход на страницу создания
        }

        //Обработчик событий выбора в списке
        private void usersListView_ItemSelected(object sender, ItemTappedEventArgs e)
        {
            userDelete.IsEnabled = true; //Включение кнопки
            User temp = e.Item as User; //Создание временного персонажа для удаления из списка
        }
    }
}