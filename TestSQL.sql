SELECT Products.Название, Categories.Название as Категория FROM Products
left JOIN Categories ON Products.Категория = Categories.id