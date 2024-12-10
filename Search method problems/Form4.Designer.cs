namespace Search_method_problems
{
    partial class Form4
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
            btnHash = new Button();
            btnGenerate = new Button();
            txtNumbers = new TextBox();
            txtSearch = new TextBox();
            dgvSearch = new DataGridView();
            dgvHash = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHash).BeginInit();
            SuspendLayout();
            // 
            // btnHash
            // 
            btnHash.Font = new Font("Yu Gothic", 9F);
            btnHash.Location = new Point(74, 193);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(112, 23);
            btnHash.TabIndex = 7;
            btnHash.Text = "Hash ";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Yu Gothic", 9F);
            btnGenerate.Location = new Point(74, 155);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate ";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.Font = new Font("Yu Gothic", 9F);
            txtNumbers.Location = new Point(204, 151);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.ReadOnly = true;
            txtNumbers.Size = new Size(163, 27);
            txtNumbers.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Yu Gothic", 9F);
            txtSearch.Location = new Point(204, 193);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 27);
            txtSearch.TabIndex = 9;
            // 
            // dgvSearch
            // 
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(422, 71);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.Size = new Size(307, 201);
            dgvSearch.TabIndex = 10;
            // 
            // dgvHash
            // 
            dgvHash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHash.Location = new Point(761, 71);
            dgvHash.Name = "dgvHash";
            dgvHash.Size = new Size(238, 201);
            dgvHash.TabIndex = 11;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 450);
            Controls.Add(dgvHash);
            Controls.Add(dgvSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtNumbers);
            Controls.Add(btnHash);
            Controls.Add(btnGenerate);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHash;
        private Button btnGenerate;
        private TextBox txtNumbers;
        private TextBox txtSearch;
        private DataGridView dgvSearch;
        private DataGridView dgvHash;
    }
}