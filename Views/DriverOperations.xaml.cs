
namespace LoadTracking.Views;

public partial class DriverOperations : ContentPage
{
	public DriverOperations()
	{
		InitializeComponent();
	}

    public static implicit operator View(DriverOperations v)
    {
        throw new NotImplementedException();
    }
}