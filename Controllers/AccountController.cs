
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using proyecto_huellas.Models;


namespace proyecto_huellas.Controllers
{
    public class AccountController : Controller
    {
        private HuellasContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        public AccountController(
            HuellasContext c,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim
        ) {
            _context = c;
            _userManager = um;
            _signInManager = sim;
        }

        public IActionResult Registro() {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(RegistroViewModel vm) {
            if (ModelState.IsValid) {
                var user = new IdentityUser();
                user.UserName = vm.Usuario;
                user.Email = vm.Email;

                var resultado = _userManager.CreateAsync(user, vm.Password);

                if (resultado.Result == IdentityResult.Success) {
                    return RedirectToAction("index", "home");
                }
                else {
                    foreach (var error in resultado.Result.Errors) {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            
            return View(vm);
        }

        public IActionResult Login() {
            return View();
        }

        public IActionResult Logout() {
            _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel vm) {
            if (ModelState.IsValid) {
                var resultado = _signInManager.PasswordSignInAsync(vm.Usuario, vm.Password, false, false);
            
                if (resultado.Result.Succeeded) {
                    return RedirectToAction("index", "home");
                }
                else {
                    ModelState.AddModelError("", "Usuario o contraseña incorrectos");
                }
            }

            return View(vm);
        }

        public IActionResult ChangePassword() {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel vm) {
            if (ModelState.IsValid) {
                var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
                var resultado = _userManager.ChangePasswordAsync(user, vm.PasswordActual, vm.PasswordNuevo);

                if (resultado.Result == IdentityResult.Success) {
                    return RedirectToAction("index", "home");
                }
                else {
                    foreach (var error in resultado.Result.Errors) {
                        ModelState.AddModelError("", error.Description);
                    }
                }
               
            }
            
            return View(vm);
        }
    }
}