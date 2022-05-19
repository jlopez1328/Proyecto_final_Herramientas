using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Proyecto_final_Herramientas.Helpers
{
	public static class Settings
	{
		private static ISettings AppSettings => CrossSettings.Current;

		private const string _usuarios = "Usuarios";

		private static readonly string _stringDefault = "";


		public static string Usuarios
		{
			get => AppSettings.GetValueOrDefault(_usuarios, _stringDefault);
			set => AppSettings.AddOrUpdateValue(_usuarios, value);
		}

	}
}