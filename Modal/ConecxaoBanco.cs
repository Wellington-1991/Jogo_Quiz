using System.Data.SqlClient;
using System.Data;
namespace Jogo_Quiz.Modal
{
	//public class ConecxaoBanco
	//{
	//	public void Conectar()
	//	{
	//		string connectionString = "Server=localhost; Initial Catalog=Quiz; Integrated Security=true";

	//		DataTable dt = new DataTable();

	//		using (SqlConnection connection = new SqlConnection(connectionString))
	//		{
	//			string sqlQuery = "select * from Jogador";

	//			using (SqlCommand command = new SqlCommand(sqlQuery, connection))
	//			{
	//				connection.Open();

	//				using (SqlDataReader reader = command.ExecuteReader())
	//				{


	//					for (int i = 0; i < reader.FieldCount; i++)
	//					{
	//						dt.Columns.Add(reader.GetName(i));
	//					}

	//					while (reader.Read())
	//					{
	//						DataRow row = dt.NewRow();
	//						for (int i = 0; i < reader.FieldCount; i++)
	//						{
	//							row[i] = reader[i];
	//						}
	//						dt.Rows.Add(row);
	//					}
	//					Console.WriteLine(dt.ToString());
	//				}
	//			}
	//		}
	//	}
	//}
}
