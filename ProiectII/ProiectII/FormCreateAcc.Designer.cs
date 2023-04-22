
namespace ProiectII
{
    partial class FormCreateAcc
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
            this.but2_CreateAcc = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_PassCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but2_CreateAcc
            // 
            this.but2_CreateAcc.Location = new System.Drawing.Point(326, 345);
            this.but2_CreateAcc.Name = "but2_CreateAcc";
            this.but2_CreateAcc.Size = new System.Drawing.Size(127, 41);
            this.but2_CreateAcc.TabIndex = 0;
            this.but2_CreateAcc.Text = "Create account";
            this.but2_CreateAcc.UseVisualStyleBackColor = true;
            this.but2_CreateAcc.Click += new System.EventHandler(this.but2_CreateAcc_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(326, 192);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(127, 21);
            this.textBox_Username.TabIndex = 1;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(326, 228);
            this.textBox_Pass.MaxLength = 20;
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '*';
            this.textBox_Pass.Size = new System.Drawing.Size(127, 22);
            this.textBox_Pass.TabIndex = 2;
            // 
            // textBox_PassCon
            // 
            this.textBox_PassCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PassCon.Location = new System.Drawing.Point(326, 268);
            this.textBox_PassCon.MaxLength = 20;
            this.textBox_PassCon.Name = "textBox_PassCon";
            this.textBox_PassCon.PasswordChar = '*';
            this.textBox_PassCon.Size = new System.Drawing.Size(127, 22);
            this.textBox_PassCon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confim Password:";
            // 
            // FormCreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PassCon);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.but2_CreateAcc);
            this.Name = "FormCreateAcc";
            this.Text = "FormCreateAcc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but2_CreateAcc;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_PassCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}