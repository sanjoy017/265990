CREATE DATABASE CoffeShop

USE CoffeShop

CREATE TABLE Items(

ID INT IDENTITY(1,1),
Name VARCHAR(50),
Price FLOAT
)
DROP TABLE Items

INSERT INTO Items(Name,Price)
VALUES('BLACK',120)
INSERT INTO Items(Name,Price)
VALUES('HOT',100)

SELECT * FROM Items
DELETE FROM Item WHERE ID=1


UPDATE Items
SET Name='Regular',
Price =80
WHERE ID=2

SELECT Name,Price FROM Items WHERE Price>=100
