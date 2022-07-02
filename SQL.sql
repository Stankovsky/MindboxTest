/* Перед созданием требуемого запроса создадим запросы на создание и заполнение
 * таблиц Products, Categories и ProductCategories
 */

CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"ProductName" TEXT
);

INSERT INTO Products
VALUES
	(1, 'Milk'),
	(2, 'Chocolate'),
	(3, 'Juice'),
	(4, 'Cheese'),
	(5, 'Bread');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"CategoryName" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Dairy'),
	(2, 'Drinks'),
	(3, 'Confectionery');

CREATE TABLE ProductCategories (
    ProductId int NOT NULL ,
    CategoryId int NOT NULL,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
	FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(2, 3),
	(3, 2),
	(4, 1);


/* Теперь выполним запрос на вывод всех пар Продукт-Категория
 * продукт без категории также выводится
 */

SELECT P."ProductName", C."CategoryName"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;