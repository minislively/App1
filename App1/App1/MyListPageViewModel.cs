using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1
{
    public class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> FoodList { get; set; }
        public MyListPageViewModel()
        {
            FoodList = new ObservableCollection<MyListModel>();
            FoodList.Add(new MyListModel { Name = "Test1", Image = "https://media.istockphoto.com/photos/juicy-hamburger-on-white-background-picture-id1206323282?k=20&m=1206323282&s=612x612&w=0&h=yatlq6BHRCCvoTzFZLSwaJc0O8Quct_tRPWtH0dj9Fc=", Detail = "This is Burger Page", Ingredients = "This is detail Burger Page listed" });
            FoodList.Add(new MyListModel { Name = "Test1", Image = "https://media.istockphoto.com/photos/juicy-hamburger-on-white-background-picture-id1206323282?k=20&m=1206323282&s=612x612&w=0&h=yatlq6BHRCCvoTzFZLSwaJc0O8Quct_tRPWtH0dj9Fc=", Detail = "This is Burger Page", Ingredients = "This is detail Burger Page listed" });
            FoodList.Add(new MyListModel { Name = "Test1", Image = "https://media.istockphoto.com/photos/juicy-hamburger-on-white-background-picture-id1206323282?k=20&m=1206323282&s=612x612&w=0&h=yatlq6BHRCCvoTzFZLSwaJc0O8Quct_tRPWtH0dj9Fc=", Detail = "This is Burger Page", Ingredients = "This is detail Burger Page listed" });
            FoodList.Add(new MyListModel { Name = "Test1", Image = "https://media.istockphoto.com/photos/juicy-hamburger-on-white-background-picture-id1206323282?k=20&m=1206323282&s=612x612&w=0&h=yatlq6BHRCCvoTzFZLSwaJc0O8Quct_tRPWtH0dj9Fc=", Detail = "This is Burger Page", Ingredients = "This is detail Burger Page listed" });
        }

    }
}
