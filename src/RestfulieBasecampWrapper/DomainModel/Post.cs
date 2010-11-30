using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<post>
  <id type="integer">#{id}</id>
  <title>#{title}</title>
  <body>#{body}</body>
  <display-body>#{display_body}</display-body>
  <posted-on type="datetime">#{posted_on}</posted-on>
  <project-id type="integer">#{project_id}</project-id>
  <category-id type="integer">#{category_id}</category-id>
  <author-id type="integer">#{author_id}</author-id>
  <author-name>#{author_name}</author-name>
  <milestone-id type="integer">#{milestone_id}</milestone-id>
  <comments-count type="integer">#{comments_count}</comments-count>
  <use-textile type="boolean">#{use_textile}</use-textile>
  <extended-body deprecated="true">#{extended_body}</extended-body>
  <display-extended-body deprecated="true">#{display_extended_body}</display-extended-body>

  <attachments-count type="integer">#{attachments_count}</attachments-count>
  <attachments type="array">
    <attachment>
      ...
    </attachment>
    ...
  </attachments>

  <!-- if user can see private posts -->
  <private type="boolean">#{private}</private>
</post>
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class Post
    {
        /* TO-DO */

        public Category Category;
        public List<Attachment> Attachments { get; set; }
    }
}
