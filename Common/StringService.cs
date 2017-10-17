using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsureThat;

namespace Common
{
    public static class StringService
    {
        public static bool IsPalindome(this string input)
        {
            Ensure.That(input, "Not null").IsNotNullOrEmpty();
            var reversedInput = input.Reverse().ToArray();
            return input.Equals(string.Concat(reversedInput));
        }

        public static string Concatenate(params string[] values)
        {
            return string.Concat(values);
        }
    }
}
