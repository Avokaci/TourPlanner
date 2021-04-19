using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Input;
using TourPlanner.Models;
using TourPlanner.ViewModels;

namespace TourPlanner.Views
{
    public class MainViewModel: BaseViewModel
    {
        //instances
        private ObservableCollection<Tour> tours;
        private ObservableCollection<DataGridItem> logs;
        private Tour tour;
        private string serachBar;
        public ICommand searchCommand = new RelayCommand(o => {Search}, o => true);
        public ICommand clearCommand = new RelayCommand(o => {Clear}, o => true);

        //properties
        public ObservableCollection<Tour> Tours { get => tours; set => tours = value; }
        public ObservableCollection<DataGridItem> Logs { get => logs; set => logs = value; }
        

        public Tour Tour
        {
            get
            {
                return tour;
            }
            set
            {
                if((tour!=value)&&(value!=null))
                {
                    tour = value;
                    RaisePropertyChangedEvent(nameof(tour));
                }
            }
        }

        public string SerachBar
        {
            get
            {
                return SerachBar;
            }
            set
            {
                if (SerachBar != value)
                {
                    SerachBar = value;
                    RaisePropertyChangedEvent(nameof(SerachBar));
                }
            }
        }

        
    }
}
