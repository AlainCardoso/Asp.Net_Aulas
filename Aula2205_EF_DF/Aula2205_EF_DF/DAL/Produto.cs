//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aula2205_EF_DF.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Categoria_Id { get; set; }
    
        public virtual Categoria Categoria { get; set; }
    }
}
