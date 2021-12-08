using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class EmpController : ApiController
    {
        //public IHttpActionResult GetAllStudents()
        //{
        //    IList<EmpDetails> empDetails = null;

        //    using (var dataBase = new DemoDBEntities())
        //    {
        //        empDetails = dataBase.Employees.Include("Employee")
        //                    .Select(emp => new EmpDetails()
        //                    {
        //                        ID = emp.EmpID,
        //                        Name = emp.Name,
        //                        Location = emp.Location,
        //                        Age = emp.Age ?? 20,
        //                    }).ToList<EmpDetails>();
        //    }

        //    if (empDetails.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(empDetails);
        //}
        public IHttpActionResult GetCountryDetails()
        {
            //IList<CountryDetails> countryDetails = null;

            //using (var dataBase = new DemoDBEntities())
            //{
            //    countryDetails = dataBase.Countries.Include("State")
            //                .Select(co => new CountryDetails()
            //                {
            //                    Cid= co.CountryID,
            //                    Cname= co.CountryName,
            //                    StateDetails= co.States==null? null:new StateDetails()
            //                    {
            //                      Sid=1,
            //                      Sname="",

            //                    }
            //                    //Sid = state.StateID,
            //                    //Sname = state.StateName,
            //                    //countryDetails = state.CountryID ==null?null: new CountryDetails()
            //                    //{
            //                    //    Cid = state.Country.CountryID,
            //                    //    Cname = state.Country.CountryName,

            //                    //}
            //                }).ToList<CountryDetails>();
            //}

            //if (countryDetails.Count == 0)
            //{
            //    return NotFound();
            //}

            //return Ok(countryDetails);
            //IList<CountryDetails> countryDetails = null;

            //using (var dataBase = new DemoDBEntities())
            //{
            //    countryDetails = dataBase.Countries.Include("Country")
            //                .Select(emp => new CountryDetails()
            //                {
            //                   Cid=emp.CountryID,
            //                   Cname=emp.CountryName,
                           

            //                }).ToList<CountryDetails>();
            //}
            IList<StateDetails> stateDetails = null;

            using (var dataBase = new DemoDBEntities())
            {
                stateDetails = dataBase.States.Include("Country")
                            .Select(emp => new StateDetails()
                            {
                             Sid=emp.StateID,
                             Sname=emp.StateName,
                             countryDetails=emp.Country==null?null:new CountryDetails()
                             {
                                 Cid=emp.Country.CountryID,
                                 Cname=emp.Country.CountryName,
                             }

                            }).ToList<StateDetails>();
            }
            if (stateDetails.Count == 0)
            {
                return NotFound();
            }

            return Ok(stateDetails);
        }

    }
}

