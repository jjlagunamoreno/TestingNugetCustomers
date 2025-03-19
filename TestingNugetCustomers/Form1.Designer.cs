namespace TestingNugetCustomers
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
            label1 = new Label();
            btnReadCustomers = new Button();
            listBox1 = new ListBox();
            btnReadCars = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // btnReadCustomers
            // 
            btnReadCustomers.Location = new Point(28, 135);
            btnReadCustomers.Name = "btnReadCustomers";
            btnReadCustomers.Size = new Size(151, 84);
            btnReadCustomers.TabIndex = 1;
            btnReadCustomers.Text = "btnReadCustomers";
            btnReadCustomers.UseVisualStyleBackColor = true;
            btnReadCustomers.Click += btnReadCustomers_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(338, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(425, 324);
            listBox1.TabIndex = 2;
            // 
            // btnReadCars
            // 
            btnReadCars.Location = new Point(28, 264);
            btnReadCars.Name = "btnReadCars";
            btnReadCars.Size = new Size(151, 73);
            btnReadCars.TabIndex = 3;
            btnReadCars.Text = "btnReadCars";
            btnReadCars.UseVisualStyleBackColor = true;
            btnReadCars.Click += btnReadCars_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReadCars);
            Controls.Add(listBox1);
            Controls.Add(btnReadCustomers);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReadCustomers;
        private ListBox listBox1;
        private Button btnReadCars;
    }
}
