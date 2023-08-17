/*
** Copyright Microsoft, Inc. 1994 - 2000
** All Rights Reserved.
*/

DROP TABLE IF EXISTS "Employees";
DROP TABLE IF EXISTS "Customers";
DROP TABLE IF EXISTS "Categories";
DROP TABLE IF EXISTS "Products";
DROP TABLE IF EXISTS "Suppliers";
DROP TABLE IF EXISTS "Orders";
DROP TABLE IF EXISTS "Order Details";
DROP TABLE IF EXISTS "Shippers";

CREATE TABLE "Employees" (
	"EmployeeId" INTEGER PRIMARY KEY,
	"LastName" nvarchar (20) NOT NULL ,
	"FirstName" nvarchar (10) NOT NULL ,
	"Title" nvarchar (30) NULL ,
	"TitleOfCourtesy" nvarchar (25) NULL ,
	"BirthDate" "datetime" NULL ,
	"HireDate" "datetime" NULL ,
	"Address" nvarchar (60) NULL ,
	"City" nvarchar (15) NULL ,
	"Region" nvarchar (15) NULL ,
	"PostalCode" nvarchar (10) NULL ,
	"Country" nvarchar (15) NULL ,
	"HomePhone" nvarchar (24) NULL ,
	"Extension" nvarchar (4) NULL ,
	"Photo" "image" NULL ,
	"Notes" "ntext" NULL ,
	"ReportsTo" "int" NULL ,
	"PhotoPath" nvarchar (255) NULL 
);
CREATE INDEX "LastName" ON "Employees"("LastName");
CREATE INDEX "PostalCodeEmployees" ON "Employees"("PostalCode");

CREATE TABLE "Categories" (
	"CategoryId" INTEGER PRIMARY KEY,
	"CategoryName" nvarchar (15) NOT NULL ,
	"Description" "ntext" NULL ,
	"Picture" "image" NULL
);
CREATE INDEX "CategoryName" ON "Categories"("CategoryName");

CREATE TABLE "Customers" (
	"CustomerId" nchar (5) NOT NULL ,
	"CompanyName" nvarchar (40) NOT NULL ,
	"ContactName" nvarchar (30) NULL ,
	"ContactTitle" nvarchar (30) NULL ,
	"Address" nvarchar (60) NULL ,
	"City" nvarchar (15) NULL ,
	"Region" nvarchar (15) NULL ,
	"PostalCode" nvarchar (10) NULL ,
	"Country" nvarchar (15) NULL ,
	"Phone" nvarchar (24) NULL ,
	"Fax" nvarchar (24) NULL ,
	CONSTRAINT "PK_Customers" PRIMARY KEY  
	(
		"CustomerId"
	)
);
CREATE INDEX "City" ON "Customers"("City");
CREATE INDEX "CompanyNameCustomers" ON "Customers"("CompanyName");
CREATE INDEX "PostalCodeCustomers" ON "Customers"("PostalCode");
CREATE INDEX "Region" ON "Customers"("Region");

CREATE TABLE "Shippers" (
	"ShipperId" INTEGER PRIMARY KEY,
	"CompanyName" nvarchar (40) NOT NULL ,
	"Phone" nvarchar (24) NULL
);

CREATE TABLE "Suppliers" (
	"SupplierId" INTEGER PRIMARY KEY,
	"CompanyName" nvarchar (40) NOT NULL ,
	"ContactName" nvarchar (30) NULL ,
	"ContactTitle" nvarchar (30) NULL ,
	"Address" nvarchar (60) NULL ,
	"City" nvarchar (15) NULL ,
	"Region" nvarchar (15) NULL ,
	"PostalCode" nvarchar (10) NULL ,
	"Country" nvarchar (15) NULL ,
	"Phone" nvarchar (24) NULL ,
	"Fax" nvarchar (24) NULL ,
	"HomePage" "ntext" NULL
);
CREATE INDEX "CompanyNameSuppliers" ON "Suppliers"("CompanyName");
CREATE INDEX "PostalCodeSuppliers" ON "Suppliers"("PostalCode");

CREATE TABLE "Orders" (
	"OrderId" INTEGER PRIMARY KEY,
	"CustomerId" nchar (5) NULL ,
	"EmployeeId" "int" NULL ,
	"OrderDate" "datetime" NULL ,
	"RequiredDate" "datetime" NULL ,
	"ShippedDate" "datetime" NULL ,
	"ShipVia" "int" NULL ,
	"Freight" "money" NULL CONSTRAINT "DF_Orders_Freight" DEFAULT (0),
	"ShipName" nvarchar (40) NULL ,
	"ShipAddress" nvarchar (60) NULL ,
	"ShipCity" nvarchar (15) NULL ,
	"ShipRegion" nvarchar (15) NULL ,
	"ShipPostalCode" nvarchar (10) NULL ,
	"ShipCountry" nvarchar (15) NULL ,
	CONSTRAINT "FK_Orders_Customers" FOREIGN KEY 
	(
		"CustomerId"
	) REFERENCES "Customers" (
		"CustomerId"
	),
	CONSTRAINT "FK_Orders_Employees" FOREIGN KEY 
	(
		"EmployeeId"
	) REFERENCES "Employees" (
		"EmployeeId"
	),
	CONSTRAINT "FK_Orders_Shippers" FOREIGN KEY 
	(
		"ShipVia"
	) REFERENCES "Shippers" (
		"ShipperId"
	)
);
CREATE INDEX "CustomerId" ON "Orders"("CustomerId");
CREATE INDEX "CustomersOrders" ON "Orders"("CustomerId");
CREATE INDEX "EmployeeId" ON "Orders"("EmployeeId");
CREATE INDEX "EmployeesOrders" ON "Orders"("EmployeeId");
CREATE INDEX "OrderDate" ON "Orders"("OrderDate");
CREATE INDEX "ShippedDate" ON "Orders"("ShippedDate");
CREATE INDEX "ShippersOrders" ON "Orders"("ShipVia");
CREATE INDEX "ShipPostalCode" ON "Orders"("ShipPostalCode");

CREATE TABLE "Products" (
	"ProductId" INTEGER PRIMARY KEY,
	"ProductName" nvarchar (40) NOT NULL ,
	"SupplierId" "int" NULL ,
	"CategoryId" "int" NULL ,
	"QuantityPerUnit" nvarchar (20) NULL ,
	"UnitPrice" "money" NULL CONSTRAINT "DF_Products_UnitPrice" DEFAULT (0),
	"UnitsInStock" "smallint" NULL CONSTRAINT "DF_Products_UnitsInStock" DEFAULT (0),
	"UnitsOnOrder" "smallint" NULL CONSTRAINT "DF_Products_UnitsOnOrder" DEFAULT (0),
	"ReorderLevel" "smallint" NULL CONSTRAINT "DF_Products_ReorderLevel" DEFAULT (0),
	"Discontinued" "bit" NOT NULL CONSTRAINT "DF_Products_Discontinued" DEFAULT (0),
	CONSTRAINT "FK_Products_Categories" FOREIGN KEY 
	(
		"CategoryId"
	) REFERENCES "Categories" (
		"CategoryId"
	),
	CONSTRAINT "FK_Products_Suppliers" FOREIGN KEY 
	(
		"SupplierId"
	) REFERENCES "Suppliers" (
		"SupplierId"
	),
	CONSTRAINT "CK_Products_UnitPrice" CHECK (UnitPrice >= 0),
	CONSTRAINT "CK_ReorderLevel" CHECK (ReorderLevel >= 0),
	CONSTRAINT "CK_UnitsInStock" CHECK (UnitsInStock >= 0),
	CONSTRAINT "CK_UnitsOnOrder" CHECK (UnitsOnOrder >= 0)
);
CREATE INDEX "CategoriesProducts" ON "Products"("CategoryId");
CREATE INDEX "CategoryId" ON "Products"("CategoryId");
CREATE INDEX "ProductName" ON "Products"("ProductName");
CREATE INDEX "SupplierId" ON "Products"("SupplierId");
CREATE INDEX "SuppliersProducts" ON "Products"("SupplierId");

CREATE TABLE "Order Details" (
	"OrderId" "int" NOT NULL ,
	"ProductId" "int" NOT NULL ,
	"UnitPrice" "money" NOT NULL CONSTRAINT "DF_Order_Details_UnitPrice" DEFAULT (0),
	"Quantity" "smallint" NOT NULL CONSTRAINT "DF_Order_Details_Quantity" DEFAULT (1),
	"Discount" "real" NOT NULL CONSTRAINT "DF_Order_Details_Discount" DEFAULT (0),
	CONSTRAINT "PK_Order_Details" PRIMARY KEY  
	(
		"OrderId",
		"ProductId"
	),
	CONSTRAINT "FK_Order_Details_Orders" FOREIGN KEY 
	(
		"OrderId"
	) REFERENCES "Orders" (
		"OrderId"
	),
	CONSTRAINT "FK_Order_Details_Products" FOREIGN KEY 
	(
		"ProductId"
	) REFERENCES "Products" (
		"ProductId"
	),
	CONSTRAINT "CK_Discount" CHECK (Discount >= 0 and (Discount <= 1)),
	CONSTRAINT "CK_Quantity" CHECK (Quantity > 0),
	CONSTRAINT "CK_UnitPrice" CHECK (UnitPrice >= 0)
);
CREATE  INDEX "OrderId" ON "Order Details"("OrderId");
CREATE  INDEX "OrdersOrder_Details" ON "Order Details"("OrderId");
CREATE  INDEX "ProductId" ON "Order Details"("ProductId");
CREATE  INDEX "ProductsOrder_Details" ON "Order Details"("ProductId");

INSERT INTO "Categories"("CategoryId","CategoryName","Description","Picture") 
VALUES(1,'Beverages','Soft drinks, coffees, teas, beers, and ales',null),
(2,'Condiments','Sweet and savory sauces, relishes, spreads, and seasonings',null),
(3,'Confections','Desserts, candies, and sweet breads',null),
(4,'Dairy Products','Cheeses',null),
(5,'Grains/Cereals','Breads, crackers, pasta, and cereal',null),
(6,'Meat/Poultry','Prepared meats',null),
(7,'Produce','Dried fruit and bean curd',null),
(8,'Seafood','Seaweed and fish',null);

INSERT INTO "Customers" VALUES('ALFKI','Alfreds Futterkiste','Maria Anders','Sales Representative','Obere Str. 57','Berlin',NULL,'12209','Germany','030-0074321','030-0076545');
INSERT INTO "Customers" VALUES('ANATR','Ana Trujillo Emparedados y helados','Ana Trujillo','Owner','Avda. de la Constitución 2222','México D.F.',NULL,'05021','Mexico','(5) 555-4729','(5) 555-3745');
INSERT INTO "Customers" VALUES('ANTON','Antonio Moreno Taquería','Antonio Moreno','Owner','Mataderos  2312','México D.F.',NULL,'05023','Mexico','(5) 555-3932',NULL);
INSERT INTO "Customers" VALUES('AROUT','Around the Horn','Thomas Hardy','Sales Representative','120 Hanover Sq.','London',NULL,'WA1 1DP','UK','(171) 555-7788','(171) 555-6750');
INSERT INTO "Customers" VALUES('BERGS','Berglunds snabbköp','Christina Berglund','Order Administrator','Berguvsvägen  8','Luleå',NULL,'S-958 22','Sweden','0921-12 34 65','0921-12 34 67');
INSERT INTO "Customers" VALUES('BLAUS','Blauer See Delikatessen','Hanna Moos','Sales Representative','Forsterstr. 57','Mannheim',NULL,'68306','Germany','0621-08460','0621-08924');
INSERT INTO "Customers" VALUES('BLONP','Blondesddsl père et fils','Frédérique Citeaux','Marketing Manager','24, place Kléber','Strasbourg',NULL,'67000','France','88.60.15.31','88.60.15.32');
INSERT INTO "Customers" VALUES('BOLID','Bólido Comidas preparadas','Martín Sommer','Owner','C/ Araquil, 67','Madrid',NULL,'28023','Spain','(91) 555 22 82','(91) 555 91 99');
INSERT INTO "Customers" VALUES('BONAP','Bon app''','Laurence Lebihan','Owner','12, rue des Bouchers','Marseille',NULL,'13008','France','91.24.45.40','91.24.45.41');
INSERT INTO "Customers" VALUES('BOTTM','Bottom-Dollar Markets','Elizabeth Lincoln','Accounting Manager','23 Tsawassen Blvd.','Tsawassen','BC','T2F 8M4','Canada','(604) 555-4729','(604) 555-3745');
INSERT INTO "Customers" VALUES('BSBEV','B''s Beverages','Victoria Ashworth','Sales Representative','Fauntleroy Circus','London',NULL,'EC2 5NT','UK','(171) 555-1212',NULL);
INSERT INTO "Customers" VALUES('CACTU','Cactus Comidas para llevar','Patricio Simpson','Sales Agent','Cerrito 333','Buenos Aires',NULL,'1010','Argentina','(1) 135-5555','(1) 135-4892');
INSERT INTO "Customers" VALUES('CENTC','Centro comercial Moctezuma','Francisco Chang','Marketing Manager','Sierras de Granada 9993','México D.F.',NULL,'05022','Mexico','(5) 555-3392','(5) 555-7293');
INSERT INTO "Customers" VALUES('CHOPS','Chop-suey Chinese','Yang Wang','Owner','Hauptstr. 29','Bern',NULL,'3012','Switzerland','0452-076545',NULL);
INSERT INTO "Customers" VALUES('COMMI','Comércio Mineiro','Pedro Afonso','Sales Associate','Av. dos Lusíadas, 23','Sao Paulo','SP','05432-043','Brazil','(11) 555-7647',NULL);
INSERT INTO "Customers" VALUES('CONSH','Consolidated Holdings','Elizabeth Brown','Sales Representative','Berkeley Gardens 12  Brewery','London',NULL,'WX1 6LT','UK','(171) 555-2282','(171) 555-9199');
INSERT INTO "Customers" VALUES('DRACD','Drachenblut Delikatessen','Sven Ottlieb','Order Administrator','Walserweg 21','Aachen',NULL,'52066','Germany','0241-039123','0241-059428');
INSERT INTO "Customers" VALUES('DUMON','Du monde entier','Janine Labrune','Owner','67, rue des Cinquante Otages','Nantes',NULL,'44000','France','40.67.88.88','40.67.89.89');
INSERT INTO "Customers" VALUES('EASTC','Eastern Connection','Ann Devon','Sales Agent','35 King George','London',NULL,'WX3 6FW','UK','(171) 555-0297','(171) 555-3373');
INSERT INTO "Customers" VALUES('ERNSH','Ernst Handel','Roland Mendel','Sales Manager','Kirchgasse 6','Graz',NULL,'8010','Austria','7675-3425','7675-3426');
INSERT INTO "Customers" VALUES('FAMIA','Familia Arquibaldo','Aria Cruz','Marketing Assistant','Rua Orós, 92','Sao Paulo','SP','05442-030','Brazil','(11) 555-9857',NULL);
INSERT INTO "Customers" VALUES('FISSA','FISSA Fabrica Inter. Salchichas S.A.','Diego Roel','Accounting Manager','C/ Moralzarzal, 86','Madrid',NULL,'28034','Spain','(91) 555 94 44','(91) 555 55 93');
INSERT INTO "Customers" VALUES('FOLIG','Folies gourmandes','Martine Rancé','Assistant Sales Agent','184, chaussée de Tournai','Lille',NULL,'59000','France','20.16.10.16','20.16.10.17');
INSERT INTO "Customers" VALUES('FOLKO','Folk och fä HB','Maria Larsson','Owner','Åkergatan 24','Bräcke',NULL,'S-844 67','Sweden','0695-34 67 21',NULL);
INSERT INTO "Customers" VALUES('FRANK','Frankenversand','Peter Franken','Marketing Manager','Berliner Platz 43','München',NULL,'80805','Germany','089-0877310','089-0877451');
INSERT INTO "Customers" VALUES('FRANR','France restauration','Carine Schmitt','Marketing Manager','54, rue Royale','Nantes',NULL,'44000','France','40.32.21.21','40.32.21.20');
INSERT INTO "Customers" VALUES('FRANS','Franchi S.p.A.','Paolo Accorti','Sales Representative','Via Monte Bianco 34','Torino',NULL,'10100','Italy','011-4988260','011-4988261');
INSERT INTO "Customers" VALUES('FURIB','Furia Bacalhau e Frutos do Mar','Lino Rodriguez','Sales Manager','Jardim das rosas n. 32','Lisboa',NULL,'1675','Portugal','(1) 354-2534','(1) 354-2535');
INSERT INTO "Customers" VALUES('GALED','Galería del gastrónomo','Eduardo Saavedra','Marketing Manager','Rambla de Cataluña, 23','Barcelona',NULL,'08022','Spain','(93) 203 4560','(93) 203 4561');
INSERT INTO "Customers" VALUES('GODOS','Godos Cocina Típica','José Pedro Freyre','Sales Manager','C/ Romero, 33','Sevilla',NULL,'41101','Spain','(95) 555 82 82',NULL);
INSERT INTO "Customers" VALUES('GOURL','Gourmet Lanchonetes','André Fonseca','Sales Associate','Av. Brasil, 442','Campinas','SP','04876-786','Brazil','(11) 555-9482',NULL);
INSERT INTO "Customers" VALUES('GREAL','Great Lakes Food Market','Howard Snyder','Marketing Manager','2732 Baker Blvd.','Euge...