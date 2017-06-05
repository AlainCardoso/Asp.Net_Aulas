using System;
using System.Collections.Generic;
using System.Linq;
using AvaliacaoAspNet.Models;
using System.Web;

namespace AvaliacaoAspNet.Controllers
{
    public class BaseController
    {
        static protected BaseDadosContainer2 contexto = new BaseDadosContainer2();
    }
}