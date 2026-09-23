using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace connRoy_FinalProject_RecipeManager
{
    public partial class RecipeEditor : Form
    {
        // Properties
        Recipe CurrentRecipe { get; init; }

        internal RecipeEditor(Recipe recipe)
        {
            InitializeComponent();

            this.CurrentRecipe = recipe;
        }

        private void RecipeEditor_Load(object sender, EventArgs e)
        {
            // Set basic recipe information
            nameText.Text = this.CurrentRecipe.Name;
            prepTimeNumeric.Value = this.CurrentRecipe.PrepTime;
            cookTimeNumeric.Value = this.CurrentRecipe.CookTime;
            totalTimeNumeric.Value = this.CurrentRecipe.TotalTime();

            // Populate ingredients list
            foreach (string ingredient in this.CurrentRecipe.Ingredients)
            {
                ingredientsList.Items.Add(ingredient);
            }

            // Populate instructions list
            foreach (string instruction in this.CurrentRecipe.Instructions)
            {
                instructionsList.Items.Add(instruction);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Check if name is blank
            if (Recipe.StringIsEmpty(nameText.Text))
            {
                MessageBox.Show("Your recipe must have a name.");
                return;
            }

            // Make sure name doesn't contain delimiter characters
            if (Recipe.ContainsDelimiter(nameText.Text))
            {
                Recipe.DelimiterError();
                return;
            }

            // Check to see if ingredients list has items
            if (ingredientsList.Items.Count == 0)
            {
                MessageBox.Show("You must have at least 1 ingredient to save this recipe.");
                return;
            }

            // Check to see if instructions list has items
            if (instructionsList.Items.Count == 0)
            {
                MessageBox.Show("You must have at least 1 instruction to save this recipe.");
                return;
            }

            this.CurrentRecipe.Name = nameText.Text;

            // Try to convert prep time value to int and update recipe
            try
            {
                this.CurrentRecipe.PrepTime = (int)prepTimeNumeric.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prep time must be an integer.");
            }

            // Try to convert cook time value to int and update recipe
            try
            {
                this.CurrentRecipe.CookTime = (int)cookTimeNumeric.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cook time must be an integer.");
            }

            // Clear ingredients list and populate it with list box contents
            this.CurrentRecipe.Ingredients.Clear();

            foreach (string ingredient in ingredientsList.Items)
            {
                this.CurrentRecipe.Ingredients.Add(ingredient);
            }

            // Clear instructions list and populate it with list box contents
            this.CurrentRecipe.Instructions.Clear();

            foreach (string instruction in instructionsList.Items)
            {
                this.CurrentRecipe.Instructions.Add(instruction);
            }
        }

        private void addIngredientBtn_Click(object sender, EventArgs e)
        {
            // Setup variables
            LineEdit addWindow;
            string ingredient = "";

            // Spawn add line window
            addWindow = new LineEdit(ingredient);
            addWindow.ShowDialog();

            // Set ingredient to add line window's output
            ingredient = addWindow.Output();

            // Add new ingredient to list box if not empty
            if (!Recipe.StringIsEmpty(ingredient))
            {
                ingredientsList.Items.Add(ingredient);
            }
        }

        private void editIngredientBtn_Click(object sender, EventArgs e)
        {
            int index = ingredientsList.SelectedIndex;
            LineEdit editWindow;
            string ingredient;

            // Select string for line editing
            if (index == -1)
            {
                MessageBox.Show("You must select an ingredient to edit.");
                return;
            }

            ingredient = ingredientsList.SelectedItem.ToString();

            // Spawn window to edit line
            editWindow = new LineEdit(ingredient);
            editWindow.ShowDialog();

            ingredient = editWindow.Output();

            // Set selected item to new ingredient text if ingredient is not empty
            if (!Recipe.StringIsEmpty(ingredient))
            {
                ingredientsList.Items[index] = ingredient;
            }

        }

        private void removeIngredientBtn_Click(object sender, EventArgs e)
        {
            // Show error if user doesn't select ingredient to remove
            if (ingredientsList.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select an ingredient to remove it.");
                return;
            }

            // Remove selected ingredient
            ingredientsList.Items.RemoveAt(ingredientsList.SelectedIndex);
            return;
        }

        private void addInstructionBtn_Click(object sender, EventArgs e)
        {
            // Setup variables
            LineEdit addWindow;
            string instruction = "";

            // Spawn add line window
            addWindow = new LineEdit(instruction);
            addWindow.ShowDialog();

            // Set instruction to add line window's output
            instruction = addWindow.Output();

            // Add new instruction to list box if not empty
            if (!Recipe.StringIsEmpty(instruction))
            {
                instructionsList.Items.Add(instruction);
            }
        }

        private void editInstructionBtn_Click(object sender, EventArgs e)
        {
            int index = instructionsList.SelectedIndex;
            LineEdit editWindow;
            string instruction;

            // Select string for line editing
            if (index == -1)
            {
                MessageBox.Show("You must select an instruction to edit.");
                return;
            }

            instruction = instructionsList.SelectedItem.ToString();

            // Spawn window to edit line
            editWindow = new LineEdit(instruction);
            editWindow.ShowDialog();

            instruction = editWindow.Output();

            // Set selected item to new instruction text if not empty
            if (!Recipe.StringIsEmpty(instruction))
            {
                instructionsList.Items[index] = instruction;
            }
        }

        private void removeInstructionBtn_Click(object sender, EventArgs e)
        {
            // Show error if user doesn't select instruction to remove
            if (instructionsList.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select an instruction to remove it.");
                return;
            }

            // Remove selected instruction
            instructionsList.Items.RemoveAt(instructionsList.SelectedIndex);
            return;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveExitBtn_Click(object sender, EventArgs e)
        {
            this.saveBtn_Click(sender, e);
            this.exitBtn_Click(sender, e);
        }

        private void prepTimeNumeric_ValueChanged(object sender, EventArgs e)
        {
            // Try to convert prep time value to int and update recipe
            try
            {
                this.CurrentRecipe.PrepTime = (int)prepTimeNumeric.Value;

                // Update total time
                totalTimeNumeric.Value = this.CurrentRecipe.TotalTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prep time must be an integer.");
            }
        }

        private void cookTimeNumeric_ValueChanged(object sender, EventArgs e)
        {
            // Try to convert prep time value to int and update recipe
            try
            {
                this.CurrentRecipe.CookTime = (int)cookTimeNumeric.Value;

                // Update total time
                totalTimeNumeric.Value = this.CurrentRecipe.TotalTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cook time must be an integer.");
            }
        }
    }
}
