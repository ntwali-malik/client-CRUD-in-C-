namespace ClientCRUD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            fnameTxt = new TextBox();
            lnameTxt = new TextBox();
            phoneTxt = new TextBox();
            addressTxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            idTxt = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 20);
            label1.Name = "label1";
            label1.Size = new Size(208, 42);
            label1.TabIndex = 1;
            label1.Text = "Client APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(35, 114);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Location = new Point(35, 178);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "Phone  Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.Location = new Point(36, 215);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // fnameTxt
            // 
            fnameTxt.Location = new Point(204, 106);
            fnameTxt.Name = "fnameTxt";
            fnameTxt.Size = new Size(174, 23);
            fnameTxt.TabIndex = 6;
            // 
            // lnameTxt
            // 
            lnameTxt.Location = new Point(204, 140);
            lnameTxt.Name = "lnameTxt";
            lnameTxt.Size = new Size(174, 23);
            lnameTxt.TabIndex = 7;
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(204, 170);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(174, 23);
            phoneTxt.TabIndex = 8;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(204, 207);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(174, 23);
            addressTxt.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(450, 68);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 10;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(450, 120);
            button2.Name = "button2";
            button2.Size = new Size(130, 46);
            button2.TabIndex = 11;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(450, 178);
            button3.Name = "button3";
            button3.Size = new Size(130, 46);
            button3.TabIndex = 12;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.AppWorkspace;
            label6.Location = new Point(36, 76);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 13;
            label6.Text = "ID";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(204, 68);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(174, 23);
            idTxt.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(36, 257);
            button4.Name = "button4";
            button4.Size = new Size(130, 46);
            button4.TabIndex = 15;
            button4.Text = "SEARCH";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 331);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(478, 150);
            dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 493);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(idTxt);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(addressTxt);
            Controls.Add(phoneTxt);
            Controls.Add(lnameTxt);
            Controls.Add(fnameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Client App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox fnameTxt;
        private TextBox lnameTxt;
        private TextBox phoneTxt;
        private TextBox addressTxt;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private TextBox idTxt;
        private Button button4;
        private DataGridView dataGridView1;
    }
}
