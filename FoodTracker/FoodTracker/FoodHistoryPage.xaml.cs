using FoodTracker.ModelView;
using FoodTracker.Service;
using FoodTracker.Models;
using System.Collections.Generic;

namespace FoodTracker;

public partial class FoodHistoryPage : ContentPage
{
	public FoodHistoryPage()
	{
		InitializeComponent();

		var foodHistoryViewModel = new FoodHistoryViewModel();
        BindingContext = foodHistoryViewModel;

        GetFoods(foodHistoryViewModel);
    }

    private async void GetFoods(FoodHistoryViewModel foodHistoryViewModel)
    {
        var list = await DataBaseService.GetFoods();
        list.Reverse();
        foreach (var item in list)
            foodHistoryViewModel.FoodList.Add(item);
    }

    private void HomeBtn_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new MainPage());
    }

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new FoodDetailView((Food)e.Item));
    }
}