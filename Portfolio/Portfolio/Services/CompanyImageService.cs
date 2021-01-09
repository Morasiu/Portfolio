using System.Collections.Generic;

namespace Portfolio.Services {
	public class CompanyImageService {
		public static Dictionary<string, string> Images { get; } = new() {
			{"Code Hydra", "Images/Companies/codehydra_full_logo.png"},
			{"Tronel", "Images/Companies/tronel.png"},
			{"Qumak", "Images/Companies/qumak.png"},
		};
	}
}