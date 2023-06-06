namespace proje3
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
            header = new Label();
            nameLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            startGameButton = new Button();
            showingTimeText = new TextBox();
            numberOfLivesText = new TextBox();
            numberOfTilesText = new TextBox();
            boardSizeText = new TextBox();
            labelShowingTime = new Label();
            labelNumberLives = new Label();
            labelNumberTiles = new Label();
            labelBoardSize = new Label();
            diffucultyBox = new ComboBox();
            dıffucultyLabel = new Label();
            nameText = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            header.Location = new Point(198, 33);
            header.Name = "header";
            header.Size = new Size(225, 41);
            header.TabIndex = 0;
            header.Text = "Memory Game";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(192, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(68, 28);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            nameLabel.Click += nameLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(diffucultyBox);
            panel1.Controls.Add(dıffucultyLabel);
            panel1.Controls.Add(nameText);
            panel1.Controls.Add(nameLabel);
            panel1.Location = new Point(74, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 466);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(startGameButton);
            panel2.Controls.Add(showingTimeText);
            panel2.Controls.Add(numberOfLivesText);
            panel2.Controls.Add(numberOfTilesText);
            panel2.Controls.Add(boardSizeText);
            panel2.Controls.Add(labelShowingTime);
            panel2.Controls.Add(labelNumberLives);
            panel2.Controls.Add(labelNumberTiles);
            panel2.Controls.Add(labelBoardSize);
            panel2.Location = new Point(48, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 264);
            panel2.TabIndex = 6;
            // 
            // startGameButton
            // 
            startGameButton.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startGameButton.Location = new Point(87, 224);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(180, 37);
            startGameButton.TabIndex = 13;
            startGameButton.Text = "Start Game";
            startGameButton.UseVisualStyleBackColor = true;
            // 
            // showingTimeText
            // 
            showingTimeText.Enabled = false;
            showingTimeText.Location = new Point(204, 122);
            showingTimeText.Name = "showingTimeText";
            showingTimeText.Size = new Size(125, 27);
            showingTimeText.TabIndex = 12;
            // 
            // numberOfLivesText
            // 
            numberOfLivesText.Enabled = false;
            numberOfLivesText.Location = new Point(204, 74);
            numberOfLivesText.Name = "numberOfLivesText";
            numberOfLivesText.Size = new Size(125, 27);
            numberOfLivesText.TabIndex = 11;
            // 
            // numberOfTilesText
            // 
            numberOfTilesText.Enabled = false;
            numberOfTilesText.Location = new Point(205, 166);
            numberOfTilesText.Name = "numberOfTilesText";
            numberOfTilesText.Size = new Size(125, 27);
            numberOfTilesText.TabIndex = 11;
            // 
            // boardSizeText
            // 
            boardSizeText.Enabled = false;
            boardSizeText.Location = new Point(204, 23);
            boardSizeText.Name = "boardSizeText";
            boardSizeText.Size = new Size(125, 27);
            boardSizeText.TabIndex = 10;
            boardSizeText.TextChanged += boardSizeText_TextChanged;
            // 
            // labelShowingTime
            // 
            labelShowingTime.AutoSize = true;
            labelShowingTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowingTime.Location = new Point(23, 121);
            labelShowingTime.Name = "labelShowingTime";
            labelShowingTime.Size = new Size(125, 23);
            labelShowingTime.TabIndex = 9;
            labelShowingTime.Text = "Showing Time";
            // 
            // labelNumberLives
            // 
            labelNumberLives.AutoSize = true;
            labelNumberLives.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumberLives.Location = new Point(23, 73);
            labelNumberLives.Name = "labelNumberLives";
            labelNumberLives.Size = new Size(142, 23);
            labelNumberLives.TabIndex = 8;
            labelNumberLives.Text = "Number of Lives";
            // 
            // labelNumberTiles
            // 
            labelNumberTiles.AutoSize = true;
            labelNumberTiles.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumberTiles.Location = new Point(23, 166);
            labelNumberTiles.Name = "labelNumberTiles";
            labelNumberTiles.Size = new Size(139, 23);
            labelNumberTiles.TabIndex = 8;
            labelNumberTiles.Text = "Number of Tiles";
            // 
            // labelBoardSize
            // 
            labelBoardSize.AutoSize = true;
            labelBoardSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelBoardSize.Location = new Point(23, 23);
            labelBoardSize.Name = "labelBoardSize";
            labelBoardSize.Size = new Size(95, 23);
            labelBoardSize.TabIndex = 7;
            labelBoardSize.Text = "Board Size";
            // 
            // diffucultyBox
            // 
            diffucultyBox.FormattingEnabled = true;
            diffucultyBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Custom..." });
            diffucultyBox.Location = new Point(209, 93);
            diffucultyBox.Name = "diffucultyBox";
            diffucultyBox.Size = new Size(151, 28);
            diffucultyBox.TabIndex = 4;
            diffucultyBox.SelectedIndexChanged += diffucultyBox_SelectedIndexChanged;
            // 
            // dıffucultyLabel
            // 
            dıffucultyLabel.AutoSize = true;
            dıffucultyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dıffucultyLabel.Location = new Point(52, 93);
            dıffucultyLabel.Name = "dıffucultyLabel";
            dıffucultyLabel.Size = new Size(108, 28);
            dıffucultyLabel.TabIndex = 3;
            dıffucultyLabel.Text = "Diffuculty";
            // 
            // nameText
            // 
            nameText.Location = new Point(52, 50);
            nameText.Name = "nameText";
            nameText.Size = new Size(343, 27);
            nameText.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(625, 615);
            Controls.Add(panel1);
            Controls.Add(header);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Label nameLabel;
        private Panel panel1;
        private TextBox nameText;
        private Panel panel2;
        private Button startGameButton;
        private TextBox showingTimeText;
        private TextBox numberOfLivesText;
        private TextBox numberOfTilesText;
        private TextBox boardSizeText;
        private Label labelShowingTime;
        private Label labelNumberLives;
        private Label labelNumberTiles;
        private Label labelBoardSize;
        private ComboBox diffucultyBox;
        private Label dıffucultyLabel;
    }
}