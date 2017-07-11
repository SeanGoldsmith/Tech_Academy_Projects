CREATE DATABASE db_sean_goldsmith;
GO

USE db_sean_goldsmith;



CREATE TABLE tbl_publisher (
	publisher_name VARCHAR(50) PRIMARY KEY NOT NULL,
	publisher_address VARCHAR(50) NOT NULL,
	publisher_phone VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_book (
	book_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	book_title VARCHAR(50),
	book_publisher VARCHAR(50) CONSTRAINT fk_publisher_name FOREIGN KEY REFERENCES tbl_publisher(publisher_name) ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE tbl_bookAuthors (
	book_id INT PRIMARY KEY NOT NULL CONSTRAINT fk_book_id FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	book_author VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_borrower (
	card_number INT PRIMARY KEY NOT NULL IDENTITY(1000,1),
	borrower_name VARCHAR(50) NOT NULL,
	borrower_address VARCHAR(50) NOT NULL,
	borrower_phone VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_libraryBranch (
	branch_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	branch_name VARCHAR(50) NOT NULL,
	branch_address VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_copies (
	book_id INT NOT NULL CONSTRAINT fk_book_id2 FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	branch_id INT NOT NULL CONSTRAINT fk_branch_id FOREIGN KEY REFERENCES tbl_libraryBranch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	copies_number INT NOT NULL
);

CREATE TABLE tbl_bookLoans (
	book_id INT NOT NULL CONSTRAINT fk_book_id3 FOREIGN KEY REFeRENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	branch_id INT NOT NULL CONSTRAINT fk_branch_id2 FOREIGN KEY REFERENCES tbl_libraryBranch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	card_number INT NOT NULL CONSTRAINT fk_card_number FOREIGN KEY REFERENCES tbl_borrower(card_number) ON UPDATE CASCADE ON DELETE CASCADE,
	date_out DATE NOT NULL,
	date_due DATE NOT NULL
);

INSERT INTO tbl_book (book_title)
	VALUES
	('arb'),
	('jarb'),
	('cats cradle')
;


INSERT INTO tbl_bookAuthors (book_id,book_author)
	VALUES
	(3,'Kurt Vonnegut')
;

INSERT INTO tbl_publisher (publisher_name,publisher_address,publisher_phone)
	VALUES
	('Holt, Rinehart and Winston','555 Broadway','555-555-1111')
;

UPDATE tbl_book
SET book_publisher = 'Holt, Rinehart and Winston' WHERE book_id = 3;

INSERT INTO tbl_book (book_title)
	VALUES
	('the lost tribe'),
	('house of leaves'),
	('slaughterhouse 5'),
	('along came a spider'),
	('cat and mouse'),
	('inferno'),
	('the iliad'),
	('grapes of wrath'),
	('a brief history of time'),
	('choke'),
	('death by black hole'),
	('a universe from nothing')
;

INSERT INTO tbl_book (book_title)
	VALUES
	('invisible monsters'),
	('breakfast of champions'),
	('mother night'),
	('galapagos'),
	('the familiar'),
	('only revolutions')

;

INSERT INTO tbl_book (book_title)
	VALUES
	('the fifty year sword'),
	('of mice and men'),
	('cannery row')
;

INSERT INTO tbl_bookAuthors (book_id,book_author)
	VALUES
	(5,'mark z danielewski'),
	(20,'mark z danielewski'),
	(21,'mark z danielewski'),
	(22,'mark z danielewski'),
	(7,'james patterson'),
	(8,'james patterson'),
	(9,'dante'),
	(10,'homer'),
	(11,'john steinbeck'),
	(23,'john steinbeck'),
	(24,'john steinbeck'),
	(19,'kurt vonnegut'),
	(18,'kurt vonnegut'),
	(17,'kurt vonnegut'),
	(16,'chuck palahniuk'),
	(15,'lawrence krauss'),
	(14,'neil degrasse tyson'),
	(13,'chuck palahniuk'),
	(12,'stephen hawking'),
	(6,'kurt vonnegut'),
	(4,'louise foley')
;


INSERT INTO tbl_book (book_title)
VALUES
('salems lot')



INSERT INTO tbl_bookAuthors (book_id,book_author)
VALUES
(25,'Stephen King');

INSERT INTO tbl_libraryBranch (branch_name,branch_address)
	VALUES
	('sharpstown','555 W 87th'),
	('central','248 N 24th'),
	('beaverton','750 farmington Rd.'),
	('Hillsboro','238 main st.')
;

INSERT INTO tbl_borrower (borrower_name,borrower_address,borrower_phone)
	VALUES
	('sean goldsmith','4067 sw greensboro','555-524-5212'),
	('pat goldsmith','243 n main','555-654-4545'),
	('mary skidmore','123 w 87th','555-123-1234'),
	('karen milarski','395 nw tillamook rd','555-965-4531'),
	('jon knoll','500 broad st.','555-876-5678'),
	('cosmo kramer','129 w 81st st. 5b','555-800-3455'),
	('jerry seinfeld','129 w 81st st. 5a','555-555-1233'),
	('jeffery lebowski','543 clearwater rd','444-555-3333');
;



INSERT INTO tbl_copies (book_id,branch_id,copies_number)
	VALUES
	(3,1,4),
	(3,2,2),
	(3,3,5),
	(3,4,2),
	(4,1,3),
	(4,2,2),
	(4,3,6),
	(4,4,4),
	(5,1,4),
	(5,2,2),
	(5,3,3),
	(5,4,3),
	(6,1,2),
	(6,2,2),
	(6,3,5),
	(6,4,3),
	(7,1,5),
	(7,2,2),
	(7,3,2),
	(7,4,2),
	(8,1,4),
	(8,2,3),
	(8,3,4),
	(8,4,4),
	(9,1,4),
	(9,2,3),
	(9,3,2),
	(9,4,5),
	(10,1,3),
	(10,2,2),
	(10,3,6),
	(10,4,3),
	(11,1,4),
	(11,2,2),
	(11,3,5),
	(11,4,2),
	(12,1,3),
	(12,2,2),
	(12,3,6),
	(12,4,4),
	(13,1,4),
	(13,2,2),
	(13,3,3),
	(13,4,3),
	(14,1,2),
	(14,2,2),
	(14,3,5),
	(14,4,3),
	(15,1,5),
	(15,2,2),
	(15,3,2),
	(15,4,2),
	(16,1,4),
	(16,2,3),
	(16,3,2),
	(16,4,5),
	(17,1,4),
	(17,2,2),
	(17,3,5),
	(17,4,2),
	(18,1,3),
	(18,2,2),
	(18,3,6),
	(18,4,4),
	(19,1,4),
	(19,2,3),
	(19,3,2),
	(19,4,5),
	(20,1,3),
	(20,2,2),
	(20,3,6),
	(20,4,3),
	(21,1,2),
	(21,2,2),
	(21,3,5),
	(21,4,3),
	(22,1,5),
	(22,2,2),
	(22,3,2),
	(22,4,2),
	(23,1,4),
	(23,2,2),
	(23,3,3),
	(23,4,3),
	(24,1,3),
	(24,2,2),
	(24,3,6),
	(24,4,3),
	(25,1,4),
	(25,2,2),
	(25,3,5),
	(25,4,2)
;

INSERT INTO tbl_publisher (publisher_name,publisher_address,publisher_phone)
	VALUES
	('Vandelay Publishing Company','543 s 32st, new york, new york','444-445-45555'),
	('little penguin publishing','23 state street, chicago, illinois','312-154-4545'),
	('big elephant publishing','1243 michigan ave, chicag, illinois','312-433-3532')
;

UPDATE tbl_book
SET book_publisher = 'Holt, Rinehart and Winston' WHERE book_id BETWEEN 23 AND 25
;

INSERT INTO tbl_bookLoans (book_id,branch_id,card_number,date_out,date_due)
	VALUES
	(7,1,1000,'2017-07-8','2017-07-24'),
	(9,1,1000,'2017-07-8','2017-07-24'),
	(21,1,1000,'2017-07-8','2017-07-24'),
	(24,1,1000,'2017-07-8','2017-07-24'),
	(25,1,1000,'2017-07-8','2017-07-24'),
	(10,2,1000,'2017-06-25','2017-07-4'),
	(11,2,1000,'2017-06-25','2017-07-4'),
	(12,2,1000,'2017-06-25','2017-07-4'),
	(14,2,1000,'2017-06-25','2017-07-4'),
	(15,2,1000,'2017-06-25','2017-07-4'),
	(16,2,1000,'2017-06-25','2017-07-4'),
	(17,2,1000,'2017-06-25','2017-07-4'),
	(18,2,1000,'2017-06-25','2017-07-4'),
	(19,2,1000,'2017-06-25','2017-07-4'),
	(21,2,1000,'2017-06-25','2017-07-4'),
	(22,2,1000,'2017-06-25','2017-07-4'),
	(23,2,1000,'2017-06-25','2017-07-4'),
	(4,2,1001,'2017-07-1','2017-07-13'),
	(13,2,1001,'2017-07-1','2017-07-13'),
	(11,2,1001,'2017-07-1','2017-07-13'),
	(15,3,1002,'2017-06-29','2017-07-5'),
	(17,3,1002,'2017-06-29','2017-07-5'),
	(18,3,1002,'2017-06-29','2017-07-5'),
	(4,3,1002,'2017-06-29','2017-07-5'),
	(22,3,1002,'2017-06-29','2017-07-5'),
	(12,1,1003,'2017-07-1','2017-07-20'),
	(12,4,1004,'2017-07-1','2017-07-20'),
	(12,3,1005,'2017-06-25','2017-07-05'),
	(13,3,1005,'2017-06-25','2017-07-05'),
	(15,3,1005,'2017-06-25','2017-07-05'),
	(7,3,1005,'2017-06-25','2017-07-05'),
	(8,3,1005,'2017-06-25','2017-07-05'),
	(16,3,1005,'2017-06-25','2017-07-05'),
	(17,3,1005,'2017-06-25','2017-07-05'),
	(18,3,1005,'2017-06-25','2017-07-05'),
	(19,3,1005,'2017-06-25','2017-07-05'),
	(21,3,1005,'2017-06-25','2017-07-05'),
	(22,3,1005,'2017-06-25','2017-07-05'),
	(24,3,1005,'2017-06-25','2017-07-05'),
	(24,3,1005,'2017-06-25','2017-07-05'),
	(3,4,1007,'2017-07-1','2017-07-05'),
	(4,4,1007,'2017-07-1','2017-07-05'),
	(6,4,1007,'2017-07-1','2017-07-05'),
	(7,4,1007,'2017-07-1','2017-07-05'),
	(8,4,1007,'2017-07-1','2017-07-05'),
	(9,4,1007,'2017-07-1','2017-07-05'),
	(10,4,1007,'2017-07-1','2017-07-05'),
	(13,4,1007,'2017-07-1','2017-07-05'),
	(15,4,1007,'2017-07-1','2017-07-05'),
	(17,4,1007,'2017-07-1','2017-07-05'),
	(24,4,1007,'2017-07-1','2017-07-05')
;

--QUERY 1--
USE db_sean_goldsmith;
GO

CREATE PROCEDURE dbo.usp_lostTribeCopiesSharptown
AS
	SELECT DISTINCT(tbl_copies.copies_number) AS 'NUMBER OF COPIES OF LOST TRIBE AT SHARPTOWN' FROM tbl_copies 
		INNER JOIN tbl_libraryBranch ON tbl_copies.branch_id = tbl_copies.branch_id
		WHERE tbl_copies.book_id = 4 AND tbl_copies.branch_id = 1;

GO
--//////--

--QUERY 2--
USE db_sean_goldsmith;
GO
CREATE PROCEDURE dbo.usp_lostTribeCopiesAllBranches
AS

	SELECT tbl_copies.copies_number AS 'NUMBER OF COPIES', tbl_libraryBranch.branch_name AS 'Branch'
		FROM tbl_copies
		INNER JOIN tbl_libraryBranch ON tbl_copies.branch_id = tbl_libraryBranch.branch_id
		WHERE tbl_copies.book_id = 4
GO
;
--/////--

--Query 3--
USE db_sean_goldsmith;
GO
CREATE PROCEDURE dbo.usp_borrowerNoBooksDue
AS
	SELECT tbl_borrower.borrower_name 
		FROM tbl_borrower
		LEFT JOIN tbl_bookLoans ON tbl_borrower.card_number = tbl_bookLoans.card_number
		GROUP BY tbl_borrower.borrower_name
		HAVING COUNT(tbl_bookLoans.card_number) = 0
GO
;
--///////--

--Query 4--
USE db_sean_goldsmith;
GO
CREATE PROCEDURE dbo.usp_booksDueTodaySharptown @Date nvarchar(20)
AS
	SELECT tbl_book.book_title,tbl_borrower.borrower_name,tbl_borrower.borrower_address 
		FROM tbl_bookLoans
		INNER JOIN tbl_borrower ON tbl_bookLoans.card_number = tbl_borrower.card_number
		INNER JOIN tbl_book ON tbl_bookLoans.book_id = tbl_book.book_id
		INNER JOIN tbl_libraryBranch ON tbl_libraryBranch.branch_id = tbl_bookLoans.branch_id
		WHERE tbl_bookLoans.branch_id = 1 AND tbl_bookLoans.date_due = @Date
GO
;

--/////--

--Query 5--
USE db_sean_goldsmith;
GO
CREATE PROCEDURE dbo.usp_booksLoanedOut
AS

	SELECT tbl_libraryBranch.branch_name,COUNT(tbl_bookLoans.branch_id) AS 'NUMBER OF LOANS'
		FROM tbl_libraryBranch
		INNER JOIN tbl_bookLoans ON tbl_libraryBranch.branch_id = tbl_bookLoans.branch_id
		GROUP BY tbl_libraryBranch.branch_name
	;
GO

--//////--

--Query 6--
USE db_sean_goldsmith;
GO
CREATE PROCEDURE dbo.usp_borrowersMoreThanFiveBooks
AS

	SELECT tbl_borrower.borrower_name,tbl_borrower.borrower_address,COUNT(tbl_bookLoans.card_number) AS 'Number of books borrowed'
		FROM tbl_borrower
		INNER JOIN tbl_bookLoans ON tbl_borrower.card_number = tbl_bookLoans.card_number
		GROUP BY tbl_borrower.borrower_name,tbl_borrower.borrower_address
		HAVING COUNT(tbl_bookLoans.card_number) >= 5
	;
GO


--Query 7--
USE db_sean_goldsmith;
GO
CREATE PROCEDURE dbo.usp_sephenKingTitelsCentral
AS

	SELECT tbl_book.book_title,tbl_copies.copies_number
		FROM tbl_book 
		INNER JOIN tbl_copies ON tbl_book.book_id = tbl_copies.book_id
		INNER JOIN tbl_bookAuthors ON tbl_book.book_id = tbl_bookAuthors.book_id
		WHERE tbl_copies.branch_id = 2 AND tbl_bookAuthors.book_author = 'stephen king'
	;
GO
--//////--