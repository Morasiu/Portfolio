using System.Collections.Generic;

namespace Portfolio.Services {
	public class CompanyImageService {
		private static Dictionary<string, string> Images { get; } = new() {
			{"Code Hydra", "Images/Companies/codehydra_full_logo.png"},
			{"Tronel", "Images/Companies/tronel.png"},
			{"Qumak", "Images/Companies/qumak.png"},
			{"OEConnection", "Images/Companies/oec.svg"},
		};

		public static string GetImagePath(string companyName) {
			if (Images.ContainsKey(companyName)) return Images[companyName];
			return string.Empty;
		}
	}
}