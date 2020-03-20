﻿using AdminCampana_2020.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCampana_2020.Business.Interface
{
    public interface ISeccionBusiness
    {
        List<SeccionDomainModel> GetSeccion();
        SeccionDomainModel GetSeccionById(int id);
    }
}
