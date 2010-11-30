using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
<company>
  <id type="integer">#{id}</id>
  <name>#{name}</name>
  <address-one>#{address_one}</address-one>
  <address-two>#{address_two}</address-two>
  <city>#{city}</city>
  <state>#{state}</state>
  <zip>#{zip}</zip>
  <country>#{country}</country>
  <web-address>#{web_address}</web-address>
  <phone-number-office>#{phone_number_office></phone-number-office>
  <phone-number-fax>#{phone_number_fax}</phone-number-fax>
  <time-zone-id>#{time_zone_id}</time-zone-id>
  <can-see-private type="boolean">#{can_see_private}</can-see-private>

  <!-- for non-client companies -->
  <url-name>#{url_name}</url-name>
</company> 
*/

namespace RestfulieBasecampWrapper.DomainModel
{
    public class Company
    {
        public int id;
        public string Name;
        public string AddressOne;
        public string AddressTwo;
        public string City;
        public string State;
        public string Zip;
        public string Country;
        public string WebAddress;
        public string PhoneNumberOffice;
        public string PhoneNumberFax;
        public string TimeZoneId;
        public bool CanSeePrivate;

        /* for non-client companies */
        public string UrlName;
    }
}
