using engine;

namespace Survival
{
    public partial class survival : Form
    {

        private Player _player;
        public survival()
        {
            InitializeComponent();

            _player = new Player(10,10,20,0,1);

            Location location = new Location(1, "Home", "Your house. You really should clean up the place.");

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        
    }
}
