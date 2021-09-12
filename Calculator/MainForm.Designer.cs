
namespace Calculator
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.modButton = new System.Windows.Forms.Button();
            this.sRootBtn = new System.Windows.Forms.Button();
            this.x2Btn = new System.Windows.Forms.Button();
            this.x1Btn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.ceBtn = new System.Windows.Forms.Button();
            this.xBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.negateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayLabel.Location = new System.Drawing.Point(-1, 9);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(436, 85);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "0";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modButton
            // 
            this.modButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modButton.Location = new System.Drawing.Point(-1, 97);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(112, 50);
            this.modButton.TabIndex = 1;
            this.modButton.Text = "%";
            this.modButton.UseVisualStyleBackColor = true;
            // 
            // sRootBtn
            // 
            this.sRootBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sRootBtn.Location = new System.Drawing.Point(108, 97);
            this.sRootBtn.Name = "sRootBtn";
            this.sRootBtn.Size = new System.Drawing.Size(112, 50);
            this.sRootBtn.TabIndex = 2;
            this.sRootBtn.Text = "√";
            this.sRootBtn.UseVisualStyleBackColor = true;
            this.sRootBtn.Click += new System.EventHandler(this.sRootBtn_Click);
            // 
            // x2Btn
            // 
            this.x2Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x2Btn.Location = new System.Drawing.Point(217, 97);
            this.x2Btn.Name = "x2Btn";
            this.x2Btn.Size = new System.Drawing.Size(112, 50);
            this.x2Btn.TabIndex = 3;
            this.x2Btn.Text = "x²";
            this.x2Btn.UseVisualStyleBackColor = true;
            this.x2Btn.Click += new System.EventHandler(this.x2Btn_Click);
            // 
            // x1Btn
            // 
            this.x1Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x1Btn.Location = new System.Drawing.Point(323, 97);
            this.x1Btn.Name = "x1Btn";
            this.x1Btn.Size = new System.Drawing.Size(112, 50);
            this.x1Btn.TabIndex = 4;
            this.x1Btn.Text = "1/x";
            this.x1Btn.UseVisualStyleBackColor = true;
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divBtn.Location = new System.Drawing.Point(323, 144);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(112, 50);
            this.divBtn.TabIndex = 8;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(217, 144);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(112, 50);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "←";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cBtn
            // 
            this.cBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBtn.Location = new System.Drawing.Point(108, 144);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(112, 50);
            this.cBtn.TabIndex = 6;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ceBtn.Location = new System.Drawing.Point(-1, 144);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(112, 50);
            this.ceBtn.TabIndex = 5;
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = true;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // xBtn
            // 
            this.xBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xBtn.Location = new System.Drawing.Point(323, 191);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(112, 50);
            this.xBtn.TabIndex = 12;
            this.xBtn.Text = "*";
            this.xBtn.UseVisualStyleBackColor = true;
            this.xBtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.SystemColors.Control;
            this.nineBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nineBtn.Location = new System.Drawing.Point(217, 191);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(112, 50);
            this.nineBtn.TabIndex = 11;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.SystemColors.Control;
            this.eightBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eightBtn.Location = new System.Drawing.Point(108, 191);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(112, 50);
            this.eightBtn.TabIndex = 10;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sevenBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sevenBtn.Location = new System.Drawing.Point(-1, 191);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(112, 50);
            this.sevenBtn.TabIndex = 9;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractBtn.Location = new System.Drawing.Point(323, 238);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(112, 50);
            this.subtractBtn.TabIndex = 16;
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.subtractBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sixBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sixBtn.Location = new System.Drawing.Point(217, 238);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(112, 50);
            this.sixBtn.TabIndex = 15;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fiveBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiveBtn.Location = new System.Drawing.Point(108, 238);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(112, 50);
            this.fiveBtn.TabIndex = 14;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fourBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fourBtn.Location = new System.Drawing.Point(-1, 238);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(112, 50);
            this.fourBtn.TabIndex = 13;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusBtn.Location = new System.Drawing.Point(323, 285);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(112, 50);
            this.plusBtn.TabIndex = 20;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.threeBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeBtn.Location = new System.Drawing.Point(217, 285);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(112, 50);
            this.threeBtn.TabIndex = 19;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.twoBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twoBtn.Location = new System.Drawing.Point(108, 285);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(112, 50);
            this.twoBtn.TabIndex = 18;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.SystemColors.Control;
            this.oneBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oneBtn.Location = new System.Drawing.Point(-1, 285);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(112, 50);
            this.oneBtn.TabIndex = 17;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalsBtn.Location = new System.Drawing.Point(323, 332);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(112, 50);
            this.equalsBtn.TabIndex = 24;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dotBtn.Location = new System.Drawing.Point(217, 332);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(112, 50);
            this.dotBtn.TabIndex = 23;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.SystemColors.Control;
            this.zeroBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeroBtn.Location = new System.Drawing.Point(108, 332);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(112, 50);
            this.zeroBtn.TabIndex = 22;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // negateBtn
            // 
            this.negateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.negateBtn.Location = new System.Drawing.Point(-1, 332);
            this.negateBtn.Name = "negateBtn";
            this.negateBtn.Size = new System.Drawing.Size(112, 50);
            this.negateBtn.TabIndex = 21;
            this.negateBtn.Text = "+-";
            this.negateBtn.UseVisualStyleBackColor = true;
            this.negateBtn.Click += new System.EventHandler(this.negateBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 383);
            this.Controls.Add(this.equalsBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.negateBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.ceBtn);
            this.Controls.Add(this.x1Btn);
            this.Controls.Add(this.x2Btn);
            this.Controls.Add(this.sRootBtn);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.displayLabel);
            this.Name = "MainForm";
            this.Text = "Ti-27";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button sRootBtn;
        private System.Windows.Forms.Button x2Btn;
        private System.Windows.Forms.Button x1Btn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button ceBtn;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button negateBtn;
    }
}

