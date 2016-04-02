using System;
using System.IO;
using System.Security;
using System.Data.SqlClient;

namespace LinguagemCS6
{
    class FiltrosException
    {
        static void Main(string[] args)
        {
            try
            {
                // algum código
                throw new Exception("tratar erro");
            }
            catch (Exception ex) when (ex.GetType() == typeof(SqlException))
            {
                Console.WriteLine("erro customizado do SQL");
            }
            catch (Exception ex) when (ex.Message.Equals("tratar erro", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("erro customizado da mensagem");
            }
            catch (Exception ex) when (ex is SecurityException || ex is IOException)
            {
                Console.WriteLine("erro de segurança ou IO");
            }
            catch (Exception)
            {
                Console.WriteLine("erro genérico");
            }
        }
    }
}
