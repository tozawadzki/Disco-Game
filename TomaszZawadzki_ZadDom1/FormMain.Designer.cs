namespace TomaszZawadzki_ZadDom1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressPee = new System.Windows.Forms.ProgressBar();
            this.labelBladder = new System.Windows.Forms.Label();
            this.progressEnergy = new System.Windows.Forms.ProgressBar();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.buttonToilet = new System.Windows.Forms.Button();
            this.buttonBeer = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressGirl = new System.Windows.Forms.ProgressBar();
            this.labelGirl = new System.Windows.Forms.Label();
            this.buttonDance = new System.Windows.Forms.Button();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonDrink = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.buttonMakeMoney = new System.Windows.Forms.Button();
            this.buttonWeapon = new System.Windows.Forms.Button();
            this.progressAlcohol = new System.Windows.Forms.ProgressBar();
            this.labelAlcohol = new System.Windows.Forms.Label();
            this.buttonCig = new System.Windows.Forms.Button();
            this.progressMind = new System.Windows.Forms.ProgressBar();
            this.labelMindControl = new System.Windows.Forms.Label();
            this.buttonBefore = new System.Windows.Forms.Button();
            this.buttonDealer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressSympathy = new System.Windows.Forms.ProgressBar();
            this.buttonOutfit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelTitle.Location = new System.Drawing.Point(285, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 48);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dyskoteka";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 345);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // progressPee
            // 
            this.progressPee.Location = new System.Drawing.Point(12, 60);
            this.progressPee.Name = "progressPee";
            this.progressPee.Size = new System.Drawing.Size(235, 23);
            this.progressPee.TabIndex = 2;
            // 
            // labelBladder
            // 
            this.labelBladder.AutoSize = true;
            this.labelBladder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBladder.Location = new System.Drawing.Point(72, 12);
            this.labelBladder.Name = "labelBladder";
            this.labelBladder.Size = new System.Drawing.Size(108, 29);
            this.labelBladder.TabIndex = 3;
            this.labelBladder.Text = "Pęcherz";
            // 
            // progressEnergy
            // 
            this.progressEnergy.Location = new System.Drawing.Point(12, 219);
            this.progressEnergy.Name = "progressEnergy";
            this.progressEnergy.Size = new System.Drawing.Size(235, 23);
            this.progressEnergy.TabIndex = 4;
            this.progressEnergy.Value = 80;
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnergy.Location = new System.Drawing.Point(72, 174);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(104, 29);
            this.labelEnergy.TabIndex = 5;
            this.labelEnergy.Text = "Energia";
            // 
            // buttonToilet
            // 
            this.buttonToilet.Location = new System.Drawing.Point(77, 99);
            this.buttonToilet.Name = "buttonToilet";
            this.buttonToilet.Size = new System.Drawing.Size(109, 55);
            this.buttonToilet.TabIndex = 6;
            this.buttonToilet.Text = "Toaleta ";
            this.buttonToilet.UseVisualStyleBackColor = true;
            this.buttonToilet.Click += new System.EventHandler(this.buttonToilet_Click);
            // 
            // buttonBeer
            // 
            this.buttonBeer.Location = new System.Drawing.Point(71, 258);
            this.buttonBeer.Name = "buttonBeer";
            this.buttonBeer.Size = new System.Drawing.Size(109, 55);
            this.buttonBeer.TabIndex = 7;
            this.buttonBeer.Text = "Piwo";
            this.buttonBeer.UseVisualStyleBackColor = true;
            this.buttonBeer.Click += new System.EventHandler(this.buttonBeer_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(885, 12);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(50, 22);
            this.textBoxTime.TabIndex = 8;
            this.textBoxTime.Text = "180";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(808, 12);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(62, 25);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Czas";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(826, 486);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(109, 55);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(653, 234);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(8, 8);
            this.progressBar1.TabIndex = 12;
            // 
            // progressGirl
            // 
            this.progressGirl.Location = new System.Drawing.Point(12, 382);
            this.progressGirl.Name = "progressGirl";
            this.progressGirl.Size = new System.Drawing.Size(235, 23);
            this.progressGirl.TabIndex = 13;
            // 
            // labelGirl
            // 
            this.labelGirl.AutoSize = true;
            this.labelGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGirl.Location = new System.Drawing.Point(17, 332);
            this.labelGirl.Name = "labelGirl";
            this.labelGirl.Size = new System.Drawing.Size(230, 29);
            this.labelGirl.TabIndex = 14;
            this.labelGirl.Text = "Zdobycie partnerki";
            // 
            // buttonDance
            // 
            this.buttonDance.Location = new System.Drawing.Point(12, 425);
            this.buttonDance.Name = "buttonDance";
            this.buttonDance.Size = new System.Drawing.Size(109, 55);
            this.buttonDance.TabIndex = 15;
            this.buttonDance.Text = "Taniec";
            this.buttonDance.UseVisualStyleBackColor = true;
            this.buttonDance.Click += new System.EventHandler(this.buttonDance_Click);
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(885, 40);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(50, 22);
            this.textBoxMoney.TabIndex = 17;
            this.textBoxMoney.Text = "100";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoney.Location = new System.Drawing.Point(775, 40);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(95, 25);
            this.labelMoney.TabIndex = 18;
            this.labelMoney.Text = "Pieniądz";
            // 
            // buttonDrink
            // 
            this.buttonDrink.Location = new System.Drawing.Point(138, 425);
            this.buttonDrink.Name = "buttonDrink";
            this.buttonDrink.Size = new System.Drawing.Size(109, 55);
            this.buttonDrink.TabIndex = 19;
            this.buttonDrink.Text = "Postaw drinka (Zaimponuj)";
            this.buttonDrink.UseVisualStyleBackColor = true;
            this.buttonDrink.Click += new System.EventHandler(this.buttonDrink_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(12, 486);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(109, 55);
            this.buttonLeave.TabIndex = 20;
            this.buttonLeave.Text = "Wyjdź";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // buttonMakeMoney
            // 
            this.buttonMakeMoney.Location = new System.Drawing.Point(826, 68);
            this.buttonMakeMoney.Name = "buttonMakeMoney";
            this.buttonMakeMoney.Size = new System.Drawing.Size(109, 55);
            this.buttonMakeMoney.TabIndex = 21;
            this.buttonMakeMoney.Text = "Zrób pieniądz";
            this.buttonMakeMoney.UseVisualStyleBackColor = true;
            this.buttonMakeMoney.Click += new System.EventHandler(this.buttonMakeMoney_Click);
            // 
            // buttonWeapon
            // 
            this.buttonWeapon.Location = new System.Drawing.Point(610, 425);
            this.buttonWeapon.Name = "buttonWeapon";
            this.buttonWeapon.Size = new System.Drawing.Size(109, 55);
            this.buttonWeapon.TabIndex = 22;
            this.buttonWeapon.Text = "Uzbroj się";
            this.buttonWeapon.UseVisualStyleBackColor = true;
            this.buttonWeapon.Click += new System.EventHandler(this.buttonWeapon_Click);
            // 
            // progressAlcohol
            // 
            this.progressAlcohol.Location = new System.Drawing.Point(544, 60);
            this.progressAlcohol.Name = "progressAlcohol";
            this.progressAlcohol.Size = new System.Drawing.Size(235, 23);
            this.progressAlcohol.TabIndex = 23;
            // 
            // labelAlcohol
            // 
            this.labelAlcohol.AutoSize = true;
            this.labelAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlcohol.Location = new System.Drawing.Point(554, 12);
            this.labelAlcohol.Name = "labelAlcohol";
            this.labelAlcohol.Size = new System.Drawing.Size(208, 29);
            this.labelAlcohol.TabIndex = 24;
            this.labelAlcohol.Text = "Poziom upojenia";
            // 
            // buttonCig
            // 
            this.buttonCig.Location = new System.Drawing.Point(610, 99);
            this.buttonCig.Name = "buttonCig";
            this.buttonCig.Size = new System.Drawing.Size(109, 55);
            this.buttonCig.TabIndex = 25;
            this.buttonCig.Text = "Fajka";
            this.buttonCig.UseVisualStyleBackColor = true;
            this.buttonCig.Click += new System.EventHandler(this.buttonCig_Click);
            // 
            // progressMind
            // 
            this.progressMind.Location = new System.Drawing.Point(544, 219);
            this.progressMind.Name = "progressMind";
            this.progressMind.Size = new System.Drawing.Size(235, 23);
            this.progressMind.TabIndex = 26;
            this.progressMind.Value = 100;
            // 
            // labelMindControl
            // 
            this.labelMindControl.AutoSize = true;
            this.labelMindControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMindControl.Location = new System.Drawing.Point(539, 174);
            this.labelMindControl.Name = "labelMindControl";
            this.labelMindControl.Size = new System.Drawing.Size(243, 29);
            this.labelMindControl.TabIndex = 27;
            this.labelMindControl.Text = "Zdrowie psychiczne";
            // 
            // buttonBefore
            // 
            this.buttonBefore.Location = new System.Drawing.Point(826, 425);
            this.buttonBefore.Name = "buttonBefore";
            this.buttonBefore.Size = new System.Drawing.Size(109, 55);
            this.buttonBefore.TabIndex = 28;
            this.buttonBefore.Text = "Idź na before";
            this.buttonBefore.UseVisualStyleBackColor = true;
            this.buttonBefore.Click += new System.EventHandler(this.buttonBefore_Click);
            // 
            // buttonDealer
            // 
            this.buttonDealer.Location = new System.Drawing.Point(610, 258);
            this.buttonDealer.Name = "buttonDealer";
            this.buttonDealer.Size = new System.Drawing.Size(109, 55);
            this.buttonDealer.TabIndex = 29;
            this.buttonDealer.Text = "Dealer (Tylko Raz)";
            this.buttonDealer.UseVisualStyleBackColor = true;
            this.buttonDealer.Click += new System.EventHandler(this.buttonDealer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(544, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sympatia bramkarza";
            // 
            // progressSympathy
            // 
            this.progressSympathy.Location = new System.Drawing.Point(544, 382);
            this.progressSympathy.Name = "progressSympathy";
            this.progressSympathy.Size = new System.Drawing.Size(235, 23);
            this.progressSympathy.TabIndex = 32;
            this.progressSympathy.Value = 100;
            // 
            // buttonOutfit
            // 
            this.buttonOutfit.Location = new System.Drawing.Point(350, 425);
            this.buttonOutfit.Name = "buttonOutfit";
            this.buttonOutfit.Size = new System.Drawing.Size(109, 55);
            this.buttonOutfit.TabIndex = 33;
            this.buttonOutfit.Text = "Outfit";
            this.buttonOutfit.UseVisualStyleBackColor = true;
            this.buttonOutfit.Click += new System.EventHandler(this.buttonOutfit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 553);
            this.Controls.Add(this.buttonOutfit);
            this.Controls.Add(this.progressSympathy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDealer);
            this.Controls.Add(this.buttonBefore);
            this.Controls.Add(this.labelMindControl);
            this.Controls.Add(this.progressMind);
            this.Controls.Add(this.buttonCig);
            this.Controls.Add(this.labelAlcohol);
            this.Controls.Add(this.progressAlcohol);
            this.Controls.Add(this.buttonWeapon);
            this.Controls.Add(this.buttonMakeMoney);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonDrink);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.buttonDance);
            this.Controls.Add(this.labelGirl);
            this.Controls.Add(this.progressGirl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonBeer);
            this.Controls.Add(this.buttonToilet);
            this.Controls.Add(this.labelEnergy);
            this.Controls.Add(this.progressEnergy);
            this.Controls.Add(this.labelBladder);
            this.Controls.Add(this.progressPee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressPee;
        private System.Windows.Forms.Label labelBladder;
        private System.Windows.Forms.ProgressBar progressEnergy;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Button buttonToilet;
        private System.Windows.Forms.Button buttonBeer;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressGirl;
        private System.Windows.Forms.Label labelGirl;
        private System.Windows.Forms.Button buttonDance;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonDrink;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.Button buttonMakeMoney;
        private System.Windows.Forms.Button buttonWeapon;
        private System.Windows.Forms.ProgressBar progressAlcohol;
        private System.Windows.Forms.Label labelAlcohol;
        private System.Windows.Forms.Button buttonCig;
        private System.Windows.Forms.ProgressBar progressMind;
        private System.Windows.Forms.Label labelMindControl;
        private System.Windows.Forms.Button buttonBefore;
        private System.Windows.Forms.Button buttonDealer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressSympathy;
        private System.Windows.Forms.Button buttonOutfit;
    }
}

