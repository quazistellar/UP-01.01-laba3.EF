using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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

namespace UP_laba3_EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UP_laba_1Entities1 context = new UP_laba_1Entities1();

        public MainWindow()
        {
            InitializeComponent();

            pomogite();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        public class space
        {
            public int PilotId { get; set; }
            public string NamePilot { get; set; }
            public string SurnamePilot { get; set; }
            public int AgePilot { get; set; }
            public int SpaceShipId { get; set; }
            public string NameShip { get; set; }
            public int AmountFlights { get; set; }
            public int TypeShipId { get; set; }
            public string TypeShipName { get; set; }
        }


        private void pomogite()
        {

            var ship = from p in context.PilotsOfShip
                       join s in context.SpaceShips on p.SpaceShip_ID equals s.ID_SpaceShip
                       join st in context.ShipsTypes on s.TypeShip_ID equals st.ID_TypeShip
                       select new space
                       {
                           PilotId = p.ID_Pilot,
                           NamePilot = p.NamePilot,
                           SurnamePilot = p.SurnamePilot,
                           AgePilot = p.AgePilot,
                           SpaceShipId = s.ID_SpaceShip,
                           NameShip = s.NameShip,
                           AmountFlights = s.AmountFlights,
                           TypeShipId = st.ID_TypeShip,
                           TypeShipName = st.Types_Name
                       };

            dgrid.ItemsSource = ship.ToList();
        }
    }
}
