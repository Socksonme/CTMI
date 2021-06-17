using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;


namespace CTMI {
	public class CTMI : Mod {

		Mod CalamityMod => ModLoader.GetMod("CalamityMod");
		ConfigClient Config => ModContent.GetInstance<ConfigClient>();
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(this);

			if (Config.AccessoryRecipes) {

				recipe.AddIngredient(ItemID.Wire, 5);
				recipe.AddIngredient(ItemID.Lens, 2);
				recipe.AddRecipeGroup("CTMI:GoldBar", 2);
				recipe.AddRecipeGroup("IronBar", 10);
				recipe.AddTile(TileID.Chairs);
				recipe.AddTile(TileID.Tables);
				recipe.SetResult(ItemID.Stopwatch);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Wire, 20);
				recipe.AddIngredient(ItemID.Glass, 5);
				recipe.AddRecipeGroup("CTMI:SilverBar", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LifeformAnalyzer);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:CobaltBar", 10);
				recipe.AddIngredient(ItemID.Wire, 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DPSMeter);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Wire, 200);
				recipe.AddIngredient(ItemID.Actuator, 50);
				recipe.AddRecipeGroup("IronBar", 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ActuationAccessory);
				// WHO THE FUCK THOUGHT THAT "ACTUATION ACCESSORY" WAS A GOOD ITEM ID NAME FOR THE PRESSERATOR????
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StoneWall, 150);
				recipe.AddIngredient(ItemID.DirtWall, 150);
				recipe.AddIngredient(ItemID.GrayBrickWall, 150);
				recipe.AddIngredient(ItemID.StoneSlabWall, 150);
				recipe.AddRecipeGroup("IronBar", 8);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.PortableCementMixer);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RedPaint, 100);
				recipe.AddIngredient(ItemID.BluePaint, 100);
				recipe.AddIngredient(ItemID.YellowPaint, 100);
				recipe.AddIngredient(ItemID.Paintbrush);
				recipe.AddIngredient(ItemID.PaintRoller);
				recipe.AddTile(TileID.TinkerersWorkbench);
				recipe.SetResult(ItemID.PaintSprayer);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Hook, 2);
				recipe.AddRecipeGroup("IronBar", 12);
				recipe.AddRecipeGroup("CTMI:GoldBar", 4);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ExtendoGrip);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:SilverBar", 8);
				recipe.AddIngredient(ItemID.Ruby, 4);
				recipe.AddIngredient(ItemID.BuilderPotion, 2);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BrickLayer);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:Counterweight");
				recipe.AddIngredient(ItemID.BlackDye);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BlackCounterweight);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:Counterweight");
				recipe.AddIngredient(ItemID.YellowDye);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.YellowCounterweight);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ClockworkAssaultRifle);
				recipe.AddIngredient(ItemID.SoulofNight, 5);
				recipe.AddIngredient(ItemID.WormTooth, 10);
				recipe.AddIngredient(ItemID.IllegalGunParts);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Gatligator);
				recipe.AddRecipe();

				if (CalamityMod != null && Config.CalamityRecipes) {
					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.CobaltShield);
					recipe.AddIngredient(CalamityMod.ItemType("EssenceofEleum"), 8);
					recipe.AddTile(TileID.MythrilAnvil);
					recipe.SetResult(CalamityMod.ItemType("FrostBarrier"));
					recipe.AddRecipe();
				}

				else {
					// Since Calamity adds recipes as well
					recipe = new ModRecipe(this);
					recipe.AddRecipeGroup("CTMI:CobaltBar", 10);
					recipe.AddIngredient(ItemID.Sapphire, 3);
					recipe.AddIngredient(ItemID.FallenStar, 15);
					recipe.AddIngredient(ItemID.SoulofLight, 5);
					recipe.AddTile(TileID.CrystalBall);
					recipe.SetResult(ItemID.CelestialMagnet);
					recipe.AddRecipe();
				}


				// Moving the Confg.VanityRecipes if statement down to prevent an ide warning
				if (Config.VanityRecipes) {
					recipe = new ModRecipe(this);
					recipe.AddRecipeGroup("CTMI:GoldBar", 6);
					recipe.AddIngredient(ItemID.Diamond, 4);
					recipe.AddTile(TileID.Anvils);
					recipe.SetResult(ItemID.DiamondRing);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddRecipeGroup("CTMI:GoldBar", 8);
					recipe.AddTile(TileID.Anvils);
					recipe.SetResult(ItemID.GoldRing);
					recipe.AddRecipe();

				}

			}

			if (Config.WeaponRecipes) {
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:CobaltBar", 8);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Code1);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:AdamantiteBar", 8);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Code2);
				recipe.AddRecipe();
			}

			if (Config.PlaceableRecipes) {

				if (Config.VanityRecipes) {
					recipe = new ModRecipe(this);
					recipe.AddRecipeGroup("CTMI:DWood");
					recipe.AddTile(TileID.TinkerersWorkbench);
					recipe.SetResult(ItemID.DynastyWood);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.DynastyWood, 2);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.RedDynastyShingles);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.DynastyWood, 2);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.BlueDynastyShingles);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.ClayBlock, 2);
					recipe.AddTile(TileID.Furnaces);
					recipe.SetResult(ItemID.FancyDishes);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.GoldBar);
					recipe.AddTile(TileID.Anvils);
					// Once again, wtf is this naming scheme?
					recipe.SetResult(ItemID.SteampunkCup);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Leather, 2);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.ZebraSkin);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Leather, 2);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.LeopardSkin);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Leather, 2);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TigerSkin);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Obsidian);
					recipe.AddTile(TileID.CrystalBall);
					recipe.SetResult(ItemID.ArcaneRuneWall, 4);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Emerald);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockGreen, 100);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Ruby);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockRed, 100);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Sapphire);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockBlue, 100);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Topaz);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockYellow, 100);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Diamond);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockWhite, 100);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Amethyst);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockPink, 100);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.TeamBlockWhite);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockWhitePlatform);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.TeamBlockGreen);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockGreenPlatform);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.TeamBlockYellow);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockYellowPlatform);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.TeamBlockRed);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockRedPlatform);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.TeamBlockBlue);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockBluePlatform);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.TeamBlockPink);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.TeamBlockPinkPlatform);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingTheSeason);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingSnowfellas);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingCursedSaint);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingColdSnap);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingAcorns);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingTheTruthIsUpThere);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingMartiaLisa);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					recipe.SetResult(ItemID.PaintingCastleMarsberg);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddRecipeGroup("CTMI:Wood", 10);
					recipe.AddTile(TileID.WorkBenches);
					// At least this one is not as bad as the others
					recipe.SetResult(ItemID.MoonLordPainting);
					recipe.AddRecipe();
				}

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.EndlessMusketPouch);
				// Calamity has a recipe for Rocket Is
				if (CalamityMod == null || !Config.CalamityRecipes) {
					recipe.AddIngredient(ItemID.RocketI, 20);
				}
				else {
					recipe.AddIngredient(ItemID.RocketIII, 20);
				}
				recipe.AddIngredient(ItemID.WoodenArrow, 500);
				recipe.AddIngredient(ItemID.Gel, 200);
				recipe.AddIngredient(ItemID.PoisonDart, 300);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.AmmoBox);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Torch, 3);
				recipe.AddIngredient(ItemID.Glowstick);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.UltrabrightTorch, 3);
				recipe.AddRecipe();

			}

			if (Config.ConsumableRecipes) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Bottle);
				recipe.AddTile(TileID.Kegs);
				recipe.SetResult(ItemID.Sake);
				recipe.AddRecipe();

				// Time to say fuck readablity
				if (Config.CalamityRecipes) {
					recipe = new ModRecipe(this);
					recipe.AddIngredient(CalamityMod.GetItem("CragBullhead"));
					recipe.AddTile(TileID.CookingPots);
					recipe.SetResult(ItemID.Pho);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(CalamityMod.GetItem("PrismaticGuppy"));
					recipe.AddTile(TileID.CookingPots);
					recipe.SetResult(ItemID.Pho);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(CalamityMod.GetItem("TwinklingPollox"));
					recipe.AddTile(TileID.CookingPots);
					recipe.SetResult(ItemID.Pho);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(CalamityMod.GetItem("CragBullhead"));
					recipe.AddTile(TileID.CookingPots);
					recipe.SetResult(ItemID.PadThai);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(CalamityMod.GetItem("PrismaticGuppy"));
					recipe.AddTile(TileID.CookingPots);
					recipe.SetResult(ItemID.PadThai);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(CalamityMod.GetItem("TwinklingPollox"));
					recipe.AddTile(TileID.CookingPots);
					recipe.SetResult(ItemID.PadThai);
					recipe.AddRecipe();
				}
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Bass);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.Pho);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Trout);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.Pho);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Salmon);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.Pho);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AtlanticCod);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.Pho);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Tuna);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.Pho);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RedSnapper);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.Pho);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Bass);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.PadThai);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Trout);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.PadThai);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Salmon);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.PadThai);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AtlanticCod);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.PadThai);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Tuna);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.PadThai);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RedSnapper);
				recipe.AddTile(TileID.CookingPots);
				recipe.SetResult(ItemID.PadThai);
				recipe.AddRecipe();
			}

			if (Config.ToolRecipes) {
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:Wood", 8);
				recipe.AddIngredient(ItemID.GiantHarpyFeather);
				recipe.AddIngredient(ItemID.Feather, 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SittingDucksFishingRod);
				recipe.AddRecipe();
			}

			if (Config.ArmorRecipes) {

				if (Config.VanityRecipes) {
					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.BlackThread, 2);
					recipe.AddIngredient(ItemID.Silk, 6);
					recipe.AddTile(TileID.Loom);
					recipe.SetResult(ItemID.Fez);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.BlackThread, 2);
					recipe.AddIngredient(ItemID.Silk, 12);
					recipe.AddTile(TileID.Loom);
					recipe.SetResult(ItemID.Kimono);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.BlackThread, 2);
					recipe.AddIngredient(ItemID.GoldBar);
					recipe.AddIngredient(ItemID.Silk, 7);
					recipe.AddTile(TileID.Loom);
					recipe.SetResult(ItemID.WinterCape);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.BlackThread, 2);
					recipe.AddIngredient(ItemID.GoldBar);
					recipe.AddIngredient(ItemID.Silk, 7);
					recipe.AddTile(TileID.Loom);
					recipe.SetResult(ItemID.RedCape);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.BlackThread, 2);
					recipe.AddIngredient(ItemID.Silk, 7);
					recipe.AddTile(TileID.Loom);
					recipe.SetResult(ItemID.MysteriousCape);
					recipe.AddRecipe();

					recipe = new ModRecipe(this);
					recipe.AddIngredient(ItemID.BlackThread, 2);
					recipe.AddIngredient(ItemID.Silk, 7);
					recipe.AddTile(TileID.Loom);
					recipe.SetResult(ItemID.CrimsonCloak);
					recipe.AddRecipe();
				}

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:SilverBar", 12);
				recipe.AddIngredient(ItemID.Chain, 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Gi);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FallenStar, 3);
				recipe.AddIngredient(ItemID.Silk, 7);
				recipe.AddTile(TileID.Loom);
				recipe.SetResult(ItemID.MagicHat);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FallenStar, 4);
				recipe.AddIngredient(ItemID.Silk, 12);
				recipe.AddTile(TileID.Loom);
				recipe.SetResult(ItemID.GypsyRobe);
				recipe.AddRecipe();

			}

			if (Config.WeaponRecipes) {
				
				if (Config.VanityRecipes) {
					recipe = new ModRecipe(this);
					recipe.AddRecipeGroup("IronBar", 2);
					recipe.AddIngredient(ItemID.BottledWater, 5);
					recipe.AddTile(TileID.Anvils);
					recipe.SetResult(ItemID.WaterGun);
					recipe.AddRecipe();
				}

				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ShroomiteBar, 8);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PulseBow);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:SilverBar", 8);
				recipe.AddRecipeGroup("CTMI:GoldBar", 2);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Katana);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("CTMI:SilverBar", 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Revolver);
				recipe.AddRecipe();
			}

			if (Config.SummonRecipes && Config.VanityRecipes) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PlatinumCoin, 5);
				recipe.AddIngredient(ItemID.LifeCrystal);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CompanionCube);
				recipe.AddRecipe();
			}

		}
		public override void AddRecipeGroups() {
			// LegacyMisc.37 is the word "any"
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt bar", new int[] {
				ItemID.CobaltBar,
				ItemID.PalladiumBar
			});
			RecipeGroup.RegisterGroup("CTMI:CobaltBar", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold bar", new int[] {
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("CTMI:GoldBar", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver bar", new int[] {
				ItemID.SilverBar,
				ItemID.TungstenBar
			});
			RecipeGroup.RegisterGroup("CTMI:SilverBar", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite bar", new int[] {
				ItemID.AdamantiteBar,
				ItemID.TitaniumBar
			});
			RecipeGroup.RegisterGroup("CTMI:AdamantiteBar", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Counterweight", new int[] {
				ItemID.BlueCounterweight,
				ItemID.RedCounterweight,
				ItemID.PurpleCounterweight,
				ItemID.GreenCounterweight,
				ItemID.BlackCounterweight,
				ItemID.YellowCounterweight
			});
			RecipeGroup.RegisterGroup("CTMI:Counterweight", group);

			// Use the DWood group the dynasty wood recipe
			if (CalamityMod != null && Config.CalamityRecipes) {
				group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Wood", new int[] {
					ItemID.Wood,
					ItemID.RichMahogany,
					ItemID.Ebonwood,
					ItemID.Shadewood,
					ItemID.Pearlwood,
					ItemID.BorealWood,
					ItemID.PalmWood,
					ItemID.SpookyWood,
					ItemID.BorealWood,
					CalamityMod.ItemType("AstralMonolith")
				});
				RecipeGroup.RegisterGroup("CTMI:DWood", group);

				group = new RecipeGroup(() => "Wood", new int[] {
					ItemID.Wood,
					ItemID.RichMahogany,
					ItemID.Ebonwood,
					ItemID.Shadewood,
					ItemID.Pearlwood,
					ItemID.BorealWood,
					ItemID.PalmWood,
					ItemID.SpookyWood,
					ItemID.BorealWood,
					ItemID.DynastyWood,
					CalamityMod.ItemType("AstralMonolith")
				});
				RecipeGroup.RegisterGroup("CTMI:Wood", group);
			}
			
			else {
				group = new RecipeGroup(() => "Wood", new int[] {
					ItemID.Wood,
					ItemID.RichMahogany,
					ItemID.Ebonwood,
					ItemID.Shadewood,
					ItemID.Pearlwood,
					ItemID.BorealWood,
					ItemID.PalmWood,
					ItemID.SpookyWood,
					ItemID.BorealWood,
				});
				RecipeGroup.RegisterGroup("CTMI:DWood", group);

			}
			
		}
		
	}

}