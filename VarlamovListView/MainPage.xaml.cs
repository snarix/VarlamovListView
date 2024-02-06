
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace VarlamovListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Value.hardwares = new ObservableCollection<Hardware>();
           // hardwareList.ItemsSource = Hardwares;
        }

        private void AddClick(object sender, EventArgs e)
        {
            //if (int.TryParse(typeCPU.Text, out int _typeCPU) && int.TryParse(typeCPU.Text, out int _memory) && int.TryParse(typeCPU.Text, out int _hdd) && int.TryParse(typeCPU.Text, out int _video))
            //{
            //    Hardware newHardware = new Hardware
            //    {
            //        TypeCPU = _typeCPU,
            //        Memory = _memory,
            //        HDD = _hdd,
            //        Video = video.Text
            //    };
                Value.hardwares.Add(new Hardware { TypeCPU = Convert.ToInt32(typeCPU.Text), Memory = Convert.ToInt32(memory.Text), HDD = Convert.ToInt32(hdd.Text), Video = video.Text } );   
            //}

            //typeCPU.Text = string.Empty;
            //memory.Text = string.Empty;
            //hdd.Text = string.Empty;
            //video.Text = string.Empty;
        }
        private async void EndClick(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}