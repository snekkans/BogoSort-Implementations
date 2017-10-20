namespace BogoSort___Windows_Forms
{
    partial class BogoSortForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_generatedArray = new System.Windows.Forms.Label();
            this.btn_generateArray = new System.Windows.Forms.Button();
            this.lbl_numShuffles = new System.Windows.Forms.Label();
            this.lbl_timesShuffled = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.txtBox_numGeneratedValues = new System.Windows.Forms.TextBox();
            this.lbl_enterValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_generatedArray);
            this.panel1.Controls.Add(this.btn_generateArray);
            this.panel1.Controls.Add(this.lbl_numShuffles);
            this.panel1.Controls.Add(this.lbl_timesShuffled);
            this.panel1.Controls.Add(this.btn_go);
            this.panel1.Controls.Add(this.txtBox_numGeneratedValues);
            this.panel1.Controls.Add(this.lbl_enterValue);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 230);
            this.panel1.TabIndex = 0;
            // 
            // lbl_generatedArray
            // 
            this.lbl_generatedArray.AutoSize = true;
            this.lbl_generatedArray.Location = new System.Drawing.Point(3, 63);
            this.lbl_generatedArray.Name = "lbl_generatedArray";
            this.lbl_generatedArray.Size = new System.Drawing.Size(97, 20);
            this.lbl_generatedArray.TabIndex = 6;
            this.lbl_generatedArray.Text = "No array yet!";
            // 
            // btn_generateArray
            // 
            this.btn_generateArray.Location = new System.Drawing.Point(126, 22);
            this.btn_generateArray.Name = "btn_generateArray";
            this.btn_generateArray.Size = new System.Drawing.Size(140, 30);
            this.btn_generateArray.TabIndex = 5;
            this.btn_generateArray.Text = "Generate Array";
            this.btn_generateArray.UseVisualStyleBackColor = true;
            this.btn_generateArray.Click += new System.EventHandler(this.lbl_generateArray_Click);
            // 
            // lbl_numShuffles
            // 
            this.lbl_numShuffles.AutoSize = true;
            this.lbl_numShuffles.Location = new System.Drawing.Point(3, 141);
            this.lbl_numShuffles.Name = "lbl_numShuffles";
            this.lbl_numShuffles.Size = new System.Drawing.Size(91, 20);
            this.lbl_numShuffles.TabIndex = 4;
            this.lbl_numShuffles.Text = "None so far";
            // 
            // lbl_timesShuffled
            // 
            this.lbl_timesShuffled.AutoSize = true;
            this.lbl_timesShuffled.Location = new System.Drawing.Point(3, 121);
            this.lbl_timesShuffled.Name = "lbl_timesShuffled";
            this.lbl_timesShuffled.Size = new System.Drawing.Size(278, 20);
            this.lbl_timesShuffled.TabIndex = 3;
            this.lbl_timesShuffled.Text = "Times shuffled before correctly sorted:";
            // 
            // btn_go
            // 
            this.btn_go.Enabled = false;
            this.btn_go.Location = new System.Drawing.Point(7, 86);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 32);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "GO!";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txtBox_numGeneratedValues
            // 
            this.txtBox_numGeneratedValues.Location = new System.Drawing.Point(7, 24);
            this.txtBox_numGeneratedValues.Name = "txtBox_numGeneratedValues";
            this.txtBox_numGeneratedValues.Size = new System.Drawing.Size(100, 26);
            this.txtBox_numGeneratedValues.TabIndex = 1;
            // 
            // lbl_enterValue
            // 
            this.lbl_enterValue.AutoSize = true;
            this.lbl_enterValue.Location = new System.Drawing.Point(3, 0);
            this.lbl_enterValue.Name = "lbl_enterValue";
            this.lbl_enterValue.Size = new System.Drawing.Size(263, 20);
            this.lbl_enterValue.TabIndex = 0;
            this.lbl_enterValue.Text = "Enter number of values to generate:";
            // 
            // BogoSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 254);
            this.Controls.Add(this.panel1);
            this.Name = "BogoSortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BogoSort!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_generateArray;
        private System.Windows.Forms.Label lbl_numShuffles;
        private System.Windows.Forms.Label lbl_timesShuffled;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txtBox_numGeneratedValues;
        private System.Windows.Forms.Label lbl_enterValue;
        private System.Windows.Forms.Label lbl_generatedArray;
    }
}

