using System.Collections.Generic;

namespace Portfolio.Services {
	public class EventImageService {
		public static Dictionary<string, string> Images { get; } = new() {
			{"City Coders Płock", "Images/Events/Logo_City_coders_plock.png"},
			{"Sheep Your Hack", "Images/Events/sheep_your_hack.png"},
		};
	}
}