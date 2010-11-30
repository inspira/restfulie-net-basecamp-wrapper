using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<todo-list>
  <id type="integer">#{id}</id>
  <name>#{name}</name>
  <description>#{description}</description>
  <project-id type="integer">#{project_id}</project-id>
  <milestone-id type="integer">#{milestone_id}</milestone-id>
  <position type="integer">#{position}</position>

  <!-- if user can see private lists -->
  <private type="boolean">#{private}</private>

  <!-- if the account supports time tracking -->
  <tracked type="boolean">#{tracked}</tracked>

  <!-- if todo-items are included in the response -->
  <todo-items type="array">
    <todo-item>
      ...
    </todo-item>
    <todo-item>
      ...
    </todo-item>
    ...
  </todo-items>
</todo-list>
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class TodoList
    {
        /* TO-DO */
        public List<TodoItem> TodoItems { get; set; }
    }
}
