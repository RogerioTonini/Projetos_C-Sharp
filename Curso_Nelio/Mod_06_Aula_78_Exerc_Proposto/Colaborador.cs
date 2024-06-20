using System.Globalization;

namespace Mod_06_Aula_78_Exerc_Proposto
{
    class Colaborador
    {
		#region ===> Atributos <===
		public int ID { get; set; }
		public string NOME_COLAB { get; set; }
		public double VLR_SALAR { get; private set; }
		#endregion

		#region ===> Construtores <===
		public Colaborador(int id, string nome_colab, double vlr_salar)
		{
			ID = id;
			NOME_COLAB = nome_colab;
			VLR_SALAR = vlr_salar;
		}
		#endregion

		#region ==> Métodos Personalizados <==
		public void AumentoSalario(double percentage)
		{
			VLR_SALAR += (VLR_SALAR * ( percentage / 100 ));
		}
        #endregion

        public override string ToString()
        {
			return ID + ", " + NOME_COLAB + ", " + VLR_SALAR.ToString("F2", CultureInfo.InvariantCulture);
		}
    }
}
