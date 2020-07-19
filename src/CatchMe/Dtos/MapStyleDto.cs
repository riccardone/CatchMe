﻿using Naxam.Controls.Forms;
using Naxam.Mapbox.Layers;

namespace CatchMe.Dtos
{
    public class MapStyleDto
    {
        public string Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Owner
        {
            get;
            set;
        }

        public double[] Center
        {
            get;
            set;
        }

        public string UrlString
        {
            get;
            set;
        }

        public Layer[] layers { get; set; }
    }

    public static class Extensions
    {
        public static MapStyle DtoToModel(this MapStyleDto dto)
        {
            return new MapStyle
            {
                Id = dto.Id,
                Center = dto.Center,
                Name = dto.Name,
                Owner = dto.Owner,
            };
        }
    }
}
