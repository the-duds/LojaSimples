using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSimples.Domain.Entities.Base
{
    public class Base : IBase
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }


    }
}
