using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YourModNamespace.Items
{
    public class PlasmBlockItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plasm Block");
            Tooltip.SetDefault("A block made of plasma");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.PlasmBlock>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 1) // Пример ингредиента
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class PlasmWallItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plasm Wall");
            Tooltip.SetDefault("A wall made of plasma");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createWall = ModContent.WallType<Tiles.PlasmWall>();
        }

        public override void AddRecipes()
        {
            CreateRecipe(4)
                .AddIngredient(ModContent.ItemType<PlasmBlockItem>(), 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}