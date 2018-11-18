using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExceptions
{
    class Person
    {
        private String name;

        public String Name
        {
            get { return name; }
            set
            {
                try
                {
                    if (value == null)
                        throw new NullReferenceException("Name cannot be null");

                    name = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("name can't be null");
                    throw;
                }

            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new Person();
                person.Name = null;
            }
            catch (EncoderFallbackException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
