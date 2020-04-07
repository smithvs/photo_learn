using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter : IFilter
    {
        IParameters parameters;

        ParametrizedFilter()
        {
        }
        public ParametrizedFilter(IParameters parameters)
        {
            this.parameters = parameters;
        }

        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDescription();
        }

        public abstract Photo Process(Photo photo, IParameters parameters);

        public Photo Process(Photo photo, double[] values)
        {
            this.parameters.Parse(values);
            return Process(photo, this.parameters);
        }
    }
}
