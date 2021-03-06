﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AllReady.Models;
using MediatR;

namespace AllReady.Features.Requests
{
    public class AddRequestCommandAsync : IAsyncRequest<AddRequestError>
    {
        public Request Request { get; set; }
    }
}
