запрос для выбора всех пар «Имя продукта – Имя категории».

```SQL
SELECT Products.ProductName, Categories.CategoryName FROM Products LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID
```
