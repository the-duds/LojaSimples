using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSimples.Domain.Entities.Base
{
    public interface IBase
    {
        Guid Id { get; set; }
    }
}
