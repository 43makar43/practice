
namespace makarov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.MessegeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RusCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(71, 47);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(84, 23);
            this.actionButton.TabIndex = 0;
            this.actionButton.Text = "Выполнить";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Действие:";
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Location = new System.Drawing.Point(227, 49);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(290, 21);
            this.ActionComboBox.TabIndex = 2;
            // 
            // MessegeTextBox
            // 
            this.MessegeTextBox.Location = new System.Drawing.Point(227, 76);
            this.MessegeTextBox.Name = "MessegeTextBox";
            this.MessegeTextBox.Size = new System.Drawing.Size(290, 20);
            this.MessegeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сообщение:";
            // 
            // RusCheckBox1
            // 
            this.RusCheckBox1.AutoSize = true;
            this.RusCheckBox1.Location = new System.Drawing.Point(164, 117);
            this.RusCheckBox1.Name = "RusCheckBox1";
            this.RusCheckBox1.Size = new System.Drawing.Size(121, 17);
            this.RusCheckBox1.TabIndex = 5;
            this.RusCheckBox1.Text = "На русском языке";
            this.RusCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список сообщений";
            // 
            // MessageListBox
            // 
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.Location = new System.Drawing.Point(71, 175);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(150, 95);
            this.MessageListBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Текст";
            // 
            // TextRichTextBox
            // 
            this.TextRichTextBox.Location = new System.Drawing.Point(227, 175);
            this.TextRichTextBox.Name = "TextRichTextBox";
            this.TextRichTextBox.Size = new System.Drawing.Size(150, 96);
            this.TextRichTextBox.TabIndex = 9;
            this.TextRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Изображение";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(400, 175);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(186, 95);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 11;
            this.PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextRichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RusCheckBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MessegeTextBox);
            this.Controls.Add(this.ActionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionButton);
            this.Name = "Form1";
            this.Text = "элементы управления";
            this.Click += new System.EventHandler(this.ActionButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.TextBox MessegeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox RusCheckBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TextRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

