

namespace ContadorManual.Gui
{
    public partial class MainPage : ContentPage
    {
        private int _conteo;

        //_conteo lleva el conteo de la aplicacion
        public MainPage()
        {
            InitializeComponent();
            _conteo = 0;
            ConteoManual.Text=_conteo.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           _conteo++;
            ConteoManual.Text = _conteo.ToString();

        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
           _conteo= 0;

            ConteoManual.Text = _conteo.ToString();

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            _conteo--;

            ConteoManual.Text = _conteo.ToString();
        }
    }
}
