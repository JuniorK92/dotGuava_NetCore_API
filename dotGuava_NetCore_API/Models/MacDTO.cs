using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Models
{
    public class MacDTO
    {
        public List<System.Net.NetworkInformation.NetworkInterface> MacAddressesList { get; set; }

        public MacDTO()
        {

        }
        public MacDTO(Mac mac)
        {
            MacAddressesList = mac.MacAddressesList;
        }
    }
}
