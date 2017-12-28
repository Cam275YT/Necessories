using Terraria.ModLoader;

namespace Necessories
{
	class Necessories : Mod
	{
		public Necessories()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
