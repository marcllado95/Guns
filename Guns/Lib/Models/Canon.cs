using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Guns.Lib.Models
{
    public class Canon 
    {
        public interface ICanon
        {
            string Blast();
            string Model();
        }

        public class TNsh : ICanon
        {
            public string Model()
            {
                return "TNsh";
            }
            public string Blast()
            {
                return "BAM!";
            }
        }

        public class Breda35 : ICanon
        {
            public string Model()
            {
                return "Breda35";
            }
            public string Blast()
            {
                return "Peaaaaow!";
            }
        }

        public class KBM : ICanon
        {
            public string Model()
            {
                return "KBM";
            }
            public string Blast()
            {
                return "Fuuf!";
            }
        }
    }
}
