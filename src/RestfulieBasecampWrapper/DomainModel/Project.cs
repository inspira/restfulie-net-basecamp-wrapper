using System;
using RestfulieBasecampWrapper.DomainModel;

/*
<project>
  <id type="integer">#{id}</id>
  <name>#{name}</name>
  <created-on type="datetime">#{created_on}</created-on>
  <status>#{status}</status>
  <last-changed-on type="datetiem">#{last_changed_on}</last-changed-on>
  <company>
    <id type="integer">#{id}</id>
    <name>#{name}</name>
  </company>

  <!-- if user is administrator, or show_announcement is true -->
  <announcement>#{announcement}</announcement>

  <!-- if user is administrator -->
  <start-page>#{start_page}</start-page>
  <show-writeboards type="boolean">#{show_writeboards}</show-writeboards>
  <show-announcement type="boolean">#{show_announcement}</show-announcement>
</project>
 
*/

namespace RestfulieBasecampWrapper
{
    public class Project
    {
        public int id;
        public string Name;
        public DateTime CreatedOn;
        public string Status;
        public DateTime LastChangedOn;
        public Company Company { get; set; }

        /*-- if user is administrator, or show_announcement is true --*/
        public string Announcement;

        /*-- if user is administrator --*/
        public bool ShowWriteboards;
        public bool ShowAnnoucement;
    }
}
