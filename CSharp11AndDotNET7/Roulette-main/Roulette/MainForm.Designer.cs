namespace Roulette
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            wheelPictureBox = new PictureBox();
            spinButton = new Button();
            timerBall = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            currentBetsList = new ListBox();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button11 = new Button();
            button12 = new Button();
            button10 = new Button();
            button14 = new Button();
            button15 = new Button();
            button13 = new Button();
            button17 = new Button();
            button18 = new Button();
            button16 = new Button();
            button35 = new Button();
            button36 = new Button();
            button34 = new Button();
            button32 = new Button();
            button33 = new Button();
            button31 = new Button();
            button29 = new Button();
            button30 = new Button();
            button28 = new Button();
            button26 = new Button();
            button27 = new Button();
            button25 = new Button();
            button23 = new Button();
            button24 = new Button();
            button22 = new Button();
            button20 = new Button();
            button21 = new Button();
            button19 = new Button();
            buttonGreen = new Button();
            buttonRed = new Button();
            buttonBlack = new Button();
            amountNud = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            tbCurrentBalance = new TextBox();
            btnDepositMoney = new Button();
            btnRemoveLastBet = new Button();
            btnRemoveAllBets = new Button();
            btnRules = new Button();
            ((System.ComponentModel.ISupportInitialize)wheelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNud).BeginInit();
            SuspendLayout();
            // 
            // wheelPictureBox
            // 
            wheelPictureBox.Location = new Point(12, 83);
            wheelPictureBox.Name = "wheelPictureBox";
            wheelPictureBox.Size = new Size(27, 80);
            wheelPictureBox.TabIndex = 0;
            wheelPictureBox.TabStop = false;
            wheelPictureBox.Paint += wheelPictureBox_Paint;
            // 
            // spinButton
            // 
            spinButton.Location = new Point(461, 542);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(200, 42);
            spinButton.TabIndex = 1;
            spinButton.Text = "SPIN";
            spinButton.UseVisualStyleBackColor = true;
            spinButton.Click += spinButton_Click;
            // 
            // timerBall
            // 
            timerBall.Interval = 10;
            timerBall.Tick += timerBall_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(740, 4);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 2;
            label1.Text = "Current Bets:";
            // 
            // currentBetsList
            // 
            currentBetsList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            currentBetsList.ForeColor = SystemColors.Info;
            currentBetsList.FormattingEnabled = true;
            currentBetsList.ItemHeight = 15;
            currentBetsList.Location = new Point(690, 28);
            currentBetsList.Name = "currentBetsList";
            currentBetsList.Size = new Size(200, 499);
            currentBetsList.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(924, 61);
            button1.Name = "button1";
            button1.Size = new Size(60, 40);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(1036, 61);
            button3.Name = "button3";
            button3.Size = new Size(60, 40);
            button3.TabIndex = 7;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(980, 61);
            button2.Name = "button2";
            button2.Size = new Size(60, 40);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(980, 97);
            button5.Name = "button5";
            button5.Size = new Size(60, 40);
            button5.TabIndex = 11;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(1036, 97);
            button6.Name = "button6";
            button6.Size = new Size(60, 40);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(924, 97);
            button4.Name = "button4";
            button4.Size = new Size(60, 40);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(980, 133);
            button8.Name = "button8";
            button8.Size = new Size(60, 40);
            button8.TabIndex = 14;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaptionText;
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(1036, 133);
            button9.Name = "button9";
            button9.Size = new Size(60, 40);
            button9.TabIndex = 13;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(924, 133);
            button7.Name = "button7";
            button7.Size = new Size(60, 40);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Red;
            button11.ForeColor = SystemColors.ButtonFace;
            button11.Location = new Point(980, 169);
            button11.Name = "button11";
            button11.Size = new Size(60, 40);
            button11.TabIndex = 17;
            button11.Text = "11";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Black;
            button12.ForeColor = SystemColors.ButtonFace;
            button12.Location = new Point(1036, 169);
            button12.Name = "button12";
            button12.Size = new Size(60, 40);
            button12.TabIndex = 16;
            button12.Text = "12";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Red;
            button10.ForeColor = SystemColors.ButtonFace;
            button10.Location = new Point(924, 169);
            button10.Name = "button10";
            button10.Size = new Size(60, 40);
            button10.TabIndex = 15;
            button10.Text = "10";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Black;
            button14.ForeColor = SystemColors.ButtonFace;
            button14.Location = new Point(980, 205);
            button14.Name = "button14";
            button14.Size = new Size(60, 40);
            button14.TabIndex = 20;
            button14.Text = "14";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Red;
            button15.ForeColor = SystemColors.ButtonFace;
            button15.Location = new Point(1036, 205);
            button15.Name = "button15";
            button15.Size = new Size(60, 40);
            button15.TabIndex = 19;
            button15.Text = "15";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Red;
            button13.ForeColor = SystemColors.ButtonFace;
            button13.Location = new Point(924, 205);
            button13.Name = "button13";
            button13.Size = new Size(60, 40);
            button13.TabIndex = 18;
            button13.Text = "13";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Red;
            button17.ForeColor = SystemColors.ButtonFace;
            button17.Location = new Point(980, 240);
            button17.Name = "button17";
            button17.Size = new Size(60, 40);
            button17.TabIndex = 23;
            button17.Text = "17";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Black;
            button18.ForeColor = SystemColors.ButtonFace;
            button18.Location = new Point(1036, 240);
            button18.Name = "button18";
            button18.Size = new Size(60, 40);
            button18.TabIndex = 22;
            button18.Text = "18";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Black;
            button16.ForeColor = SystemColors.ButtonFace;
            button16.Location = new Point(924, 240);
            button16.Name = "button16";
            button16.Size = new Size(60, 40);
            button16.TabIndex = 21;
            button16.Text = "16";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button_Click;
            // 
            // button35
            // 
            button35.BackColor = Color.Red;
            button35.ForeColor = SystemColors.ButtonFace;
            button35.Location = new Point(980, 455);
            button35.Name = "button35";
            button35.Size = new Size(60, 40);
            button35.TabIndex = 41;
            button35.Text = "35";
            button35.UseVisualStyleBackColor = false;
            button35.Click += button_Click;
            // 
            // button36
            // 
            button36.BackColor = Color.Black;
            button36.ForeColor = SystemColors.ButtonFace;
            button36.Location = new Point(1036, 455);
            button36.Name = "button36";
            button36.Size = new Size(60, 40);
            button36.TabIndex = 40;
            button36.Text = "36";
            button36.UseVisualStyleBackColor = false;
            button36.Click += button_Click;
            // 
            // button34
            // 
            button34.BackColor = Color.Black;
            button34.ForeColor = SystemColors.ButtonFace;
            button34.Location = new Point(924, 455);
            button34.Name = "button34";
            button34.Size = new Size(60, 40);
            button34.TabIndex = 39;
            button34.Text = "34";
            button34.UseVisualStyleBackColor = false;
            button34.Click += button_Click;
            // 
            // button32
            // 
            button32.BackColor = Color.Black;
            button32.ForeColor = SystemColors.ButtonFace;
            button32.Location = new Point(980, 420);
            button32.Name = "button32";
            button32.Size = new Size(60, 40);
            button32.TabIndex = 38;
            button32.Text = "32";
            button32.UseVisualStyleBackColor = false;
            button32.Click += button_Click;
            // 
            // button33
            // 
            button33.BackColor = Color.Red;
            button33.ForeColor = SystemColors.ButtonFace;
            button33.Location = new Point(1036, 420);
            button33.Name = "button33";
            button33.Size = new Size(60, 40);
            button33.TabIndex = 37;
            button33.Text = "33";
            button33.UseVisualStyleBackColor = false;
            button33.Click += button_Click;
            // 
            // button31
            // 
            button31.BackColor = Color.Red;
            button31.ForeColor = SystemColors.ButtonFace;
            button31.Location = new Point(924, 420);
            button31.Name = "button31";
            button31.Size = new Size(60, 40);
            button31.TabIndex = 36;
            button31.Text = "31";
            button31.UseVisualStyleBackColor = false;
            button31.Click += button_Click;
            // 
            // button29
            // 
            button29.BackColor = Color.Red;
            button29.ForeColor = SystemColors.ButtonFace;
            button29.Location = new Point(980, 384);
            button29.Name = "button29";
            button29.Size = new Size(60, 40);
            button29.TabIndex = 35;
            button29.Text = "29";
            button29.UseVisualStyleBackColor = false;
            button29.Click += button_Click;
            // 
            // button30
            // 
            button30.BackColor = Color.Black;
            button30.ForeColor = SystemColors.ButtonFace;
            button30.Location = new Point(1036, 384);
            button30.Name = "button30";
            button30.Size = new Size(60, 40);
            button30.TabIndex = 34;
            button30.Text = "30";
            button30.UseVisualStyleBackColor = false;
            button30.Click += button_Click;
            // 
            // button28
            // 
            button28.BackColor = Color.Red;
            button28.ForeColor = SystemColors.ButtonFace;
            button28.Location = new Point(924, 384);
            button28.Name = "button28";
            button28.Size = new Size(60, 40);
            button28.TabIndex = 33;
            button28.Text = "28";
            button28.UseVisualStyleBackColor = false;
            button28.Click += button_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.Red;
            button26.ForeColor = SystemColors.ButtonFace;
            button26.Location = new Point(980, 348);
            button26.Name = "button26";
            button26.Size = new Size(60, 40);
            button26.TabIndex = 32;
            button26.Text = "26";
            button26.UseVisualStyleBackColor = false;
            button26.Click += button_Click;
            // 
            // button27
            // 
            button27.BackColor = SystemColors.ActiveCaptionText;
            button27.ForeColor = SystemColors.ButtonFace;
            button27.Location = new Point(1036, 348);
            button27.Name = "button27";
            button27.Size = new Size(60, 40);
            button27.TabIndex = 31;
            button27.Text = "27";
            button27.UseVisualStyleBackColor = false;
            button27.Click += button_Click;
            // 
            // button25
            // 
            button25.BackColor = SystemColors.ActiveCaptionText;
            button25.ForeColor = SystemColors.ButtonFace;
            button25.Location = new Point(924, 348);
            button25.Name = "button25";
            button25.Size = new Size(60, 40);
            button25.TabIndex = 30;
            button25.Text = "25";
            button25.UseVisualStyleBackColor = false;
            button25.Click += button_Click;
            // 
            // button23
            // 
            button23.BackColor = SystemColors.ActiveCaptionText;
            button23.ForeColor = SystemColors.ButtonFace;
            button23.Location = new Point(980, 312);
            button23.Name = "button23";
            button23.Size = new Size(60, 40);
            button23.TabIndex = 29;
            button23.Text = "23";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.Red;
            button24.ForeColor = SystemColors.ButtonFace;
            button24.Location = new Point(1036, 312);
            button24.Name = "button24";
            button24.Size = new Size(60, 40);
            button24.TabIndex = 28;
            button24.Text = "24";
            button24.UseVisualStyleBackColor = false;
            button24.Click += button_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Red;
            button22.ForeColor = SystemColors.ButtonFace;
            button22.Location = new Point(924, 312);
            button22.Name = "button22";
            button22.Size = new Size(60, 40);
            button22.TabIndex = 27;
            button22.Text = "22";
            button22.UseVisualStyleBackColor = false;
            button22.Click += button_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Red;
            button20.ForeColor = SystemColors.ButtonFace;
            button20.Location = new Point(980, 276);
            button20.Name = "button20";
            button20.Size = new Size(60, 40);
            button20.TabIndex = 26;
            button20.Text = "20";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button_Click;
            // 
            // button21
            // 
            button21.BackColor = SystemColors.ActiveCaptionText;
            button21.ForeColor = SystemColors.ButtonFace;
            button21.Location = new Point(1036, 276);
            button21.Name = "button21";
            button21.Size = new Size(60, 40);
            button21.TabIndex = 25;
            button21.Text = "21";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button_Click;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ActiveCaptionText;
            button19.ForeColor = SystemColors.ButtonFace;
            button19.Location = new Point(924, 276);
            button19.Name = "button19";
            button19.Size = new Size(60, 40);
            button19.TabIndex = 24;
            button19.Text = "19";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button_Click;
            // 
            // buttonGreen
            // 
            buttonGreen.BackColor = Color.Green;
            buttonGreen.ForeColor = SystemColors.ButtonFace;
            buttonGreen.Location = new Point(924, 22);
            buttonGreen.Name = "buttonGreen";
            buttonGreen.Size = new Size(172, 40);
            buttonGreen.TabIndex = 42;
            buttonGreen.Text = "0";
            buttonGreen.UseVisualStyleBackColor = false;
            buttonGreen.Click += buttonGreen_Click;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.Red;
            buttonRed.ForeColor = SystemColors.ButtonFace;
            buttonRed.Location = new Point(1093, 205);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(25, 75);
            buttonRed.TabIndex = 43;
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += buttonRed_Click;
            // 
            // buttonBlack
            // 
            buttonBlack.BackColor = SystemColors.ActiveCaptionText;
            buttonBlack.ForeColor = SystemColors.ButtonFace;
            buttonBlack.Location = new Point(1093, 277);
            buttonBlack.Name = "buttonBlack";
            buttonBlack.Size = new Size(25, 75);
            buttonBlack.TabIndex = 44;
            buttonBlack.UseVisualStyleBackColor = false;
            buttonBlack.Click += buttonBlack_Click;
            // 
            // amountNud
            // 
            amountNud.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            amountNud.Location = new Point(476, 28);
            amountNud.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            amountNud.Name = "amountNud";
            amountNud.Size = new Size(120, 23);
            amountNud.TabIndex = 45;
            amountNud.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(486, 6);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 46;
            label2.Text = "Bet Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(327, 4);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 47;
            label3.Text = "Current Balance:";
            // 
            // tbCurrentBalance
            // 
            tbCurrentBalance.Location = new Point(324, 28);
            tbCurrentBalance.Name = "tbCurrentBalance";
            tbCurrentBalance.ReadOnly = true;
            tbCurrentBalance.Size = new Size(126, 23);
            tbCurrentBalance.TabIndex = 48;
            tbCurrentBalance.Text = "0";
            tbCurrentBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDepositMoney
            // 
            btnDepositMoney.Location = new Point(12, 6);
            btnDepositMoney.Name = "btnDepositMoney";
            btnDepositMoney.Size = new Size(137, 50);
            btnDepositMoney.TabIndex = 49;
            btnDepositMoney.Text = "Deposit Money";
            btnDepositMoney.UseVisualStyleBackColor = true;
            btnDepositMoney.Click += btnDepositMoney_Click;
            // 
            // btnRemoveLastBet
            // 
            btnRemoveLastBet.Location = new Point(690, 542);
            btnRemoveLastBet.Name = "btnRemoveLastBet";
            btnRemoveLastBet.Size = new Size(89, 42);
            btnRemoveLastBet.TabIndex = 50;
            btnRemoveLastBet.Text = "Remove Last Bet";
            btnRemoveLastBet.UseVisualStyleBackColor = true;
            btnRemoveLastBet.Click += btnRemoveLastBet_Click;
            // 
            // btnRemoveAllBets
            // 
            btnRemoveAllBets.Location = new Point(798, 542);
            btnRemoveAllBets.Name = "btnRemoveAllBets";
            btnRemoveAllBets.Size = new Size(92, 42);
            btnRemoveAllBets.TabIndex = 51;
            btnRemoveAllBets.Text = "Remove All Bets";
            btnRemoveAllBets.UseVisualStyleBackColor = true;
            btnRemoveAllBets.Click += btnRemoveAllBets_Click;
            // 
            // btnRules
            // 
            btnRules.Location = new Point(170, 6);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(137, 50);
            btnRules.TabIndex = 52;
            btnRules.Text = "Rules && How To Play";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1144, 596);
            Controls.Add(btnRules);
            Controls.Add(btnRemoveAllBets);
            Controls.Add(btnRemoveLastBet);
            Controls.Add(btnDepositMoney);
            Controls.Add(tbCurrentBalance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(amountNud);
            Controls.Add(buttonBlack);
            Controls.Add(buttonRed);
            Controls.Add(buttonGreen);
            Controls.Add(button35);
            Controls.Add(button36);
            Controls.Add(button34);
            Controls.Add(button32);
            Controls.Add(button33);
            Controls.Add(button31);
            Controls.Add(button29);
            Controls.Add(button30);
            Controls.Add(button28);
            Controls.Add(button26);
            Controls.Add(button27);
            Controls.Add(button25);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button22);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button19);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button16);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(currentBetsList);
            Controls.Add(label1);
            Controls.Add(spinButton);
            Controls.Add(wheelPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Roulette";
            ((System.ComponentModel.ISupportInitialize)wheelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox wheelPictureBox;
        private Button spinButton;
        private System.Windows.Forms.Timer timerBall;
        private Label label1;
        private ListBox currentBetsList;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button button7;
        private Button button11;
        private Button button12;
        private Button button10;
        private Button button14;
        private Button button15;
        private Button button13;
        private Button button17;
        private Button button18;
        private Button button16;
        private Button button35;
        private Button button36;
        private Button button34;
        private Button button32;
        private Button button33;
        private Button button31;
        private Button button29;
        private Button button30;
        private Button button28;
        private Button button26;
        private Button button27;
        private Button button25;
        private Button button23;
        private Button button24;
        private Button button22;
        private Button button20;
        private Button button21;
        private Button button19;
        private Button buttonGreen;
        private Button buttonRed;
        private Button buttonBlack;
        private NumericUpDown amountNud;
        private Label label2;
        private Label label3;
        private TextBox tbCurrentBalance;
        private Button btnDepositMoney;
        private Button btnRemoveLastBet;
        private Button btnRemoveAllBets;
        private Button btnRules;
    }
}