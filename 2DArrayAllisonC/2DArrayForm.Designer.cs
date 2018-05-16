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
            this.lblLenght = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            this.SuspendLayout();
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
            this.btnCalculate.Location = new System.Drawing.Point(125, 77);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 32);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Create";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(184, 51);
            this.nudWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 5;
            // 
            // nudLenght
            // 
            this.nudLenght.Location = new System.Drawing.Point(184, 25);
            this.nudLenght.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(120, 20);
            this.nudLenght.TabIndex = 6;
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
            // txtArray
            // 
            this.txtArray.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArray.Location = new System.Drawing.Point(72, 115);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.ReadOnly = true;
            this.txtArray.Size = new System.Drawing.Size(196, 169);
            this.txtArray.TabIndex = 8;
            // 
            // frm2DArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 296);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.nudLenght);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLenght);
            this.Name = "frm2DArray";
            this.Text = "2D Arrays by Allison C";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudLenght;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtArray;
    }
}

