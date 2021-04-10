using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolLibrary.Enums;

namespace ToolLibrary.Configs
{
    public class ItemToolConfig
    {
        public static string DatFile = GlobalToolConfig.DatDirectory + "Item.dat";

        public static string TxtFile
        {
            get
            {
                return GlobalToolConfig.TxtDirectory + $"_code_{GlobalToolConfig.Region}_Item.txt";
            }
        }

        public static string ImgDir = GlobalToolConfig.ImagesDirectory + "NSipData\\";
    }
}
