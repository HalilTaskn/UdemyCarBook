﻿using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class RemoveFooterAddressCommand: IRequest
    {
        public RemoveFooterAddressCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
