using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gwenchana.DataAccess;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.DataAccess.ViewModel
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class AdminDashboard
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int numberDays { get; set; }

        public int numCustomers { get; set; }
        public int numSuppliers { get; set; }
        public int numProducts { get; set; }
        public int numReceipts { get; set; }

        public List<KeyValuePair<string, int>> TopProducts { get; set; }
        public List<KeyValuePair<string, int>> Understock { get; set; }

        public List<RevenueByDate> GrossRevenueList { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public void SetNumberItems()
        {
            this.numCustomers = Convert.ToInt32(_db.ExecuteScalar("SELECT COUNT(*) FROM Customer"));
            this.numSuppliers = Convert.ToInt32(_db.ExecuteScalar("SELECT COUNT(*) FROM Supplier"));
            this.numProducts = Convert.ToInt32(_db.ExecuteScalar("SELECT COUNT(*) FROM Product"));

            SqlParameter[] parameters = {
        new SqlParameter("@StartDate", this.startDate),
        new SqlParameter("@EndDate", this.endDate)
    };
            this.numReceipts = Convert.ToInt32(_db.ExecuteScalar(
                "SELECT COUNT(*) FROM Receipt WHERE receiptDate BETWEEN @StartDate AND @EndDate", parameters));
        }

        private void GetProductAnalisys()
        {
            TopProducts = new List<KeyValuePair<string, int>>();
            Understock = new List<KeyValuePair<string, int>>();
            DbConnect _db = new DbConnect();

            // Top 5 best-selling products
            string topProductQuery = @"
        SELECT TOP 5
            p.Product_Id,
            p.productName,
            p.Manufacturer,
            SUM(d.quantity) AS TotalQuantitySold
        FROM Product p
        JOIN Details d ON p.Product_Id = d.Product_Id
        WHERE d.Receipt_Id IS NOT NULL
        GROUP BY p.Product_Id, p.productName, p.Manufacturer
        ORDER BY TotalQuantitySold DESC;";

            DataTable topProductsTable = _db.GetData(topProductQuery);
            foreach (DataRow row in topProductsTable.Rows)
            {
                string name = $"{row["productName"]} ({row["Manufacturer"]})";
                int quantity = Convert.ToInt32(row["TotalQuantitySold"]);
                TopProducts.Add(new KeyValuePair<string, int>(name, quantity));
            }

            // 5 products with lowest stock
            string understockQuery = @"
                SELECT TOP 10 
                    p.Product_Id,
                    p.productName,
                    p.Manufacturer,
                    p.price,
                    p.stockQuantity
                FROM Product p
                WHERE p.stockQuantity IS NOT NULL
                  AND (
                      EXISTS (SELECT 1 FROM PC WHERE PC.Product_Id = p.Product_Id)
                      OR EXISTS (SELECT 1 FROM Laptop WHERE Laptop.Product_Id = p.Product_Id)
                      OR EXISTS (SELECT 1 FROM Accessories WHERE Accessories.Product_Id = p.Product_Id)
                  )
                ORDER BY p.stockQuantity ASC;
            ";

            DataTable understockTable = _db.GetData(understockQuery);
            foreach (DataRow row in understockTable.Rows)
            {
                string name = $"{row["productName"]} ({row["Manufacturer"]})";
                int stock = Convert.ToInt32(row["stockQuantity"]);
                Understock.Add(new KeyValuePair<string, int>(name, stock));
            }
        }

        //private void GetOrderAnalisys()
        //{
        //    GrossRevenueList = new List<RevenueByDate>();
        //    TotalProfit = 0;
        //    TotalRevenue = 0;

        //    string query = @"
        //SELECT r.receiptDate, SUM(p.price * d.quantity) as Total
        //FROM Receipt r
        //JOIN Details d ON r.Receipt_Id = d.Receipt_Id
        //JOIN Product p ON d.Product_Id = p.Product_Id
        //WHERE r.receiptDate BETWEEN @fromDate AND @toDate
        //GROUP BY r.receiptDate";

        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = this.startDate },
        //new SqlParameter("@toDate", SqlDbType.DateTime) { Value = this.endDate }
        //    };

        //    DataTable dt = _db.GetData(query, parameters);
        //    var resultTable = new List<KeyValuePair<DateTime, decimal>>();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        DateTime orderDate = (DateTime)row["receiptDate"];
        //        decimal total = (decimal)row["Total"];
        //        resultTable.Add(new KeyValuePair<DateTime, decimal>(orderDate, total));
        //        TotalRevenue += total;
        //    }

        //    TotalProfit = TotalRevenue * 0.2m;

        //    // ... phần group by thời gian giữ nguyên như cũ
        //    if (numberDays <= 1)
        //    {
        //        GrossRevenueList = resultTable
        //            .GroupBy(x => x.Key.ToString("hh tt"))
        //            .Select(g => new RevenueByDate
        //            {
        //                Date = g.Key,
        //                TotalAmount = g.Sum(x => x.Value)
        //            })
        //            .ToList();
        //    }
        //    else if (numberDays <= 30)
        //    {
        //        GrossRevenueList = resultTable
        //            .GroupBy(x => x.Key.ToString("dd MMM"))
        //            .Select(g => new RevenueByDate
        //            {
        //                Date = g.Key,
        //                TotalAmount = g.Sum(x => x.Value)
        //            })
        //            .ToList();
        //    }
        //    else if (numberDays <= 92)
        //    {
        //        GrossRevenueList = resultTable
        //            .GroupBy(x => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
        //                x.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
        //            .Select(g => new RevenueByDate
        //            {
        //                Date = "Week " + g.Key,
        //                TotalAmount = g.Sum(x => x.Value)
        //            })
        //            .ToList();
        //    }
        //    else if (numberDays <= (365 * 2))
        //    {
        //        bool isYear = numberDays <= 365;
        //        GrossRevenueList = resultTable
        //            .GroupBy(x => x.Key.ToString("MMM yyyy"))
        //            .Select(g => new RevenueByDate
        //            {
        //                Date = isYear ? g.Key.Substring(0, g.Key.IndexOf(" ")) : g.Key,
        //                TotalAmount = g.Sum(x => x.Value)
        //            })
        //            .ToList();
        //    }
        //    else
        //    {
        //        GrossRevenueList = resultTable
        //            .GroupBy(x => x.Key.ToString("yyyy"))
        //            .Select(g => new RevenueByDate
        //            {
        //                Date = g.Key,
        //                TotalAmount = g.Sum(x => x.Value)
        //            })
        //            .ToList();
        //    }
        //}
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            // Query to calculate total revenue grouped by receiptDate
            string query = @"
SELECT r.receiptDate, SUM(r.ReceiptTotal) AS TotalRevenue
FROM Receipt r
WHERE r.receiptDate BETWEEN @fromDate AND @toDate
GROUP BY r.receiptDate";

            SqlParameter[] revenueParameters = new SqlParameter[]
            {
        new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = this.startDate },
        new SqlParameter("@toDate", SqlDbType.DateTime) { Value = this.endDate }
            };

            // Execute query and get data
            DataTable dt = _db.GetData(query, revenueParameters);
            var resultTable = new List<KeyValuePair<DateTime, decimal>>();

            // Process query result
            foreach (DataRow row in dt.Rows)
            {
                DateTime orderDate = row["receiptDate"] != DBNull.Value
                    ? Convert.ToDateTime(row["receiptDate"])
                    : DateTime.MinValue; // Default value for null

                decimal totalRevenue = row["TotalRevenue"] != DBNull.Value
                    ? Convert.ToDecimal(row["TotalRevenue"])
                    : 0m; // Default value for null

                resultTable.Add(new KeyValuePair<DateTime, decimal>(orderDate, totalRevenue));
                TotalRevenue += totalRevenue;
            }

            // Query to calculate profit difference based on revenue
            string profitQuery = @"
SELECT 
    (SELECT SUM(r.ReceiptTotal) 
     FROM Receipt r
     WHERE r.receiptDate BETWEEN @fromDate AND @toDate) 
    - 
    (SELECT SUM(d.productPrice * d.quantity) 
     FROM Goods_Receipt gr
     JOIN Details d ON gr.GoodsReceipt_Id = d.GoodsReceipt_Id
     WHERE gr.goodsReceiptDate BETWEEN @fromDate AND @toDate) AS ProfitDifference";

            SqlParameter[] profitParameters = new SqlParameter[]
            {
        new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = this.startDate },
        new SqlParameter("@toDate", SqlDbType.DateTime) { Value = this.endDate }
            };

            // Execute profit query
            DataTable profitDt = _db.GetData(profitQuery, profitParameters);
            if (profitDt.Rows.Count > 0)
            {
                TotalProfit = profitDt.Rows[0]["ProfitDifference"] != DBNull.Value
                    ? Convert.ToDecimal(profitDt.Rows[0]["ProfitDifference"])
                    : 0m; // Default value for null
            }

            // Group data based on number of days
            if (numberDays <= 1)
            {
                GrossRevenueList = resultTable
                    .GroupBy(x => x.Key.ToString("hh tt"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(x => x.Value)
                    })
                    .ToList();
            }
            else if (numberDays <= 30)
            {
                GrossRevenueList = resultTable
                    .GroupBy(x => x.Key.ToString("dd MMM"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(x => x.Value)
                    })
                    .ToList();
            }
            else if (numberDays <= 92)
            {
                GrossRevenueList = resultTable
                    .GroupBy(x => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                        x.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                    .Select(g => new RevenueByDate
                    {
                        Date = "Week " + g.Key,
                        TotalAmount = g.Sum(x => x.Value)
                    })
                    .ToList();
            }
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365;
                GrossRevenueList = resultTable
                    .GroupBy(x => x.Key.ToString("MMM yyyy"))
                    .Select(g => new RevenueByDate
                    {
                        Date = isYear ? g.Key.Substring(0, g.Key.IndexOf(" ")) : g.Key,
                        TotalAmount = g.Sum(x => x.Value)
                    })
                    .ToList();
            }
            else
            {
                GrossRevenueList = resultTable
                    .GroupBy(x => x.Key.ToString("yyyy"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(x => x.Value)
                    })
                    .ToList();
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                SetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }



    }
}
