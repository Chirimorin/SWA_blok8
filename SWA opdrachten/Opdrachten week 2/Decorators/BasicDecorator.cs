using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Opdrachten_week_2
{
    public abstract class BasicDecorator : IComponent
    {
        private IComponent _component;

        protected BasicDecorator(IComponent decorated)
        {
            _component = decorated;
        }

        public virtual void Draw(Canvas c)
        {
            if (_component != null)
            {
                _component.Draw(c);
            }
        }

    }
}
