namespace connRoy_FinalProject_RecipeManager
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Exit program
            this.Close();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            // Spawn about window
            var aboutWindow = new About();
            aboutWindow.ShowDialog();
        }

        private void newDatabaseBtn_Click(object sender, EventArgs e)
        {
            // Spawn blank recipe book manager
            var newRecipeBook = new BookManager(openFile, saveFile);
            newRecipeBook.ShowDialog();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            // Create new database
            Database db = new Database(openFile, saveFile);

            // Open database before recipe book manager
            try
            {
                db.PopulateDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid recipe book file. Cancelling.");
                return;
            }

            // Spawn book manager window
            var editRecipeBook = new BookManager(openFile, saveFile, db);
            editRecipeBook.ShowDialog();
        }
    }
}
