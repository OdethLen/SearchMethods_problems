namespace Search_method_problems
{
    partial class Form3
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
            btnGenerate = new Button();
            btnBinarySearch = new Button();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Yu Gothic", 9F);
            btnGenerate.Location = new Point(96, 147);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 23);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate ";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Font = new Font("Yu Gothic", 9F);
            btnBinarySearch.Location = new Point(96, 185);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(112, 23);
            btnBinarySearch.TabIndex = 5;
            btnBinarySearch.Text = "Binary Search ";
            btnBinarySearch.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 364);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnGenerate);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerate;
        private Button btnBinarySearch;
    }
}