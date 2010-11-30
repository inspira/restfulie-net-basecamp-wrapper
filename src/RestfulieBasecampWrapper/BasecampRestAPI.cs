using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestfulieBasecampWrapper
{
    public class BasecampRestAPI
    {
        public static class Paths
        {
            public static string GetProjects = "/projects.xml";
            public static string GetProject = "/projects/{0}.xml";

            public static string GetTimeEntriesByProjectId = "/projects/{0}/time_entries.xml";
        }
    }
}
