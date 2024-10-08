using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ToastyQoL.Content.Buffs;

namespace ToastyQoL.Content.Items
{
    public class NostShroom : ModItem
    {
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine obj = tooltips.LastOrDefault((x) => x.Name == "Tooltip1" && x.Mod == "Terraria");
            obj.Text = Language.GetTextValue($"Mods.ToastyQoL.Items.NostShroom.OtherTooltip.1") + "\n" + Language.GetTextValue($"Mods.ToastyQoL.Items.NostShroom.OtherTooltip.2");
            obj.OverrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);


            TooltipLine obj2 = new(Mod, "1", "People who have nohit SCal with this:")
            {
                Text = Language.GetTextValue($"Mods.ToastyQoL.Items.NostShroom.OtherTooltip.Info")
            };
            tooltips.Add(obj2);

            TooltipLine obj3 = new(Mod, "2", "People who have nohit SCal with this:")
            {
                Text = "Astra",
                OverrideColor = new(244, 127, 255)
            };
            tooltips.Add(obj3);

            TooltipLine obj4 = new(Mod, "3", "People who have nohit SCal with this:")
            {
                Text = "Athos",
                OverrideColor = new(83, 169, 76)
            };
            tooltips.Add(obj4);

            TooltipLine obj5 = new(Mod, "4", "People who have nohit SCal with this:")
            {
                Text = "Hobbes",
                OverrideColor = new(255, 151, 11)
            };
            tooltips.Add(obj5);

            TooltipLine obj6 = new(Mod, "5", "People who have nohit SCal with this:")
            {
                Text = "Brue",
                OverrideColor = new(95, 205, 228)
            };
            tooltips.Add(obj6);

            TooltipLine obj7 = new(Mod, "6", "People who have nohit SCal with this:")
            {
                Text = "Imogen",
                OverrideColor = new(209, 180, 128)
            };
            tooltips.Add(obj7);

            TooltipLine obj8 = new(Mod, "7", "People who have nohit SCal with this:")
            {
                Text = "Creamy",
                OverrideColor = new(242, 221, 255)
            };
            tooltips.Add(obj8);

            TooltipLine obj9 = new(Mod, "8", "People who have nohit SCal with this:")
            {
                Text = "Xurkiderp",
                OverrideColor = new(0, 255, 106)
            };
            tooltips.Add(obj9);

            TooltipLine obj10 = new(Mod, "9", "People who have nohit SCal with this:")
            {
                Text = "Obama",
                OverrideColor = new(102, 0, 102)
            };
            tooltips.Add(obj10);

            TooltipLine obj11 = new(Mod, "10", "People who have nohit SCal with this:")
            {
                Text = "PurpleMattik",
                OverrideColor = new(242, 221, 255)
            };
            tooltips.Add(obj11);

            TooltipLine obj12 = new(Mod, "11", "People who have nohit SCal with this:")
            {
                Text = "KRR",
                OverrideColor = new(253, 51, 5)
            };
            tooltips.Add(obj12);

            TooltipLine obj13 = new(Mod, "12", "People who have nohit SCal with this:")
            {
                Text = "Brutus",
                OverrideColor = new(153, 204, 255)
            };
            tooltips.Add(obj13);

            TooltipLine obj14 = new(Mod, "13", "People who have nohit SCal with this:")
            {
                Text = "Lumina",
                OverrideColor = new(147, 0, 255)
            };
            tooltips.Add(obj14);
        }

        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 48;
            Item.useTurn = true;
            Item.maxStack = 30;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.rare = ItemRarityID.Orange;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.UseSound = SoundID.Item2;
            Item.consumable = true;
            Item.buffType = ModContent.BuffType<NostTrippy>();
            Item.buffTime = 216000;
            Item.value = Item.buyPrice(1);
            Item.rare = -12;
        }
    }
}