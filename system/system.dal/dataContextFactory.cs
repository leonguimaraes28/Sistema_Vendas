using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.dal
{
    public class dataContextFactory//a classe tem que ser publica
    {
        private static systemDataContext dataContext;//a função que retorna a conexão com a bd
        public static systemDataContext DataContext{
            get
            {
                if (dataContext == null)//se a conexão não foi criada
                    dataContext = new systemDataContext();//cria a conexão e retorna
                return dataContext;
            }
        }
    }
}
