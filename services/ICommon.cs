using JobPortal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.services
{
    internal interface ICommon
    {
        Response<List<Job>> GetJobs();
        Response<List<Job>> GetJobsByQuery(string city);
    }
}
