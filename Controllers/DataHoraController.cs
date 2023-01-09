using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrilhaApiDesafio.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DataHoraController : ControllerBase
	{
		[HttpGet("ObterDataHoraAtual")]
		public IActionResult ObterDataHora()
		{
			var obj = new
			{
				Data = DateTime.Now.ToLongDateString(),
				Hora = DateTime.Now.ToShortTimeString()
			};
			return Ok(obj);
		}
	}
}
