
namespace TransportApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SafeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddVehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditVehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteVehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortAZMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortZAMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddVehicleButton = new System.Windows.Forms.ToolStripButton();
            this.EditVehicleButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteVehicleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SortAZButton = new System.Windows.Forms.ToolStripButton();
            this.SortZAButton = new System.Windows.Forms.ToolStripButton();
            this.SelectionButton = new System.Windows.Forms.ToolStripButton();
            this.ReportButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.InfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VehicleListBox = new System.Windows.Forms.ListBox();
            this.transportMapControl = new TransportApp.TransportMapControl1();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.VehicleMenuItem,
            this.ActionsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuItem,
            this.SafeMenuItem,
            this.toolStripSeparator1,
            this.CloseMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FileMenuItem.Text = "Файлы";
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Image = global::TransportApp.Properties.Resources.открыть;
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenFileMenuItem.Text = "Открыть";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // SafeMenuItem
            // 
            this.SafeMenuItem.Image = global::TransportApp.Properties.Resources.сохранить;
            this.SafeMenuItem.Name = "SafeMenuItem";
            this.SafeMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SafeMenuItem.Text = "Сохранить";
            this.SafeMenuItem.Click += new System.EventHandler(this.SafeMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(133, 22);
            this.CloseMenuItem.Text = "Закрыть";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // VehicleMenuItem
            // 
            this.VehicleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVehicleMenuItem,
            this.EditVehicleMenuItem,
            this.DeleteVehicleMenuItem});
            this.VehicleMenuItem.Name = "VehicleMenuItem";
            this.VehicleMenuItem.Size = new System.Drawing.Size(149, 20);
            this.VehicleMenuItem.Text = "Транспортное средство";
            // 
            // AddVehicleMenuItem
            // 
            this.AddVehicleMenuItem.Image = global::TransportApp.Properties.Resources.добавить;
            this.AddVehicleMenuItem.Name = "AddVehicleMenuItem";
            this.AddVehicleMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AddVehicleMenuItem.Text = "Добавить новое";
            this.AddVehicleMenuItem.Click += new System.EventHandler(this.AddVehicleMenuItem_Click);
            // 
            // EditVehicleMenuItem
            // 
            this.EditVehicleMenuItem.Image = global::TransportApp.Properties.Resources.изменить;
            this.EditVehicleMenuItem.Name = "EditVehicleMenuItem";
            this.EditVehicleMenuItem.Size = new System.Drawing.Size(162, 22);
            this.EditVehicleMenuItem.Text = "Изменить";
            this.EditVehicleMenuItem.Click += new System.EventHandler(this.EditVehicleMenuItem_Click);
            // 
            // DeleteVehicleMenuItem
            // 
            this.DeleteVehicleMenuItem.Image = global::TransportApp.Properties.Resources.удалить;
            this.DeleteVehicleMenuItem.Name = "DeleteVehicleMenuItem";
            this.DeleteVehicleMenuItem.Size = new System.Drawing.Size(162, 22);
            this.DeleteVehicleMenuItem.Text = "Удалить";
            this.DeleteVehicleMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ActionsMenuItem
            // 
            this.ActionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortAZMenuItem,
            this.SortZAMenuItem,
            this.SelectionMenuItem,
            this.ReportMenuItem});
            this.ActionsMenuItem.Name = "ActionsMenuItem";
            this.ActionsMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ActionsMenuItem.Text = "Действие";
            // 
            // SortAZMenuItem
            // 
            this.SortAZMenuItem.Image = global::TransportApp.Properties.Resources.сортировать_по_возрастанию;
            this.SortAZMenuItem.Name = "SortAZMenuItem";
            this.SortAZMenuItem.Size = new System.Drawing.Size(268, 22);
            this.SortAZMenuItem.Text = "Сортировать по возраостанию";
            this.SortAZMenuItem.Click += new System.EventHandler(this.SortAZMenuItem_Click);
            // 
            // SortZAMenuItem
            // 
            this.SortZAMenuItem.Image = global::TransportApp.Properties.Resources.сортировать_по_убыванию;
            this.SortZAMenuItem.Name = "SortZAMenuItem";
            this.SortZAMenuItem.Size = new System.Drawing.Size(268, 22);
            this.SortZAMenuItem.Text = "Сортировать по убыванию";
            this.SortZAMenuItem.Click += new System.EventHandler(this.SortZAMenuItem_Click);
            // 
            // SelectionMenuItem
            // 
            this.SelectionMenuItem.Image = global::TransportApp.Properties.Resources.отбор_транспортных_средств;
            this.SelectionMenuItem.Name = "SelectionMenuItem";
            this.SelectionMenuItem.Size = new System.Drawing.Size(268, 22);
            this.SelectionMenuItem.Text = "Отбор транспортных средств";
            this.SelectionMenuItem.Click += new System.EventHandler(this.SelectionMenuItem_Click);
            // 
            // ReportMenuItem
            // 
            this.ReportMenuItem.Image = global::TransportApp.Properties.Resources.отчёт;
            this.ReportMenuItem.Name = "ReportMenuItem";
            this.ReportMenuItem.Size = new System.Drawing.Size(268, 22);
            this.ReportMenuItem.Text = "Отчёт по транспортным средствам";
            this.ReportMenuItem.Click += new System.EventHandler(this.ReportMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileButton,
            this.SaveFileButton,
            this.toolStripSeparator2,
            this.AddVehicleButton,
            this.EditVehicleButton,
            this.DeleteVehicleButton,
            this.toolStripSeparator3,
            this.SortAZButton,
            this.SortZAButton,
            this.SelectionButton,
            this.ReportButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = global::TransportApp.Properties.Resources.открыть;
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(23, 22);
            this.OpenFileButton.Text = "Открыть файл";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileButton.Image = global::TransportApp.Properties.Resources.сохранить;
            this.SaveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(23, 22);
            this.SaveFileButton.Text = "Сохранить текст";
            this.SaveFileButton.Click += new System.EventHandler(this.SafeMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddVehicleButton.Image = global::TransportApp.Properties.Resources.добавить;
            this.AddVehicleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(23, 22);
            this.AddVehicleButton.Text = "Добавить транспорт";
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleMenuItem_Click);
            // 
            // EditVehicleButton
            // 
            this.EditVehicleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditVehicleButton.Image = global::TransportApp.Properties.Resources.изменить;
            this.EditVehicleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditVehicleButton.Name = "EditVehicleButton";
            this.EditVehicleButton.Size = new System.Drawing.Size(23, 22);
            this.EditVehicleButton.Text = "Изменить транспортное средство";
            this.EditVehicleButton.Click += new System.EventHandler(this.EditVehicleMenuItem_Click);
            // 
            // DeleteVehicleButton
            // 
            this.DeleteVehicleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteVehicleButton.Image = global::TransportApp.Properties.Resources.удалить;
            this.DeleteVehicleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteVehicleButton.Name = "DeleteVehicleButton";
            this.DeleteVehicleButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteVehicleButton.Text = "Удалить транспортное средство";
            this.DeleteVehicleButton.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SortAZButton
            // 
            this.SortAZButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortAZButton.Image = global::TransportApp.Properties.Resources.сортировать_по_возрастанию;
            this.SortAZButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortAZButton.Name = "SortAZButton";
            this.SortAZButton.Size = new System.Drawing.Size(23, 22);
            this.SortAZButton.Text = "Сортировать по возростанию";
            this.SortAZButton.Click += new System.EventHandler(this.SortAZMenuItem_Click);
            // 
            // SortZAButton
            // 
            this.SortZAButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortZAButton.Image = global::TransportApp.Properties.Resources.сортировать_по_убыванию;
            this.SortZAButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortZAButton.Name = "SortZAButton";
            this.SortZAButton.Size = new System.Drawing.Size(23, 22);
            this.SortZAButton.Text = "Сортировать по убыванию";
            this.SortZAButton.Click += new System.EventHandler(this.SortZAMenuItem_Click);
            // 
            // SelectionButton
            // 
            this.SelectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectionButton.Image = global::TransportApp.Properties.Resources.отбор_транспортных_средств;
            this.SelectionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(23, 22);
            this.SelectionButton.Text = "Отбор транспортных средств";
            this.SelectionButton.Click += new System.EventHandler(this.SelectionMenuItem_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReportButton.Image = global::TransportApp.Properties.Resources.отчёт;
            this.ReportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(23, 22);
            this.ReportButton.Text = "Отчёт по транспортным средствам";
            this.ReportButton.Click += new System.EventHandler(this.ReportMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // InfoLabel
            // 
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.VehicleListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.transportMapControl, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 379);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Транспортные средства:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(292, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Расположение транспортных средств:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VehicleListBox
            // 
            this.VehicleListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleListBox.FormattingEnabled = true;
            this.VehicleListBox.Location = new System.Drawing.Point(3, 23);
            this.VehicleListBox.Name = "VehicleListBox";
            this.VehicleListBox.Size = new System.Drawing.Size(283, 353);
            this.VehicleListBox.TabIndex = 2;
            this.VehicleListBox.SelectedIndexChanged += new System.EventHandler(this.VehicleListBox_SelectedIndexChanged);
            this.VehicleListBox.DoubleClick += new System.EventHandler(this.EditVehicleMenuItem_Click);
            // 
            // transportMapControl
            // 
            this.transportMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportMapControl.Location = new System.Drawing.Point(292, 23);
            this.transportMapControl.Name = "transportMapControl";
            this.transportMapControl.Size = new System.Drawing.Size(505, 353);
            this.transportMapControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Транспортные средства";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SafeMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddVehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditVehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteVehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortAZMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortZAMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportMenuItem;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton AddVehicleButton;
        private System.Windows.Forms.ToolStripButton EditVehicleButton;
        private System.Windows.Forms.ToolStripButton DeleteVehicleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SortAZButton;
        private System.Windows.Forms.ToolStripButton SortZAButton;
        private System.Windows.Forms.ToolStripButton SelectionButton;
        private System.Windows.Forms.ToolStripButton ReportButton;
        private System.Windows.Forms.ToolStripStatusLabel InfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox VehicleListBox;
        private TransportMapControl1 transportMapControl;
    }
}

