using CRUD_NESS_ALAN.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Index = System.Index;

namespace CRUD_NESS_ALAN.Controllers
{
    public class ViewBag : Controller
    {

        private readonly Contexto _contexto;
        private object lista;

        public ViewBag(Contexto contexto)
        {
            _contexto = contexto;
        }



        public ViewBag(Contexto contexto, object lista) : this(contexto)
        {
            this.Lista = lista;
        }

        private lista lista1 { get; set; }

        public object Lista { get => lista; set => lista = value; }

        private ViewBag();
        //"return private ViewBag(lista)";
    }

    [HttpGet]
    public IActionResult Create()
    {
        object personagem = ;

        return ((IActionResult)personagem);
    }

    [HttpPost]
    public IActionResult Create(ViewBag personagem)
    {

        {
            //_contexto.Personagem.Add(personagem)
            //_contexto.SaveChanges();

             return (personagem);
        }
    }


    [HttpGet]
    public IActionResult Edit(int Id)
    {
        var personagem = ;


        return (personagem);

    }

    [HttpPost]
    public IActionResult Edit(ViewBag personagem)
    {
        var ModelState = ;
        if (ModelState.IsValid)
        {
            //_contexto.Personagem.Update(personagem)
            //_contexto.SaveChanges();

            return Index
        //;
        ; }
        else
        {

            return ((IActionResult)personagem);
        }

    }

    [HttpGet]
    public IActionResult Delete(int Id)
    {
        var personagem = ;

        return (personagem);

    }

    [HttpPost]
    public IActionResult Delete(ViewBag _personagem)
    {
        object personagem = ; } } // _contexto.Personagem.Find(Id);
           #if personagem 
            {
                //_contexto.Personagem.Remove(personagem);
                //_contexto.SaveChanges();

            object RedirectToAction = null;
            return redirectToAction["index"];
            }
            return (personagem);

        }


        [HttpGet]
        public IActionResult Details(int Id)
        {
            var personagem = Personagem.Find(Id);
            
            return (personagem);

        }

        public void CarregaTipoPoder()
        {

            var ItensTipoPoder = new List<SelectListItem>
            { 
                ,new SelectList(1="Água")
                ,new SelectList(2="Fogo")
                ,new SelectList(3="Vento")
                ,new SelectList(4="Terra")
            };
        
    View.TipoPoder = ItensTipoPoder;

        }
    }    
#endif