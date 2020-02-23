using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Stringier.Literary;

namespace Benchmarks {
	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[SimpleJob(RuntimeMoniker.CoreRt31)]
	[SimpleJob(RuntimeMoniker.Mono)]
	public class ExtensionsBenchmarks {
		[Params("", "hello", "detartrated", "Malayalam", "Was it a car or a cat I saw?", "No 'X' in Nixon", "Able was I ere I saw Elba", "A man, a plan, a canal, Panama!", "Café Éfac")]
		public String String { get; set; }

		[Benchmark]
		public Boolean IsPalindrome() => String.IsPalindrome();
	}
}
