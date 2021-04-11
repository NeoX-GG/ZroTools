using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolLibrary.Entities
{
    public class BCardEntity
    {
        public int BCardId { get; set; }

        public byte SubType { get; set; }

        public byte Type { get; set; }

        public int FirstData { get; set; }

        public int SecondData { get; set; }

        public int ThirdData { get; set; }

        public short? CardId { get; set; }

        public short? ItemVNum { get; set; }

        public short? SkillVNum { get; set; }

        public short? NpcMonsterVNum { get; set; }

        public byte CastType { get; set; }

        public bool IsLevelScaled { get; set; }

        public bool IsLevelDivided { get; set; }
    }
}
