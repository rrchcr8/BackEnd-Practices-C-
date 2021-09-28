using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly string connectionSring = "Data Source=DESKTOP-M538U9G;Initial Catalog=CustomerDb; Integrated Security=True";

        [HttpGet]
        public async Task<IEnumerable<Models.Customer>> GetAllCustomers()
        {
            IEnumerable<Models.Customer> customers;

            using (SqlConnection connection = new SqlConnection(connectionSring)) 
            {
                await connection.OpenAsync();
                var sqlQuery = "Select * From Customer";
                customers = await connection.QueryAsync <Models.Customer>(sqlQuery);

            }
            return customers;
        }

        [HttpGet("{id}")]
        public async Task<Models.Customer> GetlCustomerById(int id)
        {
            Models.Customer customer = new Models.Customer();

            using (SqlConnection connection = new SqlConnection(connectionSring))
            {
                await connection.OpenAsync();
                var sqlQuery = "Select * From Customer Where Id=@Id";
                customer = await connection.QuerySingleAsync<Models.Customer>(sqlQuery, new {Id=id });

            }
            return customer;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Models.Customer customer)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionSring))
            {
                await connection.OpenAsync();
                var sqlQuery = "Insert Into Customer (Name, Address, Telephone, Email) Values(@Name, @Address, @Telephone, @Email)";
                await connection.ExecuteAsync(sqlQuery, customer);

            }
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Models.Customer customer)
        {

            using (SqlConnection connection = new SqlConnection(connectionSring))
            {
                await connection.OpenAsync();
                var sqlQuery = "UPDATE Customer SET Name =@Name, Address= @Address, Telephone = @Telephone, Email=@Email WHERE Id=@Id";
                await connection.ExecuteAsync(sqlQuery, customer);

            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionSring))
            {
                await connection.OpenAsync();
                var sqlQuery = "Delete Customer Where Id = @Id";
                await connection.ExecuteAsync(sqlQuery, new { Id=id});

            }
            return Ok();
        }


    }
}
