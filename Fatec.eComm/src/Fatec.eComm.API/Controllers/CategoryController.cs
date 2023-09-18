using Fatec.eComm.Domain.Models.CategoryModel;
using Fatec.eComm.Domain.ViewModels;
using Fatec.eComm.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Fatec.eComm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region OLD - CONTROLLER CATEGORY
        /*
         
        private readonly ApplicationDataContext _applicationDataContext;

        public CategoryController(ApplicationDataContext applicationDataContext)
        {
            _applicationDataContext = applicationDataContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryViewModel category)
        {
            var repo = new RepositoryBase(_applicationDataContext);
            repo.Add(category);

            await _applicationDataContext.SaveChangesAsync();

            return Ok("Sucesso");
        } 
         */
        #endregion


        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CategoryViewModel request)
        {
            // Map ViewModel to Domain Model
            var category = new Category
            {
                Id= Guid.NewGuid(),
                Description= request.Description,
                IsActive= request.IsActive,
            };

             _categoryRepository.Add(category);

            // Domain model to ViewModel
            var response = new CategoryViewModel
            {
                Id = category.Id,
                Description = category.Description,
                IsActive= category.IsActive
            };

            return Ok(response);
        }

        // GET: https://localhost:7107/api/Category
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAll();

            // Map Domain model to DTO

            //var response = new List<CategoryDto>();
            //foreach (var category in caterogies)
            //{
            //    response.Add(new CategoryDto
            //    {
            //        Id = category.Id,
            //        Name = category.Name,
            //        UrlHandle = category.UrlHandle
            //    });
            //}

            return Ok(categories);
        }
    }
}
