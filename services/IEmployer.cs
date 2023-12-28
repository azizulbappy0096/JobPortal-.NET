using JobPortal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.services
{
    internal interface IEmployer
    {
        Response<Company> GetCompanyDetails(string userId);
        Response<Company> UpdateCompanyDetails(Company cData);

        Response<Job> PostJob(Job job);
        Response<bool> DeleteJob(string jobId);
        Response<List<Job>> GetJobs(string userId);
    }
}
