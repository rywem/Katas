using System;
namespace FactoryPatternConsole.Examples
{
	public class Ref<T> where T : class
	{
        public T Value;

        public Ref(T value)
		{
            this.Value = value;
        }
	}
}

