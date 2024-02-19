﻿SELECT Customers.CustomerName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID
WHERE Orders.OrderID = 10310;

UNION

SELECT Suppliers.Address
FROM Suppliers
WHERE Suppliers.SupplierID = (
    SELECT Products.SupplierID
    FROM Products
    WHERE Products.ProductID = 40
);
