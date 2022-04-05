namespace Dark
{
    public partial class MainForm : Form
    {
        private const int GWL_EXSTYLE = (-20);
        private const int WS_EX_TRANSPARENT = 0x20;

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int GetWindowLong(IntPtr hwnd, int nIndex);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ = SetWindowLong(Handle, GWL_EXSTYLE, GetWindowLong(Handle, GWL_EXSTYLE) | WS_EX_TRANSPARENT);
        }
    }
}