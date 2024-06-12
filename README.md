# repos

<h1>Windows Form C# App with ADO.NET in order to display data from SQLServer database. How it works:</h1>
<p>
class BaseClass=> the class from which the base attributes and methods derive from.<br  />

  _conS=>variable for connection string value used to connect with the database. <br />
_da=>SqlDataAdapter variable type in order to update database through SqlCommand values and connection parameters.<br  />
_dt=>DataTable variable type in order to pull content from database and serves as the source for the DataGridView element within Form container.<br  />
<br  />
Methods:
TestConnection()=>Method used to check whether the connection is opened or not.
<br  />
Initalize()=>This method is called every time the form is loaded.
<br  />
</p>

<p>
<h2>Database and DataGridView management projects:</h2>
<br  />
Insert()=>Method used to insert data inside the database through _da and _dt.
<br  />
Delete()=>Method used to delete data inside the database according to the specific values through _da and _dt.
<br  />
Update()=>Method used to update data from an existing record inside the database according to the specific Name matching.
<br  />
Filter()=>Method used to select and display the row values in a message box according to a specific Name matching.
<br  />
</p>



*Note the class uses static methods since there was no point for instantiating the whole class. Instead there was preference for directly calling them from the BaseClass itself inside Form.cs*.



