namespace lb6client
{
    partial class ClientForm
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
            components = new System.ComponentModel.Container();
            dataGridViewRooms = new DataGridView();
            roomNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bedsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            costPerDayDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            isOccupiedDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            daysRemainingDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            roomBindingSource = new BindingSource(components);
            buttonGetRoomInfo = new Button();
            labelNumPeople = new Label();
            labelNumDays = new Label();
            textBoxNumPeople = new TextBox();
            textBoxNumDays = new TextBox();
            buttonReserve = new Button();
            bindingSourceRooms = new BindingSource(components);
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bedsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costPerDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isOccupiedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            daysRemainingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRooms).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AllowUserToAddRows = false;
            dataGridViewRooms.AllowUserToDeleteRows = false;
            dataGridViewRooms.AllowUserToOrderColumns = true;
            dataGridViewRooms.AutoGenerateColumns = false;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Columns.AddRange(new DataGridViewColumn[] { roomNumberDataGridViewTextBoxColumn1, bedsDataGridViewTextBoxColumn1, costPerDayDataGridViewTextBoxColumn1, isOccupiedDataGridViewCheckBoxColumn1, daysRemainingDataGridViewTextBoxColumn1 });
            dataGridViewRooms.DataSource = roomBindingSource;
            dataGridViewRooms.Location = new Point(12, 12);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.ReadOnly = true;
            dataGridViewRooms.RowTemplate.Height = 25;
            dataGridViewRooms.Size = new Size(568, 328);
            dataGridViewRooms.TabIndex = 0;
            // 
            // roomNumberDataGridViewTextBoxColumn1
            // 
            roomNumberDataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn1.Name = "roomNumberDataGridViewTextBoxColumn1";
            roomNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bedsDataGridViewTextBoxColumn1
            // 
            bedsDataGridViewTextBoxColumn1.DataPropertyName = "Beds";
            bedsDataGridViewTextBoxColumn1.HeaderText = "Beds";
            bedsDataGridViewTextBoxColumn1.Name = "bedsDataGridViewTextBoxColumn1";
            bedsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // costPerDayDataGridViewTextBoxColumn1
            // 
            costPerDayDataGridViewTextBoxColumn1.DataPropertyName = "CostPerDay";
            costPerDayDataGridViewTextBoxColumn1.HeaderText = "CostPerDay";
            costPerDayDataGridViewTextBoxColumn1.Name = "costPerDayDataGridViewTextBoxColumn1";
            costPerDayDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isOccupiedDataGridViewCheckBoxColumn1
            // 
            isOccupiedDataGridViewCheckBoxColumn1.DataPropertyName = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn1.HeaderText = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn1.Name = "isOccupiedDataGridViewCheckBoxColumn1";
            isOccupiedDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // daysRemainingDataGridViewTextBoxColumn1
            // 
            daysRemainingDataGridViewTextBoxColumn1.DataPropertyName = "DaysRemaining";
            daysRemainingDataGridViewTextBoxColumn1.HeaderText = "DaysRemaining";
            daysRemainingDataGridViewTextBoxColumn1.Name = "daysRemainingDataGridViewTextBoxColumn1";
            daysRemainingDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Room);
            // 
            // buttonGetRoomInfo
            // 
            buttonGetRoomInfo.Location = new Point(607, 27);
            buttonGetRoomInfo.Name = "buttonGetRoomInfo";
            buttonGetRoomInfo.Size = new Size(95, 23);
            buttonGetRoomInfo.TabIndex = 1;
            buttonGetRoomInfo.Text = "Get Room Info";
            buttonGetRoomInfo.UseVisualStyleBackColor = true;
            buttonGetRoomInfo.Click += buttonGetRoomInfo_Click;
            // 
            // labelNumPeople
            // 
            labelNumPeople.AutoSize = true;
            labelNumPeople.Location = new Point(595, 113);
            labelNumPeople.Name = "labelNumPeople";
            labelNumPeople.Size = new Size(107, 15);
            labelNumPeople.TabIndex = 2;
            labelNumPeople.Text = "Number of people:";
            // 
            // labelNumDays
            // 
            labelNumDays.AutoSize = true;
            labelNumDays.Location = new Point(595, 169);
            labelNumDays.Name = "labelNumDays";
            labelNumDays.Size = new Size(95, 15);
            labelNumDays.TabIndex = 3;
            labelNumDays.Text = "Number of days:";
            // 
            // textBoxNumPeople
            // 
            textBoxNumPeople.Location = new Point(602, 131);
            textBoxNumPeople.Name = "textBoxNumPeople";
            textBoxNumPeople.Size = new Size(100, 23);
            textBoxNumPeople.TabIndex = 4;
            // 
            // textBoxNumDays
            // 
            textBoxNumDays.Location = new Point(602, 198);
            textBoxNumDays.Name = "textBoxNumDays";
            textBoxNumDays.Size = new Size(100, 23);
            textBoxNumDays.TabIndex = 5;
            // 
            // buttonReserve
            // 
            buttonReserve.Location = new Point(615, 242);
            buttonReserve.Name = "buttonReserve";
            buttonReserve.Size = new Size(75, 23);
            buttonReserve.TabIndex = 6;
            buttonReserve.Text = "Reserve";
            buttonReserve.UseVisualStyleBackColor = true;
            buttonReserve.Click += buttonReserve_Click;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // bedsDataGridViewTextBoxColumn
            // 
            bedsDataGridViewTextBoxColumn.DataPropertyName = "Beds";
            bedsDataGridViewTextBoxColumn.HeaderText = "Beds";
            bedsDataGridViewTextBoxColumn.Name = "bedsDataGridViewTextBoxColumn";
            // 
            // costPerDayDataGridViewTextBoxColumn
            // 
            costPerDayDataGridViewTextBoxColumn.DataPropertyName = "CostPerDay";
            costPerDayDataGridViewTextBoxColumn.HeaderText = "CostPerDay";
            costPerDayDataGridViewTextBoxColumn.Name = "costPerDayDataGridViewTextBoxColumn";
            // 
            // isOccupiedDataGridViewCheckBoxColumn
            // 
            isOccupiedDataGridViewCheckBoxColumn.DataPropertyName = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.HeaderText = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.Name = "isOccupiedDataGridViewCheckBoxColumn";
            // 
            // daysRemainingDataGridViewTextBoxColumn
            // 
            daysRemainingDataGridViewTextBoxColumn.DataPropertyName = "DaysRemaining";
            daysRemainingDataGridViewTextBoxColumn.HeaderText = "DaysRemaining";
            daysRemainingDataGridViewTextBoxColumn.Name = "daysRemainingDataGridViewTextBoxColumn";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 346);
            Controls.Add(buttonReserve);
            Controls.Add(textBoxNumDays);
            Controls.Add(textBoxNumPeople);
            Controls.Add(labelNumDays);
            Controls.Add(labelNumPeople);
            Controls.Add(buttonGetRoomInfo);
            Controls.Add(dataGridViewRooms);
            Name = "ClientForm";
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRooms;
        private Button buttonGetRoomInfo;
        private Label labelNumPeople;
        private Label labelNumDays;
        private TextBox textBoxNumPeople;
        private TextBox textBoxNumDays;
        private Button buttonReserve;
        private BindingSource bindingSourceRooms;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bedsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costPerDayDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isOccupiedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn daysRemainingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bedsDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn costPerDayDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn isOccupiedDataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn daysRemainingDataGridViewTextBoxColumn1;
        private BindingSource roomBindingSource;
    }
}