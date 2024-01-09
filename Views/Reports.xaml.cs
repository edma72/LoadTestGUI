
namespace LoadTracking.Views;

public partial class Reports : ContentPage
{
	public Reports()
	{
		InitializeComponent();
	}

    public static implicit operator View(Reports v)
    {
        throw new NotImplementedException();
    }
}