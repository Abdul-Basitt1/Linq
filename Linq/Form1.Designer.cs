namespace Linq
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nameuser = new System.Windows.Forms.TextBox();
            this.startalpha = new System.Windows.Forms.TextBox();
            this.numofalpha = new System.Windows.Forms.TextBox();
            this.specificalpha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultt = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search through starting Alphabet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search based on no. of alphabet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search specific alphabet Names";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchname);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.search_startingalphabet);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.search_throughlength);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.search_specificalphabet);
            // 
            // nameuser
            // 
            this.nameuser.Location = new System.Drawing.Point(362, 126);
            this.nameuser.Name = "nameuser";
            this.nameuser.Size = new System.Drawing.Size(100, 22);
            this.nameuser.TabIndex = 8;
            // 
            // startalpha
            // 
            this.startalpha.Location = new System.Drawing.Point(362, 159);
            this.startalpha.Name = "startalpha";
            this.startalpha.Size = new System.Drawing.Size(100, 22);
            this.startalpha.TabIndex = 9;
            // 
            // numofalpha
            // 
            this.numofalpha.Location = new System.Drawing.Point(362, 198);
            this.numofalpha.Name = "numofalpha";
            this.numofalpha.Size = new System.Drawing.Size(100, 22);
            this.numofalpha.TabIndex = 10;
            // 
            // specificalpha
            // 
            this.specificalpha.Location = new System.Drawing.Point(362, 230);
            this.specificalpha.Name = "specificalpha";
            this.specificalpha.Size = new System.Drawing.Size(100, 22);
            this.specificalpha.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "RESULT";
            // 
            // resultt
            // 
            this.resultt.AutoSize = true;
            this.resultt.Location = new System.Drawing.Point(399, 318);
            this.resultt.Name = "resultt";
            this.resultt.Size = new System.Drawing.Size(29, 16);
            this.resultt.TabIndex = 13;
            this.resultt.Text = "ans";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Sort";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.sort_Arr);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search Student Record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.resultt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.specificalpha);
            this.Controls.Add(this.numofalpha);
            this.Controls.Add(this.startalpha);
            this.Controls.Add(this.nameuser);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox nameuser;
        private System.Windows.Forms.TextBox startalpha;
        private System.Windows.Forms.TextBox numofalpha;
        private System.Windows.Forms.TextBox specificalpha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
    }
}

