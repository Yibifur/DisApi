using DisApi.BusinessLayer.Abstract;
using DisApi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DisApi.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToothController : ControllerBase
    {
        private readonly IToothService _toothService;

        public ToothController(IToothService toothService)
        {
            _toothService = toothService;
        }

        [HttpGet]
        public IActionResult GetToothList()
        {
            return Ok(_toothService.TGetList());
        }
        [HttpGet("{id}")]
        public IActionResult GetTooth(int id)
        {
            return Ok(_toothService.TGetByID(id));
        }
        [HttpDelete] 
        public IActionResult DeleteTooth(int id) {


            var tooth = _toothService.TGetByID(id);
            _toothService.TDelete(tooth);
            return Ok();
        
        
        }
        [HttpPut]
        public IActionResult UpdateTooth(Tooth tooth )
        {


            _toothService.TUpdate(tooth);
            return Ok();


        }

    }
}
