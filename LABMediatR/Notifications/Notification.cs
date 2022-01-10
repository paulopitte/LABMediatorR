using MediatR;
using System;

namespace LABMediatR.Notifications
{
    public class Notification : INotification
    {
        public string Nome { get; set; }
  
        public DateTime DataHora { get; set; } = DateTime.Now;

        public override string ToString()
            => $"Novo Customer inserida por {Nome} no dia {DataHora} ";
    }
}
