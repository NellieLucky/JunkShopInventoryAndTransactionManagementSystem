CREATE TABLE Employees (
    empId INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50),
    empName NVARCHAR(50) NOT NULL,
    empPosition INT CHECK (empPosition BETWEEN 0 AND 9),
    empPassword NVARCHAR(50) NOT NULL,
    empEmail NVARCHAR(50)
);

INSERT INTO Employees (
username, empName, empPosition, empPassword, empEmail
)
VALUES ('TEST ACCOUNT', 'usernameTest', 0, 'passwordTest', 'test@gmail.com');

SELECT * FROM Employees