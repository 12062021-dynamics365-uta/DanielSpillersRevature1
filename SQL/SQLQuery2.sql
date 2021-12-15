/****** Script for SelectTopNRows command from SSMS  ******/
SELECT CustomerId, FirstName, LastName, Country FROM Customer
WHERE Country != 'USA';

SELECT * FROM Customer
WHERE Country = 'Brazil';

SELECT * FROM Employee
WHERE Title LIKE '%Sales%Agent%';

SELECT DISTINCT	BillingCountry FROM Invoice;

SELECT COUNT(InvoiceDate) FROM Invoice;

SELECT SUM(Total) AS TotalAmount, COUNT(InvoiceId) AS 'Invoices in 2009' FROM InvoiceWHERE InvoiceDate BETWEEN '2009-01-01' AND '2010-01-01';

SELECT YEAR(InvoiceDate) AS Year, SUM(Total) AS TotalAmount, COUNT(InvoiceId) AS Invoices FROM InvoiceGROUP BY YEAR(InvoiceDate);SELECT COUNT(Quantity) As TotalItems FROM InvoiceLine WHERE InvoiceId = '37';SELECT COUNT(InvoiceId) AS TotalInvoices FROM InvoiceGROUP BY BillingCountry;SELECT BillingCountry, count(BillingCountry) as 'Number of Orders' FROM dbo.Invoice GROUP BY BillingCountry;SELECT BillingCountry, SUM(Total) FROM Invoice GROUP BY BillingCountryORDER BY SUM(Total) Desc;SELECT * FROM Track;SELECT TrackId, Name, AlbumId, Composer FROM TrackWHERE Composer BETWEEN 'A%' AND 'G%'AND AlbumId BETWEEN 85 AND 192  AND Name BETWEEN 'Bring%' AND 'Thinking%'Order By Name Asc;