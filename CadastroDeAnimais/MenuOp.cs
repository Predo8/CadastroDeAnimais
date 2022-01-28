using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAnimais
{
    class MenuOp
    {
        public string Menu()
        {
            return string.Format("================= PROGRAMA DE CADASTRO DE ANIMAIS =============" +
            "\nO que você deseja fazer?" +
            "\n1 - Cadastrar um novo animal" +
            "\n2 - Excluir algum registro" +
            "\n3 - Listar todos os gatos" +
            "\n4 - Listar todos os cachorros" +
            "\n5 - Listar todas as raposas" +
            "\n6 - Listar todos os animais" +
            "\n7 - Sair");
        }

        public void MostrarMenu()
        {
            Console.WriteLine(Menu());
        }
    }
}
