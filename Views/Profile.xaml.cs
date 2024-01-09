
namespace LoadTracking.Views;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}

    public static implicit operator View(Profile v)
    {
        throw new NotImplementedException();
    }
}