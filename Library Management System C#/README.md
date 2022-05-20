# C# Library Management System 

A Project i've been working on since yesterday. This system can help library workers to manage their books, see which books available (By category, name).
<br>
This is an incomplete project.
<br>
<b> To do: </b>
1. Complete Books by category (Select * from (Table) Where category = @category) for each category.
<br>
2.Some Category needs to be reshaped to hide columns the worker do not need to see but exist to filter the results. Using SqlDataAdapter and DataSet, we declare a 
variable for table, and SqlDataAdapter.Fill(Table). Then, we call the talbe variable and use it methods.  For this request, we need to manipulate Table.Columns.Remove("Column Name").
<br>
3. New User UI for worker, can be copy-cat from Register.cs into a new UI. Same system, using the same table, columns and command.
<br>
4. Design - The most important thing. I like to code, not to design UX/UI. and as such, I don't care much about the design but about the tasks behind.
<br>

<h1> Examples </h1>
Gifs to show the work.
<br>
<br>
<h1> Register </h1>
<img src="Register.gif">

<h1> Login </h1>
The Login system. Using ExecuteReader I check for the username and password to Authenticate with SQL.
<img src="Login.gif">

<h1> Main Dashboard </h1>
Main Dashboard. Using getdate.now for time, search option to look over DB and print results in the datagridview.
<img src="Main_Dashboard.gif">
