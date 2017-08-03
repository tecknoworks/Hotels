using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class ReviewService
	{
		private ApplicationDbContext context = new ApplicationDbContext();

		public void GetAllReviews()
		{
			var x = context.Reviews.ToList();
		}
	}
}
