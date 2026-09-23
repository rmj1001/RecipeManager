namespace connRoy_FinalProject_RecipeManager
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            iconBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            exitBtn = new Button();
            aboutTooltip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)iconBox).BeginInit();
            SuspendLayout();
            // 
            // iconBox
            // 
            iconBox.Image = (Image)resources.GetObject("iconBox.Image");
            iconBox.Location = new Point(18, 25);
            iconBox.Margin = new Padding(4, 3, 4, 3);
            iconBox.Name = "iconBox";
            iconBox.Size = new Size(302, 195);
            iconBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBox.TabIndex = 0;
            iconBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 239);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 1;
            label1.Text = "Recipe Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(109, 281);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 2;
            label2.Text = "By: Roy Conn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(100, 322);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 22);
            label3.TabIndex = 3;
            label3.Text = "Copyright: 2026";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Salmon;
            exitBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(101, 363);
            exitBtn.Margin = new Padding(4, 3, 4, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(136, 41);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "&Exit";
            aboutTooltip.SetToolTip(exitBtn, "Click here to exit the about window.");
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // About
            // 
            AcceptButton = exitBtn;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(339, 428);
            Controls.Add(exitBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iconBox);
            Font = new Font("Times New Roman", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)iconBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button exitBtn;
        private ToolTip aboutTooltip;
    }
}