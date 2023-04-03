using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShortcutsController : ControllerBase
    {
        IShortcutListService _shortcutListService;
        public ShortcutsController(IShortcutListService shortcutListService)
        {
            _shortcutListService = shortcutListService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _shortcutListService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getById")]
        public IActionResult GetAllById(int id)
        {
            var result = _shortcutListService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(ShortcutList shortcutList)
        {
            var result = _shortcutListService.Add(shortcutList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ShortcutList shortcutList)
        {
            var result = _shortcutListService.Delete(shortcutList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
