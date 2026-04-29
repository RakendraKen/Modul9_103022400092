using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400092
{
    internal class transfer
    {
        public double thereshold { get; set; }
        public double low_fee { get; set; }
        public double high_fee { get; set; }


        public transfer()
        {

        }
        public transfer(double thereshold, double low_fee, double high_fee)
        {
            this.thereshold = thereshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;

        }

        private double calculate_fee(double amount)
        {
            if (amount <= thereshold)
            {
                return low_fee;
            }
            else
            {
                return high_fee;
            }
        }

    }
}