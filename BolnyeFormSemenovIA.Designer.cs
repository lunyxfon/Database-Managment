namespace Tyuiu.SemenovIA.Task1.V6
{
    partial class BolnyeFormSemenovIA
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
            this.labelBolnyeSemenovIA = new System.Windows.Forms.Label();
            this.textBoxSemenovIA = new System.Windows.Forms.TextBox();
            this.buttonBolnyeSemenovIA = new System.Windows.Forms.Button();
            this.buttonAllSemenovIA = new System.Windows.Forms.Button();
            this.buttonCloseSemenovIA = new System.Windows.Forms.Button();
            this.buttonСloseSemenovIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemenovIA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSemenovIA
            // 
            this.dataGridViewSemenovIA.AllowUserToOrderColumns = true;
            this.dataGridViewSemenovIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSemenovIA.Location = new System.Drawing.Point(33, 32);
            this.dataGridViewSemenovIA.Name = "dataGridViewSemenovIA";
            this.dataGridViewSemenovIA.Size = new System.Drawing.Size(709, 299);
            this.dataGridViewSemenovIA.TabIndex = 0;
            // 
            // labelBolnyeSemenovIA
            // 
            this.labelBolnyeSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBolnyeSemenovIA.Location = new System.Drawing.Point(29, 344);
            this.labelBolnyeSemenovIA.Name = "labelBolnyeSemenovIA";
            this.labelBolnyeSemenovIA.Size = new System.Drawing.Size(167, 32);
            this.labelBolnyeSemenovIA.TabIndex = 1;
            this.labelBolnyeSemenovIA.Text = "Найти больного";
            // 
            // textBoxSemenovIA
            // 
            this.textBoxSemenovIA.Location = new System.Drawing.Point(33, 379);
            this.textBoxSemenovIA.Name = "textBoxSemenovIA";
            this.textBoxSemenovIA.Size = new System.Drawing.Size(130, 20);
            this.textBoxSemenovIA.TabIndex = 2;
            // 
            // buttonBolnyeSemenovIA
            // 
            this.buttonBolnyeSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBolnyeSemenovIA.Location = new System.Drawing.Point(227, 344);
            this.buttonBolnyeSemenovIA.Name = "buttonBolnyeSemenovIA";
            this.buttonBolnyeSemenovIA.Size = new System.Drawing.Size(130, 57);
            this.buttonBolnyeSemenovIA.TabIndex = 3;
            this.buttonBolnyeSemenovIA.Text = "Поиск больного";
            this.buttonBolnyeSemenovIA.UseVisualStyleBackColor = true;
            this.buttonBolnyeSemenovIA.Click += new System.EventHandler(this.buttonBolnyeSemenovIA_Click);
            // 
            // buttonAllSemenovIA
            // 
            this.buttonAllSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllSemenovIA.Location = new System.Drawing.Point(430, 344);
            this.buttonAllSemenovIA.Name = "buttonAllSemenovIA";
            this.buttonAllSemenovIA.Size = new System.Drawing.Size(130, 57);
            this.buttonAllSemenovIA.TabIndex = 4;
            this.buttonAllSemenovIA.Text = "Показать весь список";
            this.buttonAllSemenovIA.UseVisualStyleBackColor = true;
            this.buttonAllSemenovIA.Click += new System.EventHandler(this.buttonAllSemenovIA_Click);
            // 
            // buttonCloseSemenovIA
            // 
            this.buttonCloseSemenovIA.Location = new System.Drawing.Point(0, 0);
            this.buttonCloseSemenovIA.Name = "buttonCloseSemenovIA";
            this.buttonCloseSemenovIA.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseSemenovIA.TabIndex = 0;
            // 
            // buttonСloseSemenovIA
            // 
            this.buttonСloseSemenovIA.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonСloseSemenovIA.Location = new System.Drawing.Point(612, 344);
            this.buttonСloseSemenovIA.Name = "buttonСloseSemenovIA";
            this.buttonСloseSemenovIA.Size = new System.Drawing.Size(130, 57);
            this.buttonСloseSemenovIA.TabIndex = 5;
            this.buttonСloseSemenovIA.Text = "Назад";
            this.buttonСloseSemenovIA.UseVisualStyleBackColor = true;
            this.buttonСloseSemenovIA.Click += new System.EventHandler(this.buttonСloseSemenovIA_Click);
            // 
            // BolnyeFormSemenovIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonСloseSemenovIA);
            this.Controls.Add(this.buttonCloseSemenovIA);
            this.Controls.Add(this.buttonAllSemenovIA);
            this.Controls.Add(this.buttonBolnyeSemenovIA);
            this.Controls.Add(this.textBoxSemenovIA);
            this.Controls.Add(this.labelBolnyeSemenovIA);
            this.Controls.Add(this.dataGridViewSemenovIA);
            this.Name = "BolnyeFormSemenovIA";
            this.Text = "BolnyeFormSemenovIA";
            this.Load += new System.EventHandler(this.BolnyeFormSemenovIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemenovIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSemenovIA;
        private System.Windows.Forms.Label labelBolnyeSemenovIA;
        private System.Windows.Forms.TextBox textBoxSemenovIA;
        private System.Windows.Forms.Button buttonBolnyeSemenovIA;
        private System.Windows.Forms.Button buttonAllSemenovIA;
        private System.Windows.Forms.Button buttonCloseSemenovIA;
        private System.Windows.Forms.Button buttonСloseSemenovIA;
    }
}