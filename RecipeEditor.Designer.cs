namespace connRoy_FinalProject_RecipeManager
{
    partial class RecipeEditor
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
            basicInfoGrp = new GroupBox();
            minutesLabel3 = new Label();
            minutesLabel2 = new Label();
            minutesLabel1 = new Label();
            totalTimeNumeric = new NumericUpDown();
            cookTimeNumeric = new NumericUpDown();
            prepTimeNumeric = new NumericUpDown();
            totalTimeLabel = new Label();
            cookTimeLabel = new Label();
            prepTimeLabel = new Label();
            nameText = new TextBox();
            nameLabel = new Label();
            ingredientsGrp = new GroupBox();
            ingredientsList = new ListBox();
            instructionsGrp = new GroupBox();
            instructionsList = new ListBox();
            saveBtn = new Button();
            addIngredientBtn = new Button();
            removeIngredientBtn = new Button();
            addInstructionBtn = new Button();
            removeInstructionBtn = new Button();
            editorTooltip = new ToolTip(components);
            editIngredientBtn = new Button();
            editInstructionBtn = new Button();
            exitBtn = new Button();
            saveExitBtn = new Button();
            basicInfoGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalTimeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cookTimeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prepTimeNumeric).BeginInit();
            ingredientsGrp.SuspendLayout();
            instructionsGrp.SuspendLayout();
            SuspendLayout();
            // 
            // basicInfoGrp
            // 
            basicInfoGrp.Controls.Add(minutesLabel3);
            basicInfoGrp.Controls.Add(minutesLabel2);
            basicInfoGrp.Controls.Add(minutesLabel1);
            basicInfoGrp.Controls.Add(totalTimeNumeric);
            basicInfoGrp.Controls.Add(cookTimeNumeric);
            basicInfoGrp.Controls.Add(prepTimeNumeric);
            basicInfoGrp.Controls.Add(totalTimeLabel);
            basicInfoGrp.Controls.Add(cookTimeLabel);
            basicInfoGrp.Controls.Add(prepTimeLabel);
            basicInfoGrp.Controls.Add(nameText);
            basicInfoGrp.Controls.Add(nameLabel);
            basicInfoGrp.Location = new Point(12, 13);
            basicInfoGrp.Name = "basicInfoGrp";
            basicInfoGrp.Size = new Size(362, 240);
            basicInfoGrp.TabIndex = 13;
            basicInfoGrp.TabStop = false;
            basicInfoGrp.Text = "Basic Information";
            // 
            // minutesLabel3
            // 
            minutesLabel3.AutoSize = true;
            minutesLabel3.Location = new Point(274, 189);
            minutesLabel3.Name = "minutesLabel3";
            minutesLabel3.Size = new Size(73, 22);
            minutesLabel3.TabIndex = 23;
            minutesLabel3.Text = "Minutes";
            // 
            // minutesLabel2
            // 
            minutesLabel2.AutoSize = true;
            minutesLabel2.Location = new Point(274, 146);
            minutesLabel2.Name = "minutesLabel2";
            minutesLabel2.Size = new Size(73, 22);
            minutesLabel2.TabIndex = 22;
            minutesLabel2.Text = "Minutes";
            // 
            // minutesLabel1
            // 
            minutesLabel1.AutoSize = true;
            minutesLabel1.Location = new Point(274, 101);
            minutesLabel1.Name = "minutesLabel1";
            minutesLabel1.Size = new Size(73, 22);
            minutesLabel1.TabIndex = 21;
            minutesLabel1.Text = "Minutes";
            // 
            // totalTimeNumeric
            // 
            totalTimeNumeric.Enabled = false;
            totalTimeNumeric.Location = new Point(118, 187);
            totalTimeNumeric.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            totalTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            totalTimeNumeric.Name = "totalTimeNumeric";
            totalTimeNumeric.Size = new Size(150, 30);
            totalTimeNumeric.TabIndex = 20;
            editorTooltip.SetToolTip(totalTimeNumeric, "The total recipe prep time in minutes is here.");
            totalTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cookTimeNumeric
            // 
            cookTimeNumeric.Location = new Point(118, 142);
            cookTimeNumeric.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            cookTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cookTimeNumeric.Name = "cookTimeNumeric";
            cookTimeNumeric.Size = new Size(150, 30);
            cookTimeNumeric.TabIndex = 19;
            editorTooltip.SetToolTip(cookTimeNumeric, "Enter the recipe cook time here in minutes.");
            cookTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            cookTimeNumeric.ValueChanged += cookTimeNumeric_ValueChanged;
            // 
            // prepTimeNumeric
            // 
            prepTimeNumeric.Location = new Point(118, 97);
            prepTimeNumeric.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            prepTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            prepTimeNumeric.Name = "prepTimeNumeric";
            prepTimeNumeric.Size = new Size(150, 30);
            prepTimeNumeric.TabIndex = 18;
            editorTooltip.SetToolTip(prepTimeNumeric, "Enter the recipe prep time here in minutes.");
            prepTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            prepTimeNumeric.ValueChanged += prepTimeNumeric_ValueChanged;
            // 
            // totalTimeLabel
            // 
            totalTimeLabel.AutoSize = true;
            totalTimeLabel.Location = new Point(8, 191);
            totalTimeLabel.Margin = new Padding(4, 0, 4, 0);
            totalTimeLabel.Name = "totalTimeLabel";
            totalTimeLabel.Size = new Size(102, 22);
            totalTimeLabel.TabIndex = 17;
            totalTimeLabel.Text = "Total Time:";
            // 
            // cookTimeLabel
            // 
            cookTimeLabel.AutoSize = true;
            cookTimeLabel.Location = new Point(8, 146);
            cookTimeLabel.Margin = new Padding(4, 0, 4, 0);
            cookTimeLabel.Name = "cookTimeLabel";
            cookTimeLabel.Size = new Size(103, 22);
            cookTimeLabel.TabIndex = 16;
            cookTimeLabel.Text = "Cook Time:";
            // 
            // prepTimeLabel
            // 
            prepTimeLabel.AutoSize = true;
            prepTimeLabel.Location = new Point(13, 101);
            prepTimeLabel.Margin = new Padding(4, 0, 4, 0);
            prepTimeLabel.Name = "prepTimeLabel";
            prepTimeLabel.Size = new Size(98, 22);
            prepTimeLabel.TabIndex = 15;
            prepTimeLabel.Text = "Prep Time:";
            // 
            // nameText
            // 
            nameText.Location = new Point(118, 52);
            nameText.Name = "nameText";
            nameText.Size = new Size(229, 30);
            nameText.TabIndex = 14;
            editorTooltip.SetToolTip(nameText, "Enter the recipe name here.");
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(49, 56);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 22);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // ingredientsGrp
            // 
            ingredientsGrp.Controls.Add(ingredientsList);
            ingredientsGrp.Location = new Point(391, 13);
            ingredientsGrp.Name = "ingredientsGrp";
            ingredientsGrp.Size = new Size(263, 240);
            ingredientsGrp.TabIndex = 14;
            ingredientsGrp.TabStop = false;
            ingredientsGrp.Text = "Ingredients";
            // 
            // ingredientsList
            // 
            ingredientsList.FormattingEnabled = true;
            ingredientsList.Location = new Point(6, 25);
            ingredientsList.Name = "ingredientsList";
            ingredientsList.Size = new Size(251, 202);
            ingredientsList.TabIndex = 0;
            editorTooltip.SetToolTip(ingredientsList, "This is where ingredients are stored.");
            // 
            // instructionsGrp
            // 
            instructionsGrp.Controls.Add(instructionsList);
            instructionsGrp.Location = new Point(660, 13);
            instructionsGrp.Name = "instructionsGrp";
            instructionsGrp.Size = new Size(263, 240);
            instructionsGrp.TabIndex = 15;
            instructionsGrp.TabStop = false;
            instructionsGrp.Text = "Instructions";
            // 
            // instructionsList
            // 
            instructionsList.FormattingEnabled = true;
            instructionsList.Location = new Point(6, 24);
            instructionsList.Name = "instructionsList";
            instructionsList.Size = new Size(251, 202);
            instructionsList.TabIndex = 0;
            editorTooltip.SetToolTip(instructionsList, "This is where instructions are stored.");
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.PowderBlue;
            saveBtn.Location = new Point(12, 259);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(362, 40);
            saveBtn.TabIndex = 16;
            saveBtn.Text = "&Save Recipe";
            editorTooltip.SetToolTip(saveBtn, "Click here to save the recipe to the recipe book.");
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // addIngredientBtn
            // 
            addIngredientBtn.BackColor = Color.PaleGreen;
            addIngredientBtn.Location = new Point(391, 259);
            addIngredientBtn.Name = "addIngredientBtn";
            addIngredientBtn.Size = new Size(257, 40);
            addIngredientBtn.TabIndex = 17;
            addIngredientBtn.Text = "Add Ingredient";
            editorTooltip.SetToolTip(addIngredientBtn, "Click here to add a new ingredient.");
            addIngredientBtn.UseVisualStyleBackColor = false;
            addIngredientBtn.Click += addIngredientBtn_Click;
            // 
            // removeIngredientBtn
            // 
            removeIngredientBtn.BackColor = Color.Salmon;
            removeIngredientBtn.Location = new Point(391, 351);
            removeIngredientBtn.Name = "removeIngredientBtn";
            removeIngredientBtn.Size = new Size(257, 40);
            removeIngredientBtn.TabIndex = 18;
            removeIngredientBtn.Text = "Remove Ingredient";
            editorTooltip.SetToolTip(removeIngredientBtn, "Click here to remove a selected ingredient.");
            removeIngredientBtn.UseVisualStyleBackColor = false;
            removeIngredientBtn.Click += removeIngredientBtn_Click;
            // 
            // addInstructionBtn
            // 
            addInstructionBtn.BackColor = Color.PaleGreen;
            addInstructionBtn.Location = new Point(660, 259);
            addInstructionBtn.Name = "addInstructionBtn";
            addInstructionBtn.Size = new Size(263, 40);
            addInstructionBtn.TabIndex = 19;
            addInstructionBtn.Text = "Add Instruction";
            editorTooltip.SetToolTip(addInstructionBtn, "Click here to add a new instruction.");
            addInstructionBtn.UseVisualStyleBackColor = false;
            addInstructionBtn.Click += addInstructionBtn_Click;
            // 
            // removeInstructionBtn
            // 
            removeInstructionBtn.BackColor = Color.Salmon;
            removeInstructionBtn.Location = new Point(660, 351);
            removeInstructionBtn.Name = "removeInstructionBtn";
            removeInstructionBtn.Size = new Size(263, 40);
            removeInstructionBtn.TabIndex = 20;
            removeInstructionBtn.Text = "Remove Instruction";
            editorTooltip.SetToolTip(removeInstructionBtn, "Click here to remove a selected instruction.");
            removeInstructionBtn.UseVisualStyleBackColor = false;
            removeInstructionBtn.Click += removeInstructionBtn_Click;
            // 
            // editIngredientBtn
            // 
            editIngredientBtn.BackColor = Color.Khaki;
            editIngredientBtn.Location = new Point(391, 305);
            editIngredientBtn.Name = "editIngredientBtn";
            editIngredientBtn.Size = new Size(257, 40);
            editIngredientBtn.TabIndex = 21;
            editIngredientBtn.Text = "Edit Ingredient";
            editorTooltip.SetToolTip(editIngredientBtn, "Click here to edit an existing ingredient.");
            editIngredientBtn.UseVisualStyleBackColor = false;
            editIngredientBtn.Click += editIngredientBtn_Click;
            // 
            // editInstructionBtn
            // 
            editInstructionBtn.BackColor = Color.Khaki;
            editInstructionBtn.ForeColor = SystemColors.ControlText;
            editInstructionBtn.Location = new Point(660, 305);
            editInstructionBtn.Name = "editInstructionBtn";
            editInstructionBtn.Size = new Size(263, 40);
            editInstructionBtn.TabIndex = 22;
            editInstructionBtn.Text = "Edit Instruction";
            editorTooltip.SetToolTip(editInstructionBtn, "Click here to edit an existing instruction.");
            editInstructionBtn.UseVisualStyleBackColor = false;
            editInstructionBtn.Click += editInstructionBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Salmon;
            exitBtn.Location = new Point(12, 351);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(362, 40);
            exitBtn.TabIndex = 23;
            exitBtn.Text = "&Exit without Saving";
            editorTooltip.SetToolTip(exitBtn, "Click here to exit this window.");
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // saveExitBtn
            // 
            saveExitBtn.BackColor = Color.Khaki;
            saveExitBtn.ForeColor = SystemColors.ControlText;
            saveExitBtn.Location = new Point(12, 305);
            saveExitBtn.Name = "saveExitBtn";
            saveExitBtn.Size = new Size(362, 40);
            saveExitBtn.TabIndex = 24;
            saveExitBtn.Text = "S&ave && Exit";
            editorTooltip.SetToolTip(saveExitBtn, "Click here to save the recipe to the recipe book, then close the window.");
            saveExitBtn.UseVisualStyleBackColor = false;
            saveExitBtn.Click += saveExitBtn_Click;
            // 
            // RecipeEditor
            // 
            AcceptButton = saveExitBtn;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(935, 410);
            Controls.Add(saveExitBtn);
            Controls.Add(exitBtn);
            Controls.Add(editInstructionBtn);
            Controls.Add(editIngredientBtn);
            Controls.Add(removeInstructionBtn);
            Controls.Add(addInstructionBtn);
            Controls.Add(removeIngredientBtn);
            Controls.Add(addIngredientBtn);
            Controls.Add(saveBtn);
            Controls.Add(instructionsGrp);
            Controls.Add(ingredientsGrp);
            Controls.Add(basicInfoGrp);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RecipeEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Editor";
            Load += RecipeEditor_Load;
            basicInfoGrp.ResumeLayout(false);
            basicInfoGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalTimeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)cookTimeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)prepTimeNumeric).EndInit();
            ingredientsGrp.ResumeLayout(false);
            instructionsGrp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox basicInfoGrp;
        private Label minutesLabel3;
        private Label minutesLabel2;
        private Label minutesLabel1;
        private NumericUpDown totalTimeNumeric;
        private NumericUpDown cookTimeNumeric;
        private NumericUpDown prepTimeNumeric;
        private Label totalTimeLabel;
        private Label cookTimeLabel;
        private Label prepTimeLabel;
        private TextBox nameText;
        private Label nameLabel;
        private GroupBox ingredientsGrp;
        private ListBox ingredientsList;
        private GroupBox instructionsGrp;
        private ListBox instructionsList;
        private Button saveBtn;
        private Button addIngredientBtn;
        private Button removeIngredientBtn;
        private Button addInstructionBtn;
        private Button removeInstructionBtn;
        private ToolTip editorTooltip;
        private TextBox prepTimeBox;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button editIngredientBtn;
        private Button editInstructionBtn;
        private Button exitBtn;
        private Button saveExitBtn;
    }
}