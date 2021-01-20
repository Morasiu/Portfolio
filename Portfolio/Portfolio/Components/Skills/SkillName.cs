using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Portfolio.Components.Skills {
	public enum SkillName {
		Unknown,
		[Description("C#")] CSharp,
		Python,
		Rust,
		[Description("ASP.Net")]
		AspNet,
		[Description("Visual Studio")]
		VisualStudio,
		Git,
		Unity,
		Linux,
		[Description("SQL")]
		Sql,
		[Description("Google Cloud Platform")]
		GoogleCloudPlatform,
		Angular,
		Bootstrap,
		[Description("REST API")]
		RestApi,
		English,
		[Description("Unit Tests")]
		UnitTests,
		[Description("Design Patterns")]
		DesignPatterns,
	}
}