using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindWeb.Models;

namespace NorthwindWeb.Context
{
    /// <summary>
    /// This class contains functions that fill Northwind Database with Test data
    /// </summary>
    public static class NorthwindTestDatabaseInitializer
    {
        /// <summary>
        /// Insert test data with new NorthwindDatabase() context
        /// </summary>
        /// <remarks>You need to insert the referencied data with InsertNorthwindReferencedData.InsertNorthwindReferencedData(...)</remarks>
        public static void InsertNorthwindTestData()
        {
            var db = new NorthwindDatabase();
            InsertNorthwindTestData(db);
            db.Dispose();
        }

        /// <summary>
        /// Insert test data with given context
        /// </summary>
        /// <remarks></remarks>
        /// <param name="context">Local Northwind Context</param>
        public static void InsertNorthwindTestData(NorthwindDatabase context)
        {
            //employees
            List<Employees> employees = new List<Employees>()
            {
                new Employees() {LastName = "Fuller",   FirstName = "Andrew", Title = "Vice President, Sales", TitleOfCourtesy = "Dr.", BirthDate = new DateTime(1952, 02, 18), HireDate = new DateTime(1992, 08, 13), Address = "Str.Hornului, nr. 22, ap 3, Bucuresti Sector 4", City = "Bucuresti", Region = "4", PostalCode = "031317", Country = "Romania", HomePhone = "0753255371", Extension = "", Notes = "Andrew received his senior technician degree in 1984 and a doctorate in international marketing from the University of Dallas in 1991. He is fluent in French and Italian and reads German. He joined the company as a sales representative, was promoted to director. sales in January 2002 and vice president of sales in March 2003. Andrew is a member of the Seattle Chamber of Commerce." },
                new Employees() {LastName = "Davolio",   FirstName = "Nancy", Title = "Sales Representative", TitleOfCourtesy = "Ms.", BirthDate = new DateTime(1948, 12, 07), HireDate = new DateTime(1992, 04, 30), Address = "Spl.Independentei, nr. 27, ap 27, Bucuresti Sector 6", City = "Bucuresti", Region = "6", PostalCode = "050082", Country = "Romania", HomePhone = "0751292371", Extension = "", Notes = "She holds a bachelor's degree in psychology from Colorado State University in 1980. She also completed the \"Art of Cold Calling.\" Nicoleta is a member of Toastmasters International.", ReportsTo = 2 },
                new Employees() {LastName = "Leverling",     FirstName = "Janet", Title = "Sales Representative", TitleOfCourtesy = "Ms.", BirthDate = new DateTime(1963, 08, 29), HireDate = new DateTime(1992, 03, 31), Address = "Str.Cupolei, nr 54, ap 15, Bucuresti Sector 6", City = "Bucuresti", Region = "6", PostalCode = "061158", Country = "Romania", HomePhone = "0723292441", Extension = "", Notes = "Janet has a degree in chemistry from Boston College (1994). She completed a certification program in the field of food retail management. Janet was hired as a saleswoman in 2001 and was promoted to sales representative in February 2002.", ReportsTo = 2 },
                new Employees() {LastName = "Peacock",  FirstName = "Margaret", Title = "Sales Representative", TitleOfCourtesy = "Mrs.", BirthDate = new DateTime(1937, 09, 18), HireDate = new DateTime(1993, 05, 02), Address = "Str.Hornului, nr. 22, ap 4, Bucuresti Sector 4", City = "Bucuresti", Region = "4", PostalCode = "031317", Country = "Romania", HomePhone = "0752212371", Extension = "", Notes = "Margaret holds a bachelor's degree in English literature from Concordia College (1978) and a bachelor's degree from the American Institute of Culinary Arts (1986).", ReportsTo = 2 },
                new Employees() {LastName = "Buchanan",FirstName = "Steven", Title = "Sales Manager", TitleOfCourtesy = "Mr.", BirthDate = new DateTime(1955, 03, 03), HireDate = new DateTime(1993, 10, 16), Address = "Str.Preciziei, nr 2, ap 32, Bucuresti Sector 6", City = "Bucuresti", Region = "6", PostalCode = "062203", Country = "Romania", HomePhone = "0712292991", Extension = "", Notes = "Steven graduated from the University of St. Andrews, Scotland, graduated with a degree in science in 1986. After joining the company as a sales representative in 2002, he spent 6 months in an orientation program at his Seattle office and then returned to his permanent position in London. promoted to sales manager in March 1993. Mr.Buchanan graduated from the courses \"Successful Telemarketing\" and \"International Sales Management\" and is fluent in French.", ReportsTo = 2 },
                new Employees() {LastName = "Suyama",    FirstName = "Michael", Title = "Sales Representative", TitleOfCourtesy = "Mr.", BirthDate = new DateTime(1963, 07, 01), HireDate = new DateTime(1993, 10, 16), Address = "Str Ghirlandei, nr 5, ap 40, Bucuresti Sector 6", City = "Bucuresti", Region = "6", PostalCode = "062242", Country = "Romania", HomePhone = "0751217471", Extension = "", Notes = "Michael is a graduate of the University of Sussex (MA, Economics, 1993) and the University of California, Los Angeles (MBA, marketing, 2016). He has also taken courses in Multicultural Sales and Time Management for Sales Professionals. He is fluent in Japanese and can read and write French, Portuguese and Spanish.", ReportsTo = 5 },
                new Employees() {LastName = "King",FirstName = "Robert", Title = "Sales Representative", TitleOfCourtesy = "Mr.", BirthDate = new DateTime(1960, 05, 28), HireDate = new DateTime(1994, 01, 01), Address = "Str.Fabricii, nr 4, ap 4, Bucuresti Sector 6", City = "Bucuresti", Region = "6", PostalCode = "060823", Country = "Romania", HomePhone = "0718642371", Extension = "", Notes = "Robert was in the Peace Corps and traveled extensively before completing his English studies at the University of Michigan in 2002, the year he joined the company. After completing the \"Selling in Europe\" course, he was transferred to the London office in March 2003.", ReportsTo = 5 },
                new Employees() {LastName = "Callahan", FirstName = "Laura", Title = "Inside Sales Coordinator", TitleOfCourtesy = "Ms.", BirthDate = new DateTime(1958, 01, 08), HireDate = new DateTime(1994, 03, 04), Address = "Str.Lugoj, nr 2, ap 12, Bucuresti Sector 6", City = "Bucuresti", Region = "6", PostalCode = "012212", Country = "Romania", HomePhone = "0712392335", Extension = "", Notes = "Laura holds a degree in psychology from the University of Washington. She also completed a French business course. Read and write French.", ReportsTo = 2 },
                new Employees() {LastName = "Dodsworth", FirstName = "Anne", Title = "Sales Representative", TitleOfCourtesy = "Ms.", BirthDate = new DateTime(1966, 01, 26), HireDate = new DateTime(1994, 11, 14), Address = "Str.Comana, nr 2, ap 23, Bucuresti Sector 6", City = "Bucuresti", Region = "6", PostalCode = "011274", Country = "Romania", HomePhone = "0764882331", Extension = "", Notes = "Anne has a bachelor's degree in English from St. Paul's College. Lawrence. She is fluent in French and German.", ReportsTo = 5 }
            };

            employees[0].Territories = context.Territories.Where(x => x.TerritoryID == "12" || x.TerritoryID == "19" || x.TerritoryID == "23" || x.TerritoryID == "26" || x.TerritoryID == "27").ToList();
            employees[1].Territories = context.Territories.Where(x => x.TerritoryID == "10" || x.TerritoryID == "34" || x.TerritoryID == "35" || x.TerritoryID == "36" || x.TerritoryID == "5" || x.TerritoryID == "9").ToList();
            employees[2].Territories = context.Territories.Where(x => x.TerritoryID == "11" || x.TerritoryID == "12" || x.TerritoryID == "3" || x.TerritoryID == "35" || x.TerritoryID == "37" || x.TerritoryID == "38" || x.TerritoryID == "4").ToList();
            employees[3].Territories = context.Territories.Where(x => x.TerritoryID == "11" || x.TerritoryID == "12" || x.TerritoryID == "13" || x.TerritoryID == "14" || x.TerritoryID == "16").ToList();
            employees[4].Territories = context.Territories.Where(x => x.TerritoryID == "1" || x.TerritoryID == "2" || x.TerritoryID == "29" || x.TerritoryID == "33" || x.TerritoryID == "42" || x.TerritoryID == "43" || x.TerritoryID == "6").ToList();
            employees[5].Territories = context.Territories.Where(x => x.TerritoryID == "22" || x.TerritoryID == "28" || x.TerritoryID == "29" || x.TerritoryID == "30" || x.TerritoryID == "31" || x.TerritoryID == "32" || x.TerritoryID == "33").ToList();
            employees[6].Territories = context.Territories.Where(x => x.TerritoryID == "36" || x.TerritoryID == "37" || x.TerritoryID == "38" || x.TerritoryID == "39" || x.TerritoryID == "40" || x.TerritoryID == "41" || x.TerritoryID == "42").ToList();
            employees[7].Territories = context.Territories.Where(x => x.TerritoryID == "15" || x.TerritoryID == "16" || x.TerritoryID == "17" || x.TerritoryID == "18" || x.TerritoryID == "20" || x.TerritoryID == "21" || x.TerritoryID == "25" || x.TerritoryID == "26" || x.TerritoryID == "39" || x.TerritoryID == "40" || x.TerritoryID == "7").ToList();
            employees[8].Territories = context.Territories.Where(x => x.TerritoryID == "17" || x.TerritoryID == "18" || x.TerritoryID == "20" || x.TerritoryID == "21" || x.TerritoryID == "23" || x.TerritoryID == "24" || x.TerritoryID == "26" || x.TerritoryID == "27" || x.TerritoryID == "7" || x.TerritoryID == "8").ToList();

            foreach (var empolyee in employees)
            {
                context.Employees.Add(empolyee);
                //to keep the order
                context.SaveChanges();
            }

            //shippers
            List<Shippers> shippers = new List<Shippers>
            {
                new Shippers(){ CompanyName = "FedEx", Phone = "+40213034567"},
                new Shippers(){ CompanyName = "Urgent Cargus", Phone = "021 9330"},
                new Shippers(){ CompanyName = "FAN Courier", Phone = "+40742552233"},
            };

            foreach (var shipper in shippers)
            {
                context.Shippers.Add(shipper);
            }
            context.SaveChanges();

            
            //customers and orders
            List<Customers> customers = new List<Customers>
            {
                new Customers(){ CustomerID = "ALFKI", CompanyName = "RadioCom S.A.",               ContactName = "Danut Gogean"        , ContactTitle = "Reprezentant Vanzari" , Address = "STR. 10 MAI nr. 15, DaMBOVITA"           , City = "Targoviste", Region = "Muntenia"    , PostalCode = "130062", Country = "Romania", Phone = "0245-216 446" },
                new Customers(){ CustomerID = "ANATR", CompanyName = "OTE S.A.",                    ContactName = "Gabriella Anghelescu", ContactTitle = "Patron"               , Address = "Strada Caraiman 3, Constanta"            , City = "Constanta" , Region = "Dobrogea"    , PostalCode = "907021", Country = "Romania", Phone = "0723-564 218"  , Fax = "0251.411688" },
                new Customers(){ CustomerID = "ANTON", CompanyName = "Digi Telecom S.A.",                 ContactName = "Dorin Butacu"        , ContactTitle = "Patron"               , Address = "Piata Revolutiei 3/26, Maramures"        , City = "Maramures" , Region = "Maramures"   , PostalCode = "873309", Country = "Romania", Phone = "+40(262)260999", Fax = "+40(262)271338" },
                new Customers(){ CustomerID = "AROUT", CompanyName = "Cosmote S.A.",                  ContactName = "Ioana Draghici"      , ContactTitle = "Reprezentant Vanzari" , Address = "STR. VULCAN SAMUIL nr. 16, BEIUS"        , City = "BIHOR"     , Region = "Crisana"     , PostalCode = "653271", Country = "Romania", Phone = "0259-320 222"  , Fax = "0251.418803" },
                new Customers(){ CustomerID = "BERGS", CompanyName = "Telecom S.R.L.",                 ContactName = "Varujan Puscas"      , ContactTitle = "Administrator Comenzi", Address = "Bulevardul Ion Mihalache 148B, Bucuresti", City = "Bucuresti" , Region = "Muntenia"    , PostalCode = "666708", Country = "Romania", Phone = "+40(21)2246714", Fax = "0251.413102" },
                new Customers(){ CustomerID = "BLAUS", CompanyName = "Vodafone S.A.",            ContactName = "Stefan Manole"       , ContactTitle = "Reprezentant Vanzari" , Address = "STR. 9 MAI, BACAU"                       , City = "Bacau"     , Region = "Moldova"     , PostalCode = "546708", Country = "Romania", Phone = "0740-082 824"  , Fax = "0251.413102" },
                new Customers(){ CustomerID = "BLONP", CompanyName = "Orange S.A.",             ContactName = "Varujan Teodorescu"  , ContactTitle = "Director Marketing"   , Address = "STR. BARNUTIU SIMION nr. 67, SALAJ"      , City = "SALAJ"     , Region = "Transilvania", PostalCode = "437945", Country = "Romania", Phone = "0260-616 920"  , Fax = "0251.418803" },
             };

            foreach (var customer in customers)
            {
                context.Customers.Add(customer);
            }
            context.SaveChanges();

            //orders
            context.Orders.Add(new Orders() { CustomerID = "ALFKI", EmployeeID = 2, OrderDate = new DateTime(2016, 09, 22), RequiredDate = new DateTime(2016, 10, 20), ShippedDate = new DateTime(2016, 10, 02), ShipVia = 2, Freight = (decimal?)40.26, ShipName = "Vinyl Fever", ShipAddress = "STR. 10 MAI nr. 15, DaMBOVITA", ShipCity = "Targoviste", ShipRegion = "Muntenia", ShipPostalCode = "453993", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ALFKI", EmployeeID = 1, OrderDate = new DateTime(2016, 11, 18), RequiredDate = new DateTime(2016, 12, 16), ShippedDate = new DateTime(2016, 12, 01), ShipVia = 3, Freight = (decimal?)34.88, ShipName = "Vinyl Fever", ShipAddress = "STR. 10 MAI nr. 15, DaMBOVITA", ShipCity = "Targoviste", ShipRegion = "Muntenia", ShipPostalCode = "453993", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ALFKI", EmployeeID = 1, OrderDate = new DateTime(2016, 12, 04), RequiredDate = new DateTime(2017, 01, 01), ShippedDate = new DateTime(2016, 12, 08), ShipVia = 3, Freight = (decimal?)3.94, ShipName = "Vinyl Fever", ShipAddress = "STR. 10 MAI nr. 15, DaMBOVITA", ShipCity = "Targoviste", ShipRegion = "Muntenia", ShipPostalCode = "453993", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ANATR", EmployeeID = 8, OrderDate = new DateTime(2016, 08, 12), RequiredDate = new DateTime(2016, 09, 09), ShippedDate = new DateTime(2016, 08, 15), ShipVia = 2, Freight = (decimal?)25.83, ShipName = "Kash n", ShipAddress = "Strada Caraiman 3, Constanta", ShipCity = "Constanta", ShipRegion = "Dobrogea", ShipPostalCode = "907021", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ANATR", EmployeeID = 4, OrderDate = new DateTime(2017, 02, 09), RequiredDate = new DateTime(2017, 03, 09), ShippedDate = new DateTime(2017, 02, 27), ShipVia = 2, Freight = (decimal?)86.53, ShipName = "Kash n", ShipAddress = "Strada Caraiman 3, Constanta", ShipCity = "Constanta", ShipRegion = "Dobrogea", ShipPostalCode = "907021", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ANATR", EmployeeID = 4, OrderDate = new DateTime(2017, 04, 01), RequiredDate = new DateTime(2017, 04, 29), ShippedDate = new DateTime(2017, 04, 08), ShipVia = 2, Freight = (decimal?)65.99, ShipName = "Kash n", ShipAddress = "Strada Caraiman 3, Constanta", ShipCity = "Constanta", ShipRegion = "Dobrogea", ShipPostalCode = "907021", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ANATR", EmployeeID = 3, OrderDate = new DateTime(2017, 07, 07), RequiredDate = new DateTime(2017, 08, 04), ShippedDate = new DateTime(2017, 07, 13), ShipVia = 1, Freight = (decimal?)43.90, ShipName = "Ana", ShipAddress = "Strada Caraiman 3, Constanta", ShipCity = "Constanta", ShipRegion = "Dobrogea", ShipPostalCode = "05021", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ANTON", EmployeeID = 6, OrderDate = new DateTime(2016, 07, 31), RequiredDate = new DateTime(2016, 08, 28), ShippedDate = new DateTime(2016, 08, 29), ShipVia = 2, Freight = (decimal?)4.54, ShipName = "Tech Hifi", ShipAddress = "Piata Revolutiei 3/26, Maramures", ShipCity = "Maramures", ShipRegion = "Maramures", ShipPostalCode = "873309", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "ANTON", EmployeeID = 1, OrderDate = new DateTime(2016, 10, 08), RequiredDate = new DateTime(2016, 10, 22), ShippedDate = new DateTime(2016, 10, 13), ShipVia = 3, Freight = (decimal?)64.86, ShipName = "Tech Hifi", ShipAddress = "Piata Revolutiei 3/26, Maramures", ShipCity = "Maramures", ShipRegion = "Maramures", ShipPostalCode = "873309", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "AROUT", EmployeeID = 7, OrderDate = new DateTime(2016, 10, 01), RequiredDate = new DateTime(2016, 10, 29), ShippedDate = new DateTime(2016, 10, 10), ShipVia = 3, Freight = (decimal?)64.50, ShipName = "Beatties", ShipAddress = "STR. VULCAN SAMUIL nr. 16, BEIUS", ShipCity = "BIHOR", ShipRegion = "Crisana", ShipPostalCode = "653271", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "AROUT", EmployeeID = 6, OrderDate = new DateTime(2016, 07, 14), RequiredDate = new DateTime(2016, 08, 12), ShippedDate = new DateTime(2016, 08, 19), ShipVia = 1, Freight = (decimal?)41.95, ShipName = "Around the Horn", ShipAddress = "Brook Farm Stratford St. Mary", ShipCity = "Colchester", ShipRegion = "Essex", ShipPostalCode = "CO7 6JX", ShipCountry = "UK" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "AROUT", EmployeeID = 1, OrderDate = new DateTime(2015, 01, 08), RequiredDate = new DateTime(2015, 01, 27), ShippedDate = new DateTime(2015, 01, 12), ShipVia = 3, Freight = (decimal?)22.21, ShipName = "Beatties", ShipAddress = "STR. VULCAN SAMUIL nr. 16, BEIUS", ShipCity = "BIHOR", ShipRegion = "Crisana", ShipPostalCode = "653271", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "AROUT", EmployeeID = 1, OrderDate = new DateTime(2017, 02, 20), RequiredDate = new DateTime(2017, 03, 20), ShippedDate = new DateTime(2017, 02, 25), ShipVia = 2, Freight = (decimal?)25.36, ShipName = "Around the Horn", ShipAddress = "Brook Farm Stratford St. Mary", ShipCity = "Colchester", ShipRegion = "Essex", ShipPostalCode = "CO7 6JX", ShipCountry = "UK" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "AROUT", EmployeeID = 2, OrderDate = new DateTime(2017, 05, 28), RequiredDate = new DateTime(2017, 06, 25), ShippedDate = new DateTime(2017, 06, 04), ShipVia = 1, Freight = (decimal?)83.22, ShipName = "Beatties", ShipAddress = "STR. VULCAN SAMUIL nr. 16, BEIUS", ShipCity = "BIHOR", ShipRegion = "Crisana", ShipPostalCode = "653271", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BERGS", EmployeeID = 1, OrderDate = new DateTime(2016, 07, 31), RequiredDate = new DateTime(2016, 08, 28), ShippedDate = new DateTime(2016, 08, 01), ShipVia = 1, Freight = (decimal?)136.54, ShipName = "Cut Above", ShipAddress = "Bulevardul Ion Mihalache 148B, Bucuresti", ShipCity = "Bucuresti", ShipRegion = "Muntenia", ShipPostalCode = "666708", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLAUS", EmployeeID = 1, OrderDate = new DateTime(2016, 12, 31), RequiredDate = new DateTime(2017, 01, 28), ShippedDate = new DateTime(2017, 01, 15), ShipVia = 3, Freight = (decimal?)83.93, ShipName = "Sears Homelife", ShipAddress = "STR. 9 MAI, BACAU", ShipCity = "Bacau", ShipRegion = "Moldova 546708", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLAUS", EmployeeID = 2, OrderDate = new DateTime(2017, 01, 06), RequiredDate = new DateTime(2017, 02, 03), ShippedDate = new DateTime(2017, 01, 29), ShipVia = 2, Freight = (decimal?)91.48, ShipName = "Sears Homelife", ShipAddress = "STR. 9 MAI, BACAU", ShipCity = "Bacau", ShipRegion = "Moldova 546708", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLAUS", EmployeeID = 4, OrderDate = new DateTime(2017, 04, 16), RequiredDate = new DateTime(2017, 05, 14), ShippedDate = new DateTime(2017, 04, 28), ShipVia = 1, Freight = (decimal?)0.15, ShipName = "Blauer See", ShipAddress = "Delikatessen Forsterstr. 57 ", ShipCity = "Mannheim", ShipPostalCode = "68306", ShipCountry = "Germany" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLONP", EmployeeID = 2, OrderDate = new DateTime(2016, 07, 24), RequiredDate = new DateTime(2016, 08, 21), ShippedDate = new DateTime(2016, 08, 11), ShipVia = 1, Freight = (decimal?)55.28, ShipName = "Blondel père et fils", ShipAddress = "STR. BARNUTIU SIMION nr. 67, SALAJ", ShipCity = "SALAJ", ShipRegion = "Transilvania", ShipPostalCode = "67000", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLONP", EmployeeID = 4, OrderDate = new DateTime(2015, 08, 22), RequiredDate = new DateTime(2015, 09, 19), ShippedDate = new DateTime(2015, 09, 02), ShipVia = 1, Freight = (decimal?)7.45, ShipName = "Century House", ShipAddress = "STR. BARNUTIU SIMION nr. 67, SALAJ", ShipCity = "SALAJ", ShipRegion = "Transilvania", ShipPostalCode = "67000", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLONP", EmployeeID = 4, OrderDate = new DateTime(2016, 11, 21), RequiredDate = new DateTime(2016, 12, 19), ShippedDate = new DateTime(2016, 12, 01), ShipVia = 3, Freight = (decimal?)131.70, ShipName = "Blondel père et fils", ShipAddress = "STR. BARNUTIU SIMION nr. 67, SALAJ", ShipCity = "SALAJ", ShipPostalCode = "67000", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLONP", EmployeeID = 1, OrderDate = new DateTime(2016, 07, 05), RequiredDate = new DateTime(2016, 08, 02), ShippedDate = new DateTime(2016, 07, 21), ShipVia = 1, Freight = (decimal?)34.82, ShipName = "Century House", ShipAddress = "STR. BARNUTIU SIMION nr. 67, SALAJ", ShipCity = "SALAJ", ShipRegion = "Transilvania", ShipPostalCode = "67000", ShipCountry = "Romania" });
            context.SaveChanges();
            context.Orders.Add(new Orders() { CustomerID = "BLONP", EmployeeID = 1, OrderDate = new DateTime(2016, 07, 05), RequiredDate = new DateTime(2016, 08, 02), ShippedDate = new DateTime(2016, 07, 21), ShipVia = 1, Freight = (decimal?)34.82, ShipName = "Services", ShipAddress = "STR. BARNUTIU SIMION nr. 67, SALAJ", ShipCity = "SALAJ", ShipRegion = "Transilvania", ShipPostalCode = "67000", ShipCountry = "Romania" });
            context.SaveChanges();

            //order details 
            List<Order_Details> orderDetails = new List<Order_Details>
            {
                new Order_Details(){OrderID = 1, ProductID = 11, UnitPrice = 14.00M, Quantity =12 , Discount =  0   },
                new Order_Details(){OrderID = 1, ProductID = 42, UnitPrice = 9.80M, Quantity =10 , Discount =  0   },
                new Order_Details(){OrderID = 1, ProductID = 72, UnitPrice = 34.80M, Quantity =5  , Discount =  0   },
                new Order_Details(){OrderID = 1, ProductID = 31, UnitPrice = 10.00M , Quantity =15 , Discount =  0.05f},
                new Order_Details(){OrderID = 1, ProductID = 33, UnitPrice = 2.00M  , Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 1, ProductID = 40, UnitPrice = 14.70M , Quantity =60 , Discount =  0.05f},
                new Order_Details(){OrderID = 2, ProductID = 14, UnitPrice = 18.60M, Quantity =9  , Discount =  0   },
                new Order_Details(){OrderID = 2, ProductID = 51, UnitPrice = 42.40M, Quantity =40 , Discount =  0   },
                new Order_Details(){OrderID = 2, ProductID = 41, UnitPrice = 7.70M, Quantity =10 , Discount =  0   },
                new Order_Details(){OrderID = 3, ProductID = 51, UnitPrice = 42.40M, Quantity =35 , Discount =  0.15f},
                new Order_Details(){OrderID = 3, ProductID = 65, UnitPrice = 16.80M, Quantity =15 , Discount =  0.15f},
                new Order_Details(){OrderID = 3, ProductID = 22, UnitPrice = 16.80M, Quantity =6  , Discount =  0.05f},
                new Order_Details(){OrderID = 3, ProductID = 76, UnitPrice = 14.40M , Quantity =33 , Discount =  0.05f},
                new Order_Details(){OrderID = 3, ProductID = 71, UnitPrice = 17.20M , Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 3, ProductID = 72, UnitPrice = 27.80M , Quantity =7  , Discount =  0   },
                new Order_Details(){OrderID = 4, ProductID = 57, UnitPrice = 15.60M, Quantity =15 , Discount =  0.05f},
                new Order_Details(){OrderID = 4, ProductID = 65, UnitPrice = 16.80M, Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 4, ProductID = 20, UnitPrice = 64.80M, Quantity =40 , Discount =  0.05f},
                new Order_Details(){OrderID = 5, ProductID = 33, UnitPrice = 2.00M, Quantity =25 , Discount =  0.05f},
                new Order_Details(){OrderID = 5, ProductID = 60, UnitPrice = 27.20M, Quantity =40 , Discount =  0   },
                new Order_Details(){OrderID = 5, ProductID = 31, UnitPrice = 10.00M, Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 6, ProductID = 39, UnitPrice = 14.40M, Quantity =42 , Discount =  0   },
                new Order_Details(){OrderID = 6, ProductID = 49, UnitPrice = 16.00M, Quantity =40 , Discount =  0   },
                new Order_Details(){OrderID = 6, ProductID = 24, UnitPrice = 3.60M, Quantity =15 , Discount =  0.15f},
                new Order_Details(){OrderID = 6, ProductID = 25, UnitPrice = 3.60M  , Quantity =12 , Discount =  0.05f},
                new Order_Details(){OrderID = 6, ProductID = 59, UnitPrice = 44.00M , Quantity =6  , Discount =  0.05f},
                new Order_Details(){OrderID = 6, ProductID = 10, UnitPrice = 24.80M , Quantity =15 , Discount =  0   },
                new Order_Details(){OrderID = 7, ProductID = 55, UnitPrice = 19.20M, Quantity =21 , Discount =  0.15f},
                new Order_Details(){OrderID = 7, ProductID = 74, UnitPrice = 8.00M, Quantity =21 , Discount =  0   },
                new Order_Details(){OrderID = 7, ProductID = 2 , UnitPrice = 15.20M, Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 8, ProductID = 16, UnitPrice = 13.90M, Quantity =35 , Discount =  0   },
                new Order_Details(){OrderID = 8, ProductID = 36, UnitPrice = 15.20M, Quantity =25 , Discount =  0   },
                new Order_Details(){OrderID = 8, ProductID = 59, UnitPrice = 44.00M, Quantity =30 , Discount =  0   },
                new Order_Details(){OrderID = 8, ProductID = 13, UnitPrice = 4.80M  , Quantity =10 , Discount =  0   },
                new Order_Details(){OrderID = 8, ProductID = 28, UnitPrice = 36.40M , Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 8, ProductID = 62, UnitPrice = 39.40M , Quantity =12 , Discount =  0   },
                new Order_Details(){OrderID = 8, ProductID = 44, UnitPrice = 15.50M , Quantity =16 , Discount =  0   },
                new Order_Details(){OrderID = 9, ProductID = 53, UnitPrice = 26.20M, Quantity =15 , Discount =  0   },
                new Order_Details(){OrderID = 9, ProductID = 77, UnitPrice = 10.40M, Quantity =12 , Discount =  0   },
                new Order_Details(){OrderID = 9, ProductID = 27, UnitPrice = 35.10M, Quantity =25 , Discount =  0   },
                new Order_Details(){OrderID = 10, ProductID = 39, UnitPrice = 14.40M, Quantity =6  , Discount =  0   },
                new Order_Details(){OrderID = 10, ProductID = 77, UnitPrice = 10.40M, Quantity =15 , Discount =  0   },
                new Order_Details(){OrderID = 10, ProductID = 2 , UnitPrice = 15.20M, Quantity =50 , Discount =  0.2f },
                new Order_Details(){OrderID = 11, ProductID = 5 , UnitPrice = 17.00M , Quantity =65 , Discount =  0.2f },
                new Order_Details(){OrderID = 11, ProductID = 32, UnitPrice = 25.60M , Quantity =6  , Discount =  0.2f },
                new Order_Details(){OrderID = 11, ProductID = 21, UnitPrice = 8.00M  , Quantity =10 , Discount =  0   },
                new Order_Details(){OrderID = 12, ProductID = 37, UnitPrice = 20.80M , Quantity =1  , Discount =  0   },
                new Order_Details(){OrderID = 12, ProductID = 41, UnitPrice = 7.70M  , Quantity =16 , Discount =  0.25f},
                new Order_Details(){OrderID = 12, ProductID = 57, UnitPrice = 15.60M , Quantity =50 , Discount =  0   },
                new Order_Details(){OrderID = 13, ProductID = 62, UnitPrice = 39.40M , Quantity =15 , Discount =  0.25f},
                new Order_Details(){OrderID = 13, ProductID = 70, UnitPrice = 12.00M , Quantity =21 , Discount =  0.25f},
                new Order_Details(){OrderID = 13, ProductID = 21, UnitPrice = 8.00M , Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 14, ProductID = 35, UnitPrice = 14.40M , Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 14, ProductID = 5 , UnitPrice = 17.00M , Quantity =12 , Discount =  0.2f },
                new Order_Details(){OrderID = 14, ProductID = 7 , UnitPrice = 24.00M , Quantity =15 , Discount =  0   },
                new Order_Details(){OrderID = 15, ProductID = 56, UnitPrice = 30.40M , Quantity =2  , Discount =  0   },
                new Order_Details(){OrderID = 15, ProductID = 16, UnitPrice = 13.90M , Quantity =60 , Discount =  0.25f},
                new Order_Details(){OrderID = 15, ProductID = 24, UnitPrice = 3.60M  , Quantity =28 , Discount =  0   },
                new Order_Details(){OrderID = 16, ProductID = 30, UnitPrice = 20.70M , Quantity =60 , Discount =  0.25f},
                new Order_Details(){OrderID = 16, ProductID = 74, UnitPrice = 8.00M  , Quantity =36 , Discount =  0.25f},
                new Order_Details(){OrderID = 16, ProductID = 2 , UnitPrice = 15.20M , Quantity =35 , Discount =  0   },
                new Order_Details(){OrderID = 16, ProductID = 24, UnitPrice = 3.60M  , Quantity =12 , Discount =  0   },
                new Order_Details(){OrderID = 16, ProductID = 55, UnitPrice = 19.20M , Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 16, ProductID = 75, UnitPrice = 6.20M  , Quantity =30 , Discount =  0   },
                new Order_Details(){OrderID = 16, ProductID = 19, UnitPrice = 7.30M  , Quantity =1  , Discount =  0 },
                new Order_Details(){OrderID = 17, ProductID = 41, UnitPrice = 7.70M , Quantity =25 , Discount =  0.15f},
                new Order_Details(){OrderID = 17, ProductID = 17, UnitPrice = 31.20M , Quantity =30 , Discount =  0   },
                new Order_Details(){OrderID = 17, ProductID = 70, UnitPrice = 12.00M , Quantity =20 , Discount =  0   },
                new Order_Details(){OrderID = 18, ProductID = 12, UnitPrice = 30.40M , Quantity =12 , Discount =  0.05f},
                new Order_Details(){OrderID = 18, ProductID = 40, UnitPrice = 14.70M , Quantity =50 , Discount =  0   },
                new Order_Details(){OrderID = 18, ProductID = 59, UnitPrice = 44.00M , Quantity =70 , Discount =  0.15f},
                new Order_Details(){OrderID = 19, ProductID = 76, UnitPrice = 14.40M , Quantity =15 , Discount =  0.15f},
                new Order_Details(){OrderID = 19, ProductID = 29, UnitPrice = 99.00M , Quantity =10 , Discount =  0   },
                new Order_Details(){OrderID = 19, ProductID = 72, UnitPrice = 27.80M , Quantity =4  , Discount =  0   },
                new Order_Details(){OrderID = 20, ProductID = 33, UnitPrice = 2.00M  , Quantity =60 , Discount =  0.05f},
                new Order_Details(){OrderID = 20, ProductID = 72, UnitPrice = 27.80M , Quantity =20 , Discount =  0.05f},
                new Order_Details(){OrderID = 20, ProductID = 36, UnitPrice = 15.20M , Quantity =30 , Discount =  0   },
                new Order_Details(){OrderID = 20, ProductID = 59, UnitPrice = 44.00M , Quantity =15 , Discount =  0   },
                new Order_Details(){OrderID = 20, ProductID = 63, UnitPrice = 35.10M , Quantity =8  , Discount =  0   },
                new Order_Details(){OrderID = 20, ProductID = 73, UnitPrice = 12.00M , Quantity =25 , Discount =  0   },
                new Order_Details(){OrderID = 20, ProductID = 17, UnitPrice = 31.20M , Quantity =15 , Discount =  0.25f},
                new Order_Details(){OrderID = 21, ProductID = 43, UnitPrice = 36.80M , Quantity =25 , Discount =  0   },
                new Order_Details(){OrderID = 21, ProductID = 33, UnitPrice = 2.00M  , Quantity =24 , Discount =  0   },
                new Order_Details(){OrderID = 21, ProductID = 20, UnitPrice = 64.80M , Quantity =6  , Discount =  0   },
                new Order_Details(){OrderID = 22, ProductID = 31, UnitPrice = 10.00M , Quantity =40 , Discount =  0   },
                new Order_Details(){OrderID = 22, ProductID = 72, UnitPrice = 27.80M , Quantity =24 , Discount =  0   },
                new Order_Details(){OrderID = 22, ProductID = 10, UnitPrice = 24.80M , Quantity =24 , Discount =  0.05f},
                new Order_Details(){OrderID = 23, ProductID = 83, UnitPrice = 120.00M , Quantity =24 , Discount =  0.05f},
            };

            foreach (var orderDetail in orderDetails)
            {
                context.Order_Details.Add(orderDetail);
            }
            context.SaveChanges();
        }
    }
}