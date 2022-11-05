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
            this.studentsDataGrid.AllowUserToAddRows = false;
            this.studentsDataGrid.AllowUserToDeleteRows = false;
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Location = new System.Drawing.Point(130, 12);
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.ReadOnly = true;
            this.studentsDataGrid.RowHeadersWidth = 51;
            this.studentsDataGrid.Size = new System.Drawing.Size(658, 255);
            this.studentsDataGrid.TabIndex = 0;
            this.studentsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGrid_CellClick_1);
            // 
            // leftButtom
            // 
            this.leftButtom.Location = new System.Drawing.Point(91, 12);
            this.leftButtom.Name = "leftButtom";
            this.leftButtom.Size = new System.Drawing.Size(33, 254);
            this.leftButtom.TabIndex = 1;
            this.leftButtom.Text = "<";
            this.leftButtom.UseVisualStyleBackColor = true;
            this.leftButtom.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(797, 13);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(33, 254);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageLabel.Location = new System.Drawing.Point(135, 270);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(29, 31);
            this.PageLabel.TabIndex = 3;
            this.PageLabel.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(606, 274);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 549);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButtom);
            this.Controls.Add(this.studentsDataGrid);
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

