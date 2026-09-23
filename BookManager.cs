using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace connRoy_FinalProject_RecipeManager
{
    public partial class BookManager : Form
    {
        // Properties
        Database DB { get; init; }

        List<Recipe> RecipeBook { get; init; }

        // Initialize window with new recipe book database
        internal BookManager(OpenFileDialog opener, SaveFileDialog saver, Database? db = null)
        {
            InitializeComponent();

            // Initialize database and recipe book
            if (db != null)
            {
                this.DB = db;
            }
            else
            {
                this.DB = new Database(opener, saver);
            }

            this.RecipeBook = this.DB.Data;
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            // Load recipe names to list box
            foreach (Recipe recipe in this.RecipeBook)
            {
                recipesList.Items.Add(recipe.Name);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Create blank recipe
            Recipe newRecipe = new Recipe();

            // Show new recipe window and get recipe data
            var newRecipeWindow = new RecipeEditor(newRecipe);
            newRecipeWindow.ShowDialog();

            if (newRecipe.Name != "" && newRecipe.Name != null && newRecipe.Name.Length > 0)
            {
                // Add recipe to recipe book and list box only if it's been filled out.
                this.RecipeBook.Add(newRecipe);
                recipesList.Items.Add(newRecipe.Name);
            }   
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int recipeIndex = recipesList.SelectedIndex;

            // Cancel if no recipe selected
            if (recipeIndex == -1)
            {
                MessageBox.Show("You must select a recipe to edit.");
                return;
            }

            // Get recipe to edit
            Recipe recipe = this.RecipeBook[recipeIndex];

            // Edit recipe in window
            var editRecipeWindow = new RecipeEditor(recipe);
            editRecipeWindow.ShowDialog();

            // Update the selected recipe and entry in list box
            this.RecipeBook[recipeIndex] = recipe;
            recipesList.Items[recipeIndex] = recipe.Name;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int recipeIndex = recipesList.SelectedIndex;

            // Cancel if no recipe selected
            if (recipeIndex == -1)
            {
                MessageBox.Show("You must select a recipe to remove.");
                return;
            }

            // Remove selected item from recipe book and listbox
            this.RecipeBook.RemoveAt(recipeIndex);
            recipesList.Items.RemoveAt(recipeIndex);
        }

        private void markdownBtn_Click(object sender, EventArgs e)
        {
            int recipeIndex = recipesList.SelectedIndex;

            // Cancel if no recipe selected
            if (recipeIndex == -1)
            {
                MessageBox.Show("You must select a recipe to export.");
                return;
            }

            // Get recipe based on selected index
            Recipe recipe = this.RecipeBook[recipeIndex];

            // Save recipe to markdown file on disk
            recipe.SaveToMarkDownFile(this.DB.Saver);

            return;
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            // Save database
            this.DB.Save();
        }

        private void saveExitBtn_Click(object sender, EventArgs e)
        {
            // Save database then exit
            this.DB.Save();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Close without saving
            this.Close();
        }
    }
}
