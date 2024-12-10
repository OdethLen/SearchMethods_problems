namespace Search_method_problems
{
    partial class Form2
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
            btnLinealSearch = new Button();
            BinarySearch = new Button();
            btnHash = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLinealSearch
            // 
            btnLinealSearch.Font = new Font("Yu Gothic", 9.75F);
            btnLinealSearch.Location = new Point(224, 100);
            btnLinealSearch.Name = "btnLinealSearch";
            btnLinealSearch.Size = new Size(147, 36);
            btnLinealSearch.TabIndex = 0;
            btnLinealSearch.Text = "Lineal Search ";
            btnLinealSearch.UseVisualStyleBackColor = true;
            btnLinealSearch.Click += btnLinealSearch_Click;
            // 
            // BinarySearch
            // 
            BinarySearch.Font = new Font("Yu Gothic", 9.75F);
            BinarySearch.Location = new Point(224, 155);
            BinarySearch.Name = "BinarySearch";
            BinarySearch.Size = new Size(147, 36);
            BinarySearch.TabIndex = 1;
            BinarySearch.Text = "Binary Search ";
            BinarySearch.UseVisualStyleBackColor = true;
            BinarySearch.Click += BinarySearch_Click;
            // 
            // btnHash
            // 
            btnHash.Font = new Font("Yu Gothic", 9.75F);
            btnHash.Location = new Point(224, 209);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(147, 36);
            btnHash.TabIndex = 2;
            btnHash.Text = "Hash function search";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 67);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 3;
            label1.Text = "Search Algorithms  ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 311);
            Controls.Add(label1);
            Controls.Add(btnHash);
            Controls.Add(BinarySearch);
            Controls.Add(btnLinealSearch);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLinealSearch;
        private Button BinarySearch;
        private Button btnHash;
        private Label label1;
    }
}