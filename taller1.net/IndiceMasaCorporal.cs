﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1.net
{
    public class IndiceMasaCorporal
    {
        private double estatura;
        private double peso;


        public void setEstatura(double statur)
        {
            this.estatura = statur;
        }

        public double getEstatura()
        {
            return this.estatura;
        }

        public void setPeso(double pes) 
        {
            this.peso = pes;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public double CalculoIMC()
        {
            return (this.getPeso() / (this.getEstatura() * this.getEstatura()));

        }

    }
}
