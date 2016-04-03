using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponent1.Models;

namespace ViewComponent1.ViewComponents
{
    public class ProdutosPromocaoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int qtde)
        {
            var prods = new List<Produto>() {
                new Produto() { Nome="Jaca", Preco=1 },
                new Produto() { Nome="leite", Preco=20 },
                new Produto() { Nome="pao", Preco=10 },
                new Produto() { Nome="Oleo", Preco=8 },
                new Produto() { Nome="Maracujá", Preco=7 },
                new Produto() { Nome="Ovo", Preco=3 },
                new Produto() { Nome="Manga", Preco=4 },
            };
            return View("Default", prods.Take(qtde));
        }
    }
}
