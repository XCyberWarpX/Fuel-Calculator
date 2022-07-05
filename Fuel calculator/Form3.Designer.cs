namespace Fuel_calculator
{
    partial class Form3
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
            this.kmTrav = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.litUsed = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.litPer100km = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilometers traveled";
            // 
            // kmTrav
            // 
            this.kmTrav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kmTrav.Location = new System.Drawing.Point(443, 56);
            this.kmTrav.Name = "kmTrav";
            this.kmTrav.Size = new System.Drawing.Size(138, 29);
            this.kmTrav.TabIndex = 1;
            this.kmTrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kmTrav_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(228, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liters used";
            // 
            // litUsed
            // 
            this.litUsed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.litUsed.Location = new System.Drawing.Point(443, 128);
            this.litUsed.Name = "litUsed";
            this.litUsed.Size = new System.Drawing.Size(138, 29);
            this.litUsed.TabIndex = 3;
            this.litUsed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.litUsed_KeyPress);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateBtn.Location = new System.Drawing.Point(296, 199);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(181, 74);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(302, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liters per 100km";
            // 
            // litPer100km
            // 
            this.litPer100km.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.litPer100km.Location = new System.Drawing.Point(296, 362);
            this.litPer100km.Name = "litPer100km";
            this.litPer100km.ReadOnly = true;
            this.litPer100km.Size = new System.Drawing.Size(181, 36);
            this.litPer100km.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.litPer100km);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.litUsed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kmTrav);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox kmTrav;
        private Label label2;
        private TextBox litUsed;
        private Button calculateBtn;
        private Label label3;
        private TextBox litPer100km;
    }
}