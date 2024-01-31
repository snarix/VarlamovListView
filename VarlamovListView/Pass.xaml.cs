
using System.Data;

namespace VarlamovListView;

public partial class Pass : ContentPage
{
    public Pass()
    {
        InitializeComponent();
        foreach (Button el in passGrid.Children)
        {
            if (el != deleteBtn) el.Clicked += Button_Clicked;
        }
    }

    //string pass = "123";
    //int count = 0;
    private void Button_Clicked(object sender, EventArgs e)
    {
        string str = ((Button)sender).Text;
        //count++;

        //if (count == pass.Length)
        //{
        if(str != null)
        {
            lblOutput.Text += str;
        }
        
        if (lblOutput.Text == "123")
        {
            AppShell.Current.CurrentItem = new Edit();
        }
        //}
    }

    private void DeleteBtn(object sender, EventArgs e)
    {
        if (lblOutput.Text != null && lblOutput.Text != "")
        {

            lblOutput.Text = lblOutput.Text[..^1];
        }
    }
}