namespace Tutor_helper
{
    partial class Mainform
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
            this.studentsDataGrid = new System.Windows.Forms.DataGridView();
            this.leftButtom = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGrid
            // 
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Location = new System.Drawing.Point(173, 15);
            this.studentsDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.RowHeadersWidth = 51;
            this.studentsDataGrid.Size = new System.Drawing.Size(735, 314);
            this.studentsDataGrid.TabIndex = 0;
            // 
            // leftButtom
            // 
            this.leftButtom.Location = new System.Drawing.Point(121, 15);
            this.leftButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftButtom.Name = "leftButtom";
            this.leftButtom.Size = new System.Drawing.Size(44, 313);
            this.leftButtom.TabIndex = 1;
            this.leftButtom.Text = "<";
            this.leftButtom.UseVisualStyleBackColor = true;
            this.leftButtom.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(916, 15);
            this.rightButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(44, 313);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageLabel.Location = new System.Drawing.Point(180, 332);
            this.PageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(36, 39);
            this.PageLabel.TabIndex = 3;
            this.PageLabel.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(951, 511);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(808, 337);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButtom);
            this.Controls.Add(this.studentsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mainform";
            this.Text = "Tutor helper";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGrid;
        private System.Windows.Forms.Button leftButtom;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
    }
}

