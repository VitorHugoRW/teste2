using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class CarroService : ICarroService
    {
        private IRepositoryBase<Carro> _repository { get; set; }
        public CarroService(IRepositoryBase<Carro> repository)
        {
            _repository = repository;
        }

        public List<Carro> listaCarros()
        {
            return _repository.Query(x => 1 == 1).ToList();

        }
        public void Salvar(Carro obj)
        {
            if (String.IsNullOrEmpty(obj.nome_carros))
            {
                throw new Exception("Informe a Marca do automóvel");
            }
            _repository.Save(obj);
            _repository.SaveChanges();
        }
        public void Remover(Guid id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
        }
        public Carro BuscaPorId(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("Informe o id!");
            }
            var obj = _repository.Query(x => x.Id == id).FirstOrDefault();
            return obj;
        }
    }
}

