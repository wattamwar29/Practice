// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Data.SqlClient;
using System;
using System.Data;
//AddRecord();
//Show();
ShowDisconnect();
//AddConnect();
AddDisconnect();

void AddDisconnect(){
    string connectionString ="User ID=sa;password=examlyMssql@123; server=localhost;Database=akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    
    Console.WriteLine("Enter ID");
    int id=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter product name");
    string name=Console.ReadLine();
    Console.WriteLine("Enter price");
    int price=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Stock");
    int stock=Convert.ToInt32(Console.ReadLine());
    DataSet ds=null;  
    DataTable prodsTable=null;
    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    try
    {
        ds=new DataSet();
        connection=new SqlConnection(connectionString);
        adapter=new SqlDataAdapter("Select * from Product",connection);
        adapter.Fill(ds,"Prods");
        prodsTable=ds.Tables["Prods"];
        DataRow prodsrow=prodsTable.NewRow();
        prodsrow["id"]=id;
        prodsrow["name"]=name;
        prodsrow["price"]=price;
        prodsrow["stock"]=stock;
        prodsTable.Rows.Add(prodsrow);
        SqlCommandBuilder scb=new SqlCommandBuilder(adapter);
        Console.WriteLine(scb.GetInsertCommand().CommandText);
        adapter.Update(prodsTable);

        Console.WriteLine("Row added");

     }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


}
void ShowDisconnect()
{
     
     string connectionString ="User ID=sa;password=examlyMssql@123; server=localhost;Database=akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False";
     string cmdtext = "insert into Product values(@id,@name,@price,@stock)";
     SqlConnection connection=null;
     SqlDataAdapter adapter=null;
     DataSet ds=null;  
     DataTable prodsTable=null;
     try{
        ds=new DataSet();
        connection=new SqlConnection(connectionString);
        adapter=new SqlDataAdapter("Select*from Product",connection);
        adapter.Fill(ds,"Prods");
        prodsTable=ds.Tables["Prods"];
        Console.WriteLine($"Rows={prodsTable.Rows.Count}");
        Console.WriteLine($"Columns={prodsTable.Columns.Count}");
        foreach(DataRow row in prodsTable.Rows)
        {
            Console.WriteLine($"{row["id"]}--{row["name"]}--{row["price"]}--{row["stock"]}");
        }
     }  
     catch(Exception ex)
     {
        Console.WriteLine(ex.Message);
     }
     
}
void AddRecord()
{

    string connectionString ="User ID=sa;password=examlyMssql@123; server=localhost;Database=akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtext = "insert into Product values(@id,@name,@price,@stock)";
    Console.WriteLine("Enter ID");
    int id=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter product name");
    string name=Console.ReadLine();
    Console.WriteLine("Enter price");
    int price=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Stock");
    int stock=Convert.ToInt32(Console.ReadLine());
    SqlConnection con=null;
    SqlCommand command=null;
    try{
        con= new SqlConnection(connectionString);
        command=new SqlCommand(cmdtext,con);
        command.Parameters.AddWithValue("@id",id);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@price",price);
        command.Parameters.AddWithValue("@stock",stock);
        con.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("Record Added");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally{
        con.Close();
    }

}
void Show()
{
string connectionString ="User ID=sa;password=examlyMssql@123; server=localhost;Database=akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False";
string cmdtext = "select*from Product";

try{
    SqlConnection con= new (connectionString);
    con.Open();
    Console.WriteLine("Connection Opened Successfully");
    SqlCommand command=new SqlCommand(cmdtext,con);
    SqlDataReader reader = command.ExecuteReader();
    while(reader.Read())
    {
        Console.WriteLine($"{reader["id"]}---{reader["Name"]}---{reader["price"]}---{reader["stock"]}");
    }
    con.Close();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
}
