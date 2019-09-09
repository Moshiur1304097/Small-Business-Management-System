namespace InfinityDotCom.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xvxfg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryCode = c.String(),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        CustomerEmail = c.String(),
                        CustomerContact = c.String(),
                        CustomerLP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        InvoiceDate = c.String(),
                        InvoiceNo = c.String(),
                        SuppliedID = c.Int(nullable: false),
                        Supplier_ID = c.Int(),
                    })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID)
                .Index(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(),
                        SupplierName = c.String(),
                        SupplierAddress = c.String(),
                        SupplierEmail = c.String(),
                        SupplierContact = c.String(),
                        SupplierContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(nullable: false),
                        ProductName = c.String(nullable: false),
                        ProductROL = c.Int(nullable: false),
                        ProductDescription = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.PurchaseProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InvoiceNo = c.String(),
                        ProductCode = c.String(),
                        ManufacturedDate = c.String(),
                        ExpireDate = c.String(),
                        Quantity = c.String(),
                        UnitPrice = c.String(),
                        TotalPrice = c.String(),
                        NewMRP = c.String(),
                        Remarks = c.String(),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.SalesProducts",
                c => new
                    {
                        SalesProductID = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Quantity = c.String(),
                        MRP = c.String(),
                        Discount = c.String(),
                        ProductID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalesProductID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesProducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.SalesProducts", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.PurchaseProducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Invoices", "Supplier_ID", "dbo.Suppliers");
            DropIndex("dbo.SalesProducts", new[] { "CustomerID" });
            DropIndex("dbo.SalesProducts", new[] { "ProductID" });
            DropIndex("dbo.PurchaseProducts", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Invoices", new[] { "Supplier_ID" });
            DropTable("dbo.SalesProducts");
            DropTable("dbo.PurchaseProducts");
            DropTable("dbo.Products");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
