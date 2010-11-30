using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<time-entry>
  <id type="integer">#{id}</id>
  <project-id type="integer">#{project-id}</project-id>
  <person-id type="integer">#{person-id}</person-id>
  <date type="date">#{date}</date>
  <hours>#{hours}</hours>
  <description>#{description}</description>
  <todo-item-id type="integer">#{todo-item-id}</todo-item-id>
</time-entry>
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class TimeEntry
    {
        public int id;
        public int ProjectId;
        public int PersonId;
        public DateTime Date;
        public int Hours;
        public string Description;
        public int TodoItemId;

    }
}
