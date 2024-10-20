namespace Kurs
{
    partial class AddDepartamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartamentForm));
            this.nameDepartamentTextBox = new System.Windows.Forms.TextBox();
            this.addDepartamentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameDepartamentTextBox
            // 
            this.nameDepartamentTextBox.Location = new System.Drawing.Point(12, 47);
            this.nameDepartamentTextBox.Name = "nameDepartamentTextBox";
            this.nameDepartamentTextBox.Size = new System.Drawing.Size(214, 20);
            this.nameDepartamentTextBox.TabIndex = 0;
            // 
            // addDepartamentButton
            // 
            this.addDepartamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDepartamentButton.Location = new System.Drawing.Point(80, 83);
            this.addDepartamentButton.Name = "addDepartamentButton";
            this.addDepartamentButton.Size = new System.Drawing.Size(75, 23);
            this.addDepartamentButton.TabIndex = 1;
            this.addDepartamentButton.Text = "Добавить";
            this.addDepartamentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название кафедры";
            // 
            // AddDepartamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(238, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDepartamentButton);
            this.Controls.Add(this.nameDepartamentTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(254, 157);
            this.MinimumSize = new System.Drawing.Size(254, 157);
            this.Name = "AddDepartamentForm";
            this.Text = "Добавить кафедру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameDepartamentTextBox;
        private System.Windows.Forms.Button addDepartamentButton;
        private System.Windows.Forms.Label label1;
    }
}