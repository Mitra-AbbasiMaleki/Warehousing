using BaseBackend.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseBackend.Entities
{
    public class MeasurementUnit:IBaseEntity
    {
        int nextid = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public MeasurementUnit(string name)
        {
            Id = nextid;
            nextid++;
            Name = name;
        }
    }
}
