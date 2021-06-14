namespace Quine { class Program	{ static void Main()
{
	var s1 = @"namespace Quine { class Program { static void Main()
{
	var s1 = @";
	var s2 = @";
	System.Console.Write($_process.stdout.write(\u0060{s1}\u0022{s1}\u0022;\n	var s2 = @\u0022{s2}\u0022{s2.Replace((char)95, '_').Replace((char)126, (char)96)}_.Replace(@_\_, @_\\_));
}}}
~)
";
	System.Console.Write($"process.stdout.write(\u0060{s1}\u0022{s1}\u0022;\n	var s2 = @\u0022{s2}\u0022{s2.Replace((char)95, '"').Replace((char)126, (char)96)}".Replace(@"\", @"\\"));
}}}
