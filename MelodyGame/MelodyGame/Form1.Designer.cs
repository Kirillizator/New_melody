namespace MelodyGame
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnGame = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGame.BackgroundImage = global::MelodyGame.Properties.Resources._111;
            this.btnGame.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Location = new System.Drawing.Point(131, 44);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(350, 120);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Игра";
            this.btnGame.UseVisualStyleBackColor = false;
            // 
            // btnParams
            // 
            this.btnParams.BackgroundImage = global::MelodyGame.Properties.Resources._111;
            this.btnParams.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParams.Location = new System.Drawing.Point(131, 221);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(350, 120);
            this.btnParams.TabIndex = 1;
            this.btnParams.Text = "Настройки";
            this.btnParams.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::MelodyGame.Properties.Resources._111;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(131, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(350, 120);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MelodyGame.Properties.Resources.Ноты;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "fMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "                                                                 Угадай мелодию";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnExit;
    }
}

