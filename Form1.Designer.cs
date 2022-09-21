
namespace BMI_calc_Csharp_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radKg = new System.Windows.Forms.RadioButton();
            this.radLb = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btsReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(171, 60);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(165, 22);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(171, 141);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(165, 22);
            this.txtHeight.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtResult.Location = new System.Drawing.Point(86, 295);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(255, 83);
            this.txtResult.TabIndex = 5;
            // 
            // radKg
            // 
            this.radKg.AutoSize = true;
            this.radKg.Location = new System.Drawing.Point(90, 216);
            this.radKg.Name = "radKg";
            this.radKg.Size = new System.Drawing.Size(84, 21);
            this.radKg.TabIndex = 6;
            this.radKg.TabStop = true;
            this.radKg.Text = "Kilogram";
            this.radKg.UseVisualStyleBackColor = true;
            // 
            // radLb
            // 
            this.radLb.AutoSize = true;
            this.radLb.Location = new System.Drawing.Point(271, 216);
            this.radLb.Name = "radLb";
            this.radLb.Size = new System.Drawing.Size(70, 21);
            this.radLb.TabIndex = 7;
            this.radLb.TabStop = true;
            this.radLb.Text = "Pound";
            this.radLb.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(86, 395);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(250, 40);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btsReset
            // 
            this.btsReset.Location = new System.Drawing.Point(86, 458);
            this.btsReset.Name = "btsReset";
            this.btsReset.Size = new System.Drawing.Size(111, 38);
            this.btsReset.TabIndex = 9;
            this.btsReset.Text = "Reset";
            this.btsReset.UseVisualStyleBackColor = true;
            this.btsReset.Click += new System.EventHandler(this.btsReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(221, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 524);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btsReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radLb);
            this.Controls.Add(this.radKg);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton radKg;
        private System.Windows.Forms.RadioButton radLb;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btsReset;
        private System.Windows.Forms.Button btnExit;
    }
}

