using System.Collections.ObjectModel;
using System.ComponentModel;

namespace VarlamovListView;

public partial class Edit : ContentPage
{
    public ObservableCollection<Hardware> Hardwares { get; set; }

    public Edit()
    {
        InitializeComponent();
        Hardwares = new ObservableCollection<Hardware>();
        Hardwares.Add(new Hardware
        {
            TypeCPU = "8 разрядный ",
            Memory = "4Gb ",
            HDD = "250Gb ",
            Video = "Acer"
        });

        Hardwares.Add(new Hardware
        {
            TypeCPU = "16 разрядный ",
            Memory = "8Gb ",
            HDD = "500Gb ",
            Video = "Logitech"
        });

        Hardwares.Add(new Hardware
        {
            TypeCPU = "32 разрядный ",
            Memory = "16Gb ",
            HDD = "1Tb ",
            Video = "LG"
        });

        Hardwares.Add(new Hardware
        {
            TypeCPU = "64 разрядный ",
            Memory = "32Gb ",
            HDD = "2Tb ",
            Video = "Bnq"
        });
        
        hardwareList.ItemsSource = Hardwares;
    }
   
    public void RemoveHardware(Hardware hardware)
    {
        Hardwares.Remove(hardware);
    }

    private void RemoveClick(object sender, EventArgs e)
    {
        Hardware hardware = (Hardware)hardwareList.SelectedItem;
        if (hardware != null) 
        {
            RemoveHardware(hardware);
        }
    }

    private void EditClick(object sender, EventArgs e)
    {

    }

    private void SaveClick(object sender, EventArgs e)
    {

    }

    private void hardwareList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Hardware selectedItem;
        if (e.SelectedItem != null)
        {
            selectedItem = (Hardware)e.SelectedItem;
            selectedText.Text = selectedItem.Video + " " + selectedItem.TypeCPU;
        }
    }
}