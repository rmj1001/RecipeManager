namespace connRoy_FinalProject_RecipeManager
{
    partial class StartWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            openBtn = new Button();
            exitBtn = new Button();
            startTooltip = new ToolTip(components);
            newDatabaseBtn = new Button();
            aboutBtn = new Button();
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 51);
            label1.Name = "label1";
            label1.Size = new Size(260, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Recipe Manager!";
            // 
            // openBtn
            // 
            openBtn.BackColor = Color.Khaki;
            openBtn.Location = new Point(180, 150);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(130, 59);
            openBtn.TabIndex = 2;
            openBtn.Text = "&Open Recipe Book";
            startTooltip.SetToolTip(openBtn, "Click here to open a recipe database.");
            openBtn.UseVisualStyleBackColor = false;
            openBtn.Click += openBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Salmon;
            exitBtn.Location = new Point(340, 150);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(130, 59);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "&Exit";
            startTooltip.SetToolTip(exitBtn, "Click here to exit the program.");
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // newDatabaseBtn
            // 
            newDatabaseBtn.BackColor = Color.PaleGreen;
            newDatabaseBtn.Location = new Point(19, 150);
            newDatabaseBtn.Name = "newDatabaseBtn";
            newDatabaseBtn.Size = new Size(130, 59);
            newDatabaseBtn.TabIndex = 4;
            newDatabaseBtn.Text = "&New Recipe Book";
            startTooltip.SetToolTip(newDatabaseBtn, "Click here to create a new recipe database.");
            newDatabaseBtn.UseVisualStyleBackColor = false;
            newDatabaseBtn.Click += newDatabaseBtn_Click;
            // 
            // aboutBtn
            // 
            aboutBtn.BackColor = Color.PowderBlue;
            aboutBtn.Location = new Point(180, 237);
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(130, 59);
            aboutBtn.TabIndex = 5;
            aboutBtn.Text = "&About";
            startTooltip.SetToolTip(aboutBtn, "Click here to open a recipe database.");
            aboutBtn.UseVisualStyleBackColor = false;
            aboutBtn.Click += aboutBtn_Click;
            // 
            // openFile
            // 
            openFile.FileName = "recipes.csv";
            // 
            // StartWindow
            // 
            AcceptButton = newDatabaseBtn;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(488, 347);
            Controls.Add(aboutBtn);
            Controls.Add(newDatabaseBtn);
            Controls.Add(exitBtn);
            Controls.Add(openBtn);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StartWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button openBtn;
        private Button exitBtn;
        private ToolTip startTooltip;
        private Button newDatabaseBtn;
        private Button aboutBtn;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
    }
}
