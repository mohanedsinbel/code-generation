namespace CaptchaGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textCaptchaRefresh = new System.Windows.Forms.Button();
            this.textCaptchaSubmit = new System.Windows.Forms.Button();
            this.textCaptchaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCaptchaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageCaptchaRefresh = new System.Windows.Forms.Button();
            this.imageCaptchaSubmit = new System.Windows.Forms.Button();
            this.imageCaptchaInstruction = new System.Windows.Forms.Label();
            this.imageCaptchaDisplay = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mathCaptchaRefresh = new System.Windows.Forms.Button();
            this.mathCaptchaSubmit = new System.Windows.Forms.Button();
            this.mathCaptchaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mathCaptchaLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.recaptchaRefresh = new System.Windows.Forms.Button();
            this.recaptchaSubmit = new System.Windows.Forms.Button();
            this.recaptchaCheckbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCaptchaDisplay)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textCaptchaRefresh);
            this.tabPage1.Controls.Add(this.textCaptchaSubmit);
            this.tabPage1.Controls.Add(this.textCaptchaInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textCaptchaLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text CAPTCHA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textCaptchaRefresh
            // 
            this.textCaptchaRefresh.Location = new System.Drawing.Point(300, 150);
            this.textCaptchaRefresh.Name = "textCaptchaRefresh";
            this.textCaptchaRefresh.Size = new System.Drawing.Size(75, 23);
            this.textCaptchaRefresh.TabIndex = 5;
            this.textCaptchaRefresh.Text = "Refresh";
            this.textCaptchaRefresh.UseVisualStyleBackColor = true;
            this.textCaptchaRefresh.Click += new System.EventHandler(this.textCaptchaRefresh_Click);
            // 
            // textCaptchaSubmit
            // 
            this.textCaptchaSubmit.Location = new System.Drawing.Point(200, 150);
            this.textCaptchaSubmit.Name = "textCaptchaSubmit";
            this.textCaptchaSubmit.Size = new System.Drawing.Size(75, 23);
            this.textCaptchaSubmit.TabIndex = 4;
            this.textCaptchaSubmit.Text = "Submit";
            this.textCaptchaSubmit.UseVisualStyleBackColor = true;
            this.textCaptchaSubmit.Click += new System.EventHandler(this.textCaptchaSubmit_Click);
            // 
            // textCaptchaInput
            // 
            this.textCaptchaInput.Location = new System.Drawing.Point(200, 100);
            this.textCaptchaInput.Name = "textCaptchaInput";
            this.textCaptchaInput.Size = new System.Drawing.Size(175, 23);
            this.textCaptchaInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the text you see:";
            // 
            // textCaptchaLabel
            // 
            this.textCaptchaLabel.AutoSize = true;
            this.textCaptchaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.textCaptchaLabel.Location = new System.Drawing.Point(200, 50);
            this.textCaptchaLabel.Name = "textCaptchaLabel";
            this.textCaptchaLabel.Size = new System.Drawing.Size(120, 32);
            this.textCaptchaLabel.TabIndex = 1;
            this.textCaptchaLabel.Text = "CAPTCHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text CAPTCHA Display:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.imageCaptchaRefresh);
            this.tabPage2.Controls.Add(this.imageCaptchaSubmit);
            this.tabPage2.Controls.Add(this.imageCaptchaInstruction);
            this.tabPage2.Controls.Add(this.imageCaptchaDisplay);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image CAPTCHA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageCaptchaRefresh
            // 
            this.imageCaptchaRefresh.Location = new System.Drawing.Point(300, 420);
            this.imageCaptchaRefresh.Name = "imageCaptchaRefresh";
            this.imageCaptchaRefresh.Size = new System.Drawing.Size(75, 23);
            this.imageCaptchaRefresh.TabIndex = 4;
            this.imageCaptchaRefresh.Text = "Refresh";
            this.imageCaptchaRefresh.UseVisualStyleBackColor = true;
            this.imageCaptchaRefresh.Click += new System.EventHandler(this.imageCaptchaRefresh_Click);
            // 
            // imageCaptchaSubmit
            // 
            this.imageCaptchaSubmit.Location = new System.Drawing.Point(200, 420);
            this.imageCaptchaSubmit.Name = "imageCaptchaSubmit";
            this.imageCaptchaSubmit.Size = new System.Drawing.Size(75, 23);
            this.imageCaptchaSubmit.TabIndex = 3;
            this.imageCaptchaSubmit.Text = "Submit";
            this.imageCaptchaSubmit.UseVisualStyleBackColor = true;
            this.imageCaptchaSubmit.Click += new System.EventHandler(this.imageCaptchaSubmit_Click);
            // 
            // imageCaptchaInstruction
            // 
            this.imageCaptchaInstruction.AutoSize = true;
            this.imageCaptchaInstruction.Location = new System.Drawing.Point(50, 20);
            this.imageCaptchaInstruction.Name = "imageCaptchaInstruction";
            this.imageCaptchaInstruction.Size = new System.Drawing.Size(200, 15);
            this.imageCaptchaInstruction.TabIndex = 2;
            this.imageCaptchaInstruction.Text = "Click on all squares with traffic lights";
            // 
            // imageCaptchaDisplay
            // 
            this.imageCaptchaDisplay.Location = new System.Drawing.Point(50, 50);
            this.imageCaptchaDisplay.Name = "imageCaptchaDisplay";
            this.imageCaptchaDisplay.Size = new System.Drawing.Size(450, 350);
            this.imageCaptchaDisplay.TabIndex = 1;
            this.imageCaptchaDisplay.TabStop = false;
            this.imageCaptchaDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageCaptchaDisplay_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected: 0 squares";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mathCaptchaRefresh);
            this.tabPage3.Controls.Add(this.mathCaptchaSubmit);
            this.tabPage3.Controls.Add(this.mathCaptchaInput);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.mathCaptchaLabel);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Math CAPTCHA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mathCaptchaRefresh
            // 
            this.mathCaptchaRefresh.Location = new System.Drawing.Point(300, 150);
            this.mathCaptchaRefresh.Name = "mathCaptchaRefresh";
            this.mathCaptchaRefresh.Size = new System.Drawing.Size(75, 23);
            this.mathCaptchaRefresh.TabIndex = 5;
            this.mathCaptchaRefresh.Text = "Refresh";
            this.mathCaptchaRefresh.UseVisualStyleBackColor = true;
            this.mathCaptchaRefresh.Click += new System.EventHandler(this.mathCaptchaRefresh_Click);
            // 
            // mathCaptchaSubmit
            // 
            this.mathCaptchaSubmit.Location = new System.Drawing.Point(200, 150);
            this.mathCaptchaSubmit.Name = "mathCaptchaSubmit";
            this.mathCaptchaSubmit.Size = new System.Drawing.Size(75, 23);
            this.mathCaptchaSubmit.TabIndex = 4;
            this.mathCaptchaSubmit.Text = "Submit";
            this.mathCaptchaSubmit.UseVisualStyleBackColor = true;
            this.mathCaptchaSubmit.Click += new System.EventHandler(this.mathCaptchaSubmit_Click);
            // 
            // mathCaptchaInput
            // 
            this.mathCaptchaInput.Location = new System.Drawing.Point(200, 100);
            this.mathCaptchaInput.Name = "mathCaptchaInput";
            this.mathCaptchaInput.Size = new System.Drawing.Size(175, 23);
            this.mathCaptchaInput.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Enter the correct answer:";
            // 
            // mathCaptchaLabel
            // 
            this.mathCaptchaLabel.AutoSize = true;
            this.mathCaptchaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mathCaptchaLabel.Location = new System.Drawing.Point(200, 50);
            this.mathCaptchaLabel.Name = "mathCaptchaLabel";
            this.mathCaptchaLabel.Size = new System.Drawing.Size(120, 32);
            this.mathCaptchaLabel.TabIndex = 1;
            this.mathCaptchaLabel.Text = "5 + 3 = ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Math CAPTCHA Display:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.recaptchaRefresh);
            this.tabPage4.Controls.Add(this.recaptchaSubmit);
            this.tabPage4.Controls.Add(this.recaptchaCheckbox);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(552, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "reCAPTCHA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // recaptchaRefresh
            // 
            this.recaptchaRefresh.Location = new System.Drawing.Point(300, 150);
            this.recaptchaRefresh.Name = "recaptchaRefresh";
            this.recaptchaRefresh.Size = new System.Drawing.Size(75, 23);
            this.recaptchaRefresh.TabIndex = 3;
            this.recaptchaRefresh.Text = "Refresh";
            this.recaptchaRefresh.UseVisualStyleBackColor = true;
            this.recaptchaRefresh.Click += new System.EventHandler(this.recaptchaRefresh_Click);
            // 
            // recaptchaSubmit
            // 
            this.recaptchaSubmit.Location = new System.Drawing.Point(200, 150);
            this.recaptchaSubmit.Name = "recaptchaSubmit";
            this.recaptchaSubmit.Size = new System.Drawing.Size(75, 23);
            this.recaptchaSubmit.TabIndex = 2;
            this.recaptchaSubmit.Text = "Submit";
            this.recaptchaSubmit.UseVisualStyleBackColor = true;
            this.recaptchaSubmit.Click += new System.EventHandler(this.recaptchaSubmit_Click);
            // 
            // recaptchaCheckbox
            // 
            this.recaptchaCheckbox.AutoSize = true;
            this.recaptchaCheckbox.Location = new System.Drawing.Point(200, 100);
            this.recaptchaCheckbox.Name = "recaptchaCheckbox";
            this.recaptchaCheckbox.Size = new System.Drawing.Size(175, 19);
            this.recaptchaCheckbox.TabIndex = 1;
            this.recaptchaCheckbox.Text = "I\'m not a robot (reCAPTCHA)";
            this.recaptchaCheckbox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "reCAPTCHA Checkbox:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 525);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 21);
            this.resultLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CAPTCHA Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCaptchaDisplay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private Label textCaptchaLabel;
        private TextBox textCaptchaInput;
        private Label label2;
        private Button textCaptchaSubmit;
        private Button textCaptchaRefresh;
        private PictureBox imageCaptchaDisplay;
        private Label label4;
        private Label imageCaptchaInstruction;
        private Button imageCaptchaSubmit;
        private Button imageCaptchaRefresh;
        private Button mathCaptchaRefresh;
        private Button mathCaptchaSubmit;
        private TextBox mathCaptchaInput;
        private Label label6;
        private Label mathCaptchaLabel;
        private Label label8;
        private Button recaptchaRefresh;
        private Button recaptchaSubmit;
        private CheckBox recaptchaCheckbox;
        private Label label10;
        private Label resultLabel;
    }
}