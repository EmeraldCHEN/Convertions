namespace Letter_to_Number_Converter
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
            this.EnteredWord = new System.Windows.Forms.TextBox();
            this.ConvertLetters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnteredWord
            // 
            this.EnteredWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteredWord.Location = new System.Drawing.Point(173, 255);
            this.EnteredWord.Name = "EnteredWord";
            this.EnteredWord.Size = new System.Drawing.Size(151, 26);
            this.EnteredWord.TabIndex = 0;
            // 
            // ConvertLetters
            // 
            this.ConvertLetters.BackColor = System.Drawing.Color.SteelBlue;
            this.ConvertLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertLetters.ForeColor = System.Drawing.Color.White;
            this.ConvertLetters.Location = new System.Drawing.Point(402, 249);
            this.ConvertLetters.Name = "ConvertLetters";
            this.ConvertLetters.Size = new System.Drawing.Size(115, 39);
            this.ConvertLetters.TabIndex = 1;
            this.ConvertLetters.Text = "Convert";
            this.ConvertLetters.UseVisualStyleBackColor = false;
            this.ConvertLetters.Click += new System.EventHandler(this.ConvertLetters_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IF   A=1, B=2, C=3, ... Z=26";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "THEN   ATTITUDE=1+20+20+9+20+21+4+5=100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter a word  and click the button to see its score ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertLetters);
            this.Controls.Add(this.EnteredWord);
            this.Name = "Form1";
            this.Text = "Letter to Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnteredWord;
        private System.Windows.Forms.Button ConvertLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

