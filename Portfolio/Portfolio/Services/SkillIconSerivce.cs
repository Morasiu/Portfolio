using System.Collections.Generic;

namespace Portfolio.Services {
	public class SkillIconSerivce {
		public static Dictionary<string, string> IconsPath { get; } = new() {
			{"C#", "Images/Skills/csharp.svg"},
			{"Python", "Images/Skills/python.svg"},
			{"Rust", "Images/Skills/rust.svg"},
			{"ASP.Net", "Images/Skills/asp.net.svg"},
			{"Visual Studio", "Images/Skills/visualstudio.svg"},
			{"Git", "Images/Skills/git.svg"},
			{"Unity", "Images/Skills/unity.svg"},
			{"Linux", "Images/Skills/linux.svg"},
			{"SQL", "Images/Skills/postgresql.svg"},
			{"Google Cloud Platform", "Images/Skills/googlecloud.svg"},
			{"Angular", "Images/Skills/angular.svg"},
			{"Bootstrap", "Images/Skills/bootstrap.svg"},
			{"Rest API", "Images/Skills/swagger.svg"},
			{"English", "Images/Skills/english.svg"},
			{"Unit Tests", "Images/Skills/checkmarx.svg"},
			{"Design Patters", "Images/Skills/pencil-ruler.svg"},
		};
	}
}