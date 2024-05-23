using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;


        }



        [HttpGet]
        public async Task<IEnumerable<ProductModelDTO>> ProductGet()
        {

            var query = await _db.Products
                .Select(model => new ProductModelDTO
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    CategoryId = model.CategoryId,
                    Price = model.Price
                })
                .ToListAsync();
            return query;
        }

            

            
        



        [HttpPost]
        public async Task<ActionResult<ProductModelDTO>> ProductAdd(ProductModelDTO productDTO)
        {



            // Map DTO to Entity model
            var product = new ProductModel
            {
                ProductName = productDTO.ProductName,
                CategoryId = productDTO.CategoryId,
                Price=productDTO.Price
                
            };


            _db.Products.Add(product);
            await _db.SaveChangesAsync();



            // Return success response
            return CreatedAtAction(nameof(ProductAdd), new { id = product.Id }, product);



        }



        [HttpGet("{id}")]
        public async Task<ActionResult<ProductModelDTO>> GetProductItem(int id)
        {
            var productItem = await _db.Products.FindAsync(id);

            if (productItem == null)
            {
                return NotFound();
            }



            return await _db.Products.Select(prod => new ProductModelDTO 
            { 
                ProductName = prod.ProductName,
                Id = prod.Id,
                Price = prod.Price,
                CategoryId = prod.CategoryId
            }).FirstOrDefaultAsync(x => x.Id == id);
        }



    



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var productItem = await _db.Products.FindAsync(id);
            if (productItem == null)
            {
                return NotFound();
            }

            _db.Products.Remove(productItem);
            await _db.SaveChangesAsync();

            return NoContent();
        }




    }





}



