using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB5_Interfaces
{
    public enum EstadoBinario { Ligado, Desligado }

    public interface IEstadoBinario
    {
        void Ligar();
        void Desligar();
        EstadoBinario Estado { get; }

    }
}