namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class MapLayerDefaultsShapeSettings : JsonObject
    {
        public MapLayerDefaultsShapeSettings()
        {
            //>> Initialization
        
            Style = new MapLayerDefaultsShapeStyleSettings();
                
        //<< Initialization

            
        }

        

        //>> Fields
        
        public string Copyright { get; set; }
        
        public MapLayerDefaultsShapeStyleSettings Style
        {
            get;
            private set;
        }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Copyright.HasValue())
            {
                json["copyright"] = Copyright;
            }
            
            var style = Style.ToJson();
            if (style.Any())
            {
                json["style"] = style;
            }
                
        //<< Serialization
        }
    }
}
