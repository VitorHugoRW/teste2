using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface ICarroService
    {
        List<Carro> listaCarros();
        void Salvar(Carro obj);
        Carro BuscaPorId(Guid id);
        void Remover(Guid id);

    }
}
