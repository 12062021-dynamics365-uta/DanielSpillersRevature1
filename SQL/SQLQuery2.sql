/****** Script for SelectTopNRows command from SSMS  ******/
SELECT CustomerId, FirstName, LastName, Country FROM Customer
WHERE Country != 'USA';

SELECT * FROM Customer
WHERE Country = 'Brazil';

SELECT * FROM Employee
WHERE Title LIKE '%Sales%Agent%';

SELECT DISTINCT	BillingCountry FROM Invoice;

SELECT COUNT(InvoiceDate) FROM Invoice;

SELECT SUM(Total) AS TotalAmount, COUNT(InvoiceId) AS 'Invoices in 2009' FROM Invoice

SELECT YEAR(InvoiceDate) AS Year, SUM(Total) AS TotalAmount, COUNT(InvoiceId) AS Invoices FROM Invoice