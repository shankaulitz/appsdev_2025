namespace SimpleFormsAppWithComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            listBox = new ListBox();
            comboBox = new ComboBox();
            addBtn_Click = new Button();
            checkedListBox = new CheckedListBox();
            removeBtn_Click = new Button();
            clrBtn_Click = new Button();
            slctBtn_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Script MT Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(363, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 40);
            textBox1.TabIndex = 0;
            textBox1.Text = "Favorite Food Picker App";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(345, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 52);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listBox
            // 
            listBox.BackColor = Color.PaleTurquoise;
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(536, 133);
            listBox.Name = "listBox";
            listBox.Size = new Size(150, 184);
            listBox.TabIndex = 2;
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.LightCoral;
            comboBox.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(73, 133);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 3;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // addBtn_Click
            // 
            addBtn_Click.BackColor = Color.PaleVioletRed;
            addBtn_Click.Font = new Font("Magneto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn_Click.Location = new Point(312, 354);
            addBtn_Click.Name = "addBtn_Click";
            addBtn_Click.Size = new Size(151, 29);
            addBtn_Click.TabIndex = 4;
            addBtn_Click.Text = "ADD";
            addBtn_Click.UseVisualStyleBackColor = false;
            addBtn_Click.Click += addBtn_CLick_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.PaleTurquoise;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(313, 133);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(150, 180);
            checkedListBox.TabIndex = 5;
            checkedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // removeBtn_Click
            // 
            removeBtn_Click.BackColor = Color.LightPink;
            removeBtn_Click.Font = new Font("Modern No. 20", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeBtn_Click.Location = new Point(769, 133);
            removeBtn_Click.Name = "removeBtn_Click";
            removeBtn_Click.Size = new Size(133, 29);
            removeBtn_Click.TabIndex = 6;
            removeBtn_Click.Text = "REMOVE";
            removeBtn_Click.UseVisualStyleBackColor = false;
            removeBtn_Click.Click += rmvBtn_Click;
            // 
            // clrBtn_Click
            // 
            clrBtn_Click.BackColor = Color.LightPink;
            clrBtn_Click.Font = new Font("Modern No. 20", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn_Click.Location = new Point(769, 208);
            clrBtn_Click.Name = "clrBtn_Click";
            clrBtn_Click.Size = new Size(133, 29);
            clrBtn_Click.TabIndex = 7;
            clrBtn_Click.Text = "CLEAR ALL";
            clrBtn_Click.UseVisualStyleBackColor = false;
            clrBtn_Click.Click += button3_Click;
            // 
            // slctBtn_Click
            // 
            slctBtn_Click.BackColor = Color.LightCoral;
            slctBtn_Click.ForeColor = Color.Black;
            slctBtn_Click.Location = new Point(73, 226);
            slctBtn_Click.Name = "slctBtn_Click";
            slctBtn_Click.Size = new Size(151, 29);
            slctBtn_Click.TabIndex = 8;
            slctBtn_Click.Text = "SELECT";
            slctBtn_Click.UseVisualStyleBackColor = false;
            slctBtn_Click.Click += slctBtn_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 501);
            Controls.Add(slctBtn_Click);
            Controls.Add(clrBtn_Click);
            Controls.Add(removeBtn_Click);
            Controls.Add(checkedListBox);
            Controls.Add(addBtn_Click);
            Controls.Add(comboBox);
            Controls.Add(listBox);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ListBox listBox;
        private ComboBox comboBox;
        private Button addBtn_Click;
        private CheckedListBox checkedListBox;
        private Button removeBtn_Click;
        private Button clrBtn_Click;
        private Button slctBtn_Click;
    }
}
