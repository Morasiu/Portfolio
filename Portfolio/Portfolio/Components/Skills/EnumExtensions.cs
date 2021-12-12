using System;
using System.ComponentModel;

namespace Portfolio.Components.Skills {
	public static class EnumExtensions {
		public static string GetEnumDescription(this Enum value) {
			// Get the Description attribute value for the enum value
			var fi = value.GetType().GetField(value.ToString());
			var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

			if (attributes.Length > 0)
				return attributes[0].Description;
			else
				return value.ToString();
		}
	}
}