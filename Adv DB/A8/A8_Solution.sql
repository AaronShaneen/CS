--TRAMS Trigger Creation Script 
--
--Drop and Recreate Database
USE Master

IF EXISTS (SELECT * FROM sysdatabases WHERE name='Shaneen_TRAMS')
DROP DATABASE Shaneen_TRAMS

GO   

CREATE DATABASE Shaneen_TRAMS

ON PRIMARY

(
NAME = 'Shaneen_TRAMS',
FILENAME = 'C:\Stage\Shaneen_TRAMS.mdf',
SIZE = 4MB,
MAXSIZE = 6MB,
FILEGROWTH = 10% 
)

LOG ON

(
NAME = 'Shaneen_TRAMS_Log',
FILENAME = 'C:\Stage\Shaneen_TRAMS.ldf',
SIZE = 1MB,
MAXSIZE= 1500KB,
FILEGROWTH = 150KB
) 

GO

-- With the Shaneen_TRAMS database now created, switch to it and begin creating the individual 
-- tables for the database

USE Shaneen_TRAMS

CREATE TABLE PERSON
(
PersonID					int				NOT NULL		IDENTITY(1,1),
PersonFirst     			nvarchar(50)	NOT NULL,
PersonLast					nvarchar(50)	NOT NULL,
PersonAddress	  			varchar(200)	NOT NULL,
PersonCity					varchar(50)		NOT NULL,
PersonState					char(2)			NULL,
PersonPostalCode			varchar(10)		NOT NULL,
PersonCountry				varchar(20)		NOT NULL,
PersonPhone					varchar(20)		NOT NULL,
PersonEmail					varchar(200)	NOT NULL
)

CREATE TABLE UNITTYPE
(
UnitTypeID					tinyint			NOT NULL		IDENTITY(1,1),
UnitTypeDescription			varchar(20)		NOT NULL
)

CREATE TABLE AMENITY
(
AmenityID					smallint		NOT NULL		IDENTITY(1,1),
AmenityDescription			varchar(50)		NOT NULL
)

CREATE TABLE TRANSCATEGORY
(
TransCategoryID				smallint		NOT NULL		IDENTITY(1,1),
TransCategoryDescription	varchar(50)		NOT NULL,
TransTaxType				char(1)			NULL
)

CREATE TABLE TAXLOCATION
(
TaxLocationID				smallint		NOT NULL		IDENTITY(1,1),
TaxCounty					varchar(50)		NOT NULL,
TaxState					char(2)			NOT NULL
)

CREATE TABLE RESERVATION
(
ReservationID				int				NOT NULL		IDENTITY(1,1),
ResDate						smalldatetime	NOT NULL,
ResStatus					char(1)			NOT NULL,
ResCheckInDate				date			NOT NULL,
ResNights					tinyint			NOT NULL,
ResQuotedRate				smallmoney		NOT NULL,
ResDepositPaid				smallmoney		NOT NULL,
ResCCAuth					varchar(25)		NOT NULL,
UnitRateID					smallint		NOT NULL,
PersonID					int				NOT NULL
)

CREATE TABLE FOLIO
(
FolioID						int				NOT NULL		IDENTITY(1,1),
FolioStatus					char(1)			NOT NULL,
FolioRate					smallmoney		NOT NULL,
FolioCheckInDate			smalldatetime	NOT NULL,
FolioCheckOutDate			smalldatetime	NULL,
UnitID						smallint		NOT NULL,
ReservationID				int				NOT NULL
)

CREATE TABLE FOLIOTRANSACTION
(
TransID						bigint			NOT NULL		IDENTITY(1,1),
TransDate					datetime		NOT NULL,
TransAmount					smallmoney		NOT NULL,
TransDescription			varchar(50)		NOT NULL,
TransCategoryID				smallint		NOT NULL,
FolioID						int				NOT NULL
)

CREATE TABLE UNITRATE
(
UnitRateID					smallint		NOT NULL		IDENTITY(1,1),
UnitRate					smallmoney		NOT NULL,
UnitRateBeginDate			date			NOT NULL,
UnitRateEndDate				date			NOT NULL,
UnitRateDescription			varchar(50)		NULL,
UnitRateActive				bit				NOT NULL,
PropertyID					smallint		NOT NULL,
UnitTypeID					tinyint			NOT NULL
)

CREATE TABLE PROPERTY
(
PropertyID					smallint		NOT NULL,
PropertyName				varchar(50)		NOT NULL,
PropertyAddress				varchar(200)	NOT NULL,
PropertyCity				varchar(50)		NOT NULL,
PropertyState				char(2)			NULL,
PropertyPostalCode			varchar(10)		NOT NULL,
PropertyCountry				varchar(20)		NOT NULL,
PropertyPhone				varchar(20)		NOT NULL,
PropertyMgmtFee				decimal(4,2)	NOT NULL,
PropertyWebAddress			varchar(100)	NULL,
TaxLocationID				smallint		NULL
)

CREATE TABLE PROPERTYAMENITY
(
AmenityID					smallint		NOT NULL,
PropertyID					smallint		NOT NULL
)

CREATE TABLE UNITOWNER
(
UnitID						smallint		NOT NULL,
PersonID					int				NOT NULL,
OwnerStartDate				date			NOT NULL,
OwnerEndDate				date			NULL
)

CREATE TABLE UNIT
(
UnitID						smallint		NOT NULL,
UnitNumber					varchar(5)		NOT NULL,
PropertyID					smallint		NULL,
UnitTypeID					tinyint			NOT NULL
)

CREATE TABLE UNITAMENITY
(
AmenityID					smallint		NOT NULL,
UnitID						smallint		NOT NULL
)

CREATE TABLE TAXRATE
(
TaxID						int				NOT NULL		IDENTITY(1,1),
TaxRate						decimal(5,3)	NOT NULL,
TaxType						char(1)			NOT NULL,
TaxDescription				varchar(50)		NOT NULL,
TaxStartDate				date			NOT NULL,
TaxEndDate					date			NULL,
TaxLocationID				smallint		NOT NULL
)

-- Ensure that the script to create tables has finished
-- before altering tables and adding in constraints
GO

-- Alter each of the tables to add Primary keys

ALTER TABLE PERSON
	ADD CONSTRAINT PK_Person_ID
	PRIMARY KEY (PersonID)

ALTER TABLE UNITTYPE
	ADD CONSTRAINT PK_Unit_Type_ID
	PRIMARY KEY (UnitTypeID)

ALTER TABLE AMENITY
	ADD CONSTRAINT PK_Amenity_ID
	PRIMARY KEY (AmenityID)

ALTER TABLE TRANSCATEGORY
	ADD CONSTRAINT PK_Trans_Category_ID
	PRIMARY KEY (TransCategoryID)

ALTER TABLE TAXLOCATION
	ADD CONSTRAINT PK_Tax_Location_ID
	PRIMARY KEY (TaxLocationID)

ALTER TABLE RESERVATION
	ADD CONSTRAINT PK_Reservation_ID
	PRIMARY KEY (ReservationID)

ALTER TABLE FOLIO
	ADD CONSTRAINT PK_Folio_ID
	PRIMARY KEY (FolioID)

ALTER TABLE FOLIOTRANSACTION
	ADD CONSTRAINT PK_Trans_ID
	PRIMARY KEY (TransID)

ALTER TABLE UNITRATE
	ADD CONSTRAINT PK_Unit_Rate_ID
	PRIMARY KEY (UnitRateID)

ALTER TABLE PROPERTY
	ADD CONSTRAINT PK_Property_ID
	PRIMARY KEY (PropertyID)

ALTER TABLE PROPERTYAMENITY
	ADD CONSTRAINT PK_Amenity_ID_Property_ID
	PRIMARY KEY (AmenityID, PropertyID)

ALTER TABLE UNITOWNER
	ADD CONSTRAINT PK_Unit_ID_Person_ID
	PRIMARY KEY (UnitID, PersonID)

ALTER TABLE UNIT
	ADD CONSTRAINT PK_Unit_ID
	PRIMARY KEY (UnitID)

ALTER TABLE UNITAMENITY
	ADD CONSTRAINT PK_Amenity_ID_Unit_ID
	PRIMARY KEY (AmenityID, UnitID)

ALTER TABLE TAXRATE
	ADD CONSTRAINT PK_Tax_ID
	PRIMARY KEY (TaxID)

-- Ensure PKs have been created before moving on to FKs
GO

-- Alter tables to set up foreign keys

ALTER TABLE RESERVATION
	ADD
	
	CONSTRAINT FK_UnitRateHasReservation
	FOREIGN KEY (UnitRateID) REFERENCES UNITRATE (UnitRateID)
	ON UPDATE CASCADE,

	CONSTRAINT FK_PersonMakesReservation
	FOREIGN KEY (PersonID) REFERENCES PERSON (PersonID)
	ON UPDATE CASCADE
	ON DELETE CASCADE
	
ALTER TABLE FOLIO
	ADD	CONSTRAINT FK_ReservationGeneratesFolio
	FOREIGN KEY (ReservationID) REFERENCES RESERVATION (ReservationID)
	ON UPDATE CASCADE
	ON DELETE CASCADE

ALTER TABLE FOLIOTRANSACTION
	ADD
	
	CONSTRAINT FK_FolioContainsFolioTransaction
	FOREIGN KEY (FolioID) REFERENCES FOLIO (FolioID)
	ON UPDATE CASCADE
	ON DELETE CASCADE,

	CONSTRAINT FK_TransCategoryHasFolioTransaction
	FOREIGN KEY (TransCategoryID) REFERENCES TRANSCATEGORY (TransCategoryID)

ALTER TABLE UNITRATE
	ADD
	
	CONSTRAINT FK_PropertyHasUnitRate
	FOREIGN KEY (PropertyID) REFERENCES PROPERTY (PropertyID)
	ON UPDATE CASCADE
	ON DELETE CASCADE,

	CONSTRAINT FK_UnitTypeHasUnitRate
	FOREIGN KEY (UnitTypeID) REFERENCES UNITTYPE (UnitTypeID)
	ON UPDATE CASCADE


ALTER TABLE PROPERTY
	ADD CONSTRAINT FK_PropertyIsLocatedInTaxLocation
	FOREIGN KEY (TaxLocationID) REFERENCES TAXLOCATION (TaxLocationID)
	ON UPDATE CASCADE
	ON DELETE CASCADE

ALTER TABLE PROPERTYAMENITY
	ADD
	
	CONSTRAINT FK_PropertyAmenityHasAmenity
	FOREIGN KEY (AmenityID) REFERENCES AMENITY (AmenityID)
	ON UPDATE CASCADE
	ON DELETE CASCADE,

	CONSTRAINT FK_PropertyHasPropertyAmenity
	FOREIGN KEY (PropertyID) REFERENCES PROPERTY (PropertyID)
	ON UPDATE CASCADE
	ON DELETE CASCADE

ALTER TABLE UNITOWNER
	ADD

	CONSTRAINT FK_UnitIsOwnedByUnitOwner
	FOREIGN KEY (UnitID) REFERENCES UNIT (UnitID)
	ON UPDATE CASCADE
	ON DELETE CASCADE,

	CONSTRAINT FK_PersonIsUnitOwner
	FOREIGN KEY (PersonID) REFERENCES PERSON(PersonID)
	ON UPDATE CASCADE
	ON DELETE CASCADE

ALTER TABLE UNIT
	ADD	CONSTRAINT FK_UnitHasUnitType
	FOREIGN KEY (UnitTypeID) REFERENCES UNITTYPE (UnitTypeID)
	ON UPDATE CASCADE
	ON DELETE CASCADE

ALTER TABLE UNITAMENITY
	ADD

	CONSTRAINT FK_UnitAmenityHasAmenity
	FOREIGN KEY (AmenityID) REFERENCES AMENITY (AmenityID)
	ON UPDATE CASCADE
	ON DELETE CASCADE,

	CONSTRAINT FK_UnitHasUnitAmenity
	FOREIGN KEY (UnitID) REFERENCES UNIT (UnitID)
	ON UPDATE CASCADE
	ON DELETE CASCADE

ALTER TABLE TAXRATE
	ADD	CONSTRAINT FK_TaxLocationHasTaxRate
	FOREIGN KEY (TaxLocationID) REFERENCES TAXLOCATION (TaxLocationID)
	ON UPDATE CASCADE
	ON DELETE CASCADE

-- ensure that foreign keys are set up, then move on to check constraints
GO

-- ensures that a reservation status is restricted to A, C, or X
ALTER TABLE RESERVATION
	ADD	CONSTRAINT CK_ResStatus
	CHECK (ResStatus IN ('A', 'C', 'X'))
	
-- ensures that a folio status is restricted to B, C, or X
ALTER TABLE FOLIO
	ADD	CONSTRAINT CK_FolioStatus
	CHECK (FolioStatus IN ('B', 'C', 'X'))

--ensures that a transaction tax type is restricted to N, L, G, or F
ALTER TABLE TRANSCATEGORY
	ADD	CONSTRAINT CK_TransTaxType
	CHECK (TransTaxType IN ('N', 'L', 'G', 'F'))

--ensures that a tax type is restricted to L, G, or F
ALTER TABLE TAXRATE
	ADD	CONSTRAINT CK_TaxType
	CHECK (TaxType IN ('L', 'G', 'F'))

GO

--now bulk insert
BULK INSERT AMENITY FROM 'C:\Stage\Amenity.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT FOLIO FROM 'C:\Stage\Folio.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT FOLIOTRANSACTION FROM 'C:\Stage\FolioTransaction.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT PERSON FROM 'C:\Stage\Person.txt' WITH (FIELDTERMINATOR ='|', DATAFILETYPE = 'char')
BULK INSERT PROPERTY FROM 'C:\Stage\Property.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT PROPERTYAMENITY FROM 'C:\Stage\PropertyAmenity.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT RESERVATION FROM 'C:\Stage\Reservation.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT TAXLOCATION FROM 'C:\Stage\TaxLocation.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT TAXRATE FROM 'C:\Stage\TaxRate.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT TRANSCATEGORY FROM 'C:\Stage\TransCategory.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT UNIT FROM 'C:\Stage\Unit.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT UNITAMENITY FROM 'C:\Stage\UnitAmenity.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT UNITOWNER FROM 'C:\Stage\UnitOwner.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT UNITRATE FROM 'C:\Stage\UnitRate.txt' WITH (FIELDTERMINATOR ='|')
BULK INSERT UNITTYPE FROM 'C:\Stage\UnitType.txt' WITH (FIELDTERMINATOR ='|')

--TRAMS Trigger Creation Script 

USE Shaneen_TRAMS


GO

-- Start script by RE-CREATING some scripts from past assignments.

-- stored procedure sp_InsertPerson which calls sp_InsertReservation (from HW6)
-- Check to see if sp_InsertReservation exists.
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_NAME = 'sp_InsertReservation')
	DROP PROCEDURE sp_InsertReservation;
GO

-- Check to see if sp_InsertPerson exists.
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_NAME = 'sp_InsertPerson')
	DROP PROCEDURE sp_InsertPerson;
GO

-- Create sp_InsertReservation.
CREATE PROCEDURE sp_InsertReservation
	  @ResDate		smalldatetime
	, @ResStatus	 char(1)
	, @ResCheckInDate	date
	, @ResNights		tinyint
	, @ResQuotedRate	smallmoney
	, @ResDepositPaid	smallmoney
	, @ResCCAuth		varchar(25)
	, @UnitRateID		smallint
	, @PersonID			int
AS
BEGIN
	INSERT INTO Reservation (ResDate, ResStatus, ResCheckInDate, ResNights, ResQuotedRate, ResDepositPaid, ResCCAuth, UnitRateID, PersonID)
	VALUES (
	  @ResDate
	, @ResStatus
	, @ResCheckInDate
	, @ResNights
	, @ResQuotedRate
	, @ResDepositPaid
	, @ResCCAuth
	, @UnitRateID
	, @PersonID)
END
GO

-- Create sp_InsertPerson.
CREATE PROCEDURE sp_InsertPerson
	  @PersonFirst		nvarchar(50)
	, @PersonLast		nvarchar(50)
	, @PersonAddress	varchar(200)
	, @PersonCity		varchar(50)
	, @PersonState		char(2) = NULL
	, @PersonPostalCode	varchar(10)
	, @PersonCountry	varchar(20)
	, @PersonPhone		varchar(20)
	, @PersonEmail		varchar(200)
	, @PersonID			int OUTPUT
	, @NewResDate		smalldatetime
	, @NewCheckInDate	date
	, @NewResNights		tinyint
	, @NewQuotedRate	smallmoney
	, @NewDepositPaid	smallmoney
	, @NewCCAuth		varchar(25)
	, @NewUnitRateID	smallint
AS
BEGIN
	INSERT INTO Person (PersonFirst, PersonLast, PersonAddress, PersonCity, PersonState, PersonPostalCode, PersonCountry, PersonPhone, PersonEmail)
	VALUES (
	  @PersonFirst
	, @PersonLast
	, @PersonAddress
	, @PersonCity
	, @PersonState
	, @PersonPostalCode
	, @PersonCountry
	, @PersonPhone
	, @PersonEmail)

	SELECT @PersonID = @@IDENTITY -- Output

	EXEC sp_InsertReservation
		  @ResDate			= @NewResDate
		, @ResStatus		= 'A'
		, @ResCheckInDate	= @NewCheckInDate
		, @ResNights		= @NewResNights
		, @ResQuotedRate	= @NewQuotedRate
		, @ResDepositPaid	= @NewDepositPaid
		, @ResCCAuth		= @NewCCAuth
		, @UnitRateID		= @NewUnitRateID
		, @PersonID			= @PersonID
END
GO

-- stored procedure sp_ProduceBill (from HW6)
-- Check to see if sp_ProduceBill exists.
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_NAME = 'sp_ProduceBill')
	DROP PROCEDURE sp_ProduceBill;
GO

CREATE PROCEDURE sp_ProduceBill
	@FolioID	varchar(max)
AS
BEGIN
	DECLARE @ErrMessage				varchar(max)
	DECLARE @GuestName				nvarchar(200)
	DECLARE @UnitNumber				varchar(5)
	DECLARE @CheckIn				smalldateTime
	DECLARE @CheckOut				smalldatetime = NULL
	DECLARE @TransDate				datetime
	DECLARE @TransDescription		varchar(50)
	DECLARE @TransAmount			smallmoney
	
	IF NOT EXISTS(SELECT FolioID FROM Folio WHERE FolioID = @FolioID)
	BEGIN
		PRINT ''
		SET @ErrMessage = ('"' + CONVERT(varchar,@FolioID) + '" is not a valid Folio. Please try again.')
		RAISERROR (@ErrMessage, -1, -1, @FolioID)
		PRINT ''
		RETURN -1
	END

	-- Obtain basic information
	SELECT @GuestName = CONCAT(p.PersonLast,', ',p.PersonFirst)
	, @UnitNumber = u.UnitNumber
	, @CheckIn = f.FolioCheckInDate
	, @CheckOut = f.FolioCheckOutDate
	FROM Folio f
	JOIN Reservation r
	ON f.ReservationID = r.ReservationID
	JOIN Person p
	ON r.PersonID = p.PersonID
	JOIN  Unit u
	ON f.UnitID = u.UnitID
	WHERE f.FolioID = @FolioID

	-- Print basic information
	PRINT ''
	PRINT 'Guest Details:'
	PRINT '   Guest Name:  ' + @GuestName
	PRINT '   Unit Number: ' + @UnitNumber
	PRINT '   Check-In:    ' + CONVERT(varchar,@CheckIn,101)
	PRINT '   Check-Out:   ' + CONVERT(varchar,@CheckOut,101)
	PRINT ''
	PRINT 'Transactions:'

	-- Use a cursor to loop through Folio Transaction
	DECLARE FolioTransactionCursor CURSOR FOR
	SELECT TransDate, TransDescription, TransAmount
	FROM FolioTransaction
	WHERE FolioID = @FolioID

	OPEN FolioTransactionCursor

	-- Fetch First Time
	FETCH NEXT FROM FolioTransactionCursor
	INTO @TransDate, @TransDescription, @TransAmount

	WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT '   Date:        ' + CONVERT(varchar,@TransDate,101)
		PRINT '   Description: ' + @TransDescription
		PRINT '   Amount:      ' + FORMAT(@TransAmount,'$#,0.00')
		PRINT ''
		
		-- Fetch Again
		FETCH NEXT FROM FolioTransactionCursor
		INTO @TransDate, @TransDescription, @TransAmount
	END
	
	CLOSE FolioTransactionCursor
	DEALLOCATE FolioTransactionCursor
END
GO

-- the function dbo.fn_GetLodgingTaxRate (from HW 7)
-- See if dbo.GetLodgingTaxRate exists.
IF OBJECT_ID (N'dbo.GetLodgingTaxRate', N'FN') IS NOT NULL
DROP FUNCTION dbo.GetLodgingTaxRate;
GO

-- Create dbo.GetLodgingTaxRate 
CREATE FUNCTION dbo.GetLodgingTaxRate
	(
		@PropertyID	smallint,
		@InDate		date
	)
RETURNS decimal(6,4)
AS
	BEGIN
		DECLARE @TaxRate	decimal
		SET @TaxRate = 0
		SET @TaxRate = (SELECT tr.TaxRate
						FROM Property p
						JOIN TaxLocation tl
						ON p.TaxLocationID = tl.TaxLocationID
						JOIN TaxRate tr
						ON tl.TaxLocationID = tr.TaxLocationID
						WHERE @PropertyID = p.PropertyID
							AND tr.TaxType = 'L'
							AND
							((tr.TaxStartDate <= @InDate
							AND tr.TaxEndDate >= @InDate)
							OR
							(tr.TaxStartDate <= @InDate
							AND tr.TaxEndDate IS NULL)))

		RETURN @TaxRate
	END
GO

-- the function dbo.fn_GetQuotedRate (from HW 7)
-- See if fn_GetQuotedRate exists.
IF EXISTS(SELECT name FROM sys.objects WHERE name = N'fn_GetQuotedRate')
DROP FUNCTION fn_GetQuotedRate;
GO

-- Create fn_GetQuotedRate
CREATE FUNCTION fn_GetQuotedRate
	(
		@PropertyID		int,
		@BeginDate		date,
		@EndDate		date,
		@UnitTypeID		tinyint
	)
RETURNS @ValidRates TABLE
	(
		UnitRate			smallmoney	NOT NULL,
		UnitTypeDescription	varchar(20)	NOT NULL,
		UnitRateDescription	varchar(50) NULL
	)
AS
BEGIN
	-- Ensure that dates are in correct order.
	IF (@BeginDate >= @EndDate)
		BEGIN
			INSERT INTO @ValidRates(UnitRate, UnitRateDescription, UnitTypeDescription)
			VALUES (0, '---', 'Invalid Date Order')
		END
	ELSE
		BEGIN
			DECLARE @startRate	smallmoney
			DECLARE @endRate	smallmoney
			DECLARE @maxRate	smallmoney
			DECLARE @UnitTypeDescription	varchar(20)
			DECLARE @UnitRateDescription	varchar(50)

			SET @startRate = (SELECT ur.UnitRate
							FROM UnitRate ur
							JOIN Property p
							ON ur.PropertyID = p.PropertyID
							WHERE ur.PropertyID = @PropertyID
							AND ur.UnitTypeID = @UnitTypeID
							AND ur.UnitRateBeginDate <= @BeginDate
							AND ur.UnitRateEndDate >= @BeginDate)

			SET @EndRate = (SELECT ur.UnitRate
							FROM UnitRate ur
							JOIN Property p
							ON ur.PropertyID = p.PropertyID
							WHERE ur.PropertyID = @PropertyID
							AND ur.UnitTypeID = @UnitTypeID
							AND ur.UnitRateBeginDate <= @EndDate
							AND ur.UnitRateEndDate >= @EndDate)

			SET @maxRate = (SELECT MAX(val)
							FROM (VALUES (@startRate), (@endRate)) AS value(val))
			
			SET @UnitRateDescription = (SELECT UnitRateDescription
							FROM UnitRate
							WHERE PropertyID = @PropertyID
							AND UnitTypeID = @UnitTypeID
							AND UnitRate = @maxRate)
			
			SET @UnitTypeDescription = (SELECT UnitTypeDescription
										FROM UnitType
										WHERE UnitTypeID = @UnitTypeID)

			INSERT INTO @ValidRates(UnitRate, UnitRateDescription, UnitTypeDescription)
			VALUES (@maxRate, @UnitRateDescription, @UnitTypeDescription)
		END
	RETURN
END
GO

-- 0A. Just like you did in HW 6, add yourself as a new person, and create a new Reservation calling sp_InsertPerson.
-- Note: For the data you insert, Use 7/21/2015 for Check-in Date, 2 nights (essentially checking out on 24 July).
DECLARE @NewPersonID int;

EXEC sp_InsertPerson
	  @PersonFirst		= 'Richard'
	, @PersonLast		= 'Fry'
	, @PersonAddress	= '123 Elm Street'
	, @PersonCity		= 'Ogden'
	, @PersonState		= 'UT'
	, @PersonPostalCode	= '84408'
	, @PersonCountry	= 'USA'
	, @PersonPhone		= '555-123-4567'
	, @PersonEmail		= 'me@somewhere.com'
	, @PersonID			= @NewPersonID		OUTPUT
	, @NewResDate		= 'July 6, 2015'
	, @NewCheckInDate	= '7/21/2015 4:00 PM'
	, @NewResNights		= 3
	, @NewQuotedRate	= 199.00
	, @NewDepositPaid	= 199.00
	, @NewCCAuth		= 'pending'
	, @NewUnitRateID	= 4
GO

-- 0B. Select * From Person and Select * From Reservation to show the results (exactly like HW6)
SELECT *
FROM Person
WHERE PersonID >= 44  -- Start at 44 to keep it shorter.

SELECT *
FROM Reservation
WHERE ReservationID >= 44  -- Start at 44 to keep it shorter.
GO

-- 1. Write a trigger named tr_UnitIDMustExist on the FOLIO table (after INSERT or UPDATE) that checks
--    to make sure the UnitID is a valid UnitID (essentially enforcing referential integrity between the
--    Folio and Unit Tables).
--    If an improper UnitID is inserted, then raise an error message and rollback the transaction.

-- See if tr_UnitIDMustExist exists.
IF EXISTS(SELECT name FROM sys.objects WHERE name = N'tr_UnitIDMustExist')
DROP TRIGGER tr_UnitIDMustExist;
GO

CREATE TRIGGER tr_UnitIDMustExist ON Folio
AFTER INSERT, UPDATE
AS
DECLARE @UnitID smallint
IF EXISTS ( SELECT 'something'
            FROM Inserted i
			LEFT JOIN Unit u
			ON i.UnitID = u.UnitID
			WHERE u.UnitID is NULL )
BEGIN
	SELECT @UnitID = (SELECT UnitID FROM Inserted) RAISERROR ('UnitID %d does not exist',10,1,@UnitId)
ROLLBACK
END
GO

-- 1A. Demonstrate this trigger by Checking yourself in (creating a new Folio entry based on the Reservation you
--     made in #0A above). Insert into Folio the same values as the Reservation (with status "C" checked in),
--     but inserting UnitID = 999. An error message should display showing UnitID 999 is invalid.

INSERT INTO Folio
VALUES ('C', 199.00,'7/21/2015', NULL, 999, 46)

-- 1B. Demonstrate the same trigger, using a valid UnitID of your choice. You should now have an active Folio
--     linked back to your reservation.

INSERT INTO Folio
VALUES ('C', 199.00,'7/21/2015', NULL, 10000, 46)

-- 1C. Select * from Folio to show the results.

SELECT *
FROM Folio
WHERE FolioID >= 18 -- Start at 18 to keep it shorter.

-- 1D. Using the FolioID that was created for your reservation, write a couple of Insert Statements for the
--     FolioTransaction table so it populates with some sample charges associated with the Folio.
--     I don't really care what the Transactions contain (maybe a Food and Beverage, Gym, or Internet Charge),
--     but have at least 2 rows of sample data (for later).

-- Find the latest FolioID
DECLARE @FolioID	int
SET @FolioID = (SELECT MAX(FolioID) FROM Folio)

-- Insert one row.
INSERT INTO FolioTransaction
VALUES ('7/21/2015 5:46 PM', 4.99, 'Wi-Fi Daily Fee', 13, @FolioID)

-- Insert a second row.
INSERT INTO FolioTransaction
VALUES ('7/21/2015 5:46 PM', 0.5, 'Wi-Fi Tax', 15, @FolioID)

GO

-- Prove that they were inserted correctly.
SELECT *
FROM FolioTransaction
WHERE TransID >= 210 -- Start at 210 to keep it shorter.

-- 2. Write a trigger named tr_UpdateFolio that will be invoked when the Folio table 'status' field
--    (column update) is changed.
--
--    If Foliostatus is updated to 'B' for Billed, trigger two Insert statements to
--    (1) INSERT in the FolioTransaction table, the amount for the total lodging cost as
--        Transcategory 1 - (normally the FolioRate * number of nights stay, but you must
--        also factor in any late checkout fees*).
--        *Checkout time is Noon on the checkout date. Guest is given a one hour grace period
--         to check out. After 1PM (but before 4PM), a 50% surcharge is added to the FolioRate.
--         After 4PM, an additional full night's FolioRate is applied.
--         1300 Hours = 1PM, 1600 HRS = 4PM
--    (2) The second INSERT statement in the same trigger will insert the Lodging Tax*, which
--        is a separate entry in the FolioTransaction table for tax on lodging (Transcategory 2).
--        *Use the dbo.GetLodgingTaxRate function from HW 7 to determine the Logding Tax.
--        Note: You'll need to determine the propertyID to pass to the function by joining
--        Folio(unitid) to Unit(UnitID).
--
--         If FolioCheckoutDate (column update) is updated, trigger an INSERT in the
--         FolioTransaction table. Hardcode sample insert data using GetDate(), $0 for the
--         TransAmount, "Processing Bill, and getting balance due..." for the description,
--         Transcategory 10 (for payment), and any YOUR folioID (from 1D).
--    You may also modify the function, if you wish to make things easier.

-- See if tr_UpdateFolio exists.
IF EXISTS(SELECT name FROM sys.objects WHERE name = N'tr_UpdateFolio')
DROP TRIGGER tr_UpdateFolio;
GO

CREATE TRIGGER tr_UpdateFolio ON Folio
AFTER UPDATE
AS
BEGIN
	IF (COLUMNS_UPDATED() = 2 | 18)
	BEGIN
		DECLARE @OldFolioStatus		char(1)
		DECLARE @NewFolioStatus		char(1)
		DECLARE @FolioID			int
		DECLARE @FolioRate			smallmoney
		DECLARE @CheckInDate		smalldatetime
		DECLARE @CheckOutDate		smalldatetime
		DECLARE @ReservationID		int
		DECLARE @ResNights			tinyint
		DECLARE @LateCheckOutFee	smallmoney
		DECLARE @Hours				int
		DECLARE @Charge				smallmoney
		DECLARE @PropertyID			smallint
		DECLARE @TaxRate			decimal(6,4)

		SELECT @OldFolioStatus = d.FolioStatus, @NewFolioStatus = i.FolioStatus, @FolioRate = i.FolioRate,
				@FolioID = i.FolioID, @CheckInDate = i.FolioCheckInDate, @CheckOutDate = i.FolioCheckOutDate,
				@ReservationID = i.ReservationID
			FROM Inserted i
			JOIN deleted d
			ON i.FolioID = d.FolioID

		SELECT @ResNights = (SELECT ResNights
			FROM Reservation
			WHERE ReservationID = @ReservationID)

		SET @LateCheckOutFee = 0.00
		SET @Hours = DATEDIFF (HOUR, @CheckinDate + @ResNights, @CheckOutDate)
		SET @Charge = 0.00

		SET @PropertyID = (SELECT ur.PropertyID
						FROM UnitRate ur
						JOIN Reservation r
						ON ur.UnitRateID = r.UnitRateID
						WHERE r.ReservationID = @ReservationID)

		SET @TaxRate = 0.00

		-- These are commented out so that it can be billed multiple times
		-- This if-statement helps to not make a bill again if you are making the same changes.
		--IF (@OldFolioStatus != @NewFolioStatus)
		--BEGIN
			IF (@NewFolioStatus = 'B')
			BEGIN
				-- Determine Late Fee (if applicable)
				IF @Hours >= 16
				-- Add another day
				BEGIN
					SET @LateCheckOutFee = @FolioRate
				END

				ELSE IF @Hours >= 13
				-- Add a half day
				BEGIN
					SET @LateCheckOutFee = @FolioRate * 0.5
				END

				-- Generate the charges
				SET @Charge = (@FolioRate * @ResNights) + @LateCheckOutFee
				
				-- Insert Lodging into FolioTransaction
				INSERT INTO FolioTransaction
				VALUES (@CheckOutDate, @Charge, 'Lodging', 1, @FolioID)

				-- Insert Lodging Tax into FolioTransaction
				SET @TaxRate = dbo.GetLodgingTaxRate(@PropertyID, @CheckInDate)
				INSERT INTO FolioTransaction
				VALUES (@CheckOutDate, @TaxRate, 'Occupancy Tax', 2, @FolioID)
			END
		--END
	END

	IF (COLUMNS_UPDATED() = 16 | 18)
	BEGIN
		-- Insert a note into FolioTransaction
			-- Find the latest FolioID
			DECLARE @MyFolioID	int
			SET @MyFolioID = (SELECT MAX(FolioID) FROM Folio)
		INSERT INTO FolioTransaction
		VALUES (GetDate(), 0.00, 'Processing Bill, and getting balance due...', 10, @MyFolioID)
	END
END
GO

-- 3. Write a trigger named tr_GenerateBill that will be invoked when an entry is INSERTED into the table
--    FolioTransaction . If TransCategoryID is 10, meaning 'Payment', then call stored procedure ProduceBill (from HW 6).

-- See if tr_GenerateBill exists.
IF EXISTS(SELECT name FROM sys.objects WHERE name = N'tr_GenerateBill')
DROP TRIGGER tr_GenerateBill;
GO

CREATE TRIGGER tr_GenerateBill ON FolioTransaction
AFTER INSERT
AS
BEGIN
	DECLARE @TransCategoryID	smallint
	DECLARE @ThisFolioID		int

	SELECT @TransCategoryID = TransCategoryID, @ThisFolioID = FolioID
		FROM inserted

	IF (@TransCategoryID = 10)
	BEGIN
		EXEC sp_ProduceBill
			@FolioID	= @ThisFolioID
	END
END
GO
-- This GO is important as I had left it off and it caused an error:
-- Maximum stored procedure, function, trigger, or view nesting level exceeded
-- GOs are great for breaking it up into different sections/calls

-- 4A. Assume today is (July 24, 2015 at 2PM)*. YOU are due to check out today (from 1A-1C above).
--     Write an Update Statement to change the status of your Folio to 'B'illed. (Be careful to include
--     a WHERE clause so ONLY your folio is updated). Note: This should automatically invoke Trigger 1 above
--     (factoring in the late charge), which automatically invokes 3 above, and calls sp_ProduceBill, and produces
--     a bill. *To simulate the current time as July 24, 2015 at 2PM, you will need to hard code the date
--     value '7/24/2015 2:00:00 PM'.

-- Find the latest FolioID
DECLARE @FolioID	int
SET @FolioID = (SELECT MAX(FolioID) FROM Folio)

-- Change FolioStatus to 'B' and FolioCheckOutDate
UPDATE Folio
	SET FolioStatus = 'B', FolioCheckOutDate = '7/24/2015 2:00:00 PM'
	WHERE FolioID = @FolioID
GO

-- 4B. Assume today is (July 24, 2015 at 10AM)*. Write an Update Statement to change the status of your Folio to
--     'B'illed. Note: This should automatically invoke Trigger 1 above (NOT factoring in the late charge), which
--     automatically invokes 3 above, and calls sp_ProduceBill, and produces a bill. *To simulate the current time
--     as July 24, 2015 at 10AM, you will need to hard code the date value '7/24/2015 10:00:00 AM'.

-- Find the latest FolioID
DECLARE @FolioID	int
SET @FolioID = (SELECT MAX(FolioID) FROM Folio)

-- Change FolioStatus to 'B' and FolioCheckOutDate
UPDATE Folio
	SET FolioStatus = 'B', FolioCheckOutDate = '7/24/2015 10:00:00 AM'
	WHERE FolioID = @FolioID
GO

-- 4C. Assume today is (July 24, 2015 at 6PM)*. Write an Update Statement to change the status of your Folio to 
--     'B'illed. Note: This should automatically invoke Trigger 1 above (factoring in the late charge), which
--     automatically invokes 3 above, and calls sp_ProduceBill, and produces a bill. *To simulate the current time
--     as July 24, 2015 at 6PM, you will need to hard code the date value '7/24/2015 6:00:00 PM'.

-- Find the latest FolioID
DECLARE @FolioID	int
SET @FolioID = (SELECT MAX(FolioID) FROM Folio)

-- Change FolioStatus to 'B' and FolioCheckOutDate
UPDATE Folio
	SET FolioStatus = 'B', FolioCheckOutDate = '7/24/2015 6:00:00 PM'
	WHERE FolioID = @FolioID
GO

--See the results of the update on Folio.
SELECT *
FROM Folio
WHERE FolioID >= 18 -- Start at 18 to keep it shorter.

-- 4D. Run a SELECT statement on the FolioTransaction Table showing your Triggers worked.
SELECT *
FROM FolioTransaction
WHERE TransID >= 212 -- Start at 212 to keep it shorter.

-- 5. Write a trigger called tr_InsertReservationDetail that will automatically insert the Quoted Rack Rate
--    (obtained from dbo.fn_GetQuotedRate*) into the ResQuotedRate field (in lieu of the user's input), when
--    an insert (only) is made into the RESERVATION table. *getting the PropertyID by joining the UnitRateID
--    from the inserted table to the UnitRate (UnitRateID).

-- See if tr_InsertReservationDetail exists.
IF EXISTS(SELECT name FROM sys.objects WHERE name = N'tr_InsertReservationDetail')
DROP TRIGGER tr_InsertReservationDetail;
GO

CREATE TRIGGER tr_InsertReservationDetail ON Reservation
INSTEAD OF INSERT 
AS 
BEGIN 
	IF (SELECT COUNT (*) FROM Inserted) > 0
	BEGIN
		DECLARE @ResDate		smalldatetime
		DECLARE @ResStatus		char(1)
		DECLARE @ResCheckInDate	date
		DECLARE @ResNights		tinyint
		DECLARE @ResQuotedRate	smallmoney
		DECLARE @ResDepositPaid	smallmoney
		DECLARE @ResCCAuth		varchar(25)
		DECLARE @UnitRateID		smallint
		DECLARE @PersonID		int
		DECLARE @PropertyID		int
		DECLARE @EndDate		date
		DECLARE @UnitTypeID		tinyint

		SELECT @ResDate = i.ResDate, @ResStatus = i.ResStatus, @ResCheckInDate = i.ResCheckInDate,
			@ResNights = i.ResNights, @ResDepositPaid = i.ResDepositPaid, @ResCCAuth = i.ResCCAuth,
			@UnitRateID = i.UnitRateID, @PersonID = i.PersonID, @PropertyID = u.PropertyID, @UnitTypeID = u.UnitTypeID

			FROM Inserted i
			JOIN UnitRate u
			ON i.UnitRateID = u.UnitRateID

		-- Determine EndDate
		SET @EndDate = DATEADD(DAY,@ResNights,@ResCheckInDate)

		-- Determine the Unit Rate.
		SELECT @ResQuotedRate = (SELECT UnitRate
			FROM fn_GetQuotedRate(@PropertyID, @ResCheckInDate, @EndDate, @UnitTypeID))

		-- Insert the new Reservation
		INSERT INTO Reservation (ResDate, ResStatus, ResCheckInDate, ResNights, ResQuotedRate, ResDepositPaid, ResCCAuth, UnitRateID, PersonID)
		VALUES (@ResDate, @ResStatus, @ResCheckInDate, @ResNights, @ResQuotedRate, @ResDepositPaid, @ResCCAuth, @UnitRateID, @PersonID)
	END
END
GO

-- 5A. Demonstrate this trigger by entering a reservation. Go ahead and supply quoted rate (any rate).
--     The INSTEAD OF trigger should overwrite your entry with the correct Rack Rate.

-- Find the latest PersonID
DECLARE @PersonID	int
SET @PersonID = (SELECT MAX(PersonID) FROM Person)

-- Insert the new Reservation
INSERT INTO Reservation
VALUES (GETDATE(), 'A', '8/1/2015 4:00 PM', 5, 199, 199, '5A', 4, @PersonID)
GO

-- 5B: Select * From Reservation to show the system overrode your rate.
SELECT *
FROM Reservation
WHERE ReservationID >= 44  -- Start at 44 to keep it shorter.