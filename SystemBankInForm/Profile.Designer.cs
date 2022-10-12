
namespace SystemBank
{
    partial class Profile
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FSMNameLable = new System.Windows.Forms.Label();
            this.youBalanceLable = new System.Windows.Forms.Label();
            this.FSMNameTextBox = new System.Windows.Forms.TextBox();
            this.youBalaceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 418);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FSMNameLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.youBalanceLable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FSMNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.youBalaceTextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 418);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FSMNameLable
            // 
            this.FSMNameLable.AutoSize = true;
            this.FSMNameLable.Location = new System.Drawing.Point(3, 0);
            this.FSMNameLable.Name = "FSMNameLable";
            this.FSMNameLable.Size = new System.Drawing.Size(67, 13);
            this.FSMNameLable.TabIndex = 0;
            this.FSMNameLable.Text = "Ваше ФИО:";
            // 
            // youBalanceLable
            // 
            this.youBalanceLable.AutoSize = true;
            this.youBalanceLable.Location = new System.Drawing.Point(3, 26);
            this.youBalanceLable.Name = "youBalanceLable";
            this.youBalanceLable.Size = new System.Drawing.Size(70, 13);
            this.youBalanceLable.TabIndex = 1;
            this.youBalanceLable.Text = "Ваш баланс:";
            // 
            // FSMNameTextBox
            // 
            this.FSMNameTextBox.Location = new System.Drawing.Point(79, 3);
            this.FSMNameTextBox.Name = "FSMNameTextBox";
            this.FSMNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.FSMNameTextBox.TabIndex = 2;
            // 
            // youBalaceTextBox
            // 
            this.youBalaceTextBox.Location = new System.Drawing.Point(79, 29);
            this.youBalaceTextBox.Name = "youBalaceTextBox";
            this.youBalaceTextBox.Size = new System.Drawing.Size(186, 20);
            this.youBalaceTextBox.TabIndex = 3;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FSMNameLable;
        private System.Windows.Forms.Label youBalanceLable;
        private System.Windows.Forms.TextBox FSMNameTextBox;
        private System.Windows.Forms.TextBox youBalaceTextBox;
    }
}