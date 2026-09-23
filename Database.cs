using System;
using System.Collections.Generic;
using System.Text;

namespace connRoy_FinalProject_RecipeManager
{
    internal class Database
    {
        // Constructors
        public Database(OpenFileDialog opener, SaveFileDialog saver)
        {
            this.FilePath = null;

            // Database composed in CSV class
            this.Data = new List<Recipe>();

            // OpenFileDialog and SaveFileDialog should both be available for CSV class
            this.Opener = opener;
            this.Saver = saver;
        }

        // Properties        
        public string? FilePath { get; set; }

        public List<Recipe> Data { get; init; }

        public OpenFileDialog Opener { get; init; }

        public SaveFileDialog Saver { get; init; }

        // Show this if user doesn't pick a file in OpenFileDialog or SaveFileDialog
        public static void CancelMessage()
        {
            MessageBox.Show("Operation Cancelled.");
        }

        // Show exception message in MessageBox with optional custom message
        public static void Error(Exception ex, string? customMessage = null)
        {
            StringBuilder sb = new StringBuilder();

            if (customMessage != null)
            {
                sb.AppendLine(customMessage);
            }

            sb.AppendLine(ex.Message);

            MessageBox.Show(sb.ToString());
        }

        // Read lines from text file on disk to string array
        public string[]? ReadFileToStringArray()
        {
            if (this.Opener.ShowDialog() != DialogResult.OK)
            {
                Database.CancelMessage();
                return null;
            }

            this.FilePath = this.Opener.FileName;

            return File.ReadAllLines(this.FilePath);
        }

        // Try to convert each line in text file from CSV to a Recipe object and load them into the database
        public void PopulateDatabase()
        {
            string[]? contents = this.ReadFileToStringArray();

            // Throw error if file contained no data
            if (contents == null)
            {
                throw new Exception("Database file did not contain any data.");
            }

            // Iterate over each line in the file
            foreach (string line in contents)
            {
                try
                {
                    // Create a new recipe from each line
                    Recipe recipe = new Recipe(line);

                    // Add recipe to database if valid
                    this.Data.Add(recipe);
                }
                catch (Exception ex)
                {
                    // Do not throw error for invalid lines
                    continue;
                }
            }

            // Throw an error if database contains no valid data
            if (this.Data.Count == 0)
            {
                throw new Exception("Database file was invalid or corrupt.");
            }
        }

        // Save to current database file in memory
        public void Save(bool saveAs = false)
        {
            StreamWriter outputFile;

            // Cancel saving if database is empty
            if (this.Data.Count == 0)
            {
                MessageBox.Show("Save operation cancelled: recipe book empty.");
                return;
            }

            // Save to new file if filepath not picked, or user chose to save to new file
            if (saveAs || this.FilePath == null)
            {
                // Get file path from SaveFileDialog
                if (this.Saver.ShowDialog() != DialogResult.OK)
                {
                    Database.CancelMessage();
                    return;
                }

                this.FilePath = this.Saver.FileName;
            }

            try
            {
                // Open output file for writing
                outputFile = File.CreateText(this.FilePath);

                foreach (Recipe recipe in this.Data)
                {
                    outputFile.WriteLine(recipe.ToCSV());
                }

                outputFile.Close();
            }
            catch (Exception ex)
            {
                Database.Error(ex, $"Could not save to file '{this.FilePath}'.");
            }
        }
    }
}
