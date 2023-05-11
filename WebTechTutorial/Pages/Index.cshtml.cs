using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWeb.Shared.Models;

namespace WebTechTutorial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MyWebDatabaseContext _database;
        public List<Product> Products { get; set; }
        public IndexModel(ILogger<IndexModel> logger, MyWebDatabaseContext database)
        {
            _database = database;
            _logger = logger;
        }

        public async Task OnGet()
        {
            //get
            //select * from Product where ProductCategoryId = 1;
            Products = await _database.Product.ToListAsync();
            //Products = await _database.Product.Where(x => x.ProductCategoryId == 1).ToListAsync();
            //add
            //_database.Product.Add(new Product()
            //{
            //    ProductName = "xxx"
            //});
            //update
            //_database.Product.Update();
            //delete
            //_database.Product.Remove();
            //_database.SaveChanges();

            //linq
        }
    }
}