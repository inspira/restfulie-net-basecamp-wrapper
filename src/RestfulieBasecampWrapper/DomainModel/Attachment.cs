using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<attachment>
  <id type="integer">#{id}</id>
  <name>#{name}</name>
  <description>#{description}</description>
  <byte-size type="integer">#{byte_size}</byte-size>
  <download-url>#{download_url}</download-url>

  <project-id type="integer">#{project_id}</project-id>
  <category-id type="integer">#{category_id}</category-id>
  <person-id type="integer">#{person_id}</person-id>
  <private type="boolean">#{private}</private>
  <created-on type="datetime">#{created_on}</created-on>

  <!-- if the attachment belongs to a message or comment -->
  <owner-id type="integer">#{owner_id}</owner-id>
  <owner-type>#{owner_type}</owner-type>

  <!-- for attachments with multiple versions, collection specifies
    the id of the "parent" attachment (version 1), and current will
    be true for the most recent version -->
  <collection type="integer">#{collection}</collection>
  <version type="integer">#{version}</version>
  <current type="boolean">#{current}</current>
</attachment>
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class Attachment
    {
        /* TO-DO */
    }
}
