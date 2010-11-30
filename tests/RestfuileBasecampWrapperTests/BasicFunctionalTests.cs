using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestfulieBasecampWrapper;
using RestfulieBasecampWrapper.DomainModel;

namespace RestfuileBasecampWrapperTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class BasicFunctionalTests
    {
        [TestMethod]
        public void SimpleTest()
        {
            BasecampService service = new BasecampService("https://inspirasandbox.basecamphq.com", "dd8c4e8c9dcec2c1431c869ccc29d6c2c3745d06");

            //GetProjects Test
            Console.WriteLine("> Testing GetProjects");
            List<Project> Projects = service.GetProjects();
            Console.WriteLine("> {0} Projects Fetched", Projects.Count);

            //GetProject Test
            Console.WriteLine("> Testing GetProject(projectId = {0})", Projects[0].id);
            Project Project = service.GetProject(Projects[0].id);
            Console.WriteLine("> '{0}' Project Fetched", Project.Name);

            //GetProject Test
            Console.WriteLine("> Testing GetTimeEntriesByProjectId(projectId = {0})", Projects[0].id);
            List<TimeEntry> TimeEntries = service.GetTimeEntriesByProjectId(Projects[0].id);
            Console.WriteLine("> '{0}' Time Entries Fetched", TimeEntries.Count);
            Console.ReadLine();
        }
    }
}
