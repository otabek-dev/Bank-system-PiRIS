DROP TABLE deposit;

CREATE TABLE deposit(
	ID int primary key IDENTITY(1,1),
	TypeDeposit VARCHAR(50) not null,
	Deposit money NOT NULL,
	Procent int NOT NULL,
	Currency varchar(5) NOT NULL,
	CreatedDate date NOT NULL,
	EndDate date NOT NULL,
	MonthlyIncome money NOT NULL,
	ContractId varchar(13) UNIQUE NOT NULL,
	userID int NOT NULL,
	FOREIGN KEY (userID) references Users(Id)
);

SELECT Users.FirstName , Users.LastName , deposit.TypeDeposit, deposit.Deposit , deposit.CreatedDate FROM Users INNER JOIN deposit ON Users.Id = deposit.userID;

ALTER TABLE deposit ALTER COLUMN CreatedDate date;

ALTER TABLE deposit ADD Currency varchar(5), test varchar(12);

alter table deposit drop column test;

alter table deposit add MonthlyIncome money, Procent int, ContractId varchar(13) UNIQUE, EndDate date;

INSERT INTO deposit(TypeDeposit, Deposit,Procent,Currency,CreatedDate,EndDate,MonthlyIncome,ContractId,userID) 
values (N'Срочный', 100, 12, 'usd', '2023-02-06', '2024-02-06', 8, '123123',25);

ALTER TABLE deposit ALTER COLUMN TypeDeposit NVARCHAR(50);

SELECT Users.FirstName, 
	Users.LastName,  
	deposit.*
FROM Users Right Outer Join deposit 
ON Users.Id = deposit.userID;


ALTER TABLE deposit ALTER COLUMN MonthlyIncome varchar(50);

SELECT * FROM deposit