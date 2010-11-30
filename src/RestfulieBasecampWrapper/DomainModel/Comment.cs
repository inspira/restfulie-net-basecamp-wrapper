using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<comment>
  <id type="integer">#{id}</id>
  <author-id type="integer">#{author_id}</author-id>
  <author-name>#{author_name}</author-name>
  <commentable-id type="integer">#{commentable_id}</commentable-id>
  <commentable-type>#{commentable_type}</commentable-type>
  <body>#{body}</body>
  <emailed-from nil="true">#{emailed_from}</emailed-from>
  <created-at type="datetime">#{created_at}</created-at>

  <attachments-count type="integer">#{attachments_count}</attachments-count>
  <attachments type="array">
    <attachment>
      ...
    </attachment>
    ...
  </attachments>
</comment>
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class Comment
    {
        /* TO-DO */

        public Person Author;
        public List<Attachment> Attachments { get; set; }
    }
}
