using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> CategoryGet()
        {
            return await _db.Categories.ToListAsync();
        }



        [HttpPost]
        public async Task<ActionResult<CategoryModelDTO>> CategoryAdd(CategoryModelDTO categoryDTO)
        {

            var category = new CategoryModel
            {
                CategoryName = categoryDTO.CategoryName
            };
            
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();

            
            return CreatedAtAction(nameof(CategoryAdd), new { id = category.Id }, category);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryModelDTO>> GetCategoryItem(int id)
        {
            var categoryItem = await _db.Categories.FindAsync(id);

            if (categoryItem == null)
            {
                return NotFound();
            }

            return ItemToDTO(categoryItem);
        }



        private static CategoryModelDTO ItemToDTO(CategoryModel categoryItem) =>
      new CategoryModelDTO
      {
          Id = categoryItem.Id,
          CategoryName = categoryItem.CategoryName
          
      };



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var categoryItem = await _db.Categories.FindAsync(id);
            if (categoryItem == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(categoryItem);
            await _db.SaveChangesAsync();

            return NoContent();
        }




    }
}
