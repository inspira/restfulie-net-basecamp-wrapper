using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<account>
  <id type="integer">1</id>
  <name>Your Company</name>
  <account-holder-id type="integer">1</account-holder-id>
  <ssl-enabled type="boolean">true</ssl-enabled>
  <email-notification-enabled type="boolean">true</email-notification-enabled>
  <time-tracking-enabled type="boolean">true</time-tracking-enabled>
  <updated-at type="datetime">2009-10-09T17:52:46Z</updated-at>
  <subscription>
    <name>Premium</name>
    <writeboards type="float">Infinity</writeboards>
    <projects type="integer">100</projects>
    <storage type="integer">32212254720</storage>
    <ssl type="boolean">true</ssl>
    <time-tracking type="boolean">true</time-tracking>
  </subscription>
  <default-attachment-categories>
    <category>Documents</category>
    <category>Pictures</category>
    <category>Sounds</category>
  </default-attachment-categories>
  <default-post-categories>
    <category>Design</category>
    <category>Code</category>
    <category>Copywriting</category>
    <category>Transcripts</category>
    <category>Assets</category>
    <category>Miscellaneous</category>
  </default-post-categories>
</account>
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class Account
    {
        /* TO-DO */

        public Person AccountHolder { get; set; }
        public Subscription Subscription { get; set; }

    }
}
