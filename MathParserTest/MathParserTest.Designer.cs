namespace MathParserTestNS
{
    partial class MathParserTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathParserTest));
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoWordSelection = true;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(15, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(828, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "x^xv!x→x~x⊕x|x↓y";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 415);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(831, 39);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(365, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.Location = new System.Drawing.Point(15, 157);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(828, 252);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(243, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "^";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.insert_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(285, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "v";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.insert_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(327, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.insert_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(369, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "→";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.insert_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(411, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "↔";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.insert_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(453, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "⊕";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.insert_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(495, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 32);
            this.button8.TabIndex = 7;
            this.button8.Text = "|";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.insert_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(537, 59);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 32);
            this.button9.TabIndex = 7;
            this.button9.Text = "↓";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.insert_Click);
            // 
            // MathParserTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(856, 466);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "MathParserTest";
            this.Text = "info.lundin.math - Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

