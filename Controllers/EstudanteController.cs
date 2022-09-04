using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    //public static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>();


    public static List<EstudanteViewModel> estudantes = 
    new List<EstudanteViewModel> {
        new EstudanteViewModel(1, "Shrek", "Rua Far", true),
        new EstudanteViewModel(2, "Fiona", "Rua Away", true),
        new EstudanteViewModel(3, "King", "Rua Tão", false),
        new EstudanteViewModel(4, "Queen", "Rua Distante", false)

    };
    
    public IActionResult Index ()
    {
        return View(estudantes);
    }

    public IActionResult Show (int id)
    {
        return View(estudantes[id-1]);
    }
}