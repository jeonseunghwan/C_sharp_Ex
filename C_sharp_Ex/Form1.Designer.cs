namespace C_sharp_Ex
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
            this.Btn_Show_All_Data_Type = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Show_All_Data_Type
            // 
            this.Btn_Show_All_Data_Type.Location = new System.Drawing.Point(40, 49);
            this.Btn_Show_All_Data_Type.Name = "Btn_Show_All_Data_Type";
            this.Btn_Show_All_Data_Type.Size = new System.Drawing.Size(337, 58);
            this.Btn_Show_All_Data_Type.TabIndex = 0;
            this.Btn_Show_All_Data_Type.Text = "모든 데이터 타입 출력";
            this.Btn_Show_All_Data_Type.UseVisualStyleBackColor = true;
            this.Btn_Show_All_Data_Type.Click += new System.EventHandler(this.Btn_Show_All_Data_Type_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2003, 936);
            this.Controls.Add(this.Btn_Show_All_Data_Type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_Show_All_Data_Type;
    }
}