
using System;
using System.Collections.Generic;
using System.Linq;

namespace tarefa.Models
{
    public class CadastroRepository
    {
         public static List<Cadastro> cad1 = new List<Cadastro>();
    
        public CadastroRepository()
        {           
        }

        public void Create(Cadastro cad)
        {
            cad1.Add(cad);
        }
        public List<Cadastro> GetAll()
        {
            return cad1;
        }

         public List<Cadastro> GetAbertas()
        {
            return cad1.Where(x=>x.percent < 100).ToList();
        }

         public List<Cadastro> GetPorcento()
        {
            return cad1.Where(x=>x.percent == 100).ToList();
        }
        
        public Cadastro GetById(int id)
        {
            return cad1.Find(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            cad1.Remove(GetById(id));

        }

        public void Dell(int percent){
            cad1.Remove(GetByPercent(percent));
        }

        private Cadastro GetByPercent(int percent)
        {
            throw new NotImplementedException();
        }

        public void Update(Cadastro cad)
        {
            var index = cad1.FindIndex(x=>x.id == cad.id);
            cad1[index].prioridade = cad.prioridade;
            cad1[index].nameTarefa = cad.nameTarefa;
            cad1[index].data = cad.data;
            cad1[index].percent = cad.percent;
        }

        
    }
    }