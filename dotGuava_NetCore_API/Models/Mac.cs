using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Models
{
    public class Mac
    {
        public List<System.Net.NetworkInformation.NetworkInterface> MacAddressesList { get; set; }

        public Mac()
        {
            MacAddressesList = new List<System.Net.NetworkInformation.NetworkInterface>();
        }
        public Mac(MacDTO macDTO)
        {
            MacAddressesList = macDTO.MacAddressesList;
        }

        public async Task GetMacAddressesListAsync()
        {
            try
            {
                MacAddressesList = await Task.Run(() => dotGuava.Essential.Mac.GetDeviceNetworkInterfaces().ToList());
            }
            catch(Exception)
            {
                MacAddressesList = new List<System.Net.NetworkInformation.NetworkInterface>();
            }
        }
    }
}
