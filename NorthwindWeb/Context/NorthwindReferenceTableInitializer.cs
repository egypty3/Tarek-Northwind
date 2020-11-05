using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindWeb.Models;

namespace NorthwindWeb.Context
{
    /// <summary>
    /// This class contains functions that fill Region and Territories with Romanian data
    /// </summary>
    public static class NorthwindReferencedTableInitializer
    {
        /// <summary>
        /// Insert referenced data with new NorthwindDatabase() context
        /// </summary>
        public static void InsertNorthwindReferencedData()
        {
            var db = new NorthwindDatabase();
            InsertNorthwindReferencedData(db);
            db.Dispose();
        }

        /// <summary>
        /// Insert referenced data with given context
        /// </summary>
        /// <param name="context">Local Northwind Context</param>
        public static void InsertNorthwindReferencedData(NorthwindDatabase context)
        {
            //list of region
            List<Region> regions = new List<Region>
            {
                //add region in list
                new Region() { RegionID = 1, RegionDescription = "Banat" },
                new Region() { RegionID = 2, RegionDescription = "Bucovina" },
                new Region() { RegionID = 3, RegionDescription = "Crisana" },
                new Region() { RegionID = 4, RegionDescription = "Dobrogea" },
                new Region() { RegionID = 5, RegionDescription = "Maramures" },
                new Region() { RegionID = 6, RegionDescription = "Moldova" },
                new Region() { RegionID = 7, RegionDescription = "Muntenia" },
                new Region() { RegionID = 8, RegionDescription = "Oltenia" },
                new Region() { RegionID = 9, RegionDescription = "Transilvania" }
            };

            //add territories in regions
            regions[0].Territories.Add(new Territory() { TerritoryID = "1", TerritoryDescription = "Timis", RegionID = 1 });
            regions[0].Territories.Add(new Territory() { TerritoryID = "2", TerritoryDescription = "Caras - Severin", RegionID = 1 });
            regions[1].Territories.Add(new Territory() { TerritoryID = "3", TerritoryDescription = "Botosani", RegionID = 2 });
            regions[1].Territories.Add(new Territory() { TerritoryID = "4", TerritoryDescription = "Suceava", RegionID = 2 });
            regions[2].Territories.Add(new Territory() { TerritoryID = "5", TerritoryDescription = "Bihor", RegionID = 3 });
            regions[2].Territories.Add(new Territory() { TerritoryID = "6", TerritoryDescription = "Arad", RegionID = 3 });
            regions[3].Territories.Add(new Territory() { TerritoryID = "7", TerritoryDescription = "Tulcea", RegionID = 4 });
            regions[3].Territories.Add(new Territory() { TerritoryID = "8", TerritoryDescription = "Constanta", RegionID = 4 });
            regions[4].Territories.Add(new Territory() { TerritoryID = "9", TerritoryDescription = "Satu - Mare", RegionID = 5 });
            regions[4].Territories.Add(new Territory() { TerritoryID = "10", TerritoryDescription = "Maramures", RegionID = 5 });
            regions[5].Territories.Add(new Territory() { TerritoryID = "11", TerritoryDescription = "Neamt", RegionID = 6 });
            regions[5].Territories.Add(new Territory() { TerritoryID = "12", TerritoryDescription = "Iasi", RegionID = 6 });
            regions[5].Territories.Add(new Territory() { TerritoryID = "13", TerritoryDescription = "Bacau", RegionID = 6 });
            regions[5].Territories.Add(new Territory() { TerritoryID = "14", TerritoryDescription = "Vaslui", RegionID = 6 });
            regions[5].Territories.Add(new Territory() { TerritoryID = "15", TerritoryDescription = "Vrancea", RegionID = 6 });
            regions[5].Territories.Add(new Territory() { TerritoryID = "16", TerritoryDescription = "Galati", RegionID = 6 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "17", TerritoryDescription = "Braila", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "18", TerritoryDescription = "Buzau", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "19", TerritoryDescription = "Calarasi", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "20", TerritoryDescription = "Prahova", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "21", TerritoryDescription = "Dambovita", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "22", TerritoryDescription = "Arges", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "23", TerritoryDescription = "Ialomita", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "24", TerritoryDescription = "Calarasi", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "25", TerritoryDescription = "Ilfov", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "26", TerritoryDescription = "Bucuresti", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "27", TerritoryDescription = "Giurgiu", RegionID = 7 });
            regions[6].Territories.Add(new Territory() { TerritoryID = "28", TerritoryDescription = "Teleorman", RegionID = 7 });
            regions[7].Territories.Add(new Territory() { TerritoryID = "29", TerritoryDescription = "Gorj", RegionID = 8 });
            regions[7].Territories.Add(new Territory() { TerritoryID = "30", TerritoryDescription = "Valcea", RegionID = 8 });
            regions[7].Territories.Add(new Territory() { TerritoryID = "31", TerritoryDescription = "Olt", RegionID = 8 });
            regions[7].Territories.Add(new Territory() { TerritoryID = "32", TerritoryDescription = "Dolj", RegionID = 8 });
            regions[7].Territories.Add(new Territory() { TerritoryID = "33", TerritoryDescription = "Mehedinti", RegionID = 8 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "34", TerritoryDescription = "Salaj", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "35", TerritoryDescription = "Bistrita - Nasaud", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "36", TerritoryDescription = "Cluj", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "37", TerritoryDescription = "Mures", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "38", TerritoryDescription = "Harghita", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "39", TerritoryDescription = "Covasna", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "40", TerritoryDescription = "Brasov", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "41", TerritoryDescription = "Sibiu", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "42", TerritoryDescription = "Alba", RegionID = 9 });
            regions[8].Territories.Add(new Territory() { TerritoryID = "43", TerritoryDescription = "Hunedoara", RegionID = 9 });

            foreach (var region in regions)
            {
                context.Regions.Add(region);
            }
            context.SaveChanges();

            //category (they need to be added in this order)
            context.Categories.Add(new Category() { CategoryName = "Classical", Description = "Button phones" });
            context.SaveChanges();
            context.Categories.Add(new Category() { CategoryName = "Smartphone", Description = "Touch screen" });
            context.SaveChanges();
            context.Categories.Add(new Category() { CategoryName = "Accessory", Description = "Selfie sticks, Chargers, Headphones, Batteries, Covers" });
            context.SaveChanges();
            context.Categories.Add(new Category() { CategoryName = "Gadgets", Description = "Speakers, VR Glasses, Remote Controls" });
            context.SaveChanges();
            context.Categories.Add(new Category() { CategoryName = "eBook Reader", Description = "Bookreader" });
            context.SaveChanges();
            context.Categories.Add(new Category() { CategoryName = "Services", Description = "Services offered" });
            context.SaveChanges();

            //Suppliers (they need to be added in this order)
            context.Suppliers.Add(new Supplier() { CompanyName = "EURO GSM IMPEX S.R.L.", ContactName = "Ion Vasilde", ContactTitle = "Proprietar", Address = "B-dul Muncii nr.18", City = "CLUJ - NAPOCA", PostalCode = "400641", Country = "Romania", Phone = "0264450450", HomePage = "https://eurogsm.ro" });
            context.SaveChanges();
            context.Suppliers.Add(new Supplier() { CompanyName = "GERSIM IMPEX S.R.L.", ContactName = "Mircea Daniel", ContactTitle = "Manager depozit", Address = "Strada Bilciure?ti 9A", City = "BUCURESTI", PostalCode = "014012", Country = "Romania", Phone = "0213264850", Fax = "0213264851", HomePage = "http://www.gersim.ro" });
            context.SaveChanges();
            context.Suppliers.Add(new Supplier() { CompanyName = "EMAG S.A.", ContactName = "Dumitru George", ContactTitle = "Agent Vanzari", Address = "Windsor Building Sos.Bucuresti Nord nr. 15 - 23 ", City = "ILFOV", PostalCode = "077190", Country = "Romania", Phone = "0722.25.00.00", HomePage = "https://emag.ro" });
            context.SaveChanges();
            context.Suppliers.Add(new Supplier() { CompanyName = "SC MEDIA GALAXY S.R.L.", ContactName = "Popescu Mihai ", ContactTitle = "Reprezentant Vanzari", Address = "Bulevardul Poligrafiei Nr.1, Sector 1", City = "Bucuresti", PostalCode = "400641", Country = "Romania", Phone = "0212062000", Fax = "0213199939", HomePage = "www.mediagalaxy.ro" });
            context.SaveChanges();

            //products (they need to be added in this order)
            context.Products.Add(new Product() { ProductName = "Kindle 6 Glare Touch Screen WiFi Black", SupplierID = 1, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)339.00, UnitsInStock = 39, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Kindle PaperWhite Model 2015 Black", SupplierID = 2, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)629.00, UnitsInStock = 17, UnitsOnOrder = 40, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Kindle PaperWhite Model 2015 White", SupplierID = 2, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)599.00, UnitsInStock = 13, UnitsOnOrder = 70, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "PocketBook Touch LUX 3 Red pb626", SupplierID = 1, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)569.00, UnitsInStock = 53, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "PocketBook Touch LUX 3 White pb626", SupplierID = 2, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)569.00, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "PocketBook Touch LUX 3 Grey pb626", SupplierID = 1, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)569.00, UnitsInStock = 120, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "PocketBook Touch HD Black pb631", SupplierID = 4, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)799.00, UnitsInStock = 15, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bookeen CybooK Muse FrontLight Black", SupplierID = 3, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)699.00, UnitsInStock = 6, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Prestigio MultiReader SUPREME 4GB Black", SupplierID = 2, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)549.00, UnitsInStock = 29, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bookeen Cybook Muse HD 8GB Black", SupplierID = 4, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)569.00, UnitsInStock = 31, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bookeen Cybook Muse Light 4GB Black", SupplierID = 3, CategoryID = 5, QuantityPerUnit = "1", UnitPrice = (decimal?)579.00, UnitsInStock = 22, UnitsOnOrder = 30, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "CAT B25 Dual SIM Black", SupplierID = 2, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)229.00, UnitsInStock = 86, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Nokia 3310 Dual SIM Dark Blue", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)249.00, UnitsInStock = 24, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Alcatel Tiger X3 1016G Black", SupplierID = 4, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)69.00, UnitsInStock = 35, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Nokia 3310 Single Sim Orange", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)249.00, UnitsInStock = 39, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Nokia 130 Dual SIM Red", SupplierID = 2, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)99.00, UnitsInStock = 29, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Alcatel 1054 White", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)83.00, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Nokia 150 Single Sim White", SupplierID = 3, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)141.00, UnitsInStock = 42, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "MaxCom MM 141 Dual Sim Grey", SupplierID = 2, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)101.00, UnitsInStock = 25, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Alcatel 2008G Black-Silver", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)165.00, UnitsInStock = 40, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Nokia 216 Dual Sim Black", SupplierID = 3, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)156.00, UnitsInStock = 3, UnitsOnOrder = 40, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Nokia 216 Dual SIM Grey", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)156.00, UnitsInStock = 104, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Karbonn K-flip Dual Sim White", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)127.00, UnitsInStock = 61, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "MyPhone Metro Red", SupplierID = 2, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)209.00, UnitsInStock = 20, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "MyPhone 6310 Dual Sim Black", SupplierID = 3, CategoryID = 1, QuantityPerUnit = "1", UnitPrice = (decimal?)104.00, UnitsInStock = 76, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bratara Xiaomi Silicon - Roz", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)24.00, UnitsInStock = 15, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bratara Xiaomi Silicon - Verde", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)24.00, UnitsInStock = 49, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Curea Ceas 910XT GPS Negru", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)86.00, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bratara Gear S3 Silicon Maron", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)127.00, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Curea Apple Watch 38mm Piele Neagra", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)964.00, UnitsInStock = 10, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Dock Slate Union Pentru Apple Watch", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)217.00, UnitsInStock = 0, UnitsOnOrder = 70, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Dock Native Union Luxury Tech Marble", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)423.00, UnitsInStock = 9, UnitsOnOrder = 40, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Stand de incarcare Huawei Watch", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)95.00, UnitsInStock = 112, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Cablu de incarcare Fitbit Flex", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)25.00, UnitsInStock = 111, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Husa Apple Watch 38mm", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)49.00, UnitsInStock = 20, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bratara Smartwatch Silicon Argintiur", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)128.00, UnitsInStock = 112, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bratara Smartwatch Piele Neagra", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)115.00, UnitsInStock = 11, UnitsOnOrder = 50, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bratara Smartwatch Silicon Khaki", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)86.00, UnitsInStock = 17, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bratara Smartwatch Silicon Blue Black", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)86.00, UnitsInStock = 69, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Folie Protectie Curbata 42 mm Negra", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)36.00, UnitsInStock = 123, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Folie Protectie Curbata 38 mm Negra", SupplierID = 4, CategoryID = 3, QuantityPerUnit = "1", UnitPrice = (decimal?)36.00, UnitsInStock = 85, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Apple iPhone 7 32GB Black", SupplierID = 1, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)2999.00, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "OnePlus 5 A5000 64GB Dual SIM 4G Black", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)2599.00, UnitsInStock = 17, UnitsOnOrder = 10, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy A3(2017) 4G Black", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1199.00, UnitsInStock = 27, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy J5(2016) Dual SIM Gold", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)849.00, UnitsInStock = 5, UnitsOnOrder = 70, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy S8 G950F 64GB 4G Black", SupplierID = 1, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)2989.00, UnitsInStock = 95, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Apple iPhone 6 32GB Space Gray", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1899.00, UnitsInStock = 36, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy J1 Mini Prime Black", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)349.00, UnitsInStock = 15, UnitsOnOrder = 70, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy J1 Mini Prime Gold", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)349.00, UnitsInStock = 10, UnitsOnOrder = 60, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Xiaomi Redmi 4A 32GB Dark Grey", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)499.00, UnitsInStock = 65, UnitsOnOrder = 0, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Lenovo Moto Z 32GB Dual Sim 4G Black", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1659.00, UnitsInStock = 20, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy S8 Plus 64GB 4G Black", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)3549.00, UnitsInStock = 38, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "HTC 10 32GB 4G Gold", SupplierID = 1, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1799.00, UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Huawei P10 Lite 32GB Dual Sim 4G Gold", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1199.00, UnitsInStock = 21, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Apple iPhone SE 32GB Space Gray", SupplierID = 1, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1699.00, UnitsInStock = 115, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Huawei P10 Lite 32GB Dual Sim 4G Black", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1199.00, UnitsInStock = 21, UnitsOnOrder = 10, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy J1 Prime White", SupplierID = 1, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)339.00, UnitsInStock = 36, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Huawei P10 Lite 32GB Blue", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1199.00, UnitsInStock = 62, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Samsung Galaxy S6 Edge 32GB Black", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1899.00, UnitsInStock = 79, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Sony Xperia X Compact 32GB 4G Black", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1599.00, UnitsInStock = 19, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "LG G5 SE H840 32GB Titanium Grey", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)1349.00, UnitsInStock = 113, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "iPhone 6s 32GB 32gb Space Grey", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "1", UnitPrice = (decimal?)2599.00, UnitsInStock = 17, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Boxa Portabila Emie Cybertron Wireless", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)749.00, UnitsInStock = 24, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Ochelari Samsung Gear VR 2 SM - R323 Negru", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)209.00, UnitsInStock = 22, UnitsOnOrder = 80, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Manusi cu Casca Bluetooth Hi - Fun M Black", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)229.00, UnitsInStock = 76, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Dispozitiv monitorizare somn SenSe Sleep", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)119.00, UnitsInStock = 4, UnitsOnOrder = 100, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Telecomanda Bluetooth Esperanza", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)28.00, UnitsInStock = 52, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Stereo Hat with Black Microphone", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)37.00, UnitsInStock = 6, UnitsOnOrder = 10, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Seeker location device", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)29.00, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Media-Tech remote control for VR", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)39.00, UnitsInStock = 15, UnitsOnOrder = 10, ReorderLevel = 30, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Drone Arcade Orbit", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)149.00, UnitsInStock = 26, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "OnReal Black Background Video Camera", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)514.00, UnitsInStock = 14, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Bluetooth Arcade Remote", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)74.00, UnitsInStock = 101, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Ubtech Alpha Interactive Intelligent Robot", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)2369.00, UnitsInStock = 4, UnitsOnOrder = 20, ReorderLevel = 5, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Intelligent Service Robot Uno", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)3249.00, UnitsInStock = 125, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Portable Flip 4 Waterproof Black Box", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)579.00, UnitsInStock = 57, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Wireless Portable Speaker With Microphone", SupplierID = 1, CategoryID = 4, QuantityPerUnit = "1", UnitPrice = (decimal?)499.00, UnitsInStock = 32, UnitsOnOrder = 0, ReorderLevel = 15, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Diagnostics", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)60.00, UnitsInStock = 0, UnitsOnOrder = 10, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Battery replacement", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)120.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Screen replacement", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)400.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Protective foil replacement", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)70.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Motherboard replacement", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)900.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Android installation", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)80.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "IOS installation", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)120.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Install windows phone", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)80.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Windows phone data recovery", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)140.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "Android data recovery", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)120.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();
            context.Products.Add(new Product() { ProductName = "IOS data recovery", SupplierID = 1, CategoryID = 6, QuantityPerUnit = "1", UnitPrice = (decimal?)160.00, UnitsInStock = 0, UnitsOnOrder = 9, ReorderLevel = 1, Discontinued = false });
            context.SaveChanges();

        }
    }
}