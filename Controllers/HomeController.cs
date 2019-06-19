using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_huellas.Models;

namespace proyecto_huellas.Controllers
{
    public class HomeController : Controller
    {
      private HuellasContext _context;

        public HomeController(HuellasContext c) {
            _context = c;
        }





        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PublicarAdopcion()
        {
          return View();
        }
[HttpPost]
        public IActionResult PublicarAdopcion(P_Adopcion a)
        {
          if(ModelState.IsValid){
            _context.Add(a);
            _context.SaveChanges();
            return RedirectToAction("Index");
          }
          
          return View(a);
        }
        public IActionResult Adoptame()
        {
         

           var noticias = _context.Adopcion.OrderByDescending(x => x.Id).ToList();

            ViewBag.noticias = noticias;
            return View();
          
        }
//mascotas Perdidas

        public IActionResult PublicarPerdido()
        {     
          return View();
        }
        [HttpPost]
        public IActionResult PublicarPerdido(P_Perdidos a)
        {
          if(ModelState.IsValid){
            _context.Add(a);
            _context.SaveChanges();
            return RedirectToAction("Index");
          }
          
          return View(a);
        }
        public IActionResult Perdidos()
        {
        var noticias = _context.P_Perdidos.OrderByDescending(x => x.Id).ToList();

            ViewBag.noticias = noticias;
          return View();
        }
        //Usuario
        public IActionResult RegistroUsuario()
        {
          return View();
        }
        
        [HttpPost]
        public IActionResult RegistroUsuario(Usuario a)
        {
          if(ModelState.IsValid){
            _context.Add(a);
            _context.SaveChanges();
            return RedirectToAction("Index");
          }
          
          return View(a);
        }
        
        public IActionResult IniciarSession()
        {
          
          return View();
        }
      //Promociones

public IActionResult P_Promociones()
{

  return View();
}


[HttpPost]
public IActionResult P_Promociones(P_Veterinarias a)
{
          if(ModelState.IsValid){
            _context.Add(a);
            _context.SaveChanges();
            return RedirectToAction("Index");
          }
          
          return View(a);
  
}
public IActionResult Promociones()
        {
            var noticias = _context.P_Veterinarias.OrderByDescending(x => x.Id).ToList();

            ViewBag.noticias = noticias;
            return View();       
}






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
