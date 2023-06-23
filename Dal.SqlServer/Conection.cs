

namespace Dal.SqlServer
{
    public class Conection
    {
        public Conection()
        {
            Console.WriteLine("Conection");

            using (Context ctx = new Context()) {
                ctx.Produtos.ToList().ForEach(x => Console.WriteLine(x.Nome));
            }
        }
       

    }
}
