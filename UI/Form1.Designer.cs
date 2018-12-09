namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblfirst = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.firstNumberValue = new System.Windows.Forms.NumericUpDown();
            this.secondNumberValue = new System.Windows.Forms.NumericUpDown();
            this.usersDropdown = new System.Windows.Forms.ComboBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblusers = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.resultsText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Location = new System.Drawing.Point(60, 123);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(100, 20);
            this.lblfirst.TabIndex = 2;
            this.lblfirst.Text = "First Number";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Location = new System.Drawing.Point(60, 182);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(124, 20);
            this.lblsecond.TabIndex = 3;
            this.lblsecond.Text = "Second Number";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(64, 232);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(64, 262);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 23);
            this.Subtract.TabIndex = 5;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(64, 292);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 6;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(64, 322);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 7;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // firstNumberValue
            // 
            this.firstNumberValue.Location = new System.Drawing.Point(202, 121);
            this.firstNumberValue.Name = "firstNumberValue";
            this.firstNumberValue.Size = new System.Drawing.Size(120, 26);
            this.firstNumberValue.TabIndex = 8;
            // 
            // secondNumberValue
            // 
            this.secondNumberValue.Location = new System.Drawing.Point(202, 182);
            this.secondNumberValue.Name = "secondNumberValue";
            this.secondNumberValue.Size = new System.Drawing.Size(120, 26);
            this.secondNumberValue.TabIndex = 9;
            // 
            // usersDropdown
            // 
            this.usersDropdown.FormattingEnabled = true;
            this.usersDropdown.Location = new System.Drawing.Point(579, 121);
            this.usersDropdown.Name = "usersDropdown";
            this.usersDropdown.Size = new System.Drawing.Size(121, 28);
            this.usersDropdown.TabIndex = 10;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(579, 182);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 26);
            this.firstNameText.TabIndex = 11;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(579, 235);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 26);
            this.lastNameText.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(568, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Person";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblusers
            // 
            this.lblusers.AutoSize = true;
            this.lblusers.Location = new System.Drawing.Point(454, 122);
            this.lblusers.Name = "lblusers";
            this.lblusers.Size = new System.Drawing.Size(51, 20);
            this.lblusers.TabIndex = 14;
            this.lblusers.Text = "Users";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(454, 188);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 20);
            this.lblfirstname.TabIndex = 15;
            this.lblfirstname.Text = "First Name";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(454, 235);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(86, 20);
            this.lbllastname.TabIndex = 16;
            this.lbllastname.Text = "Last Name";
            // 
            // resultsText
            // 
            this.resultsText.Location = new System.Drawing.Point(202, 287);
            this.resultsText.Name = "resultsText";
            this.resultsText.Size = new System.Drawing.Size(100, 26);
            this.resultsText.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsText);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lblusers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.usersDropdown);
            this.Controls.Add(this.secondNumberValue);
            this.Controls.Add(this.firstNumberValue);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblfirst);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.NumericUpDown firstNumberValue;
        private System.Windows.Forms.NumericUpDown secondNumberValue;
        private System.Windows.Forms.ComboBox usersDropdown;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblusers;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox resultsText;
    }
}

