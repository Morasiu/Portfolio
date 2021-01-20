using System.Collections.Generic;
using Portfolio.Components.Skills;

namespace Portfolio.Services {
	public class SkillIconSerivce {
		public static Dictionary<SkillName, string> IconsPath { get; } = new() {
			{SkillName.CSharp, "Images/Skills/csharp.svg"},
			{SkillName.Python, "Images/Skills/python.svg"},
			{SkillName.Rust, "Images/Skills/rust.svg"},
			{SkillName.AspNet, "Images/Skills/asp.net.svg"},
			{SkillName.VisualStudio, "Images/Skills/visualstudio.svg"},
			{SkillName.Git, "Images/Skills/git.svg"},
			{SkillName.Unity, "Images/Skills/unity.svg"},
			{SkillName.Linux, "Images/Skills/linux.svg"},
			{SkillName.Sql, "Images/Skills/postgresql.svg"},
			{SkillName.GoogleCloudPlatform, "Images/Skills/googlecloud.svg"},
			{SkillName.Angular, "Images/Skills/angular.svg"},
			{SkillName.Bootstrap, "Images/Skills/bootstrap.svg"},
			{SkillName.RestApi, "Images/Skills/swagger.svg"},
			{SkillName.English, "Images/Skills/english.svg"},
			{SkillName.UnitTests, "Images/Skills/checkmarx.svg"},
			{SkillName.DesignPatterns, "Images/Skills/pencil-ruler.svg"},
		};
	}
}