namespace Kurs
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.delet_button = new System.Windows.Forms.Button();
            this.report_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(44, 401);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(162, 401);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Найти";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(381, 401);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // delet_button
            // 
            this.delet_button.Location = new System.Drawing.Point(602, 401);
            this.delet_button.Name = "delet_button";
            this.delet_button.Size = new System.Drawing.Size(75, 23);
            this.delet_button.TabIndex = 4;
            this.delet_button.Text = "Удалить";
            this.delet_button.UseVisualStyleBackColor = true;
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(696, 401);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(75, 23);
            this.report_button.TabIndex = 5;
            this.report_button.Text = "Отчёт";
            this.report_button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.delet_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button delet_button;
        private System.Windows.Forms.Button report_button;
    }
}