using Microsoft.Repl.ConsoleHandling;

namespace Microsoft.Repl.Tests.Mocks
{
    internal class MockWritable : IWritable
    {
        public void Write(char c)
        {
        }

        public void Write(string s)
        {
        }

        public void WriteLine()
        {
        }

        public void WriteLine(string s)
        {
        }

        public bool IsCaretVisible { get => true; set => value = true; }
    }
}
