namespace DesktopDeclutterer

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string clutterFolderPath = Path.Combine(desktopPath, "Desktop_Clutter");

            try
            {
                if (!Directory.Exists(clutterFolderPath))
                {
                    Directory.CreateDirectory(clutterFolderPath);
                }
                string[] desktopFiles = Directory.GetFiles(desktopPath);

                foreach (string file in desktopFiles)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationpath = Path.Combine(clutterFolderPath, fileName);

                    if (!File.Exists(destinationpath))
                    {
                        File.Move(file, destinationpath);
                    }

                }
                MessageBox.Show("Desktop items successfully moved to Desktop_Clutter", "Declutter is Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error happened: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string clutterFolderPath = Path.Combine(desktopPath, "Desktop_Clutter");

            try
            {
                if (Directory.Exists(clutterFolderPath))
                {
                    string[] clutterFiles = Directory.GetFiles(clutterFolderPath);

                    foreach (string file in clutterFiles)
                    {
                        string fileName = Path.GetFileName(file);
                        string destinationPath = Path.Combine(desktopPath, fileName);

                        if (!File.Exists(destinationPath))
                        {
                            File.Move(file, destinationPath);
                        }
                    }

                    Directory.Delete(clutterFolderPath);
                    MessageBox.Show("Desktop items restored from Desktop_Clutter folder.", "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Desktop_Clutter folder found.", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}