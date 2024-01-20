// OwnersController.cs en Controllers
using Microsoft.AspNetCore.Mvc;
using PropertiesManagement.Models;
using System;
using System.Data.SqlClient;

public class OwnerController : Controller
{
    private readonly string connectionString = "Data Source=(local); Initial Catalog=GestionPropiedades;Integrated Security=true";

    public IActionResult RegisterOwner()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Save(OwnerModel owner)
    {
        if (ModelState.IsValid)
        {
            try
            {
                InsertOwnerIntoDatabase(owner);

                return RedirectToAction("Index"); 
            }
            catch (Exception)
            {
                
                ModelState.AddModelError(string.Empty, "Error to saving to database.");
                return View(); 
            }
        }

        return View();
    }

    private void InsertOwnerIntoDatabase(OwnerModel owner)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (var command = new SqlCommand("INSERT INTO Owner (Name, Telephone, Email, IdentificationNumber, Address) VALUES (@Name, @Telephone, @Email, @IdentificationNumber, @Address)", connection))
            {
                command.Parameters.AddWithValue("@Name", owner.Name);
                command.Parameters.AddWithValue("@Telephone", owner.Telephone);
                command.Parameters.AddWithValue("@Email", owner.Email);
                command.Parameters.AddWithValue("@IdentificationNumber", owner.IdentificationNumber);
                command.Parameters.AddWithValue("@Address", owner.Address);

                command.ExecuteNonQuery();
            }
        }
    }
}
