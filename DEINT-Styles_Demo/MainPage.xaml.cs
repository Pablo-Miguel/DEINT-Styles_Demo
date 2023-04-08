using Microsoft.Extensions.Options;

namespace DEINT_Styles_Demo;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void CounterBtn2_Clicked(object sender, EventArgs e)
    {
		Application.Current.Resources.TryGetValue("botonVerde", out var valor);
		Resources["dynamicStyle"] = (Style) valor;
    }
}

