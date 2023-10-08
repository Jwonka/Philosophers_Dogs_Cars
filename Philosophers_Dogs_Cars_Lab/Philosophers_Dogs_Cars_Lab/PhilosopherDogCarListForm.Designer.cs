//Author: Josh Werlein
//Purpose: Create an application with 3 classes of Philospher Dog and Car
//Date: 9/20/2023

namespace PhilosopherDogCar_List
{
    partial class PhilosopherDogCarListForm
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
            carGroupBox = new GroupBox();
            carListBox = new ListBox();
            carCreateButton = new Button();
            carColorComboBox = new ComboBox();
            carModelTextBox = new TextBox();
            carMakeTextBox = new TextBox();
            carColorLabel = new Label();
            carModelLabel = new Label();
            carMakeLabel = new Label();
            dogGroupBox = new GroupBox();
            dogListBox = new ListBox();
            dogCreateButton = new Button();
            dogColorComboBox = new ComboBox();
            dogWeightTextBox = new TextBox();
            dogBreedTextBox = new TextBox();
            dogColorLabel = new Label();
            dogWeightLabel = new Label();
            dogBreedLabel = new Label();
            philosopherGroupBox = new GroupBox();
            philosopherListBox = new ListBox();
            philosopherCreateButton = new Button();
            philosopherDateTimePicker = new DateTimePicker();
            philosopherQuoteTextBox = new TextBox();
            philosopherNameTextBox = new TextBox();
            philosopherQuoteLabel = new Label();
            philosopherDateLabel = new Label();
            philosopherNameLabel = new Label();
            carGroupBox.SuspendLayout();
            dogGroupBox.SuspendLayout();
            philosopherGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // carGroupBox
            // 
            carGroupBox.BackColor = Color.LightSteelBlue;
            carGroupBox.Controls.Add(carListBox);
            carGroupBox.Controls.Add(carCreateButton);
            carGroupBox.Controls.Add(carColorComboBox);
            carGroupBox.Controls.Add(carModelTextBox);
            carGroupBox.Controls.Add(carMakeTextBox);
            carGroupBox.Controls.Add(carColorLabel);
            carGroupBox.Controls.Add(carModelLabel);
            carGroupBox.Controls.Add(carMakeLabel);
            carGroupBox.Location = new Point(34, 36);
            carGroupBox.Name = "carGroupBox";
            carGroupBox.Size = new Size(725, 200);
            carGroupBox.TabIndex = 2;
            carGroupBox.TabStop = false;
            carGroupBox.Text = "Car";
            // 
            // carListBox
            // 
            carListBox.BackColor = Color.LightGray;
            carListBox.FormattingEnabled = true;
            carListBox.ItemHeight = 25;
            carListBox.Location = new Point(492, 34);
            carListBox.Name = "carListBox";
            carListBox.Size = new Size(227, 129);
            carListBox.TabIndex = 8;
            carListBox.SelectedIndexChanged += CarListBox_SelectedIndexChanged;
            // 
            // carCreateButton
            // 
            carCreateButton.AutoSize = true;
            carCreateButton.BackColor = Color.DeepSkyBlue;
            carCreateButton.Location = new Point(361, 74);
            carCreateButton.Name = "carCreateButton";
            carCreateButton.Size = new Size(125, 48);
            carCreateButton.TabIndex = 6;
            carCreateButton.Text = "Create";
            carCreateButton.UseVisualStyleBackColor = false;
            carCreateButton.Click += CarCreateButton_Click;
            // 
            // carColorComboBox
            // 
            carColorComboBox.BackColor = Color.WhiteSmoke;
            carColorComboBox.FormattingEnabled = true;
            carColorComboBox.Location = new Point(117, 147);
            carColorComboBox.Name = "carColorComboBox";
            carColorComboBox.Size = new Size(213, 33);
            carColorComboBox.TabIndex = 5;
            // 
            // carModelTextBox
            // 
            carModelTextBox.BackColor = Color.WhiteSmoke;
            carModelTextBox.Location = new Point(117, 91);
            carModelTextBox.Name = "carModelTextBox";
            carModelTextBox.Size = new Size(213, 31);
            carModelTextBox.TabIndex = 4;
            // 
            // carMakeTextBox
            // 
            carMakeTextBox.BackColor = Color.WhiteSmoke;
            carMakeTextBox.Location = new Point(117, 34);
            carMakeTextBox.Name = "carMakeTextBox";
            carMakeTextBox.Size = new Size(213, 31);
            carMakeTextBox.TabIndex = 3;
            // 
            // carColorLabel
            // 
            carColorLabel.Location = new Point(38, 147);
            carColorLabel.Name = "carColorLabel";
            carColorLabel.Size = new Size(88, 30);
            carColorLabel.TabIndex = 2;
            carColorLabel.Text = "Color:";
            // 
            // carModelLabel
            // 
            carModelLabel.Location = new Point(38, 91);
            carModelLabel.Name = "carModelLabel";
            carModelLabel.Size = new Size(88, 30);
            carModelLabel.TabIndex = 1;
            carModelLabel.Text = "Model:";
            // 
            // carMakeLabel
            // 
            carMakeLabel.Location = new Point(38, 34);
            carMakeLabel.Name = "carMakeLabel";
            carMakeLabel.Size = new Size(88, 30);
            carMakeLabel.TabIndex = 0;
            carMakeLabel.Text = "Make:";
            // 
            // dogGroupBox
            // 
            dogGroupBox.BackColor = Color.LightSteelBlue;
            dogGroupBox.Controls.Add(dogListBox);
            dogGroupBox.Controls.Add(dogCreateButton);
            dogGroupBox.Controls.Add(dogColorComboBox);
            dogGroupBox.Controls.Add(dogWeightTextBox);
            dogGroupBox.Controls.Add(dogBreedTextBox);
            dogGroupBox.Controls.Add(dogColorLabel);
            dogGroupBox.Controls.Add(dogWeightLabel);
            dogGroupBox.Controls.Add(dogBreedLabel);
            dogGroupBox.Location = new Point(34, 242);
            dogGroupBox.Name = "dogGroupBox";
            dogGroupBox.Size = new Size(725, 200);
            dogGroupBox.TabIndex = 3;
            dogGroupBox.TabStop = false;
            dogGroupBox.Text = "Dog";
            // 
            // dogListBox
            // 
            dogListBox.BackColor = Color.LightGray;
            dogListBox.FormattingEnabled = true;
            dogListBox.ItemHeight = 25;
            dogListBox.Location = new Point(492, 38);
            dogListBox.Name = "dogListBox";
            dogListBox.Size = new Size(227, 129);
            dogListBox.TabIndex = 9;
            dogListBox.SelectedIndexChanged += DogListBox_SelectedIndexChanged;
            // 
            // dogCreateButton
            // 
            dogCreateButton.AutoSize = true;
            dogCreateButton.BackColor = Color.DeepSkyBlue;
            dogCreateButton.Location = new Point(361, 77);
            dogCreateButton.Name = "dogCreateButton";
            dogCreateButton.Size = new Size(125, 48);
            dogCreateButton.TabIndex = 7;
            dogCreateButton.Text = "Create";
            dogCreateButton.UseVisualStyleBackColor = false;
            dogCreateButton.Click += DogCreateButton_Click;
            // 
            // dogColorComboBox
            // 
            dogColorComboBox.BackColor = Color.WhiteSmoke;
            dogColorComboBox.FormattingEnabled = true;
            dogColorComboBox.Location = new Point(117, 151);
            dogColorComboBox.Name = "dogColorComboBox";
            dogColorComboBox.Size = new Size(213, 33);
            dogColorComboBox.TabIndex = 6;
            // 
            // dogWeightTextBox
            // 
            dogWeightTextBox.BackColor = Color.WhiteSmoke;
            dogWeightTextBox.Location = new Point(117, 95);
            dogWeightTextBox.Name = "dogWeightTextBox";
            dogWeightTextBox.Size = new Size(213, 31);
            dogWeightTextBox.TabIndex = 5;
            // 
            // dogBreedTextBox
            // 
            dogBreedTextBox.BackColor = Color.WhiteSmoke;
            dogBreedTextBox.Location = new Point(117, 38);
            dogBreedTextBox.Name = "dogBreedTextBox";
            dogBreedTextBox.Size = new Size(213, 31);
            dogBreedTextBox.TabIndex = 4;
            // 
            // dogColorLabel
            // 
            dogColorLabel.Location = new Point(38, 151);
            dogColorLabel.Name = "dogColorLabel";
            dogColorLabel.Size = new Size(88, 30);
            dogColorLabel.TabIndex = 3;
            dogColorLabel.Text = "Color:";
            // 
            // dogWeightLabel
            // 
            dogWeightLabel.Location = new Point(38, 95);
            dogWeightLabel.Name = "dogWeightLabel";
            dogWeightLabel.Size = new Size(88, 30);
            dogWeightLabel.TabIndex = 2;
            dogWeightLabel.Text = "Weight:";
            // 
            // dogBreedLabel
            // 
            dogBreedLabel.Location = new Point(38, 38);
            dogBreedLabel.Name = "dogBreedLabel";
            dogBreedLabel.Size = new Size(88, 30);
            dogBreedLabel.TabIndex = 1;
            dogBreedLabel.Text = "Breed:";
            // 
            // philosopherGroupBox
            // 
            philosopherGroupBox.BackColor = Color.LightSteelBlue;
            philosopherGroupBox.Controls.Add(philosopherListBox);
            philosopherGroupBox.Controls.Add(philosopherCreateButton);
            philosopherGroupBox.Controls.Add(philosopherDateTimePicker);
            philosopherGroupBox.Controls.Add(philosopherQuoteTextBox);
            philosopherGroupBox.Controls.Add(philosopherNameTextBox);
            philosopherGroupBox.Controls.Add(philosopherQuoteLabel);
            philosopherGroupBox.Controls.Add(philosopherDateLabel);
            philosopherGroupBox.Controls.Add(philosopherNameLabel);
            philosopherGroupBox.Location = new Point(34, 448);
            philosopherGroupBox.Name = "philosopherGroupBox";
            philosopherGroupBox.Size = new Size(725, 200);
            philosopherGroupBox.TabIndex = 4;
            philosopherGroupBox.TabStop = false;
            philosopherGroupBox.Text = "Philosopher";
            // 
            // philosopherListBox
            // 
            philosopherListBox.BackColor = Color.LightGray;
            philosopherListBox.FormattingEnabled = true;
            philosopherListBox.ItemHeight = 25;
            philosopherListBox.Location = new Point(492, 30);
            philosopherListBox.Name = "philosopherListBox";
            philosopherListBox.Size = new Size(227, 129);
            philosopherListBox.TabIndex = 9;
            philosopherListBox.SelectedIndexChanged += PhilosopherListBox_SelectedIndexChanged;
            // 
            // philosopherCreateButton
            // 
            philosopherCreateButton.AutoSize = true;
            philosopherCreateButton.BackColor = Color.DeepSkyBlue;
            philosopherCreateButton.Location = new Point(361, 70);
            philosopherCreateButton.Name = "philosopherCreateButton";
            philosopherCreateButton.Size = new Size(125, 48);
            philosopherCreateButton.TabIndex = 7;
            philosopherCreateButton.Text = "Create";
            philosopherCreateButton.UseVisualStyleBackColor = false;
            philosopherCreateButton.Click += PhilosopherCreateButton_Click;
            // 
            // philosopherDateTimePicker
            // 
            philosopherDateTimePicker.Location = new Point(117, 143);
            philosopherDateTimePicker.Name = "philosopherDateTimePicker";
            philosopherDateTimePicker.Size = new Size(301, 31);
            philosopherDateTimePicker.TabIndex = 6;
            // 
            // philosopherQuoteTextBox
            // 
            philosopherQuoteTextBox.BackColor = Color.WhiteSmoke;
            philosopherQuoteTextBox.Location = new Point(117, 87);
            philosopherQuoteTextBox.Name = "philosopherQuoteTextBox";
            philosopherQuoteTextBox.Size = new Size(216, 31);
            philosopherQuoteTextBox.TabIndex = 5;
            // 
            // philosopherNameTextBox
            // 
            philosopherNameTextBox.BackColor = Color.WhiteSmoke;
            philosopherNameTextBox.Location = new Point(117, 30);
            philosopherNameTextBox.Name = "philosopherNameTextBox";
            philosopherNameTextBox.Size = new Size(213, 31);
            philosopherNameTextBox.TabIndex = 4;
            // 
            // philosopherQuoteLabel
            // 
            philosopherQuoteLabel.Location = new Point(38, 88);
            philosopherQuoteLabel.Name = "philosopherQuoteLabel";
            philosopherQuoteLabel.Size = new Size(88, 30);
            philosopherQuoteLabel.TabIndex = 3;
            philosopherQuoteLabel.Text = "Quote";
            // 
            // philosopherDateLabel
            // 
            philosopherDateLabel.Location = new Point(38, 143);
            philosopherDateLabel.Name = "philosopherDateLabel";
            philosopherDateLabel.Size = new Size(88, 30);
            philosopherDateLabel.TabIndex = 2;
            philosopherDateLabel.Text = "Date:";
            // 
            // philosopherNameLabel
            // 
            philosopherNameLabel.Location = new Point(38, 30);
            philosopherNameLabel.Name = "philosopherNameLabel";
            philosopherNameLabel.Size = new Size(88, 30);
            philosopherNameLabel.TabIndex = 1;
            philosopherNameLabel.Text = "Name:";
            // 
            // PhilosopherDogCarListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 678);
            Controls.Add(philosopherGroupBox);
            Controls.Add(dogGroupBox);
            Controls.Add(carGroupBox);
            Name = "PhilosopherDogCarListForm";
            Text = "Three Classes";
            Load += PhilosopherDogCarList_Load;
            carGroupBox.ResumeLayout(false);
            carGroupBox.PerformLayout();
            dogGroupBox.ResumeLayout(false);
            dogGroupBox.PerformLayout();
            philosopherGroupBox.ResumeLayout(false);
            philosopherGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox carGroupBox;
        private Label carModelLabel;
        private Label carMakeLabel;
        private GroupBox dogGroupBox;
        private Label dogWeightLabel;
        private Label dogBreedLabel;
        private GroupBox philosopherGroupBox;
        private Label philosopherNameLabel;
        private Label carColorLabel;
        private Label dogColorLabel;
        private Label philosopherQuoteLabel;
        private Label philosopherDateLabel;
        private TextBox carMakeTextBox;
        private ComboBox carColorComboBox;
        private TextBox carModelTextBox;
        private ComboBox dogColorComboBox;
        private TextBox dogWeightTextBox;
        private TextBox dogBreedTextBox;
        private DateTimePicker philosopherDateTimePicker;
        private TextBox philosopherQuoteTextBox;
        private TextBox philosopherNameTextBox;
        private ListBox carListBox;
        private Button carCreateButton;
        private ListBox dogListBox;
        private Button dogCreateButton;
        private Button philosopherCreateButton;
        private ListBox philosopherListBox;
    }
}