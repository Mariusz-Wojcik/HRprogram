namespace HRprogram
{
    partial class Main
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btFire = new System.Windows.Forms.Button();
            this.btDelate = new System.Windows.Forms.Button();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btAdd.Location = new System.Drawing.Point(12, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Dodaj";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Yellow;
            this.btEdit.Location = new System.Drawing.Point(93, 12);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Edytuj";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btFire
            // 
            this.btFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btFire.Location = new System.Drawing.Point(174, 12);
            this.btFire.Name = "btFire";
            this.btFire.Size = new System.Drawing.Size(75, 23);
            this.btFire.TabIndex = 2;
            this.btFire.Text = "Zwolnij";
            this.btFire.UseVisualStyleBackColor = false;
            this.btFire.Click += new System.EventHandler(this.btFire_Click);
            // 
            // btDelate
            // 
            this.btDelate.BackColor = System.Drawing.Color.Red;
            this.btDelate.Location = new System.Drawing.Point(255, 12);
            this.btDelate.Name = "btDelate";
            this.btDelate.Size = new System.Drawing.Size(75, 23);
            this.btDelate.TabIndex = 3;
            this.btDelate.Text = "Usuń";
            this.btDelate.UseVisualStyleBackColor = false;
            this.btDelate.Click += new System.EventHandler(this.btDelate_Click);
            // 
            // cbbFilter
            // 
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Location = new System.Drawing.Point(336, 12);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbbFilter.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 5;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRefresh.Location = new System.Drawing.Point(463, 12);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "Odświerz";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbFilter);
            this.Controls.Add(this.btDelate);
            this.Controls.Add(this.btFire);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Name = "Main";
            this.Text = "Kadry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btFire;
        private System.Windows.Forms.Button btDelate;
        private System.Windows.Forms.ComboBox cbbFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btRefresh;
    }
}

