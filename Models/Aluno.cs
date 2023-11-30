using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apsdotnet.Models
{
    public class Aluno : Pessoa
    {
        [Display(Name="Senha")]
        public string ?Password {set; get;}

        
    }   
}