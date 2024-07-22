using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YourModNamespace.Tiles
{
    public class PlasmBlock : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;

            AddMapEntry(new Color(150, 150, 255)); // Цвет блока на карте

            DustType = DustID.BlueTorch;
            ItemDrop = ModContent.ItemType<Items.PlasmBlockItem>();
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Plasm Block");
            AddMapEntry(new Color(150, 150, 255), name);

            HitSound = SoundID.Tink;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.1f;
            g = 0.1f;
            b = 0.3f;
        }
    }

    public class PlasmWall : ModWall
    {
        public override void SetStaticDefaults()
        {
            Main.wallHouse[Type] = true;
            AddMapEntry(new Color(100, 100, 200)); // Цвет стены на карте

            DustType = DustID.BlueTorch;
            ItemDrop = ModContent.ItemType<Items.PlasmWallItem>();
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Plasm Wall");
            AddMapEntry(new Color(100, 100, 200), name);

            HitSound = SoundID.Tink;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}