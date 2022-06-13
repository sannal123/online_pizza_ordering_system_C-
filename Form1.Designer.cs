namespace OnlinePizzaThirstSatisfied
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
            this.rdodinein = new System.Windows.Forms.RadioButton();
            this.rdohomedelivery = new System.Windows.Forms.RadioButton();
            this.rdoparcel = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxflavour = new System.Windows.Forms.ComboBox();
            this.rdosmall = new System.Windows.Forms.RadioButton();
            this.rdomedium = new System.Windows.Forms.RadioButton();
            this.rdolarge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkextracheese = new System.Windows.Forms.CheckBox();
            this.chkolive = new System.Windows.Forms.CheckBox();
            this.chkjalapeno = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnorder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // rdodinein
            // 
            this.rdodinein.AutoSize = true;
            this.rdodinein.Checked = true;
            this.rdodinein.Location = new System.Drawing.Point(18, 37);
            this.rdodinein.Name = "rdodinein";
            this.rdodinein.Size = new System.Drawing.Size(66, 19);
            this.rdodinein.TabIndex = 1;
            this.rdodinein.TabStop = true;
            this.rdodinein.Text = "DINE IN";
            this.rdodinein.UseVisualStyleBackColor = true;
            // 
            // rdohomedelivery
            // 
            this.rdohomedelivery.AutoSize = true;
            this.rdohomedelivery.Location = new System.Drawing.Point(128, 37);
            this.rdohomedelivery.Name = "rdohomedelivery";
            this.rdohomedelivery.Size = new System.Drawing.Size(113, 19);
            this.rdohomedelivery.TabIndex = 2;
            this.rdohomedelivery.TabStop = true;
            this.rdohomedelivery.Text = "HOME DELIVERY";
            this.rdohomedelivery.UseVisualStyleBackColor = true;
            // 
            // rdoparcel
            // 
            this.rdoparcel.AutoSize = true;
            this.rdoparcel.Location = new System.Drawing.Point(284, 37);
            this.rdoparcel.Name = "rdoparcel";
            this.rdoparcel.Size = new System.Drawing.Size(66, 19);
            this.rdoparcel.TabIndex = 3;
            this.rdoparcel.TabStop = true;
            this.rdoparcel.Text = "PARCEL";
            this.rdoparcel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "FLAVOUR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxflavour
            // 
            this.cbxflavour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxflavour.FormattingEnabled = true;
            this.cbxflavour.Items.AddRange(new object[] {
            "Chicken Tikka",
            "Fajita",
            "Mushroom",
            "Veg Pizza",
            "Multan Extreme"});
            this.cbxflavour.Location = new System.Drawing.Point(528, 150);
            this.cbxflavour.Name = "cbxflavour";
            this.cbxflavour.Size = new System.Drawing.Size(121, 23);
            this.cbxflavour.TabIndex = 5;
            // 
            // rdosmall
            // 
            this.rdosmall.AutoSize = true;
            this.rdosmall.Checked = true;
            this.rdosmall.Location = new System.Drawing.Point(95, 24);
            this.rdosmall.Name = "rdosmall";
            this.rdosmall.Size = new System.Drawing.Size(62, 19);
            this.rdosmall.TabIndex = 7;
            this.rdosmall.TabStop = true;
            this.rdosmall.Text = "SMALL";
            this.rdosmall.UseVisualStyleBackColor = true;
            // 
            // rdomedium
            // 
            this.rdomedium.AutoSize = true;
            this.rdomedium.Location = new System.Drawing.Point(178, 22);
            this.rdomedium.Name = "rdomedium";
            this.rdomedium.Size = new System.Drawing.Size(72, 19);
            this.rdomedium.TabIndex = 8;
            this.rdomedium.TabStop = true;
            this.rdomedium.Text = "MEDIUM";
            this.rdomedium.UseVisualStyleBackColor = true;
            // 
            // rdolarge
            // 
            this.rdolarge.AutoSize = true;
            this.rdolarge.Location = new System.Drawing.Point(269, 24);
            this.rdolarge.Name = "rdolarge";
            this.rdolarge.Size = new System.Drawing.Size(60, 19);
            this.rdolarge.TabIndex = 9;
            this.rdolarge.TabStop = true;
            this.rdolarge.Text = "LARGE";
            this.rdolarge.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdodinein);
            this.groupBox1.Controls.Add(this.rdohomedelivery);
            this.groupBox1.Controls.Add(this.rdoparcel);
            this.groupBox1.Location = new System.Drawing.Point(438, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ORDER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdomedium);
            this.groupBox2.Controls.Add(this.rdosmall);
            this.groupBox2.Controls.Add(this.rdolarge);
            this.groupBox2.Location = new System.Drawing.Point(438, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 61);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SIZE : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "EXTRAs";
            // 
            // chkextracheese
            // 
            this.chkextracheese.AutoSize = true;
            this.chkextracheese.Location = new System.Drawing.Point(438, 293);
            this.chkextracheese.Name = "chkextracheese";
            this.chkextracheese.Size = new System.Drawing.Size(64, 19);
            this.chkextracheese.TabIndex = 13;
            this.chkextracheese.Text = "Cheese";
            this.chkextracheese.UseVisualStyleBackColor = true;
            // 
            // chkolive
            // 
            this.chkolive.AutoSize = true;
            this.chkolive.Location = new System.Drawing.Point(563, 293);
            this.chkolive.Name = "chkolive";
            this.chkolive.Size = new System.Drawing.Size(84, 19);
            this.chkolive.TabIndex = 19;
            this.chkolive.Text = "Black Olive";
            this.chkolive.UseVisualStyleBackColor = true;
            // 
            // chkjalapeno
            // 
            this.chkjalapeno.AutoSize = true;
            this.chkjalapeno.Location = new System.Drawing.Point(702, 293);
            this.chkjalapeno.Name = "chkjalapeno";
            this.chkjalapeno.Size = new System.Drawing.Size(72, 19);
            this.chkjalapeno.TabIndex = 20;
            this.chkjalapeno.Text = "Jalapeno";
            this.chkjalapeno.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "QUANTITY :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(438, 386);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(185, 23);
            this.numericUpDown.TabIndex = 22;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(517, 444);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(250, 49);
            this.btnorder.TabIndex = 23;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 541);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkjalapeno);
            this.Controls.Add(this.chkolive);
            this.Controls.Add(this.chkextracheese);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxflavour);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Online Pizza Thirst Satisfied";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton rdodinein;
        private RadioButton rdohomedelivery;
        private RadioButton rdoparcel;
        private Label label2;
        private ComboBox cbxflavour;
        private RadioButton rdosmall;
        private RadioButton rdomedium;
        private RadioButton rdolarge;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private CheckBox chkextracheese;
        private CheckBox chkolive;
        private CheckBox chkjalapeno;
        private Label label3;
        private NumericUpDown numericUpDown;
        private Button btnorder;
    }
}