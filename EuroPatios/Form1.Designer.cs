namespace EuroPatios
{
    partial class frmEstimate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExchangeRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rBGravel = new System.Windows.Forms.RadioButton();
            this.rBTarmac = new System.Windows.Forms.RadioButton();
            this.rBConcrete = new System.Windows.Forms.RadioButton();
            this.rBBrick = new System.Windows.Forms.RadioButton();
            this.lblPricePerSq = new System.Windows.Forms.Label();
            this.tbBrick = new System.Windows.Forms.TextBox();
            this.tbConcrete = new System.Windows.Forms.TextBox();
            this.tbTarmac = new System.Windows.Forms.TextBox();
            this.tbGravel = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.gbFoundations = new System.Windows.Forms.GroupBox();
            this.rbExtraDeep = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblMetres1 = new System.Windows.Forms.Label();
            this.lblMetres2 = new System.Windows.Forms.Label();
            this.tbGBP = new System.Windows.Forms.TextBox();
            this.tbEURO = new System.Windows.Forms.TextBox();
            this.lblGbp = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbFoundations.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(106, 33);
            this.lblHeading.MinimumSize = new System.Drawing.Size(154, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(234, 26);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Euro Drives or Patios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "EXCHANGE RATE:  £1=";
            // 
            // tbExchangeRate
            // 
            this.tbExchangeRate.Location = new System.Drawing.Point(144, 67);
            this.tbExchangeRate.Name = "tbExchangeRate";
            this.tbExchangeRate.Size = new System.Drawing.Size(51, 23);
            this.tbExchangeRate.TabIndex = 3;
            this.tbExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "EUROS";
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rBGravel);
            this.gbType.Controls.Add(this.rBTarmac);
            this.gbType.Controls.Add(this.rBConcrete);
            this.gbType.Controls.Add(this.rBBrick);
            this.gbType.Location = new System.Drawing.Point(14, 116);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(124, 186);
            this.gbType.TabIndex = 5;
            this.gbType.TabStop = false;
            this.gbType.Text = "Materials";
            // 
            // rBGravel
            // 
            this.rBGravel.AutoSize = true;
            this.rBGravel.Location = new System.Drawing.Point(8, 143);
            this.rBGravel.Name = "rBGravel";
            this.rBGravel.Size = new System.Drawing.Size(66, 19);
            this.rBGravel.TabIndex = 3;
            this.rBGravel.TabStop = true;
            this.rBGravel.Text = "GRAVEL";
            this.rBGravel.UseVisualStyleBackColor = true;
            // 
            // rBTarmac
            // 
            this.rBTarmac.AutoSize = true;
            this.rBTarmac.Location = new System.Drawing.Point(8, 99);
            this.rBTarmac.Name = "rBTarmac";
            this.rBTarmac.Size = new System.Drawing.Size(72, 19);
            this.rBTarmac.TabIndex = 2;
            this.rBTarmac.TabStop = true;
            this.rBTarmac.Text = "TARMAC";
            this.rBTarmac.UseVisualStyleBackColor = true;
            // 
            // rBConcrete
            // 
            this.rBConcrete.AutoSize = true;
            this.rBConcrete.Location = new System.Drawing.Point(8, 59);
            this.rBConcrete.Name = "rBConcrete";
            this.rBConcrete.Size = new System.Drawing.Size(84, 19);
            this.rBConcrete.TabIndex = 1;
            this.rBConcrete.TabStop = true;
            this.rBConcrete.Text = "CONCRETE";
            this.rBConcrete.UseVisualStyleBackColor = true;
            // 
            // rBBrick
            // 
            this.rBBrick.AutoSize = true;
            this.rBBrick.Location = new System.Drawing.Point(8, 17);
            this.rBBrick.Name = "rBBrick";
            this.rBBrick.Size = new System.Drawing.Size(57, 19);
            this.rBBrick.TabIndex = 0;
            this.rBBrick.TabStop = true;
            this.rBBrick.Text = "BRICK";
            this.rBBrick.UseVisualStyleBackColor = true;
            // 
            // lblPricePerSq
            // 
            this.lblPricePerSq.AutoSize = true;
            this.lblPricePerSq.Location = new System.Drawing.Point(154, 101);
            this.lblPricePerSq.Name = "lblPricePerSq";
            this.lblPricePerSq.Size = new System.Drawing.Size(147, 15);
            this.lblPricePerSq.TabIndex = 6;
            this.lblPricePerSq.Text = "PRICE PER SQUARE METRE";
            // 
            // tbBrick
            // 
            this.tbBrick.Location = new System.Drawing.Point(171, 129);
            this.tbBrick.Name = "tbBrick";
            this.tbBrick.Size = new System.Drawing.Size(100, 23);
            this.tbBrick.TabIndex = 7;
            this.tbBrick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbConcrete
            // 
            this.tbConcrete.Location = new System.Drawing.Point(171, 171);
            this.tbConcrete.Name = "tbConcrete";
            this.tbConcrete.Size = new System.Drawing.Size(100, 23);
            this.tbConcrete.TabIndex = 8;
            this.tbConcrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTarmac
            // 
            this.tbTarmac.Location = new System.Drawing.Point(171, 215);
            this.tbTarmac.Name = "tbTarmac";
            this.tbTarmac.Size = new System.Drawing.Size(100, 23);
            this.tbTarmac.TabIndex = 9;
            this.tbTarmac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGravel
            // 
            this.tbGravel.Location = new System.Drawing.Point(171, 255);
            this.tbGravel.Name = "tbGravel";
            this.tbGravel.Size = new System.Drawing.Size(100, 23);
            this.tbGravel.TabIndex = 10;
            this.tbGravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(205, 517);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(94, 23);
            this.cmdStart.TabIndex = 11;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // gbFoundations
            // 
            this.gbFoundations.Controls.Add(this.rbExtraDeep);
            this.gbFoundations.Controls.Add(this.rbStandard);
            this.gbFoundations.Location = new System.Drawing.Point(341, 116);
            this.gbFoundations.Name = "gbFoundations";
            this.gbFoundations.Size = new System.Drawing.Size(119, 78);
            this.gbFoundations.TabIndex = 12;
            this.gbFoundations.TabStop = false;
            this.gbFoundations.Text = "Foundations";
            // 
            // rbExtraDeep
            // 
            this.rbExtraDeep.AutoSize = true;
            this.rbExtraDeep.Location = new System.Drawing.Point(8, 47);
            this.rbExtraDeep.Name = "rbExtraDeep";
            this.rbExtraDeep.Size = new System.Drawing.Size(89, 19);
            this.rbExtraDeep.TabIndex = 1;
            this.rbExtraDeep.TabStop = true;
            this.rbExtraDeep.Text = "EXTRA DEEP";
            this.rbExtraDeep.UseVisualStyleBackColor = true;
            this.rbExtraDeep.CheckedChanged += new System.EventHandler(this.rbExtraDeep_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(8, 22);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(84, 19);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "STANDARD";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(181, 319);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 23);
            this.tbLength.TabIndex = 13;
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(181, 359);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 23);
            this.tbWidth.TabIndex = 14;
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(126, 323);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 15);
            this.lblLength.TabIndex = 15;
            this.lblLength.Text = "LENGTH";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(132, 367);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(43, 15);
            this.lblWidth.TabIndex = 16;
            this.lblWidth.Text = "WIDTH";
            // 
            // lblMetres1
            // 
            this.lblMetres1.AutoSize = true;
            this.lblMetres1.Location = new System.Drawing.Point(287, 323);
            this.lblMetres1.Name = "lblMetres1";
            this.lblMetres1.Size = new System.Drawing.Size(49, 15);
            this.lblMetres1.TabIndex = 17;
            this.lblMetres1.Text = "METRES";
            // 
            // lblMetres2
            // 
            this.lblMetres2.AutoSize = true;
            this.lblMetres2.Location = new System.Drawing.Point(287, 367);
            this.lblMetres2.Name = "lblMetres2";
            this.lblMetres2.Size = new System.Drawing.Size(49, 15);
            this.lblMetres2.TabIndex = 18;
            this.lblMetres2.Text = "METRES";
            // 
            // tbGBP
            // 
            this.tbGBP.Location = new System.Drawing.Point(106, 399);
            this.tbGBP.Name = "tbGBP";
            this.tbGBP.Size = new System.Drawing.Size(100, 23);
            this.tbGBP.TabIndex = 19;
            this.tbGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbEURO
            // 
            this.tbEURO.Location = new System.Drawing.Point(287, 399);
            this.tbEURO.Name = "tbEURO";
            this.tbEURO.Size = new System.Drawing.Size(100, 23);
            this.tbEURO.TabIndex = 20;
            this.tbEURO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGbp
            // 
            this.lblGbp.AutoSize = true;
            this.lblGbp.Location = new System.Drawing.Point(71, 407);
            this.lblGbp.Name = "lblGbp";
            this.lblGbp.Size = new System.Drawing.Size(29, 15);
            this.lblGbp.TabIndex = 21;
            this.lblGbp.Text = "GBP";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(243, 407);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(37, 15);
            this.lblEuro.TabIndex = 22;
            this.lblEuro.Text = "EURO";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(95, 517);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(104, 23);
            this.cmdCalculate.TabIndex = 23;
            this.cmdCalculate.Text = "CALCULATE";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(305, 517);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(91, 23);
            this.cmdClear.TabIndex = 24;
            this.cmdClear.Text = "CLEAR";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(98, 490);
            this.lblOutput.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(298, 15);
            this.lblOutput.TabIndex = 25;
            this.lblOutput.Text = "                                                                                 " +
    "                \r\n";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 552);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblGbp);
            this.Controls.Add(this.tbEURO);
            this.Controls.Add(this.tbGBP);
            this.Controls.Add(this.lblMetres2);
            this.Controls.Add(this.lblMetres1);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.gbFoundations);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.tbGravel);
            this.Controls.Add(this.tbTarmac);
            this.Controls.Add(this.tbConcrete);
            this.Controls.Add(this.tbBrick);
            this.Controls.Add(this.lblPricePerSq);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbExchangeRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.Text = "Drive Estimates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbFoundations.ResumeLayout(false);
            this.gbFoundations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Label lblHeading;
        private Label label2;
        private TextBox tbExchangeRate;
        private Label label3;
        private GroupBox gbType;
        private RadioButton rBGravel;
        private RadioButton rBTarmac;
        private RadioButton rBConcrete;
        private RadioButton rBBrick;
        private Label lblPricePerSq;
        private TextBox tbBrick;
        private TextBox tbConcrete;
        private TextBox tbTarmac;
        private TextBox tbGravel;
        private Button cmdStart;
        private GroupBox gbFoundations;
        private RadioButton rbExtraDeep;
        private RadioButton rbStandard;
        private TextBox tbLength;
        private TextBox tbWidth;
        private Label lblLength;
        private Label lblWidth;
        private Label lblMetres1;
        private Label lblMetres2;
        private TextBox tbGBP;
        private TextBox tbEURO;
        private Label lblGbp;
        private Label lblEuro;
        private Button cmdCalculate;
        private Button cmdClear;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblOutput;
    }
}