namespace EditorExample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Entry_Completed(object sender, EventArgs e)
	{
		label.Text = entry.Text;
	}
	
	private void Entry_Completed_Unfocus(object sender, EventArgs e)
	{
		label1.Text = entry1.Text;
		entry1.Unfocus();
	}
}

