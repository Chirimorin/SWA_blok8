using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_1
{
    static class Factory
    {
        public static IWriter GetWriter(string color)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            var currentType = currentAssembly.GetTypes().SingleOrDefault(t => t.Name == color);
            return (IWriter)Activator.CreateInstance(currentType);
        }
    }
}
