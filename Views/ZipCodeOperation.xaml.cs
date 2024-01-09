
namespace LoadTracking.Views;

public partial class ZipCodeOperation : ContentPage
{
	public ZipCodeOperation()
	{
		InitializeComponent();
	}

    public static implicit operator View(ZipCodeOperation v)
    {
        throw new NotImplementedException();
    }
}