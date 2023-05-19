using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code_Formating
{
	class _02_Vertical_Density
	{
		public class ReporterConfig
		{ 
            /**
			 * The class name of the reporter listener */
            private String m_className;

			private List<Property> m_properties = new List<Property>();
			public void addProperty(Property property)
			{
				m_properties.Add(property);
			}
		}
	}
}