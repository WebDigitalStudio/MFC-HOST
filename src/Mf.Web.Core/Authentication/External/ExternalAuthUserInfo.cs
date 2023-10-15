﻿namespace Mf.Authentication.External
{
    public class ExternalAuthUserInfo
    {
        public string ProviderKey { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Surname { get; set; }
        
        public int Age { get; set; }
        
        public string Gender { get; set; }
        
        public string PreferendGender { get; set; }
        
        public string Location { get; set; }
        
        public string[] Interests { get; set; }

        public string Provider { get; set; }
    }
}
