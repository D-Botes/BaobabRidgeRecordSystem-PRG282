namespace BaobabRidgeRecordSystem
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lblAnimalID = new Label();
            lblName = new Label();
            lblSpecies = new Label();
            lblAge = new Label();
            lblScore = new Label();
            txtAnimalID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtScore = new TextBox();
            btnAdd = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            lblSearchID = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblTotalCaption = new Label();
            lblTotalValue = new Label();
            lblAvgAgeCaption = new Label();
            lblAvgAgeValue = new Label();
            lblAvgScoreCaption = new Label();
            lblAvgScoreValue = new Label();
            lblCriticalCaption = new Label();
            lblCriticalValue = new Label();
            lblSeriousCaption = new Label();
            lblSeriousValue = new Label();
            lblStableCaption = new Label();
            lblStableValue = new Label();
            lblRecoveryCaption = new Label();
            lblRecoveryValue = new Label();
            lblReleaseReadyCaption = new Label();
            lblReleaseReadyValue = new Label();
            btnGenerate = new Button();
            dgvAnimals = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtScore);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtSpecies);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtAnimalID);
            groupBox1.Controls.Add(lblScore);
            groupBox1.Controls.Add(lblAge);
            groupBox1.Controls.Add(lblSpecies);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblAnimalID);
            groupBox1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(50, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 419);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Animal Details";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(lblSearchID);
            groupBox2.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(442, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 134);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGenerate);
            groupBox3.Controls.Add(lblReleaseReadyValue);
            groupBox3.Controls.Add(lblReleaseReadyCaption);
            groupBox3.Controls.Add(lblRecoveryValue);
            groupBox3.Controls.Add(lblRecoveryCaption);
            groupBox3.Controls.Add(lblStableValue);
            groupBox3.Controls.Add(lblStableCaption);
            groupBox3.Controls.Add(lblSeriousValue);
            groupBox3.Controls.Add(lblSeriousCaption);
            groupBox3.Controls.Add(lblCriticalValue);
            groupBox3.Controls.Add(lblCriticalCaption);
            groupBox3.Controls.Add(lblAvgScoreValue);
            groupBox3.Controls.Add(lblAvgScoreCaption);
            groupBox3.Controls.Add(lblAvgAgeValue);
            groupBox3.Controls.Add(lblAvgAgeCaption);
            groupBox3.Controls.Add(lblTotalValue);
            groupBox3.Controls.Add(lblTotalCaption);
            groupBox3.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(442, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 294);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Summary";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnimalID.Location = new Point(43, 54);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(67, 16);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID:";
            lblAnimalID.Click += lblAnimalID_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(43, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 16);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpecies.Location = new Point(43, 123);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(58, 16);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(43, 158);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 16);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(43, 193);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(102, 16);
            lblScore.TabIndex = 4;
            lblScore.Text = "Recovery Score:";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(116, 47);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(138, 29);
            txtAnimalID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(138, 29);
            txtName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(116, 116);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(138, 29);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(116, 151);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(138, 29);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(116, 186);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(138, 29);
            txtScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 274);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(154, 274);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(30, 323);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 323);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblSearchID
            // 
            lblSearchID.AutoSize = true;
            lblSearchID.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchID.Location = new Point(27, 38);
            lblSearchID.Name = "lblSearchID";
            lblSearchID.Size = new Size(67, 16);
            lblSearchID.TabIndex = 12;
            lblSearchID.Text = "Animal ID:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(111, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(183, 32);
            txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(114, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(175, 34);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCaption.Location = new Point(27, 62);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(87, 16);
            lblTotalCaption.TabIndex = 13;
            lblTotalCaption.Text = "Total animals:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(169, 62);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(14, 16);
            lblTotalValue.TabIndex = 14;
            lblTotalValue.Text = "0";
            // 
            // lblAvgAgeCaption
            // 
            lblAvgAgeCaption.AutoSize = true;
            lblAvgAgeCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgAgeCaption.Location = new Point(27, 88);
            lblAvgAgeCaption.Name = "lblAvgAgeCaption";
            lblAvgAgeCaption.Size = new Size(82, 16);
            lblAvgAgeCaption.TabIndex = 15;
            lblAvgAgeCaption.Text = "Average age:";
            // 
            // lblAvgAgeValue
            // 
            lblAvgAgeValue.AutoSize = true;
            lblAvgAgeValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgAgeValue.Location = new Point(169, 88);
            lblAvgAgeValue.Name = "lblAvgAgeValue";
            lblAvgAgeValue.Size = new Size(29, 16);
            lblAvgAgeValue.TabIndex = 16;
            lblAvgAgeValue.Text = "N/A";
            // 
            // lblAvgScoreCaption
            // 
            lblAvgScoreCaption.AutoSize = true;
            lblAvgScoreCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgScoreCaption.Location = new Point(27, 114);
            lblAvgScoreCaption.Name = "lblAvgScoreCaption";
            lblAvgScoreCaption.Size = new Size(93, 16);
            lblAvgScoreCaption.TabIndex = 17;
            lblAvgScoreCaption.Text = "Average score:";
            // 
            // lblAvgScoreValue
            // 
            lblAvgScoreValue.AutoSize = true;
            lblAvgScoreValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgScoreValue.Location = new Point(169, 114);
            lblAvgScoreValue.Name = "lblAvgScoreValue";
            lblAvgScoreValue.Size = new Size(29, 16);
            lblAvgScoreValue.TabIndex = 18;
            lblAvgScoreValue.Text = "N/A";
            // 
            // lblCriticalCaption
            // 
            lblCriticalCaption.AutoSize = true;
            lblCriticalCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCriticalCaption.Location = new Point(27, 139);
            lblCriticalCaption.Name = "lblCriticalCaption";
            lblCriticalCaption.Size = new Size(51, 16);
            lblCriticalCaption.TabIndex = 19;
            lblCriticalCaption.Text = "Critical:";
            // 
            // lblCriticalValue
            // 
            lblCriticalValue.AutoSize = true;
            lblCriticalValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCriticalValue.Location = new Point(169, 139);
            lblCriticalValue.Name = "lblCriticalValue";
            lblCriticalValue.Size = new Size(14, 16);
            lblCriticalValue.TabIndex = 13;
            lblCriticalValue.Text = "0";
            // 
            // lblSeriousCaption
            // 
            lblSeriousCaption.AutoSize = true;
            lblSeriousCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeriousCaption.Location = new Point(27, 161);
            lblSeriousCaption.Name = "lblSeriousCaption";
            lblSeriousCaption.Size = new Size(55, 16);
            lblSeriousCaption.TabIndex = 20;
            lblSeriousCaption.Text = "Serious:";
            // 
            // lblSeriousValue
            // 
            lblSeriousValue.AutoSize = true;
            lblSeriousValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeriousValue.Location = new Point(169, 161);
            lblSeriousValue.Name = "lblSeriousValue";
            lblSeriousValue.Size = new Size(14, 16);
            lblSeriousValue.TabIndex = 21;
            lblSeriousValue.Text = "0";
            // 
            // lblStableCaption
            // 
            lblStableCaption.AutoSize = true;
            lblStableCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStableCaption.Location = new Point(27, 186);
            lblStableCaption.Name = "lblStableCaption";
            lblStableCaption.Size = new Size(48, 16);
            lblStableCaption.TabIndex = 22;
            lblStableCaption.Text = "Stable:";
            // 
            // lblStableValue
            // 
            lblStableValue.AutoSize = true;
            lblStableValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStableValue.Location = new Point(169, 186);
            lblStableValue.Name = "lblStableValue";
            lblStableValue.Size = new Size(14, 16);
            lblStableValue.TabIndex = 23;
            lblStableValue.Text = "0";
            // 
            // lblRecoveryCaption
            // 
            lblRecoveryCaption.AutoSize = true;
            lblRecoveryCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecoveryCaption.Location = new Point(27, 210);
            lblRecoveryCaption.Name = "lblRecoveryCaption";
            lblRecoveryCaption.Size = new Size(74, 16);
            lblRecoveryCaption.TabIndex = 24;
            lblRecoveryCaption.Text = "Recovering:";
            // 
            // lblRecoveryValue
            // 
            lblRecoveryValue.AutoSize = true;
            lblRecoveryValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecoveryValue.Location = new Point(169, 210);
            lblRecoveryValue.Name = "lblRecoveryValue";
            lblRecoveryValue.Size = new Size(14, 16);
            lblRecoveryValue.TabIndex = 25;
            lblRecoveryValue.Text = "0";
            // 
            // lblReleaseReadyCaption
            // 
            lblReleaseReadyCaption.AutoSize = true;
            lblReleaseReadyCaption.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReleaseReadyCaption.Location = new Point(27, 235);
            lblReleaseReadyCaption.Name = "lblReleaseReadyCaption";
            lblReleaseReadyCaption.Size = new Size(99, 16);
            lblReleaseReadyCaption.TabIndex = 26;
            lblReleaseReadyCaption.Text = "Release-Ready:";
            // 
            // lblReleaseReadyValue
            // 
            lblReleaseReadyValue.AutoSize = true;
            lblReleaseReadyValue.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReleaseReadyValue.Location = new Point(169, 235);
            lblReleaseReadyValue.Name = "lblReleaseReadyValue";
            lblReleaseReadyValue.Size = new Size(14, 16);
            lblReleaseReadyValue.TabIndex = 27;
            lblReleaseReadyValue.Text = "0";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(189, 247);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(224, 41);
            btnGenerate.TabIndex = 28;
            btnGenerate.Text = "Generate Summary";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(50, 460);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(824, 200);
            dgvAnimals.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(dgvAnimals);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Baobab Ridge Records System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblAnimalID;
        private Button btnAdd;
        private TextBox txtScore;
        private TextBox txtAge;
        private TextBox txtSpecies;
        private TextBox txtName;
        private TextBox txtAnimalID;
        private Label lblScore;
        private Label lblAge;
        private Label lblSpecies;
        private Label lblName;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearchID;
        private Label lblSeriousValue;
        private Label lblSeriousCaption;
        private Label lblCriticalValue;
        private Label lblCriticalCaption;
        private Label lblAvgScoreValue;
        private Label lblAvgScoreCaption;
        private Label lblAvgAgeValue;
        private Label lblAvgAgeCaption;
        private Label lblTotalValue;
        private Label lblTotalCaption;
        private Button btnGenerate;
        private Label lblReleaseReadyValue;
        private Label lblReleaseReadyCaption;
        private Label lblRecoveryValue;
        private Label lblRecoveryCaption;
        private Label lblStableValue;
        private Label lblStableCaption;
        private DataGridView dgvAnimals;
    }
}
