namespace CompanyApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;

	}

	public List<Test> customList { get; set; } = new List<Test>() { new() { MyProperty = "Itam1" }, new() { MyProperty = "Itam2" }, new() { MyProperty = "Itam3" } };


}

public class Test
{
	public string MyProperty { get; set; }
}