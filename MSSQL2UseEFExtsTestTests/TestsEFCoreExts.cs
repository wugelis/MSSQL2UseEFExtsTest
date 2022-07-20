using EasyArchitect.EntityFrameworkCore.Exts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSQL2UseEFExtsTest;
using MSSQL2UseEFExtsTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.MSSQL2UseEFExtsTest
{
    [TestClass()]
    public class TestsEFCoreExts
    {
        private static IConfigurationRoot _configuration;
        [TestMethod()]
        public async Task Test_OpenConnection()
        {
            bool actual;
            bool expected = true;
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json");

            _configuration = builder.Build();

            var _dbContextOptions = new DbContextOptionsBuilder<HousingLoansDbContext>()
                .UseSqlServer(_configuration.GetConnectionString("HousingConn"))
                .Options;

            HousingLoansDbContext context = new HousingLoansDbContext(_dbContextOptions);
            string sqlText = @"SELECT T.CUSTOMERID,
    T.CHTNAME,
    T.AID,
    T.MOBILE,
    T.TEL,
    T.ADDRESS,
    T.LOCATION,
    T.EMAIL,
    T.MARRY,
    T.FAMILYNUM,
    T.EDUCATION,
    T.USERID
FROM CUSTOMERDETAIL T";
            var result = await context.SqlQuery<Customerdetail>(sqlText, null);
            int count = result.Count();
            Assert.IsTrue(count > 0);
        }
    }
}