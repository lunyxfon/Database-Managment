namespace Tyuiu.SemenovIA.Task1.V6
{
    partial class EditFormSemenovIA
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
            this.dataGridViewSemenovIA = new System.Windows.Forms.DataGridView();
            this.buttonOpenSemenovIA = new System.Windows.Forms.Button();
            this.buttonSaveSemenovIA = new System.Windows.Forms.Button();
            this.buttonCloseSemenovIA = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemenovIA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSemenovIA
            // 
            this.dataGridViewSemenovIA.AllowUserToOrderColumns = true;
            this.dataGridViewSemenovIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSemenovIA.Location = new System.Drawing.Point(46, 42);
            this.dataGridViewSemenovIA.Name = "dataGridViewSemenovIA";
            this.dataGridViewSemenovIA.Size = new System.Drawing.Size(682, 296);
            this.dataGridViewSemenovIA.TabIndex = 0;
            // 
            // buttonOpenSemenovIA
            // 
            this.buttonOpenSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenSemenovIA.Location = new System.Drawing.Point(46, 344);
            this.buttonOpenSemenovIA.Name = "buttonOpenSemenovIA";
            this.buttonOpenSemenovIA.Size = new System.Drawing.Size(145, 68);
            this.buttonOpenSemenovIA.TabIndex = 1;
            this.buttonOpenSemenovIA.Text = "Открыть";
            this.buttonOpenSemenovIA.UseVisualStyleBackColor = true;
            this.buttonOpenSemenovIA.Click += new System.EventHandler(this.buttonOpenSemenovIA_Click);
            // 
            // buttonSaveSemenovIA
            // 
            this.buttonSaveSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSemenovIA.Location = new System.Drawing.Point(315, 344);
            this.buttonSaveSemenovIA.Name = "buttonSaveSemenovIA";
            this.buttonSaveSemenovIA.Size = new System.Drawing.Size(145, 68);
            this.buttonSaveSemenovIA.TabIndex = 2;
            this.buttonSaveSemenovIA.Text = "Сохранить";
            this.buttonSaveSemenovIA.UseVisualStyleBackColor = true;
            this.buttonSaveSemenovIA.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCloseSemenovIA
            // 
            this.buttonCloseSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseSemenovIA.Location = new System.Drawing.Point(583, 344);
            this.buttonCloseSemenovIA.Name = "buttonCloseSemenovIA";
            this.buttonCloseSemenovIA.Size = new System.Drawing.Size(145, 68);
            this.buttonCloseSemenovIA.TabIndex = 3;
            this.buttonCloseSemenovIA.Text = "Назад";
            this.buttonCloseSemenovIA.UseVisualStyleBackColor = true;
            this.buttonCloseSemenovIA.Click += new System.EventHandler(this.buttonCloseSemenovIA_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditFormSemenovIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseSemenovIA);
            this.Controls.Add(this.buttonSaveSemenovIA);
            this.Controls.Add(this.buttonOpenSemenovIA);
            this.Controls.Add(this.dataGridViewSemenovIA);
            this.Name = "EditFormSemenovIA";
            this.Text = "EditFormSemenovIA";
            this.Load += new System.EventHandler(this.EditFormSemenovIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemenovIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSemenovIA;
        private System.Windows.Forms.Button buttonOpenSemenovIA;
        private System.Windows.Forms.Button buttonSaveSemenovIA;
        private System.Windows.Forms.Button buttonCloseSemenovIA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}