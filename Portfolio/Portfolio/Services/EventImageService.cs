using System.Collections.Generic;

namespace Portfolio.Services {
	public class EventImageService {
		public static Dictionary<string, string> Images { get; } = new() {
			{"City Coders Płock", "Images/Achievements/Logo_City_coders_plock.png"},
			{"Sheep Your Hack", "Images/Achievements/sheep_your_hack.png"},
			{"BulldogJob article", "Images/Achievements/BulldogJob_logo.png"},
		};
	}
}