﻿using System.Collections.Generic;

namespace OpenNETCF.DreamFactory
{
    internal class ApplicationDescriptorList
    {
        public List<ApplicationDescriptor> record { get; set; }
    }

    internal class ApplicationDescriptor
    {
        public ApplicationDescriptor()
        {
        }

        public string id { get; set; }
        public string api_name { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public bool? is_url_external { get; set; }
        public bool? requires_fullscreen { get; set; }
        public bool? allow_fullscreen_toggle { get; set; }
        public string toggle_location { get; set; }
        public bool? is_default { get; set; }
    }
}
