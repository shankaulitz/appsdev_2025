namespace SimpleFormsAppWithListBox
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
            addBtn_Click = new Button();
            rmvBtn_Click = new Button();
            clrBtn_Click = new Button();
            textBox = new TextBox();
            listBox = new ListBox();
            label = new Label();
            SuspendLayout();
            // 
            // addBtn_Click
            // 
            addBtn_Click.Font = new Font("Engravers MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn_Click.Location = new Point(227, 164);
            addBtn_Click.Name = "addBtn_Click";
            addBtn_Click.Size = new Size(249, 29);
            addBtn_Click.TabIndex = 0;
            addBtn_Click.Text = "Add";
            addBtn_Click.UseVisualStyleBackColor = true;
            addBtn_Click.Click += addBtn_Click_Click;
            // 
            // rmvBtn_Click
            // 
            rmvBtn_Click.Font = new Font("Engravers MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rmvBtn_Click.Location = new Point(227, 226);
            rmvBtn_Click.Name = "rmvBtn_Click";
            rmvBtn_Click.Size = new Size(249, 29);
            rmvBtn_Click.TabIndex = 1;
            rmvBtn_Click.Text = "Remove";
            rmvBtn_Click.UseVisualStyleBackColor = true;
            rmvBtn_Click.Click += rmvBtn_Click_Click;
            // 
            // clrBtn_Click
            // 
            clrBtn_Click.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn_Click.Location = new Point(227, 285);
            clrBtn_Click.Name = "clrBtn_Click";
            clrBtn_Click.Size = new Size(249, 29);
            clrBtn_Click.TabIndex = 2;
            clrBtn_Click.Text = "Clear";
            clrBtn_Click.UseVisualStyleBackColor = true;
            clrBtn_Click.Click += clrBtn_Click_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Engravers MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.Location = new Point(227, 104);
            textBox.Name = "textBox";
            textBox.Size = new Size(249, 27);
            textBox.TabIndex = 3;
            // 
            // listBox
            // 
            listBox.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 23;
            listBox.Location = new Point(44, 104);
            listBox.Name = "listBox";
            listBox.Size = new Size(150, 211);
            listBox.TabIndex = 4;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(53, 46);
            label.Name = "label";
            label.Size = new Size(319, 24);
            label.TabIndex = 5;
            label.Text = "Simple Name Viewer\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(listBox);
            Controls.Add(textBox);
            Controls.Add(clrBtn_Click);
            Controls.Add(rmvBtn_Click);
            Controls.Add(addBtn_Click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn_Click;
        private Button rmvBtn_Click;
        private Button clrBtn_Click;
        private TextBox textBox;
        private ListBox listBox;
        private Label label;
    }
}
