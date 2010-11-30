using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using RestfulieClient.resources;
using RestfulieBasecampWrapper.DomainModel;
using System.Collections;

namespace RestfulieBasecampWrapper
{
    public class BasecampService
    {
        private string baseUrl;
        private string apiKey;
        private NetworkCredential credentials;

        public BasecampService(string BaseUrl, string APIKey)
        {
            baseUrl = BaseUrl;
            apiKey = APIKey;

            credentials = new NetworkCredential(apiKey, "X");
        }

        
        /// <summary>
        /// GET /account.xml
        /// Returns info about the current Basecamp account, its subscription, and the default post and attachment categories.
        /// </summary>
        /// <returns></returns>
        public Account GetAccount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET /projects.xml
        /// Returns all accessible projects. This includes active, inactive, and archived projects.
        /// </summary>
        /// <returns></returns>
        public List<Project> GetProjects()
        {
            List<Project> projectList = new List<Project>();

            dynamic rProjects = Restfulie.At(baseUrl + BasecampRestAPI.Paths.GetProjects, credentials).Get();

            if (rProjects.project is IEnumerable)
            {
                foreach (dynamic rProject in rProjects.project)
                {
                    var typedProject = GetStaticProject(rProject);
                    projectList.Add(typedProject);
                }
            }
            else
            {
                var typedProject = GetStaticProject(rProjects.project);
                projectList.Add(typedProject);
            }

            return projectList;
        }

        private Project GetStaticProject(dynamic rProject)
        {
            //TO-DO: Use mapper
            Project project = new Project();
            project.id = rProject.id;
            project.Name = rProject.Name;

            return project;
        }

        /// <summary>
        /// GET /projects/#{project_id}.xml
        /// Returns a single project identified by its integer ID.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public Project GetProject(Int32 projectId)
        {
            Project project = new Project();

            dynamic rProject = Restfulie.At(baseUrl + String.Format(BasecampRestAPI.Paths.GetProject, projectId), credentials).Get();

            //TO-DO: Use mapper
            project.id = rProject.id;
            project.Name = rProject.Name;

            return project;
        }

        /// <summary>
        /// GET /me.xml
        /// Returns the currently logged in person (you).
        /// </summary>
        /// <returns></returns>
        public Person GetMe()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET /people.xml
        /// Returns all people visible to (and including) the requesting user.
        /// </summary>
        /// <returns></returns>
        public List<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET /projects/#{project_id}/people.xml
        /// Returns all people with access to the given project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public List<Person> GetPeopleByProjectId(Int32 projectId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET /companies/#{company_id}/people.xml
        /// Returns all people from the given company that are visible to the requesting user.
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public List<Person> GetPeopleByCompanyId(Int32 companyId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET /people/#{person_id}.xml
        /// Returns a single person identified by their integer ID.
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public Person GetPerson(Int32 personId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET /companies.xml
        /// Returns a list of all companies visible to the requesting user.
        /// </summary>
        /// <returns></returns>
        public List<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public List<TimeEntry> GetTimeEntriesByProjectId(Int32 projectId)
        {
            List<TimeEntry> TimeEntryList = new List<TimeEntry>();

            dynamic rTimeEntryList = Restfulie.At(baseUrl + String.Format(BasecampRestAPI.Paths.GetTimeEntriesByProjectId, projectId), credentials).Get();

            foreach (dynamic rTimeEntry in rTimeEntryList.time_entry)
            {
                //TO-DO: Use mapper
                TimeEntry timeEntry = new TimeEntry();
                timeEntry.id = rTimeEntry.id;
                timeEntry.Description = rTimeEntry.Description;

                TimeEntryList.Add(timeEntry);
            }

            return TimeEntryList;

        }
    }
}
