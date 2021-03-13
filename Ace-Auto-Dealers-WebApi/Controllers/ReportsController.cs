using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ace_Auto_Dealers_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        public IConfiguration _configuration { get; }

        public ReportsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        
        [HttpGet("HeardFrom")]
        public IActionResult Get()
        {

            try
            {
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    string qr = @"select[HeardFrom]  Lables,count([VehicleModel]) Data
from [Ace-Auto-DealersDB].[dbo].[Customers]
group by [HeardFrom]";
                 
                    return Ok(connection.QueryAsync<dynamic>(qr).Result.ToList());
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("SalesRepresentativeName")]
        public IActionResult GetSalesRepresentativeName()
        {

            try
            {
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    string qr = @"select [SalesRepresentativeName] Lables, count(*)  Data
 FROM [Ace-Auto-DealersDB].[dbo].[Customers]
 where [Purchase]='true'
 group by [SalesRepresentativeName]";

                    return Ok(connection.QueryAsync<dynamic>(qr).Result.ToList());
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("VehicleModel")]
        public IActionResult GetSalesVehicleModel()
        {

            try
            {
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    string qr = @"select [VehicleModel] Lables, count(*) Data
 FROM [Ace-Auto-DealersDB].[dbo].[Customers]
 where [Purchase]='true'
 group by [VehicleModel]";

                    return Ok(connection.QueryAsync<dynamic>(qr).Result.ToList());
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }



    }
}
