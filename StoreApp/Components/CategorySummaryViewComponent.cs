// using Microsoft.AspNetCore.Mvc;
// using Repositories;
// using Services.Contracts;

// namespace StoreApp.Components
// {
//     public class CategorySummaryViewComponent : ViewComponent
//     {
//         private readonly IServiceManager _manager;

//         public CategorySummaryViewComponent(IServiceManager manager)
//         {
//            _manager = manager;
//         }
//         public IViewComponentResult Invoke()
//         {
//             var categories = _manager.CategoryService.GetAllCategories(false);
//             return View(categories);
//         }
        
//     }
// }