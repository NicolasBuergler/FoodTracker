using FoodTracker.Models;
using FoodTracker.ModelView;

namespace FoodTracker;

public partial class FoodDetailView : ContentPage
{
	public FoodDetailView(Food food)
	{
		InitializeComponent();
        SetBindingContext(food);
	}

    private void HomeBtn_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new MainPage());
    }

	public void SetBindingContext(Food food)
	{
        var foodDetailModelView = new FoodDetailModelView();
        foodDetailModelView.Food = food;

        BindingContext = foodDetailModelView;
    }
}