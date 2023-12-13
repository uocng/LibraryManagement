create database onlinelibrary 
use onlinelibrary

create table account (
	accountID char(10) primary key,
	UserName nvarchar(30)not null,
	UserPassword nvarchar(15)not null,
	UserRole varchar(30)not null
)

create table Users (
	UsersID char(10) NOT NULL,
    NameUser nvarchar(30) NOT NULL,
    Email nvarchar(30),
	UserPassword nvarchar(15),
	UserRole varchar(30),
    PRIMARY KEY (UsersID),
)

create table LibraryEvents(
	EventID char(10),
	EventName nvarchar(30)not null,
	StartTime date,
	EndTime date,
	PRIMARY KEY (EventID),
)

create table Books(
	BookID char(10),
	BookName nvarchar(30),
	Author nvarchar(30),
	BookDescription varchar(200),
	AvailableQuantity int,
	EventID char(10),
	PRIMARY KEY (BookID),
    CONSTRAINT FK_LibraryEventsBooks FOREIGN KEY (EventID)
    REFERENCES LibraryEvents(EventID)
)

create table BorrowedBooks (
	BorrowID char (10),
	UsersID char(10),
	BookID char(10),
	BorrowedData date,
	ReturnData date,
	PRIMARY KEY (BorrowID),
    CONSTRAINT FK_BooksBorrowedBooks FOREIGN KEY (BookID)
    REFERENCES Books(BookID),
    CONSTRAINT FK_UsersBorrowedBooks FOREIGN KEY (UsersID)
    REFERENCES Users(UsersID)
)

create table ReadingLists(
	ListID char(10),
	UsersID char(10),
	BookID char(10),
	PRIMARY KEY (ListID),
    CONSTRAINT FK_UsersReadingLists FOREIGN KEY (UsersID)
    REFERENCES Users(UsersID),
    CONSTRAINT FK_BooksReadingLists FOREIGN KEY (BookID)
    REFERENCES Books(BookID)
)

create table BookReviews(
	ListID char(10),
	UsersID char(10),
	BookID char(10),
	Rating char(10),
	Comments nvarchar(200),
	PRIMARY KEY (ListID),
    CONSTRAINT FK_UsersBookReviews FOREIGN KEY (UsersID)
    REFERENCES Users(UsersID),
    CONSTRAINT FK_BooksBookReviews FOREIGN KEY (BookID)
    REFERENCES Books(BookID)
)


INSERT INTO Users (UsersID, NameUser, Email, UserPassword, UserRole)
VALUES 
('U001', 'John Doe', 'john.doe@example.com', 'password123', 'Admin'),
('U002', 'Jane Smith', 'jane.smith@example.com', 'pass456', 'User'),
('U003', 'Bob Johnson', 'bob.johnson@example.com', 'securePass', 'User'),
('U004', 'Alice Brown', 'alice.brown@example.com', '1234pass', 'Admin'),
('U005', 'Charlie Davis', 'charlie.davis@example.com', 'pass789', 'User');

INSERT INTO LibraryEvents (EventID, EventName, StartTime, EndTime)
VALUES 
('E001', 'Book Launch', '2023-11-01', '2023-11-10'),
('E002', 'Author Talk', '2023-12-05', '2023-12-10'),
('E003', 'Reading Marathon', '2023-11-15', '2023-11-20'),
('E004', 'Literary Workshop', '2023-12-20', '2023-12-25'),
('E005', 'Book Fair', '2023-11-25', '2023-11-30');

INSERT INTO Books (BookID, BookName, Author, BookDescription, AvailableQuantity, EventID)
VALUES 
('B001', 'The Great Gatsby', 'F. Scott Fitzgerald', 'Classic American novel', 20, 'E001'),
('B002', 'To Kill a Mockingbird', 'Harper Lee', 'Southern Gothic novel', 15, 'E001'),
('B003', '1984', 'George Orwell', 'Dystopian fiction', 25, 'E002'),
('B004', 'Pride and Prejudice', 'Jane Austen', 'Romantic novel', 18, 'E003'),
('B005', 'The Catcher in the Rye', 'J.D. Salinger', 'Coming-of-age novel', 22, 'E003');

INSERT INTO BorrowedBooks (BorrowID, UsersID, BookID, BorrowedData, ReturnData)
VALUES 
('BR001', 'U001', 'B001', '2023-11-02', '2023-11-09'),
('BR002', 'U002', 'B002', '2023-11-03', '2023-11-10'),
('BR003', 'U003', 'B003', '2023-11-16', '2023-11-23'),
('BR004', 'U004', 'B004', '2023-12-21', '2023-12-28'),
('BR005', 'U005', 'B005', '2023-11-26', '2023-12-03');


INSERT INTO ReadingLists (ListID, UsersID, BookID)
VALUES 
('L001', 'U001', 'B001'),
('L002', 'U002', 'B002'),
('L003', 'U003', 'B003'),
('L004', 'U004', 'B004'),
('L005', 'U005', 'B005');


INSERT INTO BookReviews (ListID, UsersID, BookID, Rating, Comments)
VALUES 
('L001', 'U001', 'B001', '5', 'Great book!'),
('L002', 'U002', 'B002', '4', 'Enjoyable read'),
('L003', 'U003', 'B003', '4', 'Thought-provoking'),
('L004', 'U004', 'B004', '5', 'Classic romance'),
('L005', 'U005', 'B005', '3', 'Not my favorite');

INSERT INTO account (accountID, UserName, UserPassword, UserRole)
VALUES 
('1','admin','admin','admin'),
('2','user','user','user');



Select * from account where UserName = UserName and UserPassword = UserPassword

DELETE Books WHERE BookID = @BookID