
namespace RockstarCloudXMLToFivemJSON
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

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
            this.openXMLbtn = new System.Windows.Forms.Button();
            this.saveJSONbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openXMLbtn
            // 
            this.openXMLbtn.Location = new System.Drawing.Point(3, 53);
            this.openXMLbtn.Name = "openXMLbtn";
            this.openXMLbtn.Size = new System.Drawing.Size(141, 30);
            this.openXMLbtn.TabIndex = 0;
            this.openXMLbtn.Text = "Open XML";
            this.openXMLbtn.UseVisualStyleBackColor = true;
            this.openXMLbtn.Click += new System.EventHandler(this.openXMLbtn_Click);
            // 
            // saveJSONbtn
            // 
            this.saveJSONbtn.Location = new System.Drawing.Point(253, 53);
            this.saveJSONbtn.Name = "saveJSONbtn";
            this.saveJSONbtn.Size = new System.Drawing.Size(141, 30);
            this.saveJSONbtn.TabIndex = 1;
            this.saveJSONbtn.Text = "Save JSON";
            this.saveJSONbtn.UseVisualStyleBackColor = true;
            this.saveJSONbtn.Click += new System.EventHandler(this.saveJSONbtn_Click);
            //
            // saveFileDialog
            //
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            // 
            // Title Label
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "GTA V Cloud XML to FiveM JSON";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveJSONbtn);
            this.Controls.Add(this.openXMLbtn);
            this.Name = "App";
            this.Text = "GTA V Cloud XML to JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openXMLbtn;
        private System.Windows.Forms.Button saveJSONbtn;
        private System.Windows.Forms.Label label1;
    }
}

