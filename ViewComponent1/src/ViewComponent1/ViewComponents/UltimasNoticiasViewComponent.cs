using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponent1.Models;

namespace ViewComponent1.ViewComponents
{
    public class UltimasNoticiasViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(int quant)
        {
            List<Noticia> noticias = await popularLista();
            return View(noticias.Take(quant));
        }

        private async static Task<List<Noticia>> popularLista()
        {
            await Task.Delay(10000);

            return new List<Noticia>()
            {
                new Noticia() { titulo = "Acontece coisa extraordinaria em algum lugar" },
                new Noticia() { titulo = "Acontece coisa extraordinaria em algum lugar" },
                new Noticia() { titulo = "Acontece coisa extraordinaria em algum lugar" },
                new Noticia() { titulo = "Acontece coisa extraordinaria em algum lugar" }
            };
        }


    }
}
