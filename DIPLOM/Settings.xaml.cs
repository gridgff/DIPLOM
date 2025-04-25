using Microsoft.Maui.Controls;

namespace DIPLOM;

public partial class Settings : ContentPage
{
    public Settings()
    {
        InitializeComponent();
        LoadCurrentSettings();
    }

    private void LoadCurrentSettings()
    {
        // Load current theme setting
        var currentTheme = Application.Current.RequestedTheme;
        LightThemeRadio.IsChecked = currentTheme == AppTheme.Light;
        DarkThemeRadio.IsChecked = currentTheme == AppTheme.Dark;

        

        // Load notification settings
        DailyRemindersSwitch.IsToggled = Preferences.Get("DailyReminders", true);
        ProgressNotificationsSwitch.IsToggled = Preferences.Get("ProgressNotifications", true);

        
    }

    private void OnSaveSettingsClicked(object sender, EventArgs e)
    {
        // Save theme setting
        var newTheme = LightThemeRadio.IsChecked ? AppTheme.Light : AppTheme.Dark;
        Application.Current.UserAppTheme = newTheme;
        Preferences.Set("AppTheme", newTheme.ToString());

        

        // Save notification settings
        Preferences.Set("DailyReminders", DailyRemindersSwitch.IsToggled);
        Preferences.Set("ProgressNotifications", ProgressNotificationsSwitch.IsToggled);


        DisplayAlert("Success", "Settings saved successfully!", "OK");
    }
}