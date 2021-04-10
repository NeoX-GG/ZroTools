using System.Collections.Generic;
using ToolLibrary.Entities;

namespace ToolLibrary.Caches
{
    public class ItemToolCache
    {
        public static Dictionary<string, string> Names = new();

        public static List<ItemEntity> Items = new();
    }
}
