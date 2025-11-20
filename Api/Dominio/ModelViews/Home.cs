using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace minimal_api.Dominio.ModelViews
{
    public struct Home
    {
        public string MsgInity { get => "Bem vindo a API de veículos - Minimal API"; }
        public string Doc { get => "/swagger"; }
    }
}