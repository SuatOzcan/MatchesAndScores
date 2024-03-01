using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBoxC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() 
            { 
                Team1 = "Besiktas", 
                Team2 ="Galatasaray", Score1 =3 , 
                Score2 =2,
                Completion=85});

            matches.Add(new Match()
            {
                Team1 = "Bayar Munich",
                Team2 = "Real Mardin",
                Score1 = 1,
                Score2 = 3,
                Completion = 50
            });

            matches.Add(new Match() { Team1 = "Yener Bahce", 
                Team2 = "Kalay Spor", 
                Score1 = 4,
                Score2 = 5, 
                Completion = 19 });

            LbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(LbMatches.SelectedItem != null)
            {
                MessageBox.Show("The selected match is:\n" + (LbMatches.SelectedItem as Match).Team1 + "  " +
                    (LbMatches.SelectedItem as Match).Score1 + " - " +
                    (LbMatches.SelectedItem as Match).Score2 +"  " +
                    (LbMatches.SelectedItem as Match).Team2 +"\nCompletion: " + "The game is at the " +
                    (LbMatches.SelectedItem as Match).Completion + "-minute mark.");
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
        public Match() { }


    }
}
