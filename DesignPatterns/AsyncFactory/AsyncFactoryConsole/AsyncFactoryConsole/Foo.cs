using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFactoryConsole
{
    public class Foo
    {

        private Foo()
        {
            //private
        }
        private async Task<Foo> InitAsync()
        {
            // private, this is where we do the async work
            await Task.Delay(1000); 
            return this;
        }

        // This is our public factory method.
        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }
    }
}
