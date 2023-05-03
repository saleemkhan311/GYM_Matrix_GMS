
namespace GYM_Matrix
{
    partial class ViewFullData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFullData));
            this.MinimizeApp = new System.Windows.Forms.PictureBox();
            this.CloseApp = new System.Windows.Forms.PictureBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MemberDuesTable = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.ExpiredMembersTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDuesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiredMembersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeApp
            // 
            this.MinimizeApp.Image = global::GYM_Matrix.Properties.Resources.Minimize;
            this.MinimizeApp.Location = new System.Drawing.Point(1065, 7);
            this.MinimizeApp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeApp.Name = "MinimizeApp";
            this.MinimizeApp.Size = new System.Drawing.Size(26, 30);
            this.MinimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeApp.TabIndex = 63;
            this.MinimizeApp.TabStop = false;
            this.MinimizeApp.Click += new System.EventHandler(this.MinimizeApp_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.Image = global::GYM_Matrix.Properties.Resources.Close;
            this.CloseApp.Location = new System.Drawing.Point(1107, 7);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(26, 30);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseApp.TabIndex = 64;
            this.CloseApp.TabStop = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Bebas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(474, 12);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(62, 28);
            this.UserLabel.TabIndex = 62;
            this.UserLabel.Text = "Admin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Berlin Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(389, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 27);
            this.label14.TabIndex = 61;
            this.label14.Text = "|";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bebas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(254, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 28);
            this.label13.TabIndex = 60;
            this.label13.Text = "Dashboard";
            // 
            // MemberDuesTable
            // 
            this.MemberDuesTable.AllowUserToAddRows = false;
            this.MemberDuesTable.AllowUserToDeleteRows = false;
            this.MemberDuesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDuesTable.Location = new System.Drawing.Point(45, 466);
            this.MemberDuesTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberDuesTable.Name = "MemberDuesTable";
            this.MemberDuesTable.ReadOnly = true;
            this.MemberDuesTable.RowHeadersWidth = 51;
            this.MemberDuesTable.RowTemplate.Height = 29;
            this.MemberDuesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberDuesTable.Size = new System.Drawing.Size(1055, 320);
            this.MemberDuesTable.TabIndex = 70;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(45, 433);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(151, 24);
            this.label27.TabIndex = 71;
            this.label27.Text = "Members With Dues";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(985, 63);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(115, 32);
            this.RefreshButton.TabIndex = 69;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(45, 74);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(135, 24);
            this.label25.TabIndex = 68;
            this.label25.Text = "Expired Members";
            // 
            // ExpiredMembersTable
            // 
            this.ExpiredMembersTable.AllowUserToAddRows = false;
            this.ExpiredMembersTable.AllowUserToDeleteRows = false;
            this.ExpiredMembersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpiredMembersTable.Location = new System.Drawing.Point(45, 101);
            this.ExpiredMembersTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ExpiredMembersTable.Name = "ExpiredMembersTable";
            this.ExpiredMembersTable.ReadOnly = true;
            this.ExpiredMembersTable.RowHeadersWidth = 51;
            this.ExpiredMembersTable.RowTemplate.Height = 29;
            this.ExpiredMembersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpiredMembersTable.Size = new System.Drawing.Size(1055, 320);
            this.ExpiredMembersTable.TabIndex = 67;
            // 
            // ViewFullData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1137, 800);
            this.Controls.Add(this.MemberDuesTable);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.ExpiredMembersTable);
            this.Controls.Add(this.MinimizeApp);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Bebas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewFullData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFullData";
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDuesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiredMembersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MinimizeApp;
        private System.Windows.Forms.PictureBox CloseApp;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView MemberDuesTable;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView ExpiredMembersTable;
    }
}