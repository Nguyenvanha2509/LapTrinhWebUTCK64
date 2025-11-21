using lab1.Models;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading.Tasks;

public class RenderViewComponent : ViewComponent
{
    private List<MenuItem> MenuItems;

    public RenderViewComponent()
    {
        // Giả lập dữ liệu menu (có thể load từ DB sau này)
        MenuItems = new List<MenuItem>()
        {
            new MenuItem { Id = 1, Name = "Branches", Link = "/Branches/List" },
            new MenuItem { Id = 2, Name = "Students", Link = "/Student/Index" },
            new MenuItem { Id = 3, Name = "Subjects", Link = "/Subjects/List" },
            new MenuItem { Id = 4, Name = "Courses", Link = "/Courses/List" }
        };
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View("RenderLeftMenu", MenuItems);
    }
}
