using MongoDB.Driver.Linq;
using PatientData.Models;
using System.Collections.Generic;
using System.Linq;

namespace PatientData
{
    public class MongoConfig
    {
        public static void Seed()
        {
            var patients = PatientDb.Open();

            if (!patients.AsQueryable().Any(p => p.Name == "Scott"))
            {
                var data = new List<Patient>()
                {
                    new Patient
                    {
                        Name = "Scott",
                        Ailments = new List<Ailment>() { new Ailment { Name = "Crazy"} },
                        Medications = new List<Medication> { new Medication { Name = "B6", Doses = 100} }
                    },
                    new Patient
                    {
                        Name = "Joy",
                        Ailments = new List<Ailment>() { new Ailment { Name = "Crazy"} },
                        Medications = new List<Medication> { new Medication { Name = "Complex B", Doses = 500 } }
                    },
                    new Patient
                    {
                        Name = "Sarah",
                        Ailments = new List<Ailment>() { new Ailment { Name = "Crazy"} },
                        Medications = new List<Medication> { new Medication { Name = "Complex vitamin", Doses = 1000 } }
                    }
                };

                patients.InsertBatch(data);
            }
        }
    }
}