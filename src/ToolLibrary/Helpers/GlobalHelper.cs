using System.IO;
using System.Threading.Tasks;
using ToolLibrary.Configs;
using ToolLibrary.Enums;

namespace ToolLibrary.Helpers
{
    public class GlobalHelper
    {
        public static Task<bool> CheckIfDirectoryExist()
        {
            bool ret = true;
            if (!Directory.Exists(GlobalToolConfig.MainDirectory))
            {
                Directory.CreateDirectory(GlobalToolConfig.MainDirectory);
                ret = false;
            }

            if (!Directory.Exists(GlobalToolConfig.DatDirectory))
            {
                Directory.CreateDirectory(GlobalToolConfig.DatDirectory);
                ret = false;
            }

            if (!Directory.Exists(GlobalToolConfig.TxtDirectory))
            {
                Directory.CreateDirectory(GlobalToolConfig.TxtDirectory);
                ret = false;
            }

            if (!Directory.Exists(GlobalToolConfig.ImagesDirectory))
            {
                Directory.CreateDirectory(GlobalToolConfig.ImagesDirectory);
                ret = false;
            }

            if (!Directory.Exists(ItemToolConfig.ImgDir))
            {
                Directory.CreateDirectory(ItemToolConfig.ImgDir);
                ret = false;
            }

            return Task.FromResult(ret);
        }

        public static Task<int> GetEncoding()
        {
            RegionType Region = GlobalToolConfig.Region;
            if (Region == RegionType.cz || Region == RegionType.de || Region == RegionType.it)
            {
                return Task.FromResult(1250);
            }
            if (Region == RegionType.ru || Region == RegionType.pl)
            {
                return Task.FromResult(1251);
            }
            if (Region == RegionType.fr || Region == RegionType.uk || Region == RegionType.es)
            {
                return Task.FromResult(1252);
            }
            return Task.FromResult(-1);
        }
    }
}
