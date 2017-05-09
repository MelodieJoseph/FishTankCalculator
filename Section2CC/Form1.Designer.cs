namespace Section2CC
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTankSize = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxFishAllowed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFishAmountRange = new System.Windows.Forms.TextBox();
            this.txtTankSizeRange = new System.Windows.Forms.TextBox();
            this.txtFishType = new System.Windows.Forms.TextBox();
            this.txtFishSize = new System.Windows.Forms.TextBox();
            this.txtTankSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fish and Fish Tank Helper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of Fish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fish Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fish Tank Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tank Size";
            // 
            // lblTankSize
            // 
            this.lblTankSize.AutoSize = true;
            this.lblTankSize.Location = new System.Drawing.Point(155, 305);
            this.lblTankSize.Name = "lblTankSize";
            this.lblTankSize.Size = new System.Drawing.Size(0, 13);
            this.lblTankSize.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(47, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(158, 29);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max Amount of Fish for the tank";
            // 
            // lblMaxFishAllowed
            // 
            this.lblMaxFishAllowed.AutoSize = true;
            this.lblMaxFishAllowed.Location = new System.Drawing.Point(155, 463);
            this.lblMaxFishAllowed.Name = "lblMaxFishAllowed";
            this.lblMaxFishAllowed.Size = new System.Drawing.Size(0, 13);
            this.lblMaxFishAllowed.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tank Sizes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Maximum Fish Intake";
            // 
            // txtFishAmountRange
            // 
            this.txtFishAmountRange.BackColor = System.Drawing.SystemColors.Window;
            this.txtFishAmountRange.Location = new System.Drawing.Point(496, 142);
            this.txtFishAmountRange.Multiline = true;
            this.txtFishAmountRange.Name = "txtFishAmountRange";
            this.txtFishAmountRange.ReadOnly = true;
            this.txtFishAmountRange.Size = new System.Drawing.Size(140, 299);
            this.txtFishAmountRange.TabIndex = 11;
            // 
            // txtTankSizeRange
            // 
            this.txtTankSizeRange.BackColor = System.Drawing.SystemColors.Window;
            this.txtTankSizeRange.Location = new System.Drawing.Point(313, 142);
            this.txtTankSizeRange.Multiline = true;
            this.txtTankSizeRange.Name = "txtTankSizeRange";
            this.txtTankSizeRange.ReadOnly = true;
            this.txtTankSizeRange.Size = new System.Drawing.Size(150, 299);
            this.txtTankSizeRange.TabIndex = 12;
            // 
            // txtFishType
            // 
            this.txtFishType.Location = new System.Drawing.Point(158, 112);
            this.txtFishType.Name = "txtFishType";
            this.txtFishType.Size = new System.Drawing.Size(102, 20);
            this.txtFishType.TabIndex = 13;
            // 
            // txtFishSize
            // 
            this.txtFishSize.Location = new System.Drawing.Point(163, 173);
            this.txtFishSize.Name = "txtFishSize";
            this.txtFishSize.Size = new System.Drawing.Size(96, 20);
            this.txtFishSize.TabIndex = 14;
            // 
            // txtTankSize
            // 
            this.txtTankSize.Location = new System.Drawing.Point(164, 233);
            this.txtTankSize.Name = "txtTankSize";
            this.txtTankSize.Size = new System.Drawing.Size(95, 20);
            this.txtTankSize.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 512);
            this.Controls.Add(this.txtTankSize);
            this.Controls.Add(this.txtFishSize);
            this.Controls.Add(this.txtFishType);
            this.Controls.Add(this.txtTankSizeRange);
            this.Controls.Add(this.txtFishAmountRange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMaxFishAllowed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTankSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Animal City Fish Tank Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTankSize;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxFishAllowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFishAmountRange;
        private System.Windows.Forms.TextBox txtTankSizeRange;
        private System.Windows.Forms.TextBox txtFishType;
        private System.Windows.Forms.TextBox txtFishSize;
        private System.Windows.Forms.TextBox txtTankSize;
    }
}

