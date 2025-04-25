namespace DIPLOM;

public partial class Vocabulary : ContentPage
{
	public Vocabulary()
	{
		InitializeComponent();
        MinL.Text = $"{WordsCountSlider.Minimum:F0}";
        MaxL.Text = $"{WordsCountSlider.Maximum:F0}";
    }
    private void SubmitWord(object sender, EventArgs e)
    {
        SliderContainer.IsVisible = false;

        
        InstructionL.IsVisible = false;
        InstructionL2.IsVisible = false;
        CurrentL.IsVisible = false;
        WordsGrid.IsVisible = true;
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        CurrentL.Text = $"Selected words: {e.NewValue:F0}";
    }
}