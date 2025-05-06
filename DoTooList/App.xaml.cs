namespace DoTooList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Override the CreateWindow method to return a custom window instance. This is the starting point for the application.
        /// </summary>
        /// <param name="activationState"></param> 
        /// <returns></returns>
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}