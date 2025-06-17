
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lb_Statistics = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_thisMonth = new System.Windows.Forms.Button();
            this.btn_last30Days = new System.Windows.Forms.Button();
            this.btn_last7Days = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.lb_TotalSalesOrders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lb_TotalRevenue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lb_TotalProfit = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.lb_ProductCounter = new System.Windows.Forms.Label();
            this.lblNumSuppliers = new System.Windows.Forms.Label();
            this.lb_SupplierCounter = new System.Windows.Forms.Label();
            this.lb_Counter = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.lb_CustomerCounter = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.lb_lowIventory = new System.Windows.Forms.Label();
            this.btn_Today = new System.Windows.Forms.Button();
            this.btn_customDate = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
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
            // lb_Statistics
            // 
            this.lb_Statistics.AutoSize = true;
            this.lb_Statistics.Font = new System.Drawing.Font("JetBrains Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Statistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Statistics.Location = new System.Drawing.Point(12, 3);
            this.lb_Statistics.Name = "lb_Statistics";
            this.lb_Statistics.Size = new System.Drawing.Size(188, 47);
            this.lb_Statistics.TabIndex = 0;
            this.lb_Statistics.Text = "Thống kê";
            this.lb_Statistics.Click += new System.EventHandler(this.label1_Click);
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
            // btn_thisMonth
            // 
            this.btn_thisMonth.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thisMonth.Location = new System.Drawing.Point(1152, 10);
            this.btn_thisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btn_thisMonth.Name = "btn_thisMonth";
            this.btn_thisMonth.Size = new System.Drawing.Size(130, 35);
            this.btn_thisMonth.TabIndex = 3;
            this.btn_thisMonth.Text = "Tháng này";
            this.btn_thisMonth.UseVisualStyleBackColor = true;
            this.btn_thisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btn_last30Days
            // 
            this.btn_last30Days.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last30Days.Location = new System.Drawing.Point(973, 10);
            this.btn_last30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btn_last30Days.Name = "btn_last30Days";
            this.btn_last30Days.Size = new System.Drawing.Size(178, 35);
            this.btn_last30Days.TabIndex = 4;
            this.btn_last30Days.Text = "30 ngày gần nhất";
            this.btn_last30Days.UseVisualStyleBackColor = true;
            this.btn_last30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btn_last7Days
            // 
            this.btn_last7Days.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last7Days.Location = new System.Drawing.Point(798, 10);
            this.btn_last7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btn_last7Days.Name = "btn_last7Days";
            this.btn_last7Days.Size = new System.Drawing.Size(174, 35);
            this.btn_last7Days.TabIndex = 5;
            this.btn_last7Days.Text = "7 ngày gần nhất";
            this.btn_last7Days.UseVisualStyleBackColor = true;
            this.btn_last7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.lb_TotalSalesOrders);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 73);
            this.panel1.TabIndex = 9;
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("JetBrains Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(235, 34);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(84, 26);
            this.lblNumOrders.TabIndex = 1;
            this.lblNumOrders.Text = "100000";
            this.lblNumOrders.Click += new System.EventHandler(this.lblNumOrders_Click);
            // 
            // lb_TotalSalesOrders
            // 
            this.lb_TotalSalesOrders.AutoSize = true;
            this.lb_TotalSalesOrders.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalSalesOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lb_TotalSalesOrders.Location = new System.Drawing.Point(9, 9);
            this.lb_TotalSalesOrders.Name = "lb_TotalSalesOrders";
            this.lb_TotalSalesOrders.Size = new System.Drawing.Size(210, 25);
            this.lb_TotalSalesOrders.TabIndex = 0;
            this.lb_TotalSalesOrders.Text = "Tổng lượng đơn bán";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.lb_TotalRevenue);
            this.panel2.Location = new System.Drawing.Point(484, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 73);
            this.panel2.TabIndex = 10;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("JetBrains Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(215, 34);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(84, 26);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "100000";
            // 
            // lb_TotalRevenue
            // 
            this.lb_TotalRevenue.AutoSize = true;
            this.lb_TotalRevenue.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lb_TotalRevenue.Location = new System.Drawing.Point(16, 9);
            this.lb_TotalRevenue.Name = "lb_TotalRevenue";
            this.lb_TotalRevenue.Size = new System.Drawing.Size(166, 25);
            this.lb_TotalRevenue.TabIndex = 0;
            this.lb_TotalRevenue.Text = "Tổng doanh thu";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Controls.Add(this.lb_TotalProfit);
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
            this.lblTotalProfit.Font = new System.Drawing.Font("JetBrains Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(208, 34);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(84, 26);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "100000";
            this.lblTotalProfit.Click += new System.EventHandler(this.lblTotalProfit_Click);
            // 
            // lb_TotalProfit
            // 
            this.lb_TotalProfit.AutoSize = true;
            this.lb_TotalProfit.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lb_TotalProfit.Location = new System.Drawing.Point(24, 14);
            this.lb_TotalProfit.Name = "lb_TotalProfit";
            this.lb_TotalProfit.Size = new System.Drawing.Size(166, 25);
            this.lb_TotalProfit.TabIndex = 0;
            this.lb_TotalProfit.Text = "Tổng lợi nhuận";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend1);
            this.chartGrossRevenue.Location = new System.Drawing.Point(14, 138);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(5);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series1);
            this.chartGrossRevenue.Size = new System.Drawing.Size(1338, 538);
            this.chartGrossRevenue.TabIndex = 12;
            this.chartGrossRevenue.Text = "chartGrossRevenue";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Tổng doanh thu";
            this.chartGrossRevenue.Titles.Add(title1);
            this.chartGrossRevenue.Click += new System.EventHandler(this.chartGrossRevenue_Click);
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend2);
            this.chartTopProducts.Location = new System.Drawing.Point(1362, 138);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProducts.Name = "chartTopProducts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopProducts.Series.Add(series2);
            this.chartTopProducts.Size = new System.Drawing.Size(320, 778);
            this.chartTopProducts.TabIndex = 13;
            this.chartTopProducts.Text = "chartTopProducts";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "5 sản phẩm bán chạy nhất";
            this.chartTopProducts.Titles.Add(title2);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNumProducts);
            this.panel4.Controls.Add(this.lb_ProductCounter);
            this.panel4.Controls.Add(this.lblNumSuppliers);
            this.panel4.Controls.Add(this.lb_SupplierCounter);
            this.panel4.Controls.Add(this.lb_Counter);
            this.panel4.Controls.Add(this.lblNumCustomers);
            this.panel4.Controls.Add(this.lb_CustomerCounter);
            this.panel4.Location = new System.Drawing.Point(14, 686);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 230);
            this.panel4.TabIndex = 10;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.Location = new System.Drawing.Point(96, 185);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(90, 27);
            this.lblNumProducts.TabIndex = 6;
            this.lblNumProducts.Text = "100000";
            // 
            // lb_ProductCounter
            // 
            this.lb_ProductCounter.AutoSize = true;
            this.lb_ProductCounter.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lb_ProductCounter.Location = new System.Drawing.Point(13, 160);
            this.lb_ProductCounter.Name = "lb_ProductCounter";
            this.lb_ProductCounter.Size = new System.Drawing.Size(100, 25);
            this.lb_ProductCounter.TabIndex = 5;
            this.lb_ProductCounter.Text = "Sản phẩm";
            // 
            // lblNumSuppliers
            // 
            this.lblNumSuppliers.AutoSize = true;
            this.lblNumSuppliers.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSuppliers.Location = new System.Drawing.Point(96, 125);
            this.lblNumSuppliers.Name = "lblNumSuppliers";
            this.lblNumSuppliers.Size = new System.Drawing.Size(90, 27);
            this.lblNumSuppliers.TabIndex = 4;
            this.lblNumSuppliers.Text = "100000";
            // 
            // lb_SupplierCounter
            // 
            this.lb_SupplierCounter.AutoSize = true;
            this.lb_SupplierCounter.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SupplierCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lb_SupplierCounter.Location = new System.Drawing.Point(13, 100);
            this.lb_SupplierCounter.Name = "lb_SupplierCounter";
            this.lb_SupplierCounter.Size = new System.Drawing.Size(144, 25);
            this.lb_SupplierCounter.TabIndex = 3;
            this.lb_SupplierCounter.Text = "Nhà cung cấp";
            // 
            // lb_Counter
            // 
            this.lb_Counter.AutoSize = true;
            this.lb_Counter.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Counter.Location = new System.Drawing.Point(10, 10);
            this.lb_Counter.Name = "lb_Counter";
            this.lb_Counter.Size = new System.Drawing.Size(90, 27);
            this.lb_Counter.TabIndex = 2;
            this.lb_Counter.Text = "Bộ đếm";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.Location = new System.Drawing.Point(96, 65);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(90, 27);
            this.lblNumCustomers.TabIndex = 1;
            this.lblNumCustomers.Text = "100000";
            // 
            // lb_CustomerCounter
            // 
            this.lb_CustomerCounter.AutoSize = true;
            this.lb_CustomerCounter.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lb_CustomerCounter.Location = new System.Drawing.Point(13, 40);
            this.lb_CustomerCounter.Name = "lb_CustomerCounter";
            this.lb_CustomerCounter.Size = new System.Drawing.Size(122, 25);
            this.lb_CustomerCounter.TabIndex = 0;
            this.lb_CustomerCounter.Text = "Khách hàng";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvUnderstock);
            this.panel5.Controls.Add(this.lb_lowIventory);
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
            // lb_lowIventory
            // 
            this.lb_lowIventory.AutoSize = true;
            this.lb_lowIventory.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lowIventory.Location = new System.Drawing.Point(10, 10);
            this.lb_lowIventory.Name = "lb_lowIventory";
            this.lb_lowIventory.Size = new System.Drawing.Size(259, 27);
            this.lb_lowIventory.TabIndex = 2;
            this.lb_lowIventory.Text = "Sản phẩm tồn kho ít";
            // 
            // btn_Today
            // 
            this.btn_Today.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Today.Location = new System.Drawing.Point(667, 10);
            this.btn_Today.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(130, 35);
            this.btn_Today.TabIndex = 6;
            this.btn_Today.Text = "Hôm nay";
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_Today.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btn_customDate
            // 
            this.btn_customDate.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customDate.Location = new System.Drawing.Point(536, 10);
            this.btn_customDate.Margin = new System.Windows.Forms.Padding(5);
            this.btn_customDate.Name = "btn_customDate";
            this.btn_customDate.Size = new System.Drawing.Size(130, 35);
            this.btn_customDate.TabIndex = 7;
            this.btn_customDate.Text = "Tuỳ chỉnh";
            this.btn_customDate.UseVisualStyleBackColor = true;
            this.btn_customDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(498, 10);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(35, 35);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Visible = false;
            this.btn_OK.Click += new System.EventHandler(this.btnOkCustomDate_Click);
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
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_customDate);
            this.Controls.Add(this.btn_Today);
            this.Controls.Add(this.btn_last7Days);
            this.Controls.Add(this.btn_last30Days);
            this.Controls.Add(this.btn_thisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lb_Statistics);
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

        private System.Windows.Forms.Label lb_Statistics;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btn_thisMonth;
        private System.Windows.Forms.Button btn_last30Days;
        private System.Windows.Forms.Button btn_last7Days;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label lb_TotalSalesOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lb_TotalRevenue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lb_TotalProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label lb_ProductCounter;
        private System.Windows.Forms.Label lblNumSuppliers;
        private System.Windows.Forms.Label lb_SupplierCounter;
        private System.Windows.Forms.Label lb_Counter;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label lb_CustomerCounter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Label lb_lowIventory;
        private System.Windows.Forms.Button btn_Today;
        private System.Windows.Forms.Button btn_customDate;
        private System.Windows.Forms.Button btn_OK;
    }
}