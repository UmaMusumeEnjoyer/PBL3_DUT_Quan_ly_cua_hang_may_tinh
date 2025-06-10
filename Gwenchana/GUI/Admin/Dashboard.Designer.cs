
using System.Windows.Forms;

namespace Gwenchana
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumSuppliers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(218, 18);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(364, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.Location = new System.Drawing.Point(1060, 10);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(130, 35);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Days.Location = new System.Drawing.Point(929, 10);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast30Days.TabIndex = 4;
            this.btnLast30Days.Text = "30 ngày gần nhất";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.Location = new System.Drawing.Point(798, 10);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast7Days.TabIndex = 5;
            this.btnLast7Days.Text = "7 ngày gần nhất";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 73);
            this.panel1.TabIndex = 9;
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(74, 34);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(78, 25);
            this.lblNumOrders.TabIndex = 1;
            this.lblNumOrders.Text = "100000";
            this.lblNumOrders.Click += new System.EventHandler(this.lblNumOrders_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng lượng đơn bán";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(484, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 73);
            this.panel2.TabIndex = 10;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(74, 34);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(78, 25);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(26, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng doanh thu";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1217, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 73);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(74, 34);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(78, 25);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "100000";
            this.lblTotalProfit.Click += new System.EventHandler(this.lblTotalProfit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(24, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng lợi nhuận";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend7);
            this.chartGrossRevenue.Location = new System.Drawing.Point(14, 138);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(5);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series7);
            this.chartGrossRevenue.Size = new System.Drawing.Size(1338, 538);
            this.chartGrossRevenue.TabIndex = 12;
            this.chartGrossRevenue.Text = "chartGrossRevenue";
            title7.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Title1";
            title7.Text = "Tổng doanh thu";
            this.chartGrossRevenue.Titles.Add(title7);
            this.chartGrossRevenue.Click += new System.EventHandler(this.chartGrossRevenue_Click);
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend8);
            this.chartTopProducts.Location = new System.Drawing.Point(1362, 138);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProducts.Name = "chartTopProducts";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series8.IsValueShownAsLabel = true;
            series8.LabelForeColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartTopProducts.Series.Add(series8);
            this.chartTopProducts.Size = new System.Drawing.Size(320, 778);
            this.chartTopProducts.TabIndex = 13;
            this.chartTopProducts.Text = "chartTopProducts";
            title8.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "5 sản phẩm bán chạy nhất";
            this.chartTopProducts.Titles.Add(title8);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNumProducts);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblNumSuppliers);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblNumCustomers);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(14, 686);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 230);
            this.panel4.TabIndex = 10;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.Location = new System.Drawing.Point(59, 185);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(76, 23);
            this.lblNumProducts.TabIndex = 6;
            this.lblNumProducts.Text = "100000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label9.Location = new System.Drawing.Point(60, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sản phẩm";
            // 
            // lblNumSuppliers
            // 
            this.lblNumSuppliers.AutoSize = true;
            this.lblNumSuppliers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSuppliers.Location = new System.Drawing.Point(59, 125);
            this.lblNumSuppliers.Name = "lblNumSuppliers";
            this.lblNumSuppliers.Size = new System.Drawing.Size(76, 23);
            this.lblNumSuppliers.TabIndex = 4;
            this.lblNumSuppliers.Text = "100000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label8.Location = new System.Drawing.Point(60, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bộ đếm";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.Location = new System.Drawing.Point(59, 65);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(76, 23);
            this.lblNumCustomers.TabIndex = 1;
            this.lblNumCustomers.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(60, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvUnderstock);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(254, 686);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1098, 230);
            this.panel5.TabIndex = 11;
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(15, 45);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.Size = new System.Drawing.Size(574, 185);
            this.dgvUnderstock.TabIndex = 3;
            this.dgvUnderstock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnderstock_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sản phẩm tồn kho ít";
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(667, 10);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(130, 35);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.Location = new System.Drawing.Point(536, 10);
            this.btnCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(130, 35);
            this.btnCustomDate.TabIndex = 7;
            this.btnCustomDate.Text = "Tuỳ chỉnh";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkCustomDate.Location = new System.Drawing.Point(498, 10);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(35, 35);
            this.btnOkCustomDate.TabIndex = 8;
            this.btnOkCustomDate.Text = "Ok";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.Visible = false;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1696, 924);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Store statistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumSuppliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnOkCustomDate;
    }
}