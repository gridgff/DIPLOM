namespace DIPLOM;

public partial class Vocabulary : ContentPage
{
	public Vocabulary()
	{
		InitializeComponent();
	}
    private void SubmitWord(object sender, EventArgs e)
    {
        
    }
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (sender is Slider slider)
        {
            double step = 1;
            double newValue = Math.Round(e.NewValue / step) * step;

            if (Math.Abs(slider.Value - newValue) > 0.001)
            {
                slider.Value = newValue; 
            }
        }
    }
}