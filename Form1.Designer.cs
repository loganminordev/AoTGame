namespace AoTGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.Level2 = new System.Windows.Forms.Label();
            this.fuelBar = new System.Windows.Forms.ProgressBar();
            this.fuel = new System.Windows.Forms.PictureBox();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameOverView = new System.Windows.Forms.ListView();
            this.highScoreGridView = new System.Windows.Forms.DataGridView();
            this.slashBox = new System.Windows.Forms.PictureBox();
            this.mainMenuView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mainMenuBackground = new System.Windows.Forms.PictureBox();
            this.instructionsView = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.controlsHeader = new System.Windows.Forms.Label();
            this.controlsDesc = new System.Windows.Forms.Label();
            this.controlsDesc2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slashBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionsView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Black;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreText.Location = new System.Drawing.Point(2, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(100, 37);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "label1";
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Location = new System.Drawing.Point(-4, 633);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1143, 14);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::AoTGame.Properties.Resources.titanTop3;
            this.pipeTop.Location = new System.Drawing.Point(273, 0);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(243, 108);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::AoTGame.Properties.Resources.titanBottom;
            this.pipeBottom.Location = new System.Drawing.Point(435, 396);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(316, 251);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(21, 156);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(0);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(165, 144);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = global::AoTGame.Properties.Resources.sword;
            this.sword.Location = new System.Drawing.Point(875, 238);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(49, 62);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 8;
            this.sword.TabStop = false;
            // 
            // Level2
            // 
            this.Level2.AutoSize = true;
            this.Level2.BackColor = System.Drawing.Color.Transparent;
            this.Level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level2.Location = new System.Drawing.Point(1186, 0);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(352, 108);
            this.Level2.TabIndex = 9;
            this.Level2.Text = "Level 2";
            this.Level2.Visible = false;
            // 
            // fuelBar
            // 
            this.fuelBar.Location = new System.Drawing.Point(800, 0);
            this.fuelBar.Maximum = 1000;
            this.fuelBar.Name = "fuelBar";
            this.fuelBar.Size = new System.Drawing.Size(237, 23);
            this.fuelBar.Step = 5;
            this.fuelBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.fuelBar.TabIndex = 10;
            this.fuelBar.Value = 1000;
            // 
            // fuel
            // 
            this.fuel.BackColor = System.Drawing.Color.Transparent;
            this.fuel.Image = global::AoTGame.Properties.Resources.gasContainer5;
            this.fuel.Location = new System.Drawing.Point(198, 337);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(32, 73);
            this.fuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fuel.TabIndex = 11;
            this.fuel.TabStop = false;
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.BackColor = System.Drawing.Color.Black;
            this.fuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.fuelLabel.Location = new System.Drawing.Point(664, 0);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(130, 25);
            this.fuelLabel.TabIndex = 12;
            this.fuelLabel.Text = "Fuel Gauge:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "col1";
            this.columnHeader1.Width = 1139;
            // 
            // gameOverView
            // 
            this.gameOverView.BackColor = System.Drawing.SystemColors.MenuText;
            this.gameOverView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.gameOverView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverView.ForeColor = System.Drawing.Color.Red;
            this.gameOverView.GridLines = true;
            this.gameOverView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.gameOverView.LabelWrap = false;
            this.gameOverView.Location = new System.Drawing.Point(-4, 0);
            this.gameOverView.Name = "gameOverView";
            this.gameOverView.Scrollable = false;
            this.gameOverView.ShowGroups = false;
            this.gameOverView.Size = new System.Drawing.Size(1542, 647);
            this.gameOverView.TabIndex = 13;
            this.gameOverView.TileSize = new System.Drawing.Size(150, 150);
            this.gameOverView.UseCompatibleStateImageBehavior = false;
            this.gameOverView.View = System.Windows.Forms.View.List;
            this.gameOverView.Visible = false;
            this.gameOverView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gameOverView_KeyPress);
            // 
            // highScoreGridView
            // 
            this.highScoreGridView.AllowUserToAddRows = false;
            this.highScoreGridView.AllowUserToDeleteRows = false;
            this.highScoreGridView.AllowUserToResizeColumns = false;
            this.highScoreGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.highScoreGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.highScoreGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.highScoreGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highScoreGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.highScoreGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.highScoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.highScoreGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.highScoreGridView.Enabled = false;
            this.highScoreGridView.EnableHeadersVisualStyles = false;
            this.highScoreGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.highScoreGridView.Location = new System.Drawing.Point(779, 105);
            this.highScoreGridView.MultiSelect = false;
            this.highScoreGridView.Name = "highScoreGridView";
            this.highScoreGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.highScoreGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.highScoreGridView.RowHeadersVisible = false;
            this.highScoreGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.highScoreGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.highScoreGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.highScoreGridView.ShowCellErrors = false;
            this.highScoreGridView.ShowCellToolTips = false;
            this.highScoreGridView.ShowEditingIcon = false;
            this.highScoreGridView.ShowRowErrors = false;
            this.highScoreGridView.Size = new System.Drawing.Size(100, 177);
            this.highScoreGridView.TabIndex = 14;
            // 
            // slashBox
            // 
            this.slashBox.BackColor = System.Drawing.Color.Transparent;
            this.slashBox.Image = global::AoTGame.Properties.Resources.swordSlashAnim11;
            this.slashBox.Location = new System.Drawing.Point(167, 156);
            this.slashBox.Name = "slashBox";
            this.slashBox.Size = new System.Drawing.Size(198, 144);
            this.slashBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slashBox.TabIndex = 15;
            this.slashBox.TabStop = false;
            this.slashBox.Visible = false;
            // 
            // mainMenuView
            // 
            this.mainMenuView.AllowUserToAddRows = false;
            this.mainMenuView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.mainMenuView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.mainMenuView.BackgroundColor = System.Drawing.Color.DimGray;
            this.mainMenuView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mainMenuView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mainMenuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainMenuView.ColumnHeadersVisible = false;
            this.mainMenuView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainMenuView.DefaultCellStyle = dataGridViewCellStyle6;
            this.mainMenuView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenuView.Location = new System.Drawing.Point(711, 465);
            this.mainMenuView.Name = "mainMenuView";
            this.mainMenuView.RowHeadersVisible = false;
            this.mainMenuView.Size = new System.Drawing.Size(102, 69);
            this.mainMenuView.TabIndex = 16;
            this.mainMenuView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainMenuView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Play";
            this.Column1.Name = "Column1";
            // 
            // mainMenuBackground
            // 
            this.mainMenuBackground.Image = global::AoTGame.Properties.Resources.mainMenuBackgroundU;
            this.mainMenuBackground.Location = new System.Drawing.Point(-4, 0);
            this.mainMenuBackground.Name = "mainMenuBackground";
            this.mainMenuBackground.Size = new System.Drawing.Size(1542, 647);
            this.mainMenuBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainMenuBackground.TabIndex = 17;
            this.mainMenuBackground.TabStop = false;
            // 
            // instructionsView
            // 
            this.instructionsView.BackColor = System.Drawing.Color.Black;
            this.instructionsView.Location = new System.Drawing.Point(-4, 0);
            this.instructionsView.Name = "instructionsView";
            this.instructionsView.Size = new System.Drawing.Size(1542, 647);
            this.instructionsView.TabIndex = 18;
            this.instructionsView.TabStop = false;
            this.instructionsView.Visible = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGray;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.Location = new System.Drawing.Point(1255, 488);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 37);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseClick);
            // 
            // controlsHeader
            // 
            this.controlsHeader.BackColor = System.Drawing.Color.Black;
            this.controlsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsHeader.ForeColor = System.Drawing.Color.Red;
            this.controlsHeader.Location = new System.Drawing.Point(715, 43);
            this.controlsHeader.Name = "controlsHeader";
            this.controlsHeader.Size = new System.Drawing.Size(150, 41);
            this.controlsHeader.TabIndex = 20;
            this.controlsHeader.Text = "Controls";
            this.controlsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.controlsHeader.Visible = false;
            // 
            // controlsDesc
            // 
            this.controlsDesc.BackColor = System.Drawing.Color.Black;
            this.controlsDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsDesc.ForeColor = System.Drawing.Color.Red;
            this.controlsDesc.Location = new System.Drawing.Point(628, 105);
            this.controlsDesc.Name = "controlsDesc";
            this.controlsDesc.Size = new System.Drawing.Size(321, 65);
            this.controlsDesc.TabIndex = 21;
            this.controlsDesc.Text = "Space bar: Hold to rise, release to fall";
            this.controlsDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.controlsDesc.Visible = false;
            // 
            // controlsDesc2
            // 
            this.controlsDesc2.BackColor = System.Drawing.Color.Black;
            this.controlsDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.controlsDesc2.ForeColor = System.Drawing.Color.Red;
            this.controlsDesc2.Location = new System.Drawing.Point(705, 189);
            this.controlsDesc2.Name = "controlsDesc2";
            this.controlsDesc2.Size = new System.Drawing.Size(144, 33);
            this.controlsDesc2.TabIndex = 22;
            this.controlsDesc2.Text = "A: Attack";
            this.controlsDesc2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.controlsDesc2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AoTGame.Properties.Resources.cityBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1539, 649);
            this.Controls.Add(this.controlsDesc2);
            this.Controls.Add(this.controlsDesc);
            this.Controls.Add(this.controlsHeader);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mainMenuView);
            this.Controls.Add(this.mainMenuBackground);
            this.Controls.Add(this.instructionsView);
            this.Controls.Add(this.highScoreGridView);
            this.Controls.Add(this.gameOverView);
            this.Controls.Add(this.slashBox);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.fuelBar);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.Level2);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slashBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.Label Level2;
        private System.Windows.Forms.ProgressBar fuelBar;
        private System.Windows.Forms.PictureBox fuel;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView gameOverView;
        private System.Windows.Forms.DataGridView highScoreGridView;
        private System.Windows.Forms.PictureBox slashBox;
        private System.Windows.Forms.DataGridView mainMenuView;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.PictureBox mainMenuBackground;
        private System.Windows.Forms.PictureBox instructionsView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label controlsHeader;
        private System.Windows.Forms.Label controlsDesc;
        private System.Windows.Forms.Label controlsDesc2;
    }
}

