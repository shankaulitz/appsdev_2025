namespace SimpleFormsAppWithCheckedListBox
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
            checkedListBox = new CheckedListBox();
            listBox = new ListBox();
            addBtn = new Button();
            dltBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            clrBtn = new Button();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.FromArgb(255, 224, 192);
            checkedListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox.ForeColor = Color.Crimson;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(115, 146);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(299, 352);
            checkedListBox.TabIndex = 0;
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(255, 224, 192);
            listBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.ForeColor = Color.Crimson;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 28;
            listBox.Location = new Point(624, 151);
            listBox.Name = "listBox";
            listBox.Size = new Size(302, 340);
            listBox.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(255, 224, 192);
            addBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.Crimson;
            addBtn.Location = new Point(115, 508);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(148, 45);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dltBtn
            // 
            dltBtn.BackColor = Color.FromArgb(255, 224, 192);
            dltBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dltBtn.ForeColor = Color.Crimson;
            dltBtn.Location = new Point(624, 508);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(148, 45);
            dltBtn.TabIndex = 3;
            dltBtn.Text = "Delete";
            dltBtn.UseVisualStyleBackColor = false;
            dltBtn.Click += dltBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Broadway", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(197, 27);
            label1.Name = "label1";
            label1.Size = new Size(637, 42);
            label1.TabIndex = 5;
            label1.Text = "My Favorite Movie Picker App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(115, 110);
            label2.Name = "label2";
            label2.Size = new Size(196, 23);
            label2.TabIndex = 6;
            label2.Text = "Movies / Series List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 224, 192);
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(625, 113);
            label3.Name = "label3";
            label3.Size = new Size(229, 23);
            label3.TabIndex = 7;
            label3.Text = "My Movies / Series List";
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.FromArgb(255, 224, 192);
            clrBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            clrBtn.ForeColor = Color.Crimson;
            clrBtn.Location = new Point(778, 508);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(148, 45);
            clrBtn.TabIndex = 8;
            clrBtn.Text = "Clear All";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.movie10;
            ClientSize = new Size(1028, 603);
            Controls.Add(clrBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dltBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox);
            Controls.Add(checkedListBox);
            Cursor = Cursors.Hand;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Button addBtn;
        private Button dltBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button clrBtn;
    }
}
