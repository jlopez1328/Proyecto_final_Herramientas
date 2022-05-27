using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Proyecto_final_Herramientas.Helpers
{
	public static class Settings
	{
		private static ISettings AppSettings => CrossSettings.Current;

		private const string _usuarios = "Usuarios";
		private const string _productos = "Productos";

		private static readonly string _stringDefault = "";


		public static string Usuarios
		{
			get => AppSettings.GetValueOrDefault(_usuarios, _stringDefault);
			set => AppSettings.AddOrUpdateValue(_usuarios, value);
		}

		public static string Productos
        {
			get => AppSettings.GetValueOrDefault(_productos, _stringDefault);
			set => AppSettings.AddOrUpdateValue(_productos, value);
		}

	}
}