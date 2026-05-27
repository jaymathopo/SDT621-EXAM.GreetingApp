using System;
using System.Drawing;
using System.Windows.Forms;

namespace GreetingApp
{
    public partial class Form1 : Form
    {
        private Label lblName;
        private TextBox txtName;
        private Button btnGreeting;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            btnGreeting = new Button();

            SuspendLayout();

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";

            // Label
            lblName.AutoSize = true;
            lblName.Location = new Point(185, 145);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 15);
            lblName.Text = "Enter your name:";

            // TextBox
            txtName.Location = new Point(320, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 0;

            // Button
            btnGreeting.Location = new Point(385, 190);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(130, 40);
            btnGreeting.TabIndex = 1;
            btnGreeting.Text = "Greeting";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += BtnGreeting_Click;

            // Controls
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnGreeting);

            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnGreeting_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            MessageBox.Show($"Hello {name}!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
