namespace VarlamovListView;

public partial class MegaEdit : ContentPage
{
	public MegaEdit()
	{
		InitializeComponent();
	}
    private void EditClick(object sender, EventArgs e)
    {

    }
    private async void EndClick(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}