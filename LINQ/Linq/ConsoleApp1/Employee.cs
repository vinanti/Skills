using System.Collections.Generic;

namespace ProjectionOperationns
{
    internal class Employee
    {
        internal List<string> programming;

        public Employee()
        {
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; internal set; }
    }
}