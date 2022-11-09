using Timer = System.Windows.Forms.Timer;

namespace UPanelZeitgeber
{
    public partial class MainForm : Form
    {
        private Timer _GrafischeUhr;
        private bool Clicked = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdStartTimer_Click(object sender, EventArgs e)
        {
            if(!Clicked)
            {
                CmdStartTimer.Text = "Pause";
                _GrafischeUhr = new Timer();
                _GrafischeUhr.Enabled = true;
                _GrafischeUhr.Interval = 40 ;
                _GrafischeUhr.Tick += new EventHandler(GrafischeUhr_Tick);
                Clicked = true;
                
            }
            else
            {
                CmdStartTimer.Text = "Start";
                _GrafischeUhr.Stop();
                _GrafischeUhr.Tick -= new EventHandler(GrafischeUhr_Tick);
                Clicked = false;
            }
        }



        private void CmdClose_Click(object sender, EventArgs e)
        {
            _GrafischeUhr.Stop();
            Close();
        }

        private void GrafischeUhr_Tick(object sender, EventArgs e)
        {
            /* switch (_grafischeUhr. "ElapsedTime") entweder die Zeit oder die zurückgelegte Strecke switchen, Strecke
             * bietet sich an wenn Form !responsive gemacht wird (selbst da könnt man aber sicher teilen)
             * Zeit nur wenn ich eine Pausefunktion einführe, da ich ja den Uhrenwert in millisekunden mitzählen will
             * ein mappen wäre hier vielleicht ungenau da ja hier doubles entstehen werden.
             *  case ElapsedTime < 7500 : 
             *  case ElapsedTime < 15000 :
             *  case ElapsedTime < 22500 :
             *  case ElapsedTime <  
             */

            PnSquare1.Location = new Point(PnSquare1.Location.X + 1, PnSquare1.Location.Y -1);
            PnSquare2.Location = new Point(PnSquare2.Location.X +1,PnSquare2.Location.Y +1);
            PnSquare3.Location = new Point(PnSquare3.Location.X -1, PnSquare3.Location.Y -1);
            PnSquare4.Location = new Point(PnSquare4.Location.X -1, PnSquare4.Location.Y +1);
        }
    }
}