using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Services;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        private RpgServices _services;

        public RpgController //建構方法

        {
            _services = new RpgServices();
            
        }
        
        
        [HttpGet] 
        [Route(template:"{id}")]
        public Rpg Get(int id)
        
       
        {
            Rpg result = null;
            
            result = _services Get(id:);
            
            return result;
        }
        
    }
}
