namespace proje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void boardSizeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void diffucultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(diffucultyBox.SelectedIndex == 3)
            {
                boardSizeText.Enabled = true;
                numberOfLivesText.Enabled = true;
                showingTimeText.Enabled = true; 
                numberOfTilesText.Enabled = true;  
            }
        }
    }
}