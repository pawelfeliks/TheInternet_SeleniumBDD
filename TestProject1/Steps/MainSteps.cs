namespace TestProject1.Steps
{
    public class MainSteps
    {
        protected Application App { get; set; }

        public MainSteps()
        {
            App = new Application();
        }

        public void CloseApp()
        {
            App.Driver.Close();
            App.Driver.Dispose();
        }
    }
}
