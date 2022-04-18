namespace SimMod_8._1
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
            this.inputQuestion = new System.Windows.Forms.TextBox();
            this.labelInputQuestion = new System.Windows.Forms.Label();
            this.textAnswer = new System.Windows.Forms.Label();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputQuestion
            // 
            this.inputQuestion.Location = new System.Drawing.Point(93, 12);
            this.inputQuestion.Name = "inputQuestion";
            this.inputQuestion.Size = new System.Drawing.Size(201, 20);
            this.inputQuestion.TabIndex = 0;
            // 
            // labelInputQuestion
            // 
            this.labelInputQuestion.AutoSize = true;
            this.labelInputQuestion.Location = new System.Drawing.Point(12, 15);
            this.labelInputQuestion.Name = "labelInputQuestion";
            this.labelInputQuestion.Size = new System.Drawing.Size(75, 13);
            this.labelInputQuestion.TabIndex = 1;
            this.labelInputQuestion.Text = "Your question:";
            // 
            // textAnswer
            // 
            this.textAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAnswer.AutoSize = true;
            this.textAnswer.Location = new System.Drawing.Point(101, 35);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(0, 13);
            this.textAnswer.TabIndex = 2;
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.Location = new System.Drawing.Point(300, 12);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(77, 23);
            this.btnGetAnswer.TabIndex = 3;
            this.btnGetAnswer.Text = "Get answer";
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 98);
            this.Controls.Add(this.btnGetAnswer);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.labelInputQuestion);
            this.Controls.Add(this.inputQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputQuestion;
        private System.Windows.Forms.Label labelInputQuestion;
        private System.Windows.Forms.Label textAnswer;
        private System.Windows.Forms.Button btnGetAnswer;
    }
}

