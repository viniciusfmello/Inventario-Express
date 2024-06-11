using Microsoft.Data.SqlClient;
using System.Data;
using WebApplication1;
using WebApplication1.Entities;

namespace InventarioExpressTests
{
	[TestClass]
	public class InventarioExpressTests
	{
		[TestMethod]
		public void TesteAbrirConexaoBancoDeDados()
		{
			var database = new Database();

			 SqlConnection banco = database.conectionOpen();
			Assert.IsNotNull(banco);
		}

		[TestMethod]
		public void TesteFecharConexaoBancoDeDados()
		{
			var database = new Database();

			SqlConnection connection = database.conectionOpen();
			connection.Close();
			Assert.AreEqual(ConnectionState.Closed, connection.State);
		}

		[TestMethod]
		public void TesteLoginValido()
		{
			bool valido = Auxiliar.isValidLogin("1", "1");
			Assert.IsTrue(valido);
		}

		[TestMethod]
		public void TesteLoginInvalido()
		{
			bool valido = Auxiliar.isValidLogin("Invalido", "Invalido");
			Assert.IsFalse(valido);
		}
	}
}