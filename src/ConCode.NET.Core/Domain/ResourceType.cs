using System;

namespace ConCode.NET.Core.Domain
{
    public class ResourceType
    {
        public string Name { get; }
        public string IconUri { get; }

        private ResourceType(string name, string iconUri)
        {
            Name = name;
            IconUri = iconUri;
        }

        public static ResourceType PDF = new ResourceType("PDF", "~/images/file-types/pdf.png");
        public static ResourceType PPT = new ResourceType("PPT", "~/images/file-types/ppt.png");
    }
    
}