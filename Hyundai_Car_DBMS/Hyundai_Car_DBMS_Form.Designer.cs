namespace Hyundai_Car_DBMS
{
    partial class Hyundai_Car_DBMS_Form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab = new System.Windows.Forms.TabControl();
            this.AppointmentTabPage = new System.Windows.Forms.TabPage();
            this.AppointmentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AppointmentDrivingDistanceLabel = new System.Windows.Forms.Label();
            this.AppointmentDateTimeLabel = new System.Windows.Forms.Label();
            this.AppointmentEndFuelTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentEndLabel = new System.Windows.Forms.Label();
            this.AppointmentEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentEndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentEndDrivingDistanceTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentStartDrivingDistanceTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentStartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentStartLabel = new System.Windows.Forms.Label();
            this.AppointmentFuelLabel = new System.Windows.Forms.Label();
            this.AppointmentStartFuelTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.AppointmentLocationComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AppointmentCommentLabel = new System.Windows.Forms.Label();
            this.AppointmentCarComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentCarLabel = new System.Windows.Forms.Label();
            this.AppointmentChangeButton = new System.Windows.Forms.Button();
            this.AppointmentDeleteButton = new System.Windows.Forms.Button();
            this.AppointmentPersonComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentLocationTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentLocationLabel = new System.Windows.Forms.Label();
            this.AppointmentPersonLabel = new System.Windows.Forms.Label();
            this.AppointmentListView = new System.Windows.Forms.ListView();
            this.AppointmentAddButton = new System.Windows.Forms.Button();
            this.CarTabPage = new System.Windows.Forms.TabPage();
            this.CarViegnetteComboBox = new System.Windows.Forms.ComboBox();
            this.CarViegnetteLabel = new System.Windows.Forms.Label();
            this.CarTUVDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CarTUVDateLabel = new System.Windows.Forms.Label();
            this.CarLeasingCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.CarTyreTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CarTyreTypeLabel = new System.Windows.Forms.Label();
            this.CarLeasingCompanyLabel = new System.Windows.Forms.Label();
            this.CarCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CarCommentLabel = new System.Windows.Forms.Label();
            this.CarChangeButton = new System.Windows.Forms.Button();
            this.CarDeleteButton = new System.Windows.Forms.Button();
            this.CarListView = new System.Windows.Forms.ListView();
            this.CarPlateTextBox = new System.Windows.Forms.TextBox();
            this.CarPlateLabel = new System.Windows.Forms.Label();
            this.CarAddButton = new System.Windows.Forms.Button();
            this.PersonTabPage = new System.Windows.Forms.TabPage();
            this.PersonChangeButton = new System.Windows.Forms.Button();
            this.PersonCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PersonCommentLabel = new System.Windows.Forms.Label();
            this.PersonDeleteButton = new System.Windows.Forms.Button();
            this.PersonAddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PersonAddressLabel = new System.Windows.Forms.Label();
            this.PersonPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PersonPhoneNumberLabel = new System.Windows.Forms.Label();
            this.PersonSurnameTextBox = new System.Windows.Forms.TextBox();
            this.PersonSurnameLabel = new System.Windows.Forms.Label();
            this.PersonListView = new System.Windows.Forms.ListView();
            this.PersonNameTextBox = new System.Windows.Forms.TextBox();
            this.PersonNameLabel = new System.Windows.Forms.Label();
            this.PersonAddButton = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.AppointmentTabPage.SuspendLayout();
            this.AppointmentTableLayoutPanel.SuspendLayout();
            this.CarTabPage.SuspendLayout();
            this.PersonTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.AppointmentTabPage);
            this.Tab.Controls.Add(this.CarTabPage);
            this.Tab.Controls.Add(this.PersonTabPage);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1084, 681);
            this.Tab.TabIndex = 0;
            // 
            // AppointmentTabPage
            // 
            this.AppointmentTabPage.Controls.Add(this.AppointmentTableLayoutPanel);
            this.AppointmentTabPage.Controls.Add(this.AppointmentMonthCalendar);
            this.AppointmentTabPage.Controls.Add(this.AppointmentLocationComboBox);
            this.AppointmentTabPage.Controls.Add(this.AppointmentCommentRichTextBox);
            this.AppointmentTabPage.Controls.Add(this.AppointmentCommentLabel);
            this.AppointmentTabPage.Controls.Add(this.AppointmentCarComboBox);
            this.AppointmentTabPage.Controls.Add(this.AppointmentCarLabel);
            this.AppointmentTabPage.Controls.Add(this.AppointmentChangeButton);
            this.AppointmentTabPage.Controls.Add(this.AppointmentDeleteButton);
            this.AppointmentTabPage.Controls.Add(this.AppointmentPersonComboBox);
            this.AppointmentTabPage.Controls.Add(this.AppointmentLocationTextBox);
            this.AppointmentTabPage.Controls.Add(this.AppointmentLocationLabel);
            this.AppointmentTabPage.Controls.Add(this.AppointmentPersonLabel);
            this.AppointmentTabPage.Controls.Add(this.AppointmentListView);
            this.AppointmentTabPage.Controls.Add(this.AppointmentAddButton);
            this.AppointmentTabPage.Location = new System.Drawing.Point(4, 22);
            this.AppointmentTabPage.Name = "AppointmentTabPage";
            this.AppointmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentTabPage.Size = new System.Drawing.Size(1076, 655);
            this.AppointmentTabPage.TabIndex = 0;
            this.AppointmentTabPage.Text = "Appointment Database";
            this.AppointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // AppointmentTableLayoutPanel
            // 
            this.AppointmentTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.AppointmentTableLayoutPanel.ColumnCount = 5;
            this.AppointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AppointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AppointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AppointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AppointmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentDrivingDistanceLabel, 3, 0);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentDateTimeLabel, 1, 0);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentEndFuelTextBox, 4, 2);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentEndLabel, 0, 2);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentEndDateDateTimePicker, 1, 2);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentEndTimeDateTimePicker, 2, 2);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentEndDrivingDistanceTextBox, 3, 2);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentStartDrivingDistanceTextBox, 3, 1);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentStartTimeDateTimePicker, 2, 1);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentStartDateDateTimePicker, 1, 1);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentStartLabel, 0, 1);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentFuelLabel, 4, 0);
            this.AppointmentTableLayoutPanel.Controls.Add(this.AppointmentStartFuelTextBox, 4, 1);
            this.AppointmentTableLayoutPanel.Location = new System.Drawing.Point(8, 421);
            this.AppointmentTableLayoutPanel.Name = "AppointmentTableLayoutPanel";
            this.AppointmentTableLayoutPanel.RowCount = 3;
            this.AppointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AppointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AppointmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AppointmentTableLayoutPanel.Size = new System.Drawing.Size(607, 69);
            this.AppointmentTableLayoutPanel.TabIndex = 47;
            // 
            // AppointmentDrivingDistanceLabel
            // 
            this.AppointmentDrivingDistanceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentDrivingDistanceLabel.AutoSize = true;
            this.AppointmentDrivingDistanceLabel.Location = new System.Drawing.Point(364, 1);
            this.AppointmentDrivingDistanceLabel.Name = "AppointmentDrivingDistanceLabel";
            this.AppointmentDrivingDistanceLabel.Size = new System.Drawing.Size(108, 13);
            this.AppointmentDrivingDistanceLabel.TabIndex = 39;
            this.AppointmentDrivingDistanceLabel.Text = "Driving Distance [km]";
            // 
            // AppointmentDateTimeLabel
            // 
            this.AppointmentDateTimeLabel.AutoSize = true;
            this.AppointmentDateTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AppointmentTableLayoutPanel.SetColumnSpan(this.AppointmentDateTimeLabel, 2);
            this.AppointmentDateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentDateTimeLabel.Location = new System.Drawing.Point(40, 1);
            this.AppointmentDateTimeLabel.Name = "AppointmentDateTimeLabel";
            this.AppointmentDateTimeLabel.Size = new System.Drawing.Size(317, 13);
            this.AppointmentDateTimeLabel.TabIndex = 41;
            this.AppointmentDateTimeLabel.Text = "Date Time";
            this.AppointmentDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppointmentEndFuelTextBox
            // 
            this.AppointmentEndFuelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentEndFuelTextBox.Location = new System.Drawing.Point(491, 45);
            this.AppointmentEndFuelTextBox.Name = "AppointmentEndFuelTextBox";
            this.AppointmentEndFuelTextBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentEndFuelTextBox.TabIndex = 43;
            // 
            // AppointmentEndLabel
            // 
            this.AppointmentEndLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentEndLabel.AutoSize = true;
            this.AppointmentEndLabel.Location = new System.Drawing.Point(5, 48);
            this.AppointmentEndLabel.Name = "AppointmentEndLabel";
            this.AppointmentEndLabel.Size = new System.Drawing.Size(26, 13);
            this.AppointmentEndLabel.TabIndex = 36;
            this.AppointmentEndLabel.Text = "End";
            // 
            // AppointmentEndDateDateTimePicker
            // 
            this.AppointmentEndDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentEndDateDateTimePicker.Location = new System.Drawing.Point(40, 45);
            this.AppointmentEndDateDateTimePicker.Name = "AppointmentEndDateDateTimePicker";
            this.AppointmentEndDateDateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.AppointmentEndDateDateTimePicker.TabIndex = 37;
            this.AppointmentEndDateDateTimePicker.Value = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            // 
            // AppointmentEndTimeDateTimePicker
            // 
            this.AppointmentEndTimeDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentEndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AppointmentEndTimeDateTimePicker.Location = new System.Drawing.Point(267, 45);
            this.AppointmentEndTimeDateTimePicker.Name = "AppointmentEndTimeDateTimePicker";
            this.AppointmentEndTimeDateTimePicker.ShowUpDown = true;
            this.AppointmentEndTimeDateTimePicker.Size = new System.Drawing.Size(90, 20);
            this.AppointmentEndTimeDateTimePicker.TabIndex = 38;
            this.AppointmentEndTimeDateTimePicker.Value = new System.DateTime(2021, 10, 9, 0, 0, 0, 0);
            // 
            // AppointmentEndDrivingDistanceTextBox
            // 
            this.AppointmentEndDrivingDistanceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentEndDrivingDistanceTextBox.Location = new System.Drawing.Point(368, 45);
            this.AppointmentEndDrivingDistanceTextBox.Name = "AppointmentEndDrivingDistanceTextBox";
            this.AppointmentEndDrivingDistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentEndDrivingDistanceTextBox.TabIndex = 45;
            // 
            // AppointmentStartDrivingDistanceTextBox
            // 
            this.AppointmentStartDrivingDistanceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentStartDrivingDistanceTextBox.Location = new System.Drawing.Point(368, 18);
            this.AppointmentStartDrivingDistanceTextBox.Name = "AppointmentStartDrivingDistanceTextBox";
            this.AppointmentStartDrivingDistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentStartDrivingDistanceTextBox.TabIndex = 46;
            // 
            // AppointmentStartTimeDateTimePicker
            // 
            this.AppointmentStartTimeDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentStartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AppointmentStartTimeDateTimePicker.Location = new System.Drawing.Point(267, 18);
            this.AppointmentStartTimeDateTimePicker.Name = "AppointmentStartTimeDateTimePicker";
            this.AppointmentStartTimeDateTimePicker.ShowUpDown = true;
            this.AppointmentStartTimeDateTimePicker.Size = new System.Drawing.Size(90, 20);
            this.AppointmentStartTimeDateTimePicker.TabIndex = 34;
            this.AppointmentStartTimeDateTimePicker.Value = new System.DateTime(2021, 10, 9, 0, 0, 0, 0);
            // 
            // AppointmentStartDateDateTimePicker
            // 
            this.AppointmentStartDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentStartDateDateTimePicker.Location = new System.Drawing.Point(40, 18);
            this.AppointmentStartDateDateTimePicker.Name = "AppointmentStartDateDateTimePicker";
            this.AppointmentStartDateDateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.AppointmentStartDateDateTimePicker.TabIndex = 23;
            this.AppointmentStartDateDateTimePicker.Value = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            // 
            // AppointmentStartLabel
            // 
            this.AppointmentStartLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentStartLabel.AutoSize = true;
            this.AppointmentStartLabel.Location = new System.Drawing.Point(4, 21);
            this.AppointmentStartLabel.Name = "AppointmentStartLabel";
            this.AppointmentStartLabel.Size = new System.Drawing.Size(29, 13);
            this.AppointmentStartLabel.TabIndex = 16;
            this.AppointmentStartLabel.Text = "Start";
            // 
            // AppointmentFuelLabel
            // 
            this.AppointmentFuelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentFuelLabel.AutoSize = true;
            this.AppointmentFuelLabel.Location = new System.Drawing.Point(496, 1);
            this.AppointmentFuelLabel.Name = "AppointmentFuelLabel";
            this.AppointmentFuelLabel.Size = new System.Drawing.Size(90, 13);
            this.AppointmentFuelLabel.TabIndex = 42;
            this.AppointmentFuelLabel.Text = "Fuel [percentage]";
            // 
            // AppointmentStartFuelTextBox
            // 
            this.AppointmentStartFuelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentStartFuelTextBox.Location = new System.Drawing.Point(491, 18);
            this.AppointmentStartFuelTextBox.Name = "AppointmentStartFuelTextBox";
            this.AppointmentStartFuelTextBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentStartFuelTextBox.TabIndex = 44;
            // 
            // AppointmentMonthCalendar
            // 
            this.AppointmentMonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.AppointmentMonthCalendar.Location = new System.Drawing.Point(835, 335);
            this.AppointmentMonthCalendar.Name = "AppointmentMonthCalendar";
            this.AppointmentMonthCalendar.ShowToday = false;
            this.AppointmentMonthCalendar.ShowTodayCircle = false;
            this.AppointmentMonthCalendar.TabIndex = 35;
            // 
            // AppointmentLocationComboBox
            // 
            this.AppointmentLocationComboBox.FormattingEnabled = true;
            this.AppointmentLocationComboBox.Location = new System.Drawing.Point(69, 382);
            this.AppointmentLocationComboBox.Name = "AppointmentLocationComboBox";
            this.AppointmentLocationComboBox.Size = new System.Drawing.Size(206, 21);
            this.AppointmentLocationComboBox.TabIndex = 33;
            this.AppointmentLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.AppointmentLocationComboBox_SelectedIndexChanged);
            // 
            // AppointmentCommentRichTextBox
            // 
            this.AppointmentCommentRichTextBox.Location = new System.Drawing.Point(347, 329);
            this.AppointmentCommentRichTextBox.Name = "AppointmentCommentRichTextBox";
            this.AppointmentCommentRichTextBox.Size = new System.Drawing.Size(395, 86);
            this.AppointmentCommentRichTextBox.TabIndex = 32;
            this.AppointmentCommentRichTextBox.Text = "";
            // 
            // AppointmentCommentLabel
            // 
            this.AppointmentCommentLabel.AutoSize = true;
            this.AppointmentCommentLabel.Location = new System.Drawing.Point(281, 332);
            this.AppointmentCommentLabel.Name = "AppointmentCommentLabel";
            this.AppointmentCommentLabel.Size = new System.Drawing.Size(60, 13);
            this.AppointmentCommentLabel.TabIndex = 31;
            this.AppointmentCommentLabel.Text = "Comment : ";
            // 
            // AppointmentCarComboBox
            // 
            this.AppointmentCarComboBox.FormattingEnabled = true;
            this.AppointmentCarComboBox.Location = new System.Drawing.Point(69, 329);
            this.AppointmentCarComboBox.Name = "AppointmentCarComboBox";
            this.AppointmentCarComboBox.Size = new System.Drawing.Size(206, 21);
            this.AppointmentCarComboBox.TabIndex = 30;
            this.AppointmentCarComboBox.SelectedIndexChanged += new System.EventHandler(this.AppointmentCarComboBox_SelectedIndexChanged);
            // 
            // AppointmentCarLabel
            // 
            this.AppointmentCarLabel.AutoSize = true;
            this.AppointmentCarLabel.Location = new System.Drawing.Point(31, 332);
            this.AppointmentCarLabel.Name = "AppointmentCarLabel";
            this.AppointmentCarLabel.Size = new System.Drawing.Size(32, 13);
            this.AppointmentCarLabel.TabIndex = 29;
            this.AppointmentCarLabel.Text = "Car : ";
            // 
            // AppointmentChangeButton
            // 
            this.AppointmentChangeButton.Location = new System.Drawing.Point(748, 360);
            this.AppointmentChangeButton.Name = "AppointmentChangeButton";
            this.AppointmentChangeButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentChangeButton.TabIndex = 28;
            this.AppointmentChangeButton.Text = "Change";
            this.AppointmentChangeButton.UseVisualStyleBackColor = true;
            this.AppointmentChangeButton.Click += new System.EventHandler(this.AppointmentChangeButton_Click);
            // 
            // AppointmentDeleteButton
            // 
            this.AppointmentDeleteButton.Location = new System.Drawing.Point(748, 389);
            this.AppointmentDeleteButton.Name = "AppointmentDeleteButton";
            this.AppointmentDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentDeleteButton.TabIndex = 27;
            this.AppointmentDeleteButton.Text = "Delete";
            this.AppointmentDeleteButton.UseVisualStyleBackColor = true;
            this.AppointmentDeleteButton.Click += new System.EventHandler(this.AppointmentDeleteButton_Click);
            // 
            // AppointmentPersonComboBox
            // 
            this.AppointmentPersonComboBox.FormattingEnabled = true;
            this.AppointmentPersonComboBox.Location = new System.Drawing.Point(69, 355);
            this.AppointmentPersonComboBox.Name = "AppointmentPersonComboBox";
            this.AppointmentPersonComboBox.Size = new System.Drawing.Size(206, 21);
            this.AppointmentPersonComboBox.TabIndex = 24;
            this.AppointmentPersonComboBox.SelectedIndexChanged += new System.EventHandler(this.AppointmentPersonComboBox_SelectedIndexChanged);
            // 
            // AppointmentLocationTextBox
            // 
            this.AppointmentLocationTextBox.Location = new System.Drawing.Point(69, 383);
            this.AppointmentLocationTextBox.Name = "AppointmentLocationTextBox";
            this.AppointmentLocationTextBox.Size = new System.Drawing.Size(206, 20);
            this.AppointmentLocationTextBox.TabIndex = 22;
            // 
            // AppointmentLocationLabel
            // 
            this.AppointmentLocationLabel.AutoSize = true;
            this.AppointmentLocationLabel.Location = new System.Drawing.Point(8, 386);
            this.AppointmentLocationLabel.Name = "AppointmentLocationLabel";
            this.AppointmentLocationLabel.Size = new System.Drawing.Size(57, 13);
            this.AppointmentLocationLabel.TabIndex = 21;
            this.AppointmentLocationLabel.Text = "Location : ";
            // 
            // AppointmentPersonLabel
            // 
            this.AppointmentPersonLabel.AutoSize = true;
            this.AppointmentPersonLabel.Location = new System.Drawing.Point(16, 358);
            this.AppointmentPersonLabel.Name = "AppointmentPersonLabel";
            this.AppointmentPersonLabel.Size = new System.Drawing.Size(49, 13);
            this.AppointmentPersonLabel.TabIndex = 19;
            this.AppointmentPersonLabel.Text = "Person : ";
            // 
            // AppointmentListView
            // 
            this.AppointmentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AppointmentListView.HideSelection = false;
            this.AppointmentListView.Location = new System.Drawing.Point(6, 6);
            this.AppointmentListView.MultiSelect = false;
            this.AppointmentListView.Name = "AppointmentListView";
            this.AppointmentListView.Size = new System.Drawing.Size(1062, 317);
            this.AppointmentListView.TabIndex = 18;
            this.AppointmentListView.UseCompatibleStateImageBehavior = false;
            this.AppointmentListView.View = System.Windows.Forms.View.Details;
            this.AppointmentListView.SelectedIndexChanged += new System.EventHandler(this.AppointmentListView_SelectedIndexChanged);
            // 
            // AppointmentAddButton
            // 
            this.AppointmentAddButton.Location = new System.Drawing.Point(748, 329);
            this.AppointmentAddButton.Name = "AppointmentAddButton";
            this.AppointmentAddButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentAddButton.TabIndex = 15;
            this.AppointmentAddButton.Text = "Add";
            this.AppointmentAddButton.UseVisualStyleBackColor = true;
            this.AppointmentAddButton.Click += new System.EventHandler(this.AppointmentAddButton_Click);
            // 
            // CarTabPage
            // 
            this.CarTabPage.Controls.Add(this.CarViegnetteComboBox);
            this.CarTabPage.Controls.Add(this.CarViegnetteLabel);
            this.CarTabPage.Controls.Add(this.CarTUVDateDateTimePicker);
            this.CarTabPage.Controls.Add(this.CarTUVDateLabel);
            this.CarTabPage.Controls.Add(this.CarLeasingCompanyComboBox);
            this.CarTabPage.Controls.Add(this.CarTyreTypeComboBox);
            this.CarTabPage.Controls.Add(this.CarTyreTypeLabel);
            this.CarTabPage.Controls.Add(this.CarLeasingCompanyLabel);
            this.CarTabPage.Controls.Add(this.CarCommentRichTextBox);
            this.CarTabPage.Controls.Add(this.CarCommentLabel);
            this.CarTabPage.Controls.Add(this.CarChangeButton);
            this.CarTabPage.Controls.Add(this.CarDeleteButton);
            this.CarTabPage.Controls.Add(this.CarListView);
            this.CarTabPage.Controls.Add(this.CarPlateTextBox);
            this.CarTabPage.Controls.Add(this.CarPlateLabel);
            this.CarTabPage.Controls.Add(this.CarAddButton);
            this.CarTabPage.Location = new System.Drawing.Point(4, 22);
            this.CarTabPage.Name = "CarTabPage";
            this.CarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CarTabPage.Size = new System.Drawing.Size(1076, 655);
            this.CarTabPage.TabIndex = 1;
            this.CarTabPage.Text = "Car Database";
            this.CarTabPage.UseVisualStyleBackColor = true;
            // 
            // CarViegnetteComboBox
            // 
            this.CarViegnetteComboBox.FormattingEnabled = true;
            this.CarViegnetteComboBox.Location = new System.Drawing.Point(118, 518);
            this.CarViegnetteComboBox.Name = "CarViegnetteComboBox";
            this.CarViegnetteComboBox.Size = new System.Drawing.Size(289, 21);
            this.CarViegnetteComboBox.TabIndex = 32;
            // 
            // CarViegnetteLabel
            // 
            this.CarViegnetteLabel.AutoSize = true;
            this.CarViegnetteLabel.Location = new System.Drawing.Point(48, 521);
            this.CarViegnetteLabel.Name = "CarViegnetteLabel";
            this.CarViegnetteLabel.Size = new System.Drawing.Size(61, 13);
            this.CarViegnetteLabel.TabIndex = 31;
            this.CarViegnetteLabel.Text = "Viegnette : ";
            // 
            // CarTUVDateDateTimePicker
            // 
            this.CarTUVDateDateTimePicker.Location = new System.Drawing.Point(118, 465);
            this.CarTUVDateDateTimePicker.Name = "CarTUVDateDateTimePicker";
            this.CarTUVDateDateTimePicker.Size = new System.Drawing.Size(289, 20);
            this.CarTUVDateDateTimePicker.TabIndex = 30;
            this.CarTUVDateDateTimePicker.Value = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            // 
            // CarTUVDateLabel
            // 
            this.CarTUVDateLabel.AutoSize = true;
            this.CarTUVDateLabel.Location = new System.Drawing.Point(48, 467);
            this.CarTUVDateLabel.Name = "CarTUVDateLabel";
            this.CarTUVDateLabel.Size = new System.Drawing.Size(64, 13);
            this.CarTUVDateLabel.TabIndex = 29;
            this.CarTUVDateLabel.Text = "TUV Date : ";
            // 
            // CarLeasingCompanyComboBox
            // 
            this.CarLeasingCompanyComboBox.FormattingEnabled = true;
            this.CarLeasingCompanyComboBox.Location = new System.Drawing.Point(118, 491);
            this.CarLeasingCompanyComboBox.Name = "CarLeasingCompanyComboBox";
            this.CarLeasingCompanyComboBox.Size = new System.Drawing.Size(289, 21);
            this.CarLeasingCompanyComboBox.TabIndex = 28;
            // 
            // CarTyreTypeComboBox
            // 
            this.CarTyreTypeComboBox.FormattingEnabled = true;
            this.CarTyreTypeComboBox.Location = new System.Drawing.Point(118, 438);
            this.CarTyreTypeComboBox.Name = "CarTyreTypeComboBox";
            this.CarTyreTypeComboBox.Size = new System.Drawing.Size(289, 21);
            this.CarTyreTypeComboBox.TabIndex = 27;
            // 
            // CarTyreTypeLabel
            // 
            this.CarTyreTypeLabel.AutoSize = true;
            this.CarTyreTypeLabel.Location = new System.Drawing.Point(48, 441);
            this.CarTyreTypeLabel.Name = "CarTyreTypeLabel";
            this.CarTyreTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.CarTyreTypeLabel.TabIndex = 26;
            this.CarTyreTypeLabel.Text = "Tyre Type : ";
            // 
            // CarLeasingCompanyLabel
            // 
            this.CarLeasingCompanyLabel.AutoSize = true;
            this.CarLeasingCompanyLabel.Location = new System.Drawing.Point(12, 494);
            this.CarLeasingCompanyLabel.Name = "CarLeasingCompanyLabel";
            this.CarLeasingCompanyLabel.Size = new System.Drawing.Size(100, 13);
            this.CarLeasingCompanyLabel.TabIndex = 24;
            this.CarLeasingCompanyLabel.Text = "Leasing Company : ";
            // 
            // CarCommentRichTextBox
            // 
            this.CarCommentRichTextBox.Location = new System.Drawing.Point(416, 438);
            this.CarCommentRichTextBox.Name = "CarCommentRichTextBox";
            this.CarCommentRichTextBox.Size = new System.Drawing.Size(573, 101);
            this.CarCommentRichTextBox.TabIndex = 23;
            this.CarCommentRichTextBox.Text = "";
            // 
            // CarCommentLabel
            // 
            this.CarCommentLabel.AutoSize = true;
            this.CarCommentLabel.Location = new System.Drawing.Point(413, 415);
            this.CarCommentLabel.Name = "CarCommentLabel";
            this.CarCommentLabel.Size = new System.Drawing.Size(60, 13);
            this.CarCommentLabel.TabIndex = 22;
            this.CarCommentLabel.Text = "Comment : ";
            // 
            // CarChangeButton
            // 
            this.CarChangeButton.Location = new System.Drawing.Point(995, 467);
            this.CarChangeButton.Name = "CarChangeButton";
            this.CarChangeButton.Size = new System.Drawing.Size(75, 23);
            this.CarChangeButton.TabIndex = 21;
            this.CarChangeButton.Text = "Change";
            this.CarChangeButton.UseVisualStyleBackColor = true;
            this.CarChangeButton.Click += new System.EventHandler(this.CarChangeButton_Click);
            // 
            // CarDeleteButton
            // 
            this.CarDeleteButton.Location = new System.Drawing.Point(995, 496);
            this.CarDeleteButton.Name = "CarDeleteButton";
            this.CarDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.CarDeleteButton.TabIndex = 6;
            this.CarDeleteButton.Text = "Delete";
            this.CarDeleteButton.UseVisualStyleBackColor = true;
            this.CarDeleteButton.Click += new System.EventHandler(this.CarDeleteButton_Click);
            // 
            // CarListView
            // 
            this.CarListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CarListView.HideSelection = false;
            this.CarListView.Location = new System.Drawing.Point(8, 6);
            this.CarListView.MultiSelect = false;
            this.CarListView.Name = "CarListView";
            this.CarListView.Size = new System.Drawing.Size(1060, 400);
            this.CarListView.TabIndex = 5;
            this.CarListView.UseCompatibleStateImageBehavior = false;
            this.CarListView.View = System.Windows.Forms.View.Details;
            this.CarListView.SelectedIndexChanged += new System.EventHandler(this.CarListView_SelectedIndexChanged);
            // 
            // CarPlateTextBox
            // 
            this.CarPlateTextBox.Location = new System.Drawing.Point(118, 412);
            this.CarPlateTextBox.Name = "CarPlateTextBox";
            this.CarPlateTextBox.Size = new System.Drawing.Size(289, 20);
            this.CarPlateTextBox.TabIndex = 2;
            // 
            // CarPlateLabel
            // 
            this.CarPlateLabel.AutoSize = true;
            this.CarPlateLabel.Location = new System.Drawing.Point(72, 415);
            this.CarPlateLabel.Name = "CarPlateLabel";
            this.CarPlateLabel.Size = new System.Drawing.Size(40, 13);
            this.CarPlateLabel.TabIndex = 1;
            this.CarPlateLabel.Text = "Plate : ";
            // 
            // CarAddButton
            // 
            this.CarAddButton.Location = new System.Drawing.Point(995, 438);
            this.CarAddButton.Name = "CarAddButton";
            this.CarAddButton.Size = new System.Drawing.Size(75, 23);
            this.CarAddButton.TabIndex = 0;
            this.CarAddButton.Text = "Add";
            this.CarAddButton.UseVisualStyleBackColor = true;
            this.CarAddButton.Click += new System.EventHandler(this.CarAddButton_Click);
            // 
            // PersonTabPage
            // 
            this.PersonTabPage.Controls.Add(this.PersonChangeButton);
            this.PersonTabPage.Controls.Add(this.PersonCommentRichTextBox);
            this.PersonTabPage.Controls.Add(this.PersonCommentLabel);
            this.PersonTabPage.Controls.Add(this.PersonDeleteButton);
            this.PersonTabPage.Controls.Add(this.PersonAddressRichTextBox);
            this.PersonTabPage.Controls.Add(this.PersonAddressLabel);
            this.PersonTabPage.Controls.Add(this.PersonPhoneNumberTextBox);
            this.PersonTabPage.Controls.Add(this.PersonPhoneNumberLabel);
            this.PersonTabPage.Controls.Add(this.PersonSurnameTextBox);
            this.PersonTabPage.Controls.Add(this.PersonSurnameLabel);
            this.PersonTabPage.Controls.Add(this.PersonListView);
            this.PersonTabPage.Controls.Add(this.PersonNameTextBox);
            this.PersonTabPage.Controls.Add(this.PersonNameLabel);
            this.PersonTabPage.Controls.Add(this.PersonAddButton);
            this.PersonTabPage.Location = new System.Drawing.Point(4, 22);
            this.PersonTabPage.Name = "PersonTabPage";
            this.PersonTabPage.Size = new System.Drawing.Size(1076, 655);
            this.PersonTabPage.TabIndex = 2;
            this.PersonTabPage.Text = "Person Database";
            this.PersonTabPage.UseVisualStyleBackColor = true;
            // 
            // PersonChangeButton
            // 
            this.PersonChangeButton.Location = new System.Drawing.Point(993, 457);
            this.PersonChangeButton.Name = "PersonChangeButton";
            this.PersonChangeButton.Size = new System.Drawing.Size(75, 23);
            this.PersonChangeButton.TabIndex = 20;
            this.PersonChangeButton.Text = "Change";
            this.PersonChangeButton.UseVisualStyleBackColor = true;
            this.PersonChangeButton.Click += new System.EventHandler(this.PersonChangeButton_Click);
            // 
            // PersonCommentRichTextBox
            // 
            this.PersonCommentRichTextBox.Location = new System.Drawing.Point(399, 430);
            this.PersonCommentRichTextBox.Name = "PersonCommentRichTextBox";
            this.PersonCommentRichTextBox.Size = new System.Drawing.Size(588, 184);
            this.PersonCommentRichTextBox.TabIndex = 19;
            this.PersonCommentRichTextBox.Text = "";
            // 
            // PersonCommentLabel
            // 
            this.PersonCommentLabel.AutoSize = true;
            this.PersonCommentLabel.Location = new System.Drawing.Point(396, 414);
            this.PersonCommentLabel.Name = "PersonCommentLabel";
            this.PersonCommentLabel.Size = new System.Drawing.Size(60, 13);
            this.PersonCommentLabel.TabIndex = 18;
            this.PersonCommentLabel.Text = "Comment : ";
            // 
            // PersonDeleteButton
            // 
            this.PersonDeleteButton.Location = new System.Drawing.Point(993, 486);
            this.PersonDeleteButton.Name = "PersonDeleteButton";
            this.PersonDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.PersonDeleteButton.TabIndex = 17;
            this.PersonDeleteButton.Text = "Delete";
            this.PersonDeleteButton.UseVisualStyleBackColor = true;
            this.PersonDeleteButton.Click += new System.EventHandler(this.PersonDeleteButton_Click);
            // 
            // PersonAddressRichTextBox
            // 
            this.PersonAddressRichTextBox.Location = new System.Drawing.Point(101, 489);
            this.PersonAddressRichTextBox.Name = "PersonAddressRichTextBox";
            this.PersonAddressRichTextBox.Size = new System.Drawing.Size(289, 125);
            this.PersonAddressRichTextBox.TabIndex = 16;
            this.PersonAddressRichTextBox.Text = "";
            // 
            // PersonAddressLabel
            // 
            this.PersonAddressLabel.AutoSize = true;
            this.PersonAddressLabel.Location = new System.Drawing.Point(41, 489);
            this.PersonAddressLabel.Name = "PersonAddressLabel";
            this.PersonAddressLabel.Size = new System.Drawing.Size(54, 13);
            this.PersonAddressLabel.TabIndex = 15;
            this.PersonAddressLabel.Text = "Address : ";
            // 
            // PersonPhoneNumberTextBox
            // 
            this.PersonPhoneNumberTextBox.Location = new System.Drawing.Point(101, 463);
            this.PersonPhoneNumberTextBox.Name = "PersonPhoneNumberTextBox";
            this.PersonPhoneNumberTextBox.Size = new System.Drawing.Size(289, 20);
            this.PersonPhoneNumberTextBox.TabIndex = 14;
            // 
            // PersonPhoneNumberLabel
            // 
            this.PersonPhoneNumberLabel.AutoSize = true;
            this.PersonPhoneNumberLabel.Location = new System.Drawing.Point(8, 466);
            this.PersonPhoneNumberLabel.Name = "PersonPhoneNumberLabel";
            this.PersonPhoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.PersonPhoneNumberLabel.TabIndex = 13;
            this.PersonPhoneNumberLabel.Text = "Phone Number : ";
            // 
            // PersonSurnameTextBox
            // 
            this.PersonSurnameTextBox.Location = new System.Drawing.Point(101, 437);
            this.PersonSurnameTextBox.Name = "PersonSurnameTextBox";
            this.PersonSurnameTextBox.Size = new System.Drawing.Size(289, 20);
            this.PersonSurnameTextBox.TabIndex = 12;
            // 
            // PersonSurnameLabel
            // 
            this.PersonSurnameLabel.AutoSize = true;
            this.PersonSurnameLabel.Location = new System.Drawing.Point(37, 440);
            this.PersonSurnameLabel.Name = "PersonSurnameLabel";
            this.PersonSurnameLabel.Size = new System.Drawing.Size(58, 13);
            this.PersonSurnameLabel.TabIndex = 11;
            this.PersonSurnameLabel.Text = "Surname : ";
            // 
            // PersonListView
            // 
            this.PersonListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PersonListView.HideSelection = false;
            this.PersonListView.Location = new System.Drawing.Point(8, 5);
            this.PersonListView.MultiSelect = false;
            this.PersonListView.Name = "PersonListView";
            this.PersonListView.Size = new System.Drawing.Size(1060, 400);
            this.PersonListView.TabIndex = 9;
            this.PersonListView.UseCompatibleStateImageBehavior = false;
            this.PersonListView.View = System.Windows.Forms.View.Details;
            this.PersonListView.SelectedIndexChanged += new System.EventHandler(this.PersonListView_SelectedIndexChanged);
            // 
            // PersonNameTextBox
            // 
            this.PersonNameTextBox.Location = new System.Drawing.Point(101, 411);
            this.PersonNameTextBox.Name = "PersonNameTextBox";
            this.PersonNameTextBox.Size = new System.Drawing.Size(289, 20);
            this.PersonNameTextBox.TabIndex = 8;
            // 
            // PersonNameLabel
            // 
            this.PersonNameLabel.AutoSize = true;
            this.PersonNameLabel.Location = new System.Drawing.Point(51, 414);
            this.PersonNameLabel.Name = "PersonNameLabel";
            this.PersonNameLabel.Size = new System.Drawing.Size(44, 13);
            this.PersonNameLabel.TabIndex = 7;
            this.PersonNameLabel.Text = "Name : ";
            // 
            // PersonAddButton
            // 
            this.PersonAddButton.Location = new System.Drawing.Point(993, 428);
            this.PersonAddButton.Name = "PersonAddButton";
            this.PersonAddButton.Size = new System.Drawing.Size(75, 23);
            this.PersonAddButton.TabIndex = 6;
            this.PersonAddButton.Text = "Add";
            this.PersonAddButton.UseVisualStyleBackColor = true;
            this.PersonAddButton.Click += new System.EventHandler(this.PersonAddButton_Click);
            // 
            // Hyundai_Car_DBMS_Form
            // 
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.Tab);
            this.Name = "Hyundai_Car_DBMS_Form";
            this.Text = "Hyundai_Car_DBMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hyundai_Car_DBMS_Form_FormClosing);
            this.Load += new System.EventHandler(this.Hyundai_Car_DBMS_Form_Load);
            this.Tab.ResumeLayout(false);
            this.AppointmentTabPage.ResumeLayout(false);
            this.AppointmentTabPage.PerformLayout();
            this.AppointmentTableLayoutPanel.ResumeLayout(false);
            this.AppointmentTableLayoutPanel.PerformLayout();
            this.CarTabPage.ResumeLayout(false);
            this.CarTabPage.PerformLayout();
            this.PersonTabPage.ResumeLayout(false);
            this.PersonTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage AppointmentTabPage;
        private System.Windows.Forms.TabPage CarTabPage;
        private System.Windows.Forms.Label CarPlateLabel;
        private System.Windows.Forms.Button CarAddButton;
        private System.Windows.Forms.TextBox CarPlateTextBox;
        private System.Windows.Forms.ListView CarListView;
        private System.Windows.Forms.TabPage PersonTabPage;
        private System.Windows.Forms.ListView PersonListView;
        private System.Windows.Forms.TextBox PersonNameTextBox;
        private System.Windows.Forms.Label PersonNameLabel;
        private System.Windows.Forms.Button PersonAddButton;
        private System.Windows.Forms.RichTextBox PersonAddressRichTextBox;
        private System.Windows.Forms.Label PersonAddressLabel;
        private System.Windows.Forms.TextBox PersonPhoneNumberTextBox;
        private System.Windows.Forms.Label PersonPhoneNumberLabel;
        private System.Windows.Forms.TextBox PersonSurnameTextBox;
        private System.Windows.Forms.Label PersonSurnameLabel;
        private System.Windows.Forms.TextBox AppointmentLocationTextBox;
        private System.Windows.Forms.Label AppointmentLocationLabel;
        private System.Windows.Forms.Label AppointmentPersonLabel;
        private System.Windows.Forms.ListView AppointmentListView;
        private System.Windows.Forms.Label AppointmentStartLabel;
        private System.Windows.Forms.Button AppointmentAddButton;
        private System.Windows.Forms.ComboBox AppointmentPersonComboBox;
        private System.Windows.Forms.DateTimePicker AppointmentStartDateDateTimePicker;
        private System.Windows.Forms.Button AppointmentDeleteButton;
        private System.Windows.Forms.Button CarDeleteButton;
        private System.Windows.Forms.Button PersonDeleteButton;
        private System.Windows.Forms.Button PersonChangeButton;
        private System.Windows.Forms.RichTextBox PersonCommentRichTextBox;
        private System.Windows.Forms.Label PersonCommentLabel;
        private System.Windows.Forms.Button AppointmentChangeButton;
        private System.Windows.Forms.Button CarChangeButton;
        private System.Windows.Forms.ComboBox AppointmentCarComboBox;
        private System.Windows.Forms.Label AppointmentCarLabel;
        private System.Windows.Forms.RichTextBox CarCommentRichTextBox;
        private System.Windows.Forms.Label CarCommentLabel;
        private System.Windows.Forms.RichTextBox AppointmentCommentRichTextBox;
        private System.Windows.Forms.Label AppointmentCommentLabel;
        private System.Windows.Forms.ComboBox AppointmentLocationComboBox;
        private System.Windows.Forms.DateTimePicker AppointmentStartTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker AppointmentEndTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker AppointmentEndDateDateTimePicker;
        private System.Windows.Forms.Label AppointmentEndLabel;
        private System.Windows.Forms.MonthCalendar AppointmentMonthCalendar;
        private System.Windows.Forms.Label AppointmentFuelLabel;
        private System.Windows.Forms.Label AppointmentDateTimeLabel;
        private System.Windows.Forms.Label AppointmentDrivingDistanceLabel;
        private System.Windows.Forms.ComboBox CarViegnetteComboBox;
        private System.Windows.Forms.Label CarViegnetteLabel;
        private System.Windows.Forms.DateTimePicker CarTUVDateDateTimePicker;
        private System.Windows.Forms.Label CarTUVDateLabel;
        private System.Windows.Forms.ComboBox CarLeasingCompanyComboBox;
        private System.Windows.Forms.ComboBox CarTyreTypeComboBox;
        private System.Windows.Forms.Label CarTyreTypeLabel;
        private System.Windows.Forms.Label CarLeasingCompanyLabel;
        private System.Windows.Forms.TextBox AppointmentStartDrivingDistanceTextBox;
        private System.Windows.Forms.TextBox AppointmentEndDrivingDistanceTextBox;
        private System.Windows.Forms.TextBox AppointmentStartFuelTextBox;
        private System.Windows.Forms.TextBox AppointmentEndFuelTextBox;
        private System.Windows.Forms.TableLayoutPanel AppointmentTableLayoutPanel;
    }
}

