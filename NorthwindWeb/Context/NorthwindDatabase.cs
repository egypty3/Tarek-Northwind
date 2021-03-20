using System.Data.Entity;
using NorthwindWeb.Models;

namespace NorthwindWeb.Context
{


    /// <summary>
    /// Context for northwind database.
    /// </summary>
    public partial class NorthwindDatabase : DbContext
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public NorthwindDatabase()
            : base("name=NorthwindDatabaseConnection") // name in web.config of Connection string.
        {
            Database.SetInitializer(new NorthwindDatabaseInitializer());
            //(new NorthwindDatabaseInitializer()).InsertInDatabase(this);

        }


        /// <summary>
        /// Context for Categories table in northwind database
        /// </summary>
        public virtual DbSet<Category> Categories { get; set; }
        /// <summary>
        /// Context for CustomerDemographics table in northwind database
        /// </summary>
        public virtual DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        /// <summary>
        /// Context for Customers table in northwind database
        /// </summary>
        public virtual DbSet<Customer> Customers { get; set; }
        /// <summary>
        /// Context for Employees table in northwind database
        /// </summary>
        public virtual DbSet<Employee> Employees { get; set; }
        /// <summary>
        /// Context for Order_Details table in northwind database
        /// </summary>
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        /// <summary>
        /// Context for Orders table in northwind database
        /// </summary>
        public virtual DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Context for Persons table in northwind database
        /// </summary>
        public virtual DbSet<Person> Persons { get; set; }
        /// <summary>
        /// Context for Products table in northwind database
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }
        /// <summary>
        /// Context for Regions table in northwind database
        /// </summary>
        public virtual DbSet<Region> Regions { get; set; }
        /// <summary>
        /// Context for Shippers table in northwind database
        /// </summary>
        public virtual DbSet<Shipper> Shippers { get; set; }
        /// <summary>
        /// Context for Suppliers table in northwind database
        /// </summary>
        public virtual DbSet<Supplier> Suppliers { get; set; }
        /// <summary>
        /// Context for Territories table in northwind database
        /// </summary>
        public virtual DbSet<Territory> Territories { get; set; }
        /// <summary>
        /// Context for ShopCart table in northwind database
        /// </summary>
        public virtual DbSet<ShopCart> ShopCart { get; set; }


        /// <summary>
        /// Build Information of Northwind DataBase
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CustomerDemographics>()
                .Property(e => e.CustomerTypeID)
                .IsFixedLength();

            modelBuilder.Entity<CustomerDemographics>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.CustomerDemographics)
                .Map(m => m.ToTable("CustomerCustomerDemo").MapLeftKey("CustomerTypeID").MapRightKey("CustomerID"));

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Territories)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeeTerritories").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"));

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionDescription)
                .IsFixedLength();

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Territories)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipper>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShipVia);

            modelBuilder.Entity<Territory>()
                .Property(e => e.TerritoryDescription)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ShopCart>()
                .HasRequired(a => a.Products)
                .WithMany()
                .HasForeignKey(a => a.ProductID);

            modelBuilder.Entity<ShopCart>()
                .Property(e => e.UserName)
                .IsRequired();

            modelBuilder.Entity<ShopCart>()
                .Property(e => e.Quantity)
                .IsRequired();
        }
    }
}
