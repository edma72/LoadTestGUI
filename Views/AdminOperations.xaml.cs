
namespace LoadTracking.Views;

public partial class AdminOperations : ContentPage
{
	public AdminOperations()
	{
		InitializeComponent();
	}

    public static implicit operator View(AdminOperations v)
    {
        throw new NotImplementedException();
    }
}