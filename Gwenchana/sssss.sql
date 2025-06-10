USE [PBL3]
GO
/****** Object:  Table [dbo].[Accessories]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessories](
	[Product_Id] [int] NOT NULL,
	[overview] [nvarchar](max) NULL,
	[Type] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[role] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_Id] [int] IDENTITY(1,1) NOT NULL,
	[customerName] [nvarchar](100) NOT NULL,
	[phoneNumber] [nvarchar](20) NULL,
	[email] [nvarchar](100) NULL,
	[address] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Details]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Details](
	[Details_Id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[productPrice] [decimal](10, 2) NOT NULL,
	[Receipt_Id] [int] NULL,
	[GoodsReceipt_Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Details_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Employee_Id] [int] IDENTITY(1,1) NOT NULL,
	[employeeName] [nvarchar](100) NULL,
	[age] [int] NULL,
	[phoneNumber] [nvarchar](20) NULL,
	[Account_Id] [int] NULL,
	[EmploymentStatus] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goods_Receipt]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods_Receipt](
	[GoodsReceipt_Id] [int] IDENTITY(1,1) NOT NULL,
	[goodsReceiptDate] [date] NOT NULL,
	[Employee_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GoodsReceipt_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laptop]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laptop](
	[Product_Id] [int] NOT NULL,
	[weight] [decimal](5, 2) NULL,
	[screenSize] [nvarchar](50) NULL,
	[specification] [nvarchar](max) NULL,
	[colour] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PC]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PC](
	[Product_Id] [int] NOT NULL,
	[specification] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_Id] [int] IDENTITY(1,1) NOT NULL,
	[Supplier_Id] [int] NULL,
	[productName] [nvarchar](100) NOT NULL,
	[price] [decimal](10, 2) NULL,
	[stockQuantity] [int] NULL,
	[Manufacturer] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[Receipt_Id] [int] IDENTITY(1,1) NOT NULL,
	[receiptDate] [date] NOT NULL,
	[Customer_Id] [int] NOT NULL,
	[Employee_Id] [int] NOT NULL,
	[ReceiptTotal] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Receipt_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Supplier_Id] [int] IDENTITY(1,1) NOT NULL,
	[supplierName] [nvarchar](100) NOT NULL,
	[phoneNumber] [nvarchar](20) NULL,
	[email] [nvarchar](100) NULL,
	[address] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Supplier_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (N'Đang làm việc') FOR [EmploymentStatus]
GO
ALTER TABLE [dbo].[Accessories]  WITH NOCHECK ADD FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([Product_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Details]  WITH NOCHECK ADD FOREIGN KEY([GoodsReceipt_Id])
REFERENCES [dbo].[Goods_Receipt] ([GoodsReceipt_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Details]  WITH NOCHECK ADD FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([Product_Id])
GO
ALTER TABLE [dbo].[Details]  WITH NOCHECK ADD FOREIGN KEY([Receipt_Id])
REFERENCES [dbo].[Receipt] ([Receipt_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Account] FOREIGN KEY([Account_Id])
REFERENCES [dbo].[Account] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Account]
GO
ALTER TABLE [dbo].[Goods_Receipt]  WITH NOCHECK ADD FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[Employee] ([Employee_Id])
GO
ALTER TABLE [dbo].[Laptop]  WITH NOCHECK ADD FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([Product_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PC]  WITH NOCHECK ADD FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([Product_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK__Product__Supplie__4F7CD00D] FOREIGN KEY([Supplier_Id])
REFERENCES [dbo].[Supplier] ([Supplier_Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK__Product__Supplie__4F7CD00D]
GO
ALTER TABLE [dbo].[Receipt]  WITH NOCHECK ADD FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Customer] ([Customer_Id])
GO
ALTER TABLE [dbo].[Receipt]  WITH NOCHECK ADD FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[Employee] ([Employee_Id])
GO
ALTER TABLE [dbo].[Details]  WITH NOCHECK ADD CHECK  (([productPrice]>=(0)))
GO
ALTER TABLE [dbo].[Details]  WITH NOCHECK ADD CHECK  (([quantity]>(0)))
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateOrder]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreateOrder]
    @CustomerID INT,
    @EmployeeID INT,
    @ReceiptTotal DECIMAL(18, 2),
    @ProductList NVARCHAR(MAX) -- JSON danh sách sản phẩm: [{"Product_Id":1,"Quantity":2,"Price":10000},...]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra input
        IF @CustomerID IS NULL OR @EmployeeID IS NULL OR @ProductList IS NULL
        BEGIN
            THROW 51010, N'Thông tin khách hàng, nhân viên hoặc danh sách sản phẩm không được để trống', 1;
        END

        -- Kiểm tra khách hàng
        IF NOT EXISTS (SELECT 1 FROM Customer WHERE Customer_Id = @CustomerID)
        BEGIN
            THROW 51011, N'Khách hàng không tồn tại trong hệ thống', 1;
        END

        -- Kiểm tra nhân viên
        IF NOT EXISTS (SELECT 1 FROM Employee WHERE Employee_Id = @EmployeeID)
        BEGIN
            THROW 51012, N'Nhân viên không tồn tại trong hệ thống', 1;
        END

        -- Parse JSON sản phẩm
        DECLARE @OrderProducts TABLE (
            Product_Id INT,
            Quantity INT,
            Price DECIMAL(18, 2)
        );

        INSERT INTO @OrderProducts (Product_Id, Quantity, Price)
        SELECT 
            Product_Id,
            Quantity,
            Price
        FROM OPENJSON(@ProductList)
        WITH (
            Product_Id INT,
            Quantity INT,
            Price DECIMAL(18, 2)
        );

        -- Kiểm tra sản phẩm có tồn tại
        IF EXISTS (
            SELECT op.Product_Id
            FROM @OrderProducts op
            LEFT JOIN Product p ON op.Product_Id = p.Product_Id
            WHERE p.Product_Id IS NULL
        )
        BEGIN
            DECLARE @InvalidProductMsg NVARCHAR(4000) = N'Sản phẩm không tồn tại với ID:';
            SELECT @InvalidProductMsg = @InvalidProductMsg + ' ' + CAST(op.Product_Id AS NVARCHAR)
            FROM @OrderProducts op
            LEFT JOIN Product p ON op.Product_Id = p.Product_Id
            WHERE p.Product_Id IS NULL;
            THROW 51013, @InvalidProductMsg, 1;
        END

        -- Kiểm tra tồn kho đủ
        IF EXISTS (
            SELECT 1
            FROM @OrderProducts op
            JOIN Product p ON op.Product_Id = p.Product_Id
            WHERE (ISNULL(p.stockQuantity, 0) < op.Quantity)
        )
        BEGIN
            DECLARE @OutOfStockMsg NVARCHAR(4000) = N'Sản phẩm không đủ tồn kho với ID:';
            SELECT @OutOfStockMsg = @OutOfStockMsg + ' ' + CAST(op.Product_Id AS NVARCHAR)
            FROM @OrderProducts op
            JOIN Product p ON op.Product_Id = p.Product_Id
            WHERE (ISNULL(p.stockQuantity, 0) < op.Quantity);
            THROW 51014, @OutOfStockMsg, 1;
        END

        -- Insert vào bảng Receipt
        INSERT INTO Receipt (Customer_Id, Employee_Id, receiptDate, ReceiptTotal)
        VALUES (@CustomerID, @EmployeeID, GETDATE(), @ReceiptTotal);

        -- Lấy Receipt_Id vừa tạo
        DECLARE @ReceiptID INT;
        SET @ReceiptID = SCOPE_IDENTITY();

        -- Thêm chi tiết hóa đơn vào Details
        INSERT INTO Details (Receipt_Id, Product_Id, Quantity, ProductPrice)
        SELECT 
            @ReceiptID AS Receipt_Id,
            Product_Id,
            Quantity,
            Price
        FROM @OrderProducts;

        -- Cập nhật tồn kho (trừ đi)
        UPDATE p
        SET p.stockQuantity = p.stockQuantity - op.Quantity
        FROM Product p
        INNER JOIN @OrderProducts op ON p.Product_Id = op.Product_Id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR (@ErrorMessage, 16, 1);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ImportProducts]    Script Date: 6/10/2025 8:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ImportProducts]
    @EmployeeID INT,
    @ProductList NVARCHAR(MAX) -- JSON: '[{"productId":1, "quantity":10, "price":20000000, "supplierId":3}, ...]'
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DECLARE @ImportDate DATE = GETDATE();
        DECLARE @NewGoodsReceiptID INT;
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @SupplierID INT;

        -- Parse JSON sản phẩm, lấy thêm supplierId
        DECLARE @ProductDetails TABLE (
            ProductId INT,
            Quantity INT,
            Price DECIMAL(10, 2),
            SupplierId INT
        );

        INSERT INTO @ProductDetails (ProductId, Quantity, Price, SupplierId)
        SELECT 
            JSON_VALUE(p.value, '$.productId'),
            JSON_VALUE(p.value, '$.quantity'),
            JSON_VALUE(p.value, '$.price'),
            JSON_VALUE(p.value, '$.supplierId')
        FROM OPENJSON(@ProductList) AS p;

        -- Kiểm tra có dữ liệu không
        IF NOT EXISTS (SELECT 1 FROM @ProductDetails)
        BEGIN
            SET @ErrorMessage = N'Danh sách sản phẩm không hợp lệ hoặc rỗng';
            THROW 51001, @ErrorMessage, 1;
        END

        -- Kiểm tra tất cả supplierId có giống nhau không
        SELECT TOP 1 @SupplierID = SupplierId FROM @ProductDetails;
        IF EXISTS (
            SELECT 1 FROM @ProductDetails WHERE SupplierId <> @SupplierID OR SupplierId IS NULL
        )
        BEGIN
            SET @ErrorMessage = N'Tất cả sản phẩm phải có cùng supplierId và không được để trống';
            THROW 51002, @ErrorMessage, 1;
        END

        -- Kiểm tra nhà cung cấp
        IF NOT EXISTS (SELECT 1 FROM Supplier WHERE Supplier_Id = @SupplierID)
        BEGIN
            SET @ErrorMessage = N'Nhà cung cấp không tồn tại trong hệ thống';
            THROW 51003, @ErrorMessage, 1;
        END

        -- Kiểm tra nhân viên
        IF @EmployeeID IS NULL OR NOT EXISTS (SELECT 1 FROM Employee WHERE Employee_Id = @EmployeeID)
        BEGIN
            SET @ErrorMessage = N'Nhân viên không tồn tại trong hệ thống';
            THROW 51004, @ErrorMessage, 1;
        END

        -- Bắt đầu giao dịch
        BEGIN TRANSACTION;

        -- Tạo phiếu nhập hàng mới (Goods_Receipt)
        INSERT INTO Goods_Receipt (goodsReceiptDate, Employee_Id)
        VALUES (@ImportDate, @EmployeeID);

        SET @NewGoodsReceiptID = SCOPE_IDENTITY();

        -- Kiểm tra sản phẩm có tồn tại
        DECLARE @InvalidProducts TABLE (ProductId INT);

        INSERT INTO @InvalidProducts (ProductId)
        SELECT pd.ProductId
        FROM @ProductDetails pd
        LEFT JOIN Product p ON pd.ProductId = p.Product_Id
        WHERE p.Product_Id IS NULL;

        IF EXISTS (SELECT 1 FROM @InvalidProducts)
        BEGIN
            SET @ErrorMessage = N'Sản phẩm không tồn tại với ID:';
            SELECT @ErrorMessage = @ErrorMessage + ' ' + CAST(ProductId AS NVARCHAR)
            FROM @InvalidProducts;
            ROLLBACK;
            THROW 51005, @ErrorMessage, 1;
        END

        -- Thêm chi tiết nhập hàng vào bảng Details
        INSERT INTO Details (Product_Id, quantity, productPrice, GoodsReceipt_Id)
        SELECT 
            pd.ProductId,
            pd.Quantity,
            pd.Price,
            @NewGoodsReceiptID
        FROM @ProductDetails pd;

        -- Cập nhật tồn kho (cộng thêm)
        UPDATE p
        SET p.stockQuantity = ISNULL(p.stockQuantity, 0) + pd.Quantity
        FROM Product p
        INNER JOIN @ProductDetails pd ON p.Product_Id = pd.ProductId;

        COMMIT;

        -- Trả về thông tin phiếu nhập
        SELECT 
            gr.GoodsReceipt_Id AS ImportID,
            CONVERT(VARCHAR(10), gr.goodsReceiptDate, 103) AS ImportDate,
            s.supplierName AS SupplierName,
            e.employeeName AS EmployeeName,
            SUM(d.quantity * d.productPrice) AS TotalAmount,
            COUNT(d.Details_Id) AS TotalItems,
            SUM(d.quantity) AS TotalQuantity
        FROM Goods_Receipt gr
        JOIN Employee e ON gr.Employee_Id = e.Employee_Id
        JOIN Details d ON gr.GoodsReceipt_Id = d.GoodsReceipt_Id
        JOIN Product p ON d.Product_Id = p.Product_Id
        JOIN Supplier s ON p.Supplier_Id = s.Supplier_Id
        WHERE gr.GoodsReceipt_Id = @NewGoodsReceiptID AND s.Supplier_Id = @SupplierID
        GROUP BY gr.GoodsReceipt_Id, gr.goodsReceiptDate, s.supplierName, e.employeeName;

        -- Trả về chi tiết sản phẩm nhập
        SELECT 
            d.Details_Id AS LineItemID,
            p.productName AS ProductName,
            d.quantity AS Quantity,
            d.productPrice AS UnitPrice,
            (d.quantity * d.productPrice) AS SubTotal
        FROM Details d
        JOIN Product p ON d.Product_Id = p.Product_Id
        WHERE d.GoodsReceipt_Id = @NewGoodsReceiptID;

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
        THROW;
    END CATCH
END
GO
