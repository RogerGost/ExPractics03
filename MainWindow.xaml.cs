using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExPractics03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ActivarMissatge_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Acció realitzada correctament");
        }
        private void MostrarLable_Click(object sender, RoutedEventArgs e)
            
        {
            TextBlock newText = new TextBlock();
            boto1.Content = "Mona Lisa";
            newText.TextWrapping = TextWrapping.Wrap;
            newText.Text = "El retrato de Lisa Gherardini, esposa de Francesco del Giocondo, más conocido como La Gioconda " +
                             "(La Joconde en francés) o Monna Lisa, es una obra pictórica del polímata renacentista italiano Leonardo da Vinci. " +
                             "Fue adquirida por el rey Francisco I de Francia a comienzos del siglo XVI.";
            boto2.IsEnabled = false;
            nocheEstrellada.Visibility = Visibility.Collapsed;
            monaLisa.Visibility = Visibility.Visible;

            canviarText.Content = newText;
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            boto2.IsEnabled = true;
            boto1.Content = "La Noche Estrellada";
            TextBlock originalText = new TextBlock();
            originalText.TextWrapping = TextWrapping.Wrap;
            originalText.Text = "La noche estrellada es un óleo sobre lienzo del pintor postimpresionista neerlandés Vincent van Gogh."+
                                    "Pintado en junio de 1889, representa la vista desde la ventana orientada al este de su habitación" +
                                    "de asilo en Saint-Rémy - de - Provence, justo antes del amanecer, con la adición de un pueblo imaginario.";
            canviarText.Content = originalText;
            nocheEstrellada.Visibility = Visibility.Visible;
            monaLisa.Visibility = Visibility.Collapsed;

        }







    }
}