using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*You need to create a class named Product that represents a product.The class has a single
property named Name.Users of the Product class should be able to get as well as set the value
of the Name property.However, any attempt to set the value of Name to an empty string or
a null value should raise an exception.Also, users of the Product class should not be able to
access any other data members of the Product class. How will you create such a class?
*/
namespace Hw02._1
{
    class Product
    {
        private string name;
        
        public string Name
        {

            get {
                return name;
            }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Wrong value");
                }
                name = value;
                    
                }
            }
        }
    }

