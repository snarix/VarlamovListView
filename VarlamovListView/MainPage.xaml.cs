
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace VarlamovListView
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Hardware> Hardwares { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Hardwares = new ObservableCollection<Hardware>();
            hardwareList.ItemsSource = Hardwares;
        }

        private void AddClick(object sender, EventArgs e)
        {
            Hardware newHardware = new Hardware
            {
                TypeCPU = typeCPU.Text,
                Memory = memory.Text,
                HDD = hdd.Text,
                Video = video.Text
            };

            Hardwares.Add(newHardware);

            typeCPU.Text = string.Empty;
            memory.Text = string.Empty;
            hdd.Text = string.Empty;
            video.Text = string.Empty;
            
        }
    }
}