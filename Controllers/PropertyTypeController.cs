
//using PropertiesManagement.Data;
using Microsoft.AspNetCore.Mvc;
using PropertiesManagement.Models;
using System;
using System.Data.SqlClient;

namespace PropertiesManagement.Controllers

{
    public class PropertyTypeController: Controller
    {

        private readonly string connectionString = "Data Source=(local); Initial Catalog=GestionPropiedades;Integrated Security=true";

        public IActionResult RegisterPropertyType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SavePropertyType(PropertyTypeModel propertyType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InsertPropertyTypeIntoDatabase(propertyType);

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    // Manejar errores de inserción en la base de datos
                    ModelState.AddModelError(string.Empty, "Error to saving to database.");
                    return View();
                }
            }

            return View();
        }

        private IActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }

        private void InsertPropertyTypeIntoDatabase(PropertyTypeModel propertyType)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("INSERT INTO Owner (Description) VALUES (@Description)", connection))
                {
                    command.Parameters.AddWithValue("@Name", propertyType.Description);
                   
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
