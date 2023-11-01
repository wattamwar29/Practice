using Microsoft.AspNetCore.Mvc;

using EmpMvc.Models;

using System.Data;

using System.Data.SqlClient;

namespace EmpMvc.Controllers;

 

public class ProductController : Controller

{
    public IActionResult Display(int id)
    {
        string constr = "User ID=sa; password=examlyMssql@123; server=localhost;Database=Akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand command = new SqlCommand("Find", con);
        command.CommandType=CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id",id);
        con.Open();
        SqlDataReader reader=command.ExecuteReader();
        DataTable prodTable=new DataTable();
        prodTable.Load(reader);
        return View(prodTable);


    }

    public IActionResult List()

    {

        string constr = "User ID=sa; password=examlyMssql@123; server=localhost;Database=Akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand command = new SqlCommand("Select * from Product", con);

        con.Open();

        SqlDataReader reader = command.ExecuteReader();

        DataTable prodTable = new DataTable();

        prodTable.Load(reader);

        return View(prodTable);

    }
    public IActionResult create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult create(int id,string name,int price,int stock)
    {
        if(ModelState.IsValid)
        {
            string constr = "User ID=sa; password=examlyMssql@123; server=localhost;Database=Akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False";
            
        SqlConnection con = new SqlConnection(constr);

        SqlCommand command = new SqlCommand("addproduct", con);
        command.CommandType=CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id",id);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@price",price);
        command.Parameters.AddWithValue("@stock",stock);
        con.Open();
        command.ExecuteNonQuery();
        con.Close();
        return RedirectToAction("List");

        }
        return View();
    }

 

}
