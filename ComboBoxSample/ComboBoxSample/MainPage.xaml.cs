using System.Collections.ObjectModel;

namespace ComboBoxSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Model
    {
        public string? Name { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Designation { get; set; }
        public string? ID { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Model> Employees { get; set; }
        public ViewModel()
        {
            Employees = new ObservableCollection<Model>();
            Employees.Add(new Model
            {
                Name = "Jessica Martinez",
                ProfilePicture = "Jessy.png",
                Designation = "Developer",
                ID = "E001",
            });
            Employees.Add(new Model
            {
                Name = "Robert Lee",
                ProfilePicture = "Robert.png",
                Designation = "Developer",
                ID = "E002",
            });
            Employees.Add(new Model
            {
                Name = "Andrew Fuller",
                ProfilePicture = "Andrew.png",
                Designation = "Team Lead",
                ID = "E003",
            });
            Employees.Add(new Model
            {
                Name = "Sarah Davis",
                ProfilePicture = "Sarah.png",
                Designation = "Product Manager",
                ID = "E004",
            });
        }
    }
}