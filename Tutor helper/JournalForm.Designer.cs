namespace Tutor_helper
{
    partial class JournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.studentsDataGrid = new System.Windows.Forms.DataGridView();
            this.leftButtom = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGrid
            // 
            this.studentsDataGrid.AllowUserToAddRows = false;
            this.studentsDataGrid.AllowUserToDeleteRows = false;
            this.studentsDataGrid.AllowUserToResizeColumns = false;
            this.studentsDataGrid.AllowUserToResizeRows = false;
            this.studentsDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Location = new System.Drawing.Point(49, 58);
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.ReadOnly = true;
            this.studentsDataGrid.RowHeadersWidth = 51;
            this.studentsDataGrid.Size = new System.Drawing.Size(396, 155);
            this.studentsDataGrid.TabIndex = 0;
            this.studentsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGrid_CellClick_1);
            // 
            // leftButtom
            // 
            this.leftButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.leftButtom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftButtom.Location = new System.Drawing.Point(10, 58);
            this.leftButtom.Name = "leftButtom";
            this.leftButtom.Size = new System.Drawing.Size(33, 155);
            this.leftButtom.TabIndex = 1;
            this.leftButtom.Text = "<";
            this.leftButtom.UseVisualStyleBackColor = false;
            this.leftButtom.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rightButton.Location = new System.Drawing.Point(451, 59);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(33, 154);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageLabel.Location = new System.Drawing.Point(43, 216);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(31, 31);
            this.PageLabel.TabIndex = 3;
            this.PageLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Journal";
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Tutor_helper.Properties.Resources.exit20;
            this.exitButton.Location = new System.Drawing.Point(450, 254);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(444, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 306);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButtom);
            this.Controls.Add(this.studentsDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalForm";
            this.Text = "Journal";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

