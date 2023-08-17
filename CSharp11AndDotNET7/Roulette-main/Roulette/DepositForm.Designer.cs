namespace Roulette
{
    partial class DepositForm
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
            components = new System.ComponentModel.Container();
            depositBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            nudAmount = new System.Windows.Forms.NumericUpDown();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            this.SuspendLayout();
            // 
            // depositBtn
            // 
            depositBtn.Location = new System.Drawing.Point(12, 81);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new System.Drawing.Size(111, 23);
            depositBtn.TabIndex = 0;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += this.depositBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Amount:";
            // 
            // nudAmount
            // 
            nudAmount.Increment = new System.Decimal(new System.Int32[] { 50, 0, 0, 0 });
            nudAmount.Location = new System.Drawing.Point(72, 21);
            nudAmount.Maximum = new System.Decimal(new System.Int32[] { -727379968, 232, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new System.Drawing.Size(170, 23);
            nudAmount.TabIndex = 2;
            nudAmount.Validating += this.nudAmount_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new System.Drawing.Point(129, 81);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(113, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += this.cancelBtn_Click;
            // 
            // DepositForm
            // 
            this.AcceptButton = depositBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelBtn;
            this.ClientSize = new System.Drawing.Size(265, 119);
            this.Controls.Add(cancelBtn);
            this.Controls.Add(nudAmount);
            this.Controls.Add(label1);
            this.Controls.Add(depositBtn);
            this.Name = "DepositForm";
            this.Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button depositBtn;
        private Label label1;
        private NumericUpDown nudAmount;
        private ErrorProvider errorProvider1;
        private Button cancelBtn;
    }
}