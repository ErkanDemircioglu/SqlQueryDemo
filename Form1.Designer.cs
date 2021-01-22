namespace SqlQuery
{
    partial class SqlSorgu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwResults = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTakeList = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txbQuery = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResults)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgwResults);
            this.groupBox1.Location = new System.Drawing.Point(15, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 279);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // dgwResults
            // 
            this.dgwResults.AllowUserToAddRows = false;
            this.dgwResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwResults.Location = new System.Drawing.Point(3, 16);
            this.dgwResults.Name = "dgwResults";
            this.dgwResults.Size = new System.Drawing.Size(654, 260);
            this.dgwResults.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnTakeList);
            this.groupBox2.Controls.Add(this.btnExecute);
            this.groupBox2.Controls.Add(this.txbQuery);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 148);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // btnTakeList
            // 
            this.btnTakeList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTakeList.Location = new System.Drawing.Point(346, 105);
            this.btnTakeList.Name = "btnTakeList";
            this.btnTakeList.Size = new System.Drawing.Size(188, 26);
            this.btnTakeList.TabIndex = 4;
            this.btnTakeList.Text = "Rapor";
            this.btnTakeList.UseVisualStyleBackColor = true;
            this.btnTakeList.Click += new System.EventHandler(this.btnTakeList_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExecute.Location = new System.Drawing.Point(126, 105);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(188, 26);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute SQL Query";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txbQuery
            // 
            this.txbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuery.Location = new System.Drawing.Point(6, 24);
            this.txbQuery.Multiline = true;
            this.txbQuery.Name = "txbQuery";
            this.txbQuery.Size = new System.Drawing.Size(645, 75);
            this.txbQuery.TabIndex = 2;
            // 
            // SqlSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SqlSorgu";
            this.Text = "Sql Query";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResults)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTakeList;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txbQuery;
    }
}

