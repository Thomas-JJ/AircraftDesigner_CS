CREATE TABLE tbAircraftDesigner2(
	Id int IDENTITY PRIMARY KEY,
	User_ID int NOT NULL,
	Configuration_Name varchar(64) NOT NULL,
	aircraft_Type int NOT NULL,
	payload real NOT NULL,
	velocity real NOT NULL,
	range real NOT NULL,
	prop_Config int NOT NULL,
	wingspan real NOT NULL,
	wing_Config int NOT NULL,
	sweep_Angle real NOT NULL,
	root_Cord real NOT NULL,
	landing_Gear_Config int NOT NULL,
	mission_Profile int NOT NULL
)