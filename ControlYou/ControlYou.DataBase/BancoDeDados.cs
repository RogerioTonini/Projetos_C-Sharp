using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace ControlYou.DataBase
{
	public class BancoDeDados
	{
		#region *--- Públicos ---*
		private string _stringConexaoServidorSQL = string.Empty;
		private SqlConnection _servidorSQL;
		#endregion

		//	#region *--- Construtor ---*
		//		public BancoDeDados()
		//		{
		//			try
		//			{
		//				if (Config.SQLStringConexao == string.Empty);
		//				{
		//					ConexaoDB cn = new ConexaoDB();
		//					cn.MontaStringConexao();
		//				}
		//				StringConexaoServidorSQL = Config.SQLStringConexao;
		//			}
		//			catch (Exception erro)
		//			{
		//				throw new ApplicationException(erro.Message);
		//			}
		//		}
		//	#endregion

		//	#region *--- Métodos ---*
		//		public bool Conecta()
		//		{
		//			Log.Escreve("Conectando no Servidor SQL.");

		//			try
		//			{
		//				_servidorSQL = new SqlConnection(_stringConexaoServidorSQL);
		//				_servidorSQL.Open();
		//				Log.Escreve("Servidor SQL conectado com sucesso.");
		//				return true;
		//			}
		//			catch (Exception erro)
		//			{
		//				Log.Escreve("*** Erro ao tentar se conectar no Servidor SQL. " + erro.Message.ToString() + " ***");
		//			}
		//			return false;
		//		}

		//		public bool Desconecta();
		//		{
		//			_servidorSQL.Close();
		//			return true;
		//		}			
		//	#endregion

		//	#region *--- Funções ---*
		//		public bool ExecutaComandoSQL(string ComandoSQL, ref SqlDataReader DataReader)
		//		{
		//			try
		//			{
		//				SqlConnection servidorSQL = new SqlConnection(_stringConexaoServidorSQL);
		//				servidorSQL.Open();
		//			}
		//			catch (Exception erro)
		//			{
		//				if (servidorSQL != null)
		//				{
		//					try
		//					{
		//						servidorSQL.Close();
		//					}
		//					catch
		//					{
		//					}
		//					servidorSQL.Dispose();
		//					servidorSQL = null;
		//				}
		//				trow new ApplicationException("Problemas ao reconectar o Bando de Dados : " + erro.Message);
		//			}

		//			SqlCommand comandoSQL;

		//			bool retorno = false;

		//			try
		//			{
		//				if (servidorSQL != null && servidorSQL.State != ConnectionState.Closed)
		//				{
		//					comandoSQL = new SqlCommand(ComandoSQL, servidorSQL);
		//					DataReader = comandoSQL.Execute.Reader();
		//					retorno = DataReader.HasRows;

		//					if (servidorSQL != null)
		//					{
		//						servidorSQL.Close();
		//						servidorSQL.Dispose();
		//					}
		//				}
		//			}
		//			catch (Exception erro)
		//			{
		//				string mensagemErro = erro.Message;

		//				if (mensagemErro.IndexOf("deadlocked") > 0)
		//					mensagemErro = "Banco de Dados ocupado ...";

		//				if (servidorSQL != null)
		//				{
		//					servidorSQL.Close();
		//					servidorSQL.Dispose();
		//				}
		//				retorno = false;
		//			}
		//			return retorno;
		//		}

		//		public bool ExecutaComandoSQL(string ComandoSQL)
		//		{
		//			try
		//			{
		//				SqlConnection servidorSQL = new SqlConnection(_stringConexaoServidorSQL);
		//				servidorSQL.Open();
		//			}
		//			catch (Exception erro)
		//			{
		//				if (servidorSQL != null)
		//				{
		//					try
		//					{
		//						servidorSQL.Close();
		//					}
		//					catch
		//					{
		//					}
		//					servidorSQL.Dispose();
		//					servidorSQL = null;
		//				}
		//				trow new ApplicationException("Problemas ao reconectar o Bando de Dados : " + erro.Message);
		//			}

		//			SqlCommand comandoSQL;

		//			bool retorno = false;

		//			try
		//			{
		//				if (servidorSQL != null && servidorSQL.State != ConnectionState.Closed)
		//				{
		//					comandoSQL = new SqlCommand(ComandoSQL, servidorSQL);
		//					comandoSQL.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
		//					int linhasAfetadas = comandoSQL.ExecuteNonQuery();

		//					if ( (linhasAfetadas > 0) || (comandoSQL.Parameters["@result"].Value.ToString() == "0") )
		//						retorno = true;

		//					if (servidorSQL != null)
		//					{
		//						servidorSQL.Close();
		//						servidorSQL.Dispose();
		//					}
		//				}
		//			}
		//			catch (Exception erro)
		//			{
		//				string mensagemErro = erro.Message;

		//				if (mensagemErro.IndexOf("deadlocked") > 0)
		//					mensagemErro = "Banco de Dados ocupado ...";

		//				if (servidorSQL != null)
		//				{
		//					servidorSQL.Close();
		//					servidorSQL.Dispose();
		//				}
		//				retorno = false;
		//			}
		//			servidorSQL = null;
		//			return retorno;
		//		}

		//		public bool ExecutaComandoSQL(string ComandoSQL, ref Int64 Index_)
		//		{
		//			try
		//			{
		//				SqlConnection servidorSQL = new SqlConnection(_stringConexaoServidorSQL);
		//				servidorSQL.Open();
		//			}
		//			catch (Exception erro)
		//			{
		//				if (servidorSQL != null)
		//				{
		//					try
		//					{
		//						servidorSQL.Close();
		//					}
		//					catch
		//					{
		//					}
		//					servidorSQL.Dispose();
		//					servidorSQL = null;
		//				}
		//				trow new ApplicationException("Problemas ao reconectar o Bando de Dados : " + erro.Message);
		//			}

		//			SqlCommand comandoSQL;

		//			bool retorno = false;

		//			try
		//			{
		//				if (servidorSQL != null && servidorSQL.State != ConnectionState.Closed)
		//				{
		//					comandoSQL = new SqlCommand(ComandoSQL, servidorSQL);
		//					comandoSQL.Parameters.Add("@index", SqlDbType.Decimal).Direction = ParameterDirection.Output;
		//					comandoSQL.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
		//					int linhasAfetadas = comandoSQL.ExecuteNonQuery();

		//					if ( (linhasAfetadas > 0) || (comandoSQL.Parameters["@result"].Value.ToString() == "0") )
		//						Index_ = Int64.Parse( comandoSQL.Parameters["@result"].Value.ToString() );
		//						retorno = true;

		//					if (servidorSQL != null)
		//					{
		//						servidorSQL.Close();
		//						servidorSQL.Dispose();
		//					}
		//				}
		//			}
		//			catch (Exception erro)
		//			{
		//				string mensagemErro = erro.Message;

		//				if (mensagemErro.IndexOf("deadlocked") > 0)
		//					mensagemErro = "Banco de Dados ocupado ...";

		//				if (servidorSQL != null)
		//				{
		//					servidorSQL.Close();
		//					servidorSQL.Dispose();
		//				}
		//				retorno = false;
		//			}
		//			servidorSQL = null;
		//			return retorno;
		//		}

		//		public SqlParameterCollection ExecutaStoreProcedureSQL(string NomeStoreProcedure, SqlParameter[] Parametros)
		//		{
		//			SqlConnection servidorSQL = null;

		//			try
		//			{
		//				servidorSQL = new SqlConnection(_stringConexaoServidorSQL);
		//				servidorSQL.Open();
		//			}
		//			catch (Exception erro)
		//			{
		//				if (servidorSQL != null)
		//				{
		//					try
		//					{
		//						servidorSQL.Close();
		//					}
		//					catch
		//					{
		//					}
		//					servidorSQL.Dispose();
		//					servidorSQL = null;
		//				}
		//				trow new ApplicationException("Problemas ao reconectar o Bando de Dados : " + erro.Message);
		//			}

		//			SqlCommand comandoSQL;

		//			SqlParameterCollection retorno = null;

		//			try
		//			{
		//				if (servidorSQL != null && servidorSQL.State != ConnectionState.Closed)
		//				{
		//					comandoSQL = new SqlCommand(ComandoSQL, servidorSQL);
		//					comandoSQL.CommandTimeout = 150;
		//					comandoSQL.CommandType = CommandType.StoredProcedure;

		//					if ( Parametros != null )
		//					{
		//						for (int indice = 0; indice < Parametros.Lenght; indice++)
		//						{
		//							if ( Parametros[indice].Direction == ParameterDirection.Output )
		//							{
		//								SqlParameter sqlparameter = comandoSQL.Parameters.Add(Parametros[indice].ParameterName, Parametros[indice].SqlDbType);
		//								sqlparameter.Direction =  Parametros[indice].Direction;
		//								sqlparameter.Value = Parametros[indice].Value;
		//								sqlparameter.Size = Parameter[indice].Size;
		//							}
		//							else if ( Parametros[indice].Direction == ParameterDirection.Input )
		//							{
		//								comandoSQL.Parameters.Add(Parametros[indice].ParameterName, Parametros[indice].SqlDbType).Value = Parametros[indice].Value;
		//							}
		//						}
		//					}

		//					comandoSQL.ExecuteNonQuery();
		//					retorno = comandoSQL.Parameters;

		//					if (servidorSQL != null)
		//					{
		//						servidorSQL.Close();
		//						servidorSQL.Dispose();
		//					}
		//				}
		//			}
		//			catch (Exception erro)
		//			{
		//				string mensagemErro = erro.Message;

		//				if (mensagemErro.IndexOf("deadlocked") > 0)
		//					mensagemErro = "Banco de Dados ocupado ...";

		//				if (servidorSQL != null)
		//				{
		//					servidorSQL.Close();
		//					servidorSQL.Dispose();
		//				}
		//				retorno = null;

		//				throw  new ApplicationException(mensagemErro);
		//			}
		//			servidorSQL = null;
		//			return retorno;
		//		}

		//		public DataTable ExecutaDados(string NomeStoredProcedure, SqlParameter[] Parametros)
		//		{
		//			DataTable objReturn = null;
		//			SqlConnection servidorSQL = null;

		//			try
		//			{
		//				servidorSQL = new SqlConnection(_stringConexaoServidorSQL);
		//				servidorSQL.Open();
		//			}
		//			catch (Exception erro)
		//			{
		//				if (servidorSQL != null)
		//				{
		//					try
		//					{
		//						servidorSQL.Close();
		//					}
		//					catch
		//					{
		//					}
		//					servidorSQL.Dispose();
		//					servidorSQL = null;
		//				}
		//				trow new ApplicationException("Problemas ao reconectar o Bando de Dados : " + erro.Message);
		//			}

		//			SqlCommand comandoSQL;

		//			try
		//			{
		//				if (servidorSQL != null && servidorSQL.State != ConnectionState.Closed)
		//				{
		//					comandoSQL = new SqlCommand(ComandoSQL, servidorSQL);
		//					comandoSQL.CommandType = CommandType.StoredProcedure;
		//					comandoSQL.Parameters.Clear();

		//					if ( Parametros != null )
		//					{
		//						for (int indice = 0; indice < Parametros.Lenght; indice++)
		//							comandoSQL.Parameters.Add(Parametros[indice]);
		//					}

		//					SqlDataAdapter objDtAdpt = new SqlDataAdapter(comandoSQL);
		//					DataTable objDataTable = new DataTable();

		//					objDtAdpt.Fill(objDataTable);
		//					objReturn = objDataTable;

		//					objDtAdpt = null;
		//					objDataTable = null;

		//					if (servidorSQL != null)
		//					{
		//						servidorSQL.Close();
		//						servidorSQL.Dispose();
		//					}
		//				}
		//			}
		//			catch (Exception erro)
		//			{
		//				if (servidorSQL != null)
		//				{
		//					servidorSQL.Close();
		//					servidorSQL.Dispose();
		//				}
		//				objReturn = null;

		//				throw  new ApplicationException(mensagemErro);
		//			}
		//			return objReturn;
		//		}

		//		public bool ExecutaUpdateSQL(string NomeStoreProcedure, SqlParameter[] Parametros)
		//		{
		//			SqlConnection servidorSQL = null;

		//			bool retorno = false;

		//			try
		//			{
		//				try
		//				{
		//					servidorSQL = new SqlConnection(_stringConexaoServidorSQL);
		//					servidorSQL.Open();
		//				}
		//				catch (Exception erro)
		//				{
		//					if (servidorSQL != null)
		//					{
		//						try
		//						{
		//							servidorSQL.Close();
		//						}
		//						catch
		//						{
		//						}
		//						servidorSQL.Dispose();
		//						servidorSQL = null;
		//					}
		//					trow new ApplicationException("Problemas ao reconectar o Bando de Dados : " + erro.Message);
		//				}

		//				SqlCommand comandoSQL;

		//				if (servidorSQL != null && servidorSQL.State != ConnectionState.Closed)
		//				{
		//					comandoSQL = new SqlCommand(ComandoSQL, servidorSQL);
		//					comandoSQL.CommandType = CommandType.StoredProcedure;
		//					comandoSQL.Parameters.Clear();

		//					for (int indice = 0; indice < Parametros.Lenght; indice++)
		//						comandoSQL.Parameters.Add(Parametros[indice]);

		//					comandoSQL.ExecuteNonQuery();

		//					if (servidorSQL != null)
		//					{
		//						servidorSQL.Close();
		//						servidorSQL.Dispose();
		//					}
		//				}
		//				retorno = true;
		//			}
		//			catch (Exception ex)
		//			{
		//				if (servidorSQL != null)
		//				{
		//					servidorSQL.Close();
		//					servidorSQL.Dispose();
		//				}						
		//				trow new ApplicationException(erro.Message);
		//			}
		//			return retorno;
		//		}
		//	#endregion

		//	#region *--- Propriedades ---*
		//		public string StringConexaoServidorSQL
		//		{
		//			get
		//			{
		//				return _stringConexaoServidorSQL;
		//			}
		//		}
		//	#endregion
		//}

		//public class ConexaoDB
		//{
		//	public void MontaStringConexao()
		//	{
		//		string ws = string.Empty;
		//		string ambiente = "P";

		//		// Acesso a área de Produção
		//		Config.SQLStringConexao = "Data Source=192.192.192.192;Initial Catalog=DB_SAFRA_DAD;User ID=xxx;Password=123456"

		//		#if DEBUG
		//			// Acesso a área de Desenvolvimento
		//			Config.SQLStringConexao = "Data Source=192.192.192.192;Initial Catalog=DB_SAFRA_DAD;User ID=xxx;Password=123456"
		//			string teste = "123";
		//			return;
		//		#endif

		//		try
		//		{
		//			System.Net.ServicePointManager.ServerCertificaterValidationCallback += (se, cert, chain, sslerror) => { return true; }

		//			ws_dblib.Service ws_mblib = new ws_dblib.Service();

		//			try
		//			{
		//				var appConfig = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
		//				ws = appConfig.AppSettings.Settings["ws_conexao"].Value;
		//				ambiente = appConfig.AppSettings.Settings["ambiente"].Value;
		//				ws_mblib.Url = ws;
		//			}
		//			catch
		//			{
		//			}

		//			if (ambiente == "P")
		//				Config.SQLStringConexao = "Data Source=192.192.192.192;Initial Catalog=DB_SAFRA_DAD;User ID=xxx;Password=123456"
		//			else
		//				Config.SQLStringConexao = "Data Source=192.192.192.192;Initial Catalog=DB_SAFRA_DAD;User ID=xxx;Password=123456"

		//			byte[] bstrconexao = ws_mblib.StringConexao("DAD");

		//			if ( bstrconexao.Lenght > 0 )
		//				Config.SQLStringConexao = Enconding.ASCII.GetString(bstrconexao);

		//		}
		//		catch (Exception erro)
		//		{
		//			throw new ApplicationException("Não foi possível obter parâmetro de conexão. Usar parâmetro [" + ambiente + "]. \n URL: " 
		//				+ ws + "Erro: " + erro.Message);
		//		}
		//	}
	}
}