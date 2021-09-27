# AircraftDesigner_CS
Design an aircraft and estimate the initial weight
This is a project I started to explore the use of class strucutres in a C# application and demonstrate the ability to execute CRUD operations with a database.

There is a word doc inside this project that gives a highlevel process of the calculation steps if you are interested

## SET UP REQUIRED
### Adding SQL Table(s)
In the repository you will find a sql script used to set up the tables required by the application. This application has queries written to accomodate MSSQL syntax however since the queries are fairly simple it would be easy to adapt as needed.
### Adding Connection String
The project contains an app.config file where you will see the below code snippet to place your connection string.
````
    <connectionStrings>
      <add name="MyDBConnectionString" providerName="System.Data.SqlClient"
            connectionString="Data Source=localhost;Initial Catalog=MyServerDB; Integrated Security=true" />
    </connectionStrings>
````

### Opportunities
1. When saving an aircraft configuration the Configuration name does not update.
2. When Saving As the aircraft configuration name does not update to the new name.
3. Calculation needs to review regarding the Specific Fuel Consumption. This has been set to a default value till bug resolved but till then the Engine Type has no bearing on the output calculation.
