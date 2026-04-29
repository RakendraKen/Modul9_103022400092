using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400092
{
    internal class confirmations
    {
        public string en { get; set; }
        public string id { get; set; }

        public confirmations()
        {
        }

        public confirmations(string en, string id)
        {
            this.en = en;
            this.id = id;
        }

        public override string ToString()
        {
            return $"en: {en}, id: {id}";

        }
    }
}
