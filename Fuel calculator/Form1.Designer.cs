namespace Fuel_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kmtrav = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.litused = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kmwant = new System.Windows.Forms.TextBox();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.litperkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.litneed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kmtrav
            // 
            this.kmtrav.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kmtrav.Location = new System.Drawing.Point(406, 33);
            this.kmtrav.Name = "kmtrav";
            this.kmtrav.Size = new System.Drawing.Size(167, 32);
            this.kmtrav.TabIndex = 0;
            this.kmtrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kmtrav_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kilometers traveled";
            // 
            // litused
            // 
            this.litused.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.litused.Location = new System.Drawing.Point(406, 90);
            this.litused.Name = "litused";
            this.litused.Size = new System.Drawing.Size(167, 32);
            this.litused.TabIndex = 2;
            this.litused.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.litused_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liters used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(172, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kilometers wanted";
            // 
            // kmwant
            // 
            this.kmwant.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kmwant.Location = new System.Drawing.Point(406, 167);
            this.kmwant.Name = "kmwant";
            this.kmwant.Size = new System.Drawing.Size(167, 32);
            this.kmwant.TabIndex = 5;
            this.kmwant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kmwant_KeyPress);
            // 
            // calculatebtn
            // 
            this.calculatebtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculatebtn.Location = new System.Drawing.Point(278, 229);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(220, 79);
            this.calculatebtn.TabIndex = 6;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(287, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometer per liter";
            // 
            // litperkm
            // 
            this.litperkm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.litperkm.Location = new System.Drawing.Point(334, 371);
            this.litperkm.Name = "litperkm";
            this.litperkm.ReadOnly = true;
            this.litperkm.Size = new System.Drawing.Size(100, 32);
            this.litperkm.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(310, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Liters needed";
            // 
            // litneed
            // 
            this.litneed.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.litneed.Location = new System.Drawing.Point(334, 465);
            this.litneed.Name = "litneed";
            this.litneed.ReadOnly = true;
            this.litneed.Size = new System.Drawing.Size(100, 32);
            this.litneed.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.litneed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.litperkm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.kmwant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.litused);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kmtrav);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox kmtrav;
        private Label label1;
        private TextBox litused;
        private Label label2;
        private Label label3;
        private TextBox kmwant;
        private Button calculatebtn;
        private Label label4;
        private TextBox litperkm;
        private Label label5;
        private TextBox litneed;
    }
}