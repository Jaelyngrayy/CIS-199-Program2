
namespace Program2
{
    partial class calculatorForm
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
            this.peopleLbl = new System.Windows.Forms.Label();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.daysLbl = new System.Windows.Forms.Label();
            this.companyALbl = new System.Windows.Forms.Label();
            this.companyAOutputLbl = new System.Windows.Forms.Label();
            this.companyBOutputLbl = new System.Windows.Forms.Label();
            this.companyBLbl = new System.Windows.Forms.Label();
            this.companyCOutputLbl = new System.Windows.Forms.Label();
            this.companyCLbl = new System.Windows.Forms.Label();
            this.peopleTxt = new System.Windows.Forms.TextBox();
            this.distanceTxt = new System.Windows.Forms.TextBox();
            this.daysTxt = new System.Windows.Forms.TextBox();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.decisionOutputLbl = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleLbl
            // 
            this.peopleLbl.AutoSize = true;
            this.peopleLbl.Location = new System.Drawing.Point(89, 83);
            this.peopleLbl.Name = "peopleLbl";
            this.peopleLbl.Size = new System.Drawing.Size(40, 13);
            this.peopleLbl.TabIndex = 0;
            this.peopleLbl.Text = "People";
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Location = new System.Drawing.Point(89, 132);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(82, 13);
            this.distanceLbl.TabIndex = 1;
            this.distanceLbl.Text = "Distance (Miles)";
            // 
            // daysLbl
            // 
            this.daysLbl.AutoSize = true;
            this.daysLbl.Location = new System.Drawing.Point(89, 183);
            this.daysLbl.Name = "daysLbl";
            this.daysLbl.Size = new System.Drawing.Size(72, 13);
            this.daysLbl.TabIndex = 2;
            this.daysLbl.Text = "Delivery Days";
            // 
            // companyALbl
            // 
            this.companyALbl.AutoSize = true;
            this.companyALbl.Location = new System.Drawing.Point(49, 56);
            this.companyALbl.Name = "companyALbl";
            this.companyALbl.Size = new System.Drawing.Size(85, 13);
            this.companyALbl.TabIndex = 3;
            this.companyALbl.Text = "Company A Cost";
            // 
            // companyAOutputLbl
            // 
            this.companyAOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyAOutputLbl.Location = new System.Drawing.Point(156, 51);
            this.companyAOutputLbl.Name = "companyAOutputLbl";
            this.companyAOutputLbl.Size = new System.Drawing.Size(86, 23);
            this.companyAOutputLbl.TabIndex = 4;
            this.companyAOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyBOutputLbl
            // 
            this.companyBOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBOutputLbl.Location = new System.Drawing.Point(156, 100);
            this.companyBOutputLbl.Name = "companyBOutputLbl";
            this.companyBOutputLbl.Size = new System.Drawing.Size(86, 23);
            this.companyBOutputLbl.TabIndex = 6;
            this.companyBOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyBLbl
            // 
            this.companyBLbl.AutoSize = true;
            this.companyBLbl.Location = new System.Drawing.Point(49, 105);
            this.companyBLbl.Name = "companyBLbl";
            this.companyBLbl.Size = new System.Drawing.Size(85, 13);
            this.companyBLbl.TabIndex = 5;
            this.companyBLbl.Text = "Company B Cost";
            // 
            // companyCOutputLbl
            // 
            this.companyCOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyCOutputLbl.Location = new System.Drawing.Point(156, 151);
            this.companyCOutputLbl.Name = "companyCOutputLbl";
            this.companyCOutputLbl.Size = new System.Drawing.Size(86, 23);
            this.companyCOutputLbl.TabIndex = 8;
            this.companyCOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyCLbl
            // 
            this.companyCLbl.AutoSize = true;
            this.companyCLbl.Location = new System.Drawing.Point(49, 156);
            this.companyCLbl.Name = "companyCLbl";
            this.companyCLbl.Size = new System.Drawing.Size(85, 13);
            this.companyCLbl.TabIndex = 7;
            this.companyCLbl.Text = "Company C Cost";
            // 
            // peopleTxt
            // 
            this.peopleTxt.Location = new System.Drawing.Point(192, 80);
            this.peopleTxt.Name = "peopleTxt";
            this.peopleTxt.Size = new System.Drawing.Size(100, 20);
            this.peopleTxt.TabIndex = 9;
            // 
            // distanceTxt
            // 
            this.distanceTxt.Location = new System.Drawing.Point(192, 129);
            this.distanceTxt.Name = "distanceTxt";
            this.distanceTxt.Size = new System.Drawing.Size(100, 20);
            this.distanceTxt.TabIndex = 10;
            // 
            // daysTxt
            // 
            this.daysTxt.Location = new System.Drawing.Point(192, 180);
            this.daysTxt.Name = "daysTxt";
            this.daysTxt.Size = new System.Drawing.Size(100, 20);
            this.daysTxt.TabIndex = 11;
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.Location = new System.Drawing.Point(103, 262);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(107, 23);
            this.calculateCostButton.TabIndex = 12;
            this.calculateCostButton.Text = "Calculate Cost";
            this.calculateCostButton.UseVisualStyleBackColor = true;
            this.calculateCostButton.Click += new System.EventHandler(this.CalculateCostButton_Click);
            // 
            // decisionOutputLbl
            // 
            this.decisionOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionOutputLbl.Location = new System.Drawing.Point(52, 192);
            this.decisionOutputLbl.Name = "decisionOutputLbl";
            this.decisionOutputLbl.Size = new System.Drawing.Size(190, 21);
            this.decisionOutputLbl.TabIndex = 13;
            this.decisionOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.decisionOutputLbl);
            this.resultsBox.Controls.Add(this.companyALbl);
            this.resultsBox.Controls.Add(this.companyAOutputLbl);
            this.resultsBox.Controls.Add(this.companyBLbl);
            this.resultsBox.Controls.Add(this.companyBOutputLbl);
            this.resultsBox.Controls.Add(this.companyCLbl);
            this.resultsBox.Controls.Add(this.companyCOutputLbl);
            this.resultsBox.Location = new System.Drawing.Point(362, 24);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(294, 280);
            this.resultsBox.TabIndex = 15;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results";
            // 
            // calculatorForm
            // 
            this.AcceptButton = this.calculateCostButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 373);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.daysTxt);
            this.Controls.Add(this.distanceTxt);
            this.Controls.Add(this.peopleTxt);
            this.Controls.Add(this.daysLbl);
            this.Controls.Add(this.distanceLbl);
            this.Controls.Add(this.peopleLbl);
            this.Name = "calculatorForm";
            this.Text = "Food Delivery Cost Calculation";
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleLbl;
        private System.Windows.Forms.Label distanceLbl;
        private System.Windows.Forms.Label daysLbl;
        private System.Windows.Forms.Label companyALbl;
        private System.Windows.Forms.Label companyAOutputLbl;
        private System.Windows.Forms.Label companyBOutputLbl;
        private System.Windows.Forms.Label companyBLbl;
        private System.Windows.Forms.Label companyCOutputLbl;
        private System.Windows.Forms.Label companyCLbl;
        private System.Windows.Forms.TextBox peopleTxt;
        private System.Windows.Forms.TextBox distanceTxt;
        private System.Windows.Forms.TextBox daysTxt;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.Label decisionOutputLbl;
        private System.Windows.Forms.GroupBox resultsBox;
    }
}

