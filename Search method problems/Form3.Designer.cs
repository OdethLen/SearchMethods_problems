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
            dgvSearch = new DataGridView();
            txtSearch = new TextBox();
            txtNumbers = new TextBox();
            dgvSorted = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSorted).BeginInit();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Yu Gothic", 9F);
            btnGenerate.Location = new Point(51, 147);
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
            btnBinarySearch.Location = new Point(51, 185);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(112, 23);
            btnBinarySearch.TabIndex = 5;
            btnBinarySearch.Text = "Binary Search ";
            btnBinarySearch.UseVisualStyleBackColor = true;
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // dgvSearch
            // 
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(396, 50);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.Size = new Size(252, 259);
            dgvSearch.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Yu Gothic", 9F);
            txtSearch.Location = new Point(169, 187);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 27);
            txtSearch.TabIndex = 8;
            // 
            // txtNumbers
            // 
            txtNumbers.Font = new Font("Yu Gothic", 9F);
            txtNumbers.Location = new Point(169, 147);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.ReadOnly = true;
            txtNumbers.Size = new Size(163, 27);
            txtNumbers.TabIndex = 7;
            // 
            // dgvSorted
            // 
            dgvSorted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSorted.Location = new Point(680, 50);
            dgvSorted.Name = "dgvSorted";
            dgvSorted.Size = new Size(252, 259);
            dgvSorted.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(680, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 10;
            label1.Text = "Sorting";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 364);
            Controls.Add(label1);
            Controls.Add(dgvSorted);
            Controls.Add(txtSearch);
            Controls.Add(txtNumbers);
            Controls.Add(dgvSearch);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnGenerate);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSorted).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Button btnBinarySearch;
        private DataGridView dgvSearch;
        private TextBox txtSearch;
        private TextBox txtNumbers;
        private DataGridView dgvSorted;
        private Label label1;
    }
}