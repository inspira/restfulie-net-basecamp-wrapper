using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<todo-item>
  <id type="integer">#{id}</id>
  <todo-list-id type="integer">#{todo_list_id}</todo-list-id>
  <content>#{content}</content>
  <position type="integer">#{position}</position>
  <created-on type="datetime">#{created_on}</created-on>
  <creator-id type="integer">#{creator_id}</creator-id>
  <creator-name>#{creator_name}</creator-name>
  <completed type="boolean">#{completed}</completed>
  <comments-count type="integer">#{comments_count}</comments-count>

  <!-- if the item has a responsible party -->
  <responsible-party-type>#{responsible_party_type}</responsible-party-type>
  <responsible-party-id type="integer">#{responsible_party_id}</responsible-party-id>
  <responsible-party-name>#{responsible_party_name}</responsible-party-name>

  <!-- if the item has been completed -->
  <completed-on type="datetime">#{completed_on}</completed-on>
  <completer-id type="integer">#{completer_id}</completer-id>
  <completer-name>#{completer_name}</completer-name>
</todo-item>
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class TodoItem
    {
        /* TO-DO */
    }
}
