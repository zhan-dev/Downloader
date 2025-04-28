namespace Downloader
{
    partial class Downloader
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
            this.link_txt = new System.Windows.Forms.TextBox();
            this.downloadLink_lbl = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.add_pb = new System.Windows.Forms.PictureBox();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.download_pb = new System.Windows.Forms.PictureBox();
            this.result_pb = new System.Windows.Forms.ProgressBar();
            this.size_lbl = new System.Windows.Forms.Label();
            this.result_lbl = new System.Windows.Forms.Label();
            this.middle_panel = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pb)).BeginInit();
            this.bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.download_pb)).BeginInit();
            this.middle_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_txt
            // 
            this.link_txt.Location = new System.Drawing.Point(109, 10);
            this.link_txt.Name = "link_txt";
            this.link_txt.Size = new System.Drawing.Size(630, 23);
            this.link_txt.TabIndex = 0;
            this.link_txt.Text = "https://download.virtualbox.org/virtualbox/7.1.6/VirtualBox-7.1.6-167084-Win.exe";
            // 
            // downloadLink_lbl
            // 
            this.downloadLink_lbl.AutoSize = true;
            this.downloadLink_lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadLink_lbl.Location = new System.Drawing.Point(7, 10);
            this.downloadLink_lbl.Name = "downloadLink_lbl";
            this.downloadLink_lbl.Size = new System.Drawing.Size(96, 23);
            this.downloadLink_lbl.TabIndex = 1;
            this.downloadLink_lbl.Text = "Очередь";
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.add_pb);
            this.top_panel.Controls.Add(this.downloadLink_lbl);
            this.top_panel.Controls.Add(this.link_txt);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(782, 45);
            this.top_panel.TabIndex = 3;
            // 
            // add_pb
            // 
            this.add_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_pb.Image = global::Downloader.Properties.Resources.add_50;
            this.add_pb.Location = new System.Drawing.Point(745, 10);
            this.add_pb.Name = "add_pb";
            this.add_pb.Size = new System.Drawing.Size(25, 25);
            this.add_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_pb.TabIndex = 5;
            this.add_pb.TabStop = false;
            this.add_pb.Visible = false;
            // 
            // bottom_panel
            // 
            this.bottom_panel.Controls.Add(this.download_pb);
            this.bottom_panel.Controls.Add(this.result_pb);
            this.bottom_panel.Controls.Add(this.size_lbl);
            this.bottom_panel.Controls.Add(this.result_lbl);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 201);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(782, 60);
            this.bottom_panel.TabIndex = 4;
            // 
            // download_pb
            // 
            this.download_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.download_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download_pb.Image = global::Downloader.Properties.Resources.download_50;
            this.download_pb.Location = new System.Drawing.Point(742, 27);
            this.download_pb.Name = "download_pb";
            this.download_pb.Size = new System.Drawing.Size(28, 28);
            this.download_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.download_pb.TabIndex = 5;
            this.download_pb.TabStop = false;
            // 
            // result_pb
            // 
            this.result_pb.Location = new System.Drawing.Point(11, 32);
            this.result_pb.Name = "result_pb";
            this.result_pb.Size = new System.Drawing.Size(728, 23);
            this.result_pb.Step = 1;
            this.result_pb.TabIndex = 2;
            // 
            // size_lbl
            // 
            this.size_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_lbl.Location = new System.Drawing.Point(548, 8);
            this.size_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.size_lbl.Name = "size_lbl";
            this.size_lbl.Size = new System.Drawing.Size(191, 20);
            this.size_lbl.TabIndex = 1;
            this.size_lbl.Text = "Размер";
            this.size_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lbl.Location = new System.Drawing.Point(7, 8);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(84, 20);
            this.result_lbl.TabIndex = 1;
            this.result_lbl.Text = "Прогресс";
            // 
            // middle_panel
            // 
            this.middle_panel.Controls.Add(this.listView);
            this.middle_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middle_panel.Location = new System.Drawing.Point(0, 45);
            this.middle_panel.Name = "middle_panel";
            this.middle_panel.Size = new System.Drawing.Size(782, 156);
            this.middle_panel.TabIndex = 5;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.size,
            this.link});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(782, 156);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Tag = "Имя";
            this.name.Text = "Имя";
            this.name.Width = 280;
            // 
            // size
            // 
            this.size.Tag = "Размер";
            this.size.Text = "Размер";
            this.size.Width = 100;
            // 
            // link
            // 
            this.link.Tag = "Ссылка";
            this.link.Text = "Ссылка";
            this.link.Width = 402;
            // 
            // Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 261);
            this.Controls.Add(this.middle_panel);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(798, 600);
            this.MinimumSize = new System.Drawing.Size(798, 300);
            this.Name = "Downloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pb)).EndInit();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.download_pb)).EndInit();
            this.middle_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox link_txt;
        private System.Windows.Forms.Label downloadLink_lbl;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.ProgressBar result_pb;
        private System.Windows.Forms.PictureBox download_pb;
        private System.Windows.Forms.PictureBox add_pb;
        private System.Windows.Forms.Panel middle_panel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader link;
        private System.Windows.Forms.Label size_lbl;
    }
}

