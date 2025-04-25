namespace DIPLOM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var currentTheme = Preferences.Get("AppTheme", "System");
            SetTheme(currentTheme);
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            
            return new Window(new AppShell());
        }
        public static void SetTheme(string theme)
        {
            Application.Current.UserAppTheme = theme switch
            {
                "Dark" => AppTheme.Dark,
                "Light" => AppTheme.Light,
                _ => AppTheme.Unspecified // Системная тема
            };

            // Сохраняем выбор
            Preferences.Set("AppTheme", theme);
        }
    }
}