﻿using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    internal class PatientController
    {
        private PatientDAO dao = new PatientDAO();

        public bool insert(PatientDTO dto)
        {
            return dao.insert(dto);
        }

        public bool update(PatientDTO dto, string oldId)
        {
            return dao.update(dto, oldId);
        }

        public bool delete(string id)
        {
            Program.visitController.deleteWithIdPatient(id);
            Program.appointmentController.deleteWithIdPatient(id);
            return dao.delete(id);
        }

        public List<PatientDTO> select()
        {
            return dao.select();
        }

        public PatientDTO selectWithId(string id)
        {
            return dao.selectWithId(id);
        }
    }
}
