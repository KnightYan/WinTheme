using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinTheme
{
    public partial class FrmPrincipal : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public FrmPrincipal()
        {
            InitializeComponent();
            LoadTheme();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void LoadTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);
            /*btnlightColor.BackColor = themeColor;
            btndarkColor.BackColor = darkColor;
            btnthemeColor.BackColor = themeColor;

            pnllightColor.BackColor = themeColor;
            pnldarkColor.BackColor = darkColor;
            pnlthemeColor.BackColor = lightColor;*/

            //var TitleBar = 


            //Buttons
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if ("winTheme" == (string)button.Tag)
                {
                    button.BackColor = lightColor;
                    button.ForeColor = darkColor;
                }
            }

            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                panel.BackColor = themeColor;
            }
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }
        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        /*[DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCPAINT = 0x85;
            if (m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Green, new Rectangle(0, 0, 4800, 23));
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }*/
    }
}
