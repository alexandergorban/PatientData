﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MongoDB.Driver;
using PatientData.Models;

namespace PatientData.Controllers
{
    public class PatientsController : ApiController
    {
        private MongoCollection<Patient> _patients;

        public PatientsController()
        {
            _patients = PatientDb.Open();
        }

        public IEnumerable<Patient> Get()
        {
            return _patients.FindAll();
        }
    }
}