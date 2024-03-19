namespace Tyuiu.SemenovIA.Task1.V6
{
    partial class VrachiFormSemenovIA
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonPoiskSemenovIA = new System.Windows.Forms.Button();
            this.buttonCloseSemenovIA = new System.Windows.Forms.Button();
            this.labelTextSemenovIA = new System.Windows.Forms.Label();
            this.textBoxSemenovIA = new System.Windows.Forms.TextBox();
            this.buttonAllSemenovIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemenovIA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSemenovIA
            // 
            this.dataGridViewSemenovIA.AllowUserToOrderColumns = true;
            this.dataGridViewSemenovIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSemenovIA.Location = new System.Drawing.Point(32, 51);
            this.dataGridViewSemenovIA.Name = "dataGridViewSemenovIA";
            this.dataGridViewSemenovIA.Size = new System.Drawing.Size(727, 288);
            this.dataGridViewSemenovIA.TabIndex = 0;
            this.dataGridViewSemenovIA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSemenovIA_CellContentClick);
            // 
            // buttonPoiskSemenovIA
            // 
            this.buttonPoiskSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoiskSemenovIA.Location = new System.Drawing.Point(162, 358);
            this.buttonPoiskSemenovIA.Name = "buttonPoiskSemenovIA";
            this.buttonPoiskSemenovIA.Size = new System.Drawing.Size(171, 63);
            this.buttonPoiskSemenovIA.TabIndex = 1;
            this.buttonPoiskSemenovIA.Text = "Поиск";
            this.buttonPoiskSemenovIA.UseVisualStyleBackColor = true;
            this.buttonPoiskSemenovIA.Click += new System.EventHandler(this.buttonPoiskSemenovIA_Click);
            // 
            // buttonCloseSemenovIA
            // 
            this.buttonCloseSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseSemenovIA.Location = new System.Drawing.Point(573, 358);
            this.buttonCloseSemenovIA.Name = "buttonCloseSemenovIA";
            this.buttonCloseSemenovIA.Size = new System.Drawing.Size(186, 63);
            this.buttonCloseSemenovIA.TabIndex = 2;
            this.buttonCloseSemenovIA.Text = "Назад";
            this.buttonCloseSemenovIA.UseVisualStyleBackColor = true;
            this.buttonCloseSemenovIA.Click += new System.EventHandler(this.buttonCloseSemenovIA_Click);
            // 
            // labelTextSemenovIA
            // 
            this.labelTextSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSemenovIA.Location = new System.Drawing.Point(12, 358);
            this.labelTextSemenovIA.Name = "labelTextSemenovIA";
            this.labelTextSemenovIA.Size = new System.Drawing.Size(144, 30);
            this.labelTextSemenovIA.TabIndex = 3;
            this.labelTextSemenovIA.Text = "Найти врача";
            this.labelTextSemenovIA.Click += new System.EventHandler(this.labelTextSemenovIA_Click);
            // 
            // textBoxSemenovIA
            // 
            this.textBoxSemenovIA.Location = new System.Drawing.Point(12, 401);
            this.textBoxSemenovIA.Name = "textBoxSemenovIA";
            this.textBoxSemenovIA.Size = new System.Drawing.Size(144, 20);
            this.textBoxSemenovIA.TabIndex = 4;
            // 
            // buttonAllSemenovIA
            // 
            this.buttonAllSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllSemenovIA.Location = new System.Drawing.Point(365, 358);
            this.buttonAllSemenovIA.Name = "buttonAllSemenovIA";
            this.buttonAllSemenovIA.Size = new System.Drawing.Size(186, 63);
            this.buttonAllSemenovIA.TabIndex = 5;
            this.buttonAllSemenovIA.Text = "Показать весь список";
            this.buttonAllSemenovIA.UseVisualStyleBackColor = true;
            this.buttonAllSemenovIA.Click += new System.EventHandler(this.buttonAllSemenovIA_Click);
            // 
            // VrachiFormSemenovIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAllSemenovIA);
            this.Controls.Add(this.textBoxSemenovIA);
            this.Controls.Add(this.labelTextSemenovIA);
            this.Controls.Add(this.buttonCloseSemenovIA);
            this.Controls.Add(this.buttonPoiskSemenovIA);
            this.Controls.Add(this.dataGridViewSemenovIA);
            this.Name = "VrachiFormSemenovIA";
            this.Text = "VrachiFormSemenovIA";
            this.Load += new System.EventHandler(this.VrachiFormSemenovIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemenovIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSemenovIA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonPoiskSemenovIA;
        private System.Windows.Forms.Button buttonCloseSemenovIA;
        private System.Windows.Forms.Label labelTextSemenovIA;
        private System.Windows.Forms.TextBox textBoxSemenovIA;
        private System.Windows.Forms.Button buttonAllSemenovIA;
    }
}