namespace StringBuildersDemo
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
            openFileDialog1 = new OpenFileDialog();
            rtbLoad = new RichTextBox();
            btnLoad = new Button();
            btnS10 = new Button();
            btnS15 = new Button();
            btnConcat = new Button();
            txtS10 = new TextBox();
            txtS15 = new TextBox();
            txtConcat = new TextBox();
            rtbTokenize = new RichTextBox();
            btnTokenize = new Button();
            btnReplace = new Button();
            txtOld = new TextBox();
            txtNew = new TextBox();
            labOld = new Label();
            labNew = new Label();
            rtbReplace = new RichTextBox();
            rtbNormalize = new RichTextBox();
            btnUp = new Button();
            btnLow = new Button();
            rtbTrim = new RichTextBox();
            btnTrim = new Button();
            btnQ = new Button();
            btnQ7 = new Button();
            txtChar = new TextBox();
            labChar = new Label();
            btnDigit = new Button();
            btnLetter = new Button();
            btnToUpper = new Button();
            btnIsLower = new Button();
            btnQ11 = new Button();
            btnQ12 = new Button();
            txtID = new TextBox();
            btnCheck = new Button();
            txtGmail = new TextBox();
            btnGmail = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // rtbLoad
            // 
            rtbLoad.Location = new Point(12, 12);
            rtbLoad.Name = "rtbLoad";
            rtbLoad.Size = new Size(295, 184);
            rtbLoad.TabIndex = 0;
            rtbLoad.Text = "";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(313, 10);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnS10
            // 
            btnS10.Location = new Point(324, 260);
            btnS10.Name = "btnS10";
            btnS10.Size = new Size(132, 34);
            btnS10.TabIndex = 2;
            btnS10.Text = "Substring(10)";
            btnS10.UseVisualStyleBackColor = true;
            btnS10.Click += btnS10_Click;
            // 
            // btnS15
            // 
            btnS15.Location = new Point(313, 61);
            btnS15.Name = "btnS15";
            btnS15.Size = new Size(132, 34);
            btnS15.TabIndex = 2;
            btnS15.Text = "Substring(1,5)";
            btnS15.UseVisualStyleBackColor = true;
            btnS15.Click += btnS15_Click;
            // 
            // btnConcat
            // 
            btnConcat.Location = new Point(313, 387);
            btnConcat.Name = "btnConcat";
            btnConcat.Size = new Size(132, 34);
            btnConcat.TabIndex = 2;
            btnConcat.Text = "Concat a";
            btnConcat.UseVisualStyleBackColor = true;
            btnConcat.Click += btnConcat_Click;
            // 
            // txtS10
            // 
            txtS10.Location = new Point(12, 213);
            txtS10.Multiline = true;
            txtS10.Name = "txtS10";
            txtS10.Size = new Size(291, 168);
            txtS10.TabIndex = 3;
            // 
            // txtS15
            // 
            txtS15.Location = new Point(313, 101);
            txtS15.Name = "txtS15";
            txtS15.Size = new Size(132, 31);
            txtS15.TabIndex = 3;
            // 
            // txtConcat
            // 
            txtConcat.Location = new Point(12, 387);
            txtConcat.Multiline = true;
            txtConcat.Name = "txtConcat";
            txtConcat.Size = new Size(291, 152);
            txtConcat.TabIndex = 3;
            // 
            // rtbTokenize
            // 
            rtbTokenize.Location = new Point(465, 10);
            rtbTokenize.Name = "rtbTokenize";
            rtbTokenize.Size = new Size(279, 174);
            rtbTokenize.TabIndex = 4;
            rtbTokenize.Text = "";
            // 
            // btnTokenize
            // 
            btnTokenize.Location = new Point(761, 14);
            btnTokenize.Name = "btnTokenize";
            btnTokenize.Size = new Size(112, 34);
            btnTokenize.TabIndex = 5;
            btnTokenize.Text = "Tokenize";
            btnTokenize.UseVisualStyleBackColor = true;
            btnTokenize.Click += btnTokenize_Click;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(761, 198);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(112, 34);
            btnReplace.TabIndex = 6;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // txtOld
            // 
            txtOld.Location = new Point(516, 198);
            txtOld.Name = "txtOld";
            txtOld.Size = new Size(228, 31);
            txtOld.TabIndex = 7;
            // 
            // txtNew
            // 
            txtNew.Location = new Point(516, 243);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(228, 31);
            txtNew.TabIndex = 7;
            // 
            // labOld
            // 
            labOld.AutoSize = true;
            labOld.Location = new Point(465, 203);
            labOld.Name = "labOld";
            labOld.Size = new Size(45, 25);
            labOld.TabIndex = 8;
            labOld.Text = "Old:";
            // 
            // labNew
            // 
            labNew.AutoSize = true;
            labNew.Location = new Point(465, 246);
            labNew.Name = "labNew";
            labNew.Size = new Size(47, 25);
            labNew.TabIndex = 8;
            labNew.Text = "New";
            // 
            // rtbReplace
            // 
            rtbReplace.Location = new Point(465, 280);
            rtbReplace.Name = "rtbReplace";
            rtbReplace.Size = new Size(279, 115);
            rtbReplace.TabIndex = 9;
            rtbReplace.Text = "";
            // 
            // rtbNormalize
            // 
            rtbNormalize.Location = new Point(465, 411);
            rtbNormalize.Name = "rtbNormalize";
            rtbNormalize.Size = new Size(279, 144);
            rtbNormalize.TabIndex = 10;
            rtbNormalize.Text = "";
            // 
            // btnUp
            // 
            btnUp.Location = new Point(768, 411);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(145, 48);
            btnUp.TabIndex = 11;
            btnUp.Text = "Normalize/Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnLow
            // 
            btnLow.Location = new Point(768, 465);
            btnLow.Name = "btnLow";
            btnLow.Size = new Size(145, 50);
            btnLow.TabIndex = 11;
            btnLow.Text = "Normalize/Low";
            btnLow.UseVisualStyleBackColor = true;
            btnLow.Click += btnLow_Click;
            // 
            // rtbTrim
            // 
            rtbTrim.Location = new Point(905, 10);
            rtbTrim.Name = "rtbTrim";
            rtbTrim.Size = new Size(193, 174);
            rtbTrim.TabIndex = 12;
            rtbTrim.Text = "";
            // 
            // btnTrim
            // 
            btnTrim.Location = new Point(1104, 14);
            btnTrim.Name = "btnTrim";
            btnTrim.Size = new Size(112, 34);
            btnTrim.TabIndex = 13;
            btnTrim.Text = "Trim";
            btnTrim.UseVisualStyleBackColor = true;
            btnTrim.Click += btnTrim_Click;
            // 
            // btnQ
            // 
            btnQ.Location = new Point(905, 203);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(212, 68);
            btnQ.TabIndex = 14;
            btnQ.Text = "Question6";
            btnQ.UseVisualStyleBackColor = true;
            btnQ.Click += btnQ_Click;
            // 
            // btnQ7
            // 
            btnQ7.Location = new Point(905, 288);
            btnQ7.Name = "btnQ7";
            btnQ7.Size = new Size(212, 60);
            btnQ7.TabIndex = 15;
            btnQ7.Text = "Question7";
            btnQ7.UseVisualStyleBackColor = true;
            btnQ7.Click += btnQ7_Click;
            // 
            // txtChar
            // 
            txtChar.Location = new Point(915, 364);
            txtChar.Name = "txtChar";
            txtChar.Size = new Size(150, 31);
            txtChar.TabIndex = 16;
            // 
            // labChar
            // 
            labChar.AutoSize = true;
            labChar.Location = new Point(823, 367);
            labChar.Name = "labChar";
            labChar.Size = new Size(90, 25);
            labChar.TabIndex = 17;
            labChar.Text = "Character:";
            // 
            // btnDigit
            // 
            btnDigit.Location = new Point(1071, 364);
            btnDigit.Name = "btnDigit";
            btnDigit.Size = new Size(112, 34);
            btnDigit.TabIndex = 18;
            btnDigit.Text = "IsDigit";
            btnDigit.UseVisualStyleBackColor = true;
            btnDigit.Click += btnDigit_Click;
            // 
            // btnLetter
            // 
            btnLetter.Location = new Point(1004, 404);
            btnLetter.Name = "btnLetter";
            btnLetter.Size = new Size(179, 34);
            btnLetter.TabIndex = 18;
            btnLetter.Text = "IsLetterOrDigit";
            btnLetter.UseVisualStyleBackColor = true;
            btnLetter.Click += btnLetter_Click;
            // 
            // btnToUpper
            // 
            btnToUpper.Location = new Point(1071, 444);
            btnToUpper.Name = "btnToUpper";
            btnToUpper.Size = new Size(112, 34);
            btnToUpper.TabIndex = 18;
            btnToUpper.Text = "ToUpper";
            btnToUpper.UseVisualStyleBackColor = true;
            btnToUpper.Click += btnToUpper_Click;
            // 
            // btnIsLower
            // 
            btnIsLower.Location = new Point(1071, 484);
            btnIsLower.Name = "btnIsLower";
            btnIsLower.Size = new Size(112, 34);
            btnIsLower.TabIndex = 18;
            btnIsLower.Text = "IsLower";
            btnIsLower.UseVisualStyleBackColor = true;
            btnIsLower.Click += btnIsLower_Click;
            // 
            // btnQ11
            // 
            btnQ11.Location = new Point(1271, 14);
            btnQ11.Name = "btnQ11";
            btnQ11.Size = new Size(204, 81);
            btnQ11.TabIndex = 19;
            btnQ11.Text = "Question 11";
            btnQ11.UseVisualStyleBackColor = true;
            btnQ11.Click += btnQ11_Click;
            // 
            // btnQ12
            // 
            btnQ12.Location = new Point(1271, 113);
            btnQ12.Name = "btnQ12";
            btnQ12.Size = new Size(204, 83);
            btnQ12.TabIndex = 20;
            btnQ12.Text = "Question12";
            btnQ12.UseVisualStyleBackColor = true;
            btnQ12.Click += btnQ12_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(1123, 222);
            txtID.Name = "txtID";
            txtID.Size = new Size(233, 31);
            txtID.TabIndex = 21;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(1362, 222);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 34);
            btnCheck.TabIndex = 22;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(1123, 303);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(233, 31);
            txtGmail.TabIndex = 23;
            // 
            // btnGmail
            // 
            btnGmail.Location = new Point(1372, 303);
            btnGmail.Name = "btnGmail";
            btnGmail.Size = new Size(126, 56);
            btnGmail.TabIndex = 24;
            btnGmail.Text = "Check G-mail";
            btnGmail.UseVisualStyleBackColor = true;
            btnGmail.Click += btnGmail_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 548);
            Controls.Add(btnGmail);
            Controls.Add(txtGmail);
            Controls.Add(btnCheck);
            Controls.Add(txtID);
            Controls.Add(btnQ12);
            Controls.Add(btnQ11);
            Controls.Add(btnIsLower);
            Controls.Add(btnLetter);
            Controls.Add(btnToUpper);
            Controls.Add(btnDigit);
            Controls.Add(labChar);
            Controls.Add(txtChar);
            Controls.Add(btnQ7);
            Controls.Add(btnQ);
            Controls.Add(btnTrim);
            Controls.Add(rtbTrim);
            Controls.Add(btnLow);
            Controls.Add(btnUp);
            Controls.Add(rtbNormalize);
            Controls.Add(rtbReplace);
            Controls.Add(labNew);
            Controls.Add(labOld);
            Controls.Add(txtNew);
            Controls.Add(txtOld);
            Controls.Add(btnReplace);
            Controls.Add(btnTokenize);
            Controls.Add(rtbTokenize);
            Controls.Add(txtConcat);
            Controls.Add(txtS15);
            Controls.Add(txtS10);
            Controls.Add(btnConcat);
            Controls.Add(btnS15);
            Controls.Add(btnS10);
            Controls.Add(btnLoad);
            Controls.Add(rtbLoad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private RichTextBox rtbLoad;
        private Button btnLoad;
        private Button btnS10;
        private Button btnS15;
        private Button btnConcat;
        private TextBox txtS10;
        private TextBox txtS15;
        private TextBox txtConcat;
        private RichTextBox rtbTokenize;
        private Button btnTokenize;
        private Button btnReplace;
        private TextBox txtOld;
        private TextBox txtNew;
        private Label labOld;
        private Label labNew;
        private RichTextBox rtbReplace;
        private RichTextBox rtbNormalize;
        private Button btnUp;
        private Button btnLow;
        private RichTextBox rtbTrim;
        private Button btnTrim;
        private Button btnQ;
        private Button btnQ7;
        private TextBox txtChar;
        private Label labChar;
        private Button btnDigit;
        private Button btnLetter;
        private Button btnToUpper;
        private Button btnIsLower;
        private Button btnQ11;
        private Button btnQ12;
        private TextBox txtID;
        private Button btnCheck;
        private TextBox txtGmail;
        private Button btnGmail;
    }
}