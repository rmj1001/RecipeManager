using System;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace connRoy_FinalProject_RecipeManager
{
    /* CSV Format for Recipe
     * 
     * Full format: name|prepTime|cookTime|ingredientsList|instructionsList
     * List format: token~token~token
     */

    internal class Recipe
    {
        // CSV delimiters
        public static char outerDelimiter = '|';
        public static char innerDelimiter = '~';

        // Recipe properties
        public string? Name { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public List<string> Ingredients { get; init; }
        public List<string> Instructions { get; init; }
        
        public Recipe()
        {
            Name = null;
            PrepTime = 1;
            CookTime = 1;
            Ingredients = new List<string>();
            Instructions = new List<string>();
        }

        // Construct recipe w/ name, prep time, and cook time (optionally with ingredients and instructions lists for recipe copying)
        public Recipe(string name, int prepTime, int cookTime, List<string>? ingredients = null, List<string>? instructions = null)
        {
            // Recipe name, prep time, and cook time
            Name = name;
            PrepTime = prepTime;
            CookTime = cookTime;

            // Set ingredients list
            if (ingredients == null)
            {
                this.Ingredients = new List<string>();
            }
            else
            {
                this.Ingredients = ingredients;
            }

            // Set instructions list
            if (instructions == null)
            {
                this.Instructions = new List<string>();
            }
            else
            {
                this.Instructions = instructions;
            }
        }

        // Construct recipe from csv string
        public Recipe(string csvString)
        {
            // Split line into strings containing recipe parts
            string[] recipeTokens = csvString.Split(outerDelimiter);

            if (recipeTokens.Length < 5)
            {
                throw new Exception("Invalid recipe data");
            }

            // Name recipe part strings for processing
            string name = recipeTokens[0];
            string prepTimeStr = recipeTokens[1];
            string cookTimeStr = recipeTokens[2];
            string ingredientsCSV = recipeTokens[3];
            string instructionsCSV = recipeTokens[4];

            // Get prep and cook time from strings
            int prepTime = 0;
            int cookTime = 0;

            if (!int.TryParse(prepTimeStr, out prepTime))
            {
                throw new Exception("Prep time is not a number.");
            }

            if (!int.TryParse(cookTimeStr, out cookTime))
            {
                throw new Exception("Cook time is not a number.");
            }

            // Validate time data
            if (prepTime <= 0 || cookTime <= 0)
            {
                throw new Exception("Prep and cook time should be 1 minute or longer each.");
            }

            // Create recipe object
            this.Name = name;
            this.CookTime = cookTime;
            this.PrepTime = prepTime;
            this.Ingredients = new List<string>();
            this.Instructions = new List<string>();

            // Split ingredients and instructions into separate tokens
            string[] ingredientTokens = ingredientsCSV.Split(innerDelimiter);
            string[] instructionTokens = instructionsCSV.Split(innerDelimiter);

            // Throw error if there aren't ingredients or instructions
            if (ingredientTokens.Length == 0 || instructionTokens.Length == 0)
            {
                throw new Exception("There should be at least 1 ingredient and at least 1 instruction.");
            }

            // Add each ingredient to recipe ingredients list
            foreach (string ingredient in ingredientTokens)
            {
                this.Ingredients.Add(ingredient);
            }

            // Add each instruction to recipe instructions list
            foreach (string instruction in instructionTokens)
            {
                this.Instructions.Add(instruction);
            }
        }

        // Detect if text contains delimiters
        public static bool ContainsDelimiter(string s)
        {
            return s.Contains(Recipe.outerDelimiter) || s.Contains(Recipe.innerDelimiter);
        }

        // Show error if text contains delimiters
        public static void DelimiterError()
        {
            MessageBox.Show($"You cannot use {Recipe.outerDelimiter} or {Recipe.innerDelimiter} characters.");
            return;
        }

        // Detects empty strings
        public static bool StringIsEmpty(string s)
        {
            return s == "" || s == null || s.Length == 0;
        }

        public int TotalTime()
        {
            // Use this to get total cooking time instead of manual entry
            return this.PrepTime + this.CookTime;
        }

        public string ToMarkDown()
        {
            StringBuilder sb = new StringBuilder();

            // Recipe name as H1
            sb.AppendLine($"# {this.Name}");
            sb.AppendLine();

            // Cooking times all under H1
            sb.AppendLine($"Prep Time: {this.PrepTime}");
            sb.AppendLine($"Cook Time: {this.CookTime}");
            sb.AppendLine($"Total: {this.TotalTime()}");
            sb.AppendLine();

            // Ingredients section - bulleted list under H2 heading
            sb.AppendLine("## Ingredients");
            sb.AppendLine();

            foreach (string ingredient in this.Ingredients)
            {
                sb.AppendLine($"- {ingredient}");
            }

            // Instructions section - numbered list under H2 heading
            sb.AppendLine();
            sb.AppendLine("## Instructions");
            sb.AppendLine();

            for (int instruction = 0; instruction < this.Instructions.Count; instruction++)
            {
                sb.AppendLine($"{instruction + 1}. {this.Instructions[instruction]}");
            }

            // End of markdown file should have a newline
            sb.AppendLine();

            // Return markdown string
            return sb.ToString();
        }

        public void SaveToMarkDownFile(SaveFileDialog saver)
        {
            // Show error if user does not select a file to save to
            if (saver.ShowDialog() != DialogResult.OK)
            {
                Database.CancelMessage();
                return;
            }

            // Convert this recipe to markdown
            string text = this.ToMarkDown();

            // Save markdown to file
            File.WriteAllText(saver.FileName, text);
            
            return;
        }

        public string ToCSV()
        {
            // CSV string builder
            StringBuilder sb = new StringBuilder();

            // Append name, prep time, and cooking data
            sb.Append($"{Name}{outerDelimiter}");
            sb.Append($"{PrepTime}{outerDelimiter}");
            sb.Append($"{CookTime}{outerDelimiter}");

            // Ingredients use special delimiter (ame as Instructions)
            for (int index = 0; index < this.Ingredients.Count; index++)
            {
                sb.Append(this.Ingredients[index]);

                int lastIndex = this.Ingredients.Count - 1;

                if (index != lastIndex)
                {
                    sb.Append(innerDelimiter);
                }
                else
                {
                    sb.Append(outerDelimiter);
                }
            }

            // Instructions use special delimiter (ame as Ingredients)
            for (int index = 0; index < this.Instructions.Count; index++)
            {
                sb.Append(this.Instructions[index]);

                int lastIndex = this.Instructions.Count - 1;

                if (index != lastIndex)
                {
                    sb.Append(innerDelimiter);
                }
                
                // Do not append outer delimiter after end of instructions
            }

            return sb.ToString();
        }
    }
}
