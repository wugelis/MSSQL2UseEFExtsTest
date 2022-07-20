using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSSQL2UseEFExtsTest.Models
{
	[Table("ACCOUNT")]
	public class Account
	{
		[Key]
		[Column(Order = 0)]
		[StringLength(50)]
		public string userId {get; set;}


		[StringLength(50)]
		public string password {get; set;}


		[StringLength(50)]
		public string type {get; set;}


		public DateTime applyDate {get; set;}


	}

}
