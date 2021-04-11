using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ToolLibrary.Configs;
using ToolLibrary.Enums;

namespace ToolLibrary.Entities
{
    public class ItemEntity
    {
        #region Properties

        public byte BasicUpgrade { get; set; }

        public byte CellonLvl { get; set; }

        public byte Class { get; set; }

        public short CloseDefence { get; set; }

        public byte Color { get; set; }

        public short Concentrate { get; set; }

        public byte CriticalLuckRate { get; set; }

        public short CriticalRate { get; set; }

        public short DamageMaximum { get; set; }

        public short DamageMinimum { get; set; }

        public byte DarkElement { get; set; }

        public short DarkResistance { get; set; }

        public short DefenceDodge { get; set; }

        public short DistanceDefence { get; set; }

        public short DistanceDefenceDodge { get; set; }

        public short Effect { get; set; }

        public int EffectValue { get; set; }

        public byte Element { get; set; }

        public short ElementRate { get; set; }

        public EquipmentType EquipmentSlot { get; set; }

        public byte FireElement { get; set; }

        public short FireResistance { get; set; }

        public byte Height { get; set; }

        public short HitRate { get; set; }

        public short Hp { get; set; }

        public short HpRegeneration { get; set; }

        public bool IsMinilandActionable { get; set; }

        public bool IsColored { get; set; }

        public bool Flag1 { get; set; }

        public bool Flag2 { get; set; }

        public bool Flag3 { get; set; }

        public bool Flag4 { get; set; }

        public bool Flag5 { get; set; }

        public bool Flag6 { get; set; }

        public bool Flag7 { get; set; }

        public bool Flag8 { get; set; }

        public bool Flag10 { get; set; }

        public bool IsConsumable { get; set; }

        public bool IsDroppable { get; set; }

        public bool IsHeroic { get; set; }

        public bool Flag9 { get; set; }

        public bool IsWarehouse { get; set; }

        public bool IsSoldable { get; set; }

        public bool IsTradable { get; set; }

        public byte ItemSubType { get; set; }

        public ItemType ItemType { get; set; }

        public long ItemValidTime { get; set; }

        public byte LevelJobMinimum { get; set; }

        public byte LevelMinimum { get; set; }

        public byte LightElement { get; set; }

        public short LightResistance { get; set; }

        public short MagicDefence { get; set; }

        public byte MaxCellon { get; set; }

        public byte MaxCellonLvl { get; set; }

        public short MaxElementRate { get; set; }

        public byte MaximumAmmo { get; set; }

        public int MinilandObjectPoint { get; set; }

        public short MoreHp { get; set; }

        public short MoreMp { get; set; }

        public short Morph { get; set; }

        public short Mp { get; set; }

        public short MpRegeneration { get; set; }

        public string NameZts { get; set; }

        public string DescriptionZts { get; set; }

        public long Price { get; set; }

        public short PvpDefence { get; set; }

        public byte PvpStrength { get; set; }

        public short ReduceOposantResistance { get; set; }

        public byte ReputationMinimum { get; set; }

        public long ReputPrice { get; set; }

        public byte SecondaryElement { get; set; }

        public byte Sex { get; set; }

        public byte Speed { get; set; }

        public byte SpType { get; set; }

        public InventoryType Type { get; set; }

        public short Vnum { get; set; }

        public short WaitDelay { get; set; }

        public byte WaterElement { get; set; }

        public short WaterResistance { get; set; }

        public byte Width { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public string Image { get; set; } = "0";

        public List<BCardEntity> BCards { get; set; } = new List<BCardEntity>();

        public bool IsAreaBegin { get; set; } = false;

        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public bool Flag11 { get; set; }
        public bool Flag12 { get; set; }
        public bool Flag13 { get; set; }

        #endregion

        public override string ToString()
        {
            char s = GlobalToolConfig.Separation;
            return $"{s}VNUM{s}{Vnum}{s}{Price}\n" +
                   $"{s}NAME{s}{NameZts}\n" +
                   $"{s}INDEX{s}{(byte)Type}{s}{(byte)ItemType}{s}{ItemSubType}{s}{EquipmentSlot}{s}{Image}\n" +
                   $"{s}TYPE{s}{Unknown1}{s}{Class}\n" +//need check
                   $"{s}FLAG{s}{Flag11}{s}{Flag12}{s}{Flag13}{s}{(IsSoldable ? 0 : 1)}{s}{(IsDroppable ? 0 : 1)}{s}{(IsTradable ? 0 : 1)}{s}{(IsMinilandActionable ? 1 : 0)}{s}{(IsWarehouse ? 1 : 0)}{s}{(Flag9 ? 1 : 0)}{s}{(Flag1 ? 1 : 0)}{s}{(Flag2 ? 1 : 0)}{s}{(Flag3 ? 1 : 0)}{(Flag4 ? 1 : 0)}{s}{(Flag5 ? "1" : 0)}{s}{(IsColored ? 1 : 0)}{s}{(Sex == 2 ? $"1{s}0" : Sex == 1 ? $"0{s}1" : $"0{s}0")}{s}{(Flag10 ? 1 : 0)}{s}{(Flag6 ? 1 : 0)}{s}{(ReputPrice != 0 ? 1 : 0)}{s}{(IsHeroic ? 1 : 0)}{s}{(Flag7 ? "1" : "0")}{s}{(Flag8 ? "1" : "0")}\n" +//need know the others values
                   $"{s}DATA\n" +
                   $"{s}BUFF\n" +
                   $"{s}LINEDESC{s}\n{Unknown2}" +
                   $"{(!string.IsNullOrEmpty(DescriptionZts) ? DescriptionZts : "")}" +
                   $"{s}END" +
                   $"#========================================================";
        }
    }
}
