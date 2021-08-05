using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Generator
{
    // ReSharper disable once UnusedType.Global
    [Generator]
    public class HelloWorld : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // nothing happening
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var code = @"
using System;
namespace CodeGeneratorSample {
    public static class Auto 
    {
        public const string Name = ""Khurram"";
        public static void Hi() => System.Console.WriteLine($""Hi, {Name}!"");
    }
}";
            context.AddSource(
                "hello.world.generator",
                SourceText.From(code, Encoding.UTF8)
            );
        }
    }
}
