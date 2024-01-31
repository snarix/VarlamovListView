using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.Json;

namespace VarlamovListView;

public partial class Edit : ContentPage
{
    public ObservableCollection<Hardware> Hardwares;

    public Edit()
    {
        InitializeComponent();
        Hardwares = new ObservableCollection<Hardware>();
        Hardwares.Add(new Hardware
        {
            TypeCPU = 8,
            Memory = 4,
            HDD = 250,
            Video = "Acer"
        });

        Hardwares.Add(new Hardware
        {
            TypeCPU = 16,
            Memory = 8,
            HDD = 500,
            Video = "Logitech"
        });

        Hardwares.Add(new Hardware
        {
            TypeCPU = 32,
            Memory = 16,
            HDD = 750,
            Video = "LG"
        });

        Hardwares.Add(new Hardware
        {
            TypeCPU = 64,
            Memory = 32,
            HDD = 1000,
            Video = "Bnq"
        });
        
        hardwareList.ItemsSource = Hardwares;
    }

    private void RemoveClick(object sender, EventArgs e)
    {
        Hardware hardware = (Hardware)hardwareList.SelectedItem;
        if (hardware != null) 
        {
            Hardwares.Remove(hardware);
        }
    }

    string mainDir = FileSystem.Current.AppDataDirectory;
    private void SaveClick(object sender, EventArgs e)
    {
        string JsonString = JsonSerializer.Serialize(Hardwares);
        StreamWriter sw = new StreamWriter(Path.Combine(mainDir, "hardwares.txt"));
        sw.WriteLine(JsonString);
        sw.Close();
    }

    private void LoadClick(object sender, EventArgs e)
    {
        StreamReader sw = new StreamReader(Path.Combine(mainDir, "hardwares.txt"));
        string jsonString = sw.ReadLine();
        Hardwares = JsonSerializer.Deserialize<ObservableCollection<Hardware>>(jsonString);
        sw.Close();
        hardwareList.ItemsSource = Hardwares;
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

    async private void AddClick(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
    }

    async private void EditClick(object sender, EventArgs e)
    {
        
    }
}