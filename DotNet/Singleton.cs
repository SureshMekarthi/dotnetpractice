using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
            Console.WriteLine("Singleton instance created");
        }

        public static Singleton Instance { get { return instance.Value; } }

        public void ShowMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }
    }
}
