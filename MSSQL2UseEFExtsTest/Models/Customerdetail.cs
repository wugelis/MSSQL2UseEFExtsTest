using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSSQL2UseEFExtsTest.Models
{
	[Table("CUSTOMERDETAIL")]
	public class Customerdetail
	{
		[StringLength(50)]
		public string chtName {get; set;}


		[StringLength(50)]
		public string aid {get; set;}


		[StringLength(50)]
		public string mobile {get; set;}


		public DateTime birthday {get; set;}


		[StringLength(50)]
		public string tel {get; set;}


		[StringLength(50)]
		public string address {get; set;}


		[StringLength(50)]
		public string locationNow {get; set;}


		[StringLength(50)]
		public string email {get; set;}


		public bool marry {get; set;}


		public long familyNum {get; set;}


		[StringLength(50)]
		public string education {get; set;}


		[Key]
		[Column(Order = 0)]
		public long customerId {get; set;}


		[StringLength(50)]
		public string userId {get; set;}


	}

}
