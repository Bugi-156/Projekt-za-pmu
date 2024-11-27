namespace Projekt_za_pmu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

      
        private void OnFreeFallModeSelected(object sender, EventArgs e)
        {
          
            HeightEntry.IsVisible = true;
            GravityEntry.IsVisible = true;
            FrequencyEntry.IsVisible = false;
            WavelengthEntry.IsVisible = false;
        }

       
        private void OnWaveSpeedModeSelected(object sender, EventArgs e)
        {
        
            HeightEntry.IsVisible = false;
            GravityEntry.IsVisible = false;
            FrequencyEntry.IsVisible = true;
            WavelengthEntry.IsVisible = true;
        }

    
        private void OnCalculateClicked(object sender, EventArgs e)
        {
          
            if (HeightEntry.IsVisible && GravityEntry.IsVisible)
            {
                if (double.TryParse(HeightEntry.Text, out double height) &&
                    double.TryParse(GravityEntry.Text, out double gravity))
                {
                    if (height > 0 && gravity > 0)
                    {
                        double time = Math.Sqrt((2 * height) / gravity);
                        ResultLabel.Text = $"Vrijeme slobodnog pada: {time:F2} sekundi";
                    }
                    else
                    {
                        ResultLabel.Text = "Visina i gravitacija moraju biti pozitivni brojevi.";
                    }
                }
                else
                {
                    ResultLabel.Text = "Molimo unesite ispravne brojeve za visinu i gravitaciju.";
                }
            }
    
            else if (FrequencyEntry.IsVisible && WavelengthEntry.IsVisible)
            {
                if (double.TryParse(FrequencyEntry.Text, out double frequency) &&
                    double.TryParse(WavelengthEntry.Text, out double wavelength))
                {
                    if (frequency > 0 && wavelength > 0)
                    {
                        double speed = frequency * wavelength;
                        ResultLabel.Text = $"Brzina vala: {speed:F2} m/s";
                    }
                    else
                    {
                        ResultLabel.Text = "Frekvencija i valna duljina moraju biti pozitivni brojevi.";
                    }
                }
                else
                {
                    ResultLabel.Text = "Molimo unesite ispravne brojeve za frekvenciju i valnu duljinu.";
                }
            }
        }
    }
}
