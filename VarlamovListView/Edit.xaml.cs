using System.Collections.ObjectModel;
using System.ComponentModel;

using System.Text.Json;

namespace VarlamovListView;

public partial class Edit : ContentPage
{

    public Edit()
    {
        InitializeComponent();
        Value.hardwares = new ObservableCollection<Hardware>();
        Value.hardwares.Add(new Hardware
        {
            TypeCPU = 8,
            Memory = 4,
            HDD = 250,
            Video = "Acer"
        });

        Value.hardwares.Add(new Hardware
        {
            TypeCPU = 16,
            Memory = 8,
            HDD = 500,
            Video = "Logitech"
        });

        Value.hardwares.Add(new Hardware
        {
            TypeCPU = 32,
            Memory = 16,
            HDD = 750,
            Video = "LG"
        });

        Value.hardwares.Add(new Hardware
        {
            TypeCPU = 64,
            Memory = 32,
            HDD = 1000,
            Video = "Bnq"
        });

        hardwareList.ItemsSource = Value.hardwares;
    }

    protected virtual void OnAppearing()
    {
        hardwareList.ItemsSource = Value.hardwares;
    }

    private void RemoveClick(object sender, EventArgs e)
    {
        Hardware hardware = (Hardware)hardwareList.SelectedItem;
        if (hardware != null) 
        {
            Value.hardwares.Remove(hardware);
        }
    }

    string mainDir = FileSystem.Current.AppDataDirectory;
    private void SaveClick(object sender, EventArgs e)
    {
        string JsonString = JsonSerializer.Serialize(Value.hardwares);
        StreamWriter sw = new StreamWriter(Path.Combine(mainDir, "hardwaares.txt"));
        sw.WriteLine(JsonString);
        sw.Close();
    }

    private void LoadClick(object sender, EventArgs e)
    {
        StreamReader sw = new StreamReader(Path.Combine(mainDir, "hardwaares.txt"));
        string jsonString = sw.ReadLine();
        Value.hardwares = JsonSerializer.Deserialize<ObservableCollection<Hardware>>(jsonString);
        sw.Close();
        hardwareList.ItemsSource = Value.hardwares;
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
        await Navigation.PushAsync(new MainPage());
    }

    async private void EditClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MegaEdit());
    }
}