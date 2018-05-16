namespace _2DArrayAllisonC
{
    partial class frm2DArray
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
            this.lstArray = new System.Windows.Forms.ListBox();
            this.lblLenght = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.nubLenght = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // lstArray
            // 
            this.lstArray.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArray.FormattingEnabled = true;
            this.lstArray.ItemHeight = 21;
            this.lstArray.Location = new System.Drawing.Point(107, 93);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(120, 130);
            this.lstArray.TabIndex = 0;
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenght.Location = new System.Drawing.Point(24, 21);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(142, 21);
            this.lblLenght.TabIndex = 3;
            this.lblLenght.Text = "Lenght (horizontal)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(98, 228);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(184, 51);
            this.nud.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(120, 20);
            this.nud.TabIndex = 5;
            // 
            // nubLenght
            // 
            this.nubLenght.Location = new System.Drawing.Point(184, 25);
            this.nubLenght.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nubLenght.Name = "nubLenght";
            this.nubLenght.Size = new System.Drawing.Size(120, 20);
            this.nubLenght.TabIndex = 6;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(24, 47);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(116, 21);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width (vertical)";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(94, 266);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(109, 21);
            this.lblAverage.TabIndex = 8;
            this.lblAverage.Text = "The average is";
            // 
            // frm2DArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 296);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.nubLenght);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.lstArray);
            this.Name = "frm2DArray";
            this.Text = "2D Arrays by Allison C";
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.NumericUpDown nubLenght;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblAverage;
    }
}

