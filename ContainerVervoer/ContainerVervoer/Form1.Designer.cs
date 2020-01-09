namespace ContainerVervoer
{
    partial class Form
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
            this.lBContainers = new System.Windows.Forms.ListBox();
            this.lContainers = new System.Windows.Forms.Label();
            this.cBLoadType = new System.Windows.Forms.ComboBox();
            this.bAddContainer = new System.Windows.Forms.Button();
            this.nUDContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDShipLength = new System.Windows.Forms.NumericUpDown();
            this.nUDShipWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bSortShip = new System.Windows.Forms.Button();
            this.lErrorMessage = new System.Windows.Forms.Label();
            this.bDeleteContainer = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.tBMaxWeight = new System.Windows.Forms.TextBox();
            this.tBUrl = new System.Windows.Forms.TextBox();
            this.tBTotalWeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDContainerWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDShipLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDShipWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lBContainers
            // 
            this.lBContainers.FormattingEnabled = true;
            this.lBContainers.Location = new System.Drawing.Point(42, 49);
            this.lBContainers.Name = "lBContainers";
            this.lBContainers.Size = new System.Drawing.Size(167, 160);
            this.lBContainers.TabIndex = 0;
            // 
            // lContainers
            // 
            this.lContainers.AutoSize = true;
            this.lContainers.Location = new System.Drawing.Point(42, 33);
            this.lContainers.Name = "lContainers";
            this.lContainers.Size = new System.Drawing.Size(57, 13);
            this.lContainers.TabIndex = 1;
            this.lContainers.Text = "Containers";
            // 
            // cBLoadType
            // 
            this.cBLoadType.FormattingEnabled = true;
            this.cBLoadType.Items.AddRange(new object[] {
            "Normal",
            "Cooled",
            "Valuable"});
            this.cBLoadType.Location = new System.Drawing.Point(88, 299);
            this.cBLoadType.Name = "cBLoadType";
            this.cBLoadType.Size = new System.Drawing.Size(121, 21);
            this.cBLoadType.TabIndex = 4;
            // 
            // bAddContainer
            // 
            this.bAddContainer.Location = new System.Drawing.Point(42, 326);
            this.bAddContainer.Name = "bAddContainer";
            this.bAddContainer.Size = new System.Drawing.Size(167, 23);
            this.bAddContainer.TabIndex = 5;
            this.bAddContainer.Text = "Add Container";
            this.bAddContainer.UseVisualStyleBackColor = true;
            this.bAddContainer.Click += new System.EventHandler(this.bAddContainer_Click);
            // 
            // nUDContainerWeight
            // 
            this.nUDContainerWeight.Location = new System.Drawing.Point(89, 272);
            this.nUDContainerWeight.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUDContainerWeight.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDContainerWeight.Name = "nUDContainerWeight";
            this.nUDContainerWeight.Size = new System.Drawing.Size(120, 20);
            this.nUDContainerWeight.TabIndex = 6;
            this.nUDContainerWeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Load";
            // 
            // nUDShipLength
            // 
            this.nUDShipLength.Location = new System.Drawing.Point(351, 49);
            this.nUDShipLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDShipLength.Name = "nUDShipLength";
            this.nUDShipLength.Size = new System.Drawing.Size(120, 20);
            this.nUDShipLength.TabIndex = 9;
            this.nUDShipLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDShipLength.ValueChanged += new System.EventHandler(this.nUDShipLength_ValueChanged);
            // 
            // nUDShipWidth
            // 
            this.nUDShipWidth.Location = new System.Drawing.Point(351, 75);
            this.nUDShipWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDShipWidth.Name = "nUDShipWidth";
            this.nUDShipWidth.Size = new System.Drawing.Size(120, 20);
            this.nUDShipWidth.TabIndex = 10;
            this.nUDShipWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDShipWidth.ValueChanged += new System.EventHandler(this.nUDShipWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ship";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max Weight";
            // 
            // bSortShip
            // 
            this.bSortShip.Location = new System.Drawing.Point(287, 170);
            this.bSortShip.Name = "bSortShip";
            this.bSortShip.Size = new System.Drawing.Size(184, 122);
            this.bSortShip.TabIndex = 16;
            this.bSortShip.Text = "Sort Ship";
            this.bSortShip.UseVisualStyleBackColor = true;
            this.bSortShip.Click += new System.EventHandler(this.bSortShip_Click);
            // 
            // lErrorMessage
            // 
            this.lErrorMessage.AutoSize = true;
            this.lErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lErrorMessage.Location = new System.Drawing.Point(42, 299);
            this.lErrorMessage.Name = "lErrorMessage";
            this.lErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lErrorMessage.TabIndex = 17;
            // 
            // bDeleteContainer
            // 
            this.bDeleteContainer.Location = new System.Drawing.Point(42, 220);
            this.bDeleteContainer.Name = "bDeleteContainer";
            this.bDeleteContainer.Size = new System.Drawing.Size(167, 23);
            this.bDeleteContainer.TabIndex = 18;
            this.bDeleteContainer.Text = "Delete Container";
            this.bDeleteContainer.UseVisualStyleBackColor = true;
            this.bDeleteContainer.Click += new System.EventHandler(this.bDeleteContainer_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(287, 301);
            this.ErrorMessage.MaximumSize = new System.Drawing.Size(0, 122);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(72, 13);
            this.ErrorMessage.TabIndex = 19;
            this.ErrorMessage.Text = "ErrorMessage";
            // 
            // tBMaxWeight
            // 
            this.tBMaxWeight.Location = new System.Drawing.Point(351, 100);
            this.tBMaxWeight.Name = "tBMaxWeight";
            this.tBMaxWeight.ReadOnly = true;
            this.tBMaxWeight.Size = new System.Drawing.Size(120, 20);
            this.tBMaxWeight.TabIndex = 20;
            // 
            // tBUrl
            // 
            this.tBUrl.Location = new System.Drawing.Point(290, 326);
            this.tBUrl.Name = "tBUrl";
            this.tBUrl.ReadOnly = true;
            this.tBUrl.Size = new System.Drawing.Size(181, 20);
            this.tBUrl.TabIndex = 21;
            // 
            // tBTotalWeight
            // 
            this.tBTotalWeight.Location = new System.Drawing.Point(42, 246);
            this.tBTotalWeight.Name = "tBTotalWeight";
            this.tBTotalWeight.ReadOnly = true;
            this.tBTotalWeight.Size = new System.Drawing.Size(120, 20);
            this.tBTotalWeight.TabIndex = 22;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 375);
            this.Controls.Add(this.tBTotalWeight);
            this.Controls.Add(this.tBUrl);
            this.Controls.Add(this.tBMaxWeight);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.bDeleteContainer);
            this.Controls.Add(this.lErrorMessage);
            this.Controls.Add(this.bSortShip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDShipWidth);
            this.Controls.Add(this.nUDShipLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDContainerWeight);
            this.Controls.Add(this.bAddContainer);
            this.Controls.Add(this.cBLoadType);
            this.Controls.Add(this.lContainers);
            this.Controls.Add(this.lBContainers);
            this.Name = "Form";
            this.Text = "Container Sorter";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDContainerWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDShipLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDShipWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBContainers;
        private System.Windows.Forms.Label lContainers;
        private System.Windows.Forms.ComboBox cBLoadType;
        private System.Windows.Forms.Button bAddContainer;
        private System.Windows.Forms.NumericUpDown nUDContainerWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDShipLength;
        private System.Windows.Forms.NumericUpDown nUDShipWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bSortShip;
        private System.Windows.Forms.Label lErrorMessage;
        private System.Windows.Forms.Button bDeleteContainer;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.TextBox tBMaxWeight;
        private System.Windows.Forms.TextBox tBUrl;
        private System.Windows.Forms.TextBox tBTotalWeight;
    }
}

