using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_15_Aula_207_GetHashCode_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(! (obj is Client))
            {
                return false;
            }
            Client temp = obj as Client;
            return Email.Equals(temp.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
