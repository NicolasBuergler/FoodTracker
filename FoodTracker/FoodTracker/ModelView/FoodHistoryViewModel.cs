using FoodTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.ModelView
{
    public class FoodHistoryViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Food> foodList = new ObservableCollection<Food>();

        public ObservableCollection<Food> FoodList
        {
            get => foodList;
            set
            {
                foodList = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
