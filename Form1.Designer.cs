namespace Activity_14
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
            this.ShapeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FillButton = new System.Windows.Forms.RadioButton();
            this.OutlineButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SidesCheckbox = new System.Windows.Forms.CheckBox();
            this.NamesCheckbox = new System.Windows.Forms.CheckBox();
            this.SquareOutImage = new System.Windows.Forms.PictureBox();
            this.SidesLabel = new System.Windows.Forms.Label();
            this.NamesLabel = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SquareFillImage = new System.Windows.Forms.PictureBox();
            this.TriangleOutImage = new System.Windows.Forms.PictureBox();
            this.TriangleFillImage = new System.Windows.Forms.PictureBox();
            this.PentagonOutImage = new System.Windows.Forms.PictureBox();
            this.PentagonFillImage = new System.Windows.Forms.PictureBox();
            this.SidesDesLabel = new System.Windows.Forms.Label();
            this.NameDesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquareOutImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareFillImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleOutImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleFillImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PentagonOutImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PentagonFillImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapeListBox
            // 
            this.ShapeListBox.FormattingEnabled = true;
            this.ShapeListBox.ItemHeight = 25;
            this.ShapeListBox.Items.AddRange(new object[] {
            "Triangle",
            "Square",
            "Pentagon"});
            this.ShapeListBox.Location = new System.Drawing.Point(48, 60);
            this.ShapeListBox.Name = "ShapeListBox";
            this.ShapeListBox.Size = new System.Drawing.Size(170, 154);
            this.ShapeListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Shape:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutlineButton);
            this.groupBox1.Controls.Add(this.FillButton);
            this.groupBox1.Location = new System.Drawing.Point(48, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Fill Mode";
            // 
            // FillButton
            // 
            this.FillButton.AutoSize = true;
            this.FillButton.BackColor = System.Drawing.SystemColors.Control;
            this.FillButton.Location = new System.Drawing.Point(6, 49);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(71, 29);
            this.FillButton.TabIndex = 3;
            this.FillButton.TabStop = true;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = false;
            // 
            // OutlineButton
            // 
            this.OutlineButton.AutoSize = true;
            this.OutlineButton.Location = new System.Drawing.Point(6, 85);
            this.OutlineButton.Name = "OutlineButton";
            this.OutlineButton.Size = new System.Drawing.Size(111, 29);
            this.OutlineButton.TabIndex = 3;
            this.OutlineButton.TabStop = true;
            this.OutlineButton.Text = "Outline";
            this.OutlineButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NamesCheckbox);
            this.groupBox2.Controls.Add(this.SidesCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(54, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Details";
            // 
            // SidesCheckbox
            // 
            this.SidesCheckbox.AutoSize = true;
            this.SidesCheckbox.Location = new System.Drawing.Point(14, 30);
            this.SidesCheckbox.Name = "SidesCheckbox";
            this.SidesCheckbox.Size = new System.Drawing.Size(98, 29);
            this.SidesCheckbox.TabIndex = 4;
            this.SidesCheckbox.Text = "Sides";
            this.SidesCheckbox.UseVisualStyleBackColor = true;
            // 
            // NamesCheckbox
            // 
            this.NamesCheckbox.AutoSize = true;
            this.NamesCheckbox.Location = new System.Drawing.Point(14, 79);
            this.NamesCheckbox.Name = "NamesCheckbox";
            this.NamesCheckbox.Size = new System.Drawing.Size(100, 29);
            this.NamesCheckbox.TabIndex = 5;
            this.NamesCheckbox.Text = "Name";
            this.NamesCheckbox.UseVisualStyleBackColor = true;
            // 
            // SquareOutImage
            // 
            this.SquareOutImage.Image = global::Activity_14.Properties.Resources.squareOut;
            this.SquareOutImage.Location = new System.Drawing.Point(410, 72);
            this.SquareOutImage.Name = "SquareOutImage";
            this.SquareOutImage.Size = new System.Drawing.Size(278, 274);
            this.SquareOutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SquareOutImage.TabIndex = 6;
            this.SquareOutImage.TabStop = false;
            this.SquareOutImage.Visible = false;
            // 
            // SidesLabel
            // 
            this.SidesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidesLabel.Location = new System.Drawing.Point(467, 376);
            this.SidesLabel.Name = "SidesLabel";
            this.SidesLabel.Size = new System.Drawing.Size(221, 32);
            this.SidesLabel.TabIndex = 7;
            // 
            // NamesLabel
            // 
            this.NamesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamesLabel.Location = new System.Drawing.Point(467, 430);
            this.NamesLabel.Name = "NamesLabel";
            this.NamesLabel.Size = new System.Drawing.Size(221, 33);
            this.NamesLabel.TabIndex = 8;
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DrawButton.Location = new System.Drawing.Point(377, 478);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(152, 56);
            this.DrawButton.TabIndex = 9;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Location = new System.Drawing.Point(556, 478);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(152, 56);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SquareFillImage
            // 
            this.SquareFillImage.Image = global::Activity_14.Properties.Resources.squareFill;
            this.SquareFillImage.Location = new System.Drawing.Point(410, 72);
            this.SquareFillImage.Name = "SquareFillImage";
            this.SquareFillImage.Size = new System.Drawing.Size(278, 274);
            this.SquareFillImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SquareFillImage.TabIndex = 11;
            this.SquareFillImage.TabStop = false;
            this.SquareFillImage.Visible = false;
            // 
            // TriangleOutImage
            // 
            this.TriangleOutImage.Image = global::Activity_14.Properties.Resources.triangleOut;
            this.TriangleOutImage.Location = new System.Drawing.Point(410, 72);
            this.TriangleOutImage.Name = "TriangleOutImage";
            this.TriangleOutImage.Size = new System.Drawing.Size(278, 274);
            this.TriangleOutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TriangleOutImage.TabIndex = 12;
            this.TriangleOutImage.TabStop = false;
            this.TriangleOutImage.Visible = false;
            // 
            // TriangleFillImage
            // 
            this.TriangleFillImage.Image = global::Activity_14.Properties.Resources.triangleFill;
            this.TriangleFillImage.Location = new System.Drawing.Point(410, 72);
            this.TriangleFillImage.Name = "TriangleFillImage";
            this.TriangleFillImage.Size = new System.Drawing.Size(278, 274);
            this.TriangleFillImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TriangleFillImage.TabIndex = 13;
            this.TriangleFillImage.TabStop = false;
            this.TriangleFillImage.Visible = false;
            // 
            // PentagonOutImage
            // 
            this.PentagonOutImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PentagonOutImage.Image = global::Activity_14.Properties.Resources.pentagonOut;
            this.PentagonOutImage.Location = new System.Drawing.Point(410, 72);
            this.PentagonOutImage.Name = "PentagonOutImage";
            this.PentagonOutImage.Size = new System.Drawing.Size(278, 274);
            this.PentagonOutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PentagonOutImage.TabIndex = 14;
            this.PentagonOutImage.TabStop = false;
            this.PentagonOutImage.Visible = false;
            // 
            // PentagonFillImage
            // 
            this.PentagonFillImage.Image = global::Activity_14.Properties.Resources.pentagonFill;
            this.PentagonFillImage.Location = new System.Drawing.Point(410, 72);
            this.PentagonFillImage.Name = "PentagonFillImage";
            this.PentagonFillImage.Size = new System.Drawing.Size(278, 274);
            this.PentagonFillImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PentagonFillImage.TabIndex = 15;
            this.PentagonFillImage.TabStop = false;
            this.PentagonFillImage.Visible = false;
            // 
            // SidesDesLabel
            // 
            this.SidesDesLabel.Location = new System.Drawing.Point(372, 376);
            this.SidesDesLabel.Name = "SidesDesLabel";
            this.SidesDesLabel.Size = new System.Drawing.Size(89, 32);
            this.SidesDesLabel.TabIndex = 16;
            this.SidesDesLabel.Text = "Sides:";
            // 
            // NameDesLabel
            // 
            this.NameDesLabel.Location = new System.Drawing.Point(372, 430);
            this.NameDesLabel.Name = "NameDesLabel";
            this.NameDesLabel.Size = new System.Drawing.Size(89, 32);
            this.NameDesLabel.TabIndex = 17;
            this.NameDesLabel.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 564);
            this.Controls.Add(this.NameDesLabel);
            this.Controls.Add(this.SidesDesLabel);
            this.Controls.Add(this.PentagonFillImage);
            this.Controls.Add(this.PentagonOutImage);
            this.Controls.Add(this.TriangleFillImage);
            this.Controls.Add(this.TriangleOutImage);
            this.Controls.Add(this.SquareFillImage);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.NamesLabel);
            this.Controls.Add(this.SidesLabel);
            this.Controls.Add(this.SquareOutImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShapeListBox);
            this.Name = "Form1";
            this.Text = "Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquareOutImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareFillImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleOutImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleFillImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PentagonOutImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PentagonFillImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShapeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OutlineButton;
        private System.Windows.Forms.RadioButton FillButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox NamesCheckbox;
        private System.Windows.Forms.CheckBox SidesCheckbox;
        private System.Windows.Forms.Label SidesLabel;
        private System.Windows.Forms.Label NamesLabel;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.PictureBox SquareOutImage;
        public System.Windows.Forms.PictureBox SquareFillImage;
        public System.Windows.Forms.PictureBox TriangleOutImage;
        public System.Windows.Forms.PictureBox TriangleFillImage;
        public System.Windows.Forms.PictureBox PentagonOutImage;
        public System.Windows.Forms.PictureBox PentagonFillImage;
        private System.Windows.Forms.Label SidesDesLabel;
        private System.Windows.Forms.Label NameDesLabel;
    }
}

