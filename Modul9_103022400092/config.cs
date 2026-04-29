using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400092
{
    internal class config
    {
        public string lang { get; set; }
        public transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public confirmations confirmations{ get; set; }

        public config()
        {
          
        }
        public config(string lang, transfer transfer, List<string> methods, confirmations confirmations)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmations = confirmations;
        }


    }



}
