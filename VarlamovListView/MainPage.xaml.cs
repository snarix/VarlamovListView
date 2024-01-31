
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
            if (int.TryParse(typeCPU.Text, out int _typeCPU) && int.TryParse(typeCPU.Text, out int _memory) && int.TryParse(typeCPU.Text, out int _hdd) && int.TryParse(typeCPU.Text, out int _video))
            {
                Hardware newHardware = new Hardware
                {
                    TypeCPU = _typeCPU,
                    Memory = _memory,
                    HDD = _hdd,
                    Video = video.Text
                };
                Hardwares.Add(newHardware);
            }
         



            typeCPU.Text = string.Empty;
            memory.Text = string.Empty;
            hdd.Text = string.Empty;
            video.Text = string.Empty;

        }
    }
}