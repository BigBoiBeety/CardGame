namespace CardGame
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
            this.btnCreateDeck = new System.Windows.Forms.Button();
            this.pbCardDisplay0 = new System.Windows.Forms.PictureBox();
            this.pbCardDisplay1 = new System.Windows.Forms.PictureBox();
            this.pbCardDisplay2 = new System.Windows.Forms.PictureBox();
            this.pbCardDisplay3 = new System.Windows.Forms.PictureBox();
            this.pbCardDisplay4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDeck
            // 
            this.btnCreateDeck.Location = new System.Drawing.Point(12, 12);
            this.btnCreateDeck.Name = "btnCreateDeck";
            this.btnCreateDeck.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDeck.TabIndex = 0;
            this.btnCreateDeck.Text = "Create Deck";
            this.btnCreateDeck.UseVisualStyleBackColor = true;
            this.btnCreateDeck.Click += new System.EventHandler(this.btnCreateDeck_Click);
            // 
            // pbCardDisplay0
            // 
            this.pbCardDisplay0.Location = new System.Drawing.Point(25, 72);
            this.pbCardDisplay0.Name = "pbCardDisplay0";
            this.pbCardDisplay0.Size = new System.Drawing.Size(100, 97);
            this.pbCardDisplay0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardDisplay0.TabIndex = 1;
            this.pbCardDisplay0.TabStop = false;
            // 
            // pbCardDisplay1
            // 
            this.pbCardDisplay1.Location = new System.Drawing.Point(131, 72);
            this.pbCardDisplay1.Name = "pbCardDisplay1";
            this.pbCardDisplay1.Size = new System.Drawing.Size(100, 97);
            this.pbCardDisplay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardDisplay1.TabIndex = 2;
            this.pbCardDisplay1.TabStop = false;
            // 
            // pbCardDisplay2
            // 
            this.pbCardDisplay2.Location = new System.Drawing.Point(237, 72);
            this.pbCardDisplay2.Name = "pbCardDisplay2";
            this.pbCardDisplay2.Size = new System.Drawing.Size(100, 97);
            this.pbCardDisplay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardDisplay2.TabIndex = 3;
            this.pbCardDisplay2.TabStop = false;
            // 
            // pbCardDisplay3
            // 
            this.pbCardDisplay3.Location = new System.Drawing.Point(343, 72);
            this.pbCardDisplay3.Name = "pbCardDisplay3";
            this.pbCardDisplay3.Size = new System.Drawing.Size(100, 97);
            this.pbCardDisplay3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardDisplay3.TabIndex = 4;
            this.pbCardDisplay3.TabStop = false;
            // 
            // pbCardDisplay4
            // 
            this.pbCardDisplay4.Location = new System.Drawing.Point(449, 72);
            this.pbCardDisplay4.Name = "pbCardDisplay4";
            this.pbCardDisplay4.Size = new System.Drawing.Size(100, 97);
            this.pbCardDisplay4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardDisplay4.TabIndex = 5;
            this.pbCardDisplay4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCardDisplay4);
            this.Controls.Add(this.pbCardDisplay3);
            this.Controls.Add(this.pbCardDisplay2);
            this.Controls.Add(this.pbCardDisplay1);
            this.Controls.Add(this.pbCardDisplay0);
            this.Controls.Add(this.btnCreateDeck);
            this.Name = "Form1";
            this.Text = "Card Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDeck;
        private System.Windows.Forms.PictureBox pbCardDisplay0;
        private System.Windows.Forms.PictureBox pbCardDisplay1;
        private System.Windows.Forms.PictureBox pbCardDisplay2;
        private System.Windows.Forms.PictureBox pbCardDisplay3;
        private System.Windows.Forms.PictureBox pbCardDisplay4;
    }
}

