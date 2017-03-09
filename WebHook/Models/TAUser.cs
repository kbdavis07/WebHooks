using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHook.Models
{
    public class TAUserInfo
    {
       
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string AffiliateID { get; set; }
        public string TAHost { get; set; }
        public string Referrer { get; set; }
        public string Page { get; set; }
        public string Machine { get; set; }
        /// <summary>
        /// Finger Print of User's Device, language and Web Broswer
        /// Currently Using MD5 Hash : (userAgent + buildID + language + os + platform)
        /// </summary>
        //[Index(IsUnique = true)]
        //[StringLength(200)]
        public string DeviceHash { get; set; }
        /// <summary>
        /// Finger Print of User's Network
        /// Currently Using MD5 Hash : (IP,Country,Region,City,Zip/Postal code,Lat/Long,Metro code,Time zone)
        /// </summary>
        public string NetworkHash { get; set; }
        /// <summary>
        /// Finter Print of the User's Device + Network
        ///  Currently Using MD5 Hash : (DeviceHash + NetworkHash)
        /// </summary>
        public string UserHash { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastSeen { get; set; }
    }
}