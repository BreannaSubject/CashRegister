namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.sushiText = new System.Windows.Forms.TextBox();
            this.sushiLabel = new System.Windows.Forms.Label();
            this.udonText = new System.Windows.Forms.TextBox();
            this.udonLabel = new System.Windows.Forms.Label();
            this.bubbleTeaText = new System.Windows.Forms.TextBox();
            this.bubbleteaLabel = new System.Windows.Forms.Label();
            this.tempuraText = new System.Windows.Forms.TextBox();
            this.tempuraLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.costOutputLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Font = new System.Drawing.Font("Gentium Book Basic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gold;
            this.titleLabel.Location = new System.Drawing.Point(-3, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(724, 67);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Hao\'s Sushi";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sushiText
            // 
            this.sushiText.Location = new System.Drawing.Point(182, 86);
            this.sushiText.Name = "sushiText";
            this.sushiText.Size = new System.Drawing.Size(60, 20);
            this.sushiText.TabIndex = 1;
            this.sushiText.TextChanged += new System.EventHandler(this.SushiText_TextChanged);
            // 
            // sushiLabel
            // 
            this.sushiLabel.BackColor = System.Drawing.Color.Transparent;
            this.sushiLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sushiLabel.ForeColor = System.Drawing.Color.White;
            this.sushiLabel.Location = new System.Drawing.Point(41, 86);
            this.sushiLabel.Name = "sushiLabel";
            this.sushiLabel.Size = new System.Drawing.Size(100, 23);
            this.sushiLabel.TabIndex = 2;
            this.sushiLabel.Text = "Sushi (6pcs)";
            // 
            // udonText
            // 
            this.udonText.Location = new System.Drawing.Point(183, 118);
            this.udonText.Name = "udonText";
            this.udonText.Size = new System.Drawing.Size(60, 20);
            this.udonText.TabIndex = 4;
            this.udonText.TextChanged += new System.EventHandler(this.UdonText_TextChanged);
            // 
            // udonLabel
            // 
            this.udonLabel.AutoSize = true;
            this.udonLabel.BackColor = System.Drawing.Color.Transparent;
            this.udonLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udonLabel.ForeColor = System.Drawing.Color.White;
            this.udonLabel.Location = new System.Drawing.Point(41, 118);
            this.udonLabel.Name = "udonLabel";
            this.udonLabel.Size = new System.Drawing.Size(87, 19);
            this.udonLabel.TabIndex = 5;
            this.udonLabel.Text = "Udon Bowl";
            // 
            // bubbleTeaText
            // 
            this.bubbleTeaText.Location = new System.Drawing.Point(182, 152);
            this.bubbleTeaText.Name = "bubbleTeaText";
            this.bubbleTeaText.Size = new System.Drawing.Size(60, 20);
            this.bubbleTeaText.TabIndex = 6;
            this.bubbleTeaText.TextChanged += new System.EventHandler(this.BubbleTeaText_TextChanged);
            // 
            // bubbleteaLabel
            // 
            this.bubbleteaLabel.AutoSize = true;
            this.bubbleteaLabel.BackColor = System.Drawing.Color.Transparent;
            this.bubbleteaLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleteaLabel.ForeColor = System.Drawing.Color.White;
            this.bubbleteaLabel.Location = new System.Drawing.Point(41, 152);
            this.bubbleteaLabel.Name = "bubbleteaLabel";
            this.bubbleteaLabel.Size = new System.Drawing.Size(92, 19);
            this.bubbleteaLabel.TabIndex = 7;
            this.bubbleteaLabel.Text = "Bubble Tea ";
            // 
            // tempuraText
            // 
            this.tempuraText.Location = new System.Drawing.Point(182, 182);
            this.tempuraText.Name = "tempuraText";
            this.tempuraText.Size = new System.Drawing.Size(60, 20);
            this.tempuraText.TabIndex = 8;
            this.tempuraText.TextChanged += new System.EventHandler(this.TempuraText_TextChanged);
            // 
            // tempuraLabel
            // 
            this.tempuraLabel.AutoSize = true;
            this.tempuraLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempuraLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempuraLabel.ForeColor = System.Drawing.Color.White;
            this.tempuraLabel.Location = new System.Drawing.Point(41, 182);
            this.tempuraLabel.Name = "tempuraLabel";
            this.tempuraLabel.Size = new System.Drawing.Size(122, 19);
            this.tempuraLabel.TabIndex = 9;
            this.tempuraLabel.Text = "Mixed Tempura";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.DarkRed;
            this.calculateButton.Font = new System.Drawing.Font("Gentium Book Basic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Gold;
            this.calculateButton.Location = new System.Drawing.Point(45, 218);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // costOutputLabel
            // 
            this.costOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.costOutputLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costOutputLabel.ForeColor = System.Drawing.Color.White;
            this.costOutputLabel.Location = new System.Drawing.Point(40, 244);
            this.costOutputLabel.Name = "costOutputLabel";
            this.costOutputLabel.Size = new System.Drawing.Size(201, 80);
            this.costOutputLabel.TabIndex = 11;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(41, 324);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(137, 19);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered Amount";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(184, 323);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(59, 20);
            this.tenderedInput.TabIndex = 13;
            this.tenderedInput.TextChanged += new System.EventHandler(this.TenderedInput_TextChanged);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.DarkRed;
            this.receiptButton.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.Gold;
            this.receiptButton.Location = new System.Drawing.Point(77, 436);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(124, 27);
            this.receiptButton.TabIndex = 14;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(41, 402);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(201, 23);
            this.changeLabel.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkRed;
            this.changeButton.Font = new System.Drawing.Font("Gentium Book Basic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Gold;
            this.changeButton.Location = new System.Drawing.Point(44, 346);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.DarkRed;
            this.newOrder.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.Color.Gold;
            this.newOrder.Location = new System.Drawing.Point(247, 436);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(96, 27);
            this.newOrder.TabIndex = 18;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.receiptLabel.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.Black;
            this.receiptLabel.Location = new System.Drawing.Point(418, 88);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(214, 337);
            this.receiptLabel.TabIndex = 15;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::CashRegister.Properties.Resources.sakura;
            this.ClientSize = new System.Drawing.Size(719, 475);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.costOutputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.tempuraLabel);
            this.Controls.Add(this.tempuraText);
            this.Controls.Add(this.bubbleteaLabel);
            this.Controls.Add(this.bubbleTeaText);
            this.Controls.Add(this.udonLabel);
            this.Controls.Add(this.udonText);
            this.Controls.Add(this.sushiLabel);
            this.Controls.Add(this.sushiText);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hao\'s Sushi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox sushiText;
        private System.Windows.Forms.Label sushiLabel;
        private System.Windows.Forms.TextBox udonText;
        private System.Windows.Forms.Label udonLabel;
        private System.Windows.Forms.TextBox bubbleTeaText;
        private System.Windows.Forms.Label bubbleteaLabel;
        private System.Windows.Forms.TextBox tempuraText;
        private System.Windows.Forms.Label tempuraLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label costOutputLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button newOrder;
    }
}

