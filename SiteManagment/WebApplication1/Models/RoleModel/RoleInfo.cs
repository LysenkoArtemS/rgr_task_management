﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.RoleModel
{
    public class RoleInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleInfo(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public RoleInfo()
        {

        }
    }
}