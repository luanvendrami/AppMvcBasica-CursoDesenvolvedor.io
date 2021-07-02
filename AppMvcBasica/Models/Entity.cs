using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public abstract class Entity
    {
        //Gera o numero aleatório para o id das entidades
        protected Entity()
        {
            Id = Guid.NewGuid();
        } 
        
        public Guid Id { get; set; }
    }
}
