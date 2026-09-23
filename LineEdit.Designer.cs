namespace connRoy_FinalProject_RecipeManager
{
    partial class LineEdit
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
            instructionLabel = new Label();
            lineText = new TextBox();
            saveBtn = new Button();
            lineEditorTooltip = new ToolTip(components);
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(214, 43);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(219, 23);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Enter line content below.";
            // 
            // lineText
            // 
            lineText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lineText.Location = new Point(12, 118);
            lineText.Name = "lineText";
            lineText.Size = new Size(577, 30);
            lineText.TabIndex = 1;
            lineEditorTooltip.SetToolTip(lineText, "Enter line contents here.");
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(246, 206);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(108, 42);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            lineEditorTooltip.SetToolTip(saveBtn, "Click here to save the current line.");
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // LineEdit
            // 
            AcceptButton = saveBtn;
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = saveBtn;
            ClientSize = new Size(601, 290);
            Controls.Add(saveBtn);
            Controls.Add(lineText);
            Controls.Add(instructionLabel);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "LineEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Line Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private TextBox lineText;
        private Button saveBtn;
        private ToolTip lineEditorTooltip;
    }
}