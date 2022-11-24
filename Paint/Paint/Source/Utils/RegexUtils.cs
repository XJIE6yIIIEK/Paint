using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Paint.Source.Utils {
	static class RegexUtils {
		public static bool CheckRegex(string text, string regexString) {
			Regex regex = new Regex(regexString);
			MatchCollection matches = regex.Matches(text);
			return matches.Count > 0;
		}
	}
}
