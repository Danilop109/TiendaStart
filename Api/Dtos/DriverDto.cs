using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Api.Dtos
{
    public class DriverDto : BaseEntity
    {
        public string Name { get; set; }
        public string Age { get; set; }

    }
}