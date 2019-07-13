using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication43.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }

        public Employee(string record)
        {
            var datas = record.Split('\t');
            Id = Convert.ToInt32(datas[0]);
            Name = datas[1];
            EMail = datas[2];
        }
    }
}