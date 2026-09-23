namespace connRoy_FinalProject_RecipeManager
{
    partial class BookManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            recipesList = new ListBox();
            recipesListLabel = new Label();
            managerTooltip = new ToolTip(components);
            markdownBtn = new Button();
            removeBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            exitBtn = new Button();
            saveExitBtn = new Button();
            saveDataBtn = new Button();
            recipeMgmtBox = new GroupBox();
            databaseMgmtBox = new GroupBox();
            recipeMgmtBox.SuspendLayout();
            databaseMgmtBox.SuspendLayout();
            SuspendLayout();
            // 
            // recipesList
            // 
            recipesList.FormattingEnabled = true;
            recipesList.Location = new Point(17, 38);
            recipesList.Margin = new Padding(4, 3, 4, 3);
            recipesList.Name = "recipesList";
            recipesList.Size = new Size(370, 422);
            recipesList.TabIndex = 0;
            managerTooltip.SetToolTip(recipesList, "Click on a recipe here to manage it.");
            // 
            // recipesListLabel
            // 
            recipesListLabel.AutoSize = true;
            recipesListLabel.Location = new Point(17, 13);
            recipesListLabel.Margin = new Padding(4, 0, 4, 0);
            recipesListLabel.Name = "recipesListLabel";
            recipesListLabel.Size = new Size(80, 22);
            recipesListLabel.TabIndex = 1;
            recipesListLabel.Text = "Recipes:";
            // 
            // markdownBtn
            // 
            markdownBtn.BackColor = Color.PowderBlue;
            markdownBtn.Location = new Point(15, 194);
            markdownBtn.Name = "markdownBtn";
            markdownBtn.Size = new Size(221, 30);
            markdownBtn.TabIndex = 14;
            markdownBtn.Text = "E&xport to Markdown";
            managerTooltip.SetToolTip(markdownBtn, "Click here to export selected recipe to a Markdown file.");
            markdownBtn.UseVisualStyleBackColor = false;
            markdownBtn.Click += markdownBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Salmon;
            removeBtn.Location = new Point(15, 139);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(221, 30);
            removeBtn.TabIndex = 13;
            removeBtn.Text = "&Remove Recipe";
            managerTooltip.SetToolTip(removeBtn, "Click here to remove selected recipe.");
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Khaki;
            editBtn.Location = new Point(15, 84);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(221, 30);
            editBtn.TabIndex = 12;
            editBtn.Text = "&Edit Recipe";
            managerTooltip.SetToolTip(editBtn, "Click here to edit selected recipe.");
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.PaleGreen;
            addBtn.Location = new Point(15, 29);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(221, 30);
            addBtn.TabIndex = 11;
            addBtn.Text = "&Add Recipe";
            managerTooltip.SetToolTip(addBtn, "Click here to add a new recipe.");
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Salmon;
            exitBtn.Location = new Point(15, 139);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(221, 30);
            exitBtn.TabIndex = 11;
            exitBtn.Text = "&Close";
            managerTooltip.SetToolTip(exitBtn, "Click here to exit the program.");
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // saveExitBtn
            // 
            saveExitBtn.BackColor = Color.Khaki;
            saveExitBtn.Location = new Point(15, 84);
            saveExitBtn.Name = "saveExitBtn";
            saveExitBtn.Size = new Size(221, 30);
            saveExitBtn.TabIndex = 10;
            saveExitBtn.Text = "Sa&ve && Exit";
            managerTooltip.SetToolTip(saveExitBtn, "Click here to save database to disk and exit.");
            saveExitBtn.UseVisualStyleBackColor = false;
            saveExitBtn.Click += saveExitBtn_Click;
            // 
            // saveDataBtn
            // 
            saveDataBtn.BackColor = Color.PaleGreen;
            saveDataBtn.Location = new Point(15, 29);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(221, 30);
            saveDataBtn.TabIndex = 9;
            saveDataBtn.Text = "&Save Recipe Book";
            managerTooltip.SetToolTip(saveDataBtn, "Click here to save recipe database to disk.");
            saveDataBtn.UseVisualStyleBackColor = false;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // recipeMgmtBox
            // 
            recipeMgmtBox.Controls.Add(markdownBtn);
            recipeMgmtBox.Controls.Add(removeBtn);
            recipeMgmtBox.Controls.Add(editBtn);
            recipeMgmtBox.Controls.Add(addBtn);
            recipeMgmtBox.Location = new Point(394, 38);
            recipeMgmtBox.Name = "recipeMgmtBox";
            recipeMgmtBox.Size = new Size(250, 242);
            recipeMgmtBox.TabIndex = 10;
            recipeMgmtBox.TabStop = false;
            recipeMgmtBox.Text = "Recipe Management";
            // 
            // databaseMgmtBox
            // 
            databaseMgmtBox.Controls.Add(exitBtn);
            databaseMgmtBox.Controls.Add(saveExitBtn);
            databaseMgmtBox.Controls.Add(saveDataBtn);
            databaseMgmtBox.Location = new Point(394, 286);
            databaseMgmtBox.Name = "databaseMgmtBox";
            databaseMgmtBox.Size = new Size(250, 196);
            databaseMgmtBox.TabIndex = 11;
            databaseMgmtBox.TabStop = false;
            databaseMgmtBox.Text = "Recipe Book Management";
            // 
            // BookManager
            // 
            AcceptButton = saveExitBtn;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(660, 495);
            Controls.Add(databaseMgmtBox);
            Controls.Add(recipeMgmtBox);
            Controls.Add(recipesListLabel);
            Controls.Add(recipesList);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "BookManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Book";
            Load += BookManager_Load;
            recipeMgmtBox.ResumeLayout(false);
            databaseMgmtBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox recipesList;
        private Label recipesListLabel;
        private ToolTip managerTooltip;
        private GroupBox recipeMgmtBox;
        private Button markdownBtn;
        private Button removeBtn;
        private Button editBtn;
        private Button addBtn;
        private GroupBox databaseMgmtBox;
        private Button exitBtn;
        private Button saveExitBtn;
        private Button saveDataBtn;
    }
}