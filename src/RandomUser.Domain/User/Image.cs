﻿using System;
namespace RandomUser.Domain.User
{
    public sealed class Image
    {
        public string DefaultLink { get; private set; }
        public string Thumbnail { get; private set; }

        public Image(string defaultLink)
        {
            if (defaultLink.Length == 0) throw new ShouldNotBeEmptyException("Image link is empty!");

            DefaultLink = defaultLink;
            Thumbnail = $"{defaultLink}--small";
        }

        //public override string ToString()
        //{
        //    return DefaultLink;
        //}

        //public static implicit operator string(Image image)
        //{
        //    return image.DefaultLink;
        //}

    }
}
