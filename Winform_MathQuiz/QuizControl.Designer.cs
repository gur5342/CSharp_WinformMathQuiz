namespace Winform_MathQuiz
{
    partial class QuizControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nuAnswer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.lbleft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // nuAnswer
            // 
            this.nuAnswer.Location = new System.Drawing.Point(299, 40);
            this.nuAnswer.Name = "nuAnswer";
            this.nuAnswer.Size = new System.Drawing.Size(120, 25);
            this.nuAnswer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(97, 31);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(60, 50);
            this.lblOperator.TabIndex = 8;
            this.lblOperator.Text = "+";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRight
            // 
            this.lbRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRight.Location = new System.Drawing.Point(163, 31);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(60, 50);
            this.lbRight.TabIndex = 7;
            this.lbRight.Text = "?";
            this.lbRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbleft
            // 
            this.lbleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleft.Location = new System.Drawing.Point(31, 31);
            this.lbleft.Name = "lbleft";
            this.lbleft.Size = new System.Drawing.Size(60, 50);
            this.lbleft.TabIndex = 6;
            this.lbleft.Text = "?";
            this.lbleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nuAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbleft);
            this.Name = "QuizControl";
            this.Size = new System.Drawing.Size(778, 347);
            ((System.ComponentModel.ISupportInitialize)(this.nuAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nuAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.Label lbleft;
    }
}
