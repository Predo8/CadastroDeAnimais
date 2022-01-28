using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAnimais
{
    public class FuncoesAnimais
    {
        private List<Animal> animais;
        private List<Gato> gatos;
        private List<Cachorro> cachorros;
        private List<Raposa> raposas;

        public List<Animal> Animais
        {
            get { return animais; }
        }
        public List<Gato> Gatos
        {
            get { return gatos; }
        }
        public List<Cachorro> Cachorros
        {
            get { return cachorros; }
        }
        public List<Raposa> Raposas
        {
            get { return raposas; }
        }

        public FuncoesAnimais()
        {
            animais = new List<Animal>();
            gatos = new List<Gato>();
            cachorros = new List<Cachorro>();
            raposas = new List<Raposa>();
        }

        public bool Excluir(string raca)
        {
            Gato g = Gatos.Find(x => x.Raca == raca);
            bool resultado = false;

            if (g == null)
            {
                resultado = gatos.Remove(g);
            }
            return resultado && gatos.Count > 0;
        }

        public List<Gato> Listar(string raca, decimal idade, decimal peso)
        {
            List<Gato> listaG = gatos.FindAll(x => x.Raca.Contains(raca));
            return listaG;
        }

        public List<Gato> ListarTodos()
        {
            List<Gato> listarG = gatos.ToList();
            return listarG;
        }
    }
}