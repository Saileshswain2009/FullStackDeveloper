namespace SerializationDesrialization_project
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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.rtbSerialize = new System.Windows.Forms.RichTextBox();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.rtbDeserialize = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(12, 23);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(475, 38);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // rtbSerialize
            // 
            this.rtbSerialize.Location = new System.Drawing.Point(12, 67);
            this.rtbSerialize.Name = "rtbSerialize";
            this.rtbSerialize.Size = new System.Drawing.Size(475, 105);
            this.rtbSerialize.TabIndex = 1;
            this.rtbSerialize.Text = "";
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(12, 188);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(475, 38);
            this.btnDeserialize.TabIndex = 2;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            // 
            // rtbDeserialize
            // 
            this.rtbDeserialize.Location = new System.Drawing.Point(12, 232);
            this.rtbDeserialize.Name = "rtbDeserialize";
            this.rtbDeserialize.Size = new System.Drawing.Size(475, 113);
            this.rtbDeserialize.TabIndex = 3;
            this.rtbDeserialize.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 480);
            this.Controls.Add(this.rtbDeserialize);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.rtbSerialize);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.RichTextBox rtbSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.RichTextBox rtbDeserialize;
    }
}

