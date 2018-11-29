using Newtonsoft.Json;
using System.Collections.Generic;

namespace InstaSharp.Models
{
    public class CarouselMedia
    {
        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public Image Images { get; set; }
        /// <summary>
        /// Gets or sets the videos.
        /// </summary>
        /// <value>
        /// The videos.
        /// </value>
        public Video Videos { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the users in photo.
        /// </summary>
        /// <value>
        /// The users in photo.
        /// </value>
        [JsonProperty("users_in_photo")]
        public List<UserInPhoto> UsersInPhoto { get; set; }
    }
}
