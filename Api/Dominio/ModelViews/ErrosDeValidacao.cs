using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace minimal_api.Dominio.ModelViews
{
    public struct ErrosDeValidacao
    {
        public List<string> Message { get; set; }
    }
}