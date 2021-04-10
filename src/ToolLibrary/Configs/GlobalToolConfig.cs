using ToolLibrary.Enums;

namespace ToolLibrary.Configs
{
    public class GlobalToolConfig
    {
		public static string MainDirectory = "./Files\\";

		public static string TxtDirectory = MainDirectory + "Txt\\";

		public static string DatDirectory = MainDirectory + "Dat\\";

		public static string ImagesDirectory = MainDirectory + "Images\\";

		public static RegionType Region { get; set; } = RegionType.es;

		public static char Separation = '\t';
	}
}
