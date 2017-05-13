using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
	[Route("[controller]/[action]")]
    public class AboutController
    {
		public string Phone()
		{
			return "123-456-789";
		}

		public string Address()
		{
			return "Poland";
		}
    }
}
