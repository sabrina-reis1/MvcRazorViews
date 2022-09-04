using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;
namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{

    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Shrek", "Far Street", true),
        new EstudanteViewModel(2, "Fiona", "Away Street"),
        new EstudanteViewModel(3, "Donkey", "Rua Tão", false),
        new EstudanteViewModel(4, "Rumpelstiltskin", "Rua Distante", false)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id - 1]);
    }

}