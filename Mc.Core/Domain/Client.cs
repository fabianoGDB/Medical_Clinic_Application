using System;
using System.Collections.Generic;
using System.Text;

namespace Mc.Core.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }
        public string Tel { get; set; }
        public char? Gender { get; set; }
    }
}
