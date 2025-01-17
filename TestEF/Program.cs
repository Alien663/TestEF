using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TestEF;
using TestEF.Entities;;

CryptoHandler crypto = new CryptoHandler();

//string conn = "Data Source=.;Database=Test;User ID=sa;Password=test;Connect Timeout=30;Encrypt=false;Trusted_Connection=false;TrustServerCertificate=true;MultipleActiveResultSets=true;";
//string sec_conn = crypto.Encrypt(conn);

var optionsBuilder = new DbContextOptionsBuilder<TestContext>();
optionsBuilder.UseSqlServer(crypto.Decrypt(AppConfig.Config["ConnectionStrings:DefaultConnection"]));
TestContext _context = new TestContext(optionsBuilder.Options);

var tt = _context.InvoiceDetails.Where((item => item.ProductID == 756 && item.OrderQty == 3));
Console.WriteLine(JsonConvert.SerializeObject(tt));
Console.Write("Press any key to continue......");
Console.ReadKey();