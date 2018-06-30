using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LungeloNeneTest.Models
{
		public class JuniorDevContext : DbContext
		{
				public DbSet<Add> add { get; set; }
		}
}